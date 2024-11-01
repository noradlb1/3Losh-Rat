using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using StreamLibrary.src;

namespace StreamLibrary
{
	// Token: 0x02000004 RID: 4
	public abstract class IUnsafeCodec
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000009 RID: 9
		// (set) Token: 0x0600000A RID: 10
		public abstract ulong CachedSize { get; internal set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002291 File Offset: 0x00000491
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002299 File Offset: 0x00000499
		//private protected object ImageProcessLock { protected get; private set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000022A2 File Offset: 0x000004A2
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000022AA File Offset: 0x000004AA
		public int ImageQuality
		{
			get
			{
				return this._imageQuality;
			}
			set
			{
				this._imageQuality = value;
				this.jpgCompression = new JpgCompression(value);
				this.lzwCompression = new LzwCompression(value);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000F RID: 15
		// (remove) Token: 0x06000010 RID: 16
		public abstract event IVideoCodec.VideoDebugScanningDelegate onCodeDebugScan;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000011 RID: 17
		// (remove) Token: 0x06000012 RID: 18
		public abstract event IVideoCodec.VideoDebugScanningDelegate onDecodeDebugScan;

		// Token: 0x06000013 RID: 19 RVA: 0x000022CB File Offset: 0x000004CB
		public IUnsafeCodec(int ImageQuality = 100)
		{
			this.ImageQuality = ImageQuality;
			//this.ImageProcessLock = new object();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20
		public abstract int BufferCount { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21
		public abstract CodecOption CodecOptions { get; }

		// Token: 0x06000016 RID: 22
		public abstract void CodeImage(IntPtr Scan0, Rectangle ScanArea, Size ImageSize, PixelFormat Format, Stream outStream);

		// Token: 0x06000017 RID: 23
		public abstract Bitmap DecodeData(Stream inStream);

		// Token: 0x06000018 RID: 24
		public abstract Bitmap DecodeData(IntPtr CodecBuffer, uint Length);

		// Token: 0x04000007 RID: 7
		protected JpgCompression jpgCompression;

		// Token: 0x04000008 RID: 8
		protected LzwCompression lzwCompression;

		// Token: 0x0400000A RID: 10
		private int _imageQuality;
	}
}
