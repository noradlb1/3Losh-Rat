using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Server.Forms
{
	// Token: 0x02000083 RID: 131
	public partial class FormCertificate : Form
	{
		// Token: 0x06000348 RID: 840 RVA: 0x00003DCA File Offset: 0x00001FCA
		public FormCertificate()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000282FC File Offset: 0x000264FC
		private void FormCertificate_Load(object sender, EventArgs e)
		{
			try
			{
				string text = Application.StartupPath + "\\BackupCertificate.zip";
				if (File.Exists(text))
				{
					MessageBox.Show(this, "Found a zip backup, Extracting (BackupCertificate.zip)", "Certificate backup", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ZipFile.ExtractToDirectory(text, Application.StartupPath);
					Settings.ServerCertificate = new X509Certificate2(Settings.CertificatePath);
					base.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message, "Certificate", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00028380 File Offset: 0x00026580
		private void Button1_Click(object sender, EventArgs e)
		{
			//FormCertificate.<Button1_Click>d__2 <Button1_Click>d__;
			//<Button1_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<Button1_Click>d__.<>4__this = this;
			//<Button1_Click>d__.<>1__state = -1;
			//<Button1_Click>d__.<>t__builder.Start<FormCertificate.<Button1_Click>d__2>(ref <Button1_Click>d__);
		}
	}
}
