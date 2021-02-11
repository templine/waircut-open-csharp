using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using wAirCut;

// Token: 0x02000010 RID: 16
[StandardModule]
public sealed class GClass3
{
	// Token: 0x06000169 RID: 361 RVA: 0x000075F0 File Offset: 0x000057F0
	public static int smethod_0(int int_0)
	{
		int num = 0;
		checked
		{
			if (int_0 > 9999999)
			{
				int_0 = (int)Math.Round((double)int_0 / 10.0);
			}
			while (int_0 != 0)
			{
				num += 3 * (int_0 % 10);
				int_0 /= 10;
				num += int_0 % 10;
				int_0 /= 10;
			}
			return (10 - num % 10) % 10;
		}
	}

	// Token: 0x0600016A RID: 362 RVA: 0x0000764C File Offset: 0x0000584C
	public static string smethod_1(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		int num = Convert.ToInt32(array[3] + array[4] + array[5], 16);
		num %= 10000000;
		return num.ToString("D7") + GClass3.smethod_0(num).ToString();
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00003952 File Offset: 0x00001B52
	public static string smethod_2()
	{
		return "";
	}

	// Token: 0x0600016C RID: 364 RVA: 0x000076B4 File Offset: 0x000058B4
	public static string smethod_3(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		string text = checked(Conversions.ToString((Convert.ToInt32(array[0], 16) + Convert.ToInt32(array[1], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[1], 16) + Convert.ToInt32(array[2], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[2], 16) + Convert.ToInt32(array[3], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[3], 16) + Convert.ToInt32(array[4], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[4], 16) + Convert.ToInt32(array[5], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[5], 16) + Convert.ToInt32(array[0], 16)) % 10) + Conversions.ToString((Convert.ToInt32(array[0], 16) + Convert.ToInt32(array[1], 16)) % 10));
		return text + GClass3.smethod_0(Convert.ToInt32(text)).ToString();
	}

	// Token: 0x0600016D RID: 365 RVA: 0x000077DC File Offset: 0x000059DC
	public static object smethod_4(string string_0)
	{
		int num = Convert.ToInt32(string_0.Replace(":", "").Substring(6, 6), 16) ^ 5614165;
		num ^= checked(((num & 15) << 4) + ((num & 15) << 8) + ((num & 15) << 12) + ((num & 15) << 16) + ((num & 15) << 20));
		string text = (num % 10000000).ToString().PadLeft(7, '0');
		return text + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text)));
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00007864 File Offset: 0x00005A64
	public static string smethod_5(string string_0)
	{
		string text = string_0.Replace(":", "");
		string text2 = Convert.ToInt32(text.Substring(8, 4), 16).ToString("00000");
		byte[] array = new byte[12];
		int num = 0;
		byte[] array2;
		checked
		{
			do
			{
				array[num] = (byte)Convert.ToInt32(text.Substring(num, 1), 16);
				num++;
			}
			while (num <= 11);
			array2 = new byte[5];
			int num2 = 0;
			do
			{
				array2[num2] = (byte)Convert.ToInt32(text2.Substring(num2, 1), 16);
				num2++;
			}
			while (num2 <= 4);
		}
		int num3 = (int)((array2[1] + array2[2] + array[10] + array[11]) % 16);
		int num4 = (int)((array2[3] + array2[4] + array[8] + array[9]) % 16);
		checked
		{
			byte[] array3 = new byte[]
			{
				(byte)((num3 ^ (int)array2[4]) % 16),
				(byte)((num3 ^ (int)array2[3]) % 16),
				(byte)((num4 ^ (int)array[9]) % 16),
				(byte)((num4 ^ (int)array[10]) % 16),
				(array[10] ^ array2[4]) % 16,
				(array[11] ^ array2[3]) % 16,
				(byte)((num3 ^ (int)array2[2]) % 16)
			};
			string text3 = "";
			int num5 = 0;
			do
			{
				text3 += Conversion.Hex(array3[num5]);
				num5++;
			}
			while (num5 <= 6);
			text3 = (Convert.ToInt32(text3, 16) % 10000000).ToString();
			text3 += Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text3.PadLeft(7, '0'))));
			return text3.PadLeft(8, '0');
		}
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00007A20 File Offset: 0x00005C20
	public static string smethod_6(string string_0, string string_1)
	{
		checked
		{
			string result;
			if (string_1.Length >= 10 && Versioned.IsNumeric(string_1.Substring(1, 9)))
			{
				string text = string_0.Replace(":", "");
				ulong value = (ulong)Convert.ToInt64(text, 16);
				text = Convert.ToUInt64(decimal.Subtract(new decimal(value), 2m)).ToString("X12");
				string text2 = string_1.Substring(1, 9);
				byte[] array = new byte[12];
				int num = 0;
				do
				{
					array[11 - num] = (byte)Convert.ToInt32(text.Substring(num, 1), 16);
					num++;
				}
				while (num <= 11);
				byte[] array2 = new byte[9];
				int num2 = 0;
				do
				{
					array2[8 - num2] = (byte)Convert.ToInt32(text2.Substring(num2, 1), 16);
					num2++;
				}
				while (num2 <= 8);
				int num3;
				int num4;
				unchecked
				{
					num3 = (int)((array2[2] + array2[3] + array[0] + array[1]) % 16);
					num4 = (int)((array2[0] + array2[1] + array[2] + array[3]) % 16);
				}
				byte[] array3 = new byte[]
				{
					(byte)((num3 ^ (int)array2[0]) % 16),
					(byte)((num3 ^ (int)array2[1]) % 16),
					(byte)((num4 ^ (int)array[2]) % 16),
					(byte)((num4 ^ (int)array[1]) % 16),
					(array[1] ^ array2[0]) % 16,
					(array[0] ^ array2[1]) % 16,
					(byte)((num3 ^ (int)array2[2]) % 16)
				};
				string text3 = "";
				int num5 = 0;
				do
				{
					text3 += Conversion.Hex(array3[num5]);
					num5++;
				}
				while (num5 <= 6);
				text3 = (Convert.ToInt32(text3, 16) % 10000000).ToString();
				text3 += Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text3.PadLeft(7, '0'))));
				result = text3.PadLeft(8, '0');
			}
			else
			{
				result = "";
			}
			return result;
		}
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00007C2C File Offset: 0x00005E2C
	public static string smethod_7(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		string text = Convert.ToInt32(array[5] + array[4] + array[3], 16).ToString().PadLeft(7, '0');
		string text2 = text.Substring(checked(text.Length - 7), 7);
		return text2 + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text2)));
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00007C9C File Offset: 0x00005E9C
	public static string[] smethod_8(string string_0)
	{
		string[] array = new string[]
		{
			"00000000",
			"00000000",
			"00000000"
		};
		int num = Convert.ToInt32(string_0.Replace(":", "").Substring(6, 6), 16) % 10000000;
		array[0] = num.ToString("0000000");
		string[] array2 = array;
		int num2 = 0;
		ref string ptr = ref array2[num2];
		array2[num2] = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array[0])));
		checked
		{
			array[1] = (num + 8).ToString("0000000");
			string[] array3 = array;
			int num3 = 1;
			ptr = ref array3[num3];
			array3[num3] = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array[1])));
			array[2] = (num + 14).ToString("0000000");
			string[] array4 = array;
			int num4 = 2;
			ptr = ref array4[num4];
			array4[num4] = ptr + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(array[2])));
			return array;
		}
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00007D90 File Offset: 0x00005F90
	public static string smethod_9(string string_0, string string_1)
	{
		string text = (checked(Convert.ToInt32(string_0.Replace(":", "").Substring(6, 4) + string_1.Substring(6, 2), 16) % 10000000 + 7)).ToString("0000000");
		return (text + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text)))).PadLeft(7, '0');
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00007DFC File Offset: 0x00005FFC
	public static string smethod_10(string string_0)
	{
		string text = string_0.Replace(":", "");
		int[] array = new int[6];
		byte[] array2 = new byte[8];
		string text2 = "";
		int num = 0;
		checked
		{
			do
			{
				array[num] = Convert.ToInt32(text.Substring(num * 2, 2), 16);
				num++;
			}
			while (num <= 5);
			int num2 = 0;
			do
			{
				array2[num2] = (byte)((array[num2 % 6] + array[5]) % (10 - (num2 + array[1] + array[2] + array[3] + array[4] + array[5]) % 7));
				text2 += array2[num2].ToString("X1");
				num2++;
			}
			while (num2 <= 7);
			text2 = text2.ToString().PadLeft(7, '0');
			text2 = text2.Substring(0, 7);
			return text2 + Conversions.ToString(GClass3.smethod_0(Conversions.ToInteger(text2)));
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00007EDC File Offset: 0x000060DC
	public static string smethod_11(string string_0)
	{
		ulong num = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		num = checked((ulong)(((long)num & 16777215L) % 10000000L));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(num), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(num.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00007F64 File Offset: 0x00006164
	public static string smethod_12(string string_0)
	{
		ulong num = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		num = checked((ulong)(((long)num & 268435455L) % 10000000L));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(num), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(num.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x06000176 RID: 374 RVA: 0x00007FEC File Offset: 0x000061EC
	public static string smethod_13(string string_0)
	{
		ulong value = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		value = Convert.ToUInt64(decimal.Remainder(decimal.Remainder(new decimal(value), 4294967296m), 10000000m));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(value), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x06000177 RID: 375 RVA: 0x0000808C File Offset: 0x0000628C
	public static string smethod_14(string string_0)
	{
		ulong value = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		value = Convert.ToUInt64(decimal.Remainder(decimal.Remainder(new decimal(value), 68719476736m), 10000000m));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(value), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x06000178 RID: 376 RVA: 0x0000812C File Offset: 0x0000632C
	public static string smethod_15(string string_0)
	{
		ulong value = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		value = Convert.ToUInt64(decimal.Remainder(decimal.Remainder(new decimal(value), 1099511627776m), 10000000m));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(value), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x06000179 RID: 377 RVA: 0x000081D0 File Offset: 0x000063D0
	public static string smethod_16(string string_0)
	{
		ulong value = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		value = Convert.ToUInt64(decimal.Remainder(decimal.Remainder(new decimal(value), 17592186044416m), 10000000m));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(value), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00008274 File Offset: 0x00006474
	public static string smethod_17(string string_0)
	{
		ulong value = Convert.ToUInt64(string_0.Replace(":", ""), 16);
		value = Convert.ToUInt64(decimal.Remainder(decimal.Remainder(new decimal(value), 281474976710656m), 10000000m));
		return Convert.ToUInt64(decimal.Add(decimal.Multiply(new decimal(value), 10m), new decimal(GClass3.smethod_0(Conversions.ToInteger(value.ToString("0000000")))))).ToString("00000000");
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00008318 File Offset: 0x00006518
	public static string smethod_18(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		ulong num = Convert.ToUInt64(array[5] + array[4] + array[3], 16);
		num = Convert.ToUInt64(decimal.Remainder(new decimal(num), 10000000m));
		return num.ToString("D7") + GClass3.smethod_0(checked((int)num)).ToString();
	}

	// Token: 0x0600017C RID: 380 RVA: 0x000083A0 File Offset: 0x000065A0
	public static string smethod_19(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		ulong num = Convert.ToUInt64(array[5] + array[4] + array[3] + array[2], 16);
		num = Convert.ToUInt64(decimal.Remainder(new decimal(num), 10000000m));
		return num.ToString("D7") + GClass3.smethod_0(checked((int)num)).ToString();
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00008428 File Offset: 0x00006628
	public static string smethod_20(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		ulong num = Convert.ToUInt64(string.Concat(new string[]
		{
			array[5],
			array[4],
			array[3],
			array[2],
			array[1],
			array[0]
		}), 16);
		num = Convert.ToUInt64(decimal.Remainder(new decimal(num), 10000000m));
		return num.ToString("D7") + GClass3.smethod_0(checked((int)num)).ToString();
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00003959 File Offset: 0x00001B59
	public static string smethod_21(string string_0)
	{
		return GClass3.smethod_18(GClass3.smethod_24(string_0));
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00003966 File Offset: 0x00001B66
	public static string smethod_22(string string_0)
	{
		return GClass3.smethod_19(GClass3.smethod_24(string_0));
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00003973 File Offset: 0x00001B73
	public static string smethod_23(string string_0)
	{
		return GClass3.smethod_20(GClass3.smethod_24(string_0));
	}

	// Token: 0x06000181 RID: 385 RVA: 0x000084D0 File Offset: 0x000066D0
	private static string smethod_24(string string_0)
	{
		string[] array = new string[7];
		array = string_0.Split(new char[]
		{
			':'
		});
		int num = 0;
		checked
		{
			do
			{
				array[num] = string.Join<char>("", array[num].Reverse<char>());
				num++;
			}
			while (num <= 5);
			return string.Join(":", array);
		}
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00008524 File Offset: 0x00006724
	public static string smethod_25(GClass9 gclass9_0, GClass3.GEnum0 genum0_0)
	{
		string result = "";
		for (;;)
		{
			IL_BE:
			switch (genum0_0)
			{
			case GClass3.GEnum0.ZAO:
				goto IL_121;
			case GClass3.GEnum0.FTE:
				goto IL_132;
			case GClass3.GEnum0.EasyBox:
				goto IL_149;
			case GClass3.GEnum0.dLINK:
				goto IL_15A;
			case GClass3.GEnum0.TrendNet:
				goto IL_170;
			case GClass3.GEnum0.AiroConru:
				goto IL_181;
			case GClass3.GEnum0.Asus:
				goto IL_192;
			case GClass3.GEnum0.LiveBox:
				goto IL_1A3;
			case GClass3.GEnum0.PinNull:
				goto IL_1BA;
			case (GClass3.GEnum0)9:
				return result;
			case GClass3.GEnum0.d28bit:
				goto IL_1C5;
			case GClass3.GEnum0.d32bit:
				goto IL_1D6;
			case GClass3.GEnum0.d36bit:
				goto IL_1E7;
			case GClass3.GEnum0.d40bit:
				goto IL_1F5;
			case GClass3.GEnum0.d44bit:
				goto IL_203;
			case GClass3.GEnum0.d48bit:
				goto IL_211;
			case GClass3.GEnum0.d24rhbit:
				goto IL_21F;
			case GClass3.GEnum0.d32rhbit:
				goto IL_22D;
			case GClass3.GEnum0.d48rhbit:
				goto IL_23B;
			case GClass3.GEnum0.d24rnbit:
				goto IL_249;
			case GClass3.GEnum0.d32rnbit:
				goto IL_257;
			case GClass3.GEnum0.d48rnbit:
				goto IL_265;
			default:
			{
				uint num2;
				uint num = num2 * 3824409724U ^ 3255173091U;
				for (;;)
				{
					switch ((num2 = (num ^ 3197202444U)) % 32U)
					{
					case 0U:
						goto IL_203;
					case 2U:
						goto IL_1BA;
					case 3U:
						goto IL_21F;
					case 4U:
						goto IL_1D6;
					case 5U:
						goto IL_181;
					case 6U:
						goto IL_121;
					case 8U:
						goto IL_1C5;
					case 9U:
						goto IL_249;
					case 10U:
						goto IL_22D;
					case 11U:
						goto IL_15A;
					case 12U:
						goto IL_211;
					case 13U:
					case 18U:
						goto IL_BE;
					case 14U:
						goto IL_149;
					case 16U:
						goto IL_1E7;
					case 17U:
						goto IL_170;
					case 19U:
						goto IL_192;
					case 21U:
						goto IL_257;
					case 23U:
						num = (num2 * 3880420547U ^ 2093315112U);
						continue;
					case 24U:
						goto IL_23B;
					case 26U:
						goto IL_1A3;
					case 27U:
						goto IL_265;
					case 29U:
						goto IL_132;
					case 30U:
						goto IL_1F5;
					}
					goto Block_1;
				}
				break;
			}
			}
		}
		Block_1:
		return result;
		IL_121:
		return GClass3.smethod_1(gclass9_0.BSSID);
		IL_132:
		return GClass3.smethod_9(gclass9_0.BSSID, gclass9_0.SSID);
		IL_149:
		return GClass3.smethod_5(gclass9_0.BSSID);
		IL_15A:
		return Conversions.ToString(GClass3.smethod_4(gclass9_0.BSSID));
		IL_170:
		return GClass3.smethod_7(gclass9_0.BSSID);
		IL_181:
		return GClass3.smethod_3(gclass9_0.BSSID);
		IL_192:
		return GClass3.smethod_10(gclass9_0.BSSID);
		IL_1A3:
		return GClass3.smethod_6(gclass9_0.BSSID, gclass9_0.SerialNumber);
		IL_1BA:
		return GClass3.smethod_2();
		IL_1C5:
		return GClass3.smethod_12(gclass9_0.BSSID);
		IL_1D6:
		return GClass3.smethod_13(gclass9_0.BSSID);
		IL_1E7:
		return GClass3.smethod_14(gclass9_0.BSSID);
		IL_1F5:
		return GClass3.smethod_15(gclass9_0.BSSID);
		IL_203:
		return GClass3.smethod_16(gclass9_0.BSSID);
		IL_211:
		return GClass3.smethod_17(gclass9_0.BSSID);
		IL_21F:
		return GClass3.smethod_18(gclass9_0.BSSID);
		IL_22D:
		return GClass3.smethod_19(gclass9_0.BSSID);
		IL_23B:
		return GClass3.smethod_20(gclass9_0.BSSID);
		IL_249:
		return GClass3.smethod_21(gclass9_0.BSSID);
		IL_257:
		return GClass3.smethod_22(gclass9_0.BSSID);
		IL_265:
		result = GClass3.smethod_23(gclass9_0.BSSID);
		return result;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x000087A4 File Offset: 0x000069A4
	public static string smethod_26(ref GClass9 gclass9_0, string string_0)
	{
		return GClass3.smethod_27("-e " + gclass9_0.PKE + " -r " + gclass9_0.PKR + " -s " + gclass9_0.E_HAS1 + " -z " + gclass9_0.E_HAS2 + " -a " + gclass9_0.AuthKey + " -n " + gclass9_0.E_NONCE + " -m " + gclass9_0.R_NONCE + string_0);
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00008834 File Offset: 0x00006A34
	public static string smethod_27(string string_0)
	{
		Process process = new Process();
		return GClass3.smethod_28(string_0, ref process);
	}

	// Token: 0x06000185 RID: 389 RVA: 0x00008850 File Offset: 0x00006A50
	public static string smethod_28(string string_0, ref Process process_0)
	{
		WaitSplashProcess waitSplashProcess = new WaitSplashProcess(Class6.Class7_0.MainForm_0.RtbMessage, Class10.String_76);
		Process process = process_0;
		process.StartInfo = new ProcessStartInfo("PixieWps\\pixiewps.exe", string_0);
		ProcessStartInfo startInfo = process.StartInfo;
		startInfo.CreateNoWindow = true;
		startInfo.UseShellExecute = false;
		startInfo.RedirectStandardOutput = true;
		DateTime now = DateAndTime.Now;
		process.Start();
		while (!process.HasExited)
		{
			Application.DoEvents();
			if ((DateAndTime.Now - now).TotalSeconds > 2.0)
			{
				if (waitSplashProcess.IsDisposed)
				{
					process.Kill();
				}
				else
				{
					if (!waitSplashProcess.Visible)
					{
						waitSplashProcess.Show();
					}
					waitSplashProcess.Refresh();
				}
			}
		}
		if (!waitSplashProcess.IsDisposed)
		{
			waitSplashProcess.Dispose();
		}
		return process_0.StandardOutput.ReadToEnd();
	}

	// Token: 0x02000011 RID: 17
	public enum GEnum0
	{
		// Token: 0x0400006F RID: 111
		Nothing = -1,
		// Token: 0x04000070 RID: 112
		ZAO,
		// Token: 0x04000071 RID: 113
		FTE,
		// Token: 0x04000072 RID: 114
		EasyBox,
		// Token: 0x04000073 RID: 115
		dLINK,
		// Token: 0x04000074 RID: 116
		TrendNet,
		// Token: 0x04000075 RID: 117
		AiroConru,
		// Token: 0x04000076 RID: 118
		Asus,
		// Token: 0x04000077 RID: 119
		LiveBox,
		// Token: 0x04000078 RID: 120
		PinNull,
		// Token: 0x04000079 RID: 121
		d28bit = 10,
		// Token: 0x0400007A RID: 122
		d32bit,
		// Token: 0x0400007B RID: 123
		d36bit,
		// Token: 0x0400007C RID: 124
		d40bit,
		// Token: 0x0400007D RID: 125
		d44bit,
		// Token: 0x0400007E RID: 126
		d48bit,
		// Token: 0x0400007F RID: 127
		d24rhbit,
		// Token: 0x04000080 RID: 128
		d32rhbit,
		// Token: 0x04000081 RID: 129
		d48rhbit,
		// Token: 0x04000082 RID: 130
		d24rnbit,
		// Token: 0x04000083 RID: 131
		d32rnbit,
		// Token: 0x04000084 RID: 132
		d48rnbit
	}
}
