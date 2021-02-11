using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000013 RID: 19
public class GClass5 : GInterface4
{
	// Token: 0x0600018B RID: 395 RVA: 0x00003980 File Offset: 0x00001B80
	public GClass5()
	{
		this.string_0 = "";
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600018C RID: 396 RVA: 0x00008A5C File Offset: 0x00006C5C
	// (remove) Token: 0x0600018D RID: 397 RVA: 0x00008A98 File Offset: 0x00006C98
	public event GClass5.GDelegate0 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass5.GDelegate0 gdelegate = this.gdelegate0_0;
			GClass5.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass5.GDelegate0 value2 = (GClass5.GDelegate0)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass5.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass5.GDelegate0 gdelegate = this.gdelegate0_0;
			GClass5.GDelegate0 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass5.GDelegate0 value2 = (GClass5.GDelegate0)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass5.GDelegate0>(ref this.gdelegate0_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x0600018E RID: 398 RVA: 0x00008AD0 File Offset: 0x00006CD0
	// (remove) Token: 0x0600018F RID: 399 RVA: 0x00008B0C File Offset: 0x00006D0C
	public event GClass5.GDelegate1 Event_1
	{
		[CompilerGenerated]
		add
		{
			GClass5.GDelegate1 gdelegate = this.gdelegate1_0;
			GClass5.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass5.GDelegate1 value2 = (GClass5.GDelegate1)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass5.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass5.GDelegate1 gdelegate = this.gdelegate1_0;
			GClass5.GDelegate1 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass5.GDelegate1 value2 = (GClass5.GDelegate1)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass5.GDelegate1>(ref this.gdelegate1_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x06000190 RID: 400 RVA: 0x00008B48 File Offset: 0x00006D48
	public void OnJswApiEvent(GEnum8 @event, string evtString)
	{
		if (@event != GEnum8.JswApiEvt_AdapterRemoved)
		{
			if (@event == GEnum8.JswApiEvt_AdapterAdded)
			{
				ref string ptr = ref this.string_0;
				this.string_0 = ptr + "API: Adapter added\r\n";
			}
		}
		else
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "API: Adapter removed\r\n";
		}
		GClass5.GDelegate0 gdelegate = this.gdelegate0_0;
		if (gdelegate != null)
		{
			gdelegate(@event, evtString, this.string_0);
		}
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00008BA8 File Offset: 0x00006DA8
	public void OnJswApiTraceMessage(int threadID, string message)
	{
		GClass5.GDelegate1 gdelegate = this.gdelegate1_0;
		if (gdelegate != null)
		{
			gdelegate(threadID, message);
		}
	}

	// Token: 0x04000086 RID: 134
	public string string_0;

	// Token: 0x04000087 RID: 135
	[CompilerGenerated]
	private GClass5.GDelegate0 gdelegate0_0;

	// Token: 0x04000088 RID: 136
	[CompilerGenerated]
	private GClass5.GDelegate1 gdelegate1_0;

	// Token: 0x02000014 RID: 20
	// (Invoke) Token: 0x06000195 RID: 405
	public delegate void GDelegate0(GEnum8 @event, string evtString, string message);

	// Token: 0x02000015 RID: 21
	// (Invoke) Token: 0x06000199 RID: 409
	public delegate void GDelegate1(int threadID, string _message);
}
