using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut.My
{
	// Token: 0x0200000A RID: 10
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class MySettings : ApplicationSettingsBase
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000329C File Offset: 0x0000149C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void smethod_0(object sender, EventArgs e)
		{
			if (Class6.Form0_0.SaveMySettingsOnExit)
			{
				MySettings.Default.Save();
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00004D34 File Offset: 0x00002F34
		public static MySettings Default
		{
			get
			{
				if (!MySettings.bool_0)
				{
					object obj = MySettings.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (!MySettings.bool_0)
						{
							Class6.Form0_0.Shutdown += MySettings.smethod_0;
							MySettings.bool_0 = true;
						}
					}
				}
				return MySettings.mySettings_0;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000032B4 File Offset: 0x000014B4
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000032C6 File Offset: 0x000014C6
		[UserScopedSetting]
		[DefaultSettingValue("01/31/2017 21:23:00")]
		[DebuggerNonUserCode]
		public DateTime LastDateNewsWatched
		{
			get
			{
				return Conversions.ToDate(this["LastDateNewsWatched"]);
			}
			set
			{
				this["LastDateNewsWatched"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000032D9 File Offset: 0x000014D9
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000032EB File Offset: 0x000014EB
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public int ServiceHours
		{
			get
			{
				return Conversions.ToInteger(this["ServiceHours"]);
			}
			set
			{
				this["ServiceHours"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000032FE File Offset: 0x000014FE
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00003310 File Offset: 0x00001510
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int nRigth
		{
			get
			{
				return Conversions.ToInteger(this["nRigth"]);
			}
			set
			{
				this["nRigth"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003323 File Offset: 0x00001523
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00003335 File Offset: 0x00001535
		[UserScopedSetting]
		[DefaultSettingValue("0")]
		[DebuggerNonUserCode]
		public int nWrong
		{
			get
			{
				return Conversions.ToInteger(this["nWrong"]);
			}
			set
			{
				this["nWrong"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000335A File Offset: 0x0000155A
		[DefaultSettingValue("01/31/1990 21:42:00")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public DateTime LastDateOnlineNews
		{
			get
			{
				return Conversions.ToDate(this["LastDateOnlineNews"]);
			}
			set
			{
				this["LastDateOnlineNews"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000336D File Offset: 0x0000156D
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000337F File Offset: 0x0000157F
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string Culture
		{
			get
			{
				return Conversions.ToString(this["Culture"]);
			}
			set
			{
				this["Culture"] = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000338D File Offset: 0x0000158D
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000339F File Offset: 0x0000159F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool mbl
		{
			get
			{
				return Conversions.ToBoolean(this["mbl"]);
			}
			set
			{
				this["mbl"] = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060000CC RID: 204 RVA: 0x000033B2 File Offset: 0x000015B2
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000033C4 File Offset: 0x000015C4
		[DebuggerNonUserCode]
		[DefaultSettingValue("2016-02-20")]
		[UserScopedSetting]
		public DateTime StartTime
		{
			get
			{
				return Conversions.ToDate(this["StartTime"]);
			}
			set
			{
				this["StartTime"] = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000033D7 File Offset: 0x000015D7
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000033E9 File Offset: 0x000015E9
		[DebuggerNonUserCode]
		[DefaultSettingValue("6")]
		[UserScopedSetting]
		public int ScanTime
		{
			get
			{
				return Conversions.ToInteger(this["ScanTime"]);
			}
			set
			{
				this["ScanTime"] = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000033FC File Offset: 0x000015FC
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000340E File Offset: 0x0000160E
		[UserScopedSetting]
		[DefaultSettingValue("01/31/1990 21:42:00")]
		[DebuggerNonUserCode]
		public DateTime LastDBDate
		{
			get
			{
				return Conversions.ToDate(this["LastDBDate"]);
			}
			set
			{
				this["LastDBDate"] = value;
			}
		}

		// Token: 0x04000012 RID: 18
		private static MySettings mySettings_0 = (MySettings)SettingsBase.Synchronized(new MySettings());

		// Token: 0x04000013 RID: 19
		private static bool bool_0;

		// Token: 0x04000014 RID: 20
		private static object object_0 = RuntimeHelpers.GetObjectValue(new object());
	}
}
