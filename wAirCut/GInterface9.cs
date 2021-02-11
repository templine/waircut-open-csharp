using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000047 RID: 71
[Guid("D95318F7-B1D4-46F6-8932-038A886A7722")]
[CompilerGenerated]
[InterfaceType(1)]
[TypeIdentifier]
[ComImport]
public interface GInterface9
{
	// Token: 0x0600048A RID: 1162
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnJswSupplicantEvent([In] GEnum17 @event, [In] int evtData, [MarshalAs(UnmanagedType.BStr)] [In] string evtString);
}
