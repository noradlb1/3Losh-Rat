using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace StreamLibrary.src
{
	// Token: 0x0200000B RID: 11
	public class LzwCompression
	{
		// Token: 0x06000048 RID: 72 RVA: 0x0000CADC File Offset: 0x0000ACDC
		public LzwCompression(int Quality)
		{
			this.parameter = new EncoderParameter(Encoder.Quality, (long)Quality);
			this.encoderInfo = this.GetEncoderInfo("image/jpeg");
			this.encoderParams = new EncoderParameters(2);
			this.encoderParams.Param[0] = this.parameter;
			this.encoderParams.Param[1] = new EncoderParameter(Encoder.Compression, 2L);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000CB54 File Offset: 0x0000AD54
		public byte[] Compress(Bitmap bmp, byte[] AdditionInfo = null)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				if (AdditionInfo != null)
				{
					memoryStream.Write(AdditionInfo, 0, AdditionInfo.Length);
				}
				bmp.Save(memoryStream, this.encoderInfo, this.encoderParams);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000236D File Offset: 0x0000056D
		public void Compress(Bitmap bmp, Stream stream, byte[] AdditionInfo = null)
		{
			if (AdditionInfo != null)
			{
				stream.Write(AdditionInfo, 0, AdditionInfo.Length);
			}
			bmp.Save(stream, this.encoderInfo, this.encoderParams);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		private ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			for (int i = 0; i < imageEncoders.Length; i++)
			{
				if (imageEncoders[i].MimeType == mimeType)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x0400001A RID: 26
		private EncoderParameter parameter;

		// Token: 0x0400001B RID: 27
		private ImageCodecInfo encoderInfo;

		// Token: 0x0400001C RID: 28
		private EncoderParameters encoderParams;
	}
}
