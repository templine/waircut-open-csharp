using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200003C RID: 60
	[DesignerGenerated]
	public partial class WaitSplashProcess : Form
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00018668 File Offset: 0x00016868
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000497A File Offset: 0x00002B7A
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00018914 File Offset: 0x00016B14
		internal virtual Button btStop
		{
			[CompilerGenerated]
			get
			{
				return this._btStop;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				Button btStop = this._btStop;
				if (btStop != null)
				{
					btStop.Click -= value2;
				}
				this._btStop = value;
				btStop = this._btStop;
				if (btStop != null)
				{
					btStop.Click += value2;
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00004982 File Offset: 0x00002B82
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x0000498A File Offset: 0x00002B8A
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00004993 File Offset: 0x00002B93
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000499B File Offset: 0x00002B9B
		internal virtual GClass14 ScrollLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000049A4 File Offset: 0x00002BA4
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x000049AC File Offset: 0x00002BAC
		private virtual Control Control_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0600041B RID: 1051 RVA: 0x00018958 File Offset: 0x00016B58
		public WaitSplashProcess(Control control_1 = null, string string_0 = "Waiting for completion...")
		{
			base.Load += this.WaitSplashProcess_Load;
			base.Deactivate += this.WaitSplashProcess_Deactivate;
			this.Control_0 = null;
			this.InitializeComponent();
			this.Control_0 = control_1;
			base.Owner = control_1.FindForm();
			this.ScrollLabel1.Text = string_0;
			base.Owner.Move += this.method_3;
			base.Owner.Resize += this.method_4;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000034C9 File Offset: 0x000016C9
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000189EC File Offset: 0x00016BEC
		private void method_1()
		{
			Rectangle rectangle;
			if (this.Control_0 != null)
			{
				rectangle = this.Control_0.RectangleToScreen(this.Control_0.ClientRectangle);
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

		// Token: 0x0600041E RID: 1054 RVA: 0x000049B5 File Offset: 0x00002BB5
		private void WaitSplashProcess_Load(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000049B5 File Offset: 0x00002BB5
		private void method_2(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000049BD File Offset: 0x00002BBD
		private void WaitSplashProcess_Deactivate(object sender, EventArgs e)
		{
			base.Show();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000049B5 File Offset: 0x00002BB5
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000049B5 File Offset: 0x00002BB5
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x040001EA RID: 490
		private IContainer icontainer_0;

		// Token: 0x040001EE RID: 494
		[AccessedThroughProperty("parentFrm")]
		[CompilerGenerated]
		private Control control_0;
	}
}
