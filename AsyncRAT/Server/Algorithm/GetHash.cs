using System;
using System.IO;
using System.Security.Cryptography;

namespace Server.Algorithm
{
	// Token: 0x0200009C RID: 156
	public static class GetHash
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00035BC4 File Offset: 0x00033DC4
		public static string GetChecksum(string file)
		{
			string result;
			using (FileStream fileStream = File.OpenRead(file))
			{
				result = BitConverter.ToString(new SHA256Managed().ComputeHash(fileStream)).Replace("-", string.Empty);
			}
			return result;
		}
	}
}
