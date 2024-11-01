using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Server.Helper
{
	// Token: 0x0200004B RID: 75
	public static class IconInjector
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x000039F7 File Offset: 0x00001BF7
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconInjector.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0001D8EC File Offset: 0x0001BAEC
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconInjector.IconFile iconFile = IconInjector.IconFile.FromFile(iconFileName);
			IntPtr hUpdate = IconInjector.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(14L), new IntPtr((long)((ulong)iconGroupID)), 0, array, array.Length);
			for (int i = 0; i <= iconFile.ImageCount - 1; i++)
			{
				byte[] array2 = iconFile.ImageData(i);
				IconInjector.NativeMethods.UpdateResource(hUpdate, new IntPtr(3L), new IntPtr((long)((ulong)iconBaseID + (ulong)((long)i))), 0, array2, array2.Length);
			}
			IconInjector.NativeMethods.EndUpdateResource(hUpdate, false);
		}

		// Token: 0x0200004C RID: 76
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x060002B7 RID: 695
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x060002B8 RID: 696
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x060002B9 RID: 697
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x0200004D RID: 77
		private struct ICONDIR
		{
			// Token: 0x040001B3 RID: 435
			public ushort Reserved;

			// Token: 0x040001B4 RID: 436
			public ushort Type;

			// Token: 0x040001B5 RID: 437
			public ushort Count;
		}

		// Token: 0x0200004E RID: 78
		private struct ICONDIRENTRY
		{
			// Token: 0x040001B6 RID: 438
			public byte Width;

			// Token: 0x040001B7 RID: 439
			public byte Height;

			// Token: 0x040001B8 RID: 440
			public byte ColorCount;

			// Token: 0x040001B9 RID: 441
			public byte Reserved;

			// Token: 0x040001BA RID: 442
			public ushort Planes;

			// Token: 0x040001BB RID: 443
			public ushort BitCount;

			// Token: 0x040001BC RID: 444
			public int BytesInRes;

			// Token: 0x040001BD RID: 445
			public int ImageOffset;
		}

		// Token: 0x0200004F RID: 79
		private struct BITMAPINFOHEADER
		{
			// Token: 0x040001BE RID: 446
			public uint Size;

			// Token: 0x040001BF RID: 447
			public int Width;

			// Token: 0x040001C0 RID: 448
			public int Height;

			// Token: 0x040001C1 RID: 449
			public ushort Planes;

			// Token: 0x040001C2 RID: 450
			public ushort BitCount;

			// Token: 0x040001C3 RID: 451
			public uint Compression;

			// Token: 0x040001C4 RID: 452
			public uint SizeImage;

			// Token: 0x040001C5 RID: 453
			public int XPelsPerMeter;

			// Token: 0x040001C6 RID: 454
			public int YPelsPerMeter;

			// Token: 0x040001C7 RID: 455
			public uint ClrUsed;

			// Token: 0x040001C8 RID: 456
			public uint ClrImportant;
		}

		// Token: 0x02000050 RID: 80
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x040001C9 RID: 457
			public byte Width;

			// Token: 0x040001CA RID: 458
			public byte Height;

			// Token: 0x040001CB RID: 459
			public byte ColorCount;

			// Token: 0x040001CC RID: 460
			public byte Reserved;

			// Token: 0x040001CD RID: 461
			public ushort Planes;

			// Token: 0x040001CE RID: 462
			public ushort BitCount;

			// Token: 0x040001CF RID: 463
			public int BytesInRes;

			// Token: 0x040001D0 RID: 464
			public ushort ID;
		}

		// Token: 0x02000051 RID: 81
		private class IconFile
		{
			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060002BB RID: 699 RVA: 0x00003A02 File Offset: 0x00001C02
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

			// Token: 0x060002BC RID: 700 RVA: 0x00003A0F File Offset: 0x00001C0F
			public byte[] ImageData(int index)
			{
				return this.iconImage[index];
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0001D97C File Offset: 0x0001BB7C
			public static IconInjector.IconFile FromFile(string filename)
			{
				IconInjector.IconFile iconFile = new IconInjector.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconInjector.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconInjector.ICONDIR));
				iconFile.iconEntry = new IconInjector.ICONDIRENTRY[(int)iconFile.iconDir.Count];
				iconFile.iconImage = new byte[(int)iconFile.iconDir.Count][];
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(iconFile.iconDir);
				Type typeFromHandle = typeof(IconInjector.ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				for (int i = 0; i <= (int)(iconFile.iconDir.Count - 1); i++)
				{
					IconInjector.ICONDIRENTRY icondirentry = (IconInjector.ICONDIRENTRY)Marshal.PtrToStructure(new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), typeFromHandle);
					iconFile.iconEntry[i] = icondirentry;
					iconFile.iconImage[i] = new byte[icondirentry.BytesInRes];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[i], 0, icondirentry.BytesInRes);
					num += num2;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				byte[] array = new byte[Marshal.SizeOf(typeof(IconInjector.ICONDIR)) + Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY)) * this.ImageCount];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr<IconInjector.ICONDIR>(this.iconDir, gchandle.AddrOfPinnedObject(), false);
				int num = Marshal.SizeOf<IconInjector.ICONDIR>(this.iconDir);
				for (int i = 0; i <= this.ImageCount - 1; i++)
				{
					IconInjector.GRPICONDIRENTRY structure = default(IconInjector.GRPICONDIRENTRY);
					IconInjector.BITMAPINFOHEADER bitmapinfoheader = default(IconInjector.BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(this.ImageData(i), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconInjector.BITMAPINFOHEADER)));
					gchandle2.Free();
					structure.Width = this.iconEntry[i].Width;
					structure.Height = this.iconEntry[i].Height;
					structure.ColorCount = this.iconEntry[i].ColorCount;
					structure.Reserved = this.iconEntry[i].Reserved;
					structure.Planes = bitmapinfoheader.Planes;
					structure.BitCount = bitmapinfoheader.BitCount;
					structure.BytesInRes = this.iconEntry[i].BytesInRes;
					structure.ID = Convert.ToUInt16((long)((ulong)iconBaseID + (ulong)((long)i)));
					Marshal.StructureToPtr<IconInjector.GRPICONDIRENTRY>(structure, new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num), false);
					num += Marshal.SizeOf(typeof(IconInjector.GRPICONDIRENTRY));
				}
				gchandle.Free();
				return array;
			}

			// Token: 0x040001D1 RID: 465
			private IconInjector.ICONDIR iconDir;

			// Token: 0x040001D2 RID: 466
			private IconInjector.ICONDIRENTRY[] iconEntry;

			// Token: 0x040001D3 RID: 467
			private byte[][] iconImage;
		}
	}
}
