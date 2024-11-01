namespace Server.Forms
{
	// Token: 0x02000095 RID: 149
	public partial class FormDownloadFile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x000043BC File Offset: 0x000025BC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000338A0 File Offset: 0x00031AA0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormDownloadFile));
			this.label1 = new global::System.Windows.Forms.Label();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.labelsize = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelfile = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(12, 90);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(75, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Downlad:";
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			this.labelsize.AutoSize = true;
			this.labelsize.Location = new global::System.Drawing.Point(103, 90);
			this.labelsize.Name = "labelsize";
			this.labelsize.Size = new global::System.Drawing.Size(17, 20);
			this.labelsize.TabIndex = 0;
			this.labelsize.Text = "..";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(12, 39);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(38, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "File:";
			this.labelfile.AutoSize = true;
			this.labelfile.Location = new global::System.Drawing.Point(103, 39);
			this.labelfile.Name = "labelfile";
			this.labelfile.Size = new global::System.Drawing.Size(17, 20);
			this.labelfile.TabIndex = 0;
			this.labelfile.Text = "..";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(496, 152);
			base.Controls.Add(this.labelfile);
			base.Controls.Add(this.labelsize);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormDownloadFile";
			this.Text = "SocketDownload";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.SocketDownload_FormClosed);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000387 RID: 903
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000388 RID: 904
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000389 RID: 905
		public global::System.Windows.Forms.Label labelsize;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400038B RID: 907
		public global::System.Windows.Forms.Label labelfile;

		// Token: 0x0400038C RID: 908
		public global::System.Windows.Forms.Label label1;
	}
}
