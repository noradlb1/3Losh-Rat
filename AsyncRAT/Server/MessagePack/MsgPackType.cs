using System;

namespace Server.MessagePack
{
	// Token: 0x02000046 RID: 70
	public enum MsgPackType
	{
		// Token: 0x040001A4 RID: 420
		Unknown,
		// Token: 0x040001A5 RID: 421
		Null,
		// Token: 0x040001A6 RID: 422
		Map,
		// Token: 0x040001A7 RID: 423
		Array,
		// Token: 0x040001A8 RID: 424
		String,
		// Token: 0x040001A9 RID: 425
		Integer,
		// Token: 0x040001AA RID: 426
		UInt64,
		// Token: 0x040001AB RID: 427
		Boolean,
		// Token: 0x040001AC RID: 428
		Float,
		// Token: 0x040001AD RID: 429
		Single,
		// Token: 0x040001AE RID: 430
		DateTime,
		// Token: 0x040001AF RID: 431
		Binary
	}
}
