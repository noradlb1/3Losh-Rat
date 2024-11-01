namespace Server.Forms
{
	// Token: 0x02000099 RID: 153
	public partial class Proxy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000454 RID: 1108 RVA: 0x0000457B File Offset: 0x0000277B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00034F54 File Offset: 0x00033154
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.Proxy));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(47, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(242, 20);
			this.textBox1.TabIndex = 18;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(29, 13);
			this.label1.TabIndex = 19;
			this.label1.Text = "Host";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(27, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Port";
			this.button1.Location = new global::System.Drawing.Point(47, 73);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(242, 32);
			this.button1.TabIndex = 22;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.numericUpDown1.Location = new global::System.Drawing.Point(47, 47);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 65534;
			//numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			//numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(93, 20);
			this.numericUpDown1.TabIndex = 23;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 8090;
			//numericUpDown3.Value = new decimal(array3);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(310, 116);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			////base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Proxy";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BackProxy";
			base.Load += new global::System.EventHandler(this.Proxy_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003AE RID: 942
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003AF RID: 943
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040003B2 RID: 946
		public global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040003B3 RID: 947
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
