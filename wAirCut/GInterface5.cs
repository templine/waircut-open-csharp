using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000043 RID: 67
[CompilerGenerated]
[TypeIdentifier]
[Guid("D3CBDBF0-067B-4EA8-8E3A-E42D2831EB14")]
[ComImport]
public interface GInterface5
{
	// Token: 0x0600047D RID: 1149
	[DispId(1)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object imethod_0([In] GEnum9 genum9_0);

	// Token: 0x0600047E RID: 1150
	void _VtblGap1_1();

	// Token: 0x0600047F RID: 1151
	[DispId(3)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	int imethod_1();

	// Token: 0x06000480 RID: 1152
	void _VtblGap2_3();

	// Token: 0x06000481 RID: 1153
	[DispId(7)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string imethod_2();
}
