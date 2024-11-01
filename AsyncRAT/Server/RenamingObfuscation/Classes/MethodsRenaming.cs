using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200003A RID: 58
	public class MethodsRenaming : IRenaming
	{
		// Token: 0x060001CC RID: 460 RVA: 0x0001BCB8 File Offset: 0x00019EB8
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.Types)
			{
				if (!typeDef.IsGlobalModuleType)
				{
					typeDef.Name = Utils.GenerateRandomString();
					foreach (MethodDef methodDef in typeDef.Methods)
					{
						if (!methodDef.IsSpecialName && !methodDef.IsConstructor && !methodDef.HasCustomAttributes && !methodDef.IsAbstract && !methodDef.IsVirtual && methodDef.Name != "Main")
						{
							methodDef.Name = Utils.GenerateRandomString();
						}
						foreach (ParamDef paramDef in methodDef.ParamDefs)
						{
							paramDef.Name = Utils.GenerateRandomString();
						}
					}
				}
			}
			return module;
		}
	}
}
