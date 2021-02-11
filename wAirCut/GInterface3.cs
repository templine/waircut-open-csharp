using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000041 RID: 65
[Guid("6C2216B4-6018-42B9-866B-2F795BD61B66")]
[CompilerGenerated]
[TypeIdentifier]
[ComImport]
public interface GInterface3
{
	// Token: 0x06000474 RID: 1140
	void _VtblGap1_1();

	// Token: 0x06000475 RID: 1141
	[DispId(2)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_0();

	// Token: 0x06000476 RID: 1142
	void _VtblGap2_3();

	// Token: 0x06000477 RID: 1143
	[DispId(7)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface13 imethod_1();

	// Token: 0x06000478 RID: 1144
	[DispId(8)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface11 imethod_2([MarshalAs(UnmanagedType.Interface)] [In] GInterface12 ginterface12_0);

	// Token: 0x06000479 RID: 1145
	void _VtblGap3_2();

	// Token: 0x0600047A RID: 1146
	[DispId(11)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	GInterface7 imethod_3([In] GEnum15 genum15_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface11 ginterface11_0, [MarshalAs(UnmanagedType.Interface)] [In] GInterface10 ginterface10_0);
}
