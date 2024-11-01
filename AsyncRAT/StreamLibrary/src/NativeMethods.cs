using System;
using System.Runtime.InteropServices;

namespace StreamLibrary.src
{
	// Token: 0x0200000C RID: 12
	public class NativeMethods
	{
		// Token: 0x0600004C RID: 76
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcmp(byte* ptr1, byte* ptr2, uint count);

		// Token: 0x0600004D RID: 77
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int memcmp(IntPtr ptr1, IntPtr ptr2, uint count);

		// Token: 0x0600004E RID: 78
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int memcpy(IntPtr dst, IntPtr src, uint count);

		// Token: 0x0600004F RID: 79
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int memcpy(void* dst, void* src, uint count);
	}
}
