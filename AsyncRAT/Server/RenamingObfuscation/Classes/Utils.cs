using System;
using System.Text;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x0200003D RID: 61
	public static class Utils
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		public static string GenerateRandomString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i <= Utils.random.Next(10, 20); i++)
			{
				int index = Utils.random.Next(0, "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM".Length);
				stringBuilder.Append("qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM"[index]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000185 RID: 389
		private static readonly Random random = new Random();
	}
}
