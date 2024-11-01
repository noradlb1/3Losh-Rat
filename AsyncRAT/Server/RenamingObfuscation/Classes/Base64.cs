using System;
using System.Text;
using Server.RenamingObfuscation.Interfaces;

namespace Server.RenamingObfuscation.Classes
{
	// Token: 0x02000032 RID: 50
	public class Base64 : ICrypto
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0001AC40 File Offset: 0x00018E40
		public string Encrypt(string dataPlain)
		{
			string result;
			try
			{
				result = Convert.ToBase64String(Encoding.UTF8.GetBytes(dataPlain));
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
