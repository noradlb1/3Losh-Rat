using System;
using System.Collections.Generic;

namespace Server.Helper
{
	// Token: 0x02000049 RID: 73
	public class AsyncTask
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x000039D6 File Offset: 0x00001BD6
		public AsyncTask(byte[] _msgPack, string _id)
		{
			this.msgPack = _msgPack;
			this.id = _id;
			this.doneClient = new List<string>();
		}

		// Token: 0x040001B0 RID: 432
		public byte[] msgPack;

		// Token: 0x040001B1 RID: 433
		public string id;

		// Token: 0x040001B2 RID: 434
		public List<string> doneClient;
	}
}
