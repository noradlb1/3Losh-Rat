using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x020000A8 RID: 168
internal class Class1
{
	// Token: 0x0600047C RID: 1148 RVA: 0x0003625C File Offset: 0x0003445C
	static Class1()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002287 File Offset: 0x00000487
	private void method_0()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x000363D8 File Offset: 0x000345D8
	internal static byte[] smethod_0(byte[] byte_2)
	{
		uint[] array = new uint[16];
		uint num = (uint)((448 - byte_2.Length * 8 % 512 + 512) % 512);
		if (num == 0U)
		{
			num = 512U;
		}
		uint num2 = (uint)((long)byte_2.Length + (long)((ulong)(num / 8U)) + 8L);
		ulong num3 = (ulong)((long)byte_2.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array2[i] = byte_2[i];
		}
		byte[] array3 = array2;
		int num4 = byte_2.Length;
		array3[num4] |= 128;
		for (int j = 8; j > 0; j--)
		{
			array2[(int)(checked((IntPtr)(unchecked((ulong)num2 - (ulong)((long)j)))))] = (byte)(num3 >> (8 - j) * 8 & 255UL);
		}
		uint num5 = (uint)(array2.Length * 8 / 32);
		uint num6 = 1732584193U;
		uint num7 = 4023233417U;
		uint num8 = 2562383102U;
		uint num9 = 271733878U;
		for (uint num10 = 0U; num10 < num5 / 16U; num10 += 1U)
		{
			uint num11 = num10 << 6;
			for (uint num12 = 0U; num12 < 61U; num12 += 4U)
			{
				array[(int)(num12 >> 2)] = (uint)((int)array2[(int)(num11 + (num12 + 3U))] << 24 | (int)array2[(int)(num11 + (num12 + 2U))] << 16 | (int)array2[(int)(num11 + (num12 + 1U))] << 8 | (int)array2[(int)(num11 + num12)]);
			}
			uint num13 = num6;
			uint num14 = num7;
			uint num15 = num8;
			uint num16 = num9;
			Class1.ReZxSxiJZ(ref num6, num7, num8, num9, 0U, 7, 1U, array);
			Class1.ReZxSxiJZ(ref num9, num6, num7, num8, 1U, 12, 2U, array);
			Class1.ReZxSxiJZ(ref num8, num9, num6, num7, 2U, 17, 3U, array);
			Class1.ReZxSxiJZ(ref num7, num8, num9, num6, 3U, 22, 4U, array);
			Class1.ReZxSxiJZ(ref num6, num7, num8, num9, 4U, 7, 5U, array);
			Class1.ReZxSxiJZ(ref num9, num6, num7, num8, 5U, 12, 6U, array);
			Class1.ReZxSxiJZ(ref num8, num9, num6, num7, 6U, 17, 7U, array);
			Class1.ReZxSxiJZ(ref num7, num8, num9, num6, 7U, 22, 8U, array);
			Class1.ReZxSxiJZ(ref num6, num7, num8, num9, 8U, 7, 9U, array);
			Class1.ReZxSxiJZ(ref num9, num6, num7, num8, 9U, 12, 10U, array);
			Class1.ReZxSxiJZ(ref num8, num9, num6, num7, 10U, 17, 11U, array);
			Class1.ReZxSxiJZ(ref num7, num8, num9, num6, 11U, 22, 12U, array);
			Class1.ReZxSxiJZ(ref num6, num7, num8, num9, 12U, 7, 13U, array);
			Class1.ReZxSxiJZ(ref num9, num6, num7, num8, 13U, 12, 14U, array);
			Class1.ReZxSxiJZ(ref num8, num9, num6, num7, 14U, 17, 15U, array);
			Class1.ReZxSxiJZ(ref num7, num8, num9, num6, 15U, 22, 16U, array);
			Class1.smethod_1(ref num6, num7, num8, num9, 1U, 5, 17U, array);
			Class1.smethod_1(ref num9, num6, num7, num8, 6U, 9, 18U, array);
			Class1.smethod_1(ref num8, num9, num6, num7, 11U, 14, 19U, array);
			Class1.smethod_1(ref num7, num8, num9, num6, 0U, 20, 20U, array);
			Class1.smethod_1(ref num6, num7, num8, num9, 5U, 5, 21U, array);
			Class1.smethod_1(ref num9, num6, num7, num8, 10U, 9, 22U, array);
			Class1.smethod_1(ref num8, num9, num6, num7, 15U, 14, 23U, array);
			Class1.smethod_1(ref num7, num8, num9, num6, 4U, 20, 24U, array);
			Class1.smethod_1(ref num6, num7, num8, num9, 9U, 5, 25U, array);
			Class1.smethod_1(ref num9, num6, num7, num8, 14U, 9, 26U, array);
			Class1.smethod_1(ref num8, num9, num6, num7, 3U, 14, 27U, array);
			Class1.smethod_1(ref num7, num8, num9, num6, 8U, 20, 28U, array);
			Class1.smethod_1(ref num6, num7, num8, num9, 13U, 5, 29U, array);
			Class1.smethod_1(ref num9, num6, num7, num8, 2U, 9, 30U, array);
			Class1.smethod_1(ref num8, num9, num6, num7, 7U, 14, 31U, array);
			Class1.smethod_1(ref num7, num8, num9, num6, 12U, 20, 32U, array);
			Class1.smethod_2(ref num6, num7, num8, num9, 5U, 4, 33U, array);
			Class1.smethod_2(ref num9, num6, num7, num8, 8U, 11, 34U, array);
			Class1.smethod_2(ref num8, num9, num6, num7, 11U, 16, 35U, array);
			Class1.smethod_2(ref num7, num8, num9, num6, 14U, 23, 36U, array);
			Class1.smethod_2(ref num6, num7, num8, num9, 1U, 4, 37U, array);
			Class1.smethod_2(ref num9, num6, num7, num8, 4U, 11, 38U, array);
			Class1.smethod_2(ref num8, num9, num6, num7, 7U, 16, 39U, array);
			Class1.smethod_2(ref num7, num8, num9, num6, 10U, 23, 40U, array);
			Class1.smethod_2(ref num6, num7, num8, num9, 13U, 4, 41U, array);
			Class1.smethod_2(ref num9, num6, num7, num8, 0U, 11, 42U, array);
			Class1.smethod_2(ref num8, num9, num6, num7, 3U, 16, 43U, array);
			Class1.smethod_2(ref num7, num8, num9, num6, 6U, 23, 44U, array);
			Class1.smethod_2(ref num6, num7, num8, num9, 9U, 4, 45U, array);
			Class1.smethod_2(ref num9, num6, num7, num8, 12U, 11, 46U, array);
			Class1.smethod_2(ref num8, num9, num6, num7, 15U, 16, 47U, array);
			Class1.smethod_2(ref num7, num8, num9, num6, 2U, 23, 48U, array);
			Class1.smethod_3(ref num6, num7, num8, num9, 0U, 6, 49U, array);
			Class1.smethod_3(ref num9, num6, num7, num8, 7U, 10, 50U, array);
			Class1.smethod_3(ref num8, num9, num6, num7, 14U, 15, 51U, array);
			Class1.smethod_3(ref num7, num8, num9, num6, 5U, 21, 52U, array);
			Class1.smethod_3(ref num6, num7, num8, num9, 12U, 6, 53U, array);
			Class1.smethod_3(ref num9, num6, num7, num8, 3U, 10, 54U, array);
			Class1.smethod_3(ref num8, num9, num6, num7, 10U, 15, 55U, array);
			Class1.smethod_3(ref num7, num8, num9, num6, 1U, 21, 56U, array);
			Class1.smethod_3(ref num6, num7, num8, num9, 8U, 6, 57U, array);
			Class1.smethod_3(ref num9, num6, num7, num8, 15U, 10, 58U, array);
			Class1.smethod_3(ref num8, num9, num6, num7, 6U, 15, 59U, array);
			Class1.smethod_3(ref num7, num8, num9, num6, 13U, 21, 60U, array);
			Class1.smethod_3(ref num6, num7, num8, num9, 4U, 6, 61U, array);
			Class1.smethod_3(ref num9, num6, num7, num8, 11U, 10, 62U, array);
			Class1.smethod_3(ref num8, num9, num6, num7, 2U, 15, 63U, array);
			Class1.smethod_3(ref num7, num8, num9, num6, 9U, 21, 64U, array);
			num6 += num13;
			num7 += num14;
			num8 += num15;
			num9 += num16;
		}
		byte[] array4 = new byte[16];
		Array.Copy(BitConverter.GetBytes(num6), 0, array4, 0, 4);
		Array.Copy(BitConverter.GetBytes(num7), 0, array4, 4, 4);
		Array.Copy(BitConverter.GetBytes(num8), 0, array4, 8, 4);
		Array.Copy(BitConverter.GetBytes(num9), 0, array4, 12, 4);
		return array4;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00004675 File Offset: 0x00002875
	private static void ReZxSxiJZ(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class1.smethod_4(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[(int)uint_5] + Class1.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0000469E File Offset: 0x0000289E
	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class1.smethod_4(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[(int)uint_5] + Class1.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000046C7 File Offset: 0x000028C7
	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class1.smethod_4(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[(int)uint_5] + Class1.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x000046ED File Offset: 0x000028ED
	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + Class1.smethod_4(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[(int)uint_5] + Class1.uint_0[(int)(uint_6 - 1U)], ushort_0);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00004714 File Offset: 0x00002914
	private static uint smethod_4(uint uint_1, ushort ushort_0)
	{
		return uint_1 >> (int)(32 - ushort_0) | uint_1 << (int)ushort_0;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00004726 File Offset: 0x00002926
	internal static bool smethod_5()
	{
		if (!Class1.bool_1)
		{
			Class1.smethod_7();
			Class1.bool_1 = true;
		}
		return Class1.bool_2;
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002289 File Offset: 0x00000489
	internal Class1()
	{
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00036A38 File Offset: 0x00034C38
	private void method_1(byte[] byte_2, byte[] byte_3, byte[] byte_4)
	{
		int num = byte_4.Length % 4;
		int num2 = byte_4.Length / 4;
		byte[] array = new byte[byte_4.Length];
		int num3 = byte_2.Length / 4;
		uint num4 = 0U;
		if (num > 0)
		{
			num2++;
		}
		for (int i = 0; i < num2; i++)
		{
			int num5 = i % num3;
			int num6 = i * 4;
			uint num7 = (uint)(num5 * 4);
			uint num8 = (uint)((int)byte_2[(int)(num7 + 3U)] << 24 | (int)byte_2[(int)(num7 + 2U)] << 16 | (int)byte_2[(int)(num7 + 1U)] << 8 | (int)byte_2[(int)num7]);
			uint num9 = 255U;
			int num10 = 0;
			uint num11;
			if (i == num2 - 1 && num > 0)
			{
				num11 = 0U;
				num4 += num8;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num11 <<= 8;
					}
					num11 |= (uint)byte_4[byte_4.Length - (1 + j)];
				}
			}
			else
			{
				num4 += num8;
				num7 = (uint)num6;
				num11 = (uint)((int)byte_4[(int)(num7 + 3U)] << 24 | (int)byte_4[(int)(num7 + 2U)] << 16 | (int)byte_4[(int)(num7 + 1U)] << 8 | (int)byte_4[(int)num7]);
			}
			uint num12 = num4;
			num4 = num12 + Class1.smethod_12(num12);
			if (i == num2 - 1 && num > 0)
			{
				uint num13 = num4 ^ num11;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num9 <<= 8;
						num10 += 8;
					}
					array[num6 + k] = (byte)((num13 & num9) >> num10);
				}
			}
			else
			{
				uint num14 = num4 ^ num11;
				array[num6] = (byte)(num14 & 255U);
				array[num6 + 1] = (byte)((num14 & 65280U) >> 8);
				array[num6 + 2] = (byte)((num14 & 16711680U) >> 16);
				array[num6 + 3] = (byte)((num14 & 4278190080U) >> 24);
			}
		}
		Class1.byte_0 = array;
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00036BE0 File Offset: 0x00034DE0
	internal static SymmetricAlgorithm smethod_6()
	{
		SymmetricAlgorithm result = null;
		if (Class1.smethod_5())
		{
			result = new AesCryptoServiceProvider();
		}
		else
		{
			try
			{
				result = new RijndaelManaged();
			}
			catch
			{
				try
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					result = (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}
		return result;
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00036C60 File Offset: 0x00034E60
	internal static void smethod_7()
	{
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			Class1.bool_2 = true;
			return;
		}
		try
		{
			Class1.bool_2 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x0000473F File Offset: 0x0000293F
	internal static byte[] smethod_8(byte[] byte_2)
	{
		if (!Class1.smethod_5())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_2);
		}
		return Class1.smethod_0(byte_2);
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00036CAC File Offset: 0x00034EAC
	internal static void smethod_9(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_1, byte[] byte_2)
	{
		while (uint_1 > 0U)
		{
			int num = (uint_1 > (uint)byte_2.Length) ? byte_2.Length : ((int)uint_1);
			stream_0.Read(byte_2, 0, num);
			Class1.VeZjNyNqf(hashAlgorithm_0, byte_2, 0, num);
			uint_1 -= (uint)num;
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x0000475A File Offset: 0x0000295A
	internal static void VeZjNyNqf(HashAlgorithm hashAlgorithm_0, byte[] byte_2, int int_6, int int_7)
	{
		hashAlgorithm_0.TransformBlock(byte_2, int_6, int_7, byte_2, int_6);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00036CE8 File Offset: 0x00034EE8
	internal static uint smethod_10(uint uint_1, int int_6, long long_2, BinaryReader binaryReader_0)
	{
		for (int i = 0; i < int_6; i++)
		{
			binaryReader_0.BaseStream.Position = long_2 + (long)(i * 40 + 8);
			uint num = binaryReader_0.ReadUInt32();
			uint num2 = binaryReader_0.ReadUInt32();
			binaryReader_0.ReadUInt32();
			uint num3 = binaryReader_0.ReadUInt32();
			if (num2 <= uint_1 && uint_1 < num2 + num)
			{
				return num3 + uint_1 - num2;
			}
		}
		return 0U;
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00036D44 File Offset: 0x00034F44
	public static void smethod_11(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Class1.dictionary_0 == null)
			{
				object obj = Class1.object_0;
				lock (obj)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Class1).Assembly.GetManifestResourceStream("NbKMPkk4x7wSMP1dPB.0k4sOHXp2TvaP9qgsS"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0U;
						if (num > 0)
						{
							num2++;
						}
						for (int i = 0; i < num2; i++)
						{
							int num4 = i * 4;
							uint num5 = 255U;
							int num6 = 0;
							uint num7;
							if (i == num2 - 1 && num > 0)
							{
								num7 = 0U;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num7 <<= 8;
									}
									num7 |= (uint)array[array.Length - (1 + j)];
								}
							}
							else
							{
								uint num8 = (uint)num4;
								num7 = (uint)((int)array[(int)(num8 + 3U)] << 24 | (int)array[(int)(num8 + 2U)] << 16 | (int)array[(int)(num8 + 1U)] << 8 | (int)array[(int)num8]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							num10 = 48271U * num10 - 1740689690U;
							num10 = 60396U * (num10 & 65535U) - (num10 >> 16);
							num10 ^= num10 >> 14;
							num10 += num10;
							num10 ^= num10 >> 15;
							num10 += 1623009022U;
							num10 ^= num10 << 13;
							num10 += 658165185U;
							num10 = 3474403674U + num10;
							num3 = num9 + (uint)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num7;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num5 <<= 8;
										num6 += 8;
									}
									array2[num4 + k] = (byte)((num11 & num5) >> num6);
								}
							}
							else
							{
								uint num12 = num3 ^ num7;
								array2[num4] = (byte)(num12 & 255U);
								array2[num4 + 1] = (byte)((num12 & 65280U) >> 8);
								array2[num4 + 2] = (byte)((num12 & 16711680U) >> 16);
								array2[num4 + 3] = (byte)((num12 & 4278190080U) >> 24);
							}
						}
						array = array2;
						int num13 = array.Length / 8;
						Class1.Class4 @class = new Class1.Class4(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = @class.method_3();
							int value = @class.method_3();
							dictionary.Add(key, value);
						}
						@class.method_4();
					}
					Class1.dictionary_0 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			for (int m = 0; m < fields.Length; m++)
			{
				try
				{
					FieldInfo fieldInfo = fields[m];
					int metadataToken = fieldInfo.MetadataToken;
					int num14 = Class1.dictionary_0[metadataToken];
					bool flag2 = (num14 & 1073741824) > 0;
					num14 &= 1073741823;
					MethodInfo methodInfo = (MethodInfo)typeof(Class1).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
					if (methodInfo.IsStatic)
					{
						fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					}
					else
					{
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num15 = parameters.Length + 1;
						Type[] array3 = new Type[num15];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, true);
						ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
						for (int num16 = 0; num16 < num15; num16++)
						{
							switch (num16)
							{
							case 0:
								ilgenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								ilgenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								ilgenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								ilgenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								ilgenerator.Emit(OpCodes.Ldarg_S, num16);
								break;
							}
						}
						ilgenerator.Emit(OpCodes.Tailcall);
						ilgenerator.Emit(flag2 ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						ilgenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00004768 File Offset: 0x00002968
	private static uint smethod_12(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00004774 File Offset: 0x00002974
	private static uint smethod_13(uint uint_1)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002287 File Offset: 0x00000487
	internal static void smethod_14()
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0003727C File Offset: 0x0003547C
	private static void smethod_15(Stream stream_0, int int_6)
	{
		Class6.smethod_2(0, new object[]
		{
			stream_0,
			int_6
		}, null);
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000372BC File Offset: 0x000354BC
	internal static string smethod_16(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00004780 File Offset: 0x00002980
	private static int smethod_17()
	{
		return 5;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x000372EC File Offset: 0x000354EC
	private static void smethod_18()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00037314 File Offset: 0x00035514
	private static Delegate smethod_19(IntPtr intptr_4, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[]
		{
			typeof(IntPtr),
			typeof(Type)
		}).Invoke(null, new object[]
		{
			intptr_4,
			type_0
		});
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00037374 File Offset: 0x00035574
	internal static object smethod_20(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(((Assembly)assembly_1).Location))
			{
				return ((Assembly)assembly_1).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "")))
			{
				return ((Assembly)assembly_1).GetName().CodeBase.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString()))
			{
				return assembly_1.GetType().GetProperty("Location").GetValue(assembly_1, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	// Token: 0x06000497 RID: 1175
	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	// Token: 0x06000498 RID: 1176
	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_4, string string_1);

	// Token: 0x06000499 RID: 1177 RVA: 0x00037484 File Offset: 0x00035684
	private static IntPtr smethod_21(IntPtr intptr_4, string string_1, uint uint_1)
	{
		if (Class1.delegate4_0 == null)
		{
			Class1.delegate4_0 = (Class1.Delegate4)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Find ".Trim() + "ResourceA"), typeof(Class1.Delegate4));
		}
		return Class1.delegate4_0(intptr_4, string_1, uint_1);
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x000374DC File Offset: 0x000356DC
	private static IntPtr smethod_22(IntPtr intptr_4, uint uint_1, uint uint_2, uint uint_3)
	{
		if (Class1.delegate5_0 == null)
		{
			Class1.delegate5_0 = (Class1.Delegate5)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Virtual ".Trim() + "Alloc"), typeof(Class1.Delegate5));
		}
		return Class1.delegate5_0(intptr_4, uint_1, uint_2, uint_3);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00037538 File Offset: 0x00035738
	private static int smethod_23(IntPtr intptr_4, IntPtr intptr_5, [In] [Out] byte[] byte_2, uint uint_1, out IntPtr intptr_6)
	{
		if (Class1.delegate6_0 == null)
		{
			Class1.delegate6_0 = (Class1.Delegate6)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Class1.Delegate6));
		}
		return Class1.delegate6_0(intptr_4, intptr_5, byte_2, uint_1, out intptr_6);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x000375A0 File Offset: 0x000357A0
	private static int smethod_24(IntPtr intptr_4, int int_6, int int_7, ref int int_8)
	{
		if (Class1.delegate7_0 == null)
		{
			Class1.delegate7_0 = (Class1.Delegate7)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Virtual ".Trim() + "Protect"), typeof(Class1.Delegate7));
		}
		return Class1.delegate7_0(intptr_4, int_6, int_7, ref int_8);
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000375FC File Offset: 0x000357FC
	private static IntPtr smethod_25(uint uint_1, int int_6, uint uint_2)
	{
		if (Class1.delegate8_0 == null)
		{
			Class1.delegate8_0 = (Class1.Delegate8)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Open ".Trim() + "Process"), typeof(Class1.Delegate8));
		}
		return Class1.delegate8_0(uint_1, int_6, uint_2);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00037654 File Offset: 0x00035854
	private static int smethod_26(IntPtr intptr_4)
	{
		if (Class1.delegate9_0 == null)
		{
			Class1.delegate9_0 = (Class1.Delegate9)Marshal.GetDelegateForFunctionPointer(Class1.GetProcAddress(Class1.smethod_27(), "Close ".Trim() + "Handle"), typeof(Class1.Delegate9));
		}
		return Class1.delegate9_0(intptr_4);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00004783 File Offset: 0x00002983
	private static IntPtr smethod_27()
	{
		if (Class1.intptr_3 == IntPtr.Zero)
		{
			Class1.intptr_3 = Class1.LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Class1.intptr_3;
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x000376AC File Offset: 0x000358AC
	private static byte[] smethod_28(string string_1)
	{
		byte[] array;
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read))
		{
			int num = 0;
			int i = (int)fileStream.Length;
			array = new byte[i];
			while (i > 0)
			{
				int num2 = fileStream.Read(array, num, i);
				num += num2;
				i -= num2;
			}
		}
		return array;
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x000047B9 File Offset: 0x000029B9
	internal static byte[] smethod_29(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x0003770C File Offset: 0x0003590C
	private static byte[] smethod_30(byte[] byte_2)
	{
		Stream stream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_6();
		symmetricAlgorithm.Key = new byte[]
		{
			123,
			5,
			74,
			12,
			244,
			156,
			221,
			154,
			121,
			221,
			183,
			41,
			121,
			65,
			9,
			43,
			67,
			81,
			23,
			43,
			74,
			63,
			64,
			23,
			95,
			185,
			226,
			244,
			45,
			194,
			211,
			43
		};
		symmetricAlgorithm.IV = new byte[]
		{
			117,
			254,
			41,
			121,
			65,
			52,
			9,
			43,
			221,
			154,
			12,
			54,
			68,
			241,
			68,
			66
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_2, 0, byte_2.Length);
		cryptoStream.Close();
		return Class1.smethod_29(stream);
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x000047C6 File Offset: 0x000029C6
	private byte[] method_2()
	{
		int length = "{11111-22222-10001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x000047E1 File Offset: 0x000029E1
	private byte[] method_3()
	{
		int length = "{11111-22222-10001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x000047FC File Offset: 0x000029FC
	private byte[] method_4()
	{
		int length = "{11111-22222-20001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00004817 File Offset: 0x00002A17
	private byte[] method_5()
	{
		int length = "{11111-22222-20001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00004832 File Offset: 0x00002A32
	private byte[] method_6()
	{
		int length = "{11111-22222-30001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x0000484D File Offset: 0x00002A4D
	private byte[] method_7()
	{
		int length = "{11111-22222-30001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00004868 File Offset: 0x00002A68
	internal byte[] method_8()
	{
		int length = "{11111-22222-40001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00004883 File Offset: 0x00002A83
	internal byte[] method_9()
	{
		int length = "{11111-22222-40001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x0000489E File Offset: 0x00002A9E
	internal byte[] method_10()
	{
		int length = "{11111-22222-50001-00001}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x000048B9 File Offset: 0x00002AB9
	internal byte[] method_11()
	{
		int length = "{11111-22222-50001-00002}".Length;
		return new byte[]
		{
			1,
			2
		};
	}

	// Token: 0x040003C7 RID: 967
	private static bool bool_0 = false;

	// Token: 0x040003C8 RID: 968
	internal static Assembly assembly_0 = typeof(Class1).Assembly;

	// Token: 0x040003C9 RID: 969
	private static uint[] uint_0 = new uint[]
	{
		3614090360U,
		3905402710U,
		606105819U,
		3250441966U,
		4118548399U,
		1200080426U,
		2821735955U,
		4249261313U,
		1770035416U,
		2336552879U,
		4294925233U,
		2304563134U,
		1804603682U,
		4254626195U,
		2792965006U,
		1236535329U,
		4129170786U,
		3225465664U,
		643717713U,
		3921069994U,
		3593408605U,
		38016083U,
		3634488961U,
		3889429448U,
		568446438U,
		3275163606U,
		4107603335U,
		1163531501U,
		2850285829U,
		4243563512U,
		1735328473U,
		2368359562U,
		4294588738U,
		2272392833U,
		1839030562U,
		4259657740U,
		2763975236U,
		1272893353U,
		4139469664U,
		3200236656U,
		681279174U,
		3936430074U,
		3572445317U,
		76029189U,
		3654602809U,
		3873151461U,
		530742520U,
		3299628645U,
		4096336452U,
		1126891415U,
		2878612391U,
		4237533241U,
		1700485571U,
		2399980690U,
		4293915773U,
		2240044497U,
		1873313359U,
		4264355552U,
		2734768916U,
		1309151649U,
		4149444226U,
		3174756917U,
		718787259U,
		3951481745U
	};

	// Token: 0x040003CA RID: 970
	private static bool bool_1 = false;

	// Token: 0x040003CB RID: 971
	private static bool bool_2 = false;

	// Token: 0x040003CC RID: 972
	internal static RSACryptoServiceProvider rsacryptoServiceProvider_0 = null;

	// Token: 0x040003CD RID: 973
	private static Dictionary<int, int> dictionary_0 = null;

	// Token: 0x040003CE RID: 974
	private static object object_0 = new object();

	// Token: 0x040003CF RID: 975
	private static int int_0 = 0;

	// Token: 0x040003D0 RID: 976
	private static object object_1 = new object();

	// Token: 0x040003D1 RID: 977
	private static List<string> list_0 = null;

	// Token: 0x040003D2 RID: 978
	private static List<int> list_1 = null;

	// Token: 0x040003D3 RID: 979
	private static byte[] byte_0 = new byte[0];

	// Token: 0x040003D4 RID: 980
	private static byte[] byte_1 = new byte[0];

	// Token: 0x040003D5 RID: 981
	private static IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x040003D6 RID: 982
	private static IntPtr intptr_1 = IntPtr.Zero;

	// Token: 0x040003D7 RID: 983
	private static string[] string_0 = new string[0];

	// Token: 0x040003D8 RID: 984
	private static int[] int_1 = new int[0];

	// Token: 0x040003D9 RID: 985
	private static int int_2 = 1;

	// Token: 0x040003DA RID: 986
	private static bool usfLnHavse = false;

	// Token: 0x040003DB RID: 987
	private static SortedList sortedList_0 = new SortedList();

	// Token: 0x040003DC RID: 988
	private static int int_3 = 0;

	// Token: 0x040003DD RID: 989
	private static long long_0 = 0L;

	// Token: 0x040003DE RID: 990
	internal static Class1.Delegate2 delegate2_0 = null;

	// Token: 0x040003DF RID: 991
	internal static Class1.Delegate2 delegate2_1 = null;

	// Token: 0x040003E0 RID: 992
	private static long long_1 = 0L;

	// Token: 0x040003E1 RID: 993
	private static int int_4 = 0;

	// Token: 0x040003E2 RID: 994
	private static bool bool_3 = false;

	// Token: 0x040003E3 RID: 995
	private static bool bool_4 = false;

	// Token: 0x040003E4 RID: 996
	private static int int_5 = 0;

	// Token: 0x040003E5 RID: 997
	private static IntPtr intptr_2 = IntPtr.Zero;

	// Token: 0x040003E6 RID: 998
	[Class1.Attribute0(typeof(Class1.Attribute0.Class2<object>[]))]
	private static bool firstrundone = false;

	// Token: 0x040003E7 RID: 999
	internal static Hashtable hashtable_0 = new Hashtable();

	// Token: 0x040003E8 RID: 1000
	private static Class1.Delegate4 delegate4_0 = null;

	// Token: 0x040003E9 RID: 1001
	private static Class1.Delegate5 delegate5_0 = null;

	// Token: 0x040003EA RID: 1002
	private static Class1.Delegate6 delegate6_0 = null;

	// Token: 0x040003EB RID: 1003
	private static Class1.Delegate7 delegate7_0 = null;

	// Token: 0x040003EC RID: 1004
	private static Class1.Delegate8 delegate8_0 = null;

	// Token: 0x040003ED RID: 1005
	private static Class1.Delegate9 delegate9_0 = null;

	// Token: 0x040003EE RID: 1006
	private static IntPtr intptr_3 = IntPtr.Zero;

	// Token: 0x020000A9 RID: 169
	// (Invoke) Token: 0x060004AE RID: 1198
	private delegate void Delegate1(object o);

	// Token: 0x020000AA RID: 170
	internal class Attribute0 : Attribute
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x000048D4 File Offset: 0x00002AD4
		public Attribute0(object object_0)
		{
		}

		// Token: 0x020000AB RID: 171
		internal class Class2<T>
		{
		}
	}

	// Token: 0x020000AC RID: 172
	internal class Class3
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00037778 File Offset: 0x00035978
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] key = new byte[]
			{
				82,
				102,
				104,
				110,
				32,
				77,
				24,
				34,
				118,
				181,
				51,
				17,
				18,
				51,
				12,
				109,
				10,
				32,
				77,
				24,
				34,
				158,
				161,
				41,
				97,
				28,
				118,
				181,
				5,
				25,
				1,
				88
			};
			byte[] iv = Class1.smethod_8(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = Class1.smethod_6();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iv;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}
	}

	// Token: 0x020000AD RID: 173
	// (Invoke) Token: 0x060004B6 RID: 1206
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate2(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	// Token: 0x020000AE RID: 174
	// (Invoke) Token: 0x060004BA RID: 1210
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate3();

	// Token: 0x020000AF RID: 175
	internal struct Struct3
	{
		// Token: 0x040003EF RID: 1007
		internal bool bool_0;

		// Token: 0x040003F0 RID: 1008
		internal byte[] byte_0;
	}

	// Token: 0x020000B0 RID: 176
	internal class Class4
	{
		// Token: 0x060004BD RID: 1213 RVA: 0x000048DC File Offset: 0x00002ADC
		public Class4(Stream stream_0)
		{
			this.binaryReader_0 = new BinaryReader(stream_0);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000048F0 File Offset: 0x00002AF0
		internal Stream method_0()
		{
			return this.binaryReader_0.BaseStream;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000048FD File Offset: 0x00002AFD
		internal byte[] method_1(int int_0)
		{
			return this.binaryReader_0.ReadBytes(int_0);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000490B File Offset: 0x00002B0B
		internal int method_2(byte[] byte_0, int int_0, int int_1)
		{
			return this.binaryReader_0.Read(byte_0, int_0, int_1);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000491B File Offset: 0x00002B1B
		internal int method_3()
		{
			return this.binaryReader_0.ReadInt32();
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00004928 File Offset: 0x00002B28
		internal void method_4()
		{
			this.binaryReader_0.Close();
		}

		// Token: 0x040003F1 RID: 1009
		private BinaryReader binaryReader_0;
	}

	// Token: 0x020000B1 RID: 177
	// (Invoke) Token: 0x060004C4 RID: 1220
	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr Delegate4(IntPtr hModule, string lpName, uint lpType);

	// Token: 0x020000B2 RID: 178
	// (Invoke) Token: 0x060004C8 RID: 1224
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate5(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	// Token: 0x020000B3 RID: 179
	// (Invoke) Token: 0x060004CC RID: 1228
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate6(IntPtr hProcess, IntPtr lpBaseAddress, [In] [Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	// Token: 0x020000B4 RID: 180
	// (Invoke) Token: 0x060004D0 RID: 1232
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate7(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	// Token: 0x020000B5 RID: 181
	// (Invoke) Token: 0x060004D4 RID: 1236
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	// Token: 0x020000B6 RID: 182
	// (Invoke) Token: 0x060004D8 RID: 1240
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Delegate9(IntPtr ptr);

	// Token: 0x020000B7 RID: 183
	[Flags]
	private enum Enum0
	{

	}
}
