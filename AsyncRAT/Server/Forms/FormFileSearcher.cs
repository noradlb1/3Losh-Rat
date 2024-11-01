using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Forms
{
	// Token: 0x0200008B RID: 139
	public partial class FormFileSearcher : Form
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x0000400A File Offset: 0x0000220A
		public FormFileSearcher()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00004018 File Offset: 0x00002218
		private void btnOk_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(this.txtExtnsions.Text) && this.numericUpDown1.Value > 0m)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002287 File Offset: 0x00000487
		private void FormFileSearcher_Load(object sender, EventArgs e)
		{
		}
	}
}
