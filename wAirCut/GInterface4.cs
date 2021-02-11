using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000042 RID: 66
[Guid("0AC1AF15-ED13-4E43-966C-9D838C6F6B97")]
[TypeIdentifier]
[InterfaceType(1)]
[CompilerGenerated]
[ComImport]
public interface GInterface4
{
	// Token: 0x0600047B RID: 1147
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnJswApiTraceMessage([In] int threadID, [MarshalAs(UnmanagedType.BStr)] [In] string message);

	// Token: 0x0600047C RID: 1148
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnJswApiEvent([In] GEnum8 @event, [MarshalAs(UnmanagedType.BStr)] [In] string evtString);
}
