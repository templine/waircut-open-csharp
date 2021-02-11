using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

// Token: 0x0200003A RID: 58
[StandardModule]
internal sealed class Class13
{
	// Token: 0x17000195 RID: 405
	// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000179E4 File Offset: 0x00015BE4
	public static string Version
	{
		get
		{
			string text = string.Format("{0}.{1}", Class6.Form0_0.Info.Version.Major, Class6.Form0_0.Info.Version.Minor);
			if (Class13.bool_0)
			{
				text += " beta";
			}
			return text;
		}
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00017A44 File Offset: 0x00015C44
	public static string smethod_0(GClass15<GClass9> gclass15_0)
	{
		string text = "";
		string format = "{0}       {1,3}      {2,4}     {3,5}         {4}\r\n";
		text += "BSSID     \t         Channel    RSSI    WPS Locked    ESSID\r\n";
		text += "-------------------------------------------------------------------------------------\r\n";
		checked
		{
			int num = gclass15_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				text += string.Format(format, new object[]
				{
					gclass15_0[i].BSSID,
					gclass15_0[i].Channel,
					gclass15_0[i].RSSI,
					gclass15_0[i].ApSetupLocked,
					gclass15_0[i].SSID
				});
			}
			return text;
		}
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00017AF0 File Offset: 0x00015CF0
	public static string smethod_1(byte[] byte_0)
	{
		string text = "";
		checked
		{
			int num = byte_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i > 0 & i < byte_0.Length)
				{
					text += ":";
				}
				text += byte_0[i].ToString("X2");
			}
			return text;
		}
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00017B48 File Offset: 0x00015D48
	public static void smethod_2(string string_9)
	{
		ServiceController serviceController = new ServiceController(string_9);
		if (serviceController.Status.Equals(ServiceControllerStatus.Running))
		{
			try
			{
				serviceController.Stop();
				serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
			}
			catch (Exception ex)
			{
			}
		}
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00017BA8 File Offset: 0x00015DA8
	public static void smethod_3(string string_9)
	{
		ServiceController serviceController = new ServiceController(string_9);
		try
		{
			serviceController.Stop();
			serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
			serviceController.Start();
			serviceController.WaitForStatus(ServiceControllerStatus.Running);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00004858 File Offset: 0x00002A58
	public static bool smethod_4()
	{
		return Environment.OSVersion.Version.Major >= 6;
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00017BF8 File Offset: 0x00015DF8
	public static bool smethod_5()
	{
		string text = GClass0.String_0;
		ServiceController serviceController = new ServiceController(text);
		string text2 = "";
		bool result = false;
		try
		{
			string left = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\\es\\wAirCut.resources.dll");
			if (Operators.CompareString(left, "908576645D406E5D543E1F16428FCFDB", false) != 0)
			{
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			left = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\\ru\\wAirCut.resources.dll");
			if (Operators.CompareString(left, "C994E6B19DB5C8A8E4D0549F79CE32A5", false) != 0)
			{
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			left = Class13.smethod_6(AppDomain.CurrentDomain.BaseDirectory + "\\fr\\wAirCut.resources.dll");
			if (Operators.CompareString(left, "BF000AC77F51D507E038272A8E998290", false) != 0)
			{
				MessageBox.Show("Resorce file is wrong", "Waircut", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (serviceController.DisplayName != null)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services");
				if (registryKey != null)
				{
					Class13.smethod_2(text);
					registryKey.OpenSubKey(text).GetValue("ImagePath");
					text2 = Path.GetDirectoryName(registryKey.OpenSubKey(text).GetValue("ImagePath").ToString());
				}
				if (Operators.CompareString(text2, "", false) != 0)
				{
					left = Class13.smethod_6(text2 + "\\jswscsup.dll");
					if (Operators.CompareString(left, "1FB6E3E894EDDFF1B2277235BAB769E9", false) == 0)
					{
						result = true;
					}
					else
					{
						GClass4 gclass = new GClass4(left);
						byte[] byte_ = GClass0.Byte_0;
						byte[] array = gclass.method_2(ref byte_);
						left = Class13.smethod_7(array);
						if (Operators.CompareString(left, "1FB6E3E894EDDFF1B2277235BAB769E9", false) != 0)
						{
							MessageBox.Show(Class10.String_56, "Jumpstart Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						DateTime lastWriteTime = File.GetLastWriteTime(text2 + "\\jswscsup.dll");
						DateTime creationTime = File.GetCreationTime(text2 + "\\jswscsup.dll");
						if (Class6.Class5_0.FileSystem.FileExists(text2 + "\\jswscsup-tmp.dll"))
						{
							Class6.Class5_0.FileSystem.DeleteFile(text2 + "\\jswscsup-tmp.dll");
						}
						Class6.Class5_0.FileSystem.RenameFile(text2 + "\\jswscsup.dll", "jswscsup-tmp.dll");
						File.WriteAllBytes(text2 + "\\jswscsup.dll", array);
						File.SetLastWriteTime(text2 + "\\jswscsup.dll", lastWriteTime);
						File.SetCreationTime(text2 + "\\jswscsup.dll", creationTime);
						if (Class6.Class5_0.FileSystem.FileExists(text2 + "\\jswscsup-tmp.dll"))
						{
							Class6.Class5_0.FileSystem.DeleteFile(text2 + "\\jswscsup-tmp.dll");
						}
						result = Class13.smethod_5();
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class10.String_57, "Jumpstart Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
		return result;
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x0000486F File Offset: 0x00002A6F
	public static string smethod_6(string string_9)
	{
		return Class13.smethod_7(File.ReadAllBytes(string_9));
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00017EFC File Offset: 0x000160FC
	public static string smethod_7(byte[] byte_0)
	{
		Stream stream = new MemoryStream(byte_0);
		MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
		md5CryptoServiceProvider.ComputeHash(stream);
		stream.Close();
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = md5CryptoServiceProvider.Hash.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(md5CryptoServiceProvider.Hash[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00017F6C File Offset: 0x0001616C
	public static string smethod_8(Array array_0, string string_9)
	{
		string text = "";
		try
		{
			foreach (object obj in array_0)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(obj);
				text = text + Conversion.Hex(RuntimeHelpers.GetObjectValue(objectValue)).PadLeft(2, '0') + string_9;
			}
		}
		finally
		{
			IEnumerator enumerator;
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		if (Operators.CompareString(string_9, string.Empty, false) != 0)
		{
			text = text.Substring(0, checked(text.Length - 1));
		}
		return text;
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00017FFC File Offset: 0x000161FC
	public static string smethod_9(Array array_0, Array array_1)
	{
		byte[] array = new byte[32];
		int num = 0;
		checked
		{
			do
			{
				array[num] = Conversions.ToByte(Operators.XorObject(Operators.XorObject(NewLateBinding.LateIndexGet(array_0, new object[]
				{
					num + 3
				}, null), NewLateBinding.LateIndexGet(array_1, new object[]
				{
					num
				}, null)), NewLateBinding.LateIndexGet(array_1, new object[]
				{
					32 + num
				}, null)));
				num++;
			}
			while (num <= 31);
			return Class13.smethod_8(array, ":");
		}
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00018084 File Offset: 0x00016284
	public static string smethod_10(GEnum16 genum16_0)
	{
		for (;;)
		{
			IL_C4:
			switch (genum16_0)
			{
			case GEnum16.JswMsgType_None:
				goto IL_117;
			case GEnum16.JswMsgType_Beacon:
				goto IL_11F;
			case GEnum16.JswMsgType_ProbeRequest:
				goto IL_127;
			case GEnum16.JswMsgType_ProbeResponse:
				goto IL_12F;
			case GEnum16.JswMsgType_M1:
				goto IL_137;
			case GEnum16.JswMsgType_M2:
				goto IL_13F;
			case GEnum16.JswMsgType_M2D:
				goto IL_147;
			case GEnum16.JswMsgType_M3:
				goto IL_14F;
			case GEnum16.JswMsgType_M4:
				goto IL_157;
			case GEnum16.JswMsgType_M5:
				goto IL_15F;
			case GEnum16.JswMsgType_M6:
				goto IL_167;
			case GEnum16.JswMsgType_M7:
				goto IL_16F;
			case GEnum16.JswMsgType_M8:
				goto IL_177;
			case GEnum16.JswMsgType_WSC_ACK:
				goto IL_17F;
			case GEnum16.JswMsgType_WSC_NACK:
				goto IL_187;
			case GEnum16.JswMsgType_WSC_DONE:
				goto IL_18F;
			default:
			{
				uint num2;
				uint num = num2 * 2167104212U ^ 1017883846U;
				for (;;)
				{
					switch ((num2 = (num ^ 51483762U)) % 35U)
					{
					case 0U:
						goto IL_147;
					case 2U:
						goto IL_167;
					case 3U:
						goto IL_137;
					case 4U:
						goto IL_157;
					case 9U:
					case 31U:
						goto IL_C4;
					case 10U:
						goto IL_177;
					case 12U:
						goto IL_117;
					case 13U:
						goto IL_17F;
					case 15U:
						goto IL_15F;
					case 16U:
						goto IL_16F;
					case 18U:
						goto IL_12F;
					case 22U:
						goto IL_14F;
					case 23U:
						goto IL_13F;
					case 25U:
						num = (num2 * 3737786953U ^ 2751621205U);
						continue;
					case 26U:
						goto IL_10F;
					case 27U:
						goto IL_187;
					case 28U:
						goto IL_18F;
					case 29U:
						goto IL_11F;
					case 34U:
						goto IL_127;
					}
					goto Block_1;
				}
				break;
			}
			}
		}
		Block_1:
		string result;
		return result;
		IL_10F:
		return "Undefined";
		IL_117:
		return "None";
		IL_11F:
		return "Beacon frame";
		IL_127:
		return "Probe request";
		IL_12F:
		return "Probe response";
		IL_137:
		return "M1";
		IL_13F:
		return "M2";
		IL_147:
		return "M2D";
		IL_14F:
		return "M3";
		IL_157:
		return "M4";
		IL_15F:
		return "M5";
		IL_167:
		return "M6";
		IL_16F:
		return "M7";
		IL_177:
		return "M8";
		IL_17F:
		return "WSC ACK";
		IL_187:
		return "WSC NACK";
		IL_18F:
		result = "WSC DONE";
		return result;
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00018228 File Offset: 0x00016428
	public static bool smethod_11(string string_9, ref GClass12 gclass12_0)
	{
		Match match = new Regex("WPS pin:.*?(\\w+)", RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(string_9);
		bool result;
		if (!match.Success)
		{
			result = false;
		}
		else
		{
			if (Operators.CompareString(match.Groups[1].ToString(), "empty", false) == 0)
			{
				gclass12_0.Pin = "";
			}
			else
			{
				gclass12_0.Pin = match.Groups[1].ToString();
			}
			gclass12_0.Type = GClass12.GEnum5.PixieDust;
			gclass12_0.genum0_0 = GClass3.GEnum0.Nothing;
			gclass12_0.Description = gclass12_0.Type.ToString();
			result = true;
		}
		return result;
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x0000487C File Offset: 0x00002A7C
	public static string smethod_12(string string_9)
	{
		return new Regex("Jsw.*?_|{|}[\\n\\r\\s]+", RegexOptions.IgnoreCase | RegexOptions.Singleline).Replace(string_9, "");
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00004895 File Offset: 0x00002A95
	public static string smethod_13(string string_9, string string_10)
	{
		return string_9.Substring(0, string_9.Length / 2) + Strings.StrDup(checked(string_9.Length - string_9.Length / 2), string_10);
	}

	// Token: 0x06000400 RID: 1024
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SendMessage(IntPtr intptr_0, int int_3, IntPtr intptr_1, IntPtr intptr_2);

	// Token: 0x06000401 RID: 1025 RVA: 0x000048C0 File Offset: 0x00002AC0
	public static void smethod_14(RichTextBox richTextBox_0)
	{
		Class13.SendMessage(richTextBox_0.Handle, 277, (IntPtr)7, IntPtr.Zero);
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x000182C4 File Offset: 0x000164C4
	public static void smethod_15(string string_9, string string_10)
	{
		FileStream fileStream = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\log\\" + string_9, FileMode.Append, FileAccess.Write);
		byte[] bytes = new UTF8Encoding(true).GetBytes(string_10);
		fileStream.Write(bytes, 0, bytes.Length);
		fileStream.Close();
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x000048DE File Offset: 0x00002ADE
	public static bool smethod_16()
	{
		return Class6.Class5_0.Network.IsAvailable;
	}

	// Token: 0x040001D3 RID: 467
	public static string[] string_0 = new string[]
	{
		" _  _  _       _            _                           _           ______           ",
		"| || || |     (_)          | |                     /\\  (_)         / _____)     _    ",
		"| || || | ____ _  ____ ____| | ____  ___  ___     /  \\  _  ____   | /     _   _| |_  ",
		"| ||_|| |/ _  | |/ ___) _  ) |/ _  )/___)/___)   / /\\ \\| |/ ___)  | |    | | | |  _) ",
		"| |___| ( ( | | | |  ( (/ /| ( (/ /|___ |___ |  | |__| | | |      | \\____| |_| | |__ ",
		" \\______|\\_||_|_|_|   \\____)_|\\____|___/(___/   |______|_|_|       \\______)____|\\___)",
		"                                                                                     ",
		"                        ---   " + Class6.Form0_0.Info.Copyright + "    ---                          ",
		"     Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International      ",
		"                                                                                     "
	};

	// Token: 0x040001D4 RID: 468
	public static string string_1 = "";

	// Token: 0x040001D5 RID: 469
	public static bool bool_0 = false;

	// Token: 0x040001D6 RID: 470
	public static string string_2 = Environment.MachineName;

	// Token: 0x040001D7 RID: 471
	public static string string_3 = Environment.UserName;

	// Token: 0x040001D8 RID: 472
	public static string string_4 = "\r\n" + string.Format("{0}@{1}:#_> ", Class13.string_3, Class13.string_2);

	// Token: 0x040001D9 RID: 473
	public static bool bool_1 = false;

	// Token: 0x040001DA RID: 474
	public static string string_5 = "";

	// Token: 0x040001DB RID: 475
	public static string string_6 = "";

	// Token: 0x040001DC RID: 476
	public static int int_0 = 0;

	// Token: 0x040001DD RID: 477
	public static bool bool_2 = false;

	// Token: 0x040001DE RID: 478
	public static string string_7 = "waircut.log";

	// Token: 0x040001DF RID: 479
	public static string string_8 = "1FB6E3E894EDDFF1B2277235BAB769E9";

	// Token: 0x040001E0 RID: 480
	private const int int_1 = 277;

	// Token: 0x040001E1 RID: 481
	private const int int_2 = 7;
}
