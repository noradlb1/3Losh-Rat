using System;
using System.Collections;
using System.Collections.Generic;

namespace Server.MessagePack
{
	// Token: 0x02000041 RID: 65
	public class MsgPackEnum : IEnumerator
	{
		// Token: 0x0600026C RID: 620 RVA: 0x000036D8 File Offset: 0x000018D8
		public MsgPackEnum(List<MsgPack> obj)
		{
			this.children = obj;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000036EE File Offset: 0x000018EE
		object IEnumerator.Current
		{
			get
			{
				return this.children[this.position];
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00003701 File Offset: 0x00001901
		bool IEnumerator.MoveNext()
		{
			this.position++;
			return this.position < this.children.Count;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00003724 File Offset: 0x00001924
		void IEnumerator.Reset()
		{
			this.position = -1;
		}

		// Token: 0x0400018A RID: 394
		private List<MsgPack> children;

		// Token: 0x0400018B RID: 395
		private int position = -1;
	}
}
