using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x0200003F RID: 63
[TypeIdentifier]
[CompilerGenerated]
[Guid("D5B00EF7-40B1-434A-8199-BAF41DA46731")]
[ComImport]
public interface GInterface1
{
	// Token: 0x0600046E RID: 1134
	void _VtblGap1_1();

	// Token: 0x170001BA RID: 442
	// (get) Token: 0x0600046F RID: 1135
	[DispId(2)]
	string String_0 { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

	// Token: 0x06000470 RID: 1136
	void _VtblGap2_1();

	// Token: 0x170001BB RID: 443
	// (get) Token: 0x06000471 RID: 1137
	[DispId(4)]
	GEnum13 GEnum13_0 { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x06000472 RID: 1138
	[DispId(5)]
	object Object_0 { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Struct)] get; }
}
