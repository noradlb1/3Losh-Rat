using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x02000099 RID: 153
	public partial class Proxy : Form
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x00004537 File Offset: 0x00002737
		public Proxy()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00004545 File Offset: 0x00002745
		private void Proxy_Load(object sender, EventArgs e)
		{
			//this.textBox1.Text = Settings.Default.proxyhost;
			//this.numericUpDown1.Value = Convert.ToInt32(Settings.Default.proxyport);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00034ED8 File Offset: 0x000330D8
		private void button1_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.textBox1.Text) && this.numericUpDown1.Value > 0m)
			{
				//Settings.Default.proxyhost = this.textBox1.Text;
				//Settings.Default.proxyport = this.numericUpDown1.Value.ToString();
				//Settings.Default.Save();
				base.DialogResult = DialogResult.OK;
			}
		}
	}
}
