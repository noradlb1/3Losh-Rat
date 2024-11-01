using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Server.Helper;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000090 RID: 144
	public partial class FormPorts : Form
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x00004189 File Offset: 0x00002389
		public FormPorts()
		{
			this.InitializeComponent();
			base.Opacity = 0.0;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00030C58 File Offset: 0x0002EE58
		private void PortsFrm_Load(object sender, EventArgs e)
		{
			this.textBox1.Text = HashG.Bot().ToString();
			try
			{
				this.textBox2.Text = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\AsyncRAT", "License", null).ToString();
			}
			catch (Exception)
			{
			}
			Methods.FadeIn(this, 5);
			if (Settings.Default.Ports.Length == 0)
			{
				this.listBox1.Items.AddRange(new object[]
				{
					"6606",
					"7707",
					"8808"
				});
			}
			else
			{
				try
				{
					foreach (string text in Settings.Default.Ports.Split(new string[]
					{
						","
					}, StringSplitOptions.None))
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							this.listBox1.Items.Add(text.Trim());
						}
					}
				}
				catch
				{
				}
			}
			this.Text = Settings.Version + " | Welcome " + Environment.UserName;
			if (!File.Exists(Settings.CertificatePath))
			{
				using (FormCertificate formCertificate = new FormCertificate())
				{
					formCertificate.ShowDialog();
					return;
				}
			}
			Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (FormPorts.AES_Encrypt(this.textBox2.Text, this.textBox1.Text))
				{
					Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\AsyncRAT", "License", this.textBox2.Text);
					if (this.listBox1.Items.Count > 0)
					{
						string text = "";
						foreach (object obj in this.listBox1.Items)
						{
							string str = (string)obj;
							text = text + str + ",";
						}
						//Settings.Default.Ports = text.Remove(text.Length - 1);
						//Settings.Default.Save();
						FormPorts.isOK = true;
						base.Close();
					}
				}
				else
				{
					MessageBox.Show("Contact Us :" + Environment.NewLine + "Telegram : RXRcode    ", "Error >> Wrong Bin!");
					Process.Start("https://t.me/RXRcode    ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		public static bool AES_Encrypt(string cc, string idd)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			bool result;
			try
			{
				byte[] array = new byte[32];
				byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(FormPorts.SBxx(idd.Split(new string[]
				{
					"_"
				}, StringSplitOptions.RemoveEmptyEntries)[1] + idd.Split(new string[]
				{
					"_"
				}, StringSplitOptions.RemoveEmptyEntries)[1] + "AsyncRAT"));
				Array.Copy(sourceArray, 0, array, 0, 16);
				Array.Copy(sourceArray, 0, array, 15, 16);
				rijndaelManaged.Key = array;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
				byte[] array2 = FormPorts.SBxx(idd);
				if (Convert.ToBase64String(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length)) == cc)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000041A6 File Offset: 0x000023A6
		public static byte[] SBxx(string s)
		{
			return Encoding.UTF8.GetBytes(s);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000041B3 File Offset: 0x000023B3
		private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (!FormPorts.isOK)
			{
				Program.form1.notifyIcon1.Dispose();
				Environment.Exit(0);
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				Convert.ToInt32(this.textPorts.Text.Trim());
				this.listBox1.Items.Add(this.textPorts.Text.Trim());
				this.textPorts.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000041D1 File Offset: 0x000023D1
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Remove(this.listBox1.SelectedItem);
		}

		// Token: 0x0400033E RID: 830
		private static bool isOK;
	}
}
