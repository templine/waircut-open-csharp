using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000024 RID: 36
public class GClass9 : INotifyPropertyChanged
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060002CC RID: 716 RVA: 0x000102E4 File Offset: 0x0000E4E4
	// (remove) Token: 0x060002CD RID: 717 RVA: 0x0001031C File Offset: 0x0000E51C
	event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, value2, propertyChangedEventHandler2);
			}
			while (propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00010354 File Offset: 0x0000E554
	public GClass9(ref GInterface5 ginterface5_2)
	{
		this.ginterface5_1 = new GInterface5[17];
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		this.string_4 = "";
		this.string_5 = "";
		this.string_6 = "";
		this.string_7 = "";
		this.bool_0 = false;
		this.string_8 = "";
		this.string_9 = "";
		this.string_10 = "";
		this.string_11 = "";
		this.int_0 = 0;
		this.string_12 = "";
		this.gclass15_0 = new GClass15<GClass12>();
		this.bool_1 = false;
		this.string_13 = "";
		this.gclass12_0 = new GClass12();
		this.string_14 = "";
		this.string_15 = "";
		this.string_20 = "";
		this.genum3_0 = GClass9.GEnum3.Unknow;
		this.genum4_0 = GClass9.GEnum4.Nothing;
		this.bool_2 = false;
		this.sqliteConnection_0 = new SQLiteConnection("Data Source=Bd\\WpsPin.db;Version=3;");
		this.sqliteConnection_1 = new SQLiteConnection("Data Source=Bd\\WpsProbePin.db;Version=3;");
		this.sqliteConnection_2 = new SQLiteConnection("Data Source=Bd\\ApLog.db;Version=3;");
		this.method_3(ref ginterface5_2);
		this.method_10();
		this.method_0();
	}

	// Token: 0x060002CF RID: 719 RVA: 0x000104B4 File Offset: 0x0000E6B4
	private void method_0()
	{
		this.method_9();
		try
		{
			foreach (GClass12 gclass in this.gclass15_0)
			{
				if (gclass.genum0_0 == GClass3.GEnum0.Nothing)
				{
					int count = this.gclass15_0.Count;
					if (count == 0)
					{
						this.genum4_0 = GClass9.GEnum4.Nothing;
					}
					else if (count == 1)
					{
						this.genum4_0 = GClass9.GEnum4.Single;
					}
					else if (count > 1)
					{
						this.genum4_0 = GClass9.GEnum4.Several;
					}
				}
				else
				{
					this.genum4_0 = GClass9.GEnum4.Algorithm;
				}
				if (gclass.gclass11_0.bool_0)
				{
					this.bool_1 = true;
				}
			}
		}
		finally
		{
			IEnumerator<GClass12> enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
		if (Operators.CompareString(this.gclass12_0.Pin, "", false) != 0 && !this.gclass15_0.Contains(this.gclass12_0))
		{
			this.gclass15_0.Add(this.gclass12_0);
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x00003FD5 File Offset: 0x000021D5
	public void method_1(GInterface5 ginterface5_2)
	{
		this.bool_0 = Operators.ConditionalCompareObjectEqual(this.method_7(ref ginterface5_2, GEnum9.JswAttr_ConfigurationError), GEnum10.JswConfigError_SetupLocked, false);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00010594 File Offset: 0x0000E794
	public void method_2(ref GInterface5 ginterface5_2, GEnum16 genum16_0)
	{
		try
		{
			bool flag = this.bool_2;
			if (genum16_0 == GEnum16.JswMsgType_Beacon)
			{
				this.method_3(ref ginterface5_2);
			}
			else if (genum16_0 == GEnum16.JswMsgType_M1)
			{
				this.method_4(ref ginterface5_2);
			}
			if (!flag & this.bool_2)
			{
				this.gclass15_0.Clear();
				this.method_0();
			}
			PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(this.BSSID));
			}
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00010620 File Offset: 0x0000E820
	private void method_3(ref GInterface5 ginterface5_2)
	{
		this.ginterface5_0 = ginterface5_2;
		try
		{
			this.string_8 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_MACAddress));
			this.string_11 = this.method_7(ref ginterface5_2, GEnum9.JswAttr_SSID).ToString();
			if (this.int_0 == 0)
			{
				this.int_0 = Conversions.ToInteger(this.method_7(ref ginterface5_2, GEnum9.JswAttr_Rssi));
			}
			else
			{
				this.int_0 = Conversions.ToInteger(Operators.DivideObject(Operators.AddObject(this.int_0, this.method_7(ref ginterface5_2, GEnum9.JswAttr_Rssi)), 2));
			}
			this.string_12 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_APChannel));
			if (Operators.CompareString(this.string_9, "", false) == 0)
			{
				this.string_9 = Conversions.ToString(Operators.ConcatenateObject(this.method_7(ref ginterface5_2, GEnum9.JswAttr_AuthenticationTypeFlags), this.method_7(ref ginterface5_2, GEnum9.JswAttr_EncryptionTypeFlags)));
			}
			GInterface5 ginterface = (GInterface5)ginterface5_2.imethod_0(GEnum9.JswAttr_SimpleConfigIEs);
			if (Operators.CompareString(this.string_0, "", false) == 0)
			{
				this.string_0 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_DeviceName));
			}
			if (Operators.CompareString(this.string_1, "", false) == 0)
			{
				this.string_1 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_Manufacturer));
			}
			if (Operators.CompareString(this.string_2, "", false) == 0)
			{
				this.string_2 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_ModelName));
			}
			if (Operators.CompareString(this.string_3, "", false) == 0)
			{
				this.string_3 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_ModelNumber));
			}
			if (Operators.CompareString(this.SerialNumber, "", false) == 0)
			{
				this.string_4 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_SerialNumber));
			}
			if (Operators.CompareString(this.string_5, "", false) == 0)
			{
				this.string_5 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_RFBand));
			}
			if (Operators.CompareString(this.string_6, "", false) == 0)
			{
				this.string_6 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_UUID_E));
			}
			if (Operators.CompareString(this.string_7, "", false) == 0)
			{
				this.string_7 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_Version));
			}
			GInterface5 ginterface2 = (GInterface5)this.method_7(ref ginterface, GEnum9.JswAttr_VendorExtension);
			this.method_5(ref ginterface2);
			this.bool_0 = Conversions.ToBoolean(this.method_7(ref ginterface, GEnum9.JswAttr_APSetupLocked));
			if (Operators.CompareString(this.string_10, "", false) == 0)
			{
				this.string_10 = Conversions.ToString(this.method_7(ref ginterface, GEnum9.JswAttr_ConfigMethods));
			}
			this.bool_2 = (Operators.CompareString(this.string_0, "", false) != 0 & Operators.CompareString(this.string_1, "", false) != 0 & Operators.CompareString(this.string_2, "", false) != 0 & Operators.CompareString(this.SerialNumber, "", false) != 0);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00010958 File Offset: 0x0000EB58
	private void method_4(ref GInterface5 ginterface5_2)
	{
		this.string_1 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_Manufacturer));
		this.string_2 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_ModelName));
		this.string_3 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_ModelNumber));
		this.string_4 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_SerialNumber));
		this.string_0 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_DeviceName));
		this.string_5 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_RFBand));
		this.string_6 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_UUID_E));
		this.string_10 = Conversions.ToString(this.method_7(ref ginterface5_2, GEnum9.JswAttr_ConfigMethods));
		this.bool_0 = Operators.ConditionalCompareObjectEqual(this.method_7(ref ginterface5_2, GEnum9.JswAttr_ConfigurationError), GEnum10.JswConfigError_SetupLocked, false);
		this.bool_2 = true;
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00010A44 File Offset: 0x0000EC44
	private void method_5(ref GInterface5 ginterface5_2)
	{
		if (ginterface5_2.imethod_1() != 0 && Operators.ConditionalCompareObjectEqual(ginterface5_2.imethod_0(GEnum9.JswAttr_VendorExtID), 14122, false))
		{
			byte[] array = new byte[1025];
			array = (byte[])ginterface5_2.imethod_0(GEnum9.JswAttr_Data);
			if (array[0] == 0)
			{
				int num = Conversions.ToInteger(Conversion.Hex(array[2]));
				this.string_7 = string.Format("{0}.{1}", (double)num / 10.0, (double)num - (double)num / 10.0 * 10.0);
			}
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x060002D5 RID: 725 RVA: 0x00010AF0 File Offset: 0x0000ECF0
	// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003FF7 File Offset: 0x000021F7
	public string SerialNumber
	{
		get
		{
			string result;
			if (!Class13.bool_1)
			{
				result = this.string_4;
			}
			else
			{
				result = Class13.smethod_13(this.string_4, "X");
			}
			return result;
		}
		set
		{
			this.string_4 = value;
		}
	}

	// Token: 0x1700013D RID: 317
	// (get) Token: 0x060002D7 RID: 727 RVA: 0x00010B20 File Offset: 0x0000ED20
	// (set) Token: 0x060002D8 RID: 728 RVA: 0x00004000 File Offset: 0x00002200
	public string UUID
	{
		get
		{
			string result;
			if (!Class13.bool_1)
			{
				result = this.string_6;
			}
			else
			{
				result = Class13.smethod_13(this.string_6, "X");
			}
			return result;
		}
		set
		{
			this.string_6 = value;
		}
	}

	// Token: 0x1700013E RID: 318
	// (get) Token: 0x060002D9 RID: 729 RVA: 0x00004009 File Offset: 0x00002209
	public string Version
	{
		get
		{
			return this.string_7;
		}
	}

	// Token: 0x1700013F RID: 319
	// (get) Token: 0x060002DA RID: 730 RVA: 0x00010B50 File Offset: 0x0000ED50
	public string BSSID
	{
		get
		{
			string result;
			if (!Class13.bool_1)
			{
				result = this.string_8;
			}
			else
			{
				result = this.string_8.Substring(0, 9) + "XX:XX:XX";
			}
			return result;
		}
	}

	// Token: 0x17000140 RID: 320
	// (get) Token: 0x060002DB RID: 731 RVA: 0x00010B88 File Offset: 0x0000ED88
	public string SSID
	{
		get
		{
			string result;
			if (!Class13.bool_1)
			{
				result = this.string_11;
			}
			else
			{
				result = Class13.smethod_13(this.string_11, "?");
			}
			return result;
		}
	}

	// Token: 0x17000141 RID: 321
	// (get) Token: 0x060002DC RID: 732 RVA: 0x00004011 File Offset: 0x00002211
	public string Channel
	{
		get
		{
			return this.string_12;
		}
	}

	// Token: 0x17000142 RID: 322
	// (get) Token: 0x060002DD RID: 733 RVA: 0x00004019 File Offset: 0x00002219
	public string RSSI
	{
		get
		{
			return this.int_0.ToString();
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x060002DE RID: 734 RVA: 0x00004026 File Offset: 0x00002226
	public bool ApSetupLocked
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x060002DF RID: 735 RVA: 0x0000402E File Offset: 0x0000222E
	// (set) Token: 0x060002E0 RID: 736 RVA: 0x00004036 File Offset: 0x00002236
	public GClass9.GEnum3 Status
	{
		get
		{
			return this.genum3_0;
		}
		set
		{
			this.genum3_0 = value;
			if (this.method_13())
			{
				this.method_12();
				return;
			}
			this.method_11();
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x060002E1 RID: 737 RVA: 0x00004054 File Offset: 0x00002254
	public GClass9.GEnum4 PinStatus
	{
		get
		{
			return this.genum4_0;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x060002E2 RID: 738 RVA: 0x00010BB8 File Offset: 0x0000EDB8
	// (set) Token: 0x060002E3 RID: 739 RVA: 0x0000405C File Offset: 0x0000225C
	public string NetworkKey
	{
		get
		{
			string result;
			if (!Class13.bool_1)
			{
				result = this.string_13;
			}
			else
			{
				result = Class13.smethod_13(this.string_13, "X");
			}
			return result;
		}
		set
		{
			this.string_13 = value;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x060002E4 RID: 740 RVA: 0x00004065 File Offset: 0x00002265
	public string PKE
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_14 = Class13.smethod_8((Array)this.ginterface5_1[4].imethod_0(GEnum9.JswAttr_PublicKey), ":");
			}
			return this.string_14;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000409E File Offset: 0x0000229E
	public string PKR
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_15 = Class13.smethod_8((Array)this.ginterface5_1[5].imethod_0(GEnum9.JswAttr_PublicKey), ":");
			}
			return this.string_15;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x060002E6 RID: 742 RVA: 0x000040D7 File Offset: 0x000022D7
	public string E_HAS1
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_16 = Class13.smethod_8((Array)this.ginterface5_1[7].imethod_0(GEnum9.JswAttr_E_Hash1), ":");
			}
			return this.string_16;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x060002E7 RID: 743 RVA: 0x00004110 File Offset: 0x00002310
	public string E_HAS2
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_17 = Class13.smethod_8((Array)this.ginterface5_1[7].imethod_0(GEnum9.JswAttr_E_Hash2), ":");
			}
			return this.string_17;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x060002E8 RID: 744 RVA: 0x00004149 File Offset: 0x00002349
	public string E_NONCE
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_18 = Class13.smethod_8((Array)this.ginterface5_1[4].imethod_0(GEnum9.JswAttr_EnrolleeNonce), ":");
			}
			return this.string_18;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x060002E9 RID: 745 RVA: 0x00004182 File Offset: 0x00002382
	public string R_NONCE
	{
		get
		{
			if (this.ginterface5_1[4] != null)
			{
				this.string_19 = Class13.smethod_8((Array)this.ginterface5_1[5].imethod_0(GEnum9.JswAttr_RegistrarNonce), ":");
			}
			return this.string_19;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x060002EA RID: 746 RVA: 0x00010BE8 File Offset: 0x0000EDE8
	public string AuthKey
	{
		get
		{
			string result;
			if (this.ginterface5_1[5] != null)
			{
				GInterface5 ginterface = (GInterface5)this.ginterface5_1[5].imethod_0(GEnum9.JswAttr_VendorExtension);
				object objectValue = RuntimeHelpers.GetObjectValue(this.method_7(ref ginterface, GEnum9.JswAttr_Data));
				object objectValue2 = RuntimeHelpers.GetObjectValue(this.method_7(ref this.ginterface5_1[5], GEnum9.JswAttr_PublicKey));
				result = Class13.smethod_9((Array)objectValue, (Array)objectValue2);
			}
			else
			{
				result = "";
			}
			return result;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x060002EB RID: 747 RVA: 0x000041BB File Offset: 0x000023BB
	// (set) Token: 0x060002EC RID: 748 RVA: 0x000041C3 File Offset: 0x000023C3
	public GClass12 Pin
	{
		get
		{
			return this.gclass12_0;
		}
		set
		{
			this.gclass12_0 = value;
			this.method_6();
			if (this.method_13())
			{
				this.method_12();
				return;
			}
			this.method_11();
		}
	}

	// Token: 0x060002ED RID: 749 RVA: 0x00010C60 File Offset: 0x0000EE60
	private void method_6()
	{
		try
		{
			if (!this.gclass15_0.Contains(this.gclass12_0))
			{
				this.gclass15_0.Add(this.gclass12_0);
			}
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060002EE RID: 750 RVA: 0x00010CB4 File Offset: 0x0000EEB4
	private object method_7(ref GInterface5 ginterface5_2, GEnum9 genum9_0)
	{
		string text = "";
		object result;
		try
		{
			IL_167:
			while (genum9_0 > GEnum9.JswAttr_MACAddress)
			{
				IL_15D:
				while (genum9_0 <= GEnum9.JswAttr_Version)
				{
					IL_150:
					object left2;
					while (genum9_0 != GEnum9.JswAttr_RFBand)
					{
						for (;;)
						{
							switch (genum9_0)
							{
							case GEnum9.JswAttr_UUID_E:
							case GEnum9.JswAttr_UUID_R:
								goto IL_7D3;
							case GEnum9.JswAttr_VendorExtension:
								goto IL_7F0;
							case GEnum9.JswAttr_Version:
								goto IL_7FE;
							default:
							{
								uint num;
								switch ((num = (num * 2304662080U ^ 4085628245U ^ 430986772U)) % 64U)
								{
								case 0U:
									goto IL_585;
								case 1U:
								case 17U:
								case 25U:
								case 35U:
									goto IL_7F0;
								case 2U:
									goto IL_15D;
								case 3U:
									goto IL_3B1;
								case 4U:
									goto IL_864;
								case 5U:
									goto IL_196;
								case 6U:
									goto IL_19C;
								case 7U:
									goto IL_171;
								case 8U:
									goto IL_402;
								case 9U:
									goto IL_181;
								case 10U:
									goto IL_5CB;
								case 11U:
									goto IL_18C;
								case 12U:
									goto IL_2FF;
								case 13U:
									goto IL_1D1;
								case 14U:
									goto IL_5C9;
								case 15U:
									goto IL_1DE;
								case 16U:
									goto IL_84C;
								case 18U:
									continue;
								case 20U:
									goto IL_672;
								case 21U:
									goto IL_838;
								case 22U:
									goto IL_88C;
								case 23U:
								case 63U:
									goto IL_167;
								case 24U:
									goto IL_884;
								case 26U:
									goto IL_874;
								case 27U:
									goto IL_251;
								case 28U:
									goto IL_150;
								case 29U:
									goto IL_7FE;
								case 30U:
									goto IL_81F;
								case 31U:
									goto IL_3CF;
								case 32U:
									goto IL_259;
								case 33U:
									goto IL_894;
								case 34U:
									goto IL_266;
								case 36U:
									goto IL_365;
								case 37U:
									goto IL_7D3;
								case 38U:
									goto IL_3A6;
								case 39U:
									goto IL_83E;
								case 40U:
									goto IL_29B;
								case 41U:
									goto IL_604;
								case 42U:
									goto IL_2CC;
								case 43U:
									goto IL_4AD;
								case 44U:
									goto IL_785;
								case 45U:
									goto IL_435;
								case 46U:
									goto IL_3C9;
								case 47U:
									goto IL_827;
								case 48U:
									goto IL_6A9;
								case 49U:
									goto IL_717;
								case 50U:
									goto IL_7EB;
								case 51U:
									goto IL_80E;
								case 52U:
									goto IL_39E;
								case 53U:
									goto IL_4B2;
								case 54U:
									goto IL_51E;
								case 55U:
									goto IL_842;
								case 56U:
									goto IL_63B;
								case 57U:
									goto IL_7CC;
								case 58U:
									goto IL_892;
								case 59U:
									goto IL_4EB;
								case 60U:
									goto IL_5D0;
								case 61U:
									goto IL_862;
								case 62U:
									goto IL_85C;
								}
								goto Block_3;
							}
							}
						}
						Block_3:
						goto IL_216;
						IL_7D3:
						result = Class13.smethod_8((Array)ginterface5_2.imethod_0(genum9_0), "");
						IL_7EB:
						return result;
						IL_7FE:
						text = "";
						object left = ginterface5_2.imethod_0(genum9_0);
						IL_80E:
						if (!Operators.ConditionalCompareObjectEqual(left, 16, false))
						{
							goto IL_827;
						}
						IL_81F:
						text = "1.0";
						goto IL_83E;
						IL_827:
						if (!Operators.ConditionalCompareObjectEqual(left, 17, false))
						{
							goto IL_83E;
						}
						IL_838:
						text = "1.1";
						IL_83E:
						return text;
						IL_84C:
						if (!Operators.ConditionalCompareObjectEqual(left2, 1, false))
						{
							goto IL_864;
						}
						IL_85C:
						result = "2.4 Ghz";
						IL_862:
						return result;
						IL_864:
						if (Operators.ConditionalCompareObjectEqual(left2, 2, false))
						{
							goto IL_894;
						}
						IL_874:
						if (Operators.ConditionalCompareObjectEqual(left2, 3, false))
						{
							goto IL_88C;
						}
						IL_884:
						return "";
						IL_88C:
						result = "2.4 Ghz, 5.0 Ghz";
						IL_892:
						return result;
						IL_894:
						return "5.0 Ghz";
					}
					goto IL_842;
					IL_171:
					if (genum9_0 != GEnum9.JswAttr_APSetupLocked)
					{
						goto IL_259;
					}
					IL_216:
					try
					{
						return Interaction.IIf(ginterface5_2.imethod_0(genum9_0) == null, false, true);
					}
					catch (Exception ex)
					{
						return false;
					}
					goto IL_251;
					IL_259:
					if (genum9_0 != GEnum9.JswAttr_Rssi)
					{
						goto IL_7F0;
					}
					IL_29B:
					return Interaction.IIf(Operators.ConditionalCompareObjectEqual(ginterface5_2.imethod_0(genum9_0), 0, false), "", RuntimeHelpers.GetObjectValue(ginterface5_2.imethod_0(genum9_0)));
					IL_842:
					left2 = ginterface5_2.imethod_0(genum9_0);
					goto IL_84C;
				}
				goto IL_171;
				IL_181:
				if (genum9_0 > GEnum9.JswAttr_ConfigMethods)
				{
					goto IL_39E;
				}
				IL_18C:
				if (genum9_0 != GEnum9.JswAttr_AuthenticationTypeFlags)
				{
					goto IL_1D1;
				}
				IL_196:
				text = "";
				IL_19C:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "OPEN, ", "")));
				goto IL_1DE;
				IL_1D1:
				if (genum9_0 != GEnum9.JswAttr_ConfigMethods)
				{
					goto IL_7F0;
				}
				goto IL_251;
				IL_1DE:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "WPA PSK, ", "")));
				goto IL_4EB;
				IL_251:
				text = "";
				IL_266:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "USBA, ", "")));
				IL_2CC:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "Ethernet, ", "")));
				IL_2FF:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "Label, ", "")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "Display, ", "")));
				IL_365:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16)), "Ext. NFC Token, ", "")));
				goto IL_4B2;
				IL_39E:
				if (genum9_0 == GEnum9.JswAttr_EncryptionTypeFlags)
				{
					goto IL_3C9;
				}
				IL_3A6:
				if (genum9_0 != GEnum9.JswAttr_MACAddress)
				{
					goto IL_7F0;
				}
				IL_3B1:
				return Class13.smethod_1((byte[])ginterface5_2.imethod_0(genum9_0));
				IL_3C9:
				text = "";
				IL_3CF:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1)), "None, ", "")));
				IL_402:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2)), "WEP, ", "")));
				IL_435:
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "TKIP, ", "")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "AES, ", "")));
				checked
				{
					text = text.Substring(0, text.Length - 2);
					result = text;
					IL_4AD:
					return result;
					IL_4B2:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 32)), "Int. NFC Token, ", "")));
					goto IL_5D0;
					IL_4EB:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4)), "SHARED, ", "")));
					IL_51E:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8)), "WPA, ", "")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16)), "WPA2, ", "")));
					IL_585:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 32)), "WPA2 PSK, ", "")));
					text = text.Substring(0, text.Length - 2);
					IL_5C9:
					result = text;
					IL_5CB:
					return result;
					IL_5D0:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 64)), "NFC Interface, ", "")));
					IL_604:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 128)), "PushButton, ", "")));
					IL_63B:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 256)), "Keypad, ", "")));
					IL_672:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 640)), "Virtual Push Button, ", "")));
					IL_6A9:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 1152)), "Physical Push Button, ", "")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 2176)), "(Reserved), ", "")));
					IL_717:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 4096)), "P2Ps Default Configuration Method, ", "")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 8200)), "Virtual Display PIN, ", "")));
					IL_785:
					text = Conversions.ToString(Operators.ConcatenateObject(text, Interaction.IIf(Conversions.ToBoolean(Operators.AndObject(ginterface5_2.imethod_0(genum9_0), 16392)), "Physical Display PIN, ", "")));
					text = text.Substring(0, text.Length - 2);
					IL_7CC:
					return text;
					IL_7F0:
					return ginterface5_2.imethod_0(genum9_0);
				}
			}
			goto IL_181;
		}
		catch (Exception ex2)
		{
			result = "";
		}
		return result;
	}

	// Token: 0x060002EF RID: 751 RVA: 0x000115A8 File Offset: 0x0000F7A8
	public virtual bool Equals(object obj)
	{
		GClass9 gclass = obj as GClass9;
		return gclass != null && gclass.BSSID.Equals(this.BSSID);
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x000041E7 File Offset: 0x000023E7
	public virtual int GetHashCode()
	{
		return this.BSSID.GetHashCode();
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x000115D8 File Offset: 0x0000F7D8
	private void method_8()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Select * From WPSPins where BSSID = @bssid", this.sqliteConnection_0);
		string value = this.string_8.Substring(0, 8);
		GClass15<GClass12> gclass = new GClass15<GClass12>();
		GClass15<GClass12> gclass2 = new GClass15<GClass12>();
		GClass15<GClass12> gclass3 = new GClass15<GClass12>();
		GClass15<GClass12> gclass4 = new GClass15<GClass12>();
		try
		{
			this.sqliteConnection_0.Open();
			sqliteCommand.Parameters.AddWithValue("@bssid", value);
			SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			while (sqliteDataReader.Read())
			{
				GClass11 gclass5 = new GClass11();
				gclass5.string_0 = sqliteDataReader["BSSID"].ToString();
				gclass5.string_1 = sqliteDataReader["SSID"].ToString();
				gclass5.string_2 = sqliteDataReader["Model"].ToString();
				gclass5.bool_0 = Conversions.ToBoolean(sqliteDataReader["PixieDust"]);
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["AlgorithmId"])))
				{
					gclass5.genum0_0 = (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"]);
				}
				GClass15<GClass12> gclass6 = new GClass15<GClass12>();
				this.bool_1 = gclass5.bool_0;
				if (gclass5.genum0_0 == GClass3.GEnum0.Nothing)
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["PIN"])))
					{
						foreach (string text in sqliteDataReader["PIN"].ToString().Split(new char[]
						{
							';'
						}))
						{
							gclass6.Add(new GClass12(text, GClass12.GEnum5.Generic, gclass5));
						}
					}
				}
				else
				{
					gclass6.Add(new GClass12(GClass3.smethod_25(this, (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"])), (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"]), gclass5));
				}
				if (!LikeOperator.LikeString(this.string_11.ToLower(), gclass5.string_1.ToLower(), CompareMethod.Binary))
				{
					if (LikeOperator.LikeString(this.string_2.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) | LikeOperator.LikeString(this.string_0.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) | LikeOperator.LikeString(this.string_3.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary))
					{
						gclass3.method_0(gclass6);
					}
				}
				else if (LikeOperator.LikeString(this.string_2.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) | LikeOperator.LikeString(this.string_0.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary) | LikeOperator.LikeString(this.string_3.ToLower(), "*" + gclass5.string_2.ToLower() + "*", CompareMethod.Binary))
				{
					gclass4.method_0(gclass6);
				}
				else
				{
					gclass2.method_0(gclass6);
				}
			}
			if (gclass4.Count <= 0)
			{
				if (gclass2.Count > 0)
				{
					this.gclass15_0.method_0(gclass2);
				}
				else if (gclass3.Count > 0)
				{
					this.gclass15_0.method_0(gclass3);
				}
				else if (gclass.Count > 0)
				{
					this.gclass15_0.method_0(gclass);
				}
			}
			else
			{
				this.gclass15_0.method_0(gclass4);
			}
			sqliteDataReader.Close();
			sqliteCommand.Dispose();
			this.sqliteConnection_0.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DB GetPins", MessageBoxButtons.OK);
			this.sqliteConnection_0.Close();
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x000119C4 File Offset: 0x0000FBC4
	private void method_9()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Select * From WPSPins where @DeviceName Like DeviceName and @modelname Like ModelName and @modelnumber Like ModelNumber", this.sqliteConnection_1);
		this.string_8.Substring(0, 8);
		new GClass15<GClass12>();
		new GClass15<GClass12>();
		new GClass15<GClass12>();
		new GClass15<GClass12>();
		try
		{
			this.sqliteConnection_1.Open();
			if (LikeOperator.LikeString(this.string_11, "MOVISTAR*", CompareMethod.Binary))
			{
				this.string_11 = this.string_11;
			}
			sqliteCommand.Parameters.AddWithValue("@DeviceName", this.string_0);
			sqliteCommand.Parameters.AddWithValue("@ModelName", this.string_2);
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", this.string_3);
			SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			while (sqliteDataReader.Read())
			{
				GClass11 gclass = new GClass11();
				gclass.string_0 = sqliteDataReader["BSSID"].ToString();
				gclass.string_2 = sqliteDataReader["ModelName"].ToString();
				gclass.string_3 = sqliteDataReader["ModelNumber"].ToString();
				gclass.string_4 = sqliteDataReader["DeviceName"].ToString();
				gclass.bool_0 = Conversions.ToBoolean(sqliteDataReader["PixieDust"]);
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["AlgorithmId"])))
				{
					gclass.genum0_0 = (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"]);
				}
				GClass15<GClass12> gclass2 = new GClass15<GClass12>();
				this.bool_1 = gclass.bool_0;
				if (gclass.genum0_0 != GClass3.GEnum0.Nothing)
				{
					gclass2.Add(new GClass12(GClass3.smethod_25(this, (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"])), (GClass3.GEnum0)Conversions.ToInteger(sqliteDataReader["AlgorithmId"]), gclass));
				}
				else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["PIN"])))
				{
					foreach (string left in sqliteDataReader["PIN"].ToString().Split(new char[]
					{
						';'
					}))
					{
						if (Operators.CompareString(left, "", false) != 0)
						{
							gclass2.Add(new GClass12(left, GClass12.GEnum5.Generic, gclass));
						}
					}
				}
				this.gclass15_0.method_0(gclass2);
			}
			sqliteDataReader.Close();
			sqliteCommand.Dispose();
			this.sqliteConnection_1.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DB GetProbePins", MessageBoxButtons.OK);
			this.sqliteConnection_1.Close();
		}
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00011C60 File Offset: 0x0000FE60
	public void method_10()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Select * From Networks where BSSID = @bssid", this.sqliteConnection_2);
		try
		{
			this.sqliteConnection_2.Open();
			sqliteCommand.Parameters.AddWithValue("@bssid", this.string_8);
			SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			if (sqliteDataReader.Read())
			{
				this.string_0 = sqliteDataReader["DeviceName"].ToString();
				this.string_1 = sqliteDataReader["Manufacturer"].ToString();
				this.string_2 = sqliteDataReader["ModelName"].ToString();
				this.string_3 = sqliteDataReader["ModelNumber"].ToString();
				this.string_4 = sqliteDataReader["SerialNumber"].ToString();
				this.string_5 = sqliteDataReader["RFBand"].ToString();
				this.string_6 = sqliteDataReader["UUID"].ToString();
				this.string_7 = sqliteDataReader["Version"].ToString();
				this.string_9 = sqliteDataReader["Encryption"].ToString();
				this.string_10 = sqliteDataReader["ConfigMethods"].ToString();
				this.genum3_0 = (GClass9.GEnum3)Conversions.ToInteger(sqliteDataReader["Status"]);
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["Pin"])) && Operators.CompareString(sqliteDataReader["Pin"].ToString(), "", false) != 0)
				{
					this.gclass12_0 = new GClass12(sqliteDataReader["Pin"].ToString(), (GClass12.GEnum5)Conversions.ToInteger(sqliteDataReader["DecryptMode"]));
				}
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqliteDataReader["Key"])) && Operators.CompareString(sqliteDataReader["Key"].ToString(), "", false) != 0)
				{
					this.string_13 = sqliteDataReader["Key"].ToString();
				}
			}
			sqliteDataReader.Close();
			sqliteCommand.Dispose();
			this.sqliteConnection_2.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DB GetApLog", MessageBoxButtons.OK);
			this.sqliteConnection_0.Close();
		}
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00011EB0 File Offset: 0x000100B0
	public void method_11()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Insert into Networks values(@BSSID,\r\n                                                                      @SSID,\r\n                                                                      @DeviceName,\r\n                                                                      @Manufacturer,\r\n                                                                      @ModelName,\r\n                                                                      @ModelNumber,\r\n                                                                      @SerialNumber,\r\n                                                                      @RFBand,\r\n                                                                      @UUID,\r\n                                                                      @Version,\r\n                                                                      @Encryption,\r\n                                                                      @ConfigMethods,\r\n                                                                      @Pin,\r\n                                                                      @Key,\r\n                                                                      @DecryptMode,\r\n                                                                      @Know,\r\n                                                                      @Status)", this.sqliteConnection_2);
		try
		{
			this.sqliteConnection_2.Open();
			sqliteCommand.Parameters.AddWithValue("@BSSID", this.string_8);
			sqliteCommand.Parameters.AddWithValue("@SSID", this.string_11);
			sqliteCommand.Parameters.AddWithValue("@DeviceName", this.string_0);
			sqliteCommand.Parameters.AddWithValue("@Manufacturer", this.string_1);
			sqliteCommand.Parameters.AddWithValue("@ModelName", this.string_2);
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", this.string_3);
			sqliteCommand.Parameters.AddWithValue("@SerialNumber", this.string_4);
			sqliteCommand.Parameters.AddWithValue("@RFBand", this.string_5);
			sqliteCommand.Parameters.AddWithValue("@UUID", this.string_6);
			sqliteCommand.Parameters.AddWithValue("@Version", this.string_7);
			sqliteCommand.Parameters.AddWithValue("@Encryption", this.string_9);
			sqliteCommand.Parameters.AddWithValue("@ConfigMethods", this.string_10);
			sqliteCommand.Parameters.AddWithValue("@Pin", this.gclass12_0.Pin);
			sqliteCommand.Parameters.AddWithValue("@Key", this.string_13);
			sqliteCommand.Parameters.AddWithValue("@DecryptMode", this.gclass12_0.Type);
			sqliteCommand.Parameters.AddWithValue("@Know", 0);
			sqliteCommand.Parameters.AddWithValue("@Status", this.genum3_0);
			sqliteCommand.ExecuteNonQuery();
			sqliteCommand.Dispose();
			this.sqliteConnection_2.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DB InsertAp", MessageBoxButtons.OK);
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x000120CC File Offset: 0x000102CC
	public void method_12()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Update Networks set SSID=@SSID,\r\n                                          DeviceName=@DeviceName,\r\n                                          Manufacturer=@Manufacturer,\r\n                                          ModelName=@ModelName,\r\n                                          ModelNumber=@ModelNumber,\r\n                                          SerialNumber=@SerialNumber,\r\n                                          RFBand=@RFBand,\r\n                                          UUID=@UUID,\r\n                                          Version=@Version,\r\n                                          Encryption=@Encryption,\r\n                                          ConfigMethods=@ConfigMethods,\r\n                                          Pin=@Pin,\r\n                                          Key=@Key,\r\n                                          DecryptMode=@DecryptMode,\r\n                                          Know=@Know,\r\n                                          Status=@Status \r\n                                          where BSSID=@BSSID", this.sqliteConnection_2);
		try
		{
			this.sqliteConnection_2.Open();
			sqliteCommand.Parameters.AddWithValue("@BSSID", this.string_8);
			sqliteCommand.Parameters.AddWithValue("@SSID", this.string_11);
			sqliteCommand.Parameters.AddWithValue("@DeviceName", this.string_0);
			sqliteCommand.Parameters.AddWithValue("@Manufacturer", this.string_1);
			sqliteCommand.Parameters.AddWithValue("@ModelName", this.string_2);
			sqliteCommand.Parameters.AddWithValue("@ModelNumber", this.string_3);
			sqliteCommand.Parameters.AddWithValue("@SerialNumber", this.string_4);
			sqliteCommand.Parameters.AddWithValue("@RFBand", this.string_5);
			sqliteCommand.Parameters.AddWithValue("@UUID", this.string_6);
			sqliteCommand.Parameters.AddWithValue("@Version", this.string_7);
			sqliteCommand.Parameters.AddWithValue("@Encryption", this.string_9);
			sqliteCommand.Parameters.AddWithValue("@ConfigMethods", this.string_10);
			sqliteCommand.Parameters.AddWithValue("@Pin", this.gclass12_0.Pin);
			sqliteCommand.Parameters.AddWithValue("@Key", this.string_13);
			sqliteCommand.Parameters.AddWithValue("@DecryptMode", this.gclass12_0.Type);
			sqliteCommand.Parameters.AddWithValue("@Know", 0);
			sqliteCommand.Parameters.AddWithValue("@Status", this.genum3_0);
			sqliteCommand.ExecuteNonQuery();
			sqliteCommand.Dispose();
			this.sqliteConnection_2.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "DB UpdateAp", MessageBoxButtons.OK);
		}
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x000122E8 File Offset: 0x000104E8
	public bool method_13()
	{
		SQLiteCommand sqliteCommand = new SQLiteCommand("Select * From Networks where BSSID = @bssid", this.sqliteConnection_2);
		bool result = false;
		try
		{
			this.sqliteConnection_2.Open();
			sqliteCommand.Parameters.AddWithValue("@bssid", this.string_8);
			SQLiteDataReader sqliteDataReader = sqliteCommand.ExecuteReader();
			result = sqliteDataReader.Read();
			sqliteDataReader.Close();
			sqliteCommand.Dispose();
			this.sqliteConnection_2.Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Is Ap in Db", MessageBoxButtons.OK);
			this.sqliteConnection_0.Close();
		}
		return result;
	}

	// Token: 0x04000112 RID: 274
	[CompilerGenerated]
	private PropertyChangedEventHandler propertyChangedEventHandler_0;

	// Token: 0x04000113 RID: 275
	public GInterface5 ginterface5_0;

	// Token: 0x04000114 RID: 276
	public GInterface5[] ginterface5_1;

	// Token: 0x04000115 RID: 277
	public string string_0;

	// Token: 0x04000116 RID: 278
	public string string_1;

	// Token: 0x04000117 RID: 279
	public string string_2;

	// Token: 0x04000118 RID: 280
	public string string_3;

	// Token: 0x04000119 RID: 281
	private string string_4;

	// Token: 0x0400011A RID: 282
	public string string_5;

	// Token: 0x0400011B RID: 283
	private string string_6;

	// Token: 0x0400011C RID: 284
	private string string_7;

	// Token: 0x0400011D RID: 285
	private bool bool_0;

	// Token: 0x0400011E RID: 286
	private string string_8;

	// Token: 0x0400011F RID: 287
	public string string_9;

	// Token: 0x04000120 RID: 288
	public string string_10;

	// Token: 0x04000121 RID: 289
	private string string_11;

	// Token: 0x04000122 RID: 290
	private int int_0;

	// Token: 0x04000123 RID: 291
	private string string_12;

	// Token: 0x04000124 RID: 292
	public GClass15<GClass12> gclass15_0;

	// Token: 0x04000125 RID: 293
	public bool bool_1;

	// Token: 0x04000126 RID: 294
	private string string_13;

	// Token: 0x04000127 RID: 295
	private GClass12 gclass12_0;

	// Token: 0x04000128 RID: 296
	private string string_14;

	// Token: 0x04000129 RID: 297
	private string string_15;

	// Token: 0x0400012A RID: 298
	private string string_16;

	// Token: 0x0400012B RID: 299
	private string string_17;

	// Token: 0x0400012C RID: 300
	private string string_18;

	// Token: 0x0400012D RID: 301
	private string string_19;

	// Token: 0x0400012E RID: 302
	private string string_20;

	// Token: 0x0400012F RID: 303
	private GClass9.GEnum3 genum3_0;

	// Token: 0x04000130 RID: 304
	private GClass9.GEnum4 genum4_0;

	// Token: 0x04000131 RID: 305
	private bool bool_2;

	// Token: 0x04000132 RID: 306
	private SQLiteConnection sqliteConnection_0;

	// Token: 0x04000133 RID: 307
	private SQLiteConnection sqliteConnection_1;

	// Token: 0x04000134 RID: 308
	private SQLiteConnection sqliteConnection_2;

	// Token: 0x02000025 RID: 37
	public enum GEnum3
	{
		// Token: 0x04000136 RID: 310
		Unknow,
		// Token: 0x04000137 RID: 311
		Ok,
		// Token: 0x04000138 RID: 312
		Nok
	}

	// Token: 0x02000026 RID: 38
	public enum GEnum4
	{
		// Token: 0x0400013A RID: 314
		Nothing,
		// Token: 0x0400013B RID: 315
		Single,
		// Token: 0x0400013C RID: 316
		Several,
		// Token: 0x0400013D RID: 317
		Algorithm
	}
}
