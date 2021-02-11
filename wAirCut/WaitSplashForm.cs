using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200003B RID: 59
	[DesignerGenerated]
	public partial class WaitSplashForm : Form
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0001830C File Offset: 0x0001650C
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000048EF File Offset: 0x00002AEF
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000048F7 File Offset: 0x00002AF7
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00004900 File Offset: 0x00002B00
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00004908 File Offset: 0x00002B08
		internal virtual ProgressBar ProgressBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00004911 File Offset: 0x00002B11
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00004919 File Offset: 0x00002B19
		internal virtual Label lbMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600040C RID: 1036 RVA: 0x0001858C File Offset: 0x0001678C
		public WaitSplashForm(string string_1, int int_2, Form form_1 = null)
		{
			base.Load += this.WaitSplashForm_Load;
			this.string_0 = "";
			this.int_0 = 100;
			this.form_0 = null;
			this.InitializeComponent();
			this.string_0 = string_1;
			this.int_0 = int_2;
			this.form_0 = form_1;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00004922 File Offset: 0x00002B22
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000492A File Offset: 0x00002B2A
		public int Int32_0
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
				this.ProgressBar.Value = checked((int)Math.Round((double)(this.int_1 * 100) / (double)this.int_0));
				this.ProgressBar.Update();
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00004961 File Offset: 0x00002B61
		private void WaitSplashForm_Load(object sender, EventArgs e)
		{
			this.lbMessage.Text = this.string_0;
			this.method_0();
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000185E8 File Offset: 0x000167E8
		private void method_0()
		{
			Rectangle rectangle;
			if (this.form_0 != null)
			{
				rectangle = this.form_0.RectangleToScreen(this.form_0.ClientRectangle);
			}
			else
			{
				rectangle = Screen.FromPoint(base.Location).WorkingArea;
			}
			checked
			{
				int x = rectangle.Left + (rectangle.Width - base.Width) / 2;
				int y = rectangle.Top + (rectangle.Height - base.Height) / 3;
				base.Location = new Point(x, y);
			}
		}

		// Token: 0x040001E2 RID: 482
		private IContainer icontainer_0;

		// Token: 0x040001E6 RID: 486
		private string string_0;

		// Token: 0x040001E7 RID: 487
		private int int_0;

		// Token: 0x040001E8 RID: 488
		private Form form_0;

		// Token: 0x040001E9 RID: 489
		private int int_1;
	}
}
