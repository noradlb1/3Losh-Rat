namespace Server.Forms
{
	// Token: 0x0200008E RID: 142
	public partial class FormMiner : global::System.Windows.Forms.Form
	{
		// Token: 0x060003E0 RID: 992 RVA: 0x0000413D File Offset: 0x0000233D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000303A8 File Offset: 0x0002E5A8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormMiner));
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.comboInjection = new global::System.Windows.Forms.ComboBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtPass = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnOK = new global::System.Windows.Forms.Button();
			this.txtWallet = new global::System.Windows.Forms.TextBox();
			this.txtPool = new global::System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.comboInjection);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtPass);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtWallet);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtPool);
			this.groupBox1.Location = new global::System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(840, 236);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(17, 181);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(73, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Injection:";
			this.comboInjection.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboInjection.FormattingEnabled = true;
			this.comboInjection.Items.AddRange(new object[]
			{
				"RegAsm.exe",
				"MSBuild.exe",
				"RegSvcs.exe"
			});
			this.comboInjection.Location = new global::System.Drawing.Point(154, 178);
			this.comboInjection.Name = "comboInjection";
			this.comboInjection.Size = new global::System.Drawing.Size(201, 28);
			this.comboInjection.TabIndex = 7;
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(17, 133);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(78, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Password";
			//this.txtPass.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtxmrPass", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPass.Location = new global::System.Drawing.Point(154, 130);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new global::System.Drawing.Size(663, 26);
			this.txtPass.TabIndex = 4;
			//this.txtPass.Text = global::Server.Properties.Settings.Default.txtxmrPass;
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(17, 87);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(53, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Wallet";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(17, 43);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(73, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pool:Port";
			this.btnOK.Location = new global::System.Drawing.Point(12, 274);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(840, 58);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.BtnOK_Click);
			//this.txtWallet.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtWallet", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtWallet.Location = new global::System.Drawing.Point(154, 84);
			this.txtWallet.Name = "txtWallet";
			this.txtWallet.Size = new global::System.Drawing.Size(663, 26);
			this.txtWallet.TabIndex = 2;
			//this.txtWallet.Text = global::Server.Properties.Settings.Default.txtWallet;
			//this.txtPool.DataBindings.Add(new global::System.Windows.Forms.Binding("Text", global::Server.Properties.Settings.Default, "txtPool", true, global::System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtPool.Location = new global::System.Drawing.Point(154, 40);
			this.txtPool.Name = "txtPool";
			this.txtPool.Size = new global::System.Drawing.Size(663, 26);
			this.txtPool.TabIndex = 0;
			//this.txtPool.Text = global::Server.Properties.Settings.Default.txtPool;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(864, 357);
			base.Controls.Add(this.btnOK);
			base.Controls.Add(this.groupBox1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormMiner";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "XMR Miner | AsyncRAT";
			base.Load += new global::System.EventHandler(this.FormMiner_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400032C RID: 812
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400032E RID: 814
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400032F RID: 815
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000330 RID: 816
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000331 RID: 817
		public global::System.Windows.Forms.TextBox txtPool;

		// Token: 0x04000332 RID: 818
		public global::System.Windows.Forms.TextBox txtWallet;

		// Token: 0x04000333 RID: 819
		public global::System.Windows.Forms.TextBox txtPass;

		// Token: 0x04000334 RID: 820
		public global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000335 RID: 821
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000336 RID: 822
		public global::System.Windows.Forms.ComboBox comboInjection;
	}
}
