namespace Server.Forms
{
	// Token: 0x0200007C RID: 124
	public partial class AVR : global::System.Windows.Forms.Form
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00003C30 File Offset: 0x00001E30
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000228E8 File Offset: 0x00020AE8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.AVR));
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new global::System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.listBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Items.AddRange(new object[]
			{
				"C:\\Program Files\\Avast Software",
				"C:\\Program Files\\AVG",
				"C:\\Program Files\\ESET",
				"C:\\Program Files\\Common Files\\McAfee",
				"C:\\ProgramData\\Microsoft\\Windows Defender",
				"C:\\Program Files\\Windows Defender",
				"C:\\Program Files (x86)\\Windows Defender",
				"C:\\Program Files\\Bitdefender\\Endpoint Security",
				"C:\\ProgramData\\Bitdefender\\Endpoint Security"
			});
			this.listBox1.Location = new global::System.Drawing.Point(0, 0);
			this.listBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(710, 387);
			this.listBox1.TabIndex = 0;
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem2,
				this.removeToolStripMenuItem,
				this.clearToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(149, 100);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(148, 32);
			this.toolStripMenuItem2.Text = "Add";
			this.toolStripMenuItem2.Click += new global::System.EventHandler(this.toolStripMenuItem2_Click);
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new global::System.Drawing.Size(148, 32);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new global::System.EventHandler(this.removeToolStripMenuItem_Click);
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new global::System.Drawing.Size(148, 32);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new global::System.EventHandler(this.clearToolStripMenuItem_Click);
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new global::System.Drawing.Point(0, 387);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(710, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "Run";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(710, 435);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "AVR";
			this.Text = "AV Removal";
			base.Load += new global::System.EventHandler(this.AVR_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000219 RID: 537
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x0400021E RID: 542
		public global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
	}
}
