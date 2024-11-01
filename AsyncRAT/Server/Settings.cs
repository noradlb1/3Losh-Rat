using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Server.Connection;

namespace Server
{
	// Token: 0x02000029 RID: 41
	public static class Settings
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0000284E File Offset: 0x00000A4E
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00002855 File Offset: 0x00000A55
		public static long SentValue { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0000285D File Offset: 0x00000A5D
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00002864 File Offset: 0x00000A64
		public static long ReceivedValue { get; set; }

		// Token: 0x0400015B RID: 347
		public static List<string> Blocked = new List<string>();

		// Token: 0x0400015C RID: 348
		public static object LockBlocked = new object();

		// Token: 0x0400015F RID: 351
		public static object LockReceivedSendValue = new object();

		// Token: 0x04000160 RID: 352
		public static string CertificatePath = Application.StartupPath + "\\ServerCertificate.p12";

		// Token: 0x04000161 RID: 353
		public static X509Certificate2 ServerCertificate;

		// Token: 0x04000162 RID: 354
		public static readonly string Version = "AWS | RxR  ";

		// Token: 0x04000163 RID: 355
		public static object LockListviewClients = new object();

		// Token: 0x04000164 RID: 356
		public static object LockListviewLogs = new object();

		// Token: 0x04000165 RID: 357
		public static object LockListviewThumb = new object();

		// Token: 0x04000166 RID: 358
		public static bool ReportWindow = false;

		// Token: 0x04000167 RID: 359
		public static List<Clients> ReportWindowClients = new List<Clients>();

		// Token: 0x04000168 RID: 360
		public static object LockReportWindowClients = new object();
	}
}
