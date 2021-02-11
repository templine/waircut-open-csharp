using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x02000039 RID: 57
	[DesignerGenerated]
	public partial class UpdateForm : Form
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x0000474D File Offset: 0x0000294D
		public UpdateForm()
		{
			base.Load += this.UpdateForm_Load;
			this.string_0 = "";
			this.InitializeComponent();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00017440 File Offset: 0x00015640
		[DebuggerNonUserCode]
		protected virtual void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00004778 File Offset: 0x00002978
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00004780 File Offset: 0x00002980
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00004789 File Offset: 0x00002989
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00004791 File Offset: 0x00002991
		internal virtual Label lbTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000479A File Offset: 0x0000299A
		// (set) Token: 0x060003DF RID: 991 RVA: 0x000047A2 File Offset: 0x000029A2
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000047AB File Offset: 0x000029AB
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x000047B3 File Offset: 0x000029B3
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x000047BC File Offset: 0x000029BC
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x000047C4 File Offset: 0x000029C4
		internal virtual Label lbVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000047CD File Offset: 0x000029CD
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x000047D5 File Offset: 0x000029D5
		internal virtual Label lbLastVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x000047DE File Offset: 0x000029DE
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00017864 File Offset: 0x00015A64
		internal virtual Button btDownload
		{
			[CompilerGenerated]
			get
			{
				return this._btDownload;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				Button btDownload = this._btDownload;
				if (btDownload != null)
				{
					btDownload.Click -= value2;
				}
				this._btDownload = value;
				btDownload = this._btDownload;
				if (btDownload != null)
				{
					btDownload.Click += value2;
				}
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x000047E6 File Offset: 0x000029E6
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000047EE File Offset: 0x000029EE
		internal virtual Button btDonate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x000047F7 File Offset: 0x000029F7
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x000047FF File Offset: 0x000029FF
		internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00004808 File Offset: 0x00002A08
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00004810 File Offset: 0x00002A10
		internal virtual GClass14 ScrollLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060003EE RID: 1006 RVA: 0x00004819 File Offset: 0x00002A19
		private void UpdateForm_Load(object sender, EventArgs e)
		{
			this.ScrollLabel1.Text = Class10.String_60;
			this.lbVersion.Text = Class13.Version;
			this.lbLastVersion.Text = this.string_0;
			this.btDonate.Visible = false;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000178A8 File Offset: 0x00015AA8
		private void method_0(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://sourceforge.net/projects/waircut");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040001C7 RID: 455
		private IContainer icontainer_0;

		// Token: 0x040001D2 RID: 466
		public string string_0;
	}
}
