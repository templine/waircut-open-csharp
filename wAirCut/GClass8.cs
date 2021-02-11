using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using wAirCut;
using wAirCut.My;

// Token: 0x0200001D RID: 29
public class GClass8
{
	// Token: 0x1700013B RID: 315
	// (get) Token: 0x060002A3 RID: 675 RVA: 0x00003F54 File Offset: 0x00002154
	// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000E474 File Offset: 0x0000C674
	private virtual GClass7 GClass7_0
	{
		[CompilerGenerated]
		get
		{
			return this.gclass7_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			GClass7.GDelegate3 value2 = new GClass7.GDelegate3(this.method_13);
			GClass7 gclass = this.gclass7_0;
			if (gclass != null)
			{
				gclass.Event_0 -= value2;
			}
			this.gclass7_0 = value;
			gclass = this.gclass7_0;
			if (gclass != null)
			{
				gclass.Event_0 += value2;
			}
		}
	}

	// Token: 0x14000005 RID: 5
	// (add) Token: 0x060002A5 RID: 677 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
	// (remove) Token: 0x060002A6 RID: 678 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
	public event GClass8.GDelegate6 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
			GClass8.GDelegate6 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate6 value2 = (GClass8.GDelegate6)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate6>(ref this.gdelegate6_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
			GClass8.GDelegate6 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate6 value2 = (GClass8.GDelegate6)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate6>(ref this.gdelegate6_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x14000006 RID: 6
	// (add) Token: 0x060002A7 RID: 679 RVA: 0x0000E528 File Offset: 0x0000C728
	// (remove) Token: 0x060002A8 RID: 680 RVA: 0x0000E564 File Offset: 0x0000C764
	public event GClass8.GDelegate7 Event_1
	{
		[CompilerGenerated]
		add
		{
			GClass8.GDelegate7 gdelegate = this.gdelegate7_0;
			GClass8.GDelegate7 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate7 value2 = (GClass8.GDelegate7)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate7>(ref this.gdelegate7_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass8.GDelegate7 gdelegate = this.gdelegate7_0;
			GClass8.GDelegate7 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate7 value2 = (GClass8.GDelegate7)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate7>(ref this.gdelegate7_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060002A9 RID: 681 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
	// (remove) Token: 0x060002AA RID: 682 RVA: 0x0000E5D8 File Offset: 0x0000C7D8
	public event GClass8.GDelegate8 Event_2
	{
		[CompilerGenerated]
		add
		{
			GClass8.GDelegate8 gdelegate = this.gdelegate8_0;
			GClass8.GDelegate8 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate8 value2 = (GClass8.GDelegate8)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate8>(ref this.gdelegate8_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass8.GDelegate8 gdelegate = this.gdelegate8_0;
			GClass8.GDelegate8 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass8.GDelegate8 value2 = (GClass8.GDelegate8)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass8.GDelegate8>(ref this.gdelegate8_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x060002AB RID: 683 RVA: 0x0000E610 File Offset: 0x0000C810
	// (remove) Token: 0x060002AC RID: 684 RVA: 0x0000E64C File Offset: 0x0000C84C
	private event GClass8.Delegate0 Event_3
	{
		[CompilerGenerated]
		add
		{
			GClass8.Delegate0 @delegate = this.delegate0_0;
			GClass8.Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				GClass8.Delegate0 value2 = (GClass8.Delegate0)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange<GClass8.Delegate0>(ref this.delegate0_0, value2, delegate2);
			}
			while (@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass8.Delegate0 @delegate = this.delegate0_0;
			GClass8.Delegate0 delegate2;
			do
			{
				delegate2 = @delegate;
				GClass8.Delegate0 value2 = (GClass8.Delegate0)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange<GClass8.Delegate0>(ref this.delegate0_0, value2, delegate2);
			}
			while (@delegate != delegate2);
		}
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0000E684 File Offset: 0x0000C884
	public GClass8()
	{
		this.int_0 = 0;
		this.list_0 = new List<GInterface1>();
		this.GClass7_0 = new GClass7();
		this.bool_0 = false;
		this.gclass12_0 = new GClass12("12345670", GClass12.GEnum5.Manual);
		this.string_0 = "";
		this.bool_1 = true;
		this.genum1_0 = GClass8.GEnum1.Stop;
		this.genum2_0 = GClass8.GEnum2.None;
		this.genum16_0 = GEnum16.JswMsgType_None;
		this.bool_2 = false;
		this.bool_3 = false;
		Class13.smethod_3(GClass0.String_0);
		this.method_0();
		this.method_3();
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00003F5C File Offset: 0x0000215C
	private void method_0()
	{
		this.ginterface3_0 = (GInterface14)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("77594188-FA62-45EE-A6D6-77FEBAE0AA77")));
		this.ginterface3_0.imethod_0();
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0000E718 File Offset: 0x0000C918
	private void method_1(int int_1)
	{
		this.ginterface0_0 = this.ginterface3_0.imethod_2((GInterface12)this.list_0[int_1]);
		string text = Class13.smethod_1((byte[])this.ginterface0_0.imethod_3().Object_0);
		if (Class13.bool_1)
		{
			text = Class13.smethod_13(text, "X");
		}
		GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
		if (gdelegate != null)
		{
			gdelegate(string.Format("Adapter -Start {0}", text), Color.White, true);
		}
		this.method_2();
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0000E79C File Offset: 0x0000C99C
	private void method_2()
	{
		this.ginterface7_0 = this.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkApPin, (GInterface11)this.ginterface0_0, null);
		GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
		if (gdelegate != null)
		{
			gdelegate(Class13.string_4, Color.LightGreen, false);
		}
		this.bool_3 = true;
		this.ginterface7_0.imethod_2(this.GClass7_0);
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0000E7FC File Offset: 0x0000C9FC
	public void method_3()
	{
		this.list_0.Clear();
		this.ginterface2_0 = this.ginterface3_0.imethod_1();
		if (!this.bool_3)
		{
			GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
			if (gdelegate != null)
			{
				gdelegate(Class13.string_4, Color.LightGreen, false);
			}
		}
		GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
		if (gdelegate2 != null)
		{
			gdelegate2("AdapterList -ALL_WIRELESS_ONLY", Color.White, true);
		}
		try
		{
			while (this.ginterface2_0 != null)
			{
				GInterface12 ginterface = this.ginterface2_0.imethod_0();
				if (ginterface.GEnum13_0 == GEnum13.JswDeviceType_WiFi & !ginterface.String_0.Contains("Virtual"))
				{
					this.list_0.Add(ginterface);
					string text = Class13.smethod_1((byte[])ginterface.Object_0);
					if (Class13.bool_1)
					{
						text = Class13.smethod_13(text, "X");
					}
					GClass8.GDelegate6 gdelegate3 = this.gdelegate6_0;
					if (gdelegate3 != null)
					{
						gdelegate3(string.Format("{0}    {1}", text, ginterface.String_0), Color.White, true);
					}
				}
			}
		}
		catch (Exception ex)
		{
		}
		if (!this.bool_3)
		{
			GClass8.GDelegate6 gdelegate4 = this.gdelegate6_0;
			if (gdelegate4 != null)
			{
				gdelegate4(Class13.string_4, Color.LightGreen, false);
			}
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0000E940 File Offset: 0x0000CB40
	public void method_4(int int_1)
	{
		try
		{
			this.int_0 = int_1;
			this.method_1(this.int_0);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00003F88 File Offset: 0x00002188
	private void method_5()
	{
		Class13.smethod_3(GClass0.String_0);
		this.method_0();
		this.method_3();
		this.method_1(this.int_0);
		this.method_6(this.bool_1, 1);
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x0000E980 File Offset: 0x0000CB80
	public GClass15<GClass9> method_6(bool bool_4, int int_1)
	{
		GClass15<GClass9> gclass = new GClass15<GClass9>();
		int i = 0;
		this.bool_1 = bool_4;
		GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
		if (gdelegate != null)
		{
			gdelegate(string.Format("Scan -WPSONLY {0}", bool_4), Color.White, true);
		}
		checked
		{
			try
			{
				if (this.genum1_0 == GClass8.GEnum1.Stop)
				{
					WaitSplashForm waitSplashForm = new WaitSplashForm("Scanning", int_1, Class6.Class7_0.MainForm_0);
					waitSplashForm.Show();
					while (i < int_1)
					{
						GInterface16 ginterface = this.ginterface0_0.imethod_1(bool_4);
						this.ginterface0_0.imethod_0();
						GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
						if (gdelegate2 != null)
						{
							gdelegate2(".", Color.Yellow, false);
						}
						int num = 500000;
						DateTime now = DateAndTime.Now;
						TimeSpan timeSpan = DateAndTime.Now.Subtract(DateAndTime.Now);
						now = DateAndTime.Now;
						timeSpan = DateAndTime.Now.Subtract(now);
						while (timeSpan.TotalMilliseconds < 1000.0)
						{
							Application.DoEvents();
							num--;
							timeSpan = DateAndTime.Now.Subtract(now);
						}
						ginterface = this.ginterface0_0.imethod_1(bool_4);
						i++;
						waitSplashForm.Int32_0 = i;
						int num2 = ginterface.imethod_1() - 1;
						for (int j = 0; j <= num2; j++)
						{
							GInterface15 ginterface2 = ginterface.imethod_0();
							GInterface5 ginterface3 = ginterface2;
							GClass9 gclass2 = new GClass9(ref ginterface3);
							ginterface2 = (GInterface15)ginterface3;
							GClass9 item = gclass2;
							if (gclass.Contains(item))
							{
								int index = gclass.IndexOf(item);
								GClass9 gclass3 = gclass[index];
								ginterface3 = ginterface2;
								gclass3.method_2(ref ginterface3, GEnum16.JswMsgType_Beacon);
								ginterface2 = (GInterface15)ginterface3;
							}
							else
							{
								gclass.Add(item);
								if (this.bool_2)
								{
									GClass8.GDelegate6 gdelegate3 = this.gdelegate6_0;
									if (gdelegate3 != null)
									{
										gdelegate3(Class13.smethod_12(ginterface2.imethod_2()), Color.Gray, true);
									}
								}
							}
						}
					}
					waitSplashForm.Dispose();
					GClass8.GDelegate6 gdelegate4 = this.gdelegate6_0;
					if (gdelegate4 != null)
					{
						gdelegate4(".", Color.Yellow, true);
					}
					GClass8.GDelegate6 gdelegate5 = this.gdelegate6_0;
					if (gdelegate5 != null)
					{
						gdelegate5(Class13.smethod_0(gclass), Color.White, true);
					}
				}
			}
			catch (Exception ex)
			{
				GClass8.GDelegate6 gdelegate6 = this.gdelegate6_0;
				if (gdelegate6 != null)
				{
					gdelegate6(ex.Message, Color.IndianRed, true);
				}
			}
			GClass8.GDelegate6 gdelegate7 = this.gdelegate6_0;
			if (gdelegate7 != null)
			{
				gdelegate7(Class13.string_4, Color.LightGreen, false);
			}
			return gclass;
		}
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x0000EC0C File Offset: 0x0000CE0C
	public void method_7(ref GClass9 gclass9_1, GClass12 gclass12_1)
	{
		try
		{
			this.gclass9_0 = gclass9_1;
			this.gclass12_0 = gclass12_1;
			if (this.method_11())
			{
				if (this.ginterface0_0.imethod_2())
				{
					NewLateBinding.LateCall(this.ginterface0_0, null, "ResetConnection", new object[]
					{
						true,
						GEnum11.JswConnResetMethod_Default
					}, null, null, null, true);
				}
				this.genum16_0 = GEnum16.JswMsgType_None;
				this.ginterface7_0 = this.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkApPin, (GInterface11)this.ginterface0_0, null);
				this.ginterface7_0.imethod_2(this.GClass7_0);
				if (this.ginterface7_0 != null)
				{
					this.ginterface7_0.imethod_4((GInterface15)this.gclass9_0.ginterface5_0);
					this.ginterface7_0.imethod_3(this.gclass12_0.Pin);
					this.ginterface7_0.imethod_0();
				}
				this.genum1_0 = GClass8.GEnum1.Start;
				GClass8.GDelegate8 gdelegate = this.gdelegate8_0;
				if (gdelegate != null)
				{
					gdelegate(this.genum1_0);
				}
			}
		}
		catch (Exception ex)
		{
			GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
			if (gdelegate2 != null)
			{
				gdelegate2(ex.Message, Color.IndianRed, true);
			}
			this.method_5();
		}
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x0000ED48 File Offset: 0x0000CF48
	public void method_8(ref GClass9 gclass9_1, ref GClass12 gclass12_1)
	{
		try
		{
			this.gclass9_0 = gclass9_1;
			this.gclass12_0 = gclass12_1;
			if (this.ginterface0_0.imethod_2())
			{
				NewLateBinding.LateCall(this.ginterface0_0, null, "ResetConnection", new object[]
				{
					true,
					GEnum11.JswConnResetMethod_Default
				}, null, null, null, true);
			}
			this.genum16_0 = GEnum16.JswMsgType_None;
			this.ginterface7_0 = this.ginterface3_0.imethod_3(GEnum15.JswEngMode_JoinNetworkPushbutton, (GInterface11)this.ginterface0_0, null);
			this.ginterface7_0.imethod_2(this.GClass7_0);
			if (this.ginterface7_0 != null)
			{
				this.ginterface7_0.imethod_4((GInterface15)this.gclass9_0.ginterface5_0);
				this.ginterface7_0.imethod_0();
			}
			this.genum1_0 = GClass8.GEnum1.Start;
			GClass8.GDelegate8 gdelegate = this.gdelegate8_0;
			if (gdelegate != null)
			{
				gdelegate(this.genum1_0);
			}
		}
		catch (Exception ex)
		{
			GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
			if (gdelegate2 != null)
			{
				gdelegate2(ex.Message, Color.IndianRed, true);
			}
			this.method_5();
		}
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00003FBA File Offset: 0x000021BA
	public void method_9(ref GClass9 gclass9_1)
	{
		this.bool_0 = true;
		this.method_7(ref gclass9_1, new GClass12("12345670", GClass12.GEnum5.Manual));
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x0000EE64 File Offset: 0x0000D064
	public void method_10(bool bool_4)
	{
		try
		{
			if (this.ginterface7_0 != null)
			{
				this.ginterface7_0.imethod_1();
				if (this.ginterface0_0.imethod_2())
				{
					NewLateBinding.LateCall(this.ginterface0_0, null, "ResetConnection", new object[]
					{
						true,
						GEnum11.JswConnResetMethod_Default
					}, null, null, null, true);
				}
				this.bool_0 = false;
				if (this.genum1_0 != GClass8.GEnum1.Stop)
				{
					this.genum1_0 = GClass8.GEnum1.Stop;
					GClass8.GDelegate8 gdelegate = this.gdelegate8_0;
					if (gdelegate != null)
					{
						gdelegate(this.genum1_0);
					}
					if (bool_4)
					{
						this.ginterface7_0 = null;
					}
				}
			}
		}
		catch (Exception ex)
		{
			GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
			if (gdelegate2 != null)
			{
				gdelegate2(ex.Message, Color.IndianRed, true);
			}
			this.method_5();
		}
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x0000EF38 File Offset: 0x0000D138
	private bool method_11()
	{
		int num = 10;
		bool flag = false;
		DateTime now = DateAndTime.Now;
		TimeSpan timeSpan = DateAndTime.Now.Subtract(DateAndTime.Now);
		GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
		if (gdelegate != null)
		{
			gdelegate(string.Format("Scan -BSSID {0}", this.gclass9_0.BSSID), Color.White, true);
		}
		GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
		if (gdelegate2 != null)
		{
			gdelegate2(Class10.String_47, Color.Yellow, false);
		}
		checked
		{
			while (num > 0 & !flag)
			{
				GClass8.GDelegate6 gdelegate3 = this.gdelegate6_0;
				if (gdelegate3 != null)
				{
					gdelegate3(".", Color.Yellow, false);
				}
				GInterface16 ginterface = this.ginterface0_0.imethod_1(this.bool_1);
				this.ginterface0_0.imethod_0();
				int i = 500000;
				now = DateAndTime.Now;
				timeSpan = DateAndTime.Now.Subtract(now);
				while (timeSpan.TotalMilliseconds < 1600.0)
				{
					Application.DoEvents();
					i--;
					timeSpan = DateAndTime.Now.Subtract(now);
				}
				ginterface = this.ginterface0_0.imethod_1(this.bool_1);
				if (ginterface.imethod_1() > 0)
				{
					num--;
				}
				int num2 = ginterface.imethod_1() - 1;
				for (i = 0; i <= num2; i++)
				{
					GInterface15 ginterface2 = ginterface.imethod_0();
					if (Operators.CompareString(Class13.smethod_1((byte[])ginterface2.imethod_0(GEnum9.JswAttr_MACAddress)), Class13.smethod_1((byte[])this.gclass9_0.ginterface5_0.imethod_0(GEnum9.JswAttr_MACAddress)), false) == 0)
					{
						GClass9 gclass = this.gclass9_0;
						GInterface5 ginterface3 = ginterface2;
						gclass.method_2(ref ginterface3, GEnum16.JswMsgType_Beacon);
						ginterface2 = (GInterface15)ginterface3;
						flag = true;
					}
				}
			}
			if (!flag)
			{
				GClass8.GDelegate6 gdelegate4 = this.gdelegate6_0;
				if (gdelegate4 != null)
				{
					gdelegate4("\r\n" + Class10.String_41, Color.Red, true);
				}
				GClass8.GDelegate8 gdelegate5 = this.gdelegate8_0;
				if (gdelegate5 != null)
				{
					gdelegate5(GClass8.GEnum1.ApNotFound);
				}
			}
			else
			{
				GClass8.GDelegate6 gdelegate6 = this.gdelegate6_0;
				if (gdelegate6 != null)
				{
					gdelegate6("", Color.LightGreen, true);
				}
			}
			GClass8.GDelegate6 gdelegate7 = this.gdelegate6_0;
			if (gdelegate7 != null)
			{
				gdelegate7(Class13.string_4, Color.LightGreen, false);
			}
			return flag;
		}
	}

	// Token: 0x060002BA RID: 698 RVA: 0x0000F170 File Offset: 0x0000D370
	public string method_12(ref GClass9 gclass9_1, ref GClass15<GClass9> gclass15_0, ref Control control_0)
	{
		bool flag = false;
		string text = "";
		DateTime now = DateAndTime.Now;
		TimeSpan timeSpan = DateAndTime.Now.Subtract(DateAndTime.Now);
		WaitSplashProcess waitSplashProcess = new WaitSplashProcess(control_0, Class10.String_77);
		if (gclass9_1 == null)
		{
			GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
			if (gdelegate != null)
			{
				gdelegate("WaitingPBC -ALL", Color.White, true);
			}
		}
		else
		{
			GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
			if (gdelegate2 != null)
			{
				gdelegate2(string.Format("WaitingPBC -BSSID {0}", gclass9_1.BSSID), Color.White, true);
			}
		}
		checked
		{
			while (Operators.CompareString(text, "", false) == 0 & !flag)
			{
				GInterface16 ginterface = this.ginterface0_0.imethod_1(this.bool_1);
				this.ginterface0_0.imethod_0();
				int i = 500000;
				now = DateAndTime.Now;
				timeSpan = DateAndTime.Now.Subtract(now);
				while (timeSpan.TotalMilliseconds < 1600.0)
				{
					Application.DoEvents();
					i--;
					timeSpan = DateAndTime.Now.Subtract(now);
				}
				if (!waitSplashProcess.IsDisposed)
				{
					if (!waitSplashProcess.Visible)
					{
						waitSplashProcess.Show();
					}
					waitSplashProcess.Refresh();
				}
				else
				{
					flag = true;
				}
				try
				{
					ginterface = this.ginterface0_0.imethod_1(this.bool_1);
					int num = ginterface.imethod_1() - 1;
					i = 0;
					while (i <= num)
					{
						GInterface15 ginterface2 = ginterface.imethod_0();
						if (gclass9_1 == null)
						{
							goto IL_1FE;
						}
						GInterface5 ginterface3;
						if (Operators.CompareString(Class13.smethod_1((byte[])ginterface2.imethod_0(GEnum9.JswAttr_MACAddress)), Class13.smethod_1((byte[])gclass9_1.ginterface5_0.imethod_0(GEnum9.JswAttr_MACAddress)), false) == 0)
						{
							GClass9 gclass = gclass9_1;
							ginterface3 = ginterface2;
							gclass.method_2(ref ginterface3, GEnum16.JswMsgType_Beacon);
							ginterface2 = (GInterface15)ginterface3;
							try
							{
								if (Operators.ConditionalCompareObjectEqual(((GInterface15)ginterface2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs)).imethod_0(GEnum9.JswAttr_DevicePasswordID), GEnum12.JswDevicePasswordID_PushButton, false))
								{
									text = Class13.smethod_1((byte[])ginterface2.imethod_0(GEnum9.JswAttr_MACAddress));
								}
								goto IL_2A4;
							}
							catch (Exception ex)
							{
								goto IL_2A4;
							}
							goto IL_1FE;
						}
						IL_2A4:
						i++;
						continue;
						IL_1FE:
						ginterface3 = ginterface2;
						GClass9 gclass2 = new GClass9(ref ginterface3);
						ginterface2 = (GInterface15)ginterface3;
						GClass9 item = gclass2;
						if (!gclass15_0.Contains(item))
						{
							gclass15_0.Add(item);
						}
						else
						{
							int index = gclass15_0.IndexOf(item);
							GClass9 gclass3 = gclass15_0[index];
							ginterface3 = ginterface2;
							gclass3.method_2(ref ginterface3, GEnum16.JswMsgType_Beacon);
							ginterface2 = (GInterface15)ginterface3;
						}
						try
						{
							if (Operators.ConditionalCompareObjectEqual(((GInterface15)ginterface2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs)).imethod_0(GEnum9.JswAttr_DevicePasswordID), GEnum12.JswDevicePasswordID_PushButton, false))
							{
								text = Class13.smethod_1((byte[])ginterface2.imethod_0(GEnum9.JswAttr_MACAddress));
							}
						}
						catch (Exception ex2)
						{
						}
						goto IL_2A4;
					}
				}
				catch (Exception ex3)
				{
				}
			}
			if (!waitSplashProcess.IsDisposed)
			{
				waitSplashProcess.Dispose();
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				GClass8.GDelegate8 gdelegate3 = this.gdelegate8_0;
				if (gdelegate3 != null)
				{
					gdelegate3(GClass8.GEnum1.ApNotFound);
				}
			}
			else
			{
				GClass8.GDelegate6 gdelegate4 = this.gdelegate6_0;
				if (gdelegate4 != null)
				{
					gdelegate4("", Color.LightGreen, true);
				}
			}
			GClass8.GDelegate6 gdelegate5 = this.gdelegate6_0;
			if (gdelegate5 != null)
			{
				gdelegate5(Class13.string_4, Color.LightGreen, false);
			}
			return text;
		}
	}

	// Token: 0x060002BB RID: 699 RVA: 0x0000F514 File Offset: 0x0000D714
	private void method_13(GEnum14 genum14_0, int int_1, string string_1)
	{
		Class6.Form0_0.ChangeUICulture(MySettings.Default.Culture);
		for (;;)
		{
			IL_37B:
			for (;;)
			{
				IL_318:
				switch (genum14_0)
				{
				case GEnum14.JswEngEvt_None:
					goto IL_37F;
				case GEnum14.JswEngEvt_FailedInitialize:
					goto IL_3A5;
				case GEnum14.JswEngEvt_Starting:
					goto IL_3CB;
				case GEnum14.JswEngEvt_ScanningForAps:
					goto IL_534;
				case GEnum14.JswEngEvt_NoCandidateApsFound:
					goto IL_55A;
				case GEnum14.JswEngEvt_SelectedAp:
					goto IL_580;
				case GEnum14.JswEngEvt_Associating:
					goto IL_5AE;
				case GEnum14.JswEngEvt_AssociationFailed:
					goto IL_5D1;
				case GEnum14.JswEngEvt_StartProtocol:
					goto IL_606;
				case GEnum14.JswEngEvt_ProtocolSuccess:
				case GEnum14.JswEngEvt_ProtocolAttemptFailed:
					goto IL_D11;
				case GEnum14.JswEngEvt_ProtocolFailed:
					goto IL_62C;
				case GEnum14.JswEngEvt_MultipleApsInPbMode:
					goto IL_652;
				case GEnum14.JswEngEvt_ReceivedCredentials:
					goto IL_678;
				case GEnum14.JswEngEvt_PushButtonTimeout:
					goto IL_6AE;
				case GEnum14.JswEngEvt_SupplicantReceivedMsg:
					goto IL_6D4;
				case GEnum14.JswEngEvt_SupplicantSentMsg:
					goto IL_810;
				case GEnum14.JswEngEvt_ProtocolFailedResetPin:
					goto IL_C28;
				case GEnum14.JswEngEvt_ApInSetupLockedState:
					goto IL_C4E;
				case GEnum14.JswEngEvt_Initializing:
					goto IL_CA4;
				case GEnum14.JswEngEvt_FailedDeviceInitialize:
					goto IL_CD3;
				case GEnum14.JswEngEvt_ProtocolTimeout:
					goto IL_CF3;
				default:
				{
					uint num2;
					uint num = num2 * 1883954165U ^ 3868796024U;
					for (;;)
					{
						switch ((num2 = (num ^ 112626749U)) % 178U)
						{
						case 0U:
							goto IL_8E5;
						case 1U:
							goto IL_CF3;
						case 2U:
							goto IL_63B;
						case 3U:
							goto IL_BC6;
						case 4U:
						case 100U:
							goto IL_37B;
						case 5U:
							goto IL_CDF;
						case 6U:
						case 12U:
						case 19U:
						case 31U:
						case 44U:
						case 56U:
						case 58U:
						case 63U:
						case 64U:
						case 91U:
						case 108U:
						case 111U:
						case 112U:
						case 117U:
						case 127U:
						case 129U:
						case 140U:
						case 159U:
						case 168U:
							goto IL_D11;
						case 7U:
							goto IL_69C;
						case 8U:
							goto IL_53C;
						case 9U:
							goto IL_B1D;
						case 10U:
							goto IL_6FD;
						case 11U:
						case 34U:
						case 150U:
							goto IL_7F4;
						case 13U:
							goto IL_A6B;
						case 14U:
							goto IL_65A;
						case 15U:
							goto IL_9B1;
						case 16U:
							goto IL_716;
						case 17U:
							goto IL_8C2;
						case 18U:
							goto IL_37F;
						case 20U:
							goto IL_D31;
						case 21U:
							goto IL_8D5;
						case 22U:
							goto IL_5F9;
						case 23U:
							goto IL_C56;
						case 24U:
							goto IL_3D2;
						case 25U:
							goto IL_C5A;
						case 26U:
							goto IL_522;
						case 27U:
							goto IL_678;
						case 28U:
							goto IL_AF5;
						case 29U:
							goto IL_78B;
						case 30U:
							goto IL_7FC;
						case 32U:
							goto IL_661;
						case 33U:
							goto IL_C93;
						case 35U:
							num = (num2 * 909184755U ^ 1462892102U);
							continue;
						case 36U:
							goto IL_C9B;
						case 37U:
							goto IL_7B4;
						case 38U:
							goto IL_B5E;
						case 39U:
							goto IL_BD2;
						case 40U:
							goto IL_3B4;
						case 41U:
							goto IL_6AE;
						case 42U:
							goto IL_B78;
						case 43U:
							goto IL_A19;
						case 45U:
							goto IL_543;
						case 46U:
							goto IL_BE7;
						case 47U:
							goto IL_998;
						case 48U:
							goto IL_D40;
						case 49U:
							goto IL_C87;
						case 50U:
							goto IL_71F;
						case 51U:
							goto IL_903;
						case 52U:
							goto IL_62C;
						case 53U:
							goto IL_9A5;
						case 54U:
							goto IL_803;
						case 55U:
						case 75U:
							goto IL_505;
						case 57U:
							goto IL_A38;
						case 59U:
							goto IL_6BD;
						case 60U:
							goto IL_513;
						case 61U:
							goto IL_38E;
						case 62U:
							goto IL_46D;
						case 65U:
							goto IL_3E5;
						case 66U:
							goto IL_798;
						case 67U:
							goto IL_C0F;
						case 68U:
							goto IL_A2C;
						case 69U:
							goto IL_B52;
						case 70U:
							goto IL_C00;
						case 71U:
							goto IL_B74;
						case 72U:
							goto IL_4A5;
						case 73U:
							goto IL_AB5;
						case 74U:
							goto IL_C28;
						case 76U:
							goto IL_8CD;
						case 77U:
							goto IL_A34;
						case 78U:
							goto IL_5B5;
						case 79U:
							goto IL_9B8;
						case 80U:
							goto IL_9C4;
						case 81U:
							goto IL_7C3;
						case 82U:
							goto IL_461;
						case 83U:
							goto IL_8DD;
						case 84U:
							goto IL_9CD;
						case 85U:
							goto IL_A67;
						case 86U:
							goto IL_B2C;
						case 87U:
							goto IL_C16;
						case 88U:
							goto IL_58C;
						case 89U:
							goto IL_3A5;
						case 90U:
							goto IL_3CB;
						case 92U:
							goto IL_7A1;
						case 93U:
							goto IL_BF4;
						case 94U:
							goto IL_7EC;
						case 95U:
							goto IL_3E9;
						case 96U:
							goto IL_88E;
						case 97U:
							goto IL_A99;
						case 98U:
							goto IL_CDB;
						case 99U:
							goto IL_CFB;
						case 101U:
							goto IL_3DD;
						case 102U:
							goto IL_93E;
						case 103U:
							goto IL_55A;
						case 104U:
							goto IL_96A;
						case 105U:
							goto IL_A8D;
						case 106U:
							goto IL_425;
						case 107U:
							goto IL_CD3;
						case 109U:
							goto IL_AA4;
						case 110U:
							goto IL_CAC;
						case 113U:
							goto IL_580;
						case 114U:
							goto IL_788;
						case 115U:
							goto IL_6D4;
						case 116U:
							goto IL_652;
						case 118U:
							goto IL_6B6;
						case 119U:
							goto IL_70F;
						case 120U:
							goto IL_957;
						case 121U:
							goto IL_CA4;
						case 122U:
							goto IL_94B;
						case 123U:
							goto IL_4AD;
						case 124U:
							goto IL_790;
						case 125U:
							goto IL_C4E;
						case 126U:
							goto IL_6E0;
						case 128U:
							goto IL_CFF;
						case 130U:
							goto IL_810;
						case 131U:
							goto IL_5EC;
						case 132U:
							goto IL_686;
						case 133U:
							goto IL_A5F;
						case 134U:
							goto IL_BB3;
						case 135U:
							goto IL_4B1;
						case 136U:
							goto IL_569;
						case 137U:
							goto IL_B6C;
						case 138U:
							goto IL_318;
						case 139U:
							goto IL_976;
						case 141U:
							goto IL_8F7;
						case 142U:
							goto IL_A25;
						case 143U:
							goto IL_5F3;
						case 144U:
							goto IL_D21;
						case 145U:
							goto IL_534;
						case 146U:
							goto IL_469;
						case 147U:
							goto IL_695;
						case 149U:
							goto IL_5D1;
						case 151U:
							goto IL_CCA;
						case 152U:
							goto IL_C8F;
						case 153U:
							goto IL_B24;
						case 154U:
							goto IL_B30;
						case 155U:
							goto IL_8BA;
						case 156U:
							goto IL_C37;
						case 157U:
							goto IL_9DE;
						case 158U:
							goto IL_CB8;
						case 160U:
							goto IL_8EE;
						case 161U:
							goto IL_CB4;
						case 162U:
							goto IL_59E;
						case 163U:
							goto IL_5AE;
						case 164U:
							goto IL_416;
						case 165U:
							goto IL_886;
						case 166U:
							goto IL_6DC;
						case 167U:
							goto IL_5BB;
						case 169U:
							goto IL_B9A;
						case 170U:
							goto IL_D39;
						case 171U:
							goto IL_8AF;
						case 172U:
							goto IL_BA7;
						case 173U:
							goto IL_615;
						case 174U:
							goto IL_5DB;
						case 175U:
							goto IL_892;
						case 176U:
							goto IL_606;
						case 177U:
							goto IL_60E;
						}
						goto Block_1;
					}
					break;
				}
				}
			}
		}
		Block_1:
		return;
		IL_37F:
		GClass8.GDelegate6 gdelegate = this.gdelegate6_0;
		if (gdelegate == null)
		{
			goto IL_D11;
		}
		IL_38E:
		gdelegate(Class10.String_42, Color.White, true);
		goto IL_D11;
		IL_3A5:
		GClass8.GDelegate6 gdelegate2 = this.gdelegate6_0;
		if (gdelegate2 == null)
		{
			goto IL_D11;
		}
		IL_3B4:
		gdelegate2(Class10.String_36, Color.Red, true);
		goto IL_D11;
		IL_3CB:
		this.bool_3 = false;
		IL_3D2:
		if (!this.bool_0)
		{
			goto IL_461;
		}
		IL_3DD:
		GClass8.GDelegate6 gdelegate3 = this.gdelegate6_0;
		IL_3E5:
		if (gdelegate3 == null)
		{
			goto IL_416;
		}
		IL_3E9:
		gdelegate3(string.Format(" PixieDust -SSID {0}  -BSSID {1}", this.gclass9_0.SSID, this.gclass9_0.BSSID), Color.White, true);
		IL_416:
		GClass8.GDelegate6 gdelegate4 = this.gdelegate6_0;
		if (gdelegate4 == null)
		{
			goto IL_505;
		}
		IL_425:
		gdelegate4(string.Format(Class10.String_53, this.gclass9_0.SSID, this.gclass9_0.BSSID, DateAndTime.Now), Color.Yellow, true);
		goto IL_505;
		IL_461:
		GClass8.GDelegate6 gdelegate5 = this.gdelegate6_0;
		IL_469:
		if (gdelegate5 == null)
		{
			goto IL_4A5;
		}
		IL_46D:
		gdelegate5(string.Format(" WpsPin -PIN {0} -SSID {1}  -BSSID {2}", this.gclass12_0.Pin, this.gclass9_0.SSID, this.gclass9_0.BSSID), Color.White, true);
		IL_4A5:
		GClass8.GDelegate6 gdelegate6 = this.gdelegate6_0;
		IL_4AD:
		if (gdelegate6 == null)
		{
			goto IL_505;
		}
		IL_4B1:
		gdelegate6(string.Format(Class10.String_52, new object[]
		{
			this.gclass12_0.Pin,
			this.gclass9_0.SSID,
			this.gclass9_0.BSSID,
			DateAndTime.Now
		}), Color.Yellow, true);
		IL_505:
		this.genum1_0 = GClass8.GEnum1.Testing;
		this.genum2_0 = GClass8.GEnum2.None;
		IL_513:
		GClass8.GDelegate8 gdelegate7 = this.gdelegate8_0;
		if (gdelegate7 == null)
		{
			goto IL_D11;
		}
		IL_522:
		gdelegate7(this.genum1_0);
		goto IL_D11;
		IL_534:
		GClass8.GDelegate6 gdelegate8 = this.gdelegate6_0;
		IL_53C:
		if (gdelegate8 == null)
		{
			goto IL_D11;
		}
		IL_543:
		gdelegate8(Class10.String_47, Color.LightGreen, true);
		goto IL_D11;
		IL_55A:
		GClass8.GDelegate6 gdelegate9 = this.gdelegate6_0;
		if (gdelegate9 == null)
		{
			goto IL_D11;
		}
		IL_569:
		gdelegate9(Class10.String_41, Color.Red, true);
		goto IL_D11;
		IL_580:
		GClass8.GDelegate6 gdelegate10 = this.gdelegate6_0;
		if (gdelegate10 == null)
		{
			goto IL_59E;
		}
		IL_58C:
		gdelegate10(Class10.String_48, Color.LightGreen, true);
		IL_59E:
		this.ginterface0_0.imethod_0();
		goto IL_D11;
		IL_5AE:
		GClass8.GDelegate6 gdelegate11 = this.gdelegate6_0;
		IL_5B5:
		if (gdelegate11 == null)
		{
			goto IL_D11;
		}
		IL_5BB:
		gdelegate11(Class10.String_32, Color.LightGreen, true);
		goto IL_D11;
		IL_5D1:
		GClass8.GDelegate6 gdelegate12 = this.gdelegate6_0;
		if (gdelegate12 == null)
		{
			goto IL_5EC;
		}
		IL_5DB:
		gdelegate12(Class10.String_33, Color.Red, true);
		IL_5EC:
		GClass8.GDelegate8 gdelegate13 = this.gdelegate8_0;
		IL_5F3:
		if (gdelegate13 == null)
		{
			goto IL_D11;
		}
		IL_5F9:
		gdelegate13(GClass8.GEnum1.AssociationFailed);
		goto IL_D11;
		IL_606:
		GClass8.GDelegate6 gdelegate14 = this.gdelegate6_0;
		IL_60E:
		if (gdelegate14 == null)
		{
			goto IL_D11;
		}
		IL_615:
		gdelegate14(Class10.String_49, Color.LightGreen, true);
		goto IL_D11;
		IL_62C:
		GClass8.GDelegate6 gdelegate15 = this.gdelegate6_0;
		if (gdelegate15 == null)
		{
			goto IL_D11;
		}
		IL_63B:
		gdelegate15(Class10.String_43, Color.Red, true);
		goto IL_D11;
		IL_652:
		GClass8.GDelegate6 gdelegate16 = this.gdelegate6_0;
		IL_65A:
		if (gdelegate16 == null)
		{
			goto IL_D11;
		}
		IL_661:
		gdelegate16(Class10.String_39, Color.Orange, true);
		goto IL_D11;
		IL_678:
		if (this.genum1_0 != GClass8.GEnum1.Testing)
		{
			goto IL_D11;
		}
		IL_686:
		this.genum1_0 = GClass8.GEnum1.Success;
		GClass8.GDelegate8 gdelegate17 = this.gdelegate8_0;
		IL_695:
		if (gdelegate17 == null)
		{
			goto IL_D11;
		}
		IL_69C:
		gdelegate17(this.genum1_0);
		goto IL_D11;
		IL_6AE:
		GClass8.GDelegate6 gdelegate18 = this.gdelegate6_0;
		IL_6B6:
		if (gdelegate18 == null)
		{
			goto IL_D11;
		}
		IL_6BD:
		gdelegate18(Class10.String_46, Color.Orange, true);
		goto IL_D11;
		IL_6D4:
		GClass8.GDelegate6 gdelegate19 = this.gdelegate6_0;
		IL_6DC:
		if (gdelegate19 == null)
		{
			goto IL_6FD;
		}
		IL_6E0:
		gdelegate19(Class10.String_50 + Class13.smethod_10((GEnum16)int_1), Color.AliceBlue, true);
		IL_6FD:
		if (!(int_1 >= 4 & int_1 <= 12))
		{
			goto IL_716;
		}
		IL_70F:
		this.genum16_0 = (GEnum16)int_1;
		IL_716:
		if (this.genum1_0 != GClass8.GEnum1.Testing)
		{
			goto IL_788;
		}
		IL_71F:
		GInterface5[] ginterface5_ = this.gclass9_0.ginterface5_1;
		int num3 = int_1;
		object[] array;
		bool[] array2;
		object obj = NewLateBinding.LateGet(this.ginterface7_0, null, "GetProtocolMsg", array = new object[]
		{
			int_1
		}, null, null, array2 = new bool[]
		{
			true
		});
		if (array2[0])
		{
			int_1 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		ginterface5_[num3] = (GInterface5)obj;
		IL_788:
		int num4 = int_1;
		IL_78B:
		if (num4 == 4)
		{
			goto IL_7C3;
		}
		IL_790:
		if (num4 != 14)
		{
			goto IL_7F4;
		}
		IL_798:
		if (this.genum1_0 != GClass8.GEnum1.Testing)
		{
			goto IL_7F4;
		}
		IL_7A1:
		this.genum1_0 = GClass8.GEnum1.NACK;
		GClass8.GDelegate8 gdelegate20 = this.gdelegate8_0;
		if (gdelegate20 == null)
		{
			goto IL_7F4;
		}
		IL_7B4:
		gdelegate20(this.genum1_0);
		goto IL_7F4;
		IL_7C3:
		this.gclass9_0.method_2(ref this.gclass9_0.ginterface5_1[int_1], GEnum16.JswMsgType_M1);
		GClass8.GDelegate8 gdelegate21 = this.gdelegate8_0;
		if (gdelegate21 == null)
		{
			goto IL_7F4;
		}
		IL_7EC:
		gdelegate21(GClass8.GEnum1.Updated);
		IL_7F4:
		GClass8.GDelegate7 gdelegate22 = this.gdelegate7_0;
		IL_7FC:
		if (gdelegate22 == null)
		{
			goto IL_D11;
		}
		IL_803:
		gdelegate22((GEnum16)int_1);
		goto IL_D11;
		IL_810:
		GInterface5[] ginterface5_2 = this.gclass9_0.ginterface5_1;
		int num5 = int_1;
		object obj2 = NewLateBinding.LateGet(this.ginterface7_0, null, "GetProtocolMsg", array = new object[]
		{
			int_1
		}, null, null, array2 = new bool[]
		{
			true
		});
		if (array2[0])
		{
			int_1 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		ginterface5_2[num5] = (GInterface5)obj2;
		if (this.bool_0 & int_1 == 8)
		{
			goto IL_8AF;
		}
		IL_886:
		GClass8.GDelegate6 gdelegate23 = this.gdelegate6_0;
		IL_88E:
		if (gdelegate23 == null)
		{
			goto IL_8AF;
		}
		IL_892:
		gdelegate23(Class10.String_51 + Class13.smethod_10((GEnum16)int_1), Color.AliceBlue, true);
		IL_8AF:
		int num6 = int_1;
		if (num6 == 8)
		{
			goto IL_BD2;
		}
		IL_8BA:
		if (num6 == 14)
		{
			goto IL_8CD;
		}
		IL_8C2:
		if (num6 != 15)
		{
			goto IL_D11;
		}
		IL_8CD:
		GEnum16 genum = this.genum16_0;
		IL_8D5:
		if (genum < GEnum16.JswMsgType_M3)
		{
			goto IL_BC6;
		}
		IL_8DD:
		if (genum == GEnum16.JswMsgType_M3)
		{
			goto IL_B5E;
		}
		IL_8E5:
		if (genum != GEnum16.JswMsgType_M5)
		{
			goto IL_9C4;
		}
		IL_8EE:
		if (this.genum1_0 != GClass8.GEnum1.NACK)
		{
			goto IL_96A;
		}
		IL_8F7:
		GClass8.GDelegate6 gdelegate24 = this.gdelegate6_0;
		if (gdelegate24 == null)
		{
			goto IL_93E;
		}
		IL_903:
		gdelegate24(string.Format(Class10.String_37, this.gclass12_0.Pin.Substring(0, 4), this.gclass12_0.Pin.Substring(4, 4)), Color.Orange, true);
		IL_93E:
		if (this.gclass9_0.Status != GClass9.GEnum3.Unknow)
		{
			goto IL_957;
		}
		IL_94B:
		this.gclass9_0.Status = GClass9.GEnum3.Nok;
		IL_957:
		this.genum2_0 = GClass8.GEnum2.fHalfOk;
		this.method_10(true);
		goto IL_D11;
		IL_96A:
		GClass8.GDelegate6 gdelegate25 = this.gdelegate6_0;
		if (gdelegate25 == null)
		{
			goto IL_998;
		}
		IL_976:
		gdelegate25(string.Format(Class10.String_34, this.gclass12_0.Pin), Color.Red, true);
		IL_998:
		if (this.gclass9_0.Status != GClass9.GEnum3.Unknow)
		{
			goto IL_9B1;
		}
		IL_9A5:
		this.gclass9_0.Status = GClass9.GEnum3.Nok;
		IL_9B1:
		this.genum2_0 = GClass8.GEnum2.Nok;
		IL_9B8:
		this.method_10(true);
		goto IL_D11;
		IL_9C4:
		if (genum != GEnum16.JswMsgType_M7)
		{
			goto IL_A99;
		}
		IL_9CD:
		this.gclass9_0.Pin = this.gclass12_0;
		IL_9DE:
		GInterface5 ginterface = (GInterface5)this.gclass9_0.ginterface5_1[11].imethod_0(GEnum9.JswAttr_EncryptedSettings);
		this.gclass9_0.NetworkKey = Conversions.ToString(ginterface.imethod_0(GEnum9.JswAttr_NetworkKey));
		IL_A19:
		this.gclass9_0.Status = GClass9.GEnum3.Ok;
		IL_A25:
		this.genum2_0 = GClass8.GEnum2.Ok;
		IL_A2C:
		GClass8.GDelegate6 gdelegate26 = this.gdelegate6_0;
		IL_A34:
		if (gdelegate26 == null)
		{
			goto IL_A5F;
		}
		IL_A38:
		gdelegate26(Class10.String_54 + this.gclass9_0.Pin.Pin, Color.Lime, true);
		IL_A5F:
		GClass8.GDelegate6 gdelegate27 = this.gdelegate6_0;
		IL_A67:
		if (gdelegate27 == null)
		{
			goto IL_A8D;
		}
		IL_A6B:
		gdelegate27(Class10.String_40 + this.gclass9_0.NetworkKey, Color.Lime, true);
		IL_A8D:
		this.method_10(true);
		goto IL_D11;
		IL_A99:
		if (genum != GEnum16.JswMsgType_M8)
		{
			goto IL_D11;
		}
		IL_AA4:
		this.gclass9_0.Pin = this.gclass12_0;
		IL_AB5:
		GInterface5 ginterface2 = (GInterface5)NewLateBinding.LateGet(this.gclass9_0.ginterface5_1[12].imethod_0(GEnum9.JswAttr_EncryptedSettings), null, "GetItem", new object[]
		{
			GEnum9.JswAttr_Credential
		}, null, null, null);
		IL_AF5:
		this.gclass9_0.NetworkKey = Conversions.ToString(ginterface2.imethod_0(GEnum9.JswAttr_NetworkKey));
		this.gclass9_0.Status = GClass9.GEnum3.Ok;
		IL_B1D:
		this.genum2_0 = GClass8.GEnum2.Ok;
		IL_B24:
		GClass8.GDelegate6 gdelegate28 = this.gdelegate6_0;
		IL_B2C:
		if (gdelegate28 == null)
		{
			goto IL_B52;
		}
		IL_B30:
		gdelegate28(Class10.String_40 + this.gclass9_0.NetworkKey, Color.Lime, true);
		IL_B52:
		this.method_10(true);
		goto IL_D11;
		IL_B5E:
		if (this.genum1_0 != GClass8.GEnum1.NACK)
		{
			goto IL_D11;
		}
		IL_B6C:
		GClass8.GDelegate6 gdelegate29 = this.gdelegate6_0;
		IL_B74:
		if (gdelegate29 == null)
		{
			goto IL_B9A;
		}
		IL_B78:
		gdelegate29(string.Format(Class10.String_38, this.gclass12_0.Pin), Color.Red, true);
		IL_B9A:
		if (this.gclass9_0.Status != GClass9.GEnum3.Unknow)
		{
			goto IL_BB3;
		}
		IL_BA7:
		this.gclass9_0.Status = GClass9.GEnum3.Nok;
		IL_BB3:
		this.genum2_0 = GClass8.GEnum2.Nok;
		this.method_10(true);
		goto IL_D11;
		IL_BC6:
		this.genum2_0 = GClass8.GEnum2.Fault;
		goto IL_D11;
		IL_BD2:
		if (!(this.bool_0 & this.genum1_0 == GClass8.GEnum1.Testing))
		{
			goto IL_D11;
		}
		IL_BE7:
		if (this.gclass9_0.Status != GClass9.GEnum3.Unknow)
		{
			goto IL_C00;
		}
		IL_BF4:
		this.gclass9_0.Status = GClass9.GEnum3.Nok;
		IL_C00:
		this.genum1_0 = GClass8.GEnum1.PixieSucced;
		GClass8.GDelegate8 gdelegate30 = this.gdelegate8_0;
		IL_C0F:
		if (gdelegate30 == null)
		{
			goto IL_D11;
		}
		IL_C16:
		gdelegate30(this.genum1_0);
		goto IL_D11;
		IL_C28:
		GClass8.GDelegate6 gdelegate31 = this.gdelegate6_0;
		if (gdelegate31 == null)
		{
			goto IL_D11;
		}
		IL_C37:
		gdelegate31(Class10.String_44, Color.Red, true);
		goto IL_D11;
		IL_C4E:
		GClass8.GDelegate6 gdelegate32 = this.gdelegate6_0;
		IL_C56:
		if (gdelegate32 == null)
		{
			goto IL_C87;
		}
		IL_C5A:
		gdelegate32(string.Format(Class10.String_31, this.gclass9_0.BSSID, this.gclass9_0.SSID), Color.Red, true);
		IL_C87:
		GClass8.GDelegate8 gdelegate33 = this.gdelegate8_0;
		IL_C8F:
		if (gdelegate33 == null)
		{
			goto IL_C9B;
		}
		IL_C93:
		gdelegate33(GClass8.GEnum1.Locked);
		IL_C9B:
		this.method_10(true);
		goto IL_D11;
		IL_CA4:
		if (this.bool_3)
		{
			goto IL_D11;
		}
		IL_CAC:
		GClass8.GDelegate6 gdelegate34 = this.gdelegate6_0;
		IL_CB4:
		if (gdelegate34 == null)
		{
			goto IL_CCA;
		}
		IL_CB8:
		gdelegate34(Class13.string_4, Color.LightGreen, false);
		IL_CCA:
		this.bool_3 = true;
		goto IL_D11;
		IL_CD3:
		GClass8.GDelegate6 gdelegate35 = this.gdelegate6_0;
		IL_CDB:
		if (gdelegate35 == null)
		{
			goto IL_D11;
		}
		IL_CDF:
		gdelegate35(Class10.String_35, Color.Red, true);
		goto IL_D11;
		IL_CF3:
		GClass8.GDelegate6 gdelegate36 = this.gdelegate6_0;
		IL_CFB:
		if (gdelegate36 == null)
		{
			goto IL_D11;
		}
		IL_CFF:
		gdelegate36(Class10.String_45, Color.Orange, true);
		IL_D11:
		if (this.bool_0 & int_1 == 8)
		{
			return;
		}
		IL_D21:
		if (!(int_1 != 0 & this.bool_2))
		{
			return;
		}
		IL_D31:
		GClass8.GDelegate6 gdelegate37 = this.gdelegate6_0;
		IL_D39:
		if (gdelegate37 == null)
		{
			return;
		}
		IL_D40:
		GClass8.GDelegate6 gdelegate38 = gdelegate37;
		object instance = NewLateBinding.LateGet(this.ginterface7_0, null, "GetProtocolMsg", array = new object[]
		{
			int_1
		}, null, null, array2 = new bool[]
		{
			true
		});
		if (array2[0])
		{
			int_1 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
		}
		gdelegate38(Class13.smethod_12(Conversions.ToString(NewLateBinding.LateGet(instance, null, "OutputToString", new object[0], null, null, null))), Color.Gray, true);
	}

	// Token: 0x040000EC RID: 236
	private GInterface3 ginterface3_0;

	// Token: 0x040000ED RID: 237
	private GInterface2 ginterface2_0;

	// Token: 0x040000EE RID: 238
	private int int_0;

	// Token: 0x040000EF RID: 239
	public List<GInterface1> list_0;

	// Token: 0x040000F0 RID: 240
	private GInterface0 ginterface0_0;

	// Token: 0x040000F1 RID: 241
	private GInterface7 ginterface7_0;

	// Token: 0x040000F2 RID: 242
	[CompilerGenerated]
	[AccessedThroughProperty("engineListener")]
	private GClass7 gclass7_0;

	// Token: 0x040000F3 RID: 243
	private bool bool_0;

	// Token: 0x040000F4 RID: 244
	private GClass9 gclass9_0;

	// Token: 0x040000F5 RID: 245
	private GClass12 gclass12_0;

	// Token: 0x040000F6 RID: 246
	public string string_0;

	// Token: 0x040000F7 RID: 247
	private bool bool_1;

	// Token: 0x040000F8 RID: 248
	private GClass8.GEnum1 genum1_0;

	// Token: 0x040000F9 RID: 249
	public GClass8.GEnum2 genum2_0;

	// Token: 0x040000FA RID: 250
	public GEnum16 genum16_0;

	// Token: 0x040000FB RID: 251
	public bool bool_2;

	// Token: 0x040000FC RID: 252
	[CompilerGenerated]
	private GClass8.GDelegate6 gdelegate6_0;

	// Token: 0x040000FD RID: 253
	[CompilerGenerated]
	private GClass8.GDelegate7 gdelegate7_0;

	// Token: 0x040000FE RID: 254
	[CompilerGenerated]
	private GClass8.GDelegate8 gdelegate8_0;

	// Token: 0x040000FF RID: 255
	[CompilerGenerated]
	private GClass8.Delegate0 delegate0_0;

	// Token: 0x04000100 RID: 256
	private bool bool_3;

	// Token: 0x0200001E RID: 30
	// (Invoke) Token: 0x060002BF RID: 703
	public delegate void GDelegate6(string message, Color color, bool autoCrLf);

	// Token: 0x0200001F RID: 31
	// (Invoke) Token: 0x060002C3 RID: 707
	public delegate void GDelegate7(GEnum16 MessageType);

	// Token: 0x02000020 RID: 32
	// (Invoke) Token: 0x060002C7 RID: 711
	public delegate void GDelegate8(GClass8.GEnum1 Status);

	// Token: 0x02000021 RID: 33
	// (Invoke) Token: 0x060002CB RID: 715
	private delegate void Delegate0();

	// Token: 0x02000022 RID: 34
	public enum GEnum1
	{
		// Token: 0x04000102 RID: 258
		Stop,
		// Token: 0x04000103 RID: 259
		Start,
		// Token: 0x04000104 RID: 260
		Testing,
		// Token: 0x04000105 RID: 261
		Success = 4,
		// Token: 0x04000106 RID: 262
		NACK,
		// Token: 0x04000107 RID: 263
		Updated,
		// Token: 0x04000108 RID: 264
		Locked,
		// Token: 0x04000109 RID: 265
		PixieSucced,
		// Token: 0x0400010A RID: 266
		ApNotFound,
		// Token: 0x0400010B RID: 267
		AssociationFailed
	}

	// Token: 0x02000023 RID: 35
	public enum GEnum2
	{
		// Token: 0x0400010D RID: 269
		None,
		// Token: 0x0400010E RID: 270
		Nok,
		// Token: 0x0400010F RID: 271
		Ok,
		// Token: 0x04000110 RID: 272
		fHalfOk,
		// Token: 0x04000111 RID: 273
		Fault
	}
}
