using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200008C RID: 140
	public partial class FormFTP : Form
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00004069 File Offset: 0x00002269
		public FormFTP()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0002F700 File Offset: 0x0002D900
		private void FormFTP_Load(object sender, EventArgs e)
		{
			//this.textBox1.Text = Settings.Default.usdt;
			//this.textBox2.Text = Settings.Default.ftpuser;
			//this.textBox3.Text = Settings.Default.ftppass;
			//this.numericUpDown1.Value = Convert.ToInt32(Settings.Default.ftpport);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0002F76C File Offset: 0x0002D96C
		private void button1_Click(object sender, EventArgs e)
		{
			//Settings.Default.usdt = this.textBox1.Text;
			//Settings.Default.ftpuser = this.textBox2.Text;
			//Settings.Default.ftppass = this.textBox3.Text;
			//Settings.Default.ftpport = this.numericUpDown1.Value.ToString();
			//Settings.Default.Save();
			base.Close();
		}
	}
}
