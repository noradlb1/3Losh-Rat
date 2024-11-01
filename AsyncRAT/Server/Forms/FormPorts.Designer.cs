namespace Server.Forms
{
	// Token: 0x02000090 RID: 144
	public partial class FormPorts : global::System.Windows.Forms.Form
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x000041EE File Offset: 0x000023EE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00031018 File Offset: 0x0002F218
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormPorts));
			this.button1 = new global::System.Windows.Forms.Button();
			this.textPorts = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnAdd = new global::System.Windows.Forms.Button();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.button1.Location = new global::System.Drawing.Point(14, 365);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(558, 52);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start AsyncRAT";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.textPorts.Location = new global::System.Drawing.Point(88, 145);
			this.textPorts.Name = "textPorts";
			this.textPorts.Size = new global::System.Drawing.Size(391, 26);
			this.textPorts.TabIndex = 0;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(18, 148);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(46, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ports";
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.listBox1);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textPorts);
			this.groupBox1.Location = new global::System.Drawing.Point(14, 11);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(558, 348);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new global::System.Drawing.Point(88, 180);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(391, 144);
			this.listBox1.TabIndex = 4;
			this.btnDelete.Location = new global::System.Drawing.Point(488, 178);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(57, 31);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "-";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.BtnDelete_Click);
			this.btnAdd.Location = new global::System.Drawing.Point(488, 143);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(57, 31);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new global::System.EventHandler(this.BtnAdd_Click);
			this.textBox1.Location = new global::System.Drawing.Point(88, 40);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(391, 26);
			this.textBox1.TabIndex = 15;
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(28, 91);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(30, 20);
			this.label4.TabIndex = 16;
			this.label4.Text = "bin";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(38, 40);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(26, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "ID";
			this.textBox2.Location = new global::System.Drawing.Point(88, 88);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(391, 26);
			this.textBox2.TabIndex = 13;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(584, 431);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.groupBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormPorts";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ports | AsyncRAT";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.PortsFrm_FormClosed);
			base.Load += new global::System.EventHandler(this.PortsFrm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400033F RID: 831
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000341 RID: 833
		public global::System.Windows.Forms.TextBox textPorts;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000345 RID: 837
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.Button btnAdd;

		// Token: 0x04000347 RID: 839
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000349 RID: 841
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Label label3;
	}
}
