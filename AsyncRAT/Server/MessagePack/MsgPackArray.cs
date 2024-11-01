using System;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000042 RID: 66
	public class MsgPackArray
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000372D File Offset: 0x0000192D
		public MsgPackArray(MsgPack msgpackObj, List<MsgPack> listObj)
		{
			this.owner = msgpackObj;
			this.children = listObj;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00003743 File Offset: 0x00001943
		public MsgPack Add()
		{
			return this.owner.AddArrayChild();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00003750 File Offset: 0x00001950
		public MsgPack Add(string value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.AsString = value;
			return msgPack;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00003764 File Offset: 0x00001964
		public MsgPack Add(long value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsInteger(value);
			return msgPack;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00003778 File Offset: 0x00001978
		public MsgPack Add(double value)
		{
			MsgPack msgPack = this.owner.AddArrayChild();
			msgPack.SetAsFloat(value);
			return msgPack;
		}

		// Token: 0x170000B5 RID: 181
		public MsgPack this[int index]
		{
			get
			{
				return this.children[index];
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0000379A File Offset: 0x0000199A
		public int Length
		{
			get
			{
				return this.children.Count;
			}
		}

		// Token: 0x0400018C RID: 396
		private List<MsgPack> children;

		// Token: 0x0400018D RID: 397
		private MsgPack owner;
	}
}
