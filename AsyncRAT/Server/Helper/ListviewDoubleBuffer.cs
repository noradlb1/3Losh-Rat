using System;
using System.Reflection;
using System.Windows.Forms;

namespace Server.Helper
{
	// Token: 0x02000053 RID: 83
	public static class ListviewDoubleBuffer
	{
		// Token: 0x060002C6 RID: 710 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static void Enable(ListView listView)
		{
			typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(listView, true, null);
		}
	}
}
