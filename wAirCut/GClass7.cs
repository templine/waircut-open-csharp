using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000018 RID: 24
public class GClass7 : GInterface8
{
	// Token: 0x14000004 RID: 4
	// (add) Token: 0x060001A3 RID: 419 RVA: 0x00008D9C File Offset: 0x00006F9C
	// (remove) Token: 0x060001A4 RID: 420 RVA: 0x00008DD8 File Offset: 0x00006FD8
	public event GClass7.GDelegate3 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass7.GDelegate3 gdelegate = this.gdelegate3_0;
			GClass7.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass7.GDelegate3 value2 = (GClass7.GDelegate3)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass7.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass7.GDelegate3 gdelegate = this.gdelegate3_0;
			GClass7.GDelegate3 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass7.GDelegate3 value2 = (GClass7.GDelegate3)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass7.GDelegate3>(ref this.gdelegate3_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x060001A5 RID: 421 RVA: 0x00008E10 File Offset: 0x00007010
	public void OnJswEngineEvent(GEnum14 @event, int evtData, string evtString)
	{
		GClass7.GDelegate3 gdelegate = this.gdelegate3_0;
		if (gdelegate != null)
		{
			gdelegate(@event, evtData, evtString);
		}
	}

	// Token: 0x0400008B RID: 139
	[CompilerGenerated]
	private GClass7.GDelegate3 gdelegate3_0;

	// Token: 0x02000019 RID: 25
	// (Invoke) Token: 0x060001A9 RID: 425
	public delegate void GDelegate3(GEnum14 @event, int evtData, string evtString);
}
