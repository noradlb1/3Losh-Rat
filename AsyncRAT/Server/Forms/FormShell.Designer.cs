namespace Server.Forms
{
	// Token: 0x02000096 RID: 150
	public partial class FormShell : global::System.Windows.Forms.Form
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0000444C File Offset: 0x0000264C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00033D08 File Offset: 0x00031F08
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormShell));
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.richTextBox1.BackColor = global::System.Drawing.SystemColors.Window;
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.richTextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new global::System.Drawing.Font("Consolas", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.richTextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.richTextBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new global::System.Drawing.Size(533, 272);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.textBox1.BackColor = global::System.Drawing.SystemColors.Window;
			this.textBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.textBox1.Font = new global::System.Drawing.Font("Consolas", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.textBox1.Location = new global::System.Drawing.Point(0, 272);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(533, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.TextBox1_KeyDown);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Control;
			base.ClientSize = new global::System.Drawing.Size(533, 292);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.textBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.Name = "FormShell";
			this.Text = "Remote Shell";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormShell_FormClosed);
			base.Load += new global::System.EventHandler(this.FormShell_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400038F RID: 911
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000390 RID: 912
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000391 RID: 913
		public global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000392 RID: 914
		public global::System.Windows.Forms.Timer timer1;
	}
}
