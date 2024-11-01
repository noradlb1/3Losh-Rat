using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000033 RID: 51
	public class ClassesRenaming : IRenaming
	{
		// Token: 0x060001AD RID: 429 RVA: 0x0001AC78 File Offset: 0x00018E78
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "GeneratedInternalTypeHelper") && !(typeDef.Name == "Resources"))
				{
					string s;
					if (ClassesRenaming._names.TryGetValue(typeDef.Name, out s))
					{
						typeDef.Name = s;
					}
					else
					{
						string text = Utils.GenerateRandomString();
						ClassesRenaming._names.Add(typeDef.Name, text);
						typeDef.Name = text;
					}
				}
			}
			return ClassesRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001AD4C File Offset: 0x00018F4C
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (Resource resource in module.Resources)
			{
				foreach (KeyValuePair<string, string> keyValuePair in ClassesRenaming._names)
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
								foreach (KeyValuePair<string, string> keyValuePair2 in ClassesRenaming._names)
								{
									if (instructions[i].Operand.ToString().Contains(keyValuePair2.Key))
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

		// Token: 0x0400017C RID: 380
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
