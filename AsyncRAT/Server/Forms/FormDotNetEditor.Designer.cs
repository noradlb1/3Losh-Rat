namespace Server.Forms
{
	// Token: 0x02000088 RID: 136
	public partial class FormDotNetEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x06000373 RID: 883 RVA: 0x00003F65 File Offset: 0x00002165
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0002A170 File Offset: 0x00028370
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Server.Forms.FormDotNetEditor));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.comboHelper = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.listBoxReferences = new global::System.Windows.Forms.ListBox();
			this.menuReferences = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new global::System.Windows.Forms.Label();
			this.comboLang = new global::System.Windows.Forms.ComboBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.txtBox = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.panel1.SuspendLayout();
			this.menuReferences.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtBox).BeginInit();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.comboHelper);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.listBoxReferences);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboLang);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new global::System.Drawing.Point(914, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(215, 633);
			this.panel1.TabIndex = 0;
			this.button3.Location = new global::System.Drawing.Point(375, 6);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(95, 43);
			this.button3.TabIndex = 8;
			this.button3.Text = "Test";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.Button3_Click);
			this.button2.Location = new global::System.Drawing.Point(148, 6);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(95, 43);
			this.button2.TabIndex = 7;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.Button2_Click);
			this.button1.Location = new global::System.Drawing.Point(606, 6);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(95, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "Execute";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.Button1_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(4, 522);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Helper:";
			this.comboHelper.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHelper.FormattingEnabled = true;
			this.comboHelper.Items.AddRange(new object[]
			{
				"Download and execute",
				"Hello world"
			});
			this.comboHelper.Location = new global::System.Drawing.Point(8, 554);
			this.comboHelper.Name = "comboHelper";
			this.comboHelper.Size = new global::System.Drawing.Size(195, 28);
			this.comboHelper.TabIndex = 4;
			this.comboHelper.SelectedIndexChanged += new global::System.EventHandler(this.ComboHelper_SelectedIndexChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(4, 96);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(96, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "References:";
			this.listBoxReferences.ContextMenuStrip = this.menuReferences;
			this.listBoxReferences.FormattingEnabled = true;
			this.listBoxReferences.ItemHeight = 20;
			this.listBoxReferences.Items.AddRange(new object[]
			{
				"System.dll",
				"System.Windows.Forms.dll",
				"Microsoft.VisualBasic.dll",
				"System.Management.dll",
				"System.Drawing.dll"
			});
			this.listBoxReferences.Location = new global::System.Drawing.Point(8, 128);
			this.listBoxReferences.Name = "listBoxReferences";
			this.listBoxReferences.Size = new global::System.Drawing.Size(195, 364);
			this.listBoxReferences.TabIndex = 2;
			this.menuReferences.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.menuReferences.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addToolStripMenuItem,
				this.removeToolStripMenuItem
			});
			this.menuReferences.Name = "menuReferences";
			this.menuReferences.ShowImageMargin = false;
			this.menuReferences.Size = new global::System.Drawing.Size(125, 68);
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new global::System.Drawing.Size(124, 32);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new global::System.EventHandler(this.AddToolStripMenuItem_Click);
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new global::System.Drawing.Size(124, 32);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new global::System.EventHandler(this.RemoveToolStripMenuItem_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(4, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(85, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Language:";
			this.comboLang.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLang.FormattingEnabled = true;
			this.comboLang.Items.AddRange(new object[]
			{
				"C#",
				"VB.NET"
			});
			this.comboLang.Location = new global::System.Drawing.Point(8, 40);
			this.comboLang.Name = "comboLang";
			this.comboLang.Size = new global::System.Drawing.Size(195, 28);
			this.comboLang.TabIndex = 0;
			this.comboLang.SelectedIndexChanged += new global::System.EventHandler(this.ComboLang_SelectedIndexChanged);
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.Controls.Add(this.txtBox);
			this.panel2.Location = new global::System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(884, 554);
			this.panel2.TabIndex = 1;
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.button3);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new global::System.Drawing.Point(0, 572);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(914, 61);
			this.panel3.TabIndex = 1;
			this.txtBox.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.txtBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
			this.txtBox.AutoScrollMinSize = new global::System.Drawing.Size(599, 264);
			this.txtBox.BackBrush = null;
			this.txtBox.BracketsHighlightStrategy = global::FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.txtBox.CharHeight = 22;
			this.txtBox.CharWidth = 12;
			this.txtBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtBox.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.txtBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtBox.IsReplaceMode = false;
			this.txtBox.Language = global::FastColoredTextBoxNS.Language.CSharp;
			this.txtBox.LeftBracket = '(';
			this.txtBox.LeftBracket2 = '{';
			this.txtBox.Location = new global::System.Drawing.Point(0, 0);
			this.txtBox.Name = "txtBox";
			this.txtBox.Paddings = new global::System.Windows.Forms.Padding(0);
			this.txtBox.RightBracket = ')';
			this.txtBox.RightBracket2 = '}';
			this.txtBox.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			//this.txtBox.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("txtBox.ServiceColors");
			this.txtBox.Size = new global::System.Drawing.Size(884, 554);
			this.txtBox.TabIndex = 2;
			//this.txtBox.Text = componentResourceManager.GetString("txtBox.Text");
			this.txtBox.Zoom = 100;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1129, 633);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormDotNetEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Dot Net Editor";
			base.Load += new global::System.EventHandler(this.FormDotNetEditor_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuReferences.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.txtBox).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002A7 RID: 679
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.ComboBox comboHelper;

		// Token: 0x040002AB RID: 683
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002AC RID: 684
		private global::System.Windows.Forms.ListBox listBoxReferences;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.ComboBox comboLang;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x040002B0 RID: 688
		private global::System.Windows.Forms.ContextMenuStrip menuReferences;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040002B6 RID: 694
		private global::FastColoredTextBoxNS.FastColoredTextBox txtBox;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.Panel panel3;
	}
}
