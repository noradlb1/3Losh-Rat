using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000002 RID: 2
public class HashG
{
	// Token: 0x06000003 RID: 3 RVA: 0x0000BC98 File Offset: 0x00009E98
	public static object Bot()
	{
		object result;
		try
		{
			result = Operators.ConcatenateObject(Operators.ConcatenateObject(HashG.UserName(), "_"), HashG.HWID());
		}
		catch (Exception)
		{
			result = "Error";
		}
		return result;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000BCDC File Offset: 0x00009EDC
	public static object UserName()
	{
		object result;
		try
		{
			result = Environment.UserName;
		}
		catch (Exception)
		{
			result = "Error";
		}
		return result;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000BD0C File Offset: 0x00009F0C
	public static string HWID()
	{
		string result;
		try
		{
			result = HashG.MD5HASH(HashG.Identifier("Win32_Processor", "ProcessorId") + "-" + HashG.Identifier("Win32_BIOS", "SerialNumber") + "-" + HashG.Identifier("Win32_BaseBoard", "SerialNumber") + "-" + HashG.Identifier("Win32_VideoController", "Name"));
		}
		catch (Exception)
		{
			result = "Error";
		}
		return result;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000BD98 File Offset: 0x00009F98
	private static string Identifier(string wmiClass, string wmiProperty)
	{
		string result;
		try
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass(wmiClass).GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (string.IsNullOrEmpty(text))
				{
					bool flag = false;
					try
					{
						text = managementObject[wmiProperty].ToString();
						flag = true;
						break;
					}
					catch
					{
					}
					if (flag)
					{
						break;
					}
				}
			}
			result = text;
		}
		catch (Exception)
		{
			result = "Error";
		}
		return result;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000BE3C File Offset: 0x0000A03C
	public static string MD5HASH(string input)
	{
		string result;
		try
		{
			byte[] array = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(input));
			StringBuilder stringBuilder = new StringBuilder();
			int i = 10;
			int num = array.Length - 1;
			while (i <= num)
			{
				stringBuilder.Append(array[i].ToString("x2"));
				i++;
			}
			result = stringBuilder.ToString().ToUpper();
		}
		catch (Exception)
		{
			result = "Error";
		}
		return result;
	}
}
