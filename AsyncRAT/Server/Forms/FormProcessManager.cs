using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000091 RID: 145
	public partial class FormProcessManager : Form
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x0000420D File Offset: 0x0000240D
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00004215 File Offset: 0x00002415
		public Form1 F { get; set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000421E File Offset: 0x0000241E
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00004226 File Offset: 0x00002426
		internal Clients Client { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000422F File Offset: 0x0000242F
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00004237 File Offset: 0x00002437
		internal Clients ParentClient { get; set; }

		// Token: 0x060003F5 RID: 1013 RVA: 0x00004240 File Offset: 0x00002440
		public FormProcessManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000316D4 File Offset: 0x0002F8D4
		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.Client.TcpClient.Connected || !this.ParentClient.TcpClient.Connected)
				{
					base.Close();
				}
			}
			catch
			{
				base.Close();
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00031728 File Offset: 0x0002F928
		private void killToolStripMenuItem_Click(object sender, EventArgs e)
		{
			////FormProcessManager.<killToolStripMenuItem_Click>d__14 <killToolStripMenuItem_Click>d__;
			//<killToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<killToolStripMenuItem_Click>d__.<>4__this = this;
			//<killToolStripMenuItem_Click>d__.<>1__state = -1;
			//<killToolStripMenuItem_Click>d__.<>t__builder.Start<FormProcessManager.<killToolStripMenuItem_Click>d__14>(ref <killToolStripMenuItem_Click>d__);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000424E File Offset: 0x0000244E
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ThreadPool.QueueUserWorkItem(delegate(object o)
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "processManager";
				msgPack.ForcePathObject("Option").AsString = "List";
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
			});
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00031760 File Offset: 0x0002F960
		private void FormProcessManager_FormClosed(object sender, FormClosedEventArgs e)
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
	}
}
