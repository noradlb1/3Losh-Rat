namespace Server.Forms
{
	// Token: 0x0200008F RID: 143
	public partial class FormPassword : global::System.Windows.Forms.Form
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0000416A File Offset: 0x0000236A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00030A38 File Offset: 0x0002EC38
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormPassword));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			base.SuspendLayout();
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader5,
				this.columnHeader2,
				this.columnHeader3,
				this.columnHeader4
			});
			this.listView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listView1.Location = new global::System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(800, 450);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "CLIENT ID";
			this.columnHeader1.Width = 127;
			this.columnHeader2.Text = "URL";
			this.columnHeader2.Width = 88;
			this.columnHeader3.Text = "USER";
			this.columnHeader3.Width = 90;
			this.columnHeader4.Text = "PASS";
			this.columnHeader4.Width = 101;
			this.columnHeader5.Text = "APPLICATION";
			this.columnHeader5.Width = 155;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.listView1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormPassword";
			this.Text = "FormPassword";
			base.ResumeLayout(false);
		}

		// Token: 0x04000337 RID: 823
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.ColumnHeader columnHeader4;

		// Token: 0x0400033C RID: 828
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.ColumnHeader columnHeader5;
	}
}
