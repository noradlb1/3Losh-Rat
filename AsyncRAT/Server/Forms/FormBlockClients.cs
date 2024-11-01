using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Server.Properties;

namespace Server.Forms
{
	// Token: 0x0200007F RID: 127
	public partial class FormBlockClients : Form
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00003CA9 File Offset: 0x00001EA9
		public FormBlockClients()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x000233F0 File Offset: 0x000215F0
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				this.listBlocked.Items.Add(this.txtBlock.Text);
				this.txtBlock.Clear();
			}
			catch
			{
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0002343C File Offset: 0x0002163C
		private void BtnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = this.listBlocked.SelectedIndices.Count - 1; i >= 0; i--)
				{
					this.listBlocked.Items.RemoveAt(this.listBlocked.SelectedIndices[i]);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0002349C File Offset: 0x0002169C
		private void FormBlockClients_Load(object sender, EventArgs e)
		{
			try
			{
				this.listBlocked.Items.Clear();
				//if (!string.IsNullOrWhiteSpace(Settings.Default.txtBlocked))
				//{
				//	foreach (string text in Settings.Default.txtBlocked.Split(new char[]
				//	{
				//		','
				//	}))
				//	{
				//		if (!string.IsNullOrWhiteSpace(text))
				//		{
				//			this.listBlocked.Items.Add(text);
				//		}
				//	}
				//}
			}
			catch
			{
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00023528 File Offset: 0x00021728
		private void FormBlockClients_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				List<string> blocked = Settings.Blocked;
				lock (blocked)
				{
					Settings.Blocked.Clear();
					List<string> list = new List<string>();
					foreach (object obj in this.listBlocked.Items)
					{
						string item = (string)obj;
						list.Add(item);
						Settings.Blocked.Add(item);
					}
					//Settings.Default.txtBlocked = string.Join(",", list);
					//Settings.Default.Save();
				}
			}
			catch
			{
			}
		}
	}
}
