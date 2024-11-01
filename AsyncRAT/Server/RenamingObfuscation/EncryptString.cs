using System;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation
{
	// Token: 0x0200002D RID: 45
	public static class EncryptString
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x0001A954 File Offset: 0x00018B54
		private static MethodDef InjectMethod(ModuleDef module, string methodName)
		{
			MethodDef result = (MethodDef)InjectHelper.Inject(ModuleDefMD.Load(typeof(DecryptionHelper).Module).ResolveTypeDef(MDToken.ToRID(typeof(DecryptionHelper).MetadataToken)), module.GlobalType, module).Single((IDnlibDef method) => method.Name == methodName);
			foreach (MethodDef methodDef in module.GlobalType.Methods)
			{
				if (methodDef.Name == ".ctor")
				{
					module.GlobalType.Remove(methodDef);
					break;
				}
			}
			return result;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000297D File Offset: 0x00000B7D
		public static void DoEncrypt(ModuleDef inPath)
		{
			EncryptString.EncryptStrings(inPath);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001AA20 File Offset: 0x00018C20
		private static ModuleDef EncryptStrings(ModuleDef inModule)
		{
			ICrypto crypto = new Base64();
			MethodDef methodDef = EncryptString.InjectMethod(inModule, "Decrypt_Base64");
			foreach (TypeDef typeDef in inModule.Types)
			{
				if (!typeDef.IsGlobalModuleType && !(typeDef.Name == "Resources") && !(typeDef.Name == "Settings"))
				{
					foreach (MethodDef methodDef2 in typeDef.Methods)
					{
						if (methodDef2.HasBody && methodDef2 != methodDef)
						{
							methodDef2.Body.KeepOldMaxStack = true;
							for (int i = 0; i < methodDef2.Body.Instructions.Count; i++)
							{
								if (methodDef2.Body.Instructions[i].OpCode == OpCodes.Ldstr)
								{
									string dataPlain = methodDef2.Body.Instructions[i].Operand.ToString();
									methodDef2.Body.Instructions[i].Operand = crypto.Encrypt(dataPlain);
									methodDef2.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, methodDef));
								}
							}
							methodDef2.Body.SimplifyBranches();
							methodDef2.Body.OptimizeBranches();
						}
					}
				}
			}
			return inModule;
		}
	}
}
