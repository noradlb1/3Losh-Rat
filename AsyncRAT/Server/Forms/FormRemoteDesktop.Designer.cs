namespace Server.Forms
{
	// Token: 0x02000094 RID: 148
	public partial class FormRemoteDesktop : global::System.Windows.Forms.Form
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x0000435B File Offset: 0x0000255B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000328E0 File Offset: 0x00030AE0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormRemoteDesktop));
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.btnKeyboard = new global::System.Windows.Forms.Button();
			this.btnMouse = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.button1 = new global::System.Windows.Forms.Button();
			this.timerSave = new global::System.Windows.Forms.Timer(this.components);
			this.labelWait = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 31);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(613, 329);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
			this.pictureBox1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
			this.pictureBox1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
			this.timer1.Interval = 2000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.btnKeyboard);
			this.panel1.Controls.Add(this.btnMouse);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.numericUpDown2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(613, 25);
			this.panel1.TabIndex = 1;
			//this.button2.BackgroundImage = global::Server.Properties.Resources.Hnet_com_image__7_;
			this.button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new global::System.Drawing.Point(580, 4);
			this.button2.Margin = new global::System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(21, 21);
			this.button2.TabIndex = 12;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label7.AutoSize = true;
			this.label7.Location = new global::System.Drawing.Point(538, 8);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(37, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Folder";
			this.label6.AutoSize = true;
			this.label6.Location = new global::System.Drawing.Point(444, 8);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(53, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Keyboard";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(363, 8);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(38, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Mouse";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(280, 8);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(46, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Capture";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 8);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(31, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Start";
			//this.btnKeyboard.BackgroundImage = global::Server.Properties.Resources.keyboard;
			this.btnKeyboard.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnKeyboard.Location = new global::System.Drawing.Point(502, 4);
			this.btnKeyboard.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnKeyboard.Name = "btnKeyboard";
			this.btnKeyboard.Size = new global::System.Drawing.Size(21, 21);
			this.btnKeyboard.TabIndex = 6;
			this.btnKeyboard.UseVisualStyleBackColor = true;
			this.btnKeyboard.Click += new global::System.EventHandler(this.btnKeyboard_Click);
			//this.btnMouse.BackgroundImage = global::Server.Properties.Resources.mouse;
			this.btnMouse.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnMouse.Location = new global::System.Drawing.Point(403, 4);
			this.btnMouse.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnMouse.Name = "btnMouse";
			this.btnMouse.Size = new global::System.Drawing.Size(21, 21);
			this.btnMouse.TabIndex = 3;
			this.btnMouse.UseVisualStyleBackColor = true;
			this.btnMouse.Click += new global::System.EventHandler(this.Button3_Click);
			//this.btnSave.BackgroundImage = global::Server.Properties.Resources.save_image;
			this.btnSave.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.Location = new global::System.Drawing.Point(332, 3);
			this.btnSave.Margin = new global::System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(21, 21);
			this.btnSave.TabIndex = 5;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.BtnSave_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(188, 8);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(40, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Screen";
			this.numericUpDown2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown2.Enabled = false;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown2;
			int[] array = new int[4];
			array[0] = 10;
			//numericUpDown.Increment = new decimal(array);
			this.numericUpDown2.Location = new global::System.Drawing.Point(233, 3);
			this.numericUpDown2.Margin = new global::System.Windows.Forms.Padding(2);
			this.numericUpDown2.Maximum = new decimal(new int[4]);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new global::System.Drawing.Size(42, 20);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown2.UpDownAlign = global::System.Windows.Forms.LeftRightAlignment.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(78, 8);
			this.label1.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Quality";
			this.numericUpDown1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Enabled = false;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 10;
			numericUpDown2.Increment = new decimal(array2);
			this.numericUpDown1.Location = new global::System.Drawing.Point(129, 3);
			this.numericUpDown1.Margin = new global::System.Windows.Forms.Padding(2);
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 20;
			//numericUpDown3.Minimum = new decimal(array3);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(55, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.UpDownAlign = global::System.Windows.Forms.LeftRightAlignment.Left;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.numericUpDown1;
			int[] array4 = new int[4];
			array4[0] = 30;
			//numericUpDown4.Value = new decimal(array4);
			//this.button1.BackgroundImage = global::Server.Properties.Resources.stop__1_;
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new global::System.Drawing.Point(46, 2);
			this.button1.Margin = new global::System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(21, 21);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.timerSave.Interval = 1500;
			this.timerSave.Tick += new global::System.EventHandler(this.TimerSave_Tick);
			this.labelWait.AutoSize = true;
			this.labelWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.labelWait.Location = new global::System.Drawing.Point(273, 163);
			this.labelWait.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelWait.Name = "labelWait";
			this.labelWait.Size = new global::System.Drawing.Size(53, 20);
			this.labelWait.TabIndex = 3;
			this.labelWait.Text = "Wait...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(613, 360);
			base.Controls.Add(this.labelWait);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.pictureBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Margin = new global::System.Windows.Forms.Padding(2);
			this.MinimumSize = new global::System.Drawing.Size(442, 300);
			base.Name = "FormRemoteDesktop";
			this.Text = "Remote Desktop";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormRemoteDesktop_FormClosed);
			base.Load += new global::System.EventHandler(this.FormRemoteDesktop_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyDown);
			base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.FormRemoteDesktop_KeyUp);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400036B RID: 875
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400036C RID: 876
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400036D RID: 877
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400036E RID: 878
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400036F RID: 879
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000370 RID: 880
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000371 RID: 881
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;

		// Token: 0x04000372 RID: 882
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000373 RID: 883
		public global::System.Windows.Forms.NumericUpDown numericUpDown2;

		// Token: 0x04000374 RID: 884
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000375 RID: 885
		private global::System.Windows.Forms.Timer timerSave;

		// Token: 0x04000376 RID: 886
		private global::System.Windows.Forms.Button btnMouse;

		// Token: 0x04000377 RID: 887
		public global::System.Windows.Forms.Label labelWait;

		// Token: 0x04000378 RID: 888
		private global::System.Windows.Forms.Button btnKeyboard;

		// Token: 0x04000379 RID: 889
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400037A RID: 890
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400037B RID: 891
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400037C RID: 892
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400037D RID: 893
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400037E RID: 894
		private global::System.Windows.Forms.Label label7;
	}
}
