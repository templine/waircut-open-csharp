using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000016 RID: 22
public class GClass6 : GInterface9
{
	// Token: 0x0600019A RID: 410 RVA: 0x00003993 File Offset: 0x00001B93
	public GClass6()
	{
		this.string_0 = "";
	}

	// Token: 0x14000003 RID: 3
	// (add) Token: 0x0600019B RID: 411 RVA: 0x00008BC8 File Offset: 0x00006DC8
	// (remove) Token: 0x0600019C RID: 412 RVA: 0x00008C00 File Offset: 0x00006E00
	public event GClass6.GDelegate2 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass6.GDelegate2 gdelegate = this.gdelegate2_0;
			GClass6.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass6.GDelegate2 value2 = (GClass6.GDelegate2)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass6.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass6.GDelegate2 gdelegate = this.gdelegate2_0;
			GClass6.GDelegate2 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass6.GDelegate2 value2 = (GClass6.GDelegate2)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass6.GDelegate2>(ref this.gdelegate2_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x0600019D RID: 413 RVA: 0x00008C3C File Offset: 0x00006E3C
	public void OnJswSupplicantEvent(GEnum17 @event, int evtData, string evtString)
	{
		switch (@event)
		{
		case GEnum17.JswSuppEvt_None:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: None\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ReceivedCredentials:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Received credential\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ProtocolSuccess:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Protocol success\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ProtocolFailure:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Protocol failure\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ProtocolFailurePIN:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Protocol failure PIN\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ProtocolFailureTimeout:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: timeout\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ReceivedMessage:
		{
			GEnum16 genum = (GEnum16)evtData;
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Received Message: " + genum.ToString() + "\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_SentMessage:
		{
			GEnum16 genum2 = (GEnum16)evtData;
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Sent Message: " + genum2.ToString() + "\r\n";
			break;
		}
		case GEnum17.JswSuppEvt_ProtocolWillSucceed:
		{
			ref string ptr = ref this.string_0;
			this.string_0 = ptr + "Supplicant: Protocol will succeed\r\n";
			break;
		}
		}
		GClass6.GDelegate2 gdelegate = this.gdelegate2_0;
		if (gdelegate != null)
		{
			gdelegate(@event, evtData, evtString, this.string_0);
		}
	}

	// Token: 0x04000089 RID: 137
	public string string_0;

	// Token: 0x0400008A RID: 138
	[CompilerGenerated]
	private GClass6.GDelegate2 gdelegate2_0;

	// Token: 0x02000017 RID: 23
	// (Invoke) Token: 0x060001A1 RID: 417
	public delegate void GDelegate2(GEnum17 @event, int evtData, string evtString, string message);
}
