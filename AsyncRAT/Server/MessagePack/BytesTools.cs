using System;
using System.Text;

namespace Server.MessagePack
{
	// Token: 0x02000040 RID: 64
	public class BytesTools
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00003660 File Offset: 0x00001860
		public static byte[] GetUtf8Bytes(string s)
		{
			return BytesTools.utf8Encoding_0.GetBytes(s);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000366D File Offset: 0x0000186D
		public static string GetString(byte[] byte_0)
		{
			return BytesTools.utf8Encoding_0.GetString(byte_0);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001C224 File Offset: 0x0001A424
		public static string BytesAsString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001C268 File Offset: 0x0001A468
		public static string BytesAsHexString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		public static byte[] SwapBytes(byte[] v)
		{
			byte[] array = new byte[v.Length];
			int num = v.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = v[num];
				num--;
			}
			return array;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000367A File Offset: 0x0000187A
		public static byte[] smethod_0(long v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00003687 File Offset: 0x00001887
		public static byte[] smethod_1(int v)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)v
			};
			array[2] = (byte)(v >> 8);
			array[1] = (byte)(v >> 16);
			array[0] = (byte)(v >> 24);
			return array;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000036AB File Offset: 0x000018AB
		public static byte[] smethod_2(short v)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)v
			};
			array[0] = (byte)(v >> 8);
			return array;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000036BF File Offset: 0x000018BF
		public static byte[] SwapDouble(double v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x04000189 RID: 393
		private static UTF8Encoding utf8Encoding_0 = new UTF8Encoding();
	}
}
