namespace Server.Forms
{
	// Token: 0x02000097 RID: 151
	public partial class FormTorrent : global::System.Windows.Forms.Form
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00004479 File Offset: 0x00002679
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000341B8 File Offset: 0x000323B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormTorrent));
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(129, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select torrent file";
			this.textBox1.Location = new global::System.Drawing.Point(13, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(460, 26);
			this.textBox1.TabIndex = 1;
			this.button1.Location = new global::System.Drawing.Point(518, 50);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(84, 38);
			this.button1.TabIndex = 2;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.button2.Location = new global::System.Drawing.Point(12, 98);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(84, 38);
			this.button2.TabIndex = 3;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.button3.Location = new global::System.Drawing.Point(141, 98);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(84, 38);
			this.button3.TabIndex = 4;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(614, 148);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormTorrent";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Seed Torrent";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000394 RID: 916
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000398 RID: 920
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Forms.Button button3;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.ToolTip toolTip1;
	}
}
