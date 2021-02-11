using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000045 RID: 69
[TypeIdentifier]
[Guid("CFF8AC46-A22B-46FE-AF29-232A96A00952")]
[CompilerGenerated]
[ComImport]
public interface GInterface7
{
	// Token: 0x06000484 RID: 1156
	[DispId(1)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_0();

	// Token: 0x06000485 RID: 1157
	[DispId(2)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_1();

	// Token: 0x06000486 RID: 1158
	[DispId(3)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_2([MarshalAs(UnmanagedType.Interface)] [In] GInterface8 ginterface8_0);

	// Token: 0x06000487 RID: 1159
	[DispId(4)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string string_0);

	// Token: 0x06000488 RID: 1160
	[DispId(5)]
	[MethodImpl(MethodImplOptions.InternalCall)]
	void imethod_4([MarshalAs(UnmanagedType.Interface)] [In] GInterface15 ginterface15_0);
}
