using System;
using System.IO;

namespace Server.MessagePack
{
	// Token: 0x02000048 RID: 72
	internal class WriteTools
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00003972 File Offset: 0x00001B72
		public static void WriteNull(Stream ms)
		{
			ms.WriteByte(192);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001D504 File Offset: 0x0001B704
		public static void WriteString(Stream ms, string strVal)
		{
			byte[] utf8Bytes = BytesTools.GetUtf8Bytes(strVal);
			int num = utf8Bytes.Length;
			if (num <= 31)
			{
				byte value = 160 + (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 255)
			{
				ms.WriteByte(217);
				byte value = (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 65535)
			{
				ms.WriteByte(218);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				ms.WriteByte(219);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
				ms.Write(array, 0, array.Length);
			}
			ms.Write(utf8Bytes, 0, utf8Bytes.Length);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		public static void WriteBinary(Stream ms, byte[] rawBytes)
		{
			int num = rawBytes.Length;
			if (num <= 255)
			{
				ms.WriteByte(196);
				byte value = (byte)num;
				ms.WriteByte(value);
			}
			else if (num <= 65535)
			{
				ms.WriteByte(197);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
				ms.Write(array, 0, array.Length);
			}
			else
			{
				ms.WriteByte(198);
				byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
				ms.Write(array, 0, array.Length);
			}
			ms.Write(rawBytes, 0, rawBytes.Length);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000397F File Offset: 0x00001B7F
		public static void WriteFloat(Stream ms, double fVal)
		{
			ms.WriteByte(203);
			ms.Write(BytesTools.SwapDouble(fVal), 0, 8);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000399A File Offset: 0x00001B9A
		public static void WriteSingle(Stream ms, float fVal)
		{
			ms.WriteByte(202);
			ms.Write(BytesTools.SwapBytes(BitConverter.GetBytes(fVal)), 0, 4);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000039BA File Offset: 0x00001BBA
		public static void WriteBoolean(Stream ms, bool bVal)
		{
			if (bVal)
			{
				ms.WriteByte(195);
				return;
			}
			ms.WriteByte(194);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0001D668 File Offset: 0x0001B868
		public static void smethod_0(Stream ms, ulong iVal)
		{
			ms.WriteByte(207);
			byte[] bytes = BitConverter.GetBytes(iVal);
			ms.Write(BytesTools.SwapBytes(bytes), 0, 8);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001D698 File Offset: 0x0001B898
		public static void WriteInteger(Stream ms, long iVal)
		{
			if (iVal >= 0L)
			{
				if (iVal <= 127L)
				{
					ms.WriteByte((byte)iVal);
					return;
				}
				if (iVal <= 255L)
				{
					ms.WriteByte(204);
					ms.WriteByte((byte)iVal);
					return;
				}
				if (iVal <= 65535L)
				{
					ms.WriteByte(205);
					ms.Write(BytesTools.smethod_2((short)iVal), 0, 2);
					return;
				}
				if (iVal <= 4294967295L)
				{
					ms.WriteByte(206);
					ms.Write(BytesTools.smethod_1((int)iVal), 0, 4);
					return;
				}
				ms.WriteByte(211);
				ms.Write(BytesTools.smethod_0(iVal), 0, 8);
				return;
			}
			else
			{
				if (iVal <= -2147483648L)
				{
					ms.WriteByte(211);
					ms.Write(BytesTools.smethod_0(iVal), 0, 8);
					return;
				}
				if (iVal <= -32768L)
				{
					ms.WriteByte(210);
					ms.Write(BytesTools.smethod_1((int)iVal), 0, 4);
					return;
				}
				if (iVal <= -128L)
				{
					ms.WriteByte(209);
					ms.Write(BytesTools.smethod_2((short)iVal), 0, 2);
					return;
				}
				if (iVal <= -32L)
				{
					ms.WriteByte(208);
					ms.WriteByte((byte)iVal);
					return;
				}
				ms.WriteByte((byte)iVal);
				return;
			}
		}
	}
}
