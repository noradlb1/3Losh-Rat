namespace Server.Forms
{
	// Token: 0x0200008C RID: 140
	public partial class FormFTP : global::System.Windows.Forms.Form
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00004077 File Offset: 0x00002277
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0002F7E8 File Offset: 0x0002D9E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFTP));
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(53, 125);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(285, 32);
			this.button1.TabIndex = 23;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(18, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Host";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(18, 76);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(29, 13);
			this.label2.TabIndex = 25;
			this.label2.Text = "Pass";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(20, 101);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(27, 13);
			this.label3.TabIndex = 26;
			this.label3.Text = "Port";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(18, 50);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(29, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "User";
			this.textBox1.Location = new global::System.Drawing.Point(53, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(285, 20);
			this.textBox1.TabIndex = 28;
			this.textBox2.Location = new global::System.Drawing.Point(53, 47);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(285, 20);
			this.textBox2.TabIndex = 29;
			this.textBox3.Location = new global::System.Drawing.Point(53, 73);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(285, 20);
			this.textBox3.TabIndex = 30;
			this.numericUpDown1.Location = new global::System.Drawing.Point(53, 99);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 32;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(350, 169);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormFTP";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ftp Settings";
			base.Load += new global::System.EventHandler(this.FormFTP_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000316 RID: 790
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400031B RID: 795
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400031D RID: 797
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400031E RID: 798
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400031F RID: 799
		private global::System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
