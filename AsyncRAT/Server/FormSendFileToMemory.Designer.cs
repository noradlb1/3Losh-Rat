namespace Server
{
	// Token: 0x02000028 RID: 40
	public partial class FormSendFileToMemory : global::System.Windows.Forms.Form
	{
		// Token: 0x06000176 RID: 374 RVA: 0x0000282F File Offset: 0x00000A2F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000198E4 File Offset: 0x00017AE4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.FormSendFileToMemory));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.button2 = new global::System.Windows.Forms.Button();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(319, 183);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Load in memory";
			this.button1.Location = new global::System.Drawing.Point(112, 87);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(201, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Browser";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 90);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(38, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "File:";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 142);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(73, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Injection:";
			this.label3.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 37);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(47, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type:";
			this.comboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[]
			{
				"aspnet_compiler.exe",
				"RegAsm.exe",
				"MSBuild.exe",
				"RegSvcs.exe",
				"vbc.exe"
			});
			this.comboBox2.Location = new global::System.Drawing.Point(112, 139);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(201, 28);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Visible = false;
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"Reflection",
				"RunPE"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(112, 34);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(201, 28);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.button2.Location = new global::System.Drawing.Point(22, 220);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(88, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 274);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new global::System.Drawing.Size(351, 32);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(24, 25);
			this.toolStripStatusLabel1.Text = "...";
			this.button3.Location = new global::System.Drawing.Point(243, 220);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(88, 30);
			this.button3.TabIndex = 3;
			this.button3.Text = "CANCEL";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(351, 306);
			base.ControlBox = false;
			base.Controls.Add(this.button3);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.groupBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormSendFileToMemory";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Load In Memory";
			base.Load += new global::System.EventHandler(this.SendFileToMemory_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400014F RID: 335
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000150 RID: 336
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000151 RID: 337
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000152 RID: 338
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000153 RID: 339
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000154 RID: 340
		public global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000155 RID: 341
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000156 RID: 342
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000157 RID: 343
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000158 RID: 344
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000159 RID: 345
		public global::System.Windows.Forms.ComboBox comboBox2;

		// Token: 0x0400015A RID: 346
		private global::System.Windows.Forms.Button button3;
	}
}
