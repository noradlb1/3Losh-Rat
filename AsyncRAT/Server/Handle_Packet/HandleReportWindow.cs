using System;
using System.Drawing;
using Server.Connection;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x0200006F RID: 111
	public class HandleReportWindow
	{
		// Token: 0x06000303 RID: 771 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		public HandleReportWindow(Clients client, string title)
		{
			new HandleLogs().Addmsg(string.Concat(new string[]
			{
				"Client ",
				client.Ip,
				" Opened [",
				title,
				"]"
			}), Color.Blue);
			if (Settings.Default.Notification)
			{
				Program.form1.notifyIcon1.BalloonTipText = string.Concat(new string[]
				{
					"Client ",
					client.Ip,
					" Opened [",
					title,
					"]"
				});
				Program.form1.notifyIcon1.ShowBalloonTip(100);
			}
		}
	}
}
