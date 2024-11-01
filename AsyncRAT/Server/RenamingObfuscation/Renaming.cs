using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Classes;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation
{
	// Token: 0x0200002F RID: 47
	public class Renaming
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		private static ModuleDefMD RenamingObfuscation(ModuleDefMD inModule)
		{
			ModuleDefMD module = ((IRenaming)new NamespacesRenaming()).Rename(inModule);
			module = ((IRenaming)new ClassesRenaming()).Rename(module);
			module = ((IRenaming)new MethodsRenaming()).Rename(module);
			module = ((IRenaming)new PropertiesRenaming()).Rename(module);
			return ((IRenaming)new FieldsRenaming()).Rename(module);
		}
	}
}
