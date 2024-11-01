using System;
using System.Reflection;

// Token: 0x020000A6 RID: 166
internal class Class0
{
	// Token: 0x06000475 RID: 1141 RVA: 0x000361F0 File Offset: 0x000343F0
	internal static void smethod_0(int typemdt)
	{
		Type type = Class0.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class0.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x040003C6 RID: 966
	internal static Module module_0 = typeof(Class0).Assembly.ManifestModule;

	// Token: 0x020000A7 RID: 167
	// (Invoke) Token: 0x06000479 RID: 1145
	internal delegate void Delegate0(object o);
}
