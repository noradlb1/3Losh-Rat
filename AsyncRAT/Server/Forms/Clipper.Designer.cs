namespace Server.Forms
{
	// Token: 0x0200007D RID: 125
	public partial class Clipper : global::System.Windows.Forms.Form
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00003C5D File Offset: 0x00001E5D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00022DCC File Offset: 0x00020FCC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.Clipper));
			this.button1 = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(67, 120);
			this.button1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(351, 39);
			this.button1.TabIndex = 23;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textBox1.Location = new global::System.Drawing.Point(69, 28);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(349, 22);
			this.textBox1.TabIndex = 24;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(26, 31);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(35, 17);
			this.label1.TabIndex = 25;
			this.label1.Text = "BTC";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(25, 63);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(36, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "ETH";
			this.textBox2.Location = new global::System.Drawing.Point(69, 60);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(349, 22);
			this.textBox2.TabIndex = 26;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(15, 93);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(46, 17);
			this.label3.TabIndex = 29;
			this.label3.Text = "USDT";
			this.textBox3.Location = new global::System.Drawing.Point(69, 90);
			this.textBox3.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(349, 22);
			this.textBox3.TabIndex = 28;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(448, 179);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Clipper";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clipper";
			base.Load += new global::System.EventHandler(this.Clipper_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000220 RID: 544
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.TextBox textBox3;
	}
}
