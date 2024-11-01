namespace Server.Forms
{
	// Token: 0x0200008B RID: 139
	public partial class FormFileSearcher : global::System.Windows.Forms.Form
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000404A File Offset: 0x0000224A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0002F24C File Offset: 0x0002D44C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormFileSearcher));
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtExtnsions = new global::System.Windows.Forms.TextBox();
			this.btnOk = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(8, 25);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Extensions:";
			this.txtExtnsions.Location = new global::System.Drawing.Point(11, 46);
			this.txtExtnsions.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtExtnsions.Name = "txtExtnsions";
			this.txtExtnsions.Size = new global::System.Drawing.Size(366, 20);
			this.txtExtnsions.TabIndex = 1;
			this.txtExtnsions.Text = ".txt .pdf .doc";
			this.btnOk.Location = new global::System.Drawing.Point(285, 84);
			this.btnOk.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(91, 32);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(8, 78);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(87, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Max upload size:";
			this.numericUpDown1.Location = new global::System.Drawing.Point(11, 99);
			this.numericUpDown1.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 200;
			//numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			//numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(66, 20);
			this.numericUpDown1.TabIndex = 5;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 5;
			//numericUpDown3.Value = new decimal(array3);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f);
			this.label3.Location = new global::System.Drawing.Point(86, 101);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(23, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "MB";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(383, 139);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.txtExtnsions);
			base.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(2, 2, 2, 2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormFileSearcher";
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "File Searcher - Search and upload a file by it extension";
			base.Load += new global::System.EventHandler(this.FormFileSearcher_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400030F RID: 783
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.Button btnOk;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000314 RID: 788
		public global::System.Windows.Forms.TextBox txtExtnsions;

		// Token: 0x04000315 RID: 789
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
