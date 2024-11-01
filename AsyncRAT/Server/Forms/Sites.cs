using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200009A RID: 154
	public partial class Sites : Form
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x0000459A File Offset: 0x0000279A
		public Sites()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000045A8 File Offset: 0x000027A8
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000352DC File Offset: 0x000334DC
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

		// Token: 0x06000459 RID: 1113 RVA: 0x00035330 File Offset: 0x00033530
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Add Site", "SiteLogger", "", -1, -1);
			if (text.Length != 0 && !this.listBox1.Items.Contains(text))
			{
				this.listBox1.Items.Add(text);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00035384 File Offset: 0x00033584
		private void Sites_Load(object sender, EventArgs e)
		{
			//try
			//{
			//	foreach (string item in Settings.Default.sites.Split(new string[]
			//	{
			//		","
			//	}, StringSplitOptions.None))
			//	{
			//		this.listBox1.Items.Add(item);
			//	}
			//}
			//catch (Exception)
			//{
			//}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000353EC File Offset: 0x000335EC
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listBox1.Items.Count > 0)
				{
					string text = "";
					foreach (object obj in this.listBox1.Items)
					{
						text = text + ((obj != null) ? obj.ToString() : null) + ",";
					}
					text = text.Trim().Substring(0, text.Length - 1);
					//Settings.Default.sites = text;
					//Settings.Default.Save();
					base.Close();
				}
			}
			catch (Exception)
			{
			}
		}
	}
}
