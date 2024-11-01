using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Connection;
using Server.Helper;

namespace Server.Forms
{
	// Token: 0x02000095 RID: 149
	public partial class FormDownloadFile : Form
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000438C File Offset: 0x0000258C
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00004394 File Offset: 0x00002594
		public Form1 F { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000439D File Offset: 0x0000259D
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x000043A5 File Offset: 0x000025A5
		internal Clients Client { get; set; }

		// Token: 0x06000424 RID: 1060 RVA: 0x000043AE File Offset: 0x000025AE
		public FormDownloadFile()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000335F8 File Offset: 0x000317F8
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!this.IsUpload)
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.Client.BytesRecevied);
				if (this.Client.BytesRecevied >= this.FileSize)
				{
					this.labelsize.Text = "Downloaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
					return;
				}
			}
			else
			{
				this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.BytesSent);
				if (this.BytesSent >= this.FileSize)
				{
					this.labelsize.Text = "Uploaded";
					this.labelsize.ForeColor = Color.Green;
					this.timer1.Stop();
				}
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000336E4 File Offset: 0x000318E4
		private void SocketDownload_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				Clients client = this.Client;
				if (client != null)
				{
					client.Disconnected();
				}
				Timer timer = this.timer1;
				if (timer != null)
				{
					timer.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00033728 File Offset: 0x00031928
		public void Send(object obj)
		{
			object sendSync = this.Client.SendSync;
			lock (sendSync)
			{
				try
				{
					this.IsUpload = true;
					byte[] array = (byte[])obj;
					byte[] bytes = BitConverter.GetBytes(array.Length);
					this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
					this.Client.SslClient.Write(bytes, 0, bytes.Length);
					using (MemoryStream memoryStream = new MemoryStream(array))
					{
						memoryStream.Position = 0L;
						byte[] array2 = new byte[50000];
						int num;
						while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
						{
							this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
							this.Client.SslClient.Write(array2, 0, num);
							this.BytesSent += (long)num;
						}
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						base.Close();
					}));
				}
				catch
				{
					Clients client = this.Client;
					if (client != null)
					{
						client.Disconnected();
					}
					Program.form1.BeginInvoke(new MethodInvoker(delegate()
					{
						this.labelsize.Text = "Error";
						this.labelsize.ForeColor = Color.Red;
					}));
				}
			}
		}

		// Token: 0x04000381 RID: 897
		public long FileSize;

		// Token: 0x04000382 RID: 898
		private long BytesSent;

		// Token: 0x04000383 RID: 899
		public string FullFileName;

		// Token: 0x04000384 RID: 900
		public string ClientFullFileName;

		// Token: 0x04000385 RID: 901
		private bool IsUpload;

		// Token: 0x04000386 RID: 902
		public string DirPath;
	}
}
