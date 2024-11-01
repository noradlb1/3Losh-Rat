using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200007D RID: 125
	public partial class Clipper : Form
	{
		// Token: 0x06000320 RID: 800 RVA: 0x00003C4F File Offset: 0x00001E4F
		public Clipper()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00022D00 File Offset: 0x00020F00
		private void Clipper_Load(object sender, EventArgs e)
		{
			//this.textBox1.Text = Settings.Default.btc;
			//this.textBox2.Text = Settings.Default.eth;
			//this.textBox3.Text = Settings.Default.usdt;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00022D4C File Offset: 0x00020F4C
		private void button1_Click(object sender, EventArgs e)
		{
			if (!(string.IsNullOrWhiteSpace(this.textBox1.Text) | string.IsNullOrWhiteSpace(this.textBox2.Text)))
			{
				//Settings.Default.btc = this.textBox1.Text;
				//Settings.Default.eth = this.textBox2.Text;
				//Settings.Default.usdt = this.textBox3.Text;
				//Settings.Default.Save();
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
