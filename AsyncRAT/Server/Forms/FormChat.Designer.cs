namespace Server.Forms
{
	// Token: 0x02000086 RID: 134
	public partial class FormChat : global::System.Windows.Forms.Form
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00003E6D File Offset: 0x0000206D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00028B40 File Offset: 0x00026D40
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormChat));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.richTextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richTextBox1.BackColor = global::System.Drawing.SystemColors.Window;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Location = new global::System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(733, 351);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new global::System.Drawing.Point(0, 384);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(757, 26);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.ClientSize = new global::System.Drawing.Size(757, 410);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.richTextBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormChat";
			this.Text = "FormChat";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormChat_FormClosed);
			base.Load += new global::System.EventHandler(this.FormChat_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400028D RID: 653
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400028E RID: 654
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400028F RID: 655
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000290 RID: 656
		public global::System.Windows.Forms.TextBox textBox1;
	}
}
