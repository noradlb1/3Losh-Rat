using System;
using System.Text;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000034 RID: 52
	internal static class DecryptionHelper
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x0001AFB8 File Offset: 0x000191B8
		public static string Decrypt_Base64(string dataEnc)
		{
			string result;
			try
			{
				result = Encoding.UTF8.GetString(Convert.FromBase64String(dataEnc));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
