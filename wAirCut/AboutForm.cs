using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class AboutForm : Form
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00003421 File Offset: 0x00001621
		public AboutForm()
		{
			base.Load += this.AboutForm_Load;
			this.InitializeComponent();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004DA4 File Offset: 0x00002FA4
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003441 File Offset: 0x00001641
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00003449 File Offset: 0x00001649
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003452 File Offset: 0x00001652
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x0000345A File Offset: 0x0000165A
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00003463 File Offset: 0x00001663
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000346B File Offset: 0x0000166B
		internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00003474 File Offset: 0x00001674
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000347C File Offset: 0x0000167C
		internal virtual Button btDonate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003485 File Offset: 0x00001685
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000348D File Offset: 0x0000168D
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003496 File Offset: 0x00001696
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000349E File Offset: 0x0000169E
		internal virtual ToolStripStatusLabel lbVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x000034A7 File Offset: 0x000016A7
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x000034AF File Offset: 0x000016AF
		internal virtual GClass14 ScrollLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000034B8 File Offset: 0x000016B8
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000034C0 File Offset: 0x000016C0
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x060000E5 RID: 229 RVA: 0x000051A0 File Offset: 0x000033A0
		private void AboutForm_Load(object sender, EventArgs e)
		{
			this.DoubleBuffered = true;
			this.lbVersion.Text = string.Concat(new string[]
			{
				Class10.String_1,
				Class13.Version,
				"    ",
				Class6.Form0_0.Info.Copyright,
				"\r\n"
			});
			if (!Class13.bool_0)
			{
				this.btDonate.Visible = false;
				this.ScrollLabel1.Text = Class10.String_0;
				return;
			}
			this.btDonate.Visible = false;
			this.ScrollLabel1.Text = Class10.String_0;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000034C9 File Offset: 0x000016C9
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x04000015 RID: 21
		private IContainer icontainer_0;
	}
}
