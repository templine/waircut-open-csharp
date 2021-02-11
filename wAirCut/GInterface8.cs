using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000046 RID: 70
[Guid("F170B8DD-13A9-456B-B10B-04430660A0D2")]
[CompilerGenerated]
[InterfaceType(1)]
[TypeIdentifier]
[ComImport]
public interface GInterface8
{
	// Token: 0x06000489 RID: 1161
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnJswEngineEvent([In] GEnum14 @event, [In] int evtData, [MarshalAs(UnmanagedType.BStr)] [In] string evtString);
}
