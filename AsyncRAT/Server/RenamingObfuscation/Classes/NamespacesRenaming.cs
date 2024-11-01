using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200003B RID: 59
	public class NamespacesRenaming : IRenaming
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0001BDFC File Offset: 0x00019FFC
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			module.Name = Utils.GenerateRandomString();
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Namespace == ""))
				{
					string s;
					if (NamespacesRenaming._names.TryGetValue(typeDef.Namespace, out s))
					{
						typeDef.Namespace = s;
					}
					else
					{
						string text = Utils.GenerateRandomString();
						NamespacesRenaming._names.Add(typeDef.Namespace, text);
						typeDef.Namespace = text;
					}
				}
			}
			return NamespacesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001BEC8 File Offset: 0x0001A0C8
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (Resource resource in module.Resources)
			{
				foreach (KeyValuePair<string, string> keyValuePair in NamespacesRenaming._names)
				{
					if (resource.Name.Contains(keyValuePair.Key))
					{
						resource.Name = resource.Name.Replace(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			foreach (TypeDef typeDef in module.GetTypes())
			{
				foreach (PropertyDef propertyDef in typeDef.Properties)
				{
					if (!(propertyDef.Name != "ResourceManager"))
					{
						IList<Instruction> instructions = propertyDef.GetMethod.Body.Instructions;
						for (int i = 0; i < instructions.Count; i++)
						{
							if (instructions[i].OpCode == OpCodes.Ldstr)
							{
								foreach (KeyValuePair<string, string> keyValuePair2 in NamespacesRenaming._names)
								{
									if (instructions[i].ToString().Contains(keyValuePair2.Key))
									{
										instructions[i].Operand = instructions[i].Operand.ToString().Replace(keyValuePair2.Key, keyValuePair2.Value);
									}
								}
							}
						}
					}
				}
			}
			return module;
		}

		// Token: 0x04000184 RID: 388
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
