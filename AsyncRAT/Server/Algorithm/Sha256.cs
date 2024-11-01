using System;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x0200009D RID: 157
	public static class Sha256
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x00035C18 File Offset: 0x00033E18
		public static string ComputeHash(string input)
		{
			byte[] array = Encoding.UTF8.GetBytes(input);
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				array = sha256Managed.ComputeHash(array);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString().ToUpper();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00035C9C File Offset: 0x00033E9C
		public static byte[] ComputeHash(byte[] input)
		{
			byte[] result;
			using (SHA256Managed sha256Managed = new SHA256Managed())
			{
				result = sha256Managed.ComputeHash(input);
			}
			return result;
		}
	}
}
