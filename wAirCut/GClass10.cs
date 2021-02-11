using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using wAirCut.My;

// Token: 0x02000027 RID: 39
public class GClass10
{
	// Token: 0x1700014F RID: 335
	// (get) Token: 0x060002F7 RID: 759 RVA: 0x000041F4 File Offset: 0x000023F4
	// (set) Token: 0x060002F8 RID: 760 RVA: 0x0001238C File Offset: 0x0001058C
	private virtual BackgroundWorker BackgroundWorker_0
	{
		[CompilerGenerated]
		get
		{
			return this.backgroundWorker_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			DoWorkEventHandler value2 = new DoWorkEventHandler(this.method_1);
			RunWorkerCompletedEventHandler value3 = new RunWorkerCompletedEventHandler(this.method_2);
			ProgressChangedEventHandler value4 = new ProgressChangedEventHandler(this.method_3);
			BackgroundWorker backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork -= value2;
				backgroundWorker.RunWorkerCompleted -= value3;
				backgroundWorker.ProgressChanged -= value4;
			}
			this.backgroundWorker_0 = value;
			backgroundWorker = this.backgroundWorker_0;
			if (backgroundWorker != null)
			{
				backgroundWorker.DoWork += value2;
				backgroundWorker.RunWorkerCompleted += value3;
				backgroundWorker.ProgressChanged += value4;
			}
		}
	}

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060002F9 RID: 761 RVA: 0x00012408 File Offset: 0x00010608
	// (remove) Token: 0x060002FA RID: 762 RVA: 0x00012444 File Offset: 0x00010644
	public event GClass10.GDelegate9 Event_0
	{
		[CompilerGenerated]
		add
		{
			GClass10.GDelegate9 gdelegate = this.gdelegate9_0;
			GClass10.GDelegate9 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass10.GDelegate9 value2 = (GClass10.GDelegate9)Delegate.Combine(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass10.GDelegate9>(ref this.gdelegate9_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GClass10.GDelegate9 gdelegate = this.gdelegate9_0;
			GClass10.GDelegate9 gdelegate2;
			do
			{
				gdelegate2 = gdelegate;
				GClass10.GDelegate9 value2 = (GClass10.GDelegate9)Delegate.Remove(gdelegate2, value);
				gdelegate = Interlocked.CompareExchange<GClass10.GDelegate9>(ref this.gdelegate9_0, value2, gdelegate2);
			}
			while (gdelegate != gdelegate2);
		}
	}

	// Token: 0x060002FB RID: 763 RVA: 0x00012480 File Offset: 0x00010680
	public GClass10()
	{
		this.BackgroundWorker_0 = new BackgroundWorker();
		this.bool_0 = false;
		this.int_0 = 0;
		this.gclass1_0 = new GClass1();
		this.BackgroundWorker_0.WorkerReportsProgress = true;
		this.BackgroundWorker_0.WorkerSupportsCancellation = true;
		this.BackgroundWorker_0.RunWorkerAsync();
	}

	// Token: 0x060002FC RID: 764 RVA: 0x000041FC File Offset: 0x000023FC
	public void method_0()
	{
		this.BackgroundWorker_0.CancelAsync();
	}

	// Token: 0x060002FD RID: 765 RVA: 0x000124DC File Offset: 0x000106DC
	private void method_1(object sender, DoWorkEventArgs e)
	{
		if (Class13.smethod_16())
		{
			this.method_4("https://sourceforge.net/projects/waircut/files/", 15);
			this.method_5("https://sourceforge.net/projects/waircut/files/", 15);
			this.BackgroundWorker_0.ReportProgress(1);
		}
		for (;;)
		{
			this.BackgroundWorker_0.ReportProgress(1);
			Thread.Sleep(60000);
			ref int ptr = ref this.int_0;
			this.int_0 = checked(ptr + 1);
		}
	}

	// Token: 0x060002FE RID: 766 RVA: 0x00003A31 File Offset: 0x00001C31
	private void method_2(object sender, RunWorkerCompletedEventArgs e)
	{
	}

	// Token: 0x060002FF RID: 767 RVA: 0x0001253C File Offset: 0x0001073C
	private void method_3(object sender, ProgressChangedEventArgs e)
	{
		if (!Class13.bool_0)
		{
			if (!(this.method_6() & !this.bool_0))
			{
				if (DateTime.Compare(this.dateTime_2, MySettings.Default.LastDBDate) > 0 && MessageBox.Show(Class10.String_6, "Update News...", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					this.method_7("https://sourceforge.net/projects/waircut/files/WpsPin.db", "WpsPin.db");
					MySettings.Default.LastDBDate = this.dateTime_2;
				}
			}
			else
			{
				this.bool_0 = true;
				GClass10.GDelegate9 gdelegate = this.gdelegate9_0;
				if (gdelegate != null)
				{
					gdelegate(this.version_0.ToString());
					return;
				}
			}
		}
	}

	// Token: 0x06000300 RID: 768 RVA: 0x000125D8 File Offset: 0x000107D8
	private void method_4(string string_0, int int_1)
	{
		WebRequest webRequest = WebRequest.Create(new Uri(string_0));
		webRequest.Timeout = checked(1000 * int_1);
		try
		{
			using (Stream responseStream = webRequest.GetResponse().GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					string input = streamReader.ReadToEnd();
					Match match = new Regex("Waircut.*?(\\d+.\\d+).zip", RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(input);
					if (match.Success)
					{
						this.version_0 = new Version(match.Groups[1].ToString());
					}
				}
			}
			webRequest.GetResponse().Close();
		}
		catch (WebException ex)
		{
		}
	}

	// Token: 0x06000301 RID: 769 RVA: 0x000126B0 File Offset: 0x000108B0
	private void method_5(string string_0, int int_1)
	{
		WebRequest webRequest = WebRequest.Create(new Uri(string_0));
		webRequest.Timeout = checked(1000 * int_1);
		try
		{
			using (Stream responseStream = webRequest.GetResponse().GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					string input = streamReader.ReadToEnd();
					Match match = new Regex("WpsPin.db.*?<td headers=\"files_date_h\" class=\"opt\"><abbr title=\".*?([0-9]{4}-[0-9]{2}-[0-9]{2} [0-9]{2}:[0-9]{2}:[0-9]{2})", RegexOptions.IgnoreCase | RegexOptions.Singleline).Match(input);
					if (match.Success)
					{
						this.dateTime_2 = DateTime.ParseExact(match.Groups[1].ToString(), "yyyy-MM-dd HH:mm:ss", DateTimeFormatInfo.InvariantInfo);
					}
				}
			}
			webRequest.GetResponse().Close();
		}
		catch (WebException ex)
		{
		}
	}

	// Token: 0x06000302 RID: 770 RVA: 0x00012790 File Offset: 0x00010990
	private bool method_6()
	{
		return this.version_0 != null && (this.version_0.Major > Class6.Form0_0.Info.Version.Major | (this.version_0.Major == Class6.Form0_0.Info.Version.Major & this.version_0.Minor > Class6.Form0_0.Info.Version.Minor));
	}

	// Token: 0x06000303 RID: 771 RVA: 0x00012810 File Offset: 0x00010A10
	private void method_7(string string_0, string string_1)
	{
		try
		{
			Uri address = new Uri(string_0);
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += this.method_8;
			webClient.DownloadFileAsync(address, string_1, string_1);
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x06000304 RID: 772 RVA: 0x00003A31 File Offset: 0x00001C31
	private void method_8(object sender, AsyncCompletedEventArgs e)
	{
	}

	// Token: 0x0400013E RID: 318
	[CompilerGenerated]
	[AccessedThroughProperty("backWorker")]
	private BackgroundWorker backgroundWorker_0;

	// Token: 0x0400013F RID: 319
	private Version version_0;

	// Token: 0x04000140 RID: 320
	private DateTime dateTime_0;

	// Token: 0x04000141 RID: 321
	private DateTime dateTime_1;

	// Token: 0x04000142 RID: 322
	private DateTime dateTime_2;

	// Token: 0x04000143 RID: 323
	private bool bool_0;

	// Token: 0x04000144 RID: 324
	private int int_0;

	// Token: 0x04000145 RID: 325
	private GClass1 gclass1_0;

	// Token: 0x04000146 RID: 326
	[CompilerGenerated]
	private GClass10.GDelegate9 gdelegate9_0;

	// Token: 0x02000028 RID: 40
	// (Invoke) Token: 0x06000308 RID: 776
	public delegate void GDelegate9(string version);
}
