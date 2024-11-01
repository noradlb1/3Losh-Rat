using System;
using System.IO;

namespace Server.MessagePack
{
	// Token: 0x02000047 RID: 71
	internal class ReadTools
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x0001D438 File Offset: 0x0001B638
		public static string ReadString(Stream ms, int len)
		{
			byte[] array = new byte[len];
			ms.Read(array, 0, len);
			return BytesTools.GetString(array);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003963 File Offset: 0x00001B63
		public static string ReadString(Stream ms)
		{
			return ReadTools.ReadString((byte)ms.ReadByte(), ms);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001D45C File Offset: 0x0001B65C
		public static string ReadString(byte strFlag, Stream ms)
		{
			int num = 0;
			byte[] array;
			if (strFlag >= 160 && strFlag <= 191)
			{
				num = (int)(strFlag - 160);
			}
			else if (strFlag == 217)
			{
				num = ms.ReadByte();
			}
			else if (strFlag == 218)
			{
				array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (strFlag == 219)
			{
				array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			ms.Read(array, 0, num);
			return BytesTools.GetString(array);
		}
	}
}
