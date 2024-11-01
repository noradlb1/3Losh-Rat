namespace Server.Forms
{
	// Token: 0x02000098 RID: 152
	public partial class FormWebcam : global::System.Windows.Forms.Form
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00004506 File Offset: 0x00002706
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00034860 File Offset: 0x00032A60
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormWebcam));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timerSave = new global::System.Windows.Forms.Timer(this.components);
			this.labelWait = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(799, 41);
			this.panel1.TabIndex = 3;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(71, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(272, 28);
			this.comboBox1.TabIndex = 6;
			//this.btnSave.BackgroundImage = global::Server.Properties.Resources.save_image;
			this.btnSave.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.Enabled = false;
			this.btnSave.Location = new global::System.Drawing.Point(568, 4);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(32, 32);
			this.btnSave.TabIndex = 5;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.BtnSave_Click);
			//this.button1.BackgroundImage = global::Server.Properties.Resources.play_button;
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Enabled = false;
			this.button1.Location = new global::System.Drawing.Point(12, 4);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 32);
			this.button1.TabIndex = 0;
			this.button1.Tag = "play";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new global::System.Drawing.Point(0, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(799, 532);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.timerSave.Interval = 1000;
			this.timerSave.Tick += new global::System.EventHandler(this.TimerSave_Tick);
			this.labelWait.AutoSize = true;
			this.labelWait.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelWait.Location = new global::System.Drawing.Point(319, 273);
			this.labelWait.Name = "labelWait";
			this.labelWait.Size = new global::System.Drawing.Size(78, 29);
			this.labelWait.TabIndex = 6;
			this.labelWait.Text = "Wait...";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(374, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(78, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "QUALITY";
			this.numericUpDown1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Enabled = false;
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 10;
			//numericUpDown.Increment = new decimal(array);
			this.numericUpDown1.Location = new global::System.Drawing.Point(458, 8);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 20;
			//numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(82, 26);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.UpDownAlign = global::System.Windows.Forms.LeftRightAlignment.Left;
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 50;
			//numericUpDown3.Value = new decimal(array3);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(799, 573);
			base.Controls.Add(this.labelWait);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormWebcam";
			this.Text = "FormWebcam";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormWebcam_FormClosed);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003A3 RID: 931
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040003A5 RID: 933
		public global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040003A6 RID: 934
		public global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040003A7 RID: 935
		public global::System.Windows.Forms.Button btnSave;

		// Token: 0x040003A8 RID: 936
		public global::System.Windows.Forms.Button button1;

		// Token: 0x040003A9 RID: 937
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x040003AA RID: 938
		private global::System.Windows.Forms.Timer timerSave;

		// Token: 0x040003AB RID: 939
		public global::System.Windows.Forms.Label labelWait;

		// Token: 0x040003AC RID: 940
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003AD RID: 941
		public global::System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}
