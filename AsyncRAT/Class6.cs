using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

// Token: 0x020000B9 RID: 185
internal class Class6
{
	// Token: 0x060004DD RID: 1245 RVA: 0x00004935 File Offset: 0x00002B35
	internal static object[] smethod_0()
	{
		return new object[1];
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x000377F8 File Offset: 0x000359F8
	internal static object[] smethod_1<T>(int int_1, object[] object_1, object object_2, ref T gparam_0)
	{
		Class6.Class12 @class = null;
		object obj = Class6.object_0;
		lock (obj)
		{
			if (!Class6.bool_0)
			{
				Class6.bool_0 = true;
				Class6.smethod_4();
			}
			if (Class6.class12_0[int_1] != null)
			{
				@class = Class6.class12_0[int_1];
			}
			else
			{
				Class6.binaryReader_0.BaseStream.Position = (long)Class6.int_0[int_1];
				@class = new Class6.Class12();
				Module module = typeof(Class6).Module;
				int metadataToken = Class6.smethod_6(Class6.binaryReader_0);
				int num = Class6.smethod_6(Class6.binaryReader_0);
				int num2 = Class6.smethod_6(Class6.binaryReader_0);
				int num3 = Class6.smethod_6(Class6.binaryReader_0);
				@class.methodBase_0 = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = @class.methodBase_0.GetParameters();
				@class.class8_0 = new Class6.Class8[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					Class6.Class8 class2 = new Class6.Class8();
					class2.UhNjdqxgic = type.IsByRef;
					class2.int_0 = i;
					@class.class8_0[i] = class2;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					Class6.Enum1 enum1_;
					if (type == typeof(string))
					{
						enum1_ = (Class6.Enum1)14;
					}
					else if (type == typeof(byte))
					{
						enum1_ = (Class6.Enum1)2;
					}
					else if (type == typeof(sbyte))
					{
						enum1_ = (Class6.Enum1)1;
					}
					else if (type == typeof(short))
					{
						enum1_ = (Class6.Enum1)3;
					}
					else if (type == typeof(ushort))
					{
						enum1_ = (Class6.Enum1)4;
					}
					else if (type == typeof(int))
					{
						enum1_ = (Class6.Enum1)5;
					}
					else if (type == typeof(uint))
					{
						enum1_ = (Class6.Enum1)6;
					}
					else if (type == typeof(long))
					{
						enum1_ = (Class6.Enum1)7;
					}
					else if (type == typeof(ulong))
					{
						enum1_ = (Class6.Enum1)8;
					}
					else if (type == typeof(float))
					{
						enum1_ = (Class6.Enum1)9;
					}
					else if (type == typeof(double))
					{
						enum1_ = (Class6.Enum1)10;
					}
					else if (type == typeof(bool))
					{
						enum1_ = (Class6.Enum1)11;
					}
					else if (type == typeof(IntPtr))
					{
						enum1_ = (Class6.Enum1)12;
					}
					else if (type == typeof(UIntPtr))
					{
						enum1_ = (Class6.Enum1)13;
					}
					else if (type == typeof(char))
					{
						enum1_ = (Class6.Enum1)15;
					}
					else
					{
						enum1_ = (Class6.Enum1)0;
					}
					class2.enum1_0 = enum1_;
				}
				@class.fBcjhfhonR = new List<Class6.Class9>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = Class6.smethod_6(Class6.binaryReader_0);
					Class6.Class9 class3 = new Class6.Class9();
					class3.type_0 = null;
					if (num4 >= 0 && num4 < 50)
					{
						class3.enum1_0 = (Class6.Enum1)(num4 & 31);
						class3.bool_0 = ((num4 & 32) > 0);
					}
					class3.int_0 = j;
					@class.fBcjhfhonR.Add(class3);
				}
				@class.list_1 = new List<Class6.Class10>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = Class6.smethod_6(Class6.binaryReader_0);
					int int_2 = Class6.smethod_6(Class6.binaryReader_0);
					Class6.Class10 class4 = new Class6.Class10();
					class4.int_0 = num5;
					class4.int_1 = int_2;
					Class6.Class11 class5 = new Class6.Class11();
					class4.class11_0 = class5;
					num5 = Class6.smethod_6(Class6.binaryReader_0);
					int_2 = Class6.smethod_6(Class6.binaryReader_0);
					int num6 = Class6.smethod_6(Class6.binaryReader_0);
					class5.int_0 = num5;
					class5.int_1 = int_2;
					class5.int_3 = num6;
					if (num6 == 0)
					{
						class5.type_0 = module.ResolveType(Class6.smethod_6(Class6.binaryReader_0));
					}
					else if (num6 == 1)
					{
						class5.int_2 = Class6.smethod_6(Class6.binaryReader_0);
					}
					else
					{
						Class6.smethod_6(Class6.binaryReader_0);
					}
					@class.list_1.Add(class4);
				}
				//@class.list_1.Sort(new Comparison<Class6.Class10>(Class6.Class32<T>.<>9.method_0));
				@class.list_0 = new List<Class6.Class7>(num3);
				for (int l = 0; l < num3; l++)
				{
					Class6.Class7 class6 = new Class6.Class7();
					byte b = Class6.binaryReader_0.ReadByte();
					class6.enum3_0 = (Class6.Enum3)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num7 = (int)Class6.byte_0[(int)b];
					if (num7 == 0)
					{
						class6.object_0 = null;
					}
					else
					{
						object obj2;
						switch (num7)
						{
						case 1:
							obj2 = Class6.smethod_6(Class6.binaryReader_0);
							break;
						case 2:
							obj2 = Class6.binaryReader_0.ReadInt64();
							break;
						case 3:
							obj2 = Class6.binaryReader_0.ReadSingle();
							break;
						case 4:
							obj2 = Class6.binaryReader_0.ReadDouble();
							break;
						case 5:
						{
							int num8 = Class6.smethod_6(Class6.binaryReader_0);
							int[] array = new int[num8];
							for (int m = 0; m < num8; m++)
							{
								array[m] = Class6.smethod_6(Class6.binaryReader_0);
							}
							obj2 = array;
							break;
						}
						default:
							throw new Exception();
						}
						class6.object_0 = obj2;
					}
					@class.list_0.Add(class6);
				}
				Class6.class12_0[int_1] = @class;
			}
		}
		Class6.Class15 class7 = new Class6.Class15();
		class7.class12_0 = @class;
		ParameterInfo[] parameters2 = @class.methodBase_0.GetParameters();
		bool flag2 = false;
		int num9 = 0;
		if (@class.methodBase_0 is MethodInfo && ((MethodInfo)@class.methodBase_0).ReturnType != typeof(void))
		{
			flag2 = true;
		}
		if (@class.methodBase_0.IsStatic)
		{
			class7.class17_0 = new Class6.Class17[parameters2.Length];
			for (int n = 0; n < parameters2.Length; n++)
			{
				Type parameterType = parameters2[n].ParameterType;
				class7.class17_0[n] = Class6.Class17.smethod_1(parameterType, object_1[n]);
				if (parameterType.IsByRef)
				{
					num9++;
				}
			}
		}
		else
		{
			class7.class17_0 = new Class6.Class17[parameters2.Length + 1];
			if (@class.methodBase_0.DeclaringType.IsValueType)
			{
				class7.class17_0[0] = new Class6.Class28(new Class6.Class29(object_2), @class.methodBase_0.DeclaringType);
			}
			else
			{
				class7.class17_0[0] = new Class6.Class29(object_2);
			}
			for (int num10 = 0; num10 < parameters2.Length; num10++)
			{
				Type parameterType2 = parameters2[num10].ParameterType;
				if (parameterType2.IsByRef)
				{
					class7.class17_0[num10 + 1] = Class6.Class17.smethod_1(parameterType2, object_1[num10]);
					num9++;
				}
				else
				{
					class7.class17_0[num10 + 1] = Class6.Class17.smethod_1(parameterType2, object_1[num10]);
				}
			}
		}
		class7.class17_1 = new Class6.Class17[@class.fBcjhfhonR.Count];
		for (int num11 = 0; num11 < @class.fBcjhfhonR.Count; num11++)
		{
			Class6.Class9 class8 = @class.fBcjhfhonR[num11];
			switch (class8.enum1_0)
			{
			case (Class6.Enum1)0:
				class7.class17_1[num11] = null;
				break;
			case (Class6.Enum1)1:
			case (Class6.Enum1)2:
			case (Class6.Enum1)3:
			case (Class6.Enum1)4:
			case (Class6.Enum1)5:
			case (Class6.Enum1)6:
			case (Class6.Enum1)11:
			case (Class6.Enum1)15:
				class7.class17_1[num11] = new Class6.Class19(0, class8.enum1_0);
				break;
			case (Class6.Enum1)7:
			case (Class6.Enum1)8:
				class7.class17_1[num11] = new Class6.Class20(0L, class8.enum1_0);
				break;
			case (Class6.Enum1)9:
			case (Class6.Enum1)10:
				class7.class17_1[num11] = new Class6.Class22(0.0, class8.enum1_0);
				break;
			case (Class6.Enum1)12:
				class7.class17_1[num11] = new Class6.Class21(IntPtr.Zero);
				break;
			case (Class6.Enum1)13:
				class7.class17_1[num11] = new Class6.Class21(UIntPtr.Zero);
				break;
			case (Class6.Enum1)14:
				class7.class17_1[num11] = null;
				break;
			case (Class6.Enum1)16:
				class7.class17_1[num11] = new Class6.Class29(null);
				break;
			}
		}
		try
		{
			class7.method_0();
		}
		finally
		{
			class7.method_1();
		}
		int num12 = 0;
		if (flag2)
		{
			num12 = 1;
		}
		num12 += num9;
		object[] array2 = new object[num12];
		if (flag2)
		{
			array2[0] = null;
		}
		if (@class.methodBase_0 is MethodInfo)
		{
			MethodInfo methodInfo = (MethodInfo)@class.methodBase_0;
			if (methodInfo.ReturnType != typeof(void) && class7.class17_2 != null)
			{
				array2[0] = class7.class17_2.vmethod_4(methodInfo.ReturnType);
			}
		}
		if (num9 > 0)
		{
			int num13 = 0;
			if (flag2)
			{
				num13++;
			}
			for (int num14 = 0; num14 < parameters2.Length; num14++)
			{
				Type type2 = parameters2[num14].ParameterType;
				if (type2.IsByRef)
				{
					type2 = type2.GetElementType();
					if (class7.class17_0[num14] != null)
					{
						if (@class.methodBase_0.IsStatic)
						{
							array2[num13] = class7.class17_0[num14].vmethod_4(type2);
						}
						else
						{
							array2[num13] = class7.class17_0[num14 + 1].vmethod_4(type2);
						}
					}
					else
					{
						array2[num13] = null;
					}
					num13++;
				}
			}
		}
		if (!@class.methodBase_0.IsStatic && @class.methodBase_0.DeclaringType.IsValueType)
		{
			gparam_0 = (T)((object)class7.class17_0[0].vmethod_4(@class.methodBase_0.DeclaringType));
		}
		return array2;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x000381D8 File Offset: 0x000363D8
	internal static object[] smethod_2(int int_1, object[] object_1, object object_2)
	{
		int num = 0;
		return Class6.smethod_1<int>(int_1, object_1, object_2, ref num);
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x0000493D File Offset: 0x00002B3D
	internal static object[] smethod_3<T>(int int_1, object[] object_1, ref T gparam_0)
	{
		return Class6.smethod_1<T>(int_1, object_1, gparam_0, ref gparam_0);
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x000381F4 File Offset: 0x000363F4
	internal static void smethod_4()
	{
		if (Class6.int_0 == null)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class6).Assembly.GetManifestResourceStream("rkSnLvdbQ87VMf0OOx.EXh8ovRislcLGxGYEn"));
			binaryReader.BaseStream.Position = 0L;
			byte[] byte_ = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			Class6.smethod_5(byte_);
		}
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00038258 File Offset: 0x00036458
	internal static void smethod_5(byte[] byte_1)
	{
		Class6.binaryReader_0 = new BinaryReader(new MemoryStream(byte_1));
		Class6.byte_0 = new byte[255];
		int num = Class6.smethod_6(Class6.binaryReader_0);
		for (int i = 0; i < num; i++)
		{
			int num2 = (int)Class6.binaryReader_0.ReadByte();
			Class6.byte_0[num2] = Class6.binaryReader_0.ReadByte();
		}
		num = Class6.smethod_6(Class6.binaryReader_0);
		Class6.list_0 = new List<string>(num);
		for (int j = 0; j < num; j++)
		{
			Class6.list_0.Add(Encoding.Unicode.GetString(Class6.binaryReader_0.ReadBytes(Class6.smethod_6(Class6.binaryReader_0))));
		}
		num = Class6.smethod_6(Class6.binaryReader_0);
		Class6.class12_0 = new Class6.Class12[num];
		Class6.int_0 = new int[num];
		for (int k = 0; k < num; k++)
		{
			Class6.class12_0[k] = null;
			Class6.int_0[k] = Class6.smethod_6(Class6.binaryReader_0);
		}
		int num3 = (int)Class6.binaryReader_0.BaseStream.Position;
		for (int l = 0; l < num; l++)
		{
			int num4 = Class6.int_0[l];
			Class6.int_0[l] = num3;
			num3 += num4;
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x0003838C File Offset: 0x0003658C
	internal static int smethod_6(BinaryReader binaryReader_1)
	{
		bool flag = false;
		uint num = (uint)binaryReader_1.ReadByte();
		uint num2 = 0U | (num & 63U);
		if ((num & 64U) != 0U)
		{
			flag = true;
		}
		if (num < 128U)
		{
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
		else
		{
			int num3 = 0;
			for (;;)
			{
				uint num4 = (uint)binaryReader_1.ReadByte();
				num2 |= (num4 & 127U) << 7 * num3 + 6;
				if (num4 < 128U)
				{
					break;
				}
				num3++;
			}
			if (flag)
			{
				return (int)(~(int)num2);
			}
			return (int)num2;
		}
	}

	// Token: 0x040003F4 RID: 1012
	internal static Class6.Class12[] class12_0 = null;

	// Token: 0x040003F5 RID: 1013
	internal static int[] int_0 = null;

	// Token: 0x040003F6 RID: 1014
	internal static List<string> list_0;

	// Token: 0x040003F7 RID: 1015
	private static BinaryReader binaryReader_0;

	// Token: 0x040003F8 RID: 1016
	private static byte[] byte_0;

	// Token: 0x040003F9 RID: 1017
	private static bool bool_0 = false;

	// Token: 0x040003FA RID: 1018
	private static object object_0 = new object();

	// Token: 0x020000BA RID: 186
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct4
	{
		// Token: 0x040003FB RID: 1019
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x040003FC RID: 1020
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x040003FD RID: 1021
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x040003FE RID: 1022
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x040003FF RID: 1023
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000400 RID: 1024
		[FieldOffset(0)]
		public int int_0;
	}

	// Token: 0x020000BB RID: 187
	private class Class19 : Class6.Class18
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00004970 File Offset: 0x00002B70
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.struct4_0 = ((Class6.Class19)class17_0).struct4_0;
			this.enum1_0 = ((Class6.Class19)class17_0).enum1_0;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000499D File Offset: 0x00002B9D
		public Class19(bool bool_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			if (bool_0)
			{
				this.struct4_0.int_0 = 1;
			}
			else
			{
				this.struct4_0.int_0 = 0;
			}
			this.enum1_0 = (Class6.Enum1)11;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x000049D1 File Offset: 0x00002BD1
		public Class19(Class6.Class19 class19_0)
		{
			this.enum4_0 = class19_0.enum4_0;
			this.struct4_0.int_0 = class19_0.struct4_0.int_0;
			this.enum1_0 = class19_0.enum1_0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00004A07 File Offset: 0x00002C07
		public override Class6.Class18 vmethod_71()
		{
			return new Class6.Class19(this);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00004A0F File Offset: 0x00002C0F
		public Class19(int int_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct4_0.int_0 = int_0;
			this.enum1_0 = (Class6.Enum1)5;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00004A31 File Offset: 0x00002C31
		public Class19(uint uint_0)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct4_0.uint_0 = uint_0;
			this.enum1_0 = (Class6.Enum1)6;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00004A53 File Offset: 0x00002C53
		public Class19(int int_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct4_0.int_0 = int_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004A75 File Offset: 0x00002C75
		public Class19(uint uint_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)1;
			this.struct4_0.uint_0 = uint_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000383F4 File Offset: 0x000365F4
		public override bool vmethod_10()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
			case (Class6.Enum1)7:
				goto IL_46;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
			case (Class6.Enum1)6:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_46;
				}
				if (@enum == (Class6.Enum1)15)
				{
					goto IL_46;
				}
				break;
			}
			return this.struct4_0.uint_0 == 0U;
			IL_46:
			return this.struct4_0.int_0 == 0;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004A97 File Offset: 0x00002C97
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00038458 File Offset: 0x00036658
		public override Class6.Class17 vmethod_12(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_14();
			case (Class6.Enum1)2:
				return this.vmethod_15();
			case (Class6.Enum1)3:
				return this.vmethod_16();
			case (Class6.Enum1)4:
				return this.vmethod_17();
			case (Class6.Enum1)5:
				return this.vmethod_18();
			case (Class6.Enum1)6:
				return this.vmethod_19();
			case (Class6.Enum1)11:
				return this.vmethod_13();
			case (Class6.Enum1)15:
				return this.method_6();
			case (Class6.Enum1)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00038504 File Offset: 0x00036704
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 != null && Nullable.GetUnderlyingType(type_0) != null)
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class6.Enum1)1:
					return this.struct4_0.sbyte_0;
				case (Class6.Enum1)2:
					return this.struct4_0.byte_0;
				case (Class6.Enum1)3:
					return this.struct4_0.short_0;
				case (Class6.Enum1)4:
					return this.struct4_0.ushort_0;
				case (Class6.Enum1)5:
					return this.struct4_0.int_0;
				case (Class6.Enum1)6:
					return this.struct4_0.uint_0;
				case (Class6.Enum1)7:
					return (long)this.struct4_0.int_0;
				case (Class6.Enum1)8:
					return (ulong)this.struct4_0.uint_0;
				case (Class6.Enum1)11:
					return this.vmethod_11();
				case (Class6.Enum1)15:
					return (char)this.struct4_0.int_0;
				}
				return this.struct4_0.int_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct4_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct4_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct4_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct4_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct4_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct4_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return (long)this.struct4_0.int_0;
			}
			if (type_0 == typeof(ulong))
			{
				return (ulong)this.struct4_0.uint_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct4_0.int_0;
			}
			if (type_0 == typeof(IntPtr))
			{
				return new IntPtr(this.struct4_0.int_0);
			}
			if (type_0 == typeof(UIntPtr))
			{
				return new UIntPtr(this.struct4_0.uint_0);
			}
			if (!type_0.IsEnum)
			{
				throw new Class6.Exception1();
			}
			return this.method_5(type_0);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00038838 File Offset: 0x00036A38
		internal object method_5(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct4_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct4_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct4_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct4_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct4_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct4_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, (long)this.struct4_0.int_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, (ulong)this.struct4_0.uint_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct4_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct4_0.int_0);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004AB5 File Offset: 0x00002CB5
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00004ABD File Offset: 0x00002CBD
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((int)this.struct4_0.sbyte_0, (Class6.Enum1)1);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public Class6.Class19 method_6()
		{
			return new Class6.Class19(this.struct4_0.int_0, (Class6.Enum1)15);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004AE4 File Offset: 0x00002CE4
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((uint)this.struct4_0.byte_0, (Class6.Enum1)2);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004AF7 File Offset: 0x00002CF7
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((int)this.struct4_0.short_0, (Class6.Enum1)3);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004B0A File Offset: 0x00002D0A
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19((uint)this.struct4_0.ushort_0, (Class6.Enum1)4);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004B1D File Offset: 0x00002D1D
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19(this.struct4_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004B30 File Offset: 0x00002D30
		public override Class6.Class19 vmethod_19()
		{
			return new Class6.Class19(this.struct4_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004B43 File Offset: 0x00002D43
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20((long)this.struct4_0.int_0, (Class6.Enum1)7);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004B57 File Offset: 0x00002D57
		public override Class6.Class20 vmethod_21()
		{
			return new Class6.Class20((ulong)this.struct4_0.uint_0, (Class6.Enum1)8);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004B6B File Offset: 0x00002D6B
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004B73 File Offset: 0x00002D73
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004B7B File Offset: 0x00002D7B
		public override Class6.Class19 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00004B83 File Offset: 0x00002D83
		public override Class6.Class20 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00004B8B File Offset: 0x00002D8B
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004B93 File Offset: 0x00002D93
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004B9B File Offset: 0x00002D9B
		public override Class6.Class19 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004BA3 File Offset: 0x00002DA3
		public override Class6.Class20 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004BAB File Offset: 0x00002DAB
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct4_0.int_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00004BBF File Offset: 0x00002DBF
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct4_0.uint_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00004BD3 File Offset: 0x00002DD3
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.struct4_0.int_0)), (Class6.Enum1)3);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public override Class6.Class19 usfdqHavse()
		{
			return new Class6.Class19((int)(checked((short)this.struct4_0.uint_0)), (Class6.Enum1)3);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00004B1D File Offset: 0x00002D1D
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(this.struct4_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00004BFB File Offset: 0x00002DFB
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.struct4_0.uint_0), (Class6.Enum1)5);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00004B43 File Offset: 0x00002D43
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20((long)this.struct4_0.int_0, (Class6.Enum1)7);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00004C0F File Offset: 0x00002E0F
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20((long)((ulong)this.struct4_0.uint_0), (Class6.Enum1)7);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004C23 File Offset: 0x00002E23
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.struct4_0.int_0)), (Class6.Enum1)2);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00004C37 File Offset: 0x00002E37
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.struct4_0.uint_0)), (Class6.Enum1)2);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00004C4B File Offset: 0x00002E4B
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct4_0.int_0)), (Class6.Enum1)4);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00004C5F File Offset: 0x00002E5F
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct4_0.uint_0)), (Class6.Enum1)4);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00004C73 File Offset: 0x00002E73
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.struct4_0.int_0), (Class6.Enum1)6);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00004B30 File Offset: 0x00002D30
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(this.struct4_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004C87 File Offset: 0x00002E87
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.struct4_0.int_0), (Class6.Enum1)8);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00004B57 File Offset: 0x00002D57
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20((ulong)this.struct4_0.uint_0, (Class6.Enum1)8);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004C9B File Offset: 0x00002E9B
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.struct4_0.int_0);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004CAE File Offset: 0x00002EAE
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22((double)this.struct4_0.int_0);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004CC1 File Offset: 0x00002EC1
		public override Class6.Class22 vmethod_47()
		{
			return new Class6.Class22(this.struct4_0.uint_0);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_25().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_24().struct4_0.int_0);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004D0B File Offset: 0x00002F0B
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_29().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_28().struct4_0.uint_0);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004D41 File Offset: 0x00002F41
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct4_0.int_0);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct4_0.uint_0);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00004DAD File Offset: 0x00002FAD
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct4_0.int_0);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00004DE3 File Offset: 0x00002FE3
		public override Class6.Class21 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct4_0.uint_0);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000389A4 File Offset: 0x00036BA4
		public override Class6.Class17 vmethod_54()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
				goto IL_43;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_43;
				}
				if (@enum == (Class6.Enum1)15)
				{
					goto IL_43;
				}
				break;
			}
			return new Class6.Class19((int)(-(int)((ulong)this.struct4_0.uint_0)));
			IL_43:
			return new Class6.Class19(-this.struct4_0.int_0);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00038A08 File Offset: 0x00036C08
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 + ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).Add(this);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00038A6C File Offset: 0x00036C6C
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.int_0 + ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_55(this);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00038AD0 File Offset: 0x00036CD0
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.uint_0 + ((Class6.Class19)class17_0).struct4_0.uint_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_56(this);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00038B34 File Offset: 0x00036D34
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 - ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_7(this);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00038B98 File Offset: 0x00036D98
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.int_0 - ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_8(this);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00038BFC File Offset: 0x00036DFC
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.uint_0 - ((Class6.Class19)class17_0).struct4_0.uint_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_9(this);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00038C60 File Offset: 0x00036E60
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 * ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_60(this);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00038CC4 File Offset: 0x00036EC4
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.int_0 * ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_61(this);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00038D28 File Offset: 0x00036F28
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(checked(this.struct4_0.uint_0 * ((Class6.Class19)class17_0).struct4_0.uint_0));
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_62(this);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00038D8C File Offset: 0x00036F8C
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 / ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_10(this);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00038DF0 File Offset: 0x00036FF0
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.uint_0 / ((Class6.Class19)class17_0).struct4_0.uint_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_11(this);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00038E54 File Offset: 0x00037054
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 % ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_12(this);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00038EB8 File Offset: 0x000370B8
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.uint_0 % ((Class6.Class19)class17_0).struct4_0.uint_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).yIwByEsukh(this);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00038F1C File Offset: 0x0003711C
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 & ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_67(this);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00038F80 File Offset: 0x00037180
		public override Class6.Class17 vmethod_68(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 | ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_68(this);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00004E19 File Offset: 0x00003019
		public override Class6.Class17 vmethod_69()
		{
			return new Class6.Class19(~this.struct4_0.int_0);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00038FE4 File Offset: 0x000371E4
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 ^ ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_70(this);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00039048 File Offset: 0x00037248
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 << ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_15(this);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000390AC File Offset: 0x000372AC
		public override Class6.Class17 vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.int_0 >> ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_14(this);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00039110 File Offset: 0x00037310
		public override Class6.Class17 vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return new Class6.Class19(this.struct4_0.uint_0 >> ((Class6.Class19)class17_0).struct4_0.int_0);
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).method_13(this);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00039174 File Offset: 0x00037374
		public override string ToString()
		{
			Class6.Enum1 @enum = this.enum1_0;
			switch (@enum)
			{
			case (Class6.Enum1)1:
			case (Class6.Enum1)3:
			case (Class6.Enum1)5:
				goto IL_3B;
			case (Class6.Enum1)2:
			case (Class6.Enum1)4:
				break;
			default:
				if (@enum == (Class6.Enum1)11)
				{
					goto IL_3B;
				}
				break;
			}
			return this.struct4_0.uint_0.ToString();
			IL_3B:
			return this.struct4_0.int_0.ToString();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00004E2C File Offset: 0x0000302C
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000391CC File Offset: 0x000373CC
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return ((Class6.Class29)class17_0).vmethod_5(this);
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct4_0.int_0 == ((Class6.Class19)@class).struct4_0.int_0;
			}
			return ((Class6.Class21)@class).vmethod_5(this);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00039250 File Offset: 0x00037450
		private static Class6.Class18 smethod_4(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.vmethod_0())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0003927C File Offset: 0x0003747C
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).BeouTiljCp(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_3())
			{
				return false;
			}
			if (@class.method_1())
			{
				return this.struct4_0.uint_0 != ((Class6.Class19)@class).struct4_0.uint_0;
			}
			return ((Class6.Class21)@class).BeouTiljCp(this);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000392F8 File Offset: 0x000374F8
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.int_0 >= ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_78(this);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00039358 File Offset: 0x00037558
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.uint_0 >= ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_79(this);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000393B8 File Offset: 0x000375B8
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.int_0 > ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_80(this);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00039418 File Offset: 0x00037618
		public override bool lwlumgaheq(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.uint_0 > ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_81(this);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00039478 File Offset: 0x00037678
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.int_0 <= ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_75(this);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000394D8 File Offset: 0x000376D8
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.uint_0 <= ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_76(this);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00039538 File Offset: 0x00037738
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.int_0 < ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).vmethod_77(this);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00039598 File Offset: 0x00037798
		public override bool vmethod_81(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				return this.struct4_0.uint_0 < ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			if (!class17_0.method_2())
			{
				throw new Class6.Exception1();
			}
			return ((Class6.Class21)class17_0).lwlumgaheq(this);
		}

		// Token: 0x04000401 RID: 1025
		public Class6.Struct4 struct4_0;

		// Token: 0x04000402 RID: 1026
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x020000BC RID: 188
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct5
	{
		// Token: 0x04000403 RID: 1027
		[FieldOffset(0)]
		public byte byte_0;

		// Token: 0x04000404 RID: 1028
		[FieldOffset(0)]
		public sbyte sbyte_0;

		// Token: 0x04000405 RID: 1029
		[FieldOffset(0)]
		public ushort ushort_0;

		// Token: 0x04000406 RID: 1030
		[FieldOffset(0)]
		public short short_0;

		// Token: 0x04000407 RID: 1031
		[FieldOffset(0)]
		public uint uint_0;

		// Token: 0x04000408 RID: 1032
		[FieldOffset(0)]
		public int int_0;

		// Token: 0x04000409 RID: 1033
		[FieldOffset(0)]
		public ulong ulong_0;

		// Token: 0x0400040A RID: 1034
		[FieldOffset(0)]
		public long long_0;
	}

	// Token: 0x020000BD RID: 189
	private class Class20 : Class6.Class18
	{
		// Token: 0x06000543 RID: 1347 RVA: 0x00004E2F File Offset: 0x0000302F
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.struct5_0 = ((Class6.Class20)class17_0).struct5_0;
			this.enum1_0 = ((Class6.Class20)class17_0).enum1_0;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00004E53 File Offset: 0x00003053
		public Class20(long long_0)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct5_0.long_0 = long_0;
			this.enum1_0 = (Class6.Enum1)7;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00004E75 File Offset: 0x00003075
		public Class20(Class6.Class20 class20_0)
		{
			this.enum4_0 = class20_0.enum4_0;
			this.struct5_0.long_0 = class20_0.struct5_0.long_0;
			this.enum1_0 = class20_0.enum1_0;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00004EAB File Offset: 0x000030AB
		public override Class6.Class18 vmethod_71()
		{
			return new Class6.Class20(this);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00004EB3 File Offset: 0x000030B3
		public Class20(long long_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct5_0.long_0 = long_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00004ED5 File Offset: 0x000030D5
		public Class20(ulong ulong_0)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct5_0.ulong_0 = ulong_0;
			this.enum1_0 = (Class6.Enum1)8;
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00004EF7 File Offset: 0x000030F7
		public Class20(ulong ulong_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)2;
			this.struct5_0.ulong_0 = ulong_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00004F19 File Offset: 0x00003119
		public override bool vmethod_10()
		{
			if (this.enum1_0 == (Class6.Enum1)7)
			{
				return this.struct5_0.long_0 == 0L;
			}
			return this.struct5_0.ulong_0 == 0UL;
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00004A97 File Offset: 0x00002C97
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000395F8 File Offset: 0x000377F8
		public override Class6.Class17 vmethod_12(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_14();
			case (Class6.Enum1)2:
				return this.vmethod_15();
			case (Class6.Enum1)3:
				return this.vmethod_16();
			case (Class6.Enum1)4:
				return this.vmethod_17();
			case (Class6.Enum1)5:
				return this.vmethod_18();
			case (Class6.Enum1)6:
				return this.vmethod_19();
			case (Class6.Enum1)7:
				return this.vmethod_20();
			case (Class6.Enum1)8:
				return this.vmethod_21();
			case (Class6.Enum1)11:
				return this.vmethod_13();
			case (Class6.Enum1)15:
				return this.method_6();
			case (Class6.Enum1)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000396B0 File Offset: 0x000378B0
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == null || type_0 == typeof(object))
			{
				switch (this.enum1_0)
				{
				case (Class6.Enum1)1:
					return this.struct5_0.sbyte_0;
				case (Class6.Enum1)2:
					return this.struct5_0.byte_0;
				case (Class6.Enum1)3:
					return this.struct5_0.short_0;
				case (Class6.Enum1)4:
					return this.struct5_0.ushort_0;
				case (Class6.Enum1)5:
					return this.struct5_0.int_0;
				case (Class6.Enum1)6:
					return this.struct5_0.uint_0;
				case (Class6.Enum1)7:
					return this.struct5_0.long_0;
				case (Class6.Enum1)8:
					return this.struct5_0.ulong_0;
				case (Class6.Enum1)11:
					return this.vmethod_11();
				case (Class6.Enum1)15:
					return (char)this.struct5_0.int_0;
				}
				return this.struct5_0.long_0;
			}
			if (type_0 == typeof(int))
			{
				return this.struct5_0.int_0;
			}
			if (type_0 == typeof(uint))
			{
				return this.struct5_0.uint_0;
			}
			if (type_0 == typeof(short))
			{
				return this.struct5_0.short_0;
			}
			if (type_0 == typeof(ushort))
			{
				return this.struct5_0.ushort_0;
			}
			if (type_0 == typeof(byte))
			{
				return this.struct5_0.byte_0;
			}
			if (type_0 == typeof(sbyte))
			{
				return this.struct5_0.sbyte_0;
			}
			if (type_0 == typeof(bool))
			{
				return !this.vmethod_10();
			}
			if (type_0 == typeof(long))
			{
				return this.struct5_0.long_0;
			}
			if (type_0 == typeof(ulong))
			{
				return this.struct5_0.ulong_0;
			}
			if (type_0 == typeof(char))
			{
				return (char)this.struct5_0.long_0;
			}
			if (!type_0.IsEnum)
			{
				throw new Class6.Exception1();
			}
			return this.method_5(type_0);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00039970 File Offset: 0x00037B70
		internal object method_5(Type type_0)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			if (underlyingType == typeof(int))
			{
				return Enum.ToObject(type_0, this.struct5_0.int_0);
			}
			if (underlyingType == typeof(uint))
			{
				return Enum.ToObject(type_0, this.struct5_0.uint_0);
			}
			if (underlyingType == typeof(short))
			{
				return Enum.ToObject(type_0, this.struct5_0.short_0);
			}
			if (underlyingType == typeof(ushort))
			{
				return Enum.ToObject(type_0, this.struct5_0.ushort_0);
			}
			if (underlyingType == typeof(byte))
			{
				return Enum.ToObject(type_0, this.struct5_0.byte_0);
			}
			if (underlyingType == typeof(sbyte))
			{
				return Enum.ToObject(type_0, this.struct5_0.sbyte_0);
			}
			if (underlyingType == typeof(long))
			{
				return Enum.ToObject(type_0, this.struct5_0.long_0);
			}
			if (underlyingType == typeof(ulong))
			{
				return Enum.ToObject(type_0, this.struct5_0.ulong_0);
			}
			if (underlyingType == typeof(char))
			{
				return Enum.ToObject(type_0, (ushort)this.struct5_0.int_0);
			}
			return Enum.ToObject(type_0, this.struct5_0.long_0);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19(this.vmethod_10() ? 0 : 1);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00004AB5 File Offset: 0x00002CB5
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00004F51 File Offset: 0x00003151
		public Class6.Class19 method_6()
		{
			return new Class6.Class19((int)this.struct5_0.sbyte_0, (Class6.Enum1)15);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00004F65 File Offset: 0x00003165
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((int)this.struct5_0.sbyte_0, (Class6.Enum1)1);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00004F78 File Offset: 0x00003178
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((uint)this.struct5_0.byte_0, (Class6.Enum1)2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00004F8B File Offset: 0x0000318B
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((int)this.struct5_0.short_0, (Class6.Enum1)3);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00004F9E File Offset: 0x0000319E
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19((uint)this.struct5_0.ushort_0, (Class6.Enum1)4);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00004FB1 File Offset: 0x000031B1
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19(this.struct5_0.int_0, (Class6.Enum1)5);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00004FC4 File Offset: 0x000031C4
		public override Class6.Class19 vmethod_19()
		{
			return new Class6.Class19(this.struct5_0.uint_0, (Class6.Enum1)6);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00004FD7 File Offset: 0x000031D7
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20(this.struct5_0.long_0, (Class6.Enum1)7);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00004FEA File Offset: 0x000031EA
		public override Class6.Class20 vmethod_21()
		{
			return new Class6.Class20(this.struct5_0.ulong_0, (Class6.Enum1)8);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00004B6B File Offset: 0x00002D6B
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00004B73 File Offset: 0x00002D73
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00004B7B File Offset: 0x00002D7B
		public override Class6.Class19 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00004B83 File Offset: 0x00002D83
		public override Class6.Class20 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00004B8B File Offset: 0x00002D8B
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00004B93 File Offset: 0x00002D93
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00004B9B File Offset: 0x00002D9B
		public override Class6.Class19 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00004BA3 File Offset: 0x00002DA3
		public override Class6.Class20 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00004FFD File Offset: 0x000031FD
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct5_0.long_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00005011 File Offset: 0x00003211
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((sbyte)this.struct5_0.ulong_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00005025 File Offset: 0x00003225
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.struct5_0.long_0)), (Class6.Enum1)3);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00005039 File Offset: 0x00003239
		public override Class6.Class19 usfdqHavse()
		{
			return new Class6.Class19((int)(checked((short)this.struct5_0.ulong_0)), (Class6.Enum1)3);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000504D File Offset: 0x0000324D
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(checked((int)this.struct5_0.long_0), (Class6.Enum1)5);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00005061 File Offset: 0x00003261
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.struct5_0.ulong_0), (Class6.Enum1)5);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00004FD7 File Offset: 0x000031D7
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20(this.struct5_0.long_0, (Class6.Enum1)7);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00005075 File Offset: 0x00003275
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20(checked((long)this.struct5_0.ulong_0), (Class6.Enum1)7);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00005089 File Offset: 0x00003289
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.struct5_0.long_0)), (Class6.Enum1)2);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000509D File Offset: 0x0000329D
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.struct5_0.ulong_0)), (Class6.Enum1)2);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000050B1 File Offset: 0x000032B1
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct5_0.long_0)), (Class6.Enum1)4);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000050C5 File Offset: 0x000032C5
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.struct5_0.ulong_0)), (Class6.Enum1)4);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000050D9 File Offset: 0x000032D9
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.struct5_0.long_0), (Class6.Enum1)6);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x000050ED File Offset: 0x000032ED
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(checked((uint)this.struct5_0.ulong_0), (Class6.Enum1)6);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00005101 File Offset: 0x00003301
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.struct5_0.long_0), (Class6.Enum1)8);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00004FEA File Offset: 0x000031EA
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20(this.struct5_0.ulong_0, (Class6.Enum1)8);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00005115 File Offset: 0x00003315
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.struct5_0.long_0);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00005128 File Offset: 0x00003328
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22((double)this.struct5_0.long_0);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000513B File Offset: 0x0000333B
		public override Class6.Class22 vmethod_47()
		{
			return new Class6.Class22(this.struct5_0.ulong_0);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_25().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_24().struct4_0.int_0);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00004D0B File Offset: 0x00002F0B
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_29().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_28().struct4_0.uint_0);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00004D41 File Offset: 0x00002F41
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct4_0.int_0);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct4_0.uint_0);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004DAD File Offset: 0x00002FAD
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct4_0.int_0);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000514F File Offset: 0x0000334F
		public override Class6.Class21 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)(checked((uint)this.struct5_0.ulong_0)));
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000517C File Offset: 0x0000337C
		public override Class6.Class17 vmethod_54()
		{
			return new Class6.Class20(-this.struct5_0.long_0);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00039ADC File Offset: 0x00037CDC
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 + ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00039B28 File Offset: 0x00037D28
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.long_0 + ((Class6.Class20)class17_0).struct5_0.long_0));
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00039B74 File Offset: 0x00037D74
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.ulong_0 + ((Class6.Class20)class17_0).struct5_0.ulong_0));
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00039BC0 File Offset: 0x00037DC0
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 - ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00039C0C File Offset: 0x00037E0C
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.long_0 - ((Class6.Class20)class17_0).struct5_0.long_0));
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00039C58 File Offset: 0x00037E58
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.ulong_0 - ((Class6.Class20)class17_0).struct5_0.ulong_0));
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00039CA4 File Offset: 0x00037EA4
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 * ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00039CF0 File Offset: 0x00037EF0
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.long_0 * ((Class6.Class20)class17_0).struct5_0.long_0));
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00039D3C File Offset: 0x00037F3C
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(checked(this.struct5_0.ulong_0 * ((Class6.Class20)class17_0).struct5_0.ulong_0));
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00039D88 File Offset: 0x00037F88
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 / ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00039DD4 File Offset: 0x00037FD4
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.ulong_0 / ((Class6.Class20)class17_0).struct5_0.ulong_0);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00039E20 File Offset: 0x00038020
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 % ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00039E6C File Offset: 0x0003806C
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.ulong_0 % ((Class6.Class20)class17_0).struct5_0.ulong_0);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00039EB8 File Offset: 0x000380B8
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 & ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x00039F04 File Offset: 0x00038104
		public override Class6.Class17 vmethod_68(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 | ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000518F File Offset: 0x0000338F
		public override Class6.Class17 vmethod_69()
		{
			return new Class6.Class20(~this.struct5_0.long_0);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00039F50 File Offset: 0x00038150
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 ^ ((Class6.Class20)class17_0).struct5_0.long_0);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x00039F9C File Offset: 0x0003819C
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct5_0.long_0 << ((Class6.Class20)class17_0).struct5_0.int_0);
			}
			if (!class17_0.vmethod_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 << ((Class6.Class18)class17_0).vmethod_18().struct4_0.int_0);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0003A020 File Offset: 0x00038220
		public override Class6.Class17 vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct5_0.long_0 >> ((Class6.Class20)class17_0).struct5_0.int_0);
			}
			if (!class17_0.vmethod_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.long_0 >> ((Class6.Class18)class17_0).vmethod_18().struct4_0.int_0);
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0003A0A4 File Offset: 0x000382A4
		public override Class6.Class17 vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_3())
			{
				return new Class6.Class20(this.struct5_0.ulong_0 >> ((Class6.Class20)class17_0).struct5_0.int_0);
			}
			if (!class17_0.vmethod_3())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class20(this.struct5_0.ulong_0 >> ((Class6.Class18)class17_0).vmethod_18().struct4_0.int_0);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x000051A2 File Offset: 0x000033A2
		public override string ToString()
		{
			if (this.enum1_0 == (Class6.Enum1)7)
			{
				return this.struct5_0.long_0.ToString();
			}
			return this.struct5_0.ulong_0.ToString();
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00004E2C File Offset: 0x0000302C
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0003A128 File Offset: 0x00038328
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return ((Class6.Class29)class17_0).vmethod_5(this);
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_3() && this.struct5_0.long_0 == ((Class6.Class20)@class).struct5_0.long_0;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x00039250 File Offset: 0x00037450
		private static Class6.Class18 smethod_4(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.vmethod_0())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0003A190 File Offset: 0x00038390
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).BeouTiljCp(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_3() && this.struct5_0.ulong_0 != ((Class6.Class20)@class).struct5_0.ulong_0;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x000051CE File Offset: 0x000033CE
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.long_0 >= ((Class6.Class20)class17_0).struct5_0.long_0;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000520E File Offset: 0x0000340E
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.ulong_0 >= ((Class6.Class20)class17_0).struct5_0.ulong_0;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000524E File Offset: 0x0000344E
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.long_0 > ((Class6.Class20)class17_0).struct5_0.long_0;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000528B File Offset: 0x0000348B
		public override bool lwlumgaheq(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.ulong_0 > ((Class6.Class20)class17_0).struct5_0.ulong_0;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000052C8 File Offset: 0x000034C8
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.long_0 <= ((Class6.Class20)class17_0).struct5_0.long_0;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00005308 File Offset: 0x00003508
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.ulong_0 <= ((Class6.Class20)class17_0).struct5_0.ulong_0;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x00005348 File Offset: 0x00003548
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.long_0 < ((Class6.Class20)class17_0).struct5_0.long_0;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x00005385 File Offset: 0x00003585
		public override bool vmethod_81(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_3())
			{
				throw new Class6.Exception1();
			}
			return this.struct5_0.ulong_0 < ((Class6.Class20)class17_0).struct5_0.ulong_0;
		}

		// Token: 0x0400040B RID: 1035
		public Class6.Struct5 struct5_0;

		// Token: 0x0400040C RID: 1036
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x020000BE RID: 190
	private class Class21 : Class6.Class18
	{
		// Token: 0x0600059F RID: 1439 RVA: 0x000053C2 File Offset: 0x000035C2
		internal void method_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_2())
			{
				this.class18_0 = ((Class6.Class21)class17_0).class18_0;
				this.enum1_0 = ((Class6.Class21)class17_0).enum1_0;
				return;
			}
			this.vmethod_9(class17_0);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0003A1F0 File Offset: 0x000383F0
		internal unsafe override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0.method_2())
			{
				if (IntPtr.Size == 8)
				{
					IntPtr value = new IntPtr(((Class6.Class20)this.class18_0).struct5_0.long_0);
					IntPtr intPtr = new IntPtr(((Class6.Class20)((Class6.Class21)class17_0).class18_0).struct5_0.long_0);
					*(long*)((void*)value) = intPtr.ToInt64();
					return;
				}
				IntPtr value2 = new IntPtr(((Class6.Class19)this.class18_0).struct4_0.int_0);
				IntPtr intPtr2 = new IntPtr(((Class6.Class19)((Class6.Class21)class17_0).class18_0).struct4_0.int_0);
				*(int*)((void*)value2) = intPtr2.ToInt32();
				return;
			}
			else
			{
				object obj = class17_0.vmethod_4(null);
				if (obj == null)
				{
					return;
				}
				IntPtr value3;
				if (IntPtr.Size == 8)
				{
					value3 = new IntPtr(((Class6.Class20)this.class18_0).struct5_0.long_0);
				}
				else
				{
					value3 = new IntPtr(((Class6.Class19)this.class18_0).struct4_0.int_0);
				}
				Type type = obj.GetType();
				if (type == typeof(string))
				{
					return;
				}
				if (type == typeof(byte))
				{
					*(byte*)((void*)value3) = (byte)obj;
					return;
				}
				if (type == typeof(sbyte))
				{
					*(byte*)((void*)value3) = (byte)((sbyte)obj);
					return;
				}
				if (type == typeof(short))
				{
					*(short*)((void*)value3) = (short)obj;
					return;
				}
				if (type == typeof(ushort))
				{
					*(short*)((void*)value3) = (short)((ushort)obj);
					return;
				}
				if (type == typeof(int))
				{
					*(int*)((void*)value3) = (int)obj;
					return;
				}
				if (type == typeof(uint))
				{
					*(int*)((void*)value3) = (int)((uint)obj);
					return;
				}
				if (type == typeof(long))
				{
					*(long*)((void*)value3) = (long)obj;
					return;
				}
				if (type == typeof(ulong))
				{
					*(long*)((void*)value3) = (long)((ulong)obj);
					return;
				}
				if (type == typeof(float))
				{
					*(float*)((void*)value3) = (float)obj;
					return;
				}
				if (type == typeof(double))
				{
					*(double*)((void*)value3) = (double)obj;
					return;
				}
				if (type == typeof(bool))
				{
					//*(byte*)((void*)value3) = (((bool)obj) ? 1 : 0);
					return;
				}
				if (type == typeof(IntPtr))
				{
					*(IntPtr*)((void*)value3) = (IntPtr)obj;
					return;
				}
				if (type == typeof(UIntPtr))
				{
					//*(IntPtr*)((void*)value3) = (IntPtr)((UIntPtr)obj);
					return;
				}
				if (!(type == typeof(char)))
				{
					throw new Class6.Exception1();
				}
				*(short*)((void*)value3) = (short)((char)obj);
				return;
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0003A4E0 File Offset: 0x000386E0
		public Class21(IntPtr intptr_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(intptr_0.ToInt64());
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.class18_0 = new Class6.Class19(intptr_0.ToInt32());
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0003A538 File Offset: 0x00038738
		public Class21(UIntPtr uintptr_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(uintptr_0.ToUInt64());
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.class18_0 = new Class6.Class19(uintptr_0.ToUInt32());
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0003A590 File Offset: 0x00038790
		public Class21()
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(0L);
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.class18_0 = new Class6.Class19(0);
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000053F6 File Offset: 0x000035F6
		public override Class6.Class18 vmethod_71()
		{
			return new Class6.Class21
			{
				class18_0 = this.class18_0.vmethod_71(),
				enum1_0 = this.enum1_0
			};
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0003A5E4 File Offset: 0x000387E4
		public Class21(long long_0)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(long_0);
				this.enum1_0 = (Class6.Enum1)12;
				return;
			}
			this.class18_0 = new Class6.Class19((int)long_0);
			this.enum1_0 = (Class6.Enum1)12;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000541A File Offset: 0x0000361A
		public Class21(long long_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)3;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(long_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.class18_0 = new Class6.Class19((int)long_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0003A630 File Offset: 0x00038830
		public Class21(ulong ulong_0)
		{
			this.enum4_0 = (Class6.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(ulong_0);
				this.enum1_0 = (Class6.Enum1)13;
				return;
			}
			this.class18_0 = new Class6.Class19((uint)ulong_0);
			this.enum1_0 = (Class6.Enum1)13;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00005459 File Offset: 0x00003659
		public Class21(ulong ulong_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)4;
			if (IntPtr.Size == 8)
			{
				this.class18_0 = new Class6.Class20(ulong_0);
				this.enum1_0 = enum1_1;
				return;
			}
			this.class18_0 = new Class6.Class19((uint)ulong_0);
			this.enum1_0 = enum1_1;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00005498 File Offset: 0x00003698
		public override bool vmethod_10()
		{
			return this.class18_0.vmethod_10();
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00004A97 File Offset: 0x00002C97
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00004AB5 File Offset: 0x00002CB5
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_1()
		{
			return true;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0003A67C File Offset: 0x0003887C
		public override Class6.Class17 vmethod_12(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_14();
			case (Class6.Enum1)2:
				return this.vmethod_15();
			case (Class6.Enum1)3:
				return this.vmethod_16();
			case (Class6.Enum1)4:
				return this.vmethod_17();
			case (Class6.Enum1)5:
				return this.vmethod_18();
			case (Class6.Enum1)6:
				return this.vmethod_19();
			case (Class6.Enum1)7:
				return this.vmethod_20();
			case (Class6.Enum1)8:
				return this.vmethod_21();
			case (Class6.Enum1)11:
				return this.vmethod_13();
			case (Class6.Enum1)12:
				return this;
			case (Class6.Enum1)13:
				return this;
			case (Class6.Enum1)16:
				return this.vmethod_71();
			}
			throw new Exception(((Class6.Enum5)4).ToString());
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x000054A5 File Offset: 0x000036A5
		internal IntPtr method_6()
		{
			if (IntPtr.Size == 8)
			{
				return new IntPtr(((Class6.Class20)this.class18_0).struct5_0.long_0);
			}
			return new IntPtr(((Class6.Class19)this.class18_0).struct4_0.int_0);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0003A734 File Offset: 0x00038934
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(IntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((Class6.Class20)this.class18_0).struct5_0.long_0);
				}
				return new IntPtr(((Class6.Class19)this.class18_0).struct4_0.int_0);
			}
			else if (type_0 == typeof(UIntPtr))
			{
				if (IntPtr.Size == 8)
				{
					return new UIntPtr(((Class6.Class20)this.class18_0).struct5_0.ulong_0);
				}
				return new UIntPtr(((Class6.Class19)this.class18_0).struct4_0.uint_0);
			}
			else
			{
				if (!(type_0 == null) && !(type_0 == typeof(object)))
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					if (this.enum1_0 == (Class6.Enum1)12)
					{
						return new IntPtr(((Class6.Class20)this.class18_0).struct5_0.long_0);
					}
					return new UIntPtr(((Class6.Class20)this.class18_0).struct5_0.ulong_0);
				}
				else
				{
					if (this.enum1_0 == (Class6.Enum1)12)
					{
						return new IntPtr(((Class6.Class20)this.class18_0).struct5_0.int_0);
					}
					return new UIntPtr(((Class6.Class19)this.class18_0).struct4_0.uint_0);
				}
			}
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x000054E4 File Offset: 0x000036E4
		public override Class6.Class19 vmethod_13()
		{
			return this.class18_0.vmethod_13();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x000054F1 File Offset: 0x000036F1
		public override Class6.Class19 vmethod_14()
		{
			return this.class18_0.vmethod_14();
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x000054FE File Offset: 0x000036FE
		public override Class6.Class19 vmethod_15()
		{
			return this.class18_0.vmethod_15();
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000550B File Offset: 0x0000370B
		public override Class6.Class19 vmethod_16()
		{
			return this.class18_0.vmethod_16();
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00005518 File Offset: 0x00003718
		public override Class6.Class19 vmethod_17()
		{
			return this.class18_0.vmethod_17();
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00005525 File Offset: 0x00003725
		public override Class6.Class19 vmethod_18()
		{
			return this.class18_0.vmethod_18();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00005532 File Offset: 0x00003732
		public override Class6.Class19 vmethod_19()
		{
			return this.class18_0.vmethod_19();
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000553F File Offset: 0x0000373F
		public override Class6.Class20 vmethod_20()
		{
			return this.class18_0.vmethod_20();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000554C File Offset: 0x0000374C
		public override Class6.Class20 vmethod_21()
		{
			return this.class18_0.vmethod_21();
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00004B6B File Offset: 0x00002D6B
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00004B73 File Offset: 0x00002D73
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00004B7B File Offset: 0x00002D7B
		public override Class6.Class19 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00004B83 File Offset: 0x00002D83
		public override Class6.Class20 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00004B8B File Offset: 0x00002D8B
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00004B93 File Offset: 0x00002D93
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004B9B File Offset: 0x00002D9B
		public override Class6.Class19 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004BA3 File Offset: 0x00002DA3
		public override Class6.Class20 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00005559 File Offset: 0x00003759
		public override Class6.Class19 vmethod_30()
		{
			return this.class18_0.vmethod_30();
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00005566 File Offset: 0x00003766
		public override Class6.Class19 vmethod_31()
		{
			return this.class18_0.vmethod_31();
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00005573 File Offset: 0x00003773
		public override Class6.Class19 vmethod_32()
		{
			return this.class18_0.vmethod_32();
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00005580 File Offset: 0x00003780
		public override Class6.Class19 usfdqHavse()
		{
			return this.class18_0.usfdqHavse();
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000558D File Offset: 0x0000378D
		public override Class6.Class19 vmethod_33()
		{
			return this.class18_0.vmethod_33();
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000559A File Offset: 0x0000379A
		public override Class6.Class19 vmethod_34()
		{
			return this.class18_0.vmethod_34();
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000055A7 File Offset: 0x000037A7
		public override Class6.Class20 vmethod_35()
		{
			return this.class18_0.vmethod_35();
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000055B4 File Offset: 0x000037B4
		public override Class6.Class20 vmethod_36()
		{
			return this.class18_0.vmethod_36();
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000055C1 File Offset: 0x000037C1
		public override Class6.Class19 vmethod_37()
		{
			return this.class18_0.vmethod_37();
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000055CE File Offset: 0x000037CE
		public override Class6.Class19 vmethod_38()
		{
			return this.class18_0.vmethod_38();
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x000055DB File Offset: 0x000037DB
		public override Class6.Class19 vmethod_39()
		{
			return this.class18_0.vmethod_39();
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x000055E8 File Offset: 0x000037E8
		public override Class6.Class19 vmethod_40()
		{
			return this.class18_0.vmethod_40();
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x000055F5 File Offset: 0x000037F5
		public override Class6.Class19 vmethod_41()
		{
			return this.class18_0.vmethod_41();
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00005602 File Offset: 0x00003802
		public override Class6.Class19 vmethod_42()
		{
			return this.class18_0.vmethod_42();
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000560F File Offset: 0x0000380F
		public override Class6.Class20 vmethod_43()
		{
			return this.class18_0.vmethod_43();
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000561C File Offset: 0x0000381C
		public override Class6.Class20 vmethod_44()
		{
			return this.class18_0.vmethod_44();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00005629 File Offset: 0x00003829
		public override Class6.Class22 vmethod_45()
		{
			return this.class18_0.vmethod_45();
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00005636 File Offset: 0x00003836
		public override Class6.Class22 vmethod_46()
		{
			return this.class18_0.vmethod_46();
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00005643 File Offset: 0x00003843
		public override Class6.Class22 vmethod_47()
		{
			return this.class18_0.vmethod_47();
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_25().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_24().struct4_0.int_0);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004D0B File Offset: 0x00002F0B
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_29().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_28().struct4_0.uint_0);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004D41 File Offset: 0x00002F41
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct4_0.int_0);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct4_0.uint_0);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00004DAD File Offset: 0x00002FAD
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct4_0.int_0);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004DE3 File Offset: 0x00002FE3
		public override Class6.Class21 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct4_0.uint_0);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0003A8CC File Offset: 0x00038ACC
		public override Class6.Class17 vmethod_54()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(-((Class6.Class20)this.class18_0).struct5_0.long_0);
			}
			return new Class6.Class21((long)(-(long)((Class6.Class19)this.class18_0).struct4_0.int_0));
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0003A91C File Offset: 0x00038B1C
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 + ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 + ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 + ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 + ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0003AA0C File Offset: 0x00038C0C
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 + ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 + ((Class6.Class19)class17_0).struct4_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 + ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 + ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0)));
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0003AAFC File Offset: 0x00038CFC
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 + unchecked((ulong)((Class6.Class19)class17_0).struct4_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_18().struct4_0.uint_0 + ((Class6.Class19)class17_0).struct4_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 + ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_18().struct4_0.uint_0 + ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0)));
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0003ABE8 File Offset: 0x00038DE8
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 - ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 - ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 - ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 - ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0003ACD8 File Offset: 0x00038ED8
		public Class6.Class17 method_7(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0 - this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct4_0.int_0 - this.vmethod_18().struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0 - this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0 - this.vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 - ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 - ((Class6.Class19)class17_0).struct4_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 - ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 - ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0)));
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0003AEB8 File Offset: 0x000390B8
		public Class6.Class17 method_8(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0 - this.vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(((Class6.Class19)class17_0).struct4_0.int_0 - this.vmethod_18().struct4_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0 - this.vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0 - this.vmethod_18().struct4_0.int_0)));
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0003AFA8 File Offset: 0x000391A8
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 - unchecked((ulong)((Class6.Class19)class17_0).struct4_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_18().struct4_0.uint_0 - ((Class6.Class19)class17_0).struct4_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 - ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_18().struct4_0.uint_0 - ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0)));
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0003B094 File Offset: 0x00039294
		public Class6.Class17 method_9(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(unchecked((ulong)((Class6.Class19)class17_0).struct4_0.uint_0) - this.vmethod_20().struct5_0.ulong_0));
				}
				return new Class6.Class21((long)((ulong)(checked(((Class6.Class19)class17_0).struct4_0.uint_0 - this.vmethod_18().struct4_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0 - this.vmethod_20().struct5_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0 - this.vmethod_18().struct4_0.uint_0)));
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0003B180 File Offset: 0x00039380
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 * ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 * ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 * ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 * ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0003B270 File Offset: 0x00039470
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 * ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 * ((Class6.Class19)class17_0).struct4_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.long_0 * ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0));
				}
				return new Class6.Class21((long)(checked(this.vmethod_18().struct4_0.int_0 * ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0)));
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0003B360 File Offset: 0x00039560
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 * unchecked((ulong)((Class6.Class19)class17_0).struct4_0.uint_0)));
				}
				return new Class6.Class21((long)((ulong)(checked(this.vmethod_18().struct4_0.uint_0 * ((Class6.Class19)class17_0).struct4_0.uint_0))));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(checked(this.vmethod_20().struct5_0.ulong_0 * ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0));
				}
				return new Class6.Class21((ulong)(checked(this.vmethod_18().struct4_0.uint_0 * ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0)));
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0003B44C File Offset: 0x0003964C
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 / ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 / ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 / ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 / ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0003B53C File Offset: 0x0003973C
		public Class6.Class17 method_10(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0 / this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct4_0.int_0 / this.vmethod_18().struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0 / this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0 / this.vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0003B62C File Offset: 0x0003982C
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 / ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_18().struct4_0.uint_0 / ((Class6.Class19)class17_0).struct4_0.uint_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 / ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((ulong)(this.vmethod_18().struct4_0.uint_0 / ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0));
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0003B71C File Offset: 0x0003991C
		public Class6.Class17 method_11(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0 / this.vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(((Class6.Class19)class17_0).struct4_0.uint_0 / this.vmethod_18().struct4_0.uint_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0 / this.vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((ulong)(((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0 / this.vmethod_18().struct4_0.uint_0));
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0003B80C File Offset: 0x00039A0C
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 % ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 % ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 % ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 % ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0003B8FC File Offset: 0x00039AFC
		public Class6.Class17 method_12(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0 % this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class19)class17_0).struct4_0.int_0 % this.vmethod_18().struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0 % this.vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0 % this.vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0003B9EC File Offset: 0x00039BEC
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 % ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_18().struct4_0.uint_0 % ((Class6.Class19)class17_0).struct4_0.uint_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 % ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((ulong)(this.vmethod_18().struct4_0.uint_0 % ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0));
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0003BADC File Offset: 0x00039CDC
		public Class6.Class17 yIwByEsukh(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0 % this.vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((long)((ulong)(((Class6.Class19)class17_0).struct4_0.uint_0 % this.vmethod_18().struct4_0.uint_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0 % this.vmethod_20().struct5_0.ulong_0);
				}
				return new Class6.Class21((ulong)(((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0 % this.vmethod_18().struct4_0.uint_0));
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0003BBCC File Offset: 0x00039DCC
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 & ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 & ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 & ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 & ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0003BCBC File Offset: 0x00039EBC
		public override Class6.Class17 vmethod_68(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 | ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 | ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 | ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 | ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00005650 File Offset: 0x00003850
		public override Class6.Class17 vmethod_69()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(~this.vmethod_20().struct5_0.long_0);
			}
			return new Class6.Class21((long)(~(long)this.vmethod_18().struct4_0.int_0));
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0003BDAC File Offset: 0x00039FAC
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 ^ ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 ^ ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 ^ ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 ^ ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0003BE9C File Offset: 0x0003A09C
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 << ((Class6.Class19)class17_0).struct4_0.int_0);
				}
				return new Class6.Class21((long)((long)this.vmethod_18().struct4_0.int_0 << ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 << ((Class6.Class21)class17_0).vmethod_20().struct5_0.int_0);
				}
				return new Class6.Class21((long)((long)this.vmethod_18().struct4_0.int_0 << ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0003BF94 File Offset: 0x0003A194
		public override Class6.Class17 vmethod_73(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 >> ((Class6.Class19)class17_0).struct4_0.int_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 >> ((Class6.Class19)class17_0).struct4_0.int_0));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.long_0 >> ((Class6.Class21)class17_0).vmethod_20().struct5_0.int_0);
				}
				return new Class6.Class21((long)(this.vmethod_18().struct4_0.int_0 >> ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0));
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0003C08C File Offset: 0x0003A28C
		public override Class6.Class17 vmethod_74(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 >> ((Class6.Class19)class17_0).struct4_0.int_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_18().struct4_0.uint_0 >> ((Class6.Class19)class17_0).struct4_0.int_0)));
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return new Class6.Class21(this.vmethod_20().struct5_0.ulong_0 >> ((Class6.Class21)class17_0).vmethod_20().struct5_0.int_0);
				}
				return new Class6.Class21((long)((ulong)(this.vmethod_18().struct4_0.uint_0 >> ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0)));
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00005688 File Offset: 0x00003888
		public Class6.Class17 method_13(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)((ulong)(class19_0.struct4_0.uint_0 >> this.vmethod_18().struct4_0.int_0)));
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000056AF File Offset: 0x000038AF
		public Class6.Class17 method_14(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)(class19_0.struct4_0.int_0 >> this.vmethod_20().struct5_0.int_0));
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000056D6 File Offset: 0x000038D6
		public Class6.Class17 method_15(Class6.Class19 class19_0)
		{
			return new Class6.Class21((long)((long)class19_0.struct4_0.int_0 << this.vmethod_20().struct5_0.int_0));
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000056FD File Offset: 0x000038FD
		public override string ToString()
		{
			return this.class18_0.ToString();
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00004E2C File Offset: 0x0000302C
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_8()
		{
			return true;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0003C184 File Offset: 0x0003A384
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 == ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 == ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			else
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct5_0.long_0 == ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0;
				}
				return false;
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0003C258 File Offset: 0x0003A458
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).BeouTiljCp(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			if (!@class.vmethod_8())
			{
				return false;
			}
			if (@class.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 != ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 != ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			else
			{
				if (@class.method_2())
				{
					int size = IntPtr.Size;
					return this.vmethod_20().struct5_0.ulong_0 != ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return false;
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0003C334 File Offset: 0x0003A534
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 >= ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 >= ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 >= ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 >= ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0003C420 File Offset: 0x0003A620
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 >= ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 >= ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 >= ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 >= ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0;
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0003C50C File Offset: 0x0003A70C
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 > ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 > ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 > ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 > ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0;
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0003C5EC File Offset: 0x0003A7EC
		public override bool lwlumgaheq(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 > ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 > ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 > ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 > ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0003C6CC File Offset: 0x0003A8CC
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 <= ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 <= ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 <= ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 <= ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0003C7B8 File Offset: 0x0003A9B8
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 <= ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 <= ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 <= ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 <= ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0;
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0003C8A4 File Offset: 0x0003AAA4
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 < ((Class6.Class19)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 < ((Class6.Class19)class17_0).struct4_0.int_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.long_0 < ((Class6.Class21)class17_0).vmethod_20().struct5_0.long_0;
				}
				return this.vmethod_18().struct4_0.int_0 < ((Class6.Class21)class17_0).vmethod_18().struct4_0.int_0;
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0003C984 File Offset: 0x0003AB84
		public override bool vmethod_81(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (class17_0.method_1())
			{
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 < ((Class6.Class19)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 < ((Class6.Class19)class17_0).struct4_0.uint_0;
			}
			else
			{
				if (!class17_0.method_2())
				{
					throw new Class6.Exception1();
				}
				if (IntPtr.Size == 8)
				{
					return this.vmethod_20().struct5_0.ulong_0 < ((Class6.Class21)class17_0).vmethod_20().struct5_0.ulong_0;
				}
				return this.vmethod_18().struct4_0.uint_0 < ((Class6.Class21)class17_0).vmethod_18().struct4_0.uint_0;
			}
		}

		// Token: 0x0400040D RID: 1037
		public Class6.Class18 class18_0;

		// Token: 0x0400040E RID: 1038
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x020000BF RID: 191
	private abstract class Class18 : Class6.Class17
	{
		// Token: 0x06000607 RID: 1543
		public abstract bool vmethod_10();

		// Token: 0x06000608 RID: 1544
		public abstract bool vmethod_11();

		// Token: 0x06000609 RID: 1545
		public abstract Class6.Class17 vmethod_12(Class6.Enum1 enum1_0);

		// Token: 0x0600060A RID: 1546
		public abstract Class6.Class19 vmethod_13();

		// Token: 0x0600060B RID: 1547
		public abstract Class6.Class19 vmethod_14();

		// Token: 0x0600060C RID: 1548
		public abstract Class6.Class19 vmethod_15();

		// Token: 0x0600060D RID: 1549
		public abstract Class6.Class19 vmethod_16();

		// Token: 0x0600060E RID: 1550
		public abstract Class6.Class19 vmethod_17();

		// Token: 0x0600060F RID: 1551
		public abstract Class6.Class19 vmethod_18();

		// Token: 0x06000610 RID: 1552
		public abstract Class6.Class19 vmethod_19();

		// Token: 0x06000611 RID: 1553
		public abstract Class6.Class20 vmethod_20();

		// Token: 0x06000612 RID: 1554
		public abstract Class6.Class20 vmethod_21();

		// Token: 0x06000613 RID: 1555
		public abstract Class6.Class19 vmethod_22();

		// Token: 0x06000614 RID: 1556
		public abstract Class6.Class19 vmethod_23();

		// Token: 0x06000615 RID: 1557
		public abstract Class6.Class19 vmethod_24();

		// Token: 0x06000616 RID: 1558
		public abstract Class6.Class20 vmethod_25();

		// Token: 0x06000617 RID: 1559
		public abstract Class6.Class19 vmethod_26();

		// Token: 0x06000618 RID: 1560
		public abstract Class6.Class19 vmethod_27();

		// Token: 0x06000619 RID: 1561
		public abstract Class6.Class19 vmethod_28();

		// Token: 0x0600061A RID: 1562
		public abstract Class6.Class20 vmethod_29();

		// Token: 0x0600061B RID: 1563
		public abstract Class6.Class19 vmethod_30();

		// Token: 0x0600061C RID: 1564
		public abstract Class6.Class19 vmethod_31();

		// Token: 0x0600061D RID: 1565
		public abstract Class6.Class19 vmethod_32();

		// Token: 0x0600061E RID: 1566
		public abstract Class6.Class19 usfdqHavse();

		// Token: 0x0600061F RID: 1567
		public abstract Class6.Class19 vmethod_33();

		// Token: 0x06000620 RID: 1568
		public abstract Class6.Class19 vmethod_34();

		// Token: 0x06000621 RID: 1569
		public abstract Class6.Class20 vmethod_35();

		// Token: 0x06000622 RID: 1570
		public abstract Class6.Class20 vmethod_36();

		// Token: 0x06000623 RID: 1571
		public abstract Class6.Class19 vmethod_37();

		// Token: 0x06000624 RID: 1572
		public abstract Class6.Class19 vmethod_38();

		// Token: 0x06000625 RID: 1573
		public abstract Class6.Class19 vmethod_39();

		// Token: 0x06000626 RID: 1574
		public abstract Class6.Class19 vmethod_40();

		// Token: 0x06000627 RID: 1575
		public abstract Class6.Class19 vmethod_41();

		// Token: 0x06000628 RID: 1576
		public abstract Class6.Class19 vmethod_42();

		// Token: 0x06000629 RID: 1577
		public abstract Class6.Class20 vmethod_43();

		// Token: 0x0600062A RID: 1578
		public abstract Class6.Class20 vmethod_44();

		// Token: 0x0600062B RID: 1579
		public abstract Class6.Class22 vmethod_45();

		// Token: 0x0600062C RID: 1580
		public abstract Class6.Class22 vmethod_46();

		// Token: 0x0600062D RID: 1581
		public abstract Class6.Class22 vmethod_47();

		// Token: 0x0600062E RID: 1582
		public abstract Class6.Class21 vmethod_48();

		// Token: 0x0600062F RID: 1583
		public abstract Class6.Class21 vmethod_49();

		// Token: 0x06000630 RID: 1584
		public abstract Class6.Class21 vmethod_50();

		// Token: 0x06000631 RID: 1585
		public abstract Class6.Class21 vmethod_51();

		// Token: 0x06000632 RID: 1586
		public abstract Class6.Class21 vmethod_52();

		// Token: 0x06000633 RID: 1587
		public abstract Class6.Class21 vmethod_53();

		// Token: 0x06000634 RID: 1588
		public abstract Class6.Class17 vmethod_54();

		// Token: 0x06000635 RID: 1589
		public abstract Class6.Class17 Add(Class6.Class17 class17_0);

		// Token: 0x06000636 RID: 1590
		public abstract Class6.Class17 vmethod_55(Class6.Class17 class17_0);

		// Token: 0x06000637 RID: 1591
		public abstract Class6.Class17 vmethod_56(Class6.Class17 class17_0);

		// Token: 0x06000638 RID: 1592
		public abstract Class6.Class17 vmethod_57(Class6.Class17 class17_0);

		// Token: 0x06000639 RID: 1593
		public abstract Class6.Class17 vmethod_58(Class6.Class17 class17_0);

		// Token: 0x0600063A RID: 1594
		public abstract Class6.Class17 vmethod_59(Class6.Class17 class17_0);

		// Token: 0x0600063B RID: 1595
		public abstract Class6.Class17 vmethod_60(Class6.Class17 class17_0);

		// Token: 0x0600063C RID: 1596
		public abstract Class6.Class17 vmethod_61(Class6.Class17 class17_0);

		// Token: 0x0600063D RID: 1597
		public abstract Class6.Class17 vmethod_62(Class6.Class17 class17_0);

		// Token: 0x0600063E RID: 1598
		public abstract Class6.Class17 vmethod_63(Class6.Class17 class17_0);

		// Token: 0x0600063F RID: 1599
		public abstract Class6.Class17 vmethod_64(Class6.Class17 class17_0);

		// Token: 0x06000640 RID: 1600
		public abstract Class6.Class17 vmethod_65(Class6.Class17 class17_0);

		// Token: 0x06000641 RID: 1601
		public abstract Class6.Class17 vmethod_66(Class6.Class17 class17_0);

		// Token: 0x06000642 RID: 1602
		public abstract Class6.Class17 vmethod_67(Class6.Class17 class17_0);

		// Token: 0x06000643 RID: 1603
		public abstract Class6.Class17 vmethod_68(Class6.Class17 class17_0);

		// Token: 0x06000644 RID: 1604
		public abstract Class6.Class17 vmethod_69();

		// Token: 0x06000645 RID: 1605
		public abstract Class6.Class17 vmethod_70(Class6.Class17 class17_0);

		// Token: 0x06000646 RID: 1606
		public abstract Class6.Class18 vmethod_71();

		// Token: 0x06000647 RID: 1607
		public abstract Class6.Class17 vmethod_72(Class6.Class17 class17_0);

		// Token: 0x06000648 RID: 1608
		public abstract Class6.Class17 vmethod_73(Class6.Class17 class17_0);

		// Token: 0x06000649 RID: 1609
		public abstract Class6.Class17 vmethod_74(Class6.Class17 class17_0);

		// Token: 0x0600064A RID: 1610
		public abstract bool vmethod_75(Class6.Class17 class17_0);

		// Token: 0x0600064B RID: 1611
		public abstract bool vmethod_76(Class6.Class17 class17_0);

		// Token: 0x0600064C RID: 1612
		public abstract bool vmethod_77(Class6.Class17 class17_0);

		// Token: 0x0600064D RID: 1613
		public abstract bool lwlumgaheq(Class6.Class17 class17_0);

		// Token: 0x0600064E RID: 1614
		public abstract bool vmethod_78(Class6.Class17 class17_0);

		// Token: 0x0600064F RID: 1615
		public abstract bool vmethod_79(Class6.Class17 class17_0);

		// Token: 0x06000650 RID: 1616
		public abstract bool vmethod_80(Class6.Class17 class17_0);

		// Token: 0x06000651 RID: 1617
		public abstract bool vmethod_81(Class6.Class17 class17_0);

		// Token: 0x06000652 RID: 1618 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_3()
		{
			return true;
		}
	}

	// Token: 0x020000C0 RID: 192
	private class Class22 : Class6.Class18
	{
		// Token: 0x06000654 RID: 1620 RVA: 0x00005712 File Offset: 0x00003912
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.double_0 = ((Class6.Class22)class17_0).double_0;
			this.enum1_0 = ((Class6.Class22)class17_0).enum1_0;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00005736 File Offset: 0x00003936
		public Class22(double double_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.enum1_0 = (Class6.Enum1)10;
			this.double_0 = double_1;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00005754 File Offset: 0x00003954
		public Class22(Class6.Class22 class22_0)
		{
			this.enum4_0 = class22_0.enum4_0;
			this.enum1_0 = class22_0.enum1_0;
			this.double_0 = class22_0.double_0;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00005780 File Offset: 0x00003980
		public override Class6.Class18 vmethod_71()
		{
			return new Class6.Class22(this);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00005788 File Offset: 0x00003988
		public Class22(double double_1, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = double_1;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000057A5 File Offset: 0x000039A5
		public Class22(float float_0)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = (Class6.Enum1)9;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000057C4 File Offset: 0x000039C4
		public Class22(float float_0, Class6.Enum1 enum1_1)
		{
			this.enum4_0 = (Class6.Enum4)5;
			this.double_0 = (double)float_0;
			this.enum1_0 = enum1_1;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000057E2 File Offset: 0x000039E2
		public override bool vmethod_10()
		{
			return this.double_0 == 0.0;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00004A97 File Offset: 0x00002C97
		public override bool vmethod_11()
		{
			return !this.vmethod_10();
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x000057F5 File Offset: 0x000039F5
		public override string ToString()
		{
			return this.double_0.ToString();
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0003CA64 File Offset: 0x0003AC64
		public override Class6.Class17 vmethod_12(Class6.Enum1 enum1_1)
		{
			switch (enum1_1)
			{
			case (Class6.Enum1)1:
				return this.vmethod_14();
			case (Class6.Enum1)2:
				return this.vmethod_15();
			case (Class6.Enum1)3:
				return this.vmethod_16();
			case (Class6.Enum1)4:
				return this.vmethod_17();
			case (Class6.Enum1)5:
				return this.vmethod_18();
			case (Class6.Enum1)6:
				return this.vmethod_19();
			case (Class6.Enum1)7:
				return this.vmethod_20();
			case (Class6.Enum1)8:
				return this.vmethod_21();
			case (Class6.Enum1)9:
				return this.vmethod_45();
			case (Class6.Enum1)10:
				return this.vmethod_46();
			case (Class6.Enum1)11:
				return this.vmethod_13();
			default:
				throw new Exception(((Class6.Enum5)4).ToString());
			}
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0003CB08 File Offset: 0x0003AD08
		internal override object vmethod_4(Type type_0)
		{
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (type_0 == typeof(float))
			{
				return (float)this.double_0;
			}
			if (type_0 == typeof(double))
			{
				return this.double_0;
			}
			if ((type_0 == null || type_0 == typeof(object)) && this.enum1_0 == (Class6.Enum1)9)
			{
				return (float)this.double_0;
			}
			return this.double_0;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00005802 File Offset: 0x00003A02
		public override Class6.Class19 vmethod_13()
		{
			return new Class6.Class19(this.vmethod_10() ? 1 : 0);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00004AB5 File Offset: 0x00002CB5
		internal override bool vmethod_6()
		{
			return this.vmethod_11();
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00005815 File Offset: 0x00003A15
		public override Class6.Class19 vmethod_14()
		{
			return new Class6.Class19((int)((sbyte)this.double_0), (Class6.Enum1)1);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00005824 File Offset: 0x00003A24
		public override Class6.Class19 vmethod_15()
		{
			return new Class6.Class19((uint)((byte)this.double_0), (Class6.Enum1)2);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00005833 File Offset: 0x00003A33
		public override Class6.Class19 vmethod_16()
		{
			return new Class6.Class19((int)((short)this.double_0), (Class6.Enum1)3);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00005842 File Offset: 0x00003A42
		public override Class6.Class19 vmethod_17()
		{
			return new Class6.Class19((uint)((ushort)this.double_0), (Class6.Enum1)4);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00005851 File Offset: 0x00003A51
		public override Class6.Class19 vmethod_18()
		{
			return new Class6.Class19((int)this.double_0, (Class6.Enum1)5);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00005860 File Offset: 0x00003A60
		public override Class6.Class19 vmethod_19()
		{
			return new Class6.Class19((uint)this.double_0, (Class6.Enum1)6);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000586F File Offset: 0x00003A6F
		public override Class6.Class20 vmethod_20()
		{
			return new Class6.Class20((long)this.double_0, (Class6.Enum1)7);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000587E File Offset: 0x00003A7E
		public override Class6.Class20 vmethod_21()
		{
			return new Class6.Class20((ulong)this.double_0, (Class6.Enum1)8);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00004B6B File Offset: 0x00002D6B
		public override Class6.Class19 vmethod_22()
		{
			return this.vmethod_14();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004B73 File Offset: 0x00002D73
		public override Class6.Class19 vmethod_23()
		{
			return this.vmethod_16();
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00004B7B File Offset: 0x00002D7B
		public override Class6.Class19 vmethod_24()
		{
			return this.vmethod_18();
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00004B83 File Offset: 0x00002D83
		public override Class6.Class20 vmethod_25()
		{
			return this.vmethod_20();
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00004B8B File Offset: 0x00002D8B
		public override Class6.Class19 vmethod_26()
		{
			return this.vmethod_15();
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00004B93 File Offset: 0x00002D93
		public override Class6.Class19 vmethod_27()
		{
			return this.vmethod_17();
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00004B9B File Offset: 0x00002D9B
		public override Class6.Class19 vmethod_28()
		{
			return this.vmethod_19();
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00004BA3 File Offset: 0x00002DA3
		public override Class6.Class20 vmethod_29()
		{
			return this.vmethod_21();
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0000588D File Offset: 0x00003A8D
		public override Class6.Class19 vmethod_30()
		{
			return new Class6.Class19((int)(checked((sbyte)this.double_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0000588D File Offset: 0x00003A8D
		public override Class6.Class19 vmethod_31()
		{
			return new Class6.Class19((int)(checked((sbyte)this.double_0)), (Class6.Enum1)1);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000589C File Offset: 0x00003A9C
		public override Class6.Class19 vmethod_32()
		{
			return new Class6.Class19((int)(checked((short)this.double_0)), (Class6.Enum1)3);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000589C File Offset: 0x00003A9C
		public override Class6.Class19 usfdqHavse()
		{
			return new Class6.Class19((int)(checked((short)this.double_0)), (Class6.Enum1)3);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x000058AB File Offset: 0x00003AAB
		public override Class6.Class19 vmethod_33()
		{
			return new Class6.Class19(checked((int)this.double_0), (Class6.Enum1)5);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000058AB File Offset: 0x00003AAB
		public override Class6.Class19 vmethod_34()
		{
			return new Class6.Class19(checked((int)this.double_0), (Class6.Enum1)5);
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x000058BA File Offset: 0x00003ABA
		public override Class6.Class20 vmethod_35()
		{
			return new Class6.Class20(checked((long)this.double_0), (Class6.Enum1)7);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000058BA File Offset: 0x00003ABA
		public override Class6.Class20 vmethod_36()
		{
			return new Class6.Class20(checked((long)this.double_0), (Class6.Enum1)7);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000058C9 File Offset: 0x00003AC9
		public override Class6.Class19 vmethod_37()
		{
			return new Class6.Class19((int)(checked((byte)this.double_0)), (Class6.Enum1)2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000058C9 File Offset: 0x00003AC9
		public override Class6.Class19 vmethod_38()
		{
			return new Class6.Class19((int)(checked((byte)this.double_0)), (Class6.Enum1)2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000058D8 File Offset: 0x00003AD8
		public override Class6.Class19 vmethod_39()
		{
			return new Class6.Class19((int)(checked((ushort)this.double_0)), (Class6.Enum1)4);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x000058D8 File Offset: 0x00003AD8
		public override Class6.Class19 vmethod_40()
		{
			return new Class6.Class19((int)(checked((ushort)this.double_0)), (Class6.Enum1)4);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000058E7 File Offset: 0x00003AE7
		public override Class6.Class19 vmethod_41()
		{
			return new Class6.Class19(checked((uint)this.double_0), (Class6.Enum1)6);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000058E7 File Offset: 0x00003AE7
		public override Class6.Class19 vmethod_42()
		{
			return new Class6.Class19(checked((uint)this.double_0), (Class6.Enum1)6);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000058F6 File Offset: 0x00003AF6
		public override Class6.Class20 vmethod_43()
		{
			return new Class6.Class20(checked((ulong)this.double_0), (Class6.Enum1)8);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000058F6 File Offset: 0x00003AF6
		public override Class6.Class20 vmethod_44()
		{
			return new Class6.Class20(checked((ulong)this.double_0), (Class6.Enum1)8);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00005905 File Offset: 0x00003B05
		public override Class6.Class22 vmethod_45()
		{
			return new Class6.Class22((float)this.double_0, (Class6.Enum1)9);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00005915 File Offset: 0x00003B15
		public override Class6.Class22 vmethod_46()
		{
			return new Class6.Class22(this.double_0, (Class6.Enum1)10);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00005925 File Offset: 0x00003B25
		public override Class6.Class22 vmethod_47()
		{
			return new Class6.Class22(this.double_0);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00004CD5 File Offset: 0x00002ED5
		public override Class6.Class21 vmethod_48()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_25().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_24().struct4_0.int_0);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00004D0B File Offset: 0x00002F0B
		public override Class6.Class21 vmethod_49()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_29().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_28().struct4_0.uint_0);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00004D41 File Offset: 0x00002F41
		public override Class6.Class21 vmethod_50()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_35().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_33().struct4_0.int_0);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00004D77 File Offset: 0x00002F77
		public override Class6.Class21 vmethod_51()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_43().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_41().struct4_0.uint_0);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00004DAD File Offset: 0x00002FAD
		public override Class6.Class21 vmethod_52()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_36().struct5_0.long_0);
			}
			return new Class6.Class21((long)this.vmethod_34().struct4_0.int_0);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00004DE3 File Offset: 0x00002FE3
		public override Class6.Class21 vmethod_53()
		{
			if (IntPtr.Size == 8)
			{
				return new Class6.Class21(this.vmethod_44().struct5_0.ulong_0);
			}
			return new Class6.Class21((ulong)this.vmethod_42().struct4_0.uint_0);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00005933 File Offset: 0x00003B33
		public override Class6.Class17 vmethod_54()
		{
			if (this.enum1_0 == (Class6.Enum1)9)
			{
				return new Class6.Class22((float)(-(float)this.double_0));
			}
			return new Class6.Class22(-this.double_0);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000595A File Offset: 0x00003B5A
		public override Class6.Class17 Add(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000595A File Offset: 0x00003B5A
		public override Class6.Class17 vmethod_55(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000595A File Offset: 0x00003B5A
		public override Class6.Class17 vmethod_56(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 + ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00005991 File Offset: 0x00003B91
		public override Class6.Class17 vmethod_57(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00005991 File Offset: 0x00003B91
		public override Class6.Class17 vmethod_58(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00005991 File Offset: 0x00003B91
		public override Class6.Class17 vmethod_59(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 - ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000059C8 File Offset: 0x00003BC8
		public override Class6.Class17 vmethod_60(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4() || !class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00005A07 File Offset: 0x00003C07
		public override Class6.Class17 vmethod_61(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00005A07 File Offset: 0x00003C07
		public override Class6.Class17 vmethod_62(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 * ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00005A3E File Offset: 0x00003C3E
		public override Class6.Class17 vmethod_63(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 / ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00005A3E File Offset: 0x00003C3E
		public override Class6.Class17 vmethod_64(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 / ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00005A75 File Offset: 0x00003C75
		public override Class6.Class17 vmethod_65(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 % ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00005A75 File Offset: 0x00003C75
		public override Class6.Class17 vmethod_66(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return new Class6.Class22(this.double_0 % ((Class6.Class22)class17_0).double_0);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_67(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_68(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_69()
		{
			throw new Class6.Exception1();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_70(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_72(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_73(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00005AAC File Offset: 0x00003CAC
		public override Class6.Class17 vmethod_74(Class6.Class17 class17_0)
		{
			throw new Class6.Exception1();
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00004E2C File Offset: 0x0000302C
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_4() && this.double_0 == ((Class6.Class22)@class).double_0;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0003CBF8 File Offset: 0x0003ADF8
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (class17_0.method_0())
			{
				return false;
			}
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).BeouTiljCp(this);
			}
			Class6.Class17 @class = class17_0.vmethod_7();
			return @class.method_4() && this.double_0 != ((Class6.Class22)@class).double_0;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00005AB3 File Offset: 0x00003CB3
		public override bool vmethod_75(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 >= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00005AB3 File Offset: 0x00003CB3
		public override bool vmethod_76(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 >= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public override bool vmethod_77(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 > ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00005AE9 File Offset: 0x00003CE9
		public override bool lwlumgaheq(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 > ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00005B1C File Offset: 0x00003D1C
		public override bool vmethod_78(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 <= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00005B1C File Offset: 0x00003D1C
		public override bool vmethod_79(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 <= ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00005B52 File Offset: 0x00003D52
		public override bool vmethod_80(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 < ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00005B52 File Offset: 0x00003D52
		public override bool vmethod_81(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				class17_0 = class17_0.vmethod_7();
			}
			if (!class17_0.method_4())
			{
				throw new Class6.Exception1();
			}
			return this.double_0 < ((Class6.Class22)class17_0).double_0;
		}

		// Token: 0x0400040F RID: 1039
		public double double_0;

		// Token: 0x04000410 RID: 1040
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x020000C1 RID: 193
	internal enum Enum1 : byte
	{

	}

	// Token: 0x020000C2 RID: 194
	internal enum Enum2 : byte
	{

	}

	// Token: 0x020000C3 RID: 195
	private class Exception0 : Exception
	{
		// Token: 0x060006AC RID: 1708 RVA: 0x00005B85 File Offset: 0x00003D85
		public Exception0(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x020000C4 RID: 196
	private class Exception1 : Exception
	{
		// Token: 0x060006AD RID: 1709 RVA: 0x00005B8E File Offset: 0x00003D8E
		public Exception1()
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00005B85 File Offset: 0x00003D85
		public Exception1(string string_0) : base(string_0)
		{
		}
	}

	// Token: 0x020000C5 RID: 197
	internal class Class7
	{
		// Token: 0x060006AF RID: 1711 RVA: 0x0003CC4C File Offset: 0x0003AE4C
		public override string ToString()
		{
			object obj = this.enum3_0;
			if (this.object_0 != null)
			{
				return obj.ToString() + 'H'.ToString() + this.object_0.ToString();
			}
			return obj.ToString();
		}

		// Token: 0x04000413 RID: 1043
		internal Class6.Enum3 enum3_0 = (Class6.Enum3)126;

		// Token: 0x04000414 RID: 1044
		internal object object_0;
	}

	// Token: 0x020000C6 RID: 198
	internal abstract class Class23 : Class6.Class17
	{
		// Token: 0x060006B1 RID: 1713 RVA: 0x0000570A File Offset: 0x0000390A
		public Class23()
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_0()
		{
			return true;
		}

		// Token: 0x060006B3 RID: 1715
		internal abstract IntPtr vmethod_10();

		// Token: 0x060006B4 RID: 1716
		internal abstract void vmethod_11(Class6.Class17 class17_0);

		// Token: 0x060006B5 RID: 1717 RVA: 0x00002322 File Offset: 0x00000522
		internal override bool vmethod_1()
		{
			return true;
		}
	}

	// Token: 0x020000C7 RID: 199
	internal class Class24 : Class6.Class23
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x00005BA6 File Offset: 0x00003DA6
		public Class24(int int_1, Class6.Class15 class15_1)
		{
			this.class15_0 = class15_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0003CC94 File Offset: 0x0003AE94
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class24)
			{
				this.class15_0 = ((Class6.Class24)class17_0).class15_0;
				this.int_0 = ((Class6.Class24)class17_0).int_0;
				return;
			}
			Class6.Class9 @class = this.class15_0.class12_0.fBcjhfhonR[this.int_0];
			if (class17_0 is Class6.Class23 && (@class.enum1_0 & (Class6.Enum1)226) > (Class6.Enum1)0)
			{
				Class6.Class17 class17_ = (class17_0 as Class6.Class23).vmethod_7();
				this.vmethod_11(class17_);
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00005BC3 File Offset: 0x00003DC3
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00005BCC File Offset: 0x00003DCC
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00005BD3 File Offset: 0x00003DD3
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.class15_0.class17_1[this.int_0] = class17_0;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00005BE8 File Offset: 0x00003DE8
		internal override object vmethod_4(Type type_0)
		{
			if (this.class15_0.class17_1[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00005C0C File Offset: 0x00003E0C
		internal override Class6.Class17 vmethod_7()
		{
			if (this.class15_0.class17_1[this.int_0] == null)
			{
				return new Class6.Class29(null);
			}
			return this.class15_0.class17_1[this.int_0].vmethod_7();
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00005C40 File Offset: 0x00003E40
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00005C4D File Offset: 0x00003E4D
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			return class17_0.vmethod_0() && class17_0 is Class6.Class24 && ((Class6.Class24)class17_0).int_0 == this.int_0;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00005C79 File Offset: 0x00003E79
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			return !class17_0.vmethod_0() || !(class17_0 is Class6.Class24) || ((Class6.Class24)class17_0).int_0 != this.int_0;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00005CA5 File Offset: 0x00003EA5
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000415 RID: 1045
		private Class6.Class15 class15_0;

		// Token: 0x04000416 RID: 1046
		internal int int_0;
	}

	// Token: 0x020000C8 RID: 200
	internal class Class25 : Class6.Class23
	{
		// Token: 0x060006C1 RID: 1729 RVA: 0x00005CB2 File Offset: 0x00003EB2
		public Class25(int int_1, Array array_1)
		{
			this.array_0 = array_1;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00005BCC File Offset: 0x00003DCC
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00005CCF File Offset: 0x00003ECF
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class25)
			{
				this.array_0 = ((Class6.Class25)class17_0).array_0;
				this.int_0 = ((Class6.Class25)class17_0).int_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00005BC3 File Offset: 0x00003DC3
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00005D03 File Offset: 0x00003F03
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.array_0.SetValue(class17_0.vmethod_4(null), this.int_0);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00005D1D File Offset: 0x00003F1D
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00005D2B File Offset: 0x00003F2B
		internal override Class6.Class17 vmethod_7()
		{
			return Class6.Class17.smethod_1(this.array_0.GetType().GetElementType(), this.array_0.GetValue(this.int_0));
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00005C40 File Offset: 0x00003E40
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (!class17_0.vmethod_0())
			{
				return false;
			}
			if (class17_0 is Class6.Class25)
			{
				Class6.Class25 @class = (Class6.Class25)class17_0;
				return @class.int_0 == this.int_0 && @class.array_0 == this.array_0;
			}
			return false;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0003CD68 File Offset: 0x0003AF68
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (!class17_0.vmethod_0())
			{
				return true;
			}
			if (class17_0 is Class6.Class25)
			{
				Class6.Class25 @class = (Class6.Class25)class17_0;
				return @class.int_0 != this.int_0 || @class.array_0 != this.array_0;
			}
			return true;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00005CA5 File Offset: 0x00003EA5
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000417 RID: 1047
		private Array array_0;

		// Token: 0x04000418 RID: 1048
		internal int int_0;
	}

	// Token: 0x020000C9 RID: 201
	internal class Class26 : Class6.Class23
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00005D53 File Offset: 0x00003F53
		public Class26(FieldInfo fieldInfo_1, object object_1)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.object_0 = object_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00005BCC File Offset: 0x00003DCC
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0003CDB4 File Offset: 0x0003AFB4
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			if (this.object_0 != null && this.object_0 is Class6.Class17)
			{
				this.fieldInfo_0.SetValue(((Class6.Class17)this.object_0).vmethod_4(null), class17_0.vmethod_4(null));
				return;
			}
			this.fieldInfo_0.SetValue(this.object_0, class17_0.vmethod_4(null));
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00005D70 File Offset: 0x00003F70
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class26)
			{
				this.fieldInfo_0 = ((Class6.Class26)class17_0).fieldInfo_0;
				this.object_0 = ((Class6.Class26)class17_0).object_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00005BC3 File Offset: 0x00003DC3
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00005D1D File Offset: 0x00003F1D
		internal override object vmethod_4(Type type_0)
		{
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0003CE14 File Offset: 0x0003B014
		internal override Class6.Class17 vmethod_7()
		{
			if (this.object_0 != null && this.object_0 is Class6.Class17)
			{
				return Class6.Class17.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(((Class6.Class17)this.object_0).vmethod_4(null)));
			}
			return Class6.Class17.smethod_1(this.fieldInfo_0.FieldType, this.fieldInfo_0.GetValue(this.object_0));
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00005C40 File Offset: 0x00003E40
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0003CE84 File Offset: 0x0003B084
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (!class17_0.vmethod_0())
			{
				return false;
			}
			if (class17_0 is Class6.Class26)
			{
				Class6.Class26 @class = (Class6.Class26)class17_0;
				return !(@class.fieldInfo_0 != this.fieldInfo_0) && @class.object_0 == this.object_0;
			}
			return false;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0003CED4 File Offset: 0x0003B0D4
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (!class17_0.vmethod_0())
			{
				return true;
			}
			if (class17_0 is Class6.Class26)
			{
				Class6.Class26 @class = (Class6.Class26)class17_0;
				return @class.fieldInfo_0 != this.fieldInfo_0 || @class.object_0 != this.object_0;
			}
			return true;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00005CA5 File Offset: 0x00003EA5
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x04000419 RID: 1049
		internal FieldInfo fieldInfo_0;

		// Token: 0x0400041A RID: 1050
		internal object object_0;
	}

	// Token: 0x020000CA RID: 202
	internal class Class27 : Class6.Class23
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x00005DA4 File Offset: 0x00003FA4
		public Class27(int int_1, Class6.Class15 class15_0)
		{
			this.EqvjjieJlV = class15_0;
			this.int_0 = int_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00005BCC File Offset: 0x00003DCC
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00005DC1 File Offset: 0x00003FC1
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			if (class17_0 is Class6.Class27)
			{
				this.EqvjjieJlV = ((Class6.Class27)class17_0).EqvjjieJlV;
				this.int_0 = ((Class6.Class27)class17_0).int_0;
				return;
			}
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00005BC3 File Offset: 0x00003DC3
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_11(class17_0);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00005DF5 File Offset: 0x00003FF5
		internal override void vmethod_11(Class6.Class17 class17_0)
		{
			this.EqvjjieJlV.class17_0[this.int_0] = class17_0;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00005E0A File Offset: 0x0000400A
		internal override object vmethod_4(Type type_0)
		{
			if (this.EqvjjieJlV.class17_0[this.int_0] == null)
			{
				return null;
			}
			return this.vmethod_7().vmethod_4(type_0);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00005E2E File Offset: 0x0000402E
		internal override Class6.Class17 vmethod_7()
		{
			if (this.EqvjjieJlV.class17_0[this.int_0] == null)
			{
				return new Class6.Class29(null);
			}
			return this.EqvjjieJlV.class17_0[this.int_0].vmethod_7();
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00005C40 File Offset: 0x00003E40
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00005E62 File Offset: 0x00004062
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			return class17_0.vmethod_0() && class17_0 is Class6.Class27 && ((Class6.Class27)class17_0).int_0 == this.int_0;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00005E8B File Offset: 0x0000408B
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			return !class17_0.vmethod_0() || !(class17_0 is Class6.Class27) || ((Class6.Class27)class17_0).int_0 != this.int_0;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00005CA5 File Offset: 0x00003EA5
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x0400041B RID: 1051
		private Class6.Class15 EqvjjieJlV;

		// Token: 0x0400041C RID: 1052
		internal int int_0;
	}

	// Token: 0x020000CB RID: 203
	internal class Class28 : Class6.Class23
	{
		// Token: 0x060006E2 RID: 1762 RVA: 0x00005EB7 File Offset: 0x000040B7
		public Class28(Class6.Class17 class17_1, Type type_1)
		{
			this.class17_0 = class17_1;
			this.type_0 = type_1;
			this.enum4_0 = (Class6.Enum4)7;
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00005BCC File Offset: 0x00003DCC
		internal override IntPtr vmethod_10()
		{
			throw new NotImplementedException();
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00005ED4 File Offset: 0x000040D4
		internal override void vmethod_9(Class6.Class17 class17_1)
		{
			if (class17_1 is Class6.Class28)
			{
				this.type_0 = ((Class6.Class28)class17_1).type_0;
				this.class17_0 = ((Class6.Class28)class17_1).class17_0;
				return;
			}
			this.class17_0.vmethod_9(class17_1);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00005BC3 File Offset: 0x00003DC3
		internal override void vmethod_2(Class6.Class17 class17_1)
		{
			this.vmethod_11(class17_1);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00005F0D File Offset: 0x0000410D
		internal override void vmethod_11(Class6.Class17 class17_1)
		{
			this.class17_0 = class17_1;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0003CF24 File Offset: 0x0003B124
		internal override object vmethod_4(Type type_1)
		{
			if (this.class17_0 == null)
			{
				return new Class6.Class29(null);
			}
			if (!(type_1 == null) && !(type_1 == typeof(object)))
			{
				return this.class17_0.vmethod_4(type_1);
			}
			return this.class17_0.vmethod_4(this.type_0);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00005F16 File Offset: 0x00004116
		internal override Class6.Class17 vmethod_7()
		{
			if (this.class17_0 == null)
			{
				return new Class6.Class29(null);
			}
			return this.class17_0.vmethod_7();
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00005C40 File Offset: 0x00003E40
		internal override bool vmethod_8()
		{
			return this.vmethod_7().vmethod_8();
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0003CF7C File Offset: 0x0003B17C
		internal override bool vmethod_5(Class6.Class17 class17_1)
		{
			if (!class17_1.vmethod_0())
			{
				return false;
			}
			if (!(class17_1 is Class6.Class28))
			{
				return false;
			}
			Class6.Class28 @class = (Class6.Class28)class17_1;
			if (@class.type_0 != this.type_0)
			{
				return false;
			}
			if (this.class17_0 == null)
			{
				return @class.class17_0 == null;
			}
			return this.class17_0.vmethod_5(@class.class17_0);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0003CFE0 File Offset: 0x0003B1E0
		internal override bool BeouTiljCp(Class6.Class17 class17_1)
		{
			if (!class17_1.vmethod_0())
			{
				return true;
			}
			if (!(class17_1 is Class6.Class28))
			{
				return true;
			}
			Class6.Class28 @class = (Class6.Class28)class17_1;
			if (@class.type_0 != this.type_0)
			{
				return true;
			}
			if (this.class17_0 == null)
			{
				return @class.class17_0 != null;
			}
			return this.class17_0.BeouTiljCp(@class.class17_0);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00005CA5 File Offset: 0x00003EA5
		internal override bool vmethod_6()
		{
			return this.vmethod_7().vmethod_6();
		}

		// Token: 0x0400041D RID: 1053
		private Class6.Class17 class17_0;

		// Token: 0x0400041E RID: 1054
		private Type type_0;
	}

	// Token: 0x020000CC RID: 204
	internal class Class8
	{
		// Token: 0x0400041F RID: 1055
		public int int_0;

		// Token: 0x04000420 RID: 1056
		public bool UhNjdqxgic;

		// Token: 0x04000421 RID: 1057
		public Class6.Enum1 enum1_0;
	}

	// Token: 0x020000CD RID: 205
	internal class Class9
	{
		// Token: 0x04000422 RID: 1058
		public int int_0;

		// Token: 0x04000423 RID: 1059
		public Class6.Enum1 enum1_0;

		// Token: 0x04000424 RID: 1060
		public bool bool_0;

		// Token: 0x04000425 RID: 1061
		public Type type_0 = typeof(object);
	}

	// Token: 0x020000CE RID: 206
	internal class Class10
	{
		// Token: 0x04000426 RID: 1062
		public int int_0;

		// Token: 0x04000427 RID: 1063
		public int int_1;

		// Token: 0x04000428 RID: 1064
		public Class6.Class11 class11_0;
	}

	// Token: 0x020000CF RID: 207
	internal class Class11
	{
		// Token: 0x04000429 RID: 1065
		public int int_0;

		// Token: 0x0400042A RID: 1066
		public int int_1;

		// Token: 0x0400042B RID: 1067
		public byte byte_0;

		// Token: 0x0400042C RID: 1068
		public Type type_0;

		// Token: 0x0400042D RID: 1069
		public int int_2;

		// Token: 0x0400042E RID: 1070
		public int int_3;
	}

	// Token: 0x020000D0 RID: 208
	internal class Class12
	{
		// Token: 0x0400042F RID: 1071
		internal MethodBase methodBase_0;

		// Token: 0x04000430 RID: 1072
		internal List<Class6.Class7> list_0;

		// Token: 0x04000431 RID: 1073
		internal Class6.Class8[] class8_0;

		// Token: 0x04000432 RID: 1074
		internal List<Class6.Class9> fBcjhfhonR;

		// Token: 0x04000433 RID: 1075
		internal List<Class6.Class10> list_1;
	}

	// Token: 0x020000D1 RID: 209
	private class Class13
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x00005F4A File Offset: 0x0000414A
		public Class13(FieldInfo fieldInfo_1, int int_0)
		{
			this.fieldInfo_0 = fieldInfo_1;
			this.ovMjpUjjfa = int_0;
		}

		// Token: 0x04000434 RID: 1076
		internal FieldInfo fieldInfo_0;

		// Token: 0x04000435 RID: 1077
		internal int ovMjpUjjfa;
	}

	// Token: 0x020000D2 RID: 210
	private class Class14
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00005F60 File Offset: 0x00004160
		public Class14(MethodBase methodBase_1, List<Class6.Class13> list_1)
		{
			this.list_0 = list_1;
			this.methodBase_0 = methodBase_1;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00005F81 File Offset: 0x00004181
		public Class14(MethodBase methodBase_1, Class6.Class13[] class13_0)
		{
			this.list_0.AddRange(class13_0);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0003D044 File Offset: 0x0003B244
		public override bool Equals(object obj)
		{
			Class6.Class14 @class = obj as Class6.Class14;
			if (obj == null)
			{
				return false;
			}
			if (this.methodBase_0 != @class.methodBase_0)
			{
				return false;
			}
			if (this.list_0.Count != @class.list_0.Count)
			{
				return false;
			}
			for (int i = 0; i < this.list_0.Count; i++)
			{
				if (this.list_0[i].fieldInfo_0 != @class.list_0[i].fieldInfo_0)
				{
					return false;
				}
				if (this.list_0[i].ovMjpUjjfa != @class.list_0[i].ovMjpUjjfa)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0003D0F8 File Offset: 0x0003B2F8
		public override int GetHashCode()
		{
			int num = this.methodBase_0.GetHashCode();
			foreach (Class6.Class13 @class in this.list_0)
			{
				int num2 = @class.fieldInfo_0.GetHashCode() + @class.ovMjpUjjfa;
				num = (num ^ num2) + num2;
			}
			return num;
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0003D16C File Offset: 0x0003B36C
		public Class6.Class13 method_0(int int_0)
		{
			foreach (Class6.Class13 @class in this.list_0)
			{
				if (@class.ovMjpUjjfa == int_0)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0003D1CC File Offset: 0x0003B3CC
		public bool method_1(int int_0)
		{
			using (List<Class6.Class13>.Enumerator enumerator = this.list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.ovMjpUjjfa == int_0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x04000436 RID: 1078
		private List<Class6.Class13> list_0 = new List<Class6.Class13>();

		// Token: 0x04000437 RID: 1079
		private MethodBase methodBase_0;
	}

	// Token: 0x020000D3 RID: 211
	// (Invoke) Token: 0x060006FA RID: 1786
	private delegate object Delegate10(object target, object[] paramters);

	// Token: 0x020000D4 RID: 212
	// (Invoke) Token: 0x060006FE RID: 1790
	private delegate object Delegate11(object target);

	// Token: 0x020000D5 RID: 213
	// (Invoke) Token: 0x06000702 RID: 1794
	private delegate void Delegate12(IntPtr a, byte b, int c);

	// Token: 0x020000D6 RID: 214
	// (Invoke) Token: 0x06000706 RID: 1798
	private delegate void Delegate13(IntPtr s, IntPtr t, uint c);

	// Token: 0x020000D7 RID: 215
	internal class Class15
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x0003D22C File Offset: 0x0003B42C
		internal void method_0()
		{
			bool flag = false;
			this.method_2(ref flag);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0003D244 File Offset: 0x0003B444
		internal void method_1()
		{
			this.class31_0.method_1();
			this.class17_1 = null;
			if (this.list_0 != null)
			{
				foreach (IntPtr hglobal in this.list_0)
				{
					try
					{
						Marshal.FreeHGlobal(hglobal);
					}
					catch
					{
					}
				}
				this.list_0.Clear();
				this.list_0 = null;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		internal void method_2(ref bool bool_4)
		{
			while (this.int_0 > -2)
			{
				if (this.bool_0)
				{
					this.bool_0 = false;
					int num = this.int_1;
					int num2 = this.int_0;
					this.method_4(this.int_1, this.int_0);
					this.int_0 = num2;
					this.int_1 = num;
				}
				if (this.bool_2)
				{
					this.bool_2 = false;
					return;
				}
				if (!this.bool_1)
				{
					this.int_1 = this.int_0;
					Class6.Class7 @class = this.class12_0.list_0[this.int_0];
					this.object_0 = @class.object_0;
					try
					{
						this.method_7(@class);
					}
					catch (Exception innerException)
					{
						if (innerException is TargetInvocationException)
						{
							TargetInvocationException ex = (TargetInvocationException)innerException;
							if (ex.InnerException != null)
							{
								innerException = ex.InnerException;
							}
						}
						this.exception_0 = innerException;
						bool_4 = true;
						this.class31_0.method_1();
						int int_ = this.int_1;
						Class6.Class10 class2 = this.method_5(int_, innerException);
						List<Class6.Class10> list = this.method_6(int_, false);
						List<Class6.Class10> list2 = new List<Class6.Class10>();
						if (class2 != null)
						{
							list2.Add(class2);
						}
						if (list != null && list.Count > 0)
						{
							list2.AddRange(list);
						}
						//list2.Sort(new Comparison<Class6.Class10>(Class6.Class15.Class16.<>9.method_0));
						Class6.Class10 class3 = null;
						foreach (Class6.Class10 class4 in list2)
						{
							if (class4.class11_0.int_3 != 0)
							{
								this.class31_0.method_2(new Class6.Class29(innerException));
								this.int_1 = class4.class11_0.int_2;
								this.int_0 = this.int_1;
								this.method_0();
								if (!this.bool_3)
								{
									continue;
								}
								this.bool_3 = false;
								class3 = class4;
							}
							else
							{
								class3 = class4;
							}
							break;
						}
						if (class3 == null)
						{
							throw innerException;
						}
						this.int_2 = class3.class11_0.int_0;
						this.method_3(int_, class3.class11_0.int_0);
						if (this.int_2 >= 0)
						{
							this.class31_0.method_2(new Class6.Class29(innerException));
							this.int_1 = this.int_2;
							this.int_0 = this.int_1;
							this.int_2 = -1;
							this.method_0();
						}
						return;
					}
					this.int_0++;
					continue;
				}
				this.bool_1 = false;
				return;
			}
			this.class31_0.method_1();
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0003D580 File Offset: 0x0003B780
		internal void method_3(int int_3, int int_4)
		{
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 @class in this.class12_0.list_1)
				{
					if ((@class.class11_0.int_3 == 4 || @class.class11_0.int_3 == 2) && @class.class11_0.int_0 >= int_3 && @class.class11_0.int_1 <= int_4)
					{
						this.int_1 = @class.class11_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0003D648 File Offset: 0x0003B848
		internal void method_4(int int_3, int int_4)
		{
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 @class in this.class12_0.list_1)
				{
					if (@class.class11_0.int_3 == 2 && @class.class11_0.int_0 >= int_3 && @class.class11_0.int_1 <= int_4)
					{
						this.int_1 = @class.class11_0.int_0;
						this.int_0 = this.int_1;
						bool flag = false;
						this.method_2(ref flag);
						if (flag)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0003D700 File Offset: 0x0003B900
		internal Class6.Class10 method_5(int int_3, Exception exception_1)
		{
			Class6.Class10 @class = null;
			if (this.class12_0.list_1 != null)
			{
				foreach (Class6.Class10 class2 in this.class12_0.list_1)
				{
					if (class2.class11_0 != null && class2.class11_0.int_3 == 0 && (class2.class11_0.type_0 == exception_1.GetType() || (class2.class11_0.type_0 != null && (class2.class11_0.type_0.FullName == exception_1.GetType().FullName || class2.class11_0.type_0.FullName == typeof(object).FullName || class2.class11_0.type_0.FullName == typeof(Exception).FullName))) && int_3 >= class2.int_0 && int_3 <= class2.int_1)
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (class2.class11_0.int_0 < @class.class11_0.int_0)
						{
							@class = class2;
						}
					}
				}
			}
			return @class;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0003D864 File Offset: 0x0003BA64
		internal List<Class6.Class10> method_6(int int_3, bool bool_4)
		{
			if (this.class12_0.list_1 == null)
			{
				return null;
			}
			List<Class6.Class10> list = new List<Class6.Class10>();
			foreach (Class6.Class10 @class in this.class12_0.list_1)
			{
				if ((@class.class11_0.int_3 & 1) == 1 && int_3 >= @class.int_0 && int_3 <= @class.int_1)
				{
					list.Add(@class);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0003D900 File Offset: 0x0003BB00
		private unsafe void method_7(Class6.Class7 class7_0)
		{
			switch (class7_0.enum3_0)
			{
			case (Class6.Enum3)0:
				this.int_0 = (int)this.object_0 - 1;
				this.bool_0 = true;
				return;
			case (Class6.Enum3)1:
			case (Class6.Enum3)23:
			case (Class6.Enum3)26:
			case (Class6.Enum3)37:
			case (Class6.Enum3)83:
			case (Class6.Enum3)149:
				throw new Class6.Exception1();
			case (Class6.Enum3)2:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_80(@class))
				{
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(0));
				return;
			}
			case (Class6.Enum3)3:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_41());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)4:
			case (Class6.Enum3)45:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj = @class.vmethod_4(type);
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class6.Class15.smethod_8(obj);
					}
					@class = Class6.Class17.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					@class = Class6.Class17.smethod_1(type, obj);
				}
				else
				{
					@class = new Class6.Class29(null);
				}
				Class6.Class23 class3 = this.class31_0.method_4() as Class6.Class23;
				if (class3 == null)
				{
					throw new Class6.Exception1();
				}
				class3.vmethod_9(@class);
				return;
			}
			case (Class6.Enum3)5:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_46();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)6:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_28());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19(*(uint*)((void*)intPtr), (Class6.Enum1)6));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)7:
			case (Class6.Enum3)16:
			case (Class6.Enum3)20:
			case (Class6.Enum3)21:
			case (Class6.Enum3)39:
			case (Class6.Enum3)61:
			case (Class6.Enum3)137:
			case (Class6.Enum3)174:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array = (Array)this.class31_0.method_4().vmethod_4(null);
				Type type = array.GetType().GetElementType();
				array.SetValue(@class.vmethod_4(type), class2.vmethod_18().struct4_0.int_0);
				return;
			}
			case (Class6.Enum3)8:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_4(fieldInfo.FieldType);
				fieldInfo.SetValue(null, obj);
				return;
			}
			case (Class6.Enum3)9:
				this.class31_0.method_4();
				return;
			case (Class6.Enum3)10:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)11:
				this.int_0 = (int)this.object_0 - 1;
				return;
			case (Class6.Enum3)12:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_27());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19((int)(*(ushort*)((void*)intPtr)), (Class6.Enum1)4));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)13:
				this.bool_2 = true;
				return;
			case (Class6.Enum3)14:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_23());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19((int)(*(short*)((void*)intPtr)), (Class6.Enum1)3));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)15:
				this.method_12(true);
				return;
			case (Class6.Enum3)17:
			{
				Class6.Class18 class4 = Class6.Class15.smethod_1(this.class31_0.method_3());
				if (class4 == null)
				{
					throw new ArithmeticException(((Class6.Enum5)0).ToString());
				}
				Class6.Class22 class5 = class4 as Class6.Class22;
				if (class5 != null)
				{
					if (double.IsNaN(class5.double_0))
					{
						throw new OverflowException(((Class6.Enum5)2).ToString());
					}
					if (double.IsInfinity(class5.double_0))
					{
						throw new OverflowException(((Class6.Enum5)1).ToString());
					}
				}
				return;
			}
			case (Class6.Enum3)18:
				this.bool_3 = (bool)this.class31_0.method_4().vmethod_4(typeof(bool));
				this.bool_1 = true;
				return;
			case (Class6.Enum3)19:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(float), obj));
				return;
			}
			case (Class6.Enum3)22:
				this.class31_0.method_2(new Class6.Class22((float)this.object_0));
				return;
			case (Class6.Enum3)24:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_22();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)25:
				this.class31_0.method_2(new Class6.Class19((int)this.object_0));
				return;
			case (Class6.Enum3)27:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_4(null);
				this.class31_0.method_2(Class6.Class17.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(obj)));
				return;
			}
			case (Class6.Enum3)28:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_48();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)29:
			case (Class6.Enum3)33:
			case (Class6.Enum3)131:
			case (Class6.Enum3)135:
			case (Class6.Enum3)167:
			case (Class6.Enum3)168:
				return;
			case (Class6.Enum3)30:
			{
				int num = (int)this.object_0;
				uint num2 = (uint)Class6.Class15.smethod_0(typeof(Class6).Module.ResolveType(num));
				this.class31_0.method_2(new Class6.Class19(num2, (Class6.Enum1)6));
				return;
			}
			case (Class6.Enum3)31:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_75(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)32:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_22());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)34:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(short), obj));
				return;
			}
			case (Class6.Enum3)35:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_25());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)36:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_28());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)38:
				return;
			case (Class6.Enum3)40:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class23 class6 = this.class31_0.method_4() as Class6.Class23;
				if (class6 == null)
				{
					throw new Class6.Exception1();
				}
				object obj = class6.vmethod_4(type);
				Class6.Class17 @class;
				if (obj != null)
				{
					if (type.IsValueType)
					{
						obj = Class6.Class15.smethod_8(obj);
					}
					@class = Class6.Class17.smethod_1(type, obj);
				}
				else if (type.IsValueType)
				{
					obj = Activator.CreateInstance(type);
					@class = Class6.Class17.smethod_1(type, obj);
				}
				else
				{
					@class = new Class6.Class29(null);
				}
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)41:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class7 != null)
				{
					this.class31_0.method_2(class2.vmethod_68(class7));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)42:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_77(@class))
				{
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(0));
				return;
			}
			case (Class6.Enum3)43:
			{
				Class6.Class17 class8 = this.class31_0.method_4();
				Class6.Class17 @class = this.class31_0.method_4();
				if (class8.vmethod_5(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)44:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_64(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)46:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array2 = (Array)this.class31_0.method_4().vmethod_4(null);
				object obj = array2.GetValue(class2.vmethod_18().struct4_0.int_0);
				Type type = array2.GetType().GetElementType();
				this.class31_0.method_2(Class6.Class17.smethod_1(type, obj));
				return;
			}
			case (Class6.Enum3)47:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(uint), obj));
				return;
			}
			case (Class6.Enum3)48:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_72(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)49:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(ushort), obj));
				return;
			}
			case (Class6.Enum3)50:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_66(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)51:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_45());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class22(*(float*)((void*)intPtr), (Class6.Enum1)9));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)52:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_62(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)53:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_74(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)54:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(byte), obj));
				return;
			}
			case (Class6.Enum3)55:
			{
				Class6.Class17 class9 = Class6.Class15.smethod_6(this.class31_0.method_4());
				Class6.Class17 @class = Class6.Class15.smethod_6(this.class31_0.method_4());
				if (class9.vmethod_5(@class))
				{
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(0));
				return;
			}
			case (Class6.Enum3)56:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(sbyte), obj));
				return;
			}
			case (Class6.Enum3)57:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_73(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)58:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_77(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)59:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_27());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)60:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				this.class31_0.method_2(Class6.Class17.smethod_1(fieldInfo.FieldType, fieldInfo.GetValue(null)));
				return;
			}
			case (Class6.Enum3)62:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				bool flag = Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_81(@class);
				if (flag)
				{
					this.class31_0.method_2(new Class6.Class19(1));
					if (!flag)
					{
						return;
					}
				}
				else
				{
					this.class31_0.method_2(new Class6.Class19(0));
					if (!flag)
					{
						return;
					}
				}
				this.int_0 = (int)this.object_0 - 1;
				return;
			}
			case (Class6.Enum3)63:
				this.class31_0.method_2(this.class31_0.method_3());
				return;
			case (Class6.Enum3)64:
				this.method_12(false);
				return;
			case (Class6.Enum3)65:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_42());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)66:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_78(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)67:
			{
				object obj = Class6.Class15.object_2;
				lock (obj)
				{
					Class6.Class17 @class = this.class31_0.method_4();
					object obj2 = this.class31_0.method_4().vmethod_4(null);
					Class6.Class15.dictionary_1[obj2] = @class;
				}
				return;
			}
			case (Class6.Enum3)68:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_25();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)69:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				Class6.Class17 class10 = this.class31_0.method_4();
				class10.vmethod_7();
				object obj = class10.vmethod_4(null);
				this.class31_0.method_2(new Class6.Class26(fieldInfo, obj));
				return;
			}
			case (Class6.Enum3)70:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_26());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)71:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_24();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)72:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_80(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)73:
				if (Class6.list_0.Count == 0)
				{
					Module module = typeof(Class6).Module;
					this.class31_0.method_2(new Class6.Class30(module.ResolveString((int)this.object_0 | 1879048192)));
					return;
				}
				this.class31_0.method_2(new Class6.Class30(Class6.list_0[(int)this.object_0]));
				return;
			case (Class6.Enum3)74:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_49());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)75:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_29());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)76:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_40());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)77:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_57(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)78:
			{
				int num = (int)this.object_0;
				typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array3 = (Array)this.class31_0.method_4().vmethod_4(null);
				this.class31_0.method_2(new Class6.Class25(class2.vmethod_18().struct4_0.int_0, array3));
				return;
			}
			case (Class6.Enum3)79:
				throw (Exception)this.class31_0.method_4().vmethod_4(null);
			case (Class6.Enum3)80:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class6).Module;
				object obj = null;
				try
				{
					obj = module.ResolveType(num);
				}
				catch
				{
					try
					{
						obj = module.ResolveMethod(num);
					}
					catch
					{
						try
						{
							obj = module.ResolveField(num);
						}
						catch
						{
							obj = module.ResolveMember(num);
						}
					}
				}
				this.class31_0.method_2(new Class6.Class29(obj));
				return;
			}
			case (Class6.Enum3)81:
			{
				int num = (int)this.object_0;
				this.class17_1[num] = this.method_8(this.class31_0.method_4(), this.class12_0.fBcjhfhonR[num].enum1_0, this.class12_0.fBcjhfhonR[num].bool_0);
				return;
			}
			case (Class6.Enum3)82:
				this.class31_0.method_2(((Class6.Class18)this.class31_0.method_4()).vmethod_54());
				return;
			case (Class6.Enum3)84:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_63(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)85:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(long), obj));
				return;
			}
			case (Class6.Enum3)86:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_31());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)87:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				Class6.Class17 class17_ = this.class31_0.method_4();
				Class6.Class18 class7 = Class6.Class15.smethod_1(class17_);
				if (class7 != null && class2 != null)
				{
					if (class7.lwlumgaheq(@class))
					{
						this.int_0 = (int)this.object_0 - 1;
					}
					return;
				}
				if (@class.BeouTiljCp(class17_))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)88:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_45());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)89:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_35());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)90:
			{
				IntPtr intPtr = Marshal.AllocHGlobal((this.class31_0.method_4() as Class6.Class18).vmethod_18().struct4_0.int_0);
				if (this.list_0 == null)
				{
					this.list_0 = new List<IntPtr>();
				}
				this.list_0.Add(intPtr);
				this.class31_0.method_2(new Class6.Class21(intPtr));
				return;
			}
			case (Class6.Enum3)91:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_61(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)92:
			{
				Array array3 = (Array)this.class31_0.method_4().vmethod_4(null);
				this.class31_0.method_2(new Class6.Class19(array3.Length, (Class6.Enum1)5));
				return;
			}
			case (Class6.Enum3)93:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.usfdqHavse());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)94:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_23());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)95:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_47());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)96:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_81(@class))
				{
					this.class31_0.method_2(new Class6.Class19(1));
					return;
				}
				this.class31_0.method_2(new Class6.Class19(0));
				return;
			}
			case (Class6.Enum3)97:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_39());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)98:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_76(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)99:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_48());
					return;
				}
				if (class2 == null || !class2.method_2())
				{
					throw new Class6.Exception1();
				}
				IntPtr intPtr = ((Class6.Class21)class2).method_6();
				if (IntPtr.Size == 8)
				{
					long num3 = *(long*)((void*)intPtr);
					this.class31_0.method_2(new Class6.Class21(num3, (Class6.Enum1)12));
					return;
				}
				int num = *(int*)((void*)intPtr);
				this.class31_0.method_2(new Class6.Class21((long)num, (Class6.Enum1)12));
				return;
			}
			case (Class6.Enum3)100:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_52());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)101:
				this.class31_0.method_2(new Class6.Class24((int)this.object_0, this));
				return;
			case (Class6.Enum3)102:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_24());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)103:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_32());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)104:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_55(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)105:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_22());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19((int)(*(sbyte*)((void*)intPtr)), (Class6.Enum1)1));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)106:
			{
				int num = (int)this.object_0;
				Module module = typeof(Class6).Module;
				this.class31_0.method_2(new Class6.Class21(module.ResolveMethod(num).MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class6.Enum3)107:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class != null && @class.vmethod_6())
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)108:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_69());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)109:
			{
				int num = (int)this.object_0;
				Type elementType = typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Array array3 = Array.CreateInstance(elementType, class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(new Class6.Class29(array3));
				return;
			}
			case (Class6.Enum3)110:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_65(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)111:
			{
				Class6.Class18 class2 = this.class31_0.method_4() as Class6.Class18;
				IntPtr intPtr = Class6.Class15.bltXeOrHnB(this.class31_0.method_4());
				IntPtr intPtr2 = Class6.Class15.bltXeOrHnB(this.class31_0.method_4());
				if (intPtr != IntPtr.Zero && intPtr2 != IntPtr.Zero)
				{
					uint num2 = class2.vmethod_19().struct4_0.uint_0;
					Class6.Class15.smethod_10(intPtr2, intPtr, num2);
				}
				return;
			}
			case (Class6.Enum3)112:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_33());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)113:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_46());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class22(*(double*)((void*)intPtr), (Class6.Enum1)10));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)114:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				((Array)this.class31_0.method_4().vmethod_4(null)).SetValue(@class.vmethod_4(type), class2.vmethod_18().struct4_0.int_0);
				return;
			}
			case (Class6.Enum3)115:
				this.class31_0.method_2(new Class6.Class29(null));
				return;
			case (Class6.Enum3)116:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_45();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)117:
			{
				int num = (int)this.object_0;
				ConstructorInfo constructorInfo = (ConstructorInfo)typeof(Class6).Module.ResolveMethod(num);
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				object[] array4 = new object[parameters.Length];
				Class6.Class17[] array5 = new Class6.Class17[parameters.Length];
				List<Class6.Class13> list = null;
				Class6.Class14 class11 = null;
				for (int i = 0; i < parameters.Length; i++)
				{
					Class6.Class17 @class = this.class31_0.method_4();
					Type type = parameters[parameters.Length - 1 - i].ParameterType;
					object obj2 = null;
					bool flag2 = false;
					if (type.IsByRef)
					{
						Class6.Class26 class12 = @class as Class6.Class26;
						if (class12 != null)
						{
							if (list == null)
							{
								list = new List<Class6.Class13>();
							}
							list.Add(new Class6.Class13(class12.fieldInfo_0, parameters.Length - 1 - i));
							obj2 = class12.object_0;
							if (obj2 is Class6.Class17)
							{
								@class = (obj2 as Class6.Class17);
							}
							else
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						if (@class != null)
						{
							obj2 = @class.vmethod_4(type);
						}
						if (obj2 == null)
						{
							if (type.IsByRef)
							{
								type = type.GetElementType();
							}
							if (type.IsValueType)
							{
								obj2 = Activator.CreateInstance(type);
								if (@class is Class6.Class24)
								{
									((Class6.Class23)@class).vmethod_11(Class6.Class17.smethod_1(type, obj2));
								}
							}
						}
					}
					array5[array4.Length - 1 - i] = @class;
					array4[array4.Length - 1 - i] = obj2;
				}
				Class6.Delegate10 @delegate = null;
				if (list != null)
				{
					class11 = new Class6.Class14(constructorInfo, list);
					@delegate = Class6.Class15.smethod_4(constructorInfo, true, class11);
				}
				object obj = null;
				if (@delegate != null)
				{
					obj = @delegate(null, array4);
				}
				else
				{
					obj = constructorInfo.Invoke(array4);
				}
				for (int j = 0; j < parameters.Length; j++)
				{
					if (parameters[j].ParameterType.IsByRef && (class11 == null || !class11.method_1(j)))
					{
						if (array5[j].method_2())
						{
							((Class6.Class21)array5[j]).method_5(Class6.Class17.smethod_1(parameters[j].ParameterType, array4[j]));
						}
						else if (array5[j] is Class6.Class24)
						{
							array5[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType.GetElementType(), array4[j]));
						}
						else
						{
							array5[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType, array4[j]));
						}
					}
				}
				this.class31_0.method_2(Class6.Class17.smethod_1(constructorInfo.DeclaringType, obj));
				return;
			}
			case (Class6.Enum3)118:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				object obj = this.class31_0.method_4().vmethod_4(fieldInfo.FieldType);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj2 = @class.vmethod_4(null);
				if (obj2 == null)
				{
					Type type = fieldInfo.DeclaringType;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					if (!type.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type);
					if (@class is Class6.Class24)
					{
						((Class6.Class23)@class).vmethod_11(Class6.Class17.smethod_1(type, obj2));
					}
				}
				fieldInfo.SetValue(obj2, obj);
				return;
			}
			case (Class6.Enum3)119:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_30());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)120:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_50());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)121:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_56(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)122:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(IntPtr), obj));
				return;
			}
			case (Class6.Enum3)123:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class17 @class = this.class31_0.method_4();
				object obj = @class.vmethod_4(null);
				if (obj == null)
				{
					this.class31_0.method_2(new Class6.Class29(null));
					return;
				}
				if (!type.IsAssignableFrom(obj.GetType()))
				{
					this.class31_0.method_2(new Class6.Class29(null));
					return;
				}
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)124:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_51());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)125:
				this.class31_0.method_2(new Class6.Class22((double)this.object_0));
				return;
			case (Class6.Enum3)126:
				this.int_0 = -3;
				if (this.class31_0.method_0() > 0)
				{
					this.class17_2 = this.class31_0.method_4();
				}
				return;
			case (Class6.Enum3)127:
				this.class31_0.method_2(this.class31_0.method_4().vmethod_7());
				return;
			case (Class6.Enum3)128:
			{
				int num = (int)this.object_0;
				FieldInfo fieldInfo = typeof(Class6).Module.ResolveField(num);
				this.class31_0.method_2(new Class6.Class26(fieldInfo, null));
				return;
			}
			case (Class6.Enum3)129:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_53());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)130:
			{
				int[] array6 = (int[])this.object_0;
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				long num3 = class2.vmethod_20().struct5_0.long_0;
				if ((num3 < 0L || class2.method_4()) && IntPtr.Size == 4)
				{
					num3 = (long)((int)num3);
				}
				if (class2.method_1())
				{
					Class6.Class19 class13 = (Class6.Class19)class2;
					if (class13.enum1_0 == (Class6.Enum1)6)
					{
						num3 = (long)((ulong)class13.struct4_0.uint_0);
					}
				}
				if (num3 < (long)array6.Length && num3 >= 0L)
				{
					this.int_0 = array6[(int)(checked((IntPtr)num3))] - 1;
				}
				return;
			}
			case (Class6.Enum3)132:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.Add(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)133:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				Class6.Class17 class17_ = this.class31_0.method_4();
				Class6.Class18 class7 = Class6.Class15.smethod_1(class17_);
				if (class7 != null && class2 != null)
				{
					if (class7.lwlumgaheq(@class))
					{
						this.class31_0.method_2(new Class6.Class19(1));
						return;
					}
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				else
				{
					if (@class.BeouTiljCp(class17_))
					{
						this.class31_0.method_2(new Class6.Class19(1));
						return;
					}
					this.class31_0.method_2(new Class6.Class19(0));
					return;
				}
				break;
			}
			case (Class6.Enum3)134:
				this.class31_0.method_2(new Class6.Class20((long)this.object_0));
				return;
			case (Class6.Enum3)136:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class7 != null)
				{
					this.class31_0.method_2(class2.vmethod_67(class7));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)138:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_38());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)139:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				object obj = this.class31_0.method_4().vmethod_7().vmethod_4(type);
				Class6.Class17 @class = Class6.Class17.smethod_1(type, obj);
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)140:
				this.class31_0.method_2(this.class17_0[(int)this.object_0]);
				return;
			case (Class6.Enum3)141:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_48());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)142:
			{
				Class6.Class17 @class = this.class17_1[(int)this.object_0];
				this.class31_0.method_2(@class);
				return;
			}
			case (Class6.Enum3)143:
			{
				Type type = typeof(Class6).Module.ResolveType((int)this.object_0);
				object obj = this.class31_0.method_4().vmethod_4(type);
				if (obj == null)
				{
					obj = Activator.CreateInstance(type);
				}
				Class6.Class29 class14 = new Class6.Class29(Class6.Class17.smethod_1(type, Class6.Class15.smethod_8(obj)));
				this.class31_0.method_2(class14);
				return;
			}
			case (Class6.Enum3)144:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = (Class6.Class18)this.class31_0.method_4();
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_58(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)145:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_37());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)146:
				if (this.class31_0.method_4().BeouTiljCp(this.class31_0.method_4()))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			case (Class6.Enum3)147:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_24());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19(*(int*)((void*)intPtr), (Class6.Enum1)5));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)148:
			{
				Class6.Class18 class2 = this.class31_0.method_4() as Class6.Class18;
				Class6.Class18 class7 = this.class31_0.method_4() as Class6.Class18;
				IntPtr intPtr = Class6.Class15.bltXeOrHnB(this.class31_0.method_4());
				if (intPtr != IntPtr.Zero)
				{
					byte byte_ = class7.vmethod_15().struct4_0.byte_0;
					uint num2 = class2.vmethod_19().struct4_0.uint_0;
					Class6.Class15.smethod_9(intPtr, byte_, (int)num2);
				}
				return;
			}
			case (Class6.Enum3)150:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_44());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)151:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_60(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)152:
			{
				int num = (int)this.object_0;
				if (this.class12_0.methodBase_0.IsStatic)
				{
					this.class17_0[num] = this.method_8(this.class31_0.method_4(), this.class12_0.class8_0[num].enum1_0, false);
					return;
				}
				this.class17_0[num] = this.method_8(this.class31_0.method_4(), this.class12_0.class8_0[num - 1].enum1_0, false);
				return;
			}
			case (Class6.Enum3)153:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(type, obj));
				return;
			}
			case (Class6.Enum3)154:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_3())
				{
					@class = ((Class6.Class18)@class).vmethod_23();
				}
				this.class31_0.method_4().vmethod_2(@class);
				return;
			}
			case (Class6.Enum3)155:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (@class.vmethod_0())
				{
					object obj = @class.vmethod_4(null);
					if (obj != null)
					{
						@class = Class6.Class17.smethod_1(obj.GetType(), obj);
					}
					else
					{
						@class = new Class6.Class29(null);
					}
					this.class31_0.method_2(@class);
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)156:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_26());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class19((int)(*(byte*)((void*)intPtr)), (Class6.Enum1)2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)157:
			{
				bool flag2 = false;
				Class6.Class17 @class = this.class31_0.method_4();
				flag2 = (@class == null || !@class.vmethod_6());
				if (flag2)
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)158:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(double), obj));
				return;
			}
			case (Class6.Enum3)159:
			{
				int num = (int)this.object_0;
				Type type = typeof(Class6).Module.ResolveType(num);
				Class6.Class23 class15 = this.class31_0.method_4() as Class6.Class23;
				if (class15 == null)
				{
					throw new Class6.Exception1();
				}
				if (type.IsValueType)
				{
					object obj = Activator.CreateInstance(type);
					class15.vmethod_11(Class6.Class17.smethod_1(type, obj));
					return;
				}
				class15.vmethod_11(new Class6.Class29(null));
				return;
			}
			case (Class6.Enum3)160:
				this.class31_0.method_2(new Class6.Class27((int)this.object_0, this));
				return;
			case (Class6.Enum3)161:
				throw this.exception_0;
			case (Class6.Enum3)162:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				Class6.Class18 class2 = Class6.Class15.smethod_1(@class);
				if (@class != null && @class.vmethod_0() && class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_25());
					return;
				}
				if (class2 != null && class2.method_2())
				{
					IntPtr intPtr = ((Class6.Class21)class2).method_6();
					this.class31_0.method_2(new Class6.Class20(*(long*)((void*)intPtr), (Class6.Enum1)7));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)163:
			{
				int num = (int)this.object_0;
				MethodBase methodBase = typeof(Class6).Module.ResolveMethod(num);
				Type type = this.class31_0.method_4().vmethod_4(null).GetType();
				List<Type> list2 = new List<Type>();
				do
				{
					list2.Add(type);
					type = type.BaseType;
				}
				while (type != null && type != methodBase.DeclaringType);
				list2.Reverse();
				MethodBase methodBase2 = methodBase;
				foreach (Type type2 in list2)
				{
					foreach (MethodInfo methodInfo in type2.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
					{
						if (methodInfo.GetBaseDefinition() == methodBase2)
						{
							methodBase2 = methodInfo;
							break;
						}
					}
				}
				this.class31_0.method_2(new Class6.Class21(methodBase2.MethodHandle.GetFunctionPointer()));
				return;
			}
			case (Class6.Enum3)164:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null && class7 != null)
				{
					this.class31_0.method_2(class2.vmethod_70(class7));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)165:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				Class6.Class18 class7 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class7 != null && class2 != null)
				{
					this.class31_0.method_2(class7.vmethod_59(class2));
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)166:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_46());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)169:
			{
				Class6.Class17 @class = this.class31_0.method_4();
				if (Class6.Class15.smethod_1(this.class31_0.method_4()).vmethod_79(@class))
				{
					this.int_0 = (int)this.object_0 - 1;
				}
				return;
			}
			case (Class6.Enum3)170:
			{
				object obj = Class6.Class15.object_2;
				lock (obj)
				{
					object obj2 = this.class31_0.method_4().vmethod_4(null);
					Class6.Class17 @class = null;
					if (Class6.Class15.dictionary_1.TryGetValue(obj2, out @class))
					{
						this.class31_0.method_2(@class);
					}
					else
					{
						this.class31_0.method_2(new Class6.Class29(null));
					}
				}
				return;
			}
			case (Class6.Enum3)171:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				object obj = ((Array)this.class31_0.method_4().vmethod_4(null)).GetValue(class2.vmethod_18().struct4_0.int_0);
				this.class31_0.method_2(Class6.Class17.smethod_1(typeof(int), obj));
				return;
			}
			case (Class6.Enum3)172:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_43());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)173:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 != null)
				{
					this.class31_0.method_2(class2.vmethod_36());
					return;
				}
				throw new Class6.Exception1();
			}
			case (Class6.Enum3)175:
			{
				Class6.Class18 class2 = Class6.Class15.smethod_1(this.class31_0.method_4());
				if (class2 == null)
				{
					throw new Class6.Exception1();
				}
				this.class31_0.method_2(class2.vmethod_34());
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00040988 File Offset: 0x0003EB88
		private Class6.Class17 method_8(Class6.Class17 class17_3, Class6.Enum1 enum1_0, bool bool_4 = false)
		{
			if (!bool_4 && class17_3.vmethod_0())
			{
				class17_3 = class17_3.vmethod_7();
			}
			if (class17_3.method_1())
			{
				return ((Class6.Class19)class17_3).vmethod_12(enum1_0);
			}
			if (class17_3.method_3())
			{
				return ((Class6.Class20)class17_3).vmethod_12(enum1_0);
			}
			if (class17_3.method_4())
			{
				return ((Class6.Class22)class17_3).vmethod_12(enum1_0);
			}
			if (class17_3.method_2())
			{
				return ((Class6.Class21)class17_3).vmethod_12(enum1_0);
			}
			return class17_3;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00005FA0 File Offset: 0x000041A0
		private Class6.Class17 method_9(int int_3)
		{
			return this.class17_1[int_3];
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00005FAA File Offset: 0x000041AA
		private void method_10(int int_3)
		{
			this.method_11(int_3, this.class31_0.method_4());
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00040A00 File Offset: 0x0003EC00
		private static int smethod_0(Type type_0)
		{
			object obj = Class6.Class15.object_1;
			int result;
			lock (obj)
			{
				if (Class6.Class15.dictionary_0 == null)
				{
					Class6.Class15.dictionary_0 = new Dictionary<Type, int>();
				}
				try
				{
					int num = 0;
					if (Class6.Class15.dictionary_0.TryGetValue(type_0, out num))
					{
						result = num;
					}
					else
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(int), Type.EmptyTypes, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Sizeof, type_0);
						ilgenerator.Emit(OpCodes.Ret);
						num = (int)dynamicMethod.Invoke(null, null);
						Class6.Class15.dictionary_0[type_0] = num;
						result = num;
					}
				}
				catch
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00005FBE File Offset: 0x000041BE
		private void method_11(int int_3, Class6.Class17 class17_3)
		{
			this.class17_1[int_3] = this.method_8(class17_3, this.class12_0.fBcjhfhonR[int_3].enum1_0, this.class12_0.fBcjhfhonR[int_3].bool_0);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00039250 File Offset: 0x00037450
		private static Class6.Class18 smethod_1(Class6.Class17 class17_3)
		{
			Class6.Class18 @class = class17_3 as Class6.Class18;
			if (@class == null && class17_3.vmethod_0())
			{
				@class = (class17_3.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00040AC4 File Offset: 0x0003ECC4
		private void method_12(bool bool_4)
		{
			int metadataToken = (int)this.object_0;
			MethodBase methodBase = typeof(Class6).Module.ResolveMethod(metadataToken);
			MethodInfo methodInfo = methodBase as MethodInfo;
			ParameterInfo[] parameters = methodBase.GetParameters();
			object[] array = new object[parameters.Length];
			Class6.Class17[] array2 = new Class6.Class17[parameters.Length];
			List<Class6.Class13> list = null;
			Class6.Class14 @class = null;
			for (int i = 0; i < parameters.Length; i++)
			{
				Class6.Class17 class2 = this.class31_0.method_4();
				Type type = parameters[parameters.Length - 1 - i].ParameterType;
				object obj = null;
				bool flag = false;
				if (type.IsByRef)
				{
					Class6.Class26 class3 = class2 as Class6.Class26;
					if (class3 != null)
					{
						if (list == null)
						{
							list = new List<Class6.Class13>();
						}
						list.Add(new Class6.Class13(class3.fieldInfo_0, parameters.Length - 1 - i));
						obj = class3.object_0;
						if (obj is Class6.Class17)
						{
							class2 = (obj as Class6.Class17);
						}
						else
						{
							flag = true;
							if (obj == null)
							{
								if (type.IsByRef)
								{
									type = type.GetElementType();
								}
								if (type.IsValueType)
								{
									if (class3.fieldInfo_0.IsStatic)
									{
										obj = class3.fieldInfo_0.GetValue(null);
									}
									else
									{
										obj = Activator.CreateInstance(type);
									}
									if (class2 is Class6.Class24)
									{
										((Class6.Class23)class2).vmethod_11(Class6.Class17.smethod_1(type, obj));
									}
								}
							}
						}
					}
				}
				if (!flag)
				{
					if (class2 != null)
					{
						obj = class2.vmethod_4(type);
					}
					if (obj == null)
					{
						if (type.IsByRef)
						{
							type = type.GetElementType();
						}
						if (type.IsValueType)
						{
							obj = Activator.CreateInstance(type);
							if (class2 is Class6.Class24)
							{
								((Class6.Class23)class2).vmethod_11(Class6.Class17.smethod_1(type, obj));
							}
						}
					}
				}
				array2[array.Length - 1 - i] = class2;
				array[array.Length - 1 - i] = obj;
			}
			Class6.Delegate10 @delegate = null;
			if (list != null)
			{
				@class = new Class6.Class14(methodBase, list);
				@delegate = Class6.Class15.smethod_3(methodBase, bool_4, @class);
			}
			else if (methodInfo != null && methodInfo.ReturnType.IsByRef)
			{
				@delegate = Class6.Class15.smethod_2(methodBase, bool_4);
			}
			object obj2 = null;
			Class6.Class17 class4 = null;
			if (!methodBase.IsStatic)
			{
				class4 = this.class31_0.method_4();
				if (class4 != null)
				{
					obj2 = class4.vmethod_4(methodBase.DeclaringType);
				}
				if (obj2 == null)
				{
					Type type2 = methodBase.DeclaringType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
					}
					if (!type2.IsValueType)
					{
						throw new NullReferenceException();
					}
					obj2 = Activator.CreateInstance(type2);
					if (obj2 == null && Nullable.GetUnderlyingType(type2) != null)
					{
						obj2 = FormatterServices.GetUninitializedObject(type2);
					}
					if (class4 is Class6.Class24)
					{
						((Class6.Class23)class4).vmethod_11(Class6.Class17.smethod_1(type2, obj2));
					}
				}
			}
			object obj3;
			if (methodBase is ConstructorInfo && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
			{
				obj3 = array[0];
				if (class4 != null && class4 is Class6.Class24)
				{
					((Class6.Class23)class4).vmethod_11(Class6.Class17.smethod_1(Nullable.GetUnderlyingType(methodBase.DeclaringType), obj3));
				}
			}
			else if (@delegate != null)
			{
				obj3 = @delegate(obj2, array);
			}
			else
			{
				obj3 = methodBase.Invoke(obj2, array);
			}
			for (int j = 0; j < parameters.Length; j++)
			{
				if (parameters[j].ParameterType.IsByRef && (@class == null || !@class.method_1(j)))
				{
					if (array2[j].method_2())
					{
						((Class6.Class21)array2[j]).method_5(Class6.Class17.smethod_1(parameters[j].ParameterType, array[j]));
					}
					else if (array2[j] is Class6.Class24)
					{
						array2[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType.GetElementType(), array[j]));
					}
					else
					{
						array2[j].vmethod_9(Class6.Class17.smethod_1(parameters[j].ParameterType, array[j]));
					}
				}
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				this.class31_0.method_2(Class6.Class17.smethod_1(methodInfo.ReturnType, obj3));
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00040ED4 File Offset: 0x0003F0D4
		private static Class6.Delegate10 smethod_2(MethodBase methodBase_0, bool bool_4)
		{
			object obj = Class6.Class15.object_3;
			Class6.Delegate10 result2;
			lock (obj)
			{
				Class6.Delegate10 result = null;
				if (bool_4)
				{
					if (Class6.Class15.dictionary_2.TryGetValue(methodBase_0, out result))
					{
						return result;
					}
				}
				else if (Class6.Class15.dictionary_3.TryGetValue(methodBase_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					array2[j] = ilgenerator.DeclareLocal(array[j]);
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class6.Class15.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (array[k].IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
					}
					else if (array[k] != typeof(object))
					{
						ilgenerator.Emit(OpCodes.Castclass, array[k]);
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (parameters[l].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class6.Class15.smethod_5(ilgenerator, m);
						ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
						if (array2[m].LocalType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
						}
						ilgenerator.Emit(OpCodes.Stelem_Ref);
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Delegate10 @delegate = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
				if (bool_4)
				{
					Class6.Class15.dictionary_2.Add(methodBase_0, @delegate);
				}
				else
				{
					Class6.Class15.dictionary_3.Add(methodBase_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00041370 File Offset: 0x0003F570
		private static Class6.Delegate10 smethod_3(MethodBase methodBase_0, bool bool_4, Class6.Class14 class14_0)
		{
			object obj = Class6.Class15.object_4;
			Class6.Delegate10 result2;
			lock (obj)
			{
				Class6.Delegate10 result = null;
				if (bool_4)
				{
					if (Class6.Class15.dictionary_4.TryGetValue(class14_0, out result))
					{
						return result;
					}
				}
				else if (Class6.Class15.dictionary_5.TryGetValue(class14_0, out result))
				{
					return result;
				}
				MethodInfo methodInfo = methodBase_0 as MethodInfo;
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
				{
					typeof(object),
					typeof(object[])
				}, typeof(Class6), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Type[] array = new Type[parameters.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (parameters[i].ParameterType.IsByRef)
					{
						array[i] = parameters[i].ParameterType.GetElementType();
					}
					else
					{
						array[i] = parameters[i].ParameterType;
					}
				}
				int num = array.Length;
				if (methodBase_0.DeclaringType.IsValueType)
				{
					num++;
				}
				LocalBuilder[] array2 = new LocalBuilder[num];
				for (int j = 0; j < array.Length; j++)
				{
					if (class14_0.method_1(j))
					{
						array2[j] = ilgenerator.DeclareLocal(typeof(object));
					}
					else
					{
						array2[j] = ilgenerator.DeclareLocal(array[j]);
					}
				}
				if (methodBase_0.DeclaringType.IsValueType)
				{
					array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
				}
				for (int k = 0; k < array.Length; k++)
				{
					ilgenerator.Emit(OpCodes.Ldarg_1);
					Class6.Class15.smethod_5(ilgenerator, k);
					ilgenerator.Emit(OpCodes.Ldelem_Ref);
					if (!class14_0.method_1(k))
					{
						if (array[k].IsValueType)
						{
							ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
						}
						else if (array[k] != typeof(object))
						{
							ilgenerator.Emit(OpCodes.Castclass, array[k]);
						}
					}
					ilgenerator.Emit(OpCodes.Stloc, array2[k]);
				}
				if (!methodBase_0.IsStatic)
				{
					ilgenerator.Emit(OpCodes.Ldarg_0);
					if (methodBase_0.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Unbox, methodBase_0.DeclaringType);
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						ilgenerator.Emit(OpCodes.Ldloc_S, array2[array2.Length - 1]);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Castclass, methodBase_0.DeclaringType);
					}
				}
				for (int l = 0; l < array.Length; l++)
				{
					if (!class14_0.method_1(l))
					{
						if (parameters[l].ParameterType.IsByRef)
						{
							ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
						}
					}
					else
					{
						Class6.Class13 @class = class14_0.method_0(l);
						if (@class.fieldInfo_0.IsStatic)
						{
							ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
						}
						else if (@class.fieldInfo_0.DeclaringType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
							ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
						}
					}
				}
				if (bool_4)
				{
					if (methodInfo != null)
					{
						ilgenerator.EmitCall(OpCodes.Call, methodInfo, null);
					}
					else
					{
						ilgenerator.Emit(OpCodes.Call, methodBase_0 as ConstructorInfo);
					}
				}
				else if (methodInfo != null)
				{
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
				}
				else
				{
					ilgenerator.Emit(OpCodes.Callvirt, methodBase_0 as ConstructorInfo);
				}
				if (!(methodInfo == null) && !(methodInfo.ReturnType == typeof(void)))
				{
					if (methodInfo.ReturnType.IsByRef)
					{
						Type elementType = methodInfo.ReturnType.GetElementType();
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
						}
						else
						{
							ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						}
						if (elementType.IsValueType)
						{
							ilgenerator.Emit(OpCodes.Box, elementType);
						}
					}
					else if (methodInfo.ReturnType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, methodInfo.ReturnType);
					}
				}
				else
				{
					ilgenerator.Emit(OpCodes.Ldnull);
				}
				for (int m = 0; m < array.Length; m++)
				{
					if (parameters[m].ParameterType.IsByRef)
					{
						if (!class14_0.method_1(m))
						{
							ilgenerator.Emit(OpCodes.Ldarg_1);
							Class6.Class15.smethod_5(ilgenerator, m);
							ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
							if (array2[m].LocalType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
							}
							ilgenerator.Emit(OpCodes.Stelem_Ref);
						}
						else
						{
							Class6.Class13 class2 = class14_0.method_0(m);
							if (class2.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
								if (class2.fieldInfo_0.FieldType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, class2.fieldInfo_0.FieldType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
						}
					}
				}
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Delegate10 @delegate = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
				if (bool_4)
				{
					Class6.Class15.dictionary_4.Add(class14_0, @delegate);
				}
				else
				{
					Class6.Class15.dictionary_5.Add(class14_0, @delegate);
				}
				result2 = @delegate;
			}
			return result2;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00041A08 File Offset: 0x0003FC08
		private static Class6.Delegate10 smethod_4(MethodBase methodBase_0, bool bool_4, Class6.Class14 class14_0)
		{
			object obj = Class6.Class15.object_5;
			Class6.Delegate10 result;
			lock (obj)
			{
				Class6.Delegate10 @delegate = null;
				if (Class6.Class15.dictionary_6.TryGetValue(class14_0, out @delegate))
				{
					result = @delegate;
				}
				else
				{
					ConstructorInfo constructorInfo = methodBase_0 as ConstructorInfo;
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
					{
						typeof(object),
						typeof(object[])
					}, typeof(Class6), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ParameterInfo[] parameters = methodBase_0.GetParameters();
					Type[] array = new Type[parameters.Length];
					for (int i = 0; i < array.Length; i++)
					{
						if (parameters[i].ParameterType.IsByRef)
						{
							array[i] = parameters[i].ParameterType.GetElementType();
						}
						else
						{
							array[i] = parameters[i].ParameterType;
						}
					}
					int num = array.Length;
					if (methodBase_0.DeclaringType.IsValueType)
					{
						num++;
					}
					LocalBuilder[] array2 = new LocalBuilder[num];
					for (int j = 0; j < array.Length; j++)
					{
						if (class14_0.method_1(j))
						{
							array2[j] = ilgenerator.DeclareLocal(typeof(object));
						}
						else
						{
							array2[j] = ilgenerator.DeclareLocal(array[j]);
						}
					}
					if (methodBase_0.DeclaringType.IsValueType)
					{
						array2[array2.Length - 1] = ilgenerator.DeclareLocal(methodBase_0.DeclaringType.MakeByRefType());
					}
					for (int k = 0; k < array.Length; k++)
					{
						ilgenerator.Emit(OpCodes.Ldarg_1);
						Class6.Class15.smethod_5(ilgenerator, k);
						ilgenerator.Emit(OpCodes.Ldelem_Ref);
						if (!class14_0.method_1(k))
						{
							if (array[k].IsValueType)
							{
								ilgenerator.Emit(OpCodes.Unbox_Any, array[k]);
							}
							else if (array[k] != typeof(object))
							{
								ilgenerator.Emit(OpCodes.Castclass, array[k]);
							}
						}
						ilgenerator.Emit(OpCodes.Stloc, array2[k]);
					}
					for (int l = 0; l < array.Length; l++)
					{
						if (!class14_0.method_1(l))
						{
							if (parameters[l].ParameterType.IsByRef)
							{
								ilgenerator.Emit(OpCodes.Ldloca_S, array2[l]);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
							}
						}
						else
						{
							Class6.Class13 @class = class14_0.method_0(l);
							if (@class.fieldInfo_0.IsStatic)
							{
								ilgenerator.Emit(OpCodes.Ldsflda, @class.fieldInfo_0);
							}
							else if (@class.fieldInfo_0.DeclaringType.IsValueType)
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Unbox, @class.fieldInfo_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
							}
							else
							{
								ilgenerator.Emit(OpCodes.Ldloc, array2[l]);
								ilgenerator.Emit(OpCodes.Castclass, @class.fieldInfo_0.DeclaringType);
								ilgenerator.Emit(OpCodes.Ldflda, @class.fieldInfo_0);
							}
						}
					}
					ilgenerator.Emit(OpCodes.Newobj, methodBase_0 as ConstructorInfo);
					if (constructorInfo.DeclaringType.IsValueType)
					{
						ilgenerator.Emit(OpCodes.Box, constructorInfo.DeclaringType);
					}
					for (int m = 0; m < array.Length; m++)
					{
						if (parameters[m].ParameterType.IsByRef)
						{
							if (!class14_0.method_1(m))
							{
								ilgenerator.Emit(OpCodes.Ldarg_1);
								Class6.Class15.smethod_5(ilgenerator, m);
								ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
								if (array2[m].LocalType.IsValueType)
								{
									ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
								}
								ilgenerator.Emit(OpCodes.Stelem_Ref);
							}
							else
							{
								Class6.Class13 class2 = class14_0.method_0(m);
								if (class2.fieldInfo_0.IsStatic)
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class6.Class15.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldsfld, class2.fieldInfo_0);
									if (class2.fieldInfo_0.FieldType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
								else
								{
									ilgenerator.Emit(OpCodes.Ldarg_1);
									Class6.Class15.smethod_5(ilgenerator, m);
									ilgenerator.Emit(OpCodes.Ldloc, array2[m]);
									if (array2[m].LocalType.IsValueType)
									{
										ilgenerator.Emit(OpCodes.Box, array2[m].LocalType);
									}
									ilgenerator.Emit(OpCodes.Stelem_Ref);
								}
							}
						}
					}
					ilgenerator.Emit(OpCodes.Ret);
					Class6.Delegate10 delegate2 = (Class6.Delegate10)dynamicMethod.CreateDelegate(typeof(Class6.Delegate10));
					Class6.Class15.dictionary_6.Add(class14_0, delegate2);
					result = delegate2;
				}
			}
			return result;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00041F28 File Offset: 0x00040128
		private static void smethod_5(ILGenerator ilgenerator_0, int int_3)
		{
			switch (int_3)
			{
			case -1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				ilgenerator_0.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				if (int_3 > -129 && int_3 < 128)
				{
					ilgenerator_0.Emit(OpCodes.Ldc_I4_S, (sbyte)int_3);
					return;
				}
				ilgenerator_0.Emit(OpCodes.Ldc_I4, int_3);
				return;
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00042008 File Offset: 0x00040208
		private static Class6.Class17 smethod_6(Class6.Class17 class17_3)
		{
			if (class17_3.vmethod_7().method_0())
			{
				object obj = class17_3.vmethod_4(null);
				if (obj != null && obj.GetType().IsEnum)
				{
					Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
					object obj2 = Convert.ChangeType(obj, underlyingType);
					Class6.Class17 @class = Class6.Class15.smethod_7(Class6.Class17.smethod_1(underlyingType, obj2));
					if (@class != null)
					{
						return @class as Class6.Class18;
					}
				}
			}
			return class17_3;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00039250 File Offset: 0x00037450
		private static Class6.Class18 smethod_7(Class6.Class17 class17_3)
		{
			Class6.Class18 @class = class17_3 as Class6.Class18;
			if (@class == null && class17_3.vmethod_0())
			{
				@class = (class17_3.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00042068 File Offset: 0x00040268
		private static IntPtr bltXeOrHnB(Class6.Class17 class17_3)
		{
			if (class17_3 == null)
			{
				return IntPtr.Zero;
			}
			if (class17_3.method_2())
			{
				return ((Class6.Class21)class17_3).method_6();
			}
			if (class17_3.vmethod_0())
			{
				Class6.Class23 @class = (Class6.Class23)class17_3;
				IntPtr result;
				try
				{
					result = @class.vmethod_10();
				}
				catch
				{
					goto IL_3A;
				}
				return result;
			}
			IL_3A:
			object obj = class17_3.vmethod_4(typeof(IntPtr));
			if (obj == null || !(obj.GetType() == typeof(IntPtr)))
			{
				throw new Class6.Exception1();
			}
			return (IntPtr)obj;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000420F8 File Offset: 0x000402F8
		private static object smethod_8(object object_7)
		{
			object obj = Class6.Class15.object_6;
			object result;
			lock (obj)
			{
				if (Class6.Class15.dictionary_7 == null)
				{
					Class6.Class15.dictionary_7 = new Dictionary<Type, Class6.Delegate11>();
				}
				if (object_7 != null)
				{
					try
					{
						Type type = object_7.GetType();
						Class6.Delegate11 @delegate;
						if (Class6.Class15.dictionary_7.TryGetValue(type, out @delegate))
						{
							return @delegate(object_7);
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(object), new Type[]
						{
							typeof(object)
						}, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						ilgenerator.Emit(OpCodes.Ldarg_0);
						ilgenerator.Emit(OpCodes.Unbox_Any, type);
						ilgenerator.Emit(OpCodes.Box, type);
						ilgenerator.Emit(OpCodes.Ret);
						Class6.Delegate11 delegate2 = (Class6.Delegate11)dynamicMethod.CreateDelegate(typeof(Class6.Delegate11));
						Class6.Class15.dictionary_7.Add(type, delegate2);
						return delegate2(object_7);
					}
					catch
					{
						return null;
					}
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0004220C File Offset: 0x0004040C
		private static void smethod_9(IntPtr intptr_0, byte byte_0, int int_3)
		{
			object obj = Class6.Class15.object_6;
			lock (obj)
			{
				if (Class6.Class15.delegate12_0 == null)
				{
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
					{
						typeof(IntPtr),
						typeof(byte),
						typeof(int)
					}, typeof(Class6), true);
					ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
					ilgenerator.Emit(OpCodes.Ldarg_0);
					ilgenerator.Emit(OpCodes.Ldarg_1);
					ilgenerator.Emit(OpCodes.Ldarg_2);
					ilgenerator.Emit(OpCodes.Initblk);
					ilgenerator.Emit(OpCodes.Ret);
					Class6.Class15.delegate12_0 = (Class6.Delegate12)dynamicMethod.CreateDelegate(typeof(Class6.Delegate12));
				}
				Class6.Class15.delegate12_0(intptr_0, byte_0, int_3);
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00042300 File Offset: 0x00040500
		private static void smethod_10(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
		{
			if (Class6.Class15.delegate13_0 == null)
			{
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, typeof(void), new Type[]
				{
					typeof(IntPtr),
					typeof(IntPtr),
					typeof(uint)
				}, typeof(Class6), true);
				ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldarg_1);
				ilgenerator.Emit(OpCodes.Ldarg_2);
				ilgenerator.Emit(OpCodes.Cpblk);
				ilgenerator.Emit(OpCodes.Ret);
				Class6.Class15.delegate13_0 = (Class6.Delegate13)dynamicMethod.CreateDelegate(typeof(Class6.Delegate13));
			}
			Class6.Class15.delegate13_0(intptr_0, intptr_1, uint_0);
		}

		// Token: 0x04000438 RID: 1080
		internal Class6.Class12 class12_0;

		// Token: 0x04000439 RID: 1081
		internal Class6.Class17[] class17_0 = new Class6.Class17[0];

		// Token: 0x0400043A RID: 1082
		internal Class6.Class17[] class17_1 = new Class6.Class17[0];

		// Token: 0x0400043B RID: 1083
		internal Class6.Class31 class31_0 = new Class6.Class31();

		// Token: 0x0400043C RID: 1084
		internal Class6.Class17 class17_2;

		// Token: 0x0400043D RID: 1085
		internal Exception exception_0;

		// Token: 0x0400043E RID: 1086
		internal List<IntPtr> list_0;

		// Token: 0x0400043F RID: 1087
		private int int_0;

		// Token: 0x04000440 RID: 1088
		private int int_1;

		// Token: 0x04000441 RID: 1089
		private int int_2 = -1;

		// Token: 0x04000442 RID: 1090
		private object object_0;

		// Token: 0x04000443 RID: 1091
		private bool bool_0;

		// Token: 0x04000444 RID: 1092
		private bool bool_1;

		// Token: 0x04000445 RID: 1093
		private bool bool_2;

		// Token: 0x04000446 RID: 1094
		private bool bool_3;

		// Token: 0x04000447 RID: 1095
		private static Dictionary<Type, int> dictionary_0;

		// Token: 0x04000448 RID: 1096
		private static object object_1 = new object();

		// Token: 0x04000449 RID: 1097
		private static Dictionary<object, Class6.Class17> dictionary_1 = new Dictionary<object, Class6.Class17>();

		// Token: 0x0400044A RID: 1098
		private static object object_2 = new object();

		// Token: 0x0400044B RID: 1099
		private static Dictionary<MethodBase, Class6.Delegate10> dictionary_2 = new Dictionary<MethodBase, Class6.Delegate10>();

		// Token: 0x0400044C RID: 1100
		private static Dictionary<MethodBase, Class6.Delegate10> dictionary_3 = new Dictionary<MethodBase, Class6.Delegate10>();

		// Token: 0x0400044D RID: 1101
		private static object object_3 = new object();

		// Token: 0x0400044E RID: 1102
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_4 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x0400044F RID: 1103
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_5 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x04000450 RID: 1104
		private static object object_4 = new object();

		// Token: 0x04000451 RID: 1105
		private static Dictionary<Class6.Class14, Class6.Delegate10> dictionary_6 = new Dictionary<Class6.Class14, Class6.Delegate10>();

		// Token: 0x04000452 RID: 1106
		private static object object_5 = new object();

		// Token: 0x04000453 RID: 1107
		private static Dictionary<Type, Class6.Delegate11> dictionary_7;

		// Token: 0x04000454 RID: 1108
		private static object object_6 = new object();

		// Token: 0x04000455 RID: 1109
		private static Class6.Delegate12 delegate12_0;

		// Token: 0x04000456 RID: 1110
		private static Class6.Delegate13 delegate13_0;

		// Token: 0x020000D8 RID: 216
		[CompilerGenerated]
		[Serializable]
		private sealed class Class16
		{
			// Token: 0x06000726 RID: 1830 RVA: 0x00006039 File Offset: 0x00004239
			internal int method_0(Class6.Class10 x, Class6.Class10 y)
			{
				return x.class11_0.int_0.CompareTo(y.class11_0.int_0);
			}

			// Token: 0x04000457 RID: 1111
			//public static readonly Class6.Class15.Class16 <>9 = new Class6.Class15.Class16();

			// Token: 0x04000458 RID: 1112
			//public static Comparison<Class6.Class10> <>9__12_0;
		}
	}

	// Token: 0x020000D9 RID: 217
	internal enum Enum3 : byte
	{

	}

	// Token: 0x020000DA RID: 218
	internal enum Enum4 : byte
	{

	}

	// Token: 0x020000DB RID: 219
	internal abstract class Class17
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00002289 File Offset: 0x00000489
		public Class17()
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00006056 File Offset: 0x00004256
		internal bool method_0()
		{
			return this.enum4_0 == (Class6.Enum4)0;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00006061 File Offset: 0x00004261
		internal bool method_1()
		{
			return this.enum4_0 == (Class6.Enum4)1;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0000606C File Offset: 0x0000426C
		internal bool method_2()
		{
			return this.enum4_0 == (Class6.Enum4)3 || this.enum4_0 == (Class6.Enum4)4;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00006082 File Offset: 0x00004282
		internal bool method_3()
		{
			return this.enum4_0 == (Class6.Enum4)2;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0000608D File Offset: 0x0000428D
		internal bool method_4()
		{
			return this.enum4_0 == (Class6.Enum4)5;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00006098 File Offset: 0x00004298
		internal bool nGhvlaVjva()
		{
			return this.enum4_0 == (Class6.Enum4)6;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002325 File Offset: 0x00000525
		internal virtual bool vmethod_0()
		{
			return false;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002325 File Offset: 0x00000525
		internal virtual bool vmethod_1()
		{
			return false;
		}

		// Token: 0x06000730 RID: 1840
		internal abstract void vmethod_2(Class6.Class17 class17_0);

		// Token: 0x06000731 RID: 1841 RVA: 0x00002325 File Offset: 0x00000525
		internal virtual bool vmethod_3()
		{
			return false;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x000060A3 File Offset: 0x000042A3
		internal Class17(Class6.Enum4 enum4_1)
		{
			this.enum4_0 = enum4_1;
		}

		// Token: 0x06000733 RID: 1843
		internal abstract object vmethod_4(Type type_0);

		// Token: 0x06000734 RID: 1844
		internal abstract bool vmethod_5(Class6.Class17 class17_0);

		// Token: 0x06000735 RID: 1845
		internal abstract bool BeouTiljCp(Class6.Class17 class17_0);

		// Token: 0x06000736 RID: 1846
		internal abstract bool vmethod_6();

		// Token: 0x06000737 RID: 1847
		internal abstract Class6.Class17 vmethod_7();

		// Token: 0x06000738 RID: 1848 RVA: 0x00002325 File Offset: 0x00000525
		internal virtual bool vmethod_8()
		{
			return false;
		}

		// Token: 0x06000739 RID: 1849
		internal abstract void vmethod_9(Class6.Class17 class17_0);

		// Token: 0x0600073A RID: 1850 RVA: 0x00042450 File Offset: 0x00040650
		internal static Class6.Enum2 smethod_0(Type type_0)
		{
			Type type = type_0;
			if (!(type != null))
			{
				return (Class6.Enum2)18;
			}
			if (type.IsByRef)
			{
				type = type.GetElementType();
			}
			if (type != null && Nullable.GetUnderlyingType(type) != null)
			{
				type = Nullable.GetUnderlyingType(type);
			}
			if (type == typeof(string))
			{
				return (Class6.Enum2)14;
			}
			if (type == typeof(byte))
			{
				return (Class6.Enum2)2;
			}
			if (type == typeof(sbyte))
			{
				return (Class6.Enum2)1;
			}
			if (type == typeof(short))
			{
				return (Class6.Enum2)3;
			}
			if (type == typeof(ushort))
			{
				return (Class6.Enum2)4;
			}
			if (type == typeof(int))
			{
				return (Class6.Enum2)5;
			}
			if (type == typeof(uint))
			{
				return (Class6.Enum2)6;
			}
			if (type == typeof(long))
			{
				return (Class6.Enum2)7;
			}
			if (type == typeof(ulong))
			{
				return (Class6.Enum2)8;
			}
			if (type == typeof(float))
			{
				return (Class6.Enum2)9;
			}
			if (type == typeof(double))
			{
				return (Class6.Enum2)10;
			}
			if (type == typeof(bool))
			{
				return (Class6.Enum2)11;
			}
			if (type == typeof(IntPtr))
			{
				return (Class6.Enum2)12;
			}
			if (type == typeof(UIntPtr))
			{
				return (Class6.Enum2)13;
			}
			if (type == typeof(char))
			{
				return (Class6.Enum2)15;
			}
			if (type == typeof(object))
			{
				return (Class6.Enum2)0;
			}
			if (type.IsEnum)
			{
				return (Class6.Enum2)16;
			}
			return (Class6.Enum2)17;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000425F0 File Offset: 0x000407F0
		internal static Class6.Class17 smethod_1(Type type_0, object object_0)
		{
			Class6.Enum2 @enum = Class6.Class17.smethod_0(type_0);
			Class6.Enum2 enum2 = (Class6.Enum2)18;
			if (object_0 != null)
			{
				enum2 = Class6.Class17.smethod_0(object_0.GetType());
			}
			Class6.Class17 @class = null;
			switch (@enum)
			{
			case (Class6.Enum2)0:
				if (enum2 == (Class6.Enum2)15)
				{
					@class = new Class6.Class29(object_0);
				}
				else
				{
					@class = Class6.Class17.smethod_2(object_0);
				}
				break;
			case (Class6.Enum2)1:
				if (enum2 <= (Class6.Enum2)2)
				{
					if (enum2 == (Class6.Enum2)1)
					{
						@class = new Class6.Class19((int)((sbyte)object_0), (Class6.Enum1)1);
						break;
					}
					if (enum2 == (Class6.Enum2)2)
					{
						@class = new Class6.Class19((int)((sbyte)((byte)object_0)), (Class6.Enum1)1);
						break;
					}
				}
				else if (enum2 != (Class6.Enum2)11)
				{
					if (enum2 == (Class6.Enum2)15)
					{
						@class = new Class6.Class19((int)((sbyte)((char)object_0)), (Class6.Enum1)1);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)1);
						break;
					}
					@class = new Class6.Class19(0, (Class6.Enum1)1);
					break;
				}
				throw new InvalidCastException();
			case (Class6.Enum2)2:
				if (enum2 <= (Class6.Enum2)2)
				{
					if (enum2 == (Class6.Enum2)1)
					{
						@class = new Class6.Class19((int)((byte)((sbyte)object_0)), (Class6.Enum1)2);
						break;
					}
					if (enum2 == (Class6.Enum2)2)
					{
						@class = new Class6.Class19((int)((byte)object_0), (Class6.Enum1)2);
						break;
					}
				}
				else if (enum2 != (Class6.Enum2)11)
				{
					if (enum2 == (Class6.Enum2)15)
					{
						@class = new Class6.Class19((int)((byte)((char)object_0)), (Class6.Enum1)2);
						break;
					}
				}
				else
				{
					if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)2);
						break;
					}
					@class = new Class6.Class19(0, (Class6.Enum1)2);
					break;
				}
				throw new InvalidCastException();
			case (Class6.Enum2)3:
				if (enum2 != (Class6.Enum2)3)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((short)((char)object_0)), (Class6.Enum1)3);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)3);
					}
					else
					{
						@class = new Class6.Class19(0, (Class6.Enum1)3);
					}
				}
				else
				{
					@class = new Class6.Class19((int)((short)object_0), (Class6.Enum1)3);
				}
				break;
			case (Class6.Enum2)4:
				if (enum2 != (Class6.Enum2)4)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)4);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)4);
					}
					else
					{
						@class = new Class6.Class19(0, (Class6.Enum1)4);
					}
				}
				else
				{
					@class = new Class6.Class19((int)((ushort)object_0), (Class6.Enum1)4);
				}
				break;
			case (Class6.Enum2)5:
				if (enum2 != (Class6.Enum2)5)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)5);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1, (Class6.Enum1)5);
					}
					else
					{
						@class = new Class6.Class19(0, (Class6.Enum1)5);
					}
				}
				else
				{
					@class = new Class6.Class19((int)object_0, (Class6.Enum1)5);
				}
				break;
			case (Class6.Enum2)6:
				if (enum2 != (Class6.Enum2)6)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class19((uint)((char)object_0), (Class6.Enum1)6);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class19(1U, (Class6.Enum1)6);
					}
					else
					{
						@class = new Class6.Class19(0U, (Class6.Enum1)6);
					}
				}
				else
				{
					@class = new Class6.Class19((uint)object_0, (Class6.Enum1)6);
				}
				break;
			case (Class6.Enum2)7:
				if (enum2 != (Class6.Enum2)7)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class20((long)((ulong)((char)object_0)), (Class6.Enum1)7);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class20(1L, (Class6.Enum1)7);
					}
					else
					{
						@class = new Class6.Class20(0L, (Class6.Enum1)7);
					}
				}
				else
				{
					@class = new Class6.Class20((long)object_0, (Class6.Enum1)7);
				}
				break;
			case (Class6.Enum2)8:
				if (enum2 != (Class6.Enum2)8)
				{
					if (enum2 != (Class6.Enum2)11)
					{
						if (enum2 != (Class6.Enum2)15)
						{
							throw new InvalidCastException();
						}
						@class = new Class6.Class20((ulong)((char)object_0), (Class6.Enum1)8);
					}
					else if ((bool)object_0)
					{
						@class = new Class6.Class20(1UL, (Class6.Enum1)8);
					}
					else
					{
						@class = new Class6.Class20(0UL, (Class6.Enum1)8);
					}
				}
				else
				{
					@class = new Class6.Class20((ulong)object_0, (Class6.Enum1)8);
				}
				break;
			case (Class6.Enum2)9:
				if (enum2 != (Class6.Enum2)9)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class22((float)object_0);
				break;
			case (Class6.Enum2)10:
				if (enum2 != (Class6.Enum2)10)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class22((double)object_0);
				break;
			case (Class6.Enum2)11:
				switch (enum2)
				{
				case (Class6.Enum2)1:
					@class = new Class6.Class19((sbyte)object_0 != 0);
					goto IL_618;
				case (Class6.Enum2)2:
					@class = new Class6.Class19((byte)object_0 > 0);
					goto IL_618;
				case (Class6.Enum2)3:
					@class = new Class6.Class19((short)object_0 != 0);
					goto IL_618;
				case (Class6.Enum2)4:
					@class = new Class6.Class19((ushort)object_0 > 0);
					goto IL_618;
				case (Class6.Enum2)5:
					@class = new Class6.Class19((int)object_0 != 0);
					goto IL_618;
				case (Class6.Enum2)6:
					@class = new Class6.Class19((uint)object_0 > 0U);
					goto IL_618;
				case (Class6.Enum2)7:
					@class = new Class6.Class19((long)object_0 != 0L);
					goto IL_618;
				case (Class6.Enum2)8:
					@class = new Class6.Class19((ulong)object_0 > 0UL);
					goto IL_618;
				case (Class6.Enum2)9:
				case (Class6.Enum2)10:
				case (Class6.Enum2)12:
				case (Class6.Enum2)13:
				case (Class6.Enum2)14:
				case (Class6.Enum2)15:
				case (Class6.Enum2)16:
					throw new InvalidCastException();
				case (Class6.Enum2)11:
					@class = new Class6.Class19((bool)object_0);
					goto IL_618;
				case (Class6.Enum2)18:
					@class = new Class6.Class19(false);
					goto IL_618;
				}
				@class = new Class6.Class19(object_0 != null);
				break;
			case (Class6.Enum2)12:
				if (enum2 != (Class6.Enum2)12)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class21((IntPtr)object_0);
				break;
			case (Class6.Enum2)13:
				if (enum2 != (Class6.Enum2)13)
				{
					throw new InvalidCastException();
				}
				@class = new Class6.Class21((UIntPtr)object_0);
				break;
			case (Class6.Enum2)14:
				@class = new Class6.Class30(object_0 as string);
				break;
			case (Class6.Enum2)15:
				switch (enum2)
				{
				case (Class6.Enum2)1:
					@class = new Class6.Class19((int)((sbyte)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)2:
					@class = new Class6.Class19((int)((byte)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)3:
					@class = new Class6.Class19((int)((short)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)4:
					@class = new Class6.Class19((int)((ushort)object_0), (Class6.Enum1)15);
					break;
				case (Class6.Enum2)5:
					@class = new Class6.Class19((int)object_0, (Class6.Enum1)15);
					break;
				case (Class6.Enum2)6:
					@class = new Class6.Class19((int)((uint)object_0), (Class6.Enum1)15);
					break;
				default:
					if (enum2 != (Class6.Enum2)15)
					{
						throw new InvalidCastException();
					}
					@class = new Class6.Class19((int)((char)object_0), (Class6.Enum1)15);
					break;
				}
				break;
			case (Class6.Enum2)16:
			case (Class6.Enum2)17:
				@class = Class6.Class17.smethod_2(object_0);
				break;
			case (Class6.Enum2)18:
				throw new InvalidCastException();
			}
			IL_618:
			if (type_0.IsByRef)
			{
				@class = new Class6.Class28(@class, type_0.GetElementType());
			}
			return @class;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00042C34 File Offset: 0x00040E34
		private static Class6.Class17 smethod_2(object object_0)
		{
			if (object_0 != null && object_0.GetType().IsEnum)
			{
				Type underlyingType = Enum.GetUnderlyingType(object_0.GetType());
				object object_ = Convert.ChangeType(object_0, underlyingType);
				Class6.Class17 @class = Class6.Class17.smethod_3(Class6.Class17.smethod_1(underlyingType, object_));
				if (@class != null)
				{
					return @class as Class6.Class18;
				}
			}
			return new Class6.Class29(object_0);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00039250 File Offset: 0x00037450
		private static Class6.Class18 smethod_3(Class6.Class17 class17_0)
		{
			Class6.Class18 @class = class17_0 as Class6.Class18;
			if (@class == null && class17_0.vmethod_0())
			{
				@class = (class17_0.vmethod_7() as Class6.Class18);
			}
			return @class;
		}

		// Token: 0x0400045B RID: 1115
		internal Class6.Enum4 enum4_0;
	}

	// Token: 0x020000DC RID: 220
	private class Class29 : Class6.Class17
	{
		// Token: 0x0600073E RID: 1854 RVA: 0x000060B2 File Offset: 0x000042B2
		public Class29() : this(null)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x000060BB File Offset: 0x000042BB
		internal override void vmethod_9(Class6.Class17 class17_1)
		{
			if (class17_1 is Class6.Class29)
			{
				this.class17_0 = ((Class6.Class29)class17_1).class17_0;
				this.jyuvQjLcik = ((Class6.Class29)class17_1).jyuvQjLcik;
				return;
			}
			this.class17_0 = class17_1.vmethod_7();
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_1)
		{
			this.vmethod_9(class17_1);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000060F4 File Offset: 0x000042F4
		public Class29(object object_0) : base((Class6.Enum4)0)
		{
            //this.class17_0 = object_0;
            this.jyuvQjLcik = null;
        }

		// Token: 0x06000742 RID: 1858 RVA: 0x0000610B File Offset: 0x0000430B
		public Class29(object object_0, Type type_0) : base((Class6.Enum4)0)
		{
			//this.class17_0 = object_0;
			this.jyuvQjLcik = type_0;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00042C84 File Offset: 0x00040E84
		public override string ToString()
		{
			if (this.class17_0 != null)
			{
				return this.class17_0.ToString();
			}
			return ((Class6.Enum5)5).ToString();
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00042CB4 File Offset: 0x00040EB4
		internal override object vmethod_4(Type type_0)
		{
			if (this.class17_0 == null)
			{
				return null;
			}
			if (type_0 != null && type_0.IsByRef)
			{
				type_0 = type_0.GetElementType();
			}
			if (!(this.class17_0 is Class6.Class17))
			{
				object obj = this.class17_0;
				if (obj != null && type_0 != null && obj.GetType() != type_0)
				{
					if (type_0 == typeof(RuntimeFieldHandle) && obj is FieldInfo)
					{
						obj = ((FieldInfo)obj).FieldHandle;
					}
					else if (type_0 == typeof(RuntimeTypeHandle) && obj is Type)
					{
						obj = ((Type)obj).TypeHandle;
					}
					else if (type_0 == typeof(RuntimeMethodHandle) && obj is MethodBase)
					{
						obj = ((MethodBase)obj).MethodHandle;
					}
				}
				return obj;
			}
			if (this.jyuvQjLcik != null)
			{
				return ((Class6.Class17)this.class17_0).vmethod_4(this.jyuvQjLcik);
			}
			object obj2 = ((Class6.Class17)this.class17_0).vmethod_4(type_0);
			if (obj2 != null && type_0 != null && obj2.GetType() != type_0)
			{
				if (type_0 == typeof(RuntimeFieldHandle) && obj2 is FieldInfo)
				{
					obj2 = ((FieldInfo)obj2).FieldHandle;
				}
				else if (type_0 == typeof(RuntimeTypeHandle) && obj2 is Type)
				{
					obj2 = ((Type)obj2).TypeHandle;
				}
				else if (type_0 == typeof(RuntimeMethodHandle) && obj2 is MethodBase)
				{
					obj2 = ((MethodBase)obj2).MethodHandle;
				}
			}
			return obj2;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00042E88 File Offset: 0x00041088
		internal override bool vmethod_5(Class6.Class17 class17_1)
		{
			if (class17_1.vmethod_0())
			{
				return ((Class6.Class23)class17_1).vmethod_5(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class17_1.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00042EBC File Offset: 0x000410BC
		internal override bool BeouTiljCp(Class6.Class17 class17_1)
		{
			if (class17_1.vmethod_0())
			{
				return ((Class6.Class23)class17_1).BeouTiljCp(this);
			}
			object obj = this.vmethod_4(null);
			object obj2 = class17_1.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00042EF4 File Offset: 0x000410F4
		internal override Class6.Class17 vmethod_7()
		{
			Class6.Class17 @class = this.class17_0 as Class6.Class17;
			if (@class == null)
			{
				return this;
			}
			return @class.vmethod_7();
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00042F18 File Offset: 0x00041118
		internal override bool vmethod_6()
		{
			if (this.class17_0 == null)
			{
				return false;
			}
			Class6.Class17 @class = this.class17_0 as Class6.Class17;
			return @class == null || @class.vmethod_4(null) != null;
		}

		// Token: 0x0400045C RID: 1116
		public Class6.Class17 class17_0;

		// Token: 0x0400045D RID: 1117
		public Type jyuvQjLcik;
	}

	// Token: 0x020000DD RID: 221
	private class Class30 : Class6.Class17
	{
		// Token: 0x06000749 RID: 1865 RVA: 0x00006122 File Offset: 0x00004322
		public Class30(string string_1) : base((Class6.Enum4)6)
		{
			this.string_0 = string_1;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00006132 File Offset: 0x00004332
		internal override void vmethod_9(Class6.Class17 class17_0)
		{
			this.string_0 = ((Class6.Class30)class17_0).string_0;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00004994 File Offset: 0x00002B94
		internal override void vmethod_2(Class6.Class17 class17_0)
		{
			this.vmethod_9(class17_0);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00042F4C File Offset: 0x0004114C
		public override string ToString()
		{
			if (this.string_0 == null)
			{
				return ((Class6.Enum5)5).ToString();
			}
			return '*'.ToString() + this.string_0 + '*'.ToString();
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00006145 File Offset: 0x00004345
		internal override bool vmethod_6()
		{
			return this.string_0 != null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00006150 File Offset: 0x00004350
		internal override object vmethod_4(Type type_0)
		{
			return this.string_0;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00042F90 File Offset: 0x00041190
		internal override bool vmethod_5(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).vmethod_5(this);
			}
			object obj = this.string_0;
			object obj2 = class17_0.vmethod_4(null);
			return obj == obj2;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00042FC4 File Offset: 0x000411C4
		internal override bool BeouTiljCp(Class6.Class17 class17_0)
		{
			if (class17_0.vmethod_0())
			{
				return ((Class6.Class23)class17_0).BeouTiljCp(this);
			}
			object obj = this.string_0;
			object obj2 = class17_0.vmethod_4(null);
			return obj != obj2;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004E2C File Offset: 0x0000302C
		internal override Class6.Class17 vmethod_7()
		{
			return this;
		}

		// Token: 0x0400045E RID: 1118
		public string string_0;
	}

	// Token: 0x020000DE RID: 222
	internal class Class31
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00006158 File Offset: 0x00004358
		public int method_0()
		{
			return this.list_0.Count;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00006165 File Offset: 0x00004365
		public void method_1()
		{
			this.list_0.Clear();
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00006172 File Offset: 0x00004372
		public void method_2(Class6.Class17 class17_0)
		{
			this.list_0.Add(class17_0);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00006180 File Offset: 0x00004380
		public Class6.Class17 method_3()
		{
			return this.list_0[this.list_0.Count - 1];
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0000619A File Offset: 0x0000439A
		public Class6.Class17 method_4()
		{
			Class6.Class17 result = this.method_3();
			if (this.list_0.Count != 0)
			{
				this.list_0.RemoveAt(this.list_0.Count - 1);
			}
			return result;
		}

		// Token: 0x0400045F RID: 1119
		private List<Class6.Class17> list_0 = new List<Class6.Class17>();
	}

	// Token: 0x020000DF RID: 223
	private struct d8DBD9859D004AF6
	{
		// Token: 0x06000758 RID: 1880 RVA: 0x000061DA File Offset: 0x000043DA
		public d8DBD9859D004AF6(int int_0, int int_1)
		{
			this.sb = new StringBuilder();
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x000061DA File Offset: 0x000043DA
		public d8DBD9859D004AF6(int int_0, int int_1, IFormatProvider iformatProvider_0)
		{
			this.sb = new StringBuilder();
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x000061E7 File Offset: 0x000043E7
		public void AppendLiteral(string string_0)
		{
			if (string_0 != null)
			{
				this.sb.Append(string_0);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x000061F9 File Offset: 0x000043F9
		public void AppendFormatted<T>(T value)
		{
			if (value != null)
			{
				this.sb.Append(value);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00006215 File Offset: 0x00004415
		public void AppendFormatted<T>(T value, string string_0)
		{
			if (string_0 != null)
			{
				this.sb.AppendFormat(string_0, value);
				return;
			}
			this.sb.Append(value);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x000061F9 File Offset: 0x000043F9
		public void AppendFormatted<T>(T value, int int_0)
		{
			if (value != null)
			{
				this.sb.Append(value);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00006240 File Offset: 0x00004440
		public void AppendFormatted<T>(T value, int int_0, string string_0)
		{
			if (string_0 != null)
			{
				this.sb.AppendFormat(string_0, value);
				return;
			}
			this.sb.Append(value);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x000061E7 File Offset: 0x000043E7
		public void AppendFormatted(string string_0)
		{
			if (string_0 != null)
			{
				this.sb.Append(string_0);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000626B File Offset: 0x0000446B
		public void AppendFormatted(string string_0, int int_0 = 0, string string_1 = null)
		{
			if (string_1 != null)
			{
				this.sb.AppendFormat(string_1, string_0);
				return;
			}
			this.sb.Append(string_0);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000628C File Offset: 0x0000448C
		public void AppendFormatted(object object_0, int int_0 = 0, string string_0 = null)
		{
			if (string_0 != null)
			{
				this.sb.AppendFormat(string_0, object_0);
				return;
			}
			this.sb.Append(object_0);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000062AD File Offset: 0x000044AD
		public string ToStringAndClear()
		{
			string result = this.sb.ToString();
			this.sb.Clear();
			return result;
		}

		// Token: 0x04000460 RID: 1120
		private StringBuilder sb;
	}

	// Token: 0x020000E0 RID: 224
	internal enum Enum5
	{

	}

	// Token: 0x020000E1 RID: 225
	[CompilerGenerated]
	[Serializable]
	private sealed class Class32<T>
	{
		// Token: 0x06000765 RID: 1893 RVA: 0x00006039 File Offset: 0x00004239
		internal int method_0(Class6.Class10 x, Class6.Class10 y)
		{
			return x.class11_0.int_0.CompareTo(y.class11_0.int_0);
		}

		// Token: 0x04000462 RID: 1122
		//public static readonly Class6.Class32<T> <>9 = new Class6.Class32<T>();

		// Token: 0x04000463 RID: 1123
		//public static Comparison<Class6.Class10> <>9__46_0;
	}
}
