using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Server.Properties
{
	// Token: 0x0200003F RID: 63
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00003296 File Offset: 0x00001496
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000329D File Offset: 0x0000149D
		// (set) Token: 0x06000226 RID: 550 RVA: 0x000032AF File Offset: 0x000014AF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Ports
		{
			get
			{
				return (string)this["Ports"];
			}
			set
			{
				this["Ports"] = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000032BD File Offset: 0x000014BD
		// (set) Token: 0x06000228 RID: 552 RVA: 0x000032CF File Offset: 0x000014CF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Filename
		{
			get
			{
				return (string)this["Filename"];
			}
			set
			{
				this["Filename"] = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000032DD File Offset: 0x000014DD
		// (set) Token: 0x0600022A RID: 554 RVA: 0x000032EF File Offset: 0x000014EF
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool Notification
		{
			get
			{
				return (bool)this["Notification"];
			}
			set
			{
				this["Notification"] = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00003302 File Offset: 0x00001502
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003314 File Offset: 0x00001514
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("AsyncMutex_alosh")]
		public string Mutex
		{
			get
			{
				return (string)this["Mutex"];
			}
			set
			{
				this["Mutex"] = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00003322 File Offset: 0x00001522
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00003334 File Offset: 0x00001534
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("https://pastebin.com/raw/s14cUU5G")]
		public string Pastebin
		{
			get
			{
				return (string)this["Pastebin"];
			}
			set
			{
				this["Pastebin"] = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00003342 File Offset: 0x00001542
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00003354 File Offset: 0x00001554
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string IP
		{
			get
			{
				return (string)this["IP"];
			}
			set
			{
				this["IP"] = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00003362 File Offset: 0x00001562
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00003374 File Offset: 0x00001574
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ProductName
		{
			get
			{
				return (string)this["ProductName"];
			}
			set
			{
				this["ProductName"] = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00003382 File Offset: 0x00001582
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003394 File Offset: 0x00001594
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string txtDescription
		{
			get
			{
				return (string)this["txtDescription"];
			}
			set
			{
				this["txtDescription"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000235 RID: 565 RVA: 0x000033A2 File Offset: 0x000015A2
		// (set) Token: 0x06000236 RID: 566 RVA: 0x000033B4 File Offset: 0x000015B4
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string txtCompany
		{
			get
			{
				return (string)this["txtCompany"];
			}
			set
			{
				this["txtCompany"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000237 RID: 567 RVA: 0x000033C2 File Offset: 0x000015C2
		// (set) Token: 0x06000238 RID: 568 RVA: 0x000033D4 File Offset: 0x000015D4
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string txtCopyright
		{
			get
			{
				return (string)this["txtCopyright"];
			}
			set
			{
				this["txtCopyright"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000239 RID: 569 RVA: 0x000033E2 File Offset: 0x000015E2
		// (set) Token: 0x0600023A RID: 570 RVA: 0x000033F4 File Offset: 0x000015F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtTrademarks
		{
			get
			{
				return (string)this["txtTrademarks"];
			}
			set
			{
				this["txtTrademarks"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00003402 File Offset: 0x00001602
		// (set) Token: 0x0600023C RID: 572 RVA: 0x00003414 File Offset: 0x00001614
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string txtOriginalFilename
		{
			get
			{
				return (string)this["txtOriginalFilename"];
			}
			set
			{
				this["txtOriginalFilename"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00003422 File Offset: 0x00001622
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00003434 File Offset: 0x00001634
		[DefaultSettingValue("0.0.0.0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string txtProductVersion
		{
			get
			{
				return (string)this["txtProductVersion"];
			}
			set
			{
				this["txtProductVersion"] = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00003442 File Offset: 0x00001642
		// (set) Token: 0x06000240 RID: 576 RVA: 0x00003454 File Offset: 0x00001654
		[DefaultSettingValue("0.0.0.0")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string txtFileVersion
		{
			get
			{
				return (string)this["txtFileVersion"];
			}
			set
			{
				this["txtFileVersion"] = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00003462 File Offset: 0x00001662
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003474 File Offset: 0x00001674
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string txtPool
		{
			get
			{
				return (string)this["txtPool"];
			}
			set
			{
				this["txtPool"] = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00003482 File Offset: 0x00001682
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00003494 File Offset: 0x00001694
		[UserScopedSetting]
		[DefaultSettingValue("")]
		[DebuggerNonUserCode]
		public string txtWallet
		{
			get
			{
				return (string)this["txtWallet"];
			}
			set
			{
				this["txtWallet"] = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000034A2 File Offset: 0x000016A2
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000034B4 File Offset: 0x000016B4
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string txtxmrPass
		{
			get
			{
				return (string)this["txtxmrPass"];
			}
			set
			{
				this["txtxmrPass"] = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000034C2 File Offset: 0x000016C2
		// (set) Token: 0x06000248 RID: 584 RVA: 0x000034D4 File Offset: 0x000016D4
		[UserScopedSetting]
		[DefaultSettingValue("listBlocked")]
		[DebuggerNonUserCode]
		public string txtBlocked
		{
			get
			{
				return (string)this["txtBlocked"];
			}
			set
			{
				this["txtBlocked"] = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000034E2 File Offset: 0x000016E2
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000034F4 File Offset: 0x000016F4
		[DefaultSettingValue("Default")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string Group
		{
			get
			{
				return (string)this["Group"];
			}
			set
			{
				this["Group"] = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00003502 File Offset: 0x00001702
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00003514 File Offset: 0x00001714
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("127.0.0.1")]
		public string proxyhost
		{
			get
			{
				return (string)this["proxyhost"];
			}
			set
			{
				this["proxyhost"] = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003522 File Offset: 0x00001722
		// (set) Token: 0x0600024E RID: 590 RVA: 0x00003534 File Offset: 0x00001734
		[DefaultSettingValue("8090")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string proxyport
		{
			get
			{
				return (string)this["proxyport"];
			}
			set
			{
				this["proxyport"] = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003542 File Offset: 0x00001742
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00003554 File Offset: 0x00001754
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("BTC Address")]
		public string btc
		{
			get
			{
				return (string)this["btc"];
			}
			set
			{
				this["btc"] = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003562 File Offset: 0x00001762
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00003574 File Offset: 0x00001774
		[DefaultSettingValue("ETH Address")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string eth
		{
			get
			{
				return (string)this["eth"];
			}
			set
			{
				this["eth"] = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00003582 File Offset: 0x00001782
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00003594 File Offset: 0x00001794
		[DefaultSettingValue("Trc20 Address")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string usdt
		{
			get
			{
				return (string)this["usdt"];
			}
			set
			{
				this["usdt"] = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000255 RID: 597 RVA: 0x000035A2 File Offset: 0x000017A2
		// (set) Token: 0x06000256 RID: 598 RVA: 0x000035B4 File Offset: 0x000017B4
		[DebuggerNonUserCode]
		[DefaultSettingValue("ftp-username")]
		[UserScopedSetting]
		public string ftpuser
		{
			get
			{
				return (string)this["ftpuser"];
			}
			set
			{
				this["ftpuser"] = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000035C2 File Offset: 0x000017C2
		// (set) Token: 0x06000258 RID: 600 RVA: 0x000035D4 File Offset: 0x000017D4
		[DefaultSettingValue("ftp-password")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ftppass
		{
			get
			{
				return (string)this["ftppass"];
			}
			set
			{
				this["ftppass"] = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000259 RID: 601 RVA: 0x000035E2 File Offset: 0x000017E2
		// (set) Token: 0x0600025A RID: 602 RVA: 0x000035F4 File Offset: 0x000017F4
		[DefaultSettingValue("21")]
		[DebuggerNonUserCode]
		[UserScopedSetting]
		public string ftpport
		{
			get
			{
				return (string)this["ftpport"];
			}
			set
			{
				this["ftpport"] = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00003602 File Offset: 0x00001802
		// (set) Token: 0x0600025C RID: 604 RVA: 0x00003614 File Offset: 0x00001814
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("ftp.exmple.com")]
		public string ftphost
		{
			get
			{
				return (string)this["ftphost"];
			}
			set
			{
				this["ftphost"] = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00003622 File Offset: 0x00001822
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003634 File Offset: 0x00001834
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("paypal,binance,coinbase,phantom,exodus,atomic,metamask,blockchain,bitkub,bittrex,kraken,paxful,coinmama,bitcoin,wallet,tronlink")]
		public string sites
		{
			get
			{
				return (string)this["sites"];
			}
			set
			{
				this["sites"] = value;
			}
		}

		// Token: 0x04000188 RID: 392
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
