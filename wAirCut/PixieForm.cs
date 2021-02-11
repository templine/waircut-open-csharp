using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200002C RID: 44
	[DesignerGenerated]
	public partial class PixieForm : Form
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00012BDC File Offset: 0x00010DDC
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

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00004267 File Offset: 0x00002467
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0001326C File Offset: 0x0001146C
		internal virtual ComboBox cbMode
		{
			[CompilerGenerated]
			get
			{
				return this._cbMode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				ComboBox cbMode = this._cbMode;
				if (cbMode != null)
				{
					cbMode.SelectedIndexChanged -= value2;
				}
				this._cbMode = value;
				cbMode = this._cbMode;
				if (cbMode != null)
				{
					cbMode.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000426F File Offset: 0x0000246F
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00004277 File Offset: 0x00002477
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00004280 File Offset: 0x00002480
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00004288 File Offset: 0x00002488
		internal virtual DateTimePicker dtpStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00004291 File Offset: 0x00002491
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00004299 File Offset: 0x00002499
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000320 RID: 800 RVA: 0x000042A2 File Offset: 0x000024A2
		// (set) Token: 0x06000321 RID: 801 RVA: 0x000042AA File Offset: 0x000024AA
		internal virtual DateTimePicker dtpEnd { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000042B3 File Offset: 0x000024B3
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000042BB File Offset: 0x000024BB
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000042C4 File Offset: 0x000024C4
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000132B0 File Offset: 0x000114B0
		internal virtual CheckBox cbxForce
		{
			[CompilerGenerated]
			get
			{
				return this._cbxForce;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_1);
				CheckBox cbxForce = this._cbxForce;
				if (cbxForce != null)
				{
					cbxForce.CheckedChanged -= value2;
				}
				this._cbxForce = value;
				cbxForce = this._cbxForce;
				if (cbxForce != null)
				{
					cbxForce.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000042CC File Offset: 0x000024CC
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000042D4 File Offset: 0x000024D4
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000042DD File Offset: 0x000024DD
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000042E5 File Offset: 0x000024E5
		internal virtual CheckBox cbxRNonce { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000042EE File Offset: 0x000024EE
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000042F6 File Offset: 0x000024F6
		internal virtual CheckBox cbxEBssid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000042FF File Offset: 0x000024FF
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00004307 File Offset: 0x00002507
		internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00004310 File Offset: 0x00002510
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000132F4 File Offset: 0x000114F4
		internal virtual ToolStripButton btExcute
		{
			[CompilerGenerated]
			get
			{
				return this._btExcute;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_2);
				ToolStripButton btExcute = this._btExcute;
				if (btExcute != null)
				{
					btExcute.Click -= value2;
				}
				this._btExcute = value;
				btExcute = this._btExcute;
				if (btExcute != null)
				{
					btExcute.Click += value2;
				}
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00004318 File Offset: 0x00002518
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00013338 File Offset: 0x00011538
		internal virtual ToolStripButton btRetry
		{
			[CompilerGenerated]
			get
			{
				return this._btRetry;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_3);
				ToolStripButton btRetry = this._btRetry;
				if (btRetry != null)
				{
					btRetry.Click -= value2;
				}
				this._btRetry = value;
				btRetry = this._btRetry;
				if (btRetry != null)
				{
					btRetry.Click += value2;
				}
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00004320 File Offset: 0x00002520
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0001337C File Offset: 0x0001157C
		internal virtual ToolStripButton btStop
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
				EventHandler value2 = new EventHandler(this.method_4);
				ToolStripButton btStop = this._btStop;
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00004328 File Offset: 0x00002528
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00004330 File Offset: 0x00002530
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00004339 File Offset: 0x00002539
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00004341 File Offset: 0x00002541
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000434A File Offset: 0x0000254A
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00004352 File Offset: 0x00002552
		internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000435B File Offset: 0x0000255B
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00004363 File Offset: 0x00002563
		internal virtual CheckBox cbxLength { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000436C File Offset: 0x0000256C
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000133C0 File Offset: 0x000115C0
		private virtual GClass8 GClass8_0
		{
			[CompilerGenerated]
			get
			{
				return this.gclass8_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				GClass8.GDelegate8 value2 = new GClass8.GDelegate8(this.method_5);
				GClass8 gclass = this.gclass8_0;
				if (gclass != null)
				{
					gclass.Event_2 -= value2;
				}
				this.gclass8_0 = value;
				gclass = this.gclass8_0;
				if (gclass != null)
				{
					gclass.Event_2 += value2;
				}
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00013404 File Offset: 0x00011604
		public PixieForm(ref GClass8 gclass8_1, ref GClass9 gclass9_1)
		{
			base.Load += this.PixieForm_Load;
			this.gclass12_0 = new GClass12("", GClass12.GEnum5.Manual);
			this.InitializeComponent();
			this.gclass9_0 = gclass9_1;
			this.GClass8_0 = gclass8_1;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00013450 File Offset: 0x00011650
		private void PixieForm_Load(object sender, EventArgs e)
		{
			try
			{
				this.dtpStart.Value = this.dtpStart.Value.AddMonths(-1);
				this.cbMode.SelectedIndex = 0;
				if (this.gclass9_0 != null)
				{
					this.btRetry.Enabled = (Operators.CompareString(this.gclass9_0.PKE, "", false) != 0 & Operators.CompareString(this.gclass9_0.PKR, "", false) != 0 & Operators.CompareString(this.gclass9_0.AuthKey, "", false) != 0 & Operators.CompareString(this.gclass9_0.E_HAS1, "", false) != 0 & Operators.CompareString(this.gclass9_0.E_HAS2, "", false) != 0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00013540 File Offset: 0x00011740
		private void method_0(object sender, EventArgs e)
		{
			switch (this.cbMode.SelectedIndex)
			{
			case 0:
				this.dtpStart.Enabled = true;
				this.dtpEnd.Enabled = true;
				this.cbxForce.Enabled = true;
				return;
			case 1:
			case 2:
			case 4:
			case 5:
				this.dtpStart.Enabled = false;
				this.dtpEnd.Enabled = false;
				this.cbxForce.Enabled = true;
				return;
			case 3:
				this.dtpStart.Enabled = true;
				this.dtpEnd.Enabled = true;
				this.cbxForce.Enabled = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x000135E8 File Offset: 0x000117E8
		private void method_1(object sender, EventArgs e)
		{
			if (this.cbMode.SelectedIndex == 3)
			{
				this.dtpStart.Enabled = !this.cbxForce.Checked;
				this.dtpEnd.Enabled = !this.cbxForce.Checked;
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00013638 File Offset: 0x00011838
		private void method_2(object sender, EventArgs e)
		{
			this.btExcute.Enabled = false;
			this.btRetry.Enabled = false;
			this.btStop.Enabled = true;
			this.Cursor = Cursors.WaitCursor;
			this.GClass8_0.method_9(ref this.gclass9_0);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00004374 File Offset: 0x00002574
		private void method_3(object sender, EventArgs e)
		{
			this.btExcute.Enabled = false;
			this.btRetry.Enabled = false;
			this.btStop.Enabled = true;
			this.Cursor = Cursors.WaitCursor;
			this.method_7();
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00013688 File Offset: 0x00011888
		private void method_4(object sender, EventArgs e)
		{
			if (this.process_0 != null && !this.process_0.HasExited)
			{
				this.process_0.Kill();
			}
			this.GClass8_0.method_10(true);
			this.btExcute.Enabled = true;
			this.btRetry.Enabled = (Operators.CompareString(this.gclass9_0.PKE, "", false) != 0 & Operators.CompareString(this.gclass9_0.PKR, "", false) != 0 & Operators.CompareString(this.gclass9_0.AuthKey, "", false) != 0 & Operators.CompareString(this.gclass9_0.E_HAS1, "", false) != 0 & Operators.CompareString(this.gclass9_0.E_HAS2, "", false) != 0);
			this.btStop.Enabled = false;
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00013770 File Offset: 0x00011970
		private void method_5(GClass8.GEnum1 genum1_0)
		{
			try
			{
				if (base.InvokeRequired)
				{
					PixieForm.GDelegate10 method = new PixieForm.GDelegate10(this.method_5);
					base.Invoke(method, new object[]
					{
						genum1_0
					});
				}
				else
				{
					this.method_6(genum1_0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000137D4 File Offset: 0x000119D4
		private void method_6(GClass8.GEnum1 genum1_0)
		{
			switch (genum1_0)
			{
			case GClass8.GEnum1.Stop:
			case GClass8.GEnum1.Start:
			case GClass8.GEnum1.Testing:
			case (GClass8.GEnum1)3:
			case GClass8.GEnum1.Success:
			case GClass8.GEnum1.NACK:
			case GClass8.GEnum1.Updated:
			case GClass8.GEnum1.Locked:
			case GClass8.GEnum1.ApNotFound:
			case GClass8.GEnum1.AssociationFailed:
				break;
			case GClass8.GEnum1.PixieSucced:
				this.GClass8_0.method_10(false);
				Class6.Class7_0.MainForm_0.method_22("\r\n[P] AuthKey: " + this.gclass9_0.AuthKey, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P]     PKE: " + this.gclass9_0.PKE, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P]     PKR: " + this.gclass9_0.PKR, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P] E-HASH1: " + this.gclass9_0.E_HAS1, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P] E-HASH2: " + this.gclass9_0.E_HAS2, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P] E-NONCE: " + this.gclass9_0.E_NONCE, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22("[P] R-NONCE: " + this.gclass9_0.R_NONCE, Color.White, true);
				Class6.Class7_0.MainForm_0.method_22(Class13.string_4, Color.LightGreen, false);
				this.method_7();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00013968 File Offset: 0x00011B68
		private void method_7()
		{
			string text = "-e " + this.gclass9_0.PKE;
			for (;;)
			{
				IL_1BE:
				text = text + " -r " + this.gclass9_0.PKR;
				for (;;)
				{
					IL_1A5:
					text = text + " -s " + this.gclass9_0.E_HAS1;
					for (;;)
					{
						IL_151:
						text = text + " -z " + this.gclass9_0.E_HAS2;
						text = text + " -a " + this.gclass9_0.AuthKey;
						text = text + " -n " + this.gclass9_0.E_NONCE;
						if (this.cbxRNonce.Checked)
						{
							goto IL_12B;
						}
						for (;;)
						{
							IL_142:
							if (this.cbxEBssid.Checked)
							{
								goto IL_112;
							}
							for (;;)
							{
								IL_104:
								int selectedIndex = this.cbMode.SelectedIndex;
								for (;;)
								{
									IL_E1:
									switch (selectedIndex)
									{
									case 0:
										goto IL_1D7;
									case 1:
										goto IL_22D;
									case 2:
										goto IL_23E;
									case 3:
										goto IL_24C;
									case 4:
										goto IL_2A8;
									case 5:
										goto IL_2B6;
									default:
									{
										uint num2;
										uint num = num2 * 3820013271U ^ 3077862196U;
										for (;;)
										{
											switch ((num2 = (num ^ 2256414163U)) % 35U)
											{
											case 0U:
												goto IL_35C;
											case 1U:
											case 2U:
											case 5U:
											case 16U:
											case 20U:
												goto IL_2C2;
											case 3U:
												goto IL_12B;
											case 6U:
											case 31U:
												goto IL_1BE;
											case 7U:
												goto IL_2F4;
											case 8U:
												goto IL_258;
											case 9U:
												goto IL_104;
											case 10U:
												goto IL_2FF;
											case 11U:
												goto IL_1E7;
											case 12U:
												goto IL_1D7;
											case 13U:
												goto IL_31F;
											case 14U:
												goto IL_2E8;
											case 15U:
												goto IL_22D;
											case 17U:
												goto IL_342;
											case 18U:
												goto IL_2A8;
											case 19U:
												goto IL_32C;
											case 21U:
												goto IL_2B6;
											case 22U:
												goto IL_265;
											case 23U:
												goto IL_369;
											case 24U:
												goto IL_142;
											case 25U:
												goto IL_1A5;
											case 26U:
												goto IL_2DB;
											case 27U:
												num = (num2 * 781617978U ^ 1350863861U);
												continue;
											case 28U:
												goto IL_E1;
											case 29U:
												goto IL_112;
											case 30U:
												goto IL_23E;
											case 32U:
												goto IL_2CF;
											case 33U:
												goto IL_24C;
											case 34U:
												goto IL_151;
											}
											goto Block_1;
										}
										break;
									}
									}
								}
							}
							IL_112:
							text = text + " -b " + this.gclass9_0.BSSID;
							goto IL_104;
						}
						IL_12B:
						text = text + " -m " + this.gclass9_0.R_NONCE;
						goto IL_142;
					}
				}
			}
			Block_1:
			return;
			IL_1D7:
			if (this.cbxForce.Checked)
			{
				goto IL_2C2;
			}
			IL_1E7:
			text += string.Format(" --start {0} --end {1}", this.dtpStart.Value.ToString("MM/yyyy"), this.dtpEnd.Value.ToString("MM/yyyy"));
			goto IL_2C2;
			IL_22D:
			text += " --mode 1 ";
			goto IL_2C2;
			IL_23E:
			text += " --mode 2 ";
			goto IL_2C2;
			IL_24C:
			text += " --mode 3 ";
			IL_258:
			if (this.cbxForce.Checked)
			{
				goto IL_2C2;
			}
			IL_265:
			text += string.Format(" --start {0} --end {1}", this.dtpStart.Value.ToString("MM/yyyy"), this.dtpEnd.Value.ToString("MM/yyyy"));
			goto IL_2C2;
			IL_2A8:
			text += " --mode 4 ";
			goto IL_2C2;
			IL_2B6:
			text += " --mode 5 ";
			IL_2C2:
			if (!this.cbxForce.Checked)
			{
				goto IL_2DB;
			}
			IL_2CF:
			text += " --force ";
			IL_2DB:
			if (!this.cbxLength.Checked)
			{
				goto IL_2F4;
			}
			IL_2E8:
			text += " --length ";
			IL_2F4:
			this.process_0 = new Process();
			IL_2FF:
			Class6.Class7_0.MainForm_0.method_22(" PixieWps " + text, Color.White, true);
			IL_31F:
			string text2 = GClass3.smethod_28(text, ref this.process_0);
			IL_32C:
			Class6.Class7_0.MainForm_0.method_22(text2, Color.White, true);
			IL_342:
			Class6.Class7_0.MainForm_0.method_22(Class13.string_4, Color.LightGreen, false);
			IL_35C:
			Class13.smethod_11(text2, ref this.gclass12_0);
			IL_369:
			this.btStop.PerformClick();
		}

		// Token: 0x0400015B RID: 347
		private IContainer icontainer_0;

		// Token: 0x0400016E RID: 366
		private GClass9 gclass9_0;

		// Token: 0x0400016F RID: 367
		private GClass12 gclass12_0;

		// Token: 0x04000170 RID: 368
		[AccessedThroughProperty("jsApi")]
		[CompilerGenerated]
		private GClass8 gclass8_0;

		// Token: 0x04000171 RID: 369
		private Process process_0;

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600034B RID: 843
		public delegate void GDelegate10(GClass8.GEnum1 status);
	}
}
