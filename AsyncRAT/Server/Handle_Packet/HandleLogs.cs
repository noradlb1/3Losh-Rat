using System;
using System.Drawing;
using System.Windows.Forms;

namespace Server.Handle_Packet
{
	// Token: 0x02000069 RID: 105
	public class HandleLogs
	{
		// Token: 0x060002F7 RID: 759 RVA: 0x000203E0 File Offset: 0x0001E5E0
		public void Addmsg(string Msg, Color color)
		{
			try
			{
				ListViewItem LV = new ListViewItem();
				LV.Text = DateTime.Now.ToLongTimeString();
				LV.SubItems.Add(Msg);
				LV.ForeColor = color;
				if (Program.form1.InvokeRequired)
				{
					Program.form1.Invoke(new MethodInvoker(delegate()
					{
						object lockListviewLogs2 = Settings.LockListviewLogs;
						lock (lockListviewLogs2)
						{
							Program.form1.listView2.Items.Insert(0, LV);
						}
					}));
				}
				else
				{
					object lockListviewLogs = Settings.LockListviewLogs;
					lock (lockListviewLogs)
					{
						Program.form1.listView2.Items.Insert(0, LV);
					}
				}
			}
			catch
			{
			}
		}
	}
}
