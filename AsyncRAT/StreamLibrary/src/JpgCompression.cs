using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StreamLibrary.src
{
	// Token: 0x0200000A RID: 10
	public class JpgCompression
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		public JpgCompression(int Quality)
		{
			this.parameter = new EncoderParameter(Encoder.Quality, (long)Quality);
			this.encoderInfo = this.GetEncoderInfo("image/jpeg");
			this.encoderParams = new EncoderParameters(2);
			this.encoderParams.Param[0] = this.parameter;
			this.encoderParams.Param[1] = new EncoderParameter(Encoder.Compression, 2L);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000CA54 File Offset: 0x0000AC54
		public byte[] Compress(Bitmap bmp)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bmp.Save(memoryStream, this.encoderInfo, this.encoderParams);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002357 File Offset: 0x00000557
		public void Compress(Bitmap bmp, ref Stream TargetStream)
		{
			bmp.Save(TargetStream, this.encoderInfo, this.encoderParams);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		private ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = imageEncoders.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (imageEncoders[i].MimeType == mimeType)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x04000017 RID: 23
		private EncoderParameter parameter;

		// Token: 0x04000018 RID: 24
		private ImageCodecInfo encoderInfo;

		// Token: 0x04000019 RID: 25
		private EncoderParameters encoderParams;
	}
}
