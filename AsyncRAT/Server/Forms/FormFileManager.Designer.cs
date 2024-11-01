namespace Server.Forms
{
	// Token: 0x02000089 RID: 137
	public partial class FormFileManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060003BF RID: 959 RVA: 0x00003FD9 File Offset: 0x000021D9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewGroup listViewGroup = new global::System.Windows.Forms.ListViewGroup("Folders", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.Windows.Forms.ListViewGroup listViewGroup2 = new global::System.Windows.Forms.ListViewGroup("File", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileManager));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.backToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rEFRESHToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.gOTOToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.xxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dESKTOPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aPPDATAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.userProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.startupToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.walletsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.metaMaskToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.firefoxToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.edgeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.braveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.phantomToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.edgeToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binanceExToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.edgeToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exodusExToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bitKeepToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.coinbaseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.roninToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cryptoExToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem7 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bitPayExToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.chromeToolStripMenuItem9 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.edgeToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.braveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ergoWalletToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ledgerLiveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.atomicToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exodusToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.electrumToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.coinomiToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binanceToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bitcoinCoreToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ftpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uploadToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.downloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.uPLOADToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.eXECUTEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dELETEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sevenZiplStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.installToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.zipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.unzipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.createFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.openClientFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.operaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.operaGXToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.AllowColumnReorder = true;
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2
			});
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			listViewGroup.Header = "Folders";
			listViewGroup.Name = "Folders";
			listViewGroup2.Header = "File";
			listViewGroup2.Name = "File";
			this.listView1.Groups.AddRange(new global::System.Windows.Forms.ListViewGroup[]
			{
				listViewGroup,
				listViewGroup2
			});
			this.listView1.HideSelection = false;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new global::System.Drawing.Point(0, 0);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(705, 348);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Tile;
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backToolStripMenuItem,
				this.rEFRESHToolStripMenuItem,
				this.gOTOToolStripMenuItem,
				this.walletsToolStripMenuItem,
				this.toolStripSeparator1,
				this.ftpToolStripMenuItem,
				this.downloadToolStripMenuItem,
				this.uPLOADToolStripMenuItem,
				this.eXECUTEToolStripMenuItem,
				this.renameToolStripMenuItem,
				this.copyToolStripMenuItem,
				this.cutToolStripMenuItem1,
				this.pasteToolStripMenuItem,
				this.dELETEToolStripMenuItem,
				this.toolStripSeparator4,
				this.sevenZiplStripMenuItem1,
				this.toolStripSeparator5,
				this.createFolderToolStripMenuItem,
				this.toolStripSeparator3,
				this.openClientFolderToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(181, 402);
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new global::System.EventHandler(this.backToolStripMenuItem_Click);
			this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
			this.rEFRESHToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.rEFRESHToolStripMenuItem.Text = "Refresh";
			this.rEFRESHToolStripMenuItem.Click += new global::System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
			this.gOTOToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cToolStripMenuItem,
				this.xxToolStripMenuItem,
				this.dESKTOPToolStripMenuItem,
				this.aPPDATAToolStripMenuItem,
				this.userProfileToolStripMenuItem,
				this.startupToolStripMenuItem,
				this.toolStripSeparator2
			});
			this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
			this.gOTOToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.gOTOToolStripMenuItem.Text = "GoTo";
			this.cToolStripMenuItem.Name = "cToolStripMenuItem";
			this.cToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.cToolStripMenuItem.Text = "C:\\";
			this.cToolStripMenuItem.Click += new global::System.EventHandler(this.cToolStripMenuItem_Click);
			this.xxToolStripMenuItem.Name = "xxToolStripMenuItem";
			this.xxToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.xxToolStripMenuItem.Text = "Public";
			this.xxToolStripMenuItem.Click += new global::System.EventHandler(this.xxToolStripMenuItem_Click);
			this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
			this.dESKTOPToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.dESKTOPToolStripMenuItem.Text = "Desktop";
			this.dESKTOPToolStripMenuItem.Click += new global::System.EventHandler(this.DESKTOPToolStripMenuItem_Click);
			this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
			this.aPPDATAToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.aPPDATAToolStripMenuItem.Text = "AppData";
			this.aPPDATAToolStripMenuItem.Click += new global::System.EventHandler(this.APPDATAToolStripMenuItem_Click);
			this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
			this.userProfileToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.userProfileToolStripMenuItem.Text = "User Profile";
			this.userProfileToolStripMenuItem.Click += new global::System.EventHandler(this.UserProfileToolStripMenuItem_Click);
			this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
			this.startupToolStripMenuItem.Size = new global::System.Drawing.Size(134, 22);
			this.startupToolStripMenuItem.Text = "Startup";
			this.startupToolStripMenuItem.Click += new global::System.EventHandler(this.startupToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(131, 6);
			this.walletsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.metaMaskToolStripMenuItem,
				this.phantomToolStripMenuItem,
				this.binanceExToolStripMenuItem,
				this.exodusExToolStripMenuItem,
				this.bitKeepToolStripMenuItem,
				this.coinbaseToolStripMenuItem,
				this.roninToolStripMenuItem,
				this.cryptoExToolStripMenuItem,
				this.bitPayExToolStripMenuItem,
				this.toolStripMenuItem_0,
				this.toolStripSeparator7,
				this.ergoWalletToolStripMenuItem,
				this.ledgerLiveToolStripMenuItem,
				this.atomicToolStripMenuItem,
				this.exodusToolStripMenuItem,
				this.electrumToolStripMenuItem,
				this.coinomiToolStripMenuItem,
				this.binanceToolStripMenuItem,
				this.bitcoinCoreToolStripMenuItem
			});
			this.walletsToolStripMenuItem.Name = "walletsToolStripMenuItem";
			this.walletsToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.walletsToolStripMenuItem.Text = "Wallets";
			this.metaMaskToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.firefoxToolStripMenuItem,
				this.chromeToolStripMenuItem,
				this.edgeToolStripMenuItem,
				this.braveToolStripMenuItem,
				this.operaToolStripMenuItem,
				this.operaGXToolStripMenuItem
			});
			this.metaMaskToolStripMenuItem.Name = "metaMaskToolStripMenuItem";
			this.metaMaskToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.metaMaskToolStripMenuItem.Text = "MetaMaskEx";
			this.metaMaskToolStripMenuItem.Click += new global::System.EventHandler(this.metaMaskToolStripMenuItem_Click);
			this.firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
			this.firefoxToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.firefoxToolStripMenuItem.Text = "Firefox";
			this.firefoxToolStripMenuItem.Click += new global::System.EventHandler(this.firefoxToolStripMenuItem_Click);
			this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
			this.chromeToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.chromeToolStripMenuItem.Text = "Chrome";
			this.chromeToolStripMenuItem.Click += new global::System.EventHandler(this.chromeToolStripMenuItem_Click);
			this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
			this.edgeToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.edgeToolStripMenuItem.Text = "Edge";
			this.edgeToolStripMenuItem.Click += new global::System.EventHandler(this.edgeToolStripMenuItem_Click);
			this.braveToolStripMenuItem.Name = "braveToolStripMenuItem";
			this.braveToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.braveToolStripMenuItem.Text = "Brave";
			this.braveToolStripMenuItem.Click += new global::System.EventHandler(this.braveToolStripMenuItem_Click);
			this.phantomToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem1,
				this.edgeToolStripMenuItem1
			});
			this.phantomToolStripMenuItem.Name = "phantomToolStripMenuItem";
			this.phantomToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.phantomToolStripMenuItem.Text = "PhantomEx";
			this.chromeToolStripMenuItem1.Name = "chromeToolStripMenuItem1";
			this.chromeToolStripMenuItem1.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem1.Text = "Chrome";
			this.chromeToolStripMenuItem1.Click += new global::System.EventHandler(this.chromeToolStripMenuItem1_Click);
			this.edgeToolStripMenuItem1.Name = "edgeToolStripMenuItem1";
			this.edgeToolStripMenuItem1.Size = new global::System.Drawing.Size(117, 22);
			this.edgeToolStripMenuItem1.Text = "Brave";
			this.edgeToolStripMenuItem1.Click += new global::System.EventHandler(this.edgeToolStripMenuItem1_Click);
			this.binanceExToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem2,
				this.edgeToolStripMenuItem2
			});
			this.binanceExToolStripMenuItem.Name = "binanceExToolStripMenuItem";
			this.binanceExToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.binanceExToolStripMenuItem.Text = "BinanceEx";
			this.chromeToolStripMenuItem2.Name = "chromeToolStripMenuItem2";
			this.chromeToolStripMenuItem2.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem2.Text = "Chrome";
			this.chromeToolStripMenuItem2.Click += new global::System.EventHandler(this.chromeToolStripMenuItem2_Click);
			this.edgeToolStripMenuItem2.Name = "edgeToolStripMenuItem2";
			this.edgeToolStripMenuItem2.Size = new global::System.Drawing.Size(117, 22);
			this.edgeToolStripMenuItem2.Text = "Edge";
			this.edgeToolStripMenuItem2.Click += new global::System.EventHandler(this.edgeToolStripMenuItem2_Click);
			this.exodusExToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem3
			});
			this.exodusExToolStripMenuItem.Name = "exodusExToolStripMenuItem";
			this.exodusExToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.exodusExToolStripMenuItem.Text = "TronLinkEx";
			this.chromeToolStripMenuItem3.Name = "chromeToolStripMenuItem3";
			this.chromeToolStripMenuItem3.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem3.Text = "Chrome";
			this.chromeToolStripMenuItem3.Click += new global::System.EventHandler(this.chromeToolStripMenuItem3_Click);
			this.bitKeepToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem4
			});
			this.bitKeepToolStripMenuItem.Name = "bitKeepToolStripMenuItem";
			this.bitKeepToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bitKeepToolStripMenuItem.Text = "BitKeepEx";
			this.chromeToolStripMenuItem4.Name = "chromeToolStripMenuItem4";
			this.chromeToolStripMenuItem4.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem4.Text = "Chrome";
			this.chromeToolStripMenuItem4.Click += new global::System.EventHandler(this.chromeToolStripMenuItem4_Click);
			this.coinbaseToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem5
			});
			this.coinbaseToolStripMenuItem.Name = "coinbaseToolStripMenuItem";
			this.coinbaseToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.coinbaseToolStripMenuItem.Text = "CoinbaseEx";
			this.chromeToolStripMenuItem5.Name = "chromeToolStripMenuItem5";
			this.chromeToolStripMenuItem5.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem5.Text = "Chrome";
			this.chromeToolStripMenuItem5.Click += new global::System.EventHandler(this.chromeToolStripMenuItem5_Click);
			this.roninToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem6
			});
			this.roninToolStripMenuItem.Name = "roninToolStripMenuItem";
			this.roninToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.roninToolStripMenuItem.Text = "RoninEx";
			this.chromeToolStripMenuItem6.Name = "chromeToolStripMenuItem6";
			this.chromeToolStripMenuItem6.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem6.Text = "Chrome";
			this.chromeToolStripMenuItem6.Click += new global::System.EventHandler(this.chromeToolStripMenuItem6_Click);
			this.cryptoExToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem7
			});
			this.cryptoExToolStripMenuItem.Name = "cryptoExToolStripMenuItem";
			this.cryptoExToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.cryptoExToolStripMenuItem.Text = "TrustEx";
			this.chromeToolStripMenuItem7.Name = "chromeToolStripMenuItem7";
			this.chromeToolStripMenuItem7.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem7.Text = "Chrome";
			this.chromeToolStripMenuItem7.Click += new global::System.EventHandler(this.chromeToolStripMenuItem7_Click);
			this.bitPayExToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem8
			});
			this.bitPayExToolStripMenuItem.Name = "bitPayExToolStripMenuItem";
			this.bitPayExToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bitPayExToolStripMenuItem.Text = "BitPayEx";
			this.chromeToolStripMenuItem8.Name = "chromeToolStripMenuItem8";
			this.chromeToolStripMenuItem8.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem8.Text = "Chrome";
			this.chromeToolStripMenuItem8.Click += new global::System.EventHandler(this.chromeToolStripMenuItem8_Click);
			this.toolStripMenuItem_0.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.chromeToolStripMenuItem9,
				this.edgeToolStripMenuItem3,
				this.braveToolStripMenuItem1
			});
			this.toolStripMenuItem_0.Name = "f2AToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new global::System.Drawing.Size(180, 22);
			this.toolStripMenuItem_0.Text = "2FAEx";
			this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.f2AToolStripMenuItem_Click);
			this.chromeToolStripMenuItem9.Name = "chromeToolStripMenuItem9";
			this.chromeToolStripMenuItem9.Size = new global::System.Drawing.Size(117, 22);
			this.chromeToolStripMenuItem9.Text = "Chrome";
			this.chromeToolStripMenuItem9.Click += new global::System.EventHandler(this.chromeToolStripMenuItem9_Click);
			this.edgeToolStripMenuItem3.Name = "edgeToolStripMenuItem3";
			this.edgeToolStripMenuItem3.Size = new global::System.Drawing.Size(117, 22);
			this.edgeToolStripMenuItem3.Text = "Edge";
			this.edgeToolStripMenuItem3.Click += new global::System.EventHandler(this.edgeToolStripMenuItem3_Click);
			this.braveToolStripMenuItem1.Name = "braveToolStripMenuItem1";
			this.braveToolStripMenuItem1.Size = new global::System.Drawing.Size(117, 22);
			this.braveToolStripMenuItem1.Text = "Brave";
			this.braveToolStripMenuItem1.Click += new global::System.EventHandler(this.braveToolStripMenuItem1_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(177, 6);
			this.ergoWalletToolStripMenuItem.Name = "ergoWalletToolStripMenuItem";
			this.ergoWalletToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.ergoWalletToolStripMenuItem.Text = "ErgoWallet";
			this.ergoWalletToolStripMenuItem.Click += new global::System.EventHandler(this.ergoWalletToolStripMenuItem_Click);
			this.ledgerLiveToolStripMenuItem.Name = "ledgerLiveToolStripMenuItem";
			this.ledgerLiveToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.ledgerLiveToolStripMenuItem.Text = "Ledger Live";
			this.ledgerLiveToolStripMenuItem.Click += new global::System.EventHandler(this.ledgerLiveToolStripMenuItem_Click);
			this.atomicToolStripMenuItem.Name = "atomicToolStripMenuItem";
			this.atomicToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.atomicToolStripMenuItem.Text = "Atomic";
			this.atomicToolStripMenuItem.Click += new global::System.EventHandler(this.atomicToolStripMenuItem_Click);
			this.exodusToolStripMenuItem.Name = "exodusToolStripMenuItem";
			this.exodusToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.exodusToolStripMenuItem.Text = "Exodus";
			this.exodusToolStripMenuItem.Click += new global::System.EventHandler(this.exodusToolStripMenuItem_Click);
			this.electrumToolStripMenuItem.Name = "electrumToolStripMenuItem";
			this.electrumToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.electrumToolStripMenuItem.Text = "Electrum";
			this.electrumToolStripMenuItem.Click += new global::System.EventHandler(this.electrumToolStripMenuItem_Click);
			this.coinomiToolStripMenuItem.Name = "coinomiToolStripMenuItem";
			this.coinomiToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.coinomiToolStripMenuItem.Text = "Coinomi";
			this.coinomiToolStripMenuItem.Click += new global::System.EventHandler(this.coinomiToolStripMenuItem_Click);
			this.binanceToolStripMenuItem.Name = "binanceToolStripMenuItem";
			this.binanceToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.binanceToolStripMenuItem.Text = "Binance";
			this.binanceToolStripMenuItem.Click += new global::System.EventHandler(this.binanceToolStripMenuItem_Click);
			this.bitcoinCoreToolStripMenuItem.Name = "bitcoinCoreToolStripMenuItem";
			this.bitcoinCoreToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.bitcoinCoreToolStripMenuItem.Text = "Bitcoin Core";
			this.bitcoinCoreToolStripMenuItem.Click += new global::System.EventHandler(this.bitcoinCoreToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(177, 6);
			this.ftpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.uploadToolStripMenuItem1,
				this.settingsToolStripMenuItem
			});
			this.ftpToolStripMenuItem.Name = "ftpToolStripMenuItem";
			this.ftpToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.ftpToolStripMenuItem.Text = "Ftp";
			this.uploadToolStripMenuItem1.Name = "uploadToolStripMenuItem1";
			this.uploadToolStripMenuItem1.Size = new global::System.Drawing.Size(116, 22);
			this.uploadToolStripMenuItem1.Text = "Upload";
			this.uploadToolStripMenuItem1.Click += new global::System.EventHandler(this.uploadToolStripMenuItem1_Click);
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new global::System.EventHandler(this.settingsToolStripMenuItem_Click);
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.downloadToolStripMenuItem.Text = "Download";
			this.downloadToolStripMenuItem.Click += new global::System.EventHandler(this.downloadToolStripMenuItem_Click);
			this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
			this.uPLOADToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.uPLOADToolStripMenuItem.Text = "Upload";
			this.uPLOADToolStripMenuItem.Click += new global::System.EventHandler(this.uPLOADToolStripMenuItem_Click);
			this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
			this.eXECUTEToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.eXECUTEToolStripMenuItem.Text = "Execute";
			this.eXECUTEToolStripMenuItem.Click += new global::System.EventHandler(this.eXECUTEToolStripMenuItem_Click);
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new global::System.EventHandler(this.RenameToolStripMenuItem_Click);
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			this.cutToolStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.cutToolStripMenuItem1.Text = "Cut";
			this.cutToolStripMenuItem1.Click += new global::System.EventHandler(this.CutToolStripMenuItem1_Click);
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click_1);
			this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
			this.dELETEToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.dELETEToolStripMenuItem.Text = "Delete";
			this.dELETEToolStripMenuItem.Click += new global::System.EventHandler(this.dELETEToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(177, 6);
			this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.installToolStripMenuItem,
				this.toolStripSeparator6,
				this.zipToolStripMenuItem,
				this.unzipToolStripMenuItem
			});
			this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
			this.sevenZiplStripMenuItem1.Size = new global::System.Drawing.Size(180, 22);
			this.sevenZiplStripMenuItem1.Text = "7-Zip";
			this.installToolStripMenuItem.Name = "installToolStripMenuItem";
			this.installToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.installToolStripMenuItem.Text = "Hidden Installation";
			this.installToolStripMenuItem.Click += new global::System.EventHandler(this.InstallToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(171, 6);
			this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
			this.zipToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.zipToolStripMenuItem.Text = "Zip";
			this.zipToolStripMenuItem.Click += new global::System.EventHandler(this.ZipToolStripMenuItem_Click);
			this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
			this.unzipToolStripMenuItem.Size = new global::System.Drawing.Size(174, 22);
			this.unzipToolStripMenuItem.Text = "Unzip";
			this.unzipToolStripMenuItem.Click += new global::System.EventHandler(this.UnzipToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(177, 6);
			this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
			this.createFolderToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.createFolderToolStripMenuItem.Text = "Create Folder";
			this.createFolderToolStripMenuItem.Click += new global::System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(177, 6);
			this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
			this.openClientFolderToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.openClientFolderToolStripMenuItem.Text = "Open Client Folder";
			this.openClientFolderToolStripMenuItem.Click += new global::System.EventHandler(this.OpenClientFolderToolStripMenuItem_Click);
			//this.imageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
			this.imageList1.Images.SetKeyName(1, "AsyncHDDFixed.png");
			this.imageList1.Images.SetKeyName(2, "AsyncUSB.png");
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel2,
				this.toolStripStatusLabel3
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 368);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.statusStrip1.Size = new global::System.Drawing.Size(705, 21);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 16);
			this.toolStripStatusLabel2.Text = "..";
			this.toolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Red;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(13, 16);
			this.toolStripStatusLabel3.Text = "..";
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Location = new global::System.Drawing.Point(0, 348);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new global::System.Drawing.Size(705, 20);
			this.textBox1.TabIndex = 3;
			this.operaToolStripMenuItem.Name = "operaToolStripMenuItem";
			this.operaToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.operaToolStripMenuItem.Text = "Opera";
			this.operaToolStripMenuItem.Click += new global::System.EventHandler(this.operaToolStripMenuItem_Click);
			this.operaGXToolStripMenuItem.Name = "operaGXToolStripMenuItem";
			this.operaGXToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.operaGXToolStripMenuItem.Text = "OperaGX";
			this.operaGXToolStripMenuItem.Click += new global::System.EventHandler(this.operaGXToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(705, 389);
			base.Controls.Add(this.listView1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.statusStrip1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "FormFileManager";
			this.Text = "FileManager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormFileManager_FormClosed);
			base.Load += new global::System.EventHandler(this.FormFileManager_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002BB RID: 699
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002BC RID: 700
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x040002BD RID: 701
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;

		// Token: 0x040002C0 RID: 704
		public global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040002C1 RID: 705
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.ToolStripMenuItem uPLOADToolStripMenuItem;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.ToolStripMenuItem eXECUTEToolStripMenuItem;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.ToolStripMenuItem dESKTOPToolStripMenuItem;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.ToolStripMenuItem aPPDATAToolStripMenuItem;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x040002CF RID: 719
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x040002D0 RID: 720
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;

		// Token: 0x040002D5 RID: 725
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x040002D7 RID: 727
		private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;

		// Token: 0x040002D8 RID: 728
		private global::System.Windows.Forms.ToolStripMenuItem sevenZiplStripMenuItem1;

		// Token: 0x040002D9 RID: 729
		private global::System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;

		// Token: 0x040002DA RID: 730
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x040002DB RID: 731
		private global::System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x040002DE RID: 734
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x040002DF RID: 735
		private global::System.Windows.Forms.ToolStripMenuItem xxToolStripMenuItem;

		// Token: 0x040002E0 RID: 736
		private global::System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Forms.ToolStripMenuItem ftpToolStripMenuItem;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem1;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

		// Token: 0x040002E5 RID: 741
		private global::System.Windows.Forms.ToolStripMenuItem walletsToolStripMenuItem;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.ToolStripMenuItem bitcoinCoreToolStripMenuItem;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.ToolStripMenuItem exodusToolStripMenuItem;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.ToolStripMenuItem atomicToolStripMenuItem;

		// Token: 0x040002E9 RID: 745
		private global::System.Windows.Forms.ToolStripMenuItem electrumToolStripMenuItem;

		// Token: 0x040002EA RID: 746
		private global::System.Windows.Forms.ToolStripMenuItem ledgerLiveToolStripMenuItem;

		// Token: 0x040002EB RID: 747
		private global::System.Windows.Forms.ToolStripMenuItem coinomiToolStripMenuItem;

		// Token: 0x040002EC RID: 748
		private global::System.Windows.Forms.ToolStripMenuItem metaMaskToolStripMenuItem;

		// Token: 0x040002ED RID: 749
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;

		// Token: 0x040002EF RID: 751
		private global::System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.Forms.ToolStripMenuItem braveToolStripMenuItem;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Forms.ToolStripMenuItem phantomToolStripMenuItem;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem1;

		// Token: 0x040002F3 RID: 755
		private global::System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem1;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Forms.ToolStripMenuItem binanceExToolStripMenuItem;

		// Token: 0x040002F5 RID: 757
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem2;

		// Token: 0x040002F6 RID: 758
		private global::System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem2;

		// Token: 0x040002F7 RID: 759
		private global::System.Windows.Forms.ToolStripMenuItem exodusExToolStripMenuItem;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem3;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.ToolStripMenuItem bitKeepToolStripMenuItem;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem4;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.ToolStripMenuItem coinbaseToolStripMenuItem;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem5;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.ToolStripMenuItem roninToolStripMenuItem;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem6;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.ToolStripMenuItem cryptoExToolStripMenuItem;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem7;

		// Token: 0x04000301 RID: 769
		private global::System.Windows.Forms.ToolStripMenuItem bitPayExToolStripMenuItem;

		// Token: 0x04000302 RID: 770
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem8;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem9;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.ToolStripMenuItem edgeToolStripMenuItem3;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Forms.ToolStripMenuItem braveToolStripMenuItem1;

		// Token: 0x04000306 RID: 774
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000307 RID: 775
		private global::System.Windows.Forms.ToolStripMenuItem ergoWalletToolStripMenuItem;

		// Token: 0x04000308 RID: 776
		private global::System.Windows.Forms.ToolStripMenuItem binanceToolStripMenuItem;

		// Token: 0x04000309 RID: 777
		private global::System.Windows.Forms.ToolStripMenuItem firefoxToolStripMenuItem;

		// Token: 0x0400030A RID: 778
		public global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400030B RID: 779
		private global::System.Windows.Forms.ToolStripMenuItem operaToolStripMenuItem;

		// Token: 0x0400030C RID: 780
		private global::System.Windows.Forms.ToolStripMenuItem operaGXToolStripMenuItem;
	}
}
