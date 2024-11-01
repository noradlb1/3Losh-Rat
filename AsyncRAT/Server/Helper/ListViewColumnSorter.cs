using System;
using System.Collections;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000052 RID: 82
	public class ListViewColumnSorter : IComparer
	{
		// Token: 0x060002C0 RID: 704 RVA: 0x00003A19 File Offset: 0x00001C19
		public ListViewColumnSorter()
		{
			this.ColumnToSort = 0;
			this.OrderOfSort = SortOrder.None;
			this.ObjectCompare = new CaseInsensitiveComparer();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001DC44 File Offset: 0x0001BE44
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = this.ObjectCompare.Compare(listViewItem.SubItems[this.ColumnToSort].Text, listViewItem2.SubItems[this.ColumnToSort].Text);
			if (this.OrderOfSort == SortOrder.Ascending)
			{
				return num;
			}
			if (this.OrderOfSort == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00003A43 File Offset: 0x00001C43
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00003A3A File Offset: 0x00001C3A
		public int SortColumn
		{
			get
			{
				return this.ColumnToSort;
			}
			set
			{
				this.ColumnToSort = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00003A54 File Offset: 0x00001C54
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00003A4B File Offset: 0x00001C4B
		public SortOrder Order
		{
			get
			{
				return this.OrderOfSort;
			}
			set
			{
				this.OrderOfSort = value;
			}
		}

		// Token: 0x040001D4 RID: 468
		private int ColumnToSort;

		// Token: 0x040001D5 RID: 469
		private SortOrder OrderOfSort;

		// Token: 0x040001D6 RID: 470
		private CaseInsensitiveComparer ObjectCompare;
	}
}
