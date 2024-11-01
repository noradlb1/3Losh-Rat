using System;
using dnlib.DotNet;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200003C RID: 60
	public class PropertiesRenaming : IRenaming
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x0001C130 File Offset: 0x0001A330
		public ModuleDefMD Rename(ModuleDefMD module)
		{
			foreach (TypeDef typeDef in module.GetTypes())
			{
				if (!typeDef.IsGlobalModuleType)
				{
					foreach (PropertyDef propertyDef in typeDef.Properties)
					{
						propertyDef.Name = Utils.GenerateRandomString();
					}
				}
			}
			return module;
		}
	}
}
