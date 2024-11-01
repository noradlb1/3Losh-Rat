using System;
using System.Security.Cryptography;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000018 RID: 24
	public static class encryption
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000E160 File Offset: 0x0000C360
		public static string HashHMAC(string enckey, string resp)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(enckey);
			byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
			return encryption.byte_arr_to_str(new HMACSHA256(bytes).ComputeHash(bytes2));
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000E194 File Offset: 0x0000C394
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[length / 2];
				for (int i = 0; i < length; i += 2)
				{
					array[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch
			{
				api.error("The session has ended, open program again.");
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000E240 File Offset: 0x0000C440
		public static bool CheckStringsFixedTime(string str1, string str2)
		{
			if (str1.Length != str2.Length)
			{
				return false;
			}
			int num = 0;
			for (int i = 0; i < str1.Length; i++)
			{
				num |= (int)(str1[i] ^ str2[i]);
			}
			return num == 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000E288 File Offset: 0x0000C488
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, 16);
		}
	}
}
