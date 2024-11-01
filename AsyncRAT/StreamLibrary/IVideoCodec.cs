using System;
using System.Drawing;
using System.IO;
using StreamLibrary.src;

namespace StreamLibrary
{
	// Token: 0x02000005 RID: 5
	public abstract class IVideoCodec
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000019 RID: 25
		// (remove) Token: 0x0600001A RID: 26
		public abstract event IVideoCodec.VideoCodeProgress onVideoStreamCoding;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600001B RID: 27
		// (remove) Token: 0x0600001C RID: 28
		public abstract event IVideoCodec.VideoDecodeProgress onVideoStreamDecoding;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600001D RID: 29
		// (remove) Token: 0x0600001E RID: 30
		public abstract event IVideoCodec.VideoDebugScanningDelegate onCodeDebugScan;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600001F RID: 31
		// (remove) Token: 0x06000020 RID: 32
		public abstract event IVideoCodec.VideoDebugScanningDelegate onDecodeDebugScan;

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000021 RID: 33
		// (set) Token: 0x06000022 RID: 34
		public abstract ulong CachedSize { get; internal set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000022E5 File Offset: 0x000004E5
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000022ED File Offset: 0x000004ED
		public int ImageQuality { get; set; }

		// Token: 0x06000025 RID: 37 RVA: 0x000022F6 File Offset: 0x000004F6
		public IVideoCodec(int ImageQuality = 100)
		{
			this.jpgCompression = new JpgCompression(ImageQuality);
			this.ImageQuality = ImageQuality;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000026 RID: 38
		public abstract int BufferCount { get; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000027 RID: 39
		public abstract CodecOption CodecOptions { get; }

		// Token: 0x06000028 RID: 40
		public abstract void CodeImage(Bitmap bitmap, Stream outStream);

		// Token: 0x06000029 RID: 41
		public abstract Bitmap DecodeData(Stream inStream);

		// Token: 0x0400000B RID: 11
		protected JpgCompression jpgCompression;

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x0600002B RID: 43
		public delegate void VideoCodeProgress(Stream stream, Rectangle[] MotionChanges);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600002F RID: 47
		public delegate void VideoDecodeProgress(Bitmap bitmap);

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x06000033 RID: 51
		public delegate void VideoDebugScanningDelegate(Rectangle ScanArea);
	}
}
