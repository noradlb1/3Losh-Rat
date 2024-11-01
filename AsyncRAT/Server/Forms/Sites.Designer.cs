namespace Server.Forms
{
	// Token: 0x0200009A RID: 154
	public partial class Sites : global::System.Windows.Forms.Form
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x000045BA File Offset: 0x000027BA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x000354B4 File Offset: 0x000336B4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.Sites));
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem2,
				this.removeToolStripMenuItem,
				this.clearToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(118, 70);
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new global::System.Drawing.Size(180, 22);
			this.toolStripMenuItem2.Text = "Add";
			this.toolStripMenuItem2.Click += new global::System.EventHandler(this.toolStripMenuItem2_Click);
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new global::System.EventHandler(this.removeToolStripMenuItem_Click);
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new global::System.Drawing.Size(180, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new global::System.EventHandler(this.clearToolStripMenuItem_Click);
			this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.listBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(438, 280);
			this.listBox1.TabIndex = 2;
			this.button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.button1.Location = new global::System.Drawing.Point(0, 280);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(438, 31);
			this.button1.TabIndex = 3;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(438, 311);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.button1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Sites";
			this.Text = "SiteLogger | Settings";
			base.Load += new global::System.EventHandler(this.Sites_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040003B4 RID: 948
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;

		// Token: 0x040003B9 RID: 953
		public global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x040003BA RID: 954
		private global::System.Windows.Forms.Button button1;
	}
}
