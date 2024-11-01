﻿using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Server.Helper
{
	// Token: 0x02000056 RID: 86
	public class ReferenceLoader : MarshalByRefObject
	{
		// Token: 0x060002CD RID: 717 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		public string[] LoadReferences(string assemblyPath)
		{
			string[] result;
			try
			{
				result = (from x in Assembly.ReflectionOnlyLoadFrom(assemblyPath).GetReferencedAssemblies()
				select x.FullName).ToArray<string>();
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001DF3C File Offset: 0x0001C13C
		public void AppDomainSetup(string assemblyPath)
		{
			try
			{
				AppDomainSetup info = new AppDomainSetup
				{
					ApplicationBase = AppDomain.CurrentDomain.BaseDirectory
				};
				AppDomain domain = AppDomain.CreateDomain(Guid.NewGuid().ToString(), null, info);
				((ReferenceLoader)Activator.CreateInstance(domain, typeof(ReferenceLoader).Assembly.FullName, typeof(ReferenceLoader).FullName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, null, CultureInfo.CurrentCulture, new object[0]).Unwrap()).LoadReferences(assemblyPath);
				AppDomain.Unload(domain);
			}
			catch
			{
			}
		}
	}
}
