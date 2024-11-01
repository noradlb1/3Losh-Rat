using System;
using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000035 RID: 53
	public class FieldsRenaming : IRenaming
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0001AFF0 File Offset: 0x000191F0
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (FieldDef fieldDef in typeDef.Fields)
					{
						string s;
						if (FieldsRenaming._names.TryGetValue(fieldDef.Name, out s))
						{
							fieldDef.Name = s;
						}
						else if (!fieldDef.IsSpecialName && !fieldDef.HasCustomAttributes)
						{
							string text = Utils.GenerateRandomString();
							FieldsRenaming._names.Add(fieldDef.Name, text);
							fieldDef.Name = text;
						}
					}
				}
			}
			return FieldsRenaming.ApplyChangesToResources(module);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001B0F0 File Offset: 0x000192F0
		private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (!(methodDef.Name != "InitializeComponent"))
						{
							IList<Instruction> instructions = methodDef.Body.Instructions;
							for (int i = 0; i < instructions.Count - 3; i++)
							{
								if (instructions[i].OpCode == OpCodes.Ldstr)
								{
									foreach (KeyValuePair<string, string> keyValuePair in FieldsRenaming._names)
									{
										if (keyValuePair.Key == instructions[i].Operand.ToString())
										{
											instructions[i].Operand = keyValuePair.Value;
										}
									}
								}
							}
						}
					}
				}
			}
			return module;
		}

		// Token: 0x0400017D RID: 381
		private static Dictionary<string, string> _names = new Dictionary<string, string>();
	}
}
