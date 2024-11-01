using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using Server.Handle_Packet;

namespace Server.Connection
{
	// Token: 0x0200002C RID: 44
	internal class Listener
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000296C File Offset: 0x00000B6C
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002974 File Offset: 0x00000B74
		private Socket Server { get; set; }

		// Token: 0x0600019F RID: 415 RVA: 0x0001A840 File Offset: 0x00018A40
		public void Connect(object port)
		{
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
				this.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
				{
					SendBufferSize = 51200,
					ReceiveBufferSize = 51200
				};
				this.Server.Bind(localEP);
				this.Server.Listen(500);
				new HandleLogs().Addmsg(string.Format("Listenning {0}", port), Color.Green);
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Environment.Exit(0);
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		private void EndAccept(IAsyncResult ar)
		{
			try
			{
				new Clients(this.Server.EndAccept(ar));
			}
			catch
			{
			}
			finally
			{
				this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
			}
		}
	}
}
