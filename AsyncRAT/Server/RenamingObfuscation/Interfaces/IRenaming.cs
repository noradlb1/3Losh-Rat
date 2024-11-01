using System;
using dnlib.DotNet;

namespace Server.RenamingObfuscation.Interfaces
{
	// Token: 0x02000031 RID: 49
	public interface IRenaming
	{
		// Token: 0x060001AA RID: 426
		ModuleDefMD Rename(ModuleDefMD module);
	}
}
