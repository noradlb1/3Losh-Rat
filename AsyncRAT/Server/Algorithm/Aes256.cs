using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Server.Algorithm
{
	// Token: 0x0200009B RID: 155
	public class Aes256
	{
		// Token: 0x0600045E RID: 1118 RVA: 0x00035828 File Offset: 0x00033A28
		public Aes256(string masterKey)
		{
			if (string.IsNullOrEmpty(masterKey))
			{
				throw new ArgumentException("masterKey can not be null or empty.");
			}
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(masterKey, Aes256.Salt, 50000))
			{
				this._key = rfc2898DeriveBytes.GetBytes(32);
				this._authKey = rfc2898DeriveBytes.GetBytes(64);
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000045D9 File Offset: 0x000027D9
		public string Encrypt(string input)
		{
			return Convert.ToBase64String(this.Encrypt(Encoding.UTF8.GetBytes(input)));
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00035898 File Offset: 0x00033A98
		public byte[] Encrypt(byte[] input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				memoryStream.Position = 32L;
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this._key;
					aesCryptoServiceProvider.GenerateIV();
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
					{
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
						cryptoStream.Write(input, 0, input.Length);
						cryptoStream.FlushFinalBlock();
						using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
						{
							byte[] array = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
							memoryStream.Position = 0L;
							memoryStream.Write(array, 0, array.Length);
						}
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000045F1 File Offset: 0x000027F1
		public string Decrypt(string input)
		{
			return Encoding.UTF8.GetString(this.Decrypt(Convert.FromBase64String(input)));
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000359E8 File Offset: 0x00033BE8
		public byte[] Decrypt(byte[] input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input can not be null.");
			}
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(input))
			{
				using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
				{
					aesCryptoServiceProvider.KeySize = 256;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = this._key;
					using (HMACSHA256 hmacsha = new HMACSHA256(this._authKey))
					{
						byte[] a = hmacsha.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
						byte[] array = new byte[32];
						memoryStream.Read(array, 0, array.Length);
						if (!this.AreEqual(a, array))
						{
							throw new CryptographicException("Invalid message authentication code (MAC).");
						}
					}
					byte[] array2 = new byte[16];
					memoryStream.Read(array2, 0, 16);
					aesCryptoServiceProvider.IV = array2;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read))
					{
						byte[] array3 = new byte[memoryStream.Length - 16L + 1L];
						byte[] array4 = new byte[cryptoStream.Read(array3, 0, array3.Length)];
						Buffer.BlockCopy(array3, 0, array4, 0, array4.Length);
						result = array4;
					}
				}
			}
			return result;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00035B9C File Offset: 0x00033D9C
		private bool AreEqual(byte[] a1, byte[] a2)
		{
			bool result = true;
			for (int i = 0; i < a1.Length; i++)
			{
				if (a1[i] != a2[i])
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x040003BB RID: 955
		private readonly byte[] _key;

		// Token: 0x040003BC RID: 956
		private readonly byte[] _authKey;

		// Token: 0x040003BD RID: 957
		private static readonly byte[] Salt = new byte[]
		{
			191,
			235,
			30,
			86,
			251,
			205,
			151,
			59,
			178,
			25,
			2,
			36,
			48,
			165,
			120,
			67,
			0,
			61,
			86,
			68,
			210,
			30,
			98,
			185,
			212,
			241,
			128,
			231,
			230,
			195,
			57,
			65
		};
	}
}
