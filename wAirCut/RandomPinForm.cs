using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x02000030 RID: 48
	[DesignerGenerated]
	public partial class RandomPinForm : Form
	{
		// Token: 0x0600035F RID: 863 RVA: 0x0001425C File Offset: 0x0001245C
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000442D File Offset: 0x0000262D
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00004435 File Offset: 0x00002635
		internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000443E File Offset: 0x0000263E
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00004446 File Offset: 0x00002646
		internal virtual ToolStripSeparator ToolStripSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000444F File Offset: 0x0000264F
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00014B30 File Offset: 0x00012D30
		internal virtual ToolStripTextBox TbTime
		{
			[CompilerGenerated]
			get
			{
				return this._TbTime;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.method_19);
				ToolStripTextBox tbTime = this._TbTime;
				if (tbTime != null)
				{
					tbTime.KeyPress -= value2;
				}
				this._TbTime = value;
				tbTime = this._TbTime;
				if (tbTime != null)
				{
					tbTime.KeyPress += value2;
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00004457 File Offset: 0x00002657
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00014B74 File Offset: 0x00012D74
		internal virtual ToolStripButton TbStart
		{
			[CompilerGenerated]
			get
			{
				return this._TbStart;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_3);
				ToolStripButton tbStart = this._TbStart;
				if (tbStart != null)
				{
					tbStart.Click -= value2;
				}
				this._TbStart = value;
				tbStart = this._TbStart;
				if (tbStart != null)
				{
					tbStart.Click += value2;
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000445F File Offset: 0x0000265F
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00014BB8 File Offset: 0x00012DB8
		internal virtual ToolStripButton TbStop
		{
			[CompilerGenerated]
			get
			{
				return this._TbStop;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_4);
				ToolStripButton tbStop = this._TbStop;
				if (tbStop != null)
				{
					tbStop.Click -= value2;
				}
				this._TbStop = value;
				tbStop = this._TbStop;
				if (tbStop != null)
				{
					tbStop.Click += value2;
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00004467 File Offset: 0x00002667
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00014BFC File Offset: 0x00012DFC
		internal virtual Timer Timer_0
		{
			[CompilerGenerated]
			get
			{
				return this.timer_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_11);
				Timer timer = this.timer_0;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this.timer_0 = value;
				timer = this.timer_0;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000446F File Offset: 0x0000266F
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00014C40 File Offset: 0x00012E40
		internal virtual ToolStripButton tsbOpen
		{
			[CompilerGenerated]
			get
			{
				return this._tsbOpen;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_13);
				ToolStripButton tsbOpen = this._tsbOpen;
				if (tsbOpen != null)
				{
					tsbOpen.Click -= value2;
				}
				this._tsbOpen = value;
				tsbOpen = this._tsbOpen;
				if (tsbOpen != null)
				{
					tsbOpen.Click += value2;
				}
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00004477 File Offset: 0x00002677
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000447F File Offset: 0x0000267F
		internal virtual Class12 ProgressBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00004490 File Offset: 0x00002690
		internal virtual DataGridView DgvInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00004499 File Offset: 0x00002699
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00014C84 File Offset: 0x00012E84
		internal virtual ToolStripDropDownButton tsbSaveMenu
		{
			[CompilerGenerated]
			get
			{
				return this._tsbSaveMenu;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_15);
				ToolStripDropDownButton tsbSaveMenu = this._tsbSaveMenu;
				if (tsbSaveMenu != null)
				{
					tsbSaveMenu.Click -= value2;
				}
				this._tsbSaveMenu = value;
				tsbSaveMenu = this._tsbSaveMenu;
				if (tsbSaveMenu != null)
				{
					tsbSaveMenu.Click += value2;
				}
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000375 RID: 885 RVA: 0x000044A1 File Offset: 0x000026A1
		// (set) Token: 0x06000376 RID: 886 RVA: 0x00014CC8 File Offset: 0x00012EC8
		internal virtual ToolStripMenuItem tsbAutoSave
		{
			[CompilerGenerated]
			get
			{
				return this._tsbAutoSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_18);
				ToolStripMenuItem tsbAutoSave = this._tsbAutoSave;
				if (tsbAutoSave != null)
				{
					tsbAutoSave.CheckedChanged -= value2;
				}
				this._tsbAutoSave = value;
				tsbAutoSave = this._tsbAutoSave;
				if (tsbAutoSave != null)
				{
					tsbAutoSave.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000044A9 File Offset: 0x000026A9
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00014D0C File Offset: 0x00012F0C
		internal virtual ToolStripMenuItem TsbSave
		{
			[CompilerGenerated]
			get
			{
				return this._TsbSave;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_14);
				ToolStripMenuItem tsbSave = this._TsbSave;
				if (tsbSave != null)
				{
					tsbSave.Click -= value2;
				}
				this._TsbSave = value;
				tsbSave = this._TsbSave;
				if (tsbSave != null)
				{
					tsbSave.Click += value2;
				}
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000379 RID: 889 RVA: 0x000044B1 File Offset: 0x000026B1
		// (set) Token: 0x0600037A RID: 890 RVA: 0x000044B9 File Offset: 0x000026B9
		internal virtual OpenFileDialog OpenFileDialog_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600037B RID: 891 RVA: 0x000044C2 File Offset: 0x000026C2
		// (set) Token: 0x0600037C RID: 892 RVA: 0x000044CA File Offset: 0x000026CA
		internal virtual SaveFileDialog SaveFileDialog_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000044D3 File Offset: 0x000026D3
		// (set) Token: 0x0600037E RID: 894 RVA: 0x000044DB File Offset: 0x000026DB
		internal virtual DataGridViewTextBoxColumn DgvDataCampo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000044E4 File Offset: 0x000026E4
		// (set) Token: 0x06000380 RID: 896 RVA: 0x000044EC File Offset: 0x000026EC
		internal virtual DataGridViewTextBoxColumn DgvDataValor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000044F5 File Offset: 0x000026F5
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000044FD File Offset: 0x000026FD
		internal virtual Label lbResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00004506 File Offset: 0x00002706
		// (set) Token: 0x06000384 RID: 900 RVA: 0x0000450E File Offset: 0x0000270E
		internal virtual ToolStrip tsFormatMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00004517 File Offset: 0x00002717
		// (set) Token: 0x06000386 RID: 902 RVA: 0x0000451F File Offset: 0x0000271F
		internal virtual ToolStripLabel ToolStripLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00004528 File Offset: 0x00002728
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00014D50 File Offset: 0x00012F50
		internal virtual ToolStripTextBox tbPinFormat1
		{
			[CompilerGenerated]
			get
			{
				return this._tbPinFormat1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.method_5);
				ToolStripTextBox tbPinFormat = this._tbPinFormat1;
				if (tbPinFormat != null)
				{
					tbPinFormat.KeyPress -= value2;
				}
				this._tbPinFormat1 = value;
				tbPinFormat = this._tbPinFormat1;
				if (tbPinFormat != null)
				{
					tbPinFormat.KeyPress += value2;
				}
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00014D94 File Offset: 0x00012F94
		internal virtual ToolStripButton tsbCalculate
		{
			[CompilerGenerated]
			get
			{
				return this._tsbCalculate;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_7);
				ToolStripButton tsbCalculate = this._tsbCalculate;
				if (tsbCalculate != null)
				{
					tsbCalculate.Click -= value2;
				}
				this._tsbCalculate = value;
				tsbCalculate = this._tsbCalculate;
				if (tsbCalculate != null)
				{
					tsbCalculate.Click += value2;
				}
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00004538 File Offset: 0x00002738
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00014DD8 File Offset: 0x00012FD8
		internal virtual ToolStripTextBox tbPinFormat2
		{
			[CompilerGenerated]
			get
			{
				return this._tbPinFormat2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.method_6);
				ToolStripTextBox tbPinFormat = this._tbPinFormat2;
				if (tbPinFormat != null)
				{
					tbPinFormat.KeyPress -= value2;
				}
				this._tbPinFormat2 = value;
				tbPinFormat = this._tbPinFormat2;
				if (tbPinFormat != null)
				{
					tbPinFormat.KeyPress += value2;
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00004540 File Offset: 0x00002740
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00014E1C File Offset: 0x0001301C
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
				GClass8.GDelegate8 value2 = new GClass8.GDelegate8(this.method_8);
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

		// Token: 0x0600038F RID: 911 RVA: 0x00014E60 File Offset: 0x00013060
		public RandomPinForm(ref GClass8 gclass8_1, ref GClass9 gclass9_1, bool bool_7)
		{
			base.Load += this.RandomPinForm_Load;
			base.FormClosed += this.RandomPinForm_FormClosed;
			this.gclass13_0 = new GClass13();
			this.gclass12_0 = new GClass12("12345670", GClass12.GEnum5.Manual);
			this.string_0 = "";
			this.bool_0 = false;
			this.int_2 = 0;
			this.bool_1 = false;
			this.double_0 = 0.0;
			this.int_3 = 0;
			this.int_4 = 0;
			this.string_1 = "";
			this.bool_3 = false;
			this.int_5 = 0;
			this.int_6 = 0;
			this.bool_4 = false;
			this.string_2 = "";
			this.genum6_0 = RandomPinForm.GEnum6.None;
			this.genum6_1 = RandomPinForm.GEnum6.None;
			this.int_7 = -1;
			this.bool_5 = false;
			this.list_0 = new List<string>();
			this.bool_6 = true;
			this.InitializeComponent();
			if (bool_7)
			{
				this.list_0 = this.gclass13_0.method_3(this.bool_6);
				this.Text = Class10.String_73;
			}
			else
			{
				try
				{
					foreach (GClass12 gclass in gclass9_1.gclass15_0)
					{
						this.list_0.Add(gclass.Pin);
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
				this.Text = Class10.String_74;
				this.tsFormatMenu.Visible = false;
			}
			this.int_7 = 0;
			this.gclass12_0 = new GClass12(this.list_0[this.int_7], GClass12.GEnum5.BruteForce);
			this.ProgressBar1.Maximum = this.list_0.Count;
			this.bool_5 = bool_7;
			this.gclass9_0 = gclass9_1;
			this.GClass8_0 = gclass8_1;
			this.string_2 = "log\\" + gclass9_1.BSSID.Replace(":", "") + ".log";
			this.method_1();
			this.tbPinFormat1.Tag = "";
			this.tbPinFormat2.Tag = "";
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00015084 File Offset: 0x00013284
		private void RandomPinForm_Load(object sender, EventArgs e)
		{
			this.method_2();
			this.DgvInfo.ClearSelection();
			this.tsbOpen.Visible = this.bool_5;
			this.tsbSaveMenu.Visible = this.bool_5;
			if (File.Exists(this.string_2))
			{
				if (MessageBox.Show(Class10.String_64, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.method_0();
				}
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000150F0 File Offset: 0x000132F0
		private void method_0()
		{
			this.list_0.Clear();
			if (this.method_16(this.string_2))
			{
				if (this.int_7 == -1)
				{
					this.int_7 = 0;
				}
				if (this.int_7 >= this.list_0.Count)
				{
					this.int_7 = checked(this.list_0.Count - 1);
				}
				this.gclass12_0 = new GClass12(this.list_0[this.int_7], GClass12.GEnum5.BruteForce);
				this.method_2();
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00004548 File Offset: 0x00002748
		private void RandomPinForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.TbStop.PerformClick();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00015174 File Offset: 0x00013374
		private void method_1()
		{
			this.DgvInfo.Rows.Add(7);
			this.DgvInfo.Rows[0].Cells[0].Value = "SSID";
			this.DgvInfo.Rows[1].Cells[0].Value = "BSSID";
			this.DgvInfo.Rows[2].Cells[0].Value = Class10.String_27;
			this.DgvInfo.Rows[3].Cells[0].Value = Class10.String_28;
			this.DgvInfo.Rows[4].Cells[0].Value = Class10.String_26;
			this.DgvInfo.Rows[5].Cells[0].Value = "PIN";
			this.DgvInfo.Rows[6].Cells[0].Value = "Key";
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000152A0 File Offset: 0x000134A0
		private void method_2()
		{
			this.timeSpan_0 = TimeSpan.FromSeconds(this.double_0);
			this.DgvInfo.Rows[0].Cells[1].Value = this.gclass9_0.SSID;
			for (;;)
			{
				IL_15D:
				this.DgvInfo.Rows[1].Cells[1].Value = this.gclass9_0.BSSID;
				this.DgvInfo.Rows[2].Cells[1].Value = string.Format(Class10.String_63, new object[]
				{
					this.timeSpan_0.Days,
					this.timeSpan_0.Hours,
					this.timeSpan_0.Minutes,
					this.timeSpan_0.Seconds,
					this.timeSpan_1.Days,
					this.timeSpan_1.Hours,
					this.timeSpan_1.Minutes,
					this.timeSpan_1.Seconds
				});
				this.DgvInfo.Rows[3].Cells[1].Value = string.Format(Class10.String_72, this.int_7.ToString("00000"), this.list_0.Count.ToString("00000"));
				for (;;)
				{
					IL_12F:
					this.DgvInfo.Rows[4].Cells[1].Value = this.int_2;
					for (;;)
					{
						IL_126:
						RandomPinForm.GEnum6 genum = this.genum6_1;
						for (;;)
						{
							IL_FF:
							switch (genum)
							{
							case RandomPinForm.GEnum6.None:
								goto IL_2AA;
							case RandomPinForm.GEnum6.Ok:
								goto IL_2E5;
							case RandomPinForm.GEnum6.NoOk:
								goto IL_35C;
							case RandomPinForm.GEnum6.fHalfOk:
								goto IL_3A7;
							case RandomPinForm.GEnum6.Fault:
								goto IL_3F2;
							case RandomPinForm.GEnum6.ApLocked:
								goto IL_466;
							case RandomPinForm.GEnum6.PinNotFound:
								goto IL_494;
							default:
							{
								uint num2;
								uint num = num2 * 935932444U ^ 264177942U;
								for (;;)
								{
									switch ((num2 = (num ^ 4269094284U)) % 35U)
									{
									case 0U:
										goto IL_392;
									case 1U:
									case 3U:
									case 6U:
									case 7U:
									case 12U:
									case 32U:
										goto IL_4C0;
									case 2U:
										num = (num2 * 125493163U ^ 2325440787U);
										continue;
									case 4U:
										goto IL_2AA;
									case 5U:
										goto IL_3D2;
									case 9U:
										goto IL_466;
									case 10U:
										goto IL_31B;
									case 11U:
									case 24U:
										goto IL_15D;
									case 13U:
										goto IL_33B;
									case 14U:
										goto IL_310;
									case 15U:
										goto IL_527;
									case 16U:
										goto IL_12F;
									case 17U:
										goto IL_4A4;
									case 18U:
										goto IL_476;
									case 19U:
										goto IL_438;
									case 20U:
										goto IL_387;
									case 21U:
										goto IL_428;
									case 22U:
										goto IL_FF;
									case 23U:
										goto IL_2E5;
									case 25U:
										goto IL_3A7;
									case 26U:
										goto IL_32B;
									case 27U:
										goto IL_458;
									case 28U:
										goto IL_126;
									case 29U:
										goto IL_3F2;
									case 30U:
										goto IL_4B4;
									case 31U:
										goto IL_494;
									case 33U:
										goto IL_35C;
									case 34U:
										goto IL_3DD;
									}
									goto Block_1;
								}
								break;
							}
							}
						}
					}
				}
			}
			Block_1:
			goto IL_553;
			IL_2AA:
			this.DgvInfo.Rows[5].Cells[1].Style.ForeColor = Control.DefaultForeColor;
			this.string_1 = "";
			goto IL_4C0;
			IL_2E5:
			this.DgvInfo.Rows[5].Cells[1].Style.ForeColor = Color.Green;
			IL_310:
			this.string_1 = Class10.String_75;
			IL_31B:
			this.ProgressBar1.Color_0 = Color.Green;
			IL_32B:
			this.lbResult.Text = Class10.String_69;
			IL_33B:
			this.lbResult.BackColor = Color.Green;
			this.lbResult.Visible = true;
			goto IL_4C0;
			IL_35C:
			this.DgvInfo.Rows[5].Cells[1].Style.ForeColor = Color.Red;
			IL_387:
			this.string_1 = Class10.String_68;
			IL_392:
			this.ProgressBar1.Color_0 = Color.Red;
			goto IL_4C0;
			IL_3A7:
			this.DgvInfo.Rows[5].Cells[1].Style.ForeColor = Color.Orange;
			IL_3D2:
			this.string_1 = Class10.String_66;
			IL_3DD:
			this.ProgressBar1.Color_0 = Color.Yellow;
			goto IL_4C0;
			IL_3F2:
			this.DgvInfo.Rows[5].Cells[1].Style.ForeColor = Color.Red;
			this.string_1 = Class10.String_71;
			IL_428:
			this.ProgressBar1.Color_0 = Color.Red;
			IL_438:
			this.lbResult.Text = Class10.String_71;
			this.lbResult.BackColor = Color.Red;
			IL_458:
			this.lbResult.Visible = true;
			goto IL_4C0;
			IL_466:
			this.lbResult.Text = Class10.String_62;
			IL_476:
			this.lbResult.BackColor = Color.Red;
			this.lbResult.Visible = true;
			goto IL_4C0;
			IL_494:
			this.lbResult.Text = Class10.String_70;
			IL_4A4:
			this.lbResult.BackColor = Color.Red;
			IL_4B4:
			this.lbResult.Visible = true;
			IL_4C0:
			this.DgvInfo.Rows[5].Cells[1].Value = string.Format("{0} {1}", this.gclass12_0.Pin, this.string_1);
			this.DgvInfo.Rows[6].Cells[1].Style.ForeColor = Color.Green;
			IL_527:
			this.DgvInfo.Rows[6].Cells[1].Value = this.gclass9_0.NetworkKey;
			IL_553:
			this.ProgressBar1.Maximum = this.list_0.Count;
			this.ProgressBar1.Value = this.int_7;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00015828 File Offset: 0x00013A28
		private void method_3(object sender, EventArgs e)
		{
			if (Conversions.ToInteger(this.TbTime.Text) < 5)
			{
				this.TbTime.Text = "5";
			}
			this.TbTime.Enabled = false;
			this.GClass8_0.method_7(ref this.gclass9_0, this.gclass12_0);
			this.genum6_0 = RandomPinForm.GEnum6.None;
			this.genum6_1 = RandomPinForm.GEnum6.None;
			this.bool_1 = true;
			RandomPinForm.bool_2 = true;
			this.Timer_0.Enabled = true;
			this.tsbOpen.Enabled = false;
			this.tsbSaveMenu.Enabled = true;
			this.TbStop.Enabled = true;
			this.TbStart.Enabled = false;
			this.lbResult.Visible = false;
			this.tbPinFormat1.Enabled = false;
			this.tbPinFormat2.Enabled = false;
			this.tsbCalculate.Enabled = false;
			if (this.int_7 <= 0)
			{
				this.timeSpan_1 = TimeSpan.FromSeconds((double)(checked(this.list_0.Count * Conversions.ToInteger(this.TbTime.Text) + this.int_7 * 4)));
				return;
			}
			this.timeSpan_1 = TimeSpan.FromSeconds(this.double_0 / (double)this.int_7 * (double)(checked(this.list_0.Count - this.int_7)));
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0001596C File Offset: 0x00013B6C
		private void method_4(object sender, EventArgs e)
		{
			this.TbTime.Enabled = true;
			this.method_2();
			this.int_2 = 0;
			this.bool_1 = false;
			RandomPinForm.bool_2 = false;
			this.GClass8_0.method_10(true);
			this.Timer_0.Enabled = false;
			this.tsbOpen.Enabled = true;
			this.tsbSaveMenu.Enabled = true;
			this.TbStop.Enabled = false;
			this.TbStart.Enabled = true;
			this.tbPinFormat1.Enabled = true;
			this.tbPinFormat2.Enabled = true;
			this.tsbCalculate.Enabled = true;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00015A0C File Offset: 0x00013C0C
		private void method_5(object sender, KeyPressEventArgs e)
		{
			int num = 4;
			string left = "";
			this.tbPinFormat1.Tag = "";
			checked
			{
				if (this.tbPinFormat1.SelectionStart > 0)
				{
					left = Conversions.ToString(this.tbPinFormat1.Text[this.tbPinFormat1.SelectionStart - 1]);
					int num2 = this.tbPinFormat1.SelectionStart - 1;
					for (int i = 0; i <= num2; i++)
					{
						char c = this.tbPinFormat1.Text[i];
						if (c != '-')
						{
							if (c == '[')
							{
								this.tbPinFormat1.Tag = "[";
							}
							else if (c == ']')
							{
								this.tbPinFormat1.Tag = "";
							}
						}
						else
						{
							this.tbPinFormat1.Tag = "[-";
						}
					}
				}
				int num3 = this.tbPinFormat1.Text.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					if (Operators.CompareString(Conversions.ToString(this.tbPinFormat1.Text[j]), "[", false) == 0)
					{
						num += 4;
					}
				}
				string text;
				if (Operators.CompareString(left, "[", false) != 0)
				{
					if (Operators.CompareString(left, "-", false) == 0)
					{
						text = "01234567890";
					}
					else
					{
						object tag = this.tbPinFormat1.Tag;
						if (!Operators.ConditionalCompareObjectEqual(tag, "[", false))
						{
							if (!Operators.ConditionalCompareObjectEqual(tag, "[-", false))
							{
								text = "01234567890[?";
							}
							else
							{
								text = "]";
							}
						}
						else
						{
							text = "-";
						}
					}
				}
				else
				{
					text = "01234567890";
				}
				if (e.KeyChar >= ' ' && !text.Contains(Conversions.ToString(e.KeyChar)))
				{
					e.Handled = true;
				}
				if (text.Contains(Conversions.ToString(e.KeyChar)) & this.tbPinFormat1.Text.Length >= num)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00015BF4 File Offset: 0x00013DF4
		private void method_6(object sender, KeyPressEventArgs e)
		{
			int num = 4;
			string left = "";
			this.tbPinFormat2.Tag = "";
			checked
			{
				if (this.tbPinFormat2.SelectionStart > 0)
				{
					left = Conversions.ToString(this.tbPinFormat2.Text[this.tbPinFormat2.SelectionStart - 1]);
					int num2 = this.tbPinFormat2.SelectionStart - 1;
					for (int i = 0; i <= num2; i++)
					{
						char c = this.tbPinFormat2.Text[i];
						if (c == '-')
						{
							this.tbPinFormat2.Tag = "[-";
						}
						else if (c == '[')
						{
							this.tbPinFormat2.Tag = "[";
						}
						else if (c == ']')
						{
							this.tbPinFormat2.Tag = "";
						}
					}
				}
				int num3 = this.tbPinFormat2.Text.Length - 1;
				for (int j = 0; j <= num3; j++)
				{
					if (Operators.CompareString(Conversions.ToString(this.tbPinFormat2.Text[j]), "[", false) == 0)
					{
						num += 4;
					}
				}
				string text;
				if (Operators.CompareString(left, "[", false) == 0)
				{
					text = "01234567890";
				}
				else if (Operators.CompareString(left, "-", false) == 0)
				{
					text = "01234567890";
				}
				else
				{
					object tag = this.tbPinFormat2.Tag;
					if (Operators.ConditionalCompareObjectEqual(tag, "[", false))
					{
						text = "-";
					}
					else if (!Operators.ConditionalCompareObjectEqual(tag, "[-", false))
					{
						if (this.tbPinFormat2.SelectionStart != num - 1)
						{
							text = "01234567890[?";
						}
						else
						{
							text = "01234567890?C";
						}
					}
					else
					{
						text = "]";
					}
				}
				if (e.KeyChar >= ' ' && !text.Contains(Conversions.ToString(e.KeyChar)))
				{
					e.Handled = true;
				}
				if (text.Contains(Conversions.ToString(e.KeyChar)) & this.tbPinFormat2.Text.Length >= num)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00015DF4 File Offset: 0x00013FF4
		private void method_7(object sender, EventArgs e)
		{
			this.list_0 = this.gclass13_0.method_4(this.tbPinFormat1.Text, this.tbPinFormat2.Text);
			this.int_7 = 0;
			this.gclass12_0 = new GClass12(this.list_0[this.int_7], GClass12.GEnum5.BruteForce);
			this.genum6_1 = RandomPinForm.GEnum6.None;
			this.string_1 = "";
			this.method_2();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00015E64 File Offset: 0x00014064
		private void method_8(GClass8.GEnum1 genum1_0)
		{
			try
			{
				if (base.InvokeRequired)
				{
					RandomPinForm.GDelegate11 method = new RandomPinForm.GDelegate11(this.method_8);
					base.Invoke(method, new object[]
					{
						genum1_0
					});
				}
				else
				{
					this.method_9(genum1_0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00015EC8 File Offset: 0x000140C8
		private void method_9(GClass8.GEnum1 genum1_0)
		{
			for (;;)
			{
				IL_F4:
				uint num2;
				uint num;
				switch (genum1_0)
				{
				case GClass8.GEnum1.Stop:
					IL_D5:
					if (!this.bool_1)
					{
						goto Block_3;
					}
					goto IL_AC;
				case GClass8.GEnum1.Start:
					goto IL_16B;
				case GClass8.GEnum1.Testing:
				case (GClass8.GEnum1)3:
				case GClass8.GEnum1.Success:
				case GClass8.GEnum1.NACK:
				case GClass8.GEnum1.Updated:
				case GClass8.GEnum1.PixieSucced:
					return;
				case GClass8.GEnum1.Locked:
					goto IL_17A;
				case GClass8.GEnum1.ApNotFound:
					goto IL_188;
				case GClass8.GEnum1.AssociationFailed:
					goto IL_1CE;
				default:
					num = (num2 * 177209341U ^ 4035751871U);
					break;
				}
				for (;;)
				{
					IL_23:
					switch ((num2 = (num ^ 967167044U)) % 29U)
					{
					case 0U:
					case 12U:
						goto IL_F4;
					case 1U:
						goto IL_1A2;
					case 2U:
						goto IL_138;
					case 3U:
						goto IL_15D;
					case 4U:
						goto IL_17A;
					case 5U:
						goto IL_188;
					case 6U:
					case 11U:
						goto IL_163;
					case 7U:
						goto IL_129;
					case 8U:
						return;
					case 9U:
						return;
					case 10U:
						return;
					case 13U:
						goto IL_18F;
					case 14U:
						goto IL_181;
					case 15U:
						return;
					case 16U:
						goto IL_14E;
					case 17U:
						goto IL_AC;
					case 18U:
						num = (num2 * 3375262021U ^ 1924676518U);
						continue;
					case 19U:
						return;
					case 20U:
						goto IL_156;
					case 21U:
						goto IL_1AB;
					case 22U:
						goto IL_D5;
					case 23U:
						goto IL_1CE;
					case 25U:
						goto IL_147;
					case 26U:
						goto IL_1B7;
					case 27U:
						goto IL_16B;
					case 28U:
						goto IL_172;
					}
					goto Block_1;
				}
				IL_AC:
				switch (this.GClass8_0.genum2_0)
				{
				case GClass8.GEnum2.Nok:
					goto IL_129;
				case GClass8.GEnum2.Ok:
					goto IL_138;
				case GClass8.GEnum2.fHalfOk:
					goto IL_147;
				case GClass8.GEnum2.Fault:
					goto IL_156;
				default:
					num = (num2 * 1164684242U ^ 4050660562U);
					goto IL_23;
				}
			}
			Block_1:
			return;
			Block_3:
			goto IL_163;
			IL_129:
			this.genum6_0 = RandomPinForm.GEnum6.NoOk;
			RandomPinForm.bool_2 = false;
			goto IL_163;
			IL_138:
			this.genum6_0 = RandomPinForm.GEnum6.Ok;
			RandomPinForm.bool_2 = false;
			goto IL_163;
			IL_147:
			this.genum6_0 = RandomPinForm.GEnum6.fHalfOk;
			IL_14E:
			RandomPinForm.bool_2 = false;
			goto IL_163;
			IL_156:
			this.genum6_0 = RandomPinForm.GEnum6.Fault;
			IL_15D:
			RandomPinForm.bool_2 = false;
			IL_163:
			this.bool_4 = true;
			return;
			IL_16B:
			this.genum6_0 = RandomPinForm.GEnum6.None;
			IL_172:
			this.int_6 = 0;
			return;
			IL_17A:
			this.genum6_0 = RandomPinForm.GEnum6.ApLocked;
			IL_181:
			RandomPinForm.bool_2 = false;
			return;
			IL_188:
			this.genum6_0 = RandomPinForm.GEnum6.ApNotFound;
			IL_18F:
			RandomPinForm.bool_2 = false;
			ref int ptr = ref this.int_6;
			this.int_6 = checked(ptr + 1);
			IL_1A2:
			if (this.int_6 <= 5)
			{
				goto IL_1B7;
			}
			IL_1AB:
			this.TbStop.PerformClick();
			return;
			IL_1B7:
			this.int_2 = Conversions.ToInteger(this.TbTime.Text);
			return;
			IL_1CE:
			this.genum6_0 = RandomPinForm.GEnum6.AssociationFailed;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x000160AC File Offset: 0x000142AC
		private void method_10()
		{
			RandomPinForm.GEnum6 genum = this.genum6_0;
			for (;;)
			{
				IL_B5:
				switch (genum)
				{
				case RandomPinForm.GEnum6.Ok:
					goto IL_E2;
				case RandomPinForm.GEnum6.NoOk:
					goto IL_F2;
				case RandomPinForm.GEnum6.fHalfOk:
					goto IL_11A;
				case RandomPinForm.GEnum6.Fault:
					goto IL_1BA;
				case RandomPinForm.GEnum6.ApLocked:
					goto IL_206;
				case RandomPinForm.GEnum6.PinNotFound:
					goto IL_26F;
				case RandomPinForm.GEnum6.ApNotFound:
					goto IL_213;
				case RandomPinForm.GEnum6.AssociationFailed:
					goto IL_24E;
				default:
				{
					uint num2;
					uint num = num2 * 3667114684U ^ 1250860089U;
					for (;;)
					{
						switch ((num2 = (num ^ 2394794205U)) % 30U)
						{
						case 0U:
							goto IL_236;
						case 1U:
							goto IL_24E;
						case 2U:
							goto IL_12C;
						case 3U:
							goto IL_1CE;
						case 4U:
							goto IL_192;
						case 5U:
							goto IL_14B;
						case 6U:
						case 10U:
						case 11U:
						case 17U:
						case 22U:
						case 26U:
							goto IL_26F;
						case 7U:
							goto IL_1D7;
						case 8U:
							goto IL_213;
						case 9U:
							goto IL_E2;
						case 12U:
							goto IL_F2;
						case 13U:
							goto IL_1EE;
						case 14U:
							goto IL_206;
						case 15U:
						case 16U:
							goto IL_B5;
						case 18U:
							goto IL_264;
						case 19U:
							goto IL_11A;
						case 20U:
							num = (num2 * 800848034U ^ 1475077945U);
							continue;
						case 21U:
							goto IL_1C1;
						case 23U:
							goto IL_229;
						case 24U:
							goto IL_220;
						case 25U:
							goto IL_168;
						case 28U:
							goto IL_19F;
						case 29U:
							goto IL_1BA;
						}
						goto Block_1;
					}
					break;
				}
				}
			}
			Block_1:
			return;
			IL_E2:
			this.TbStop.PerformClick();
			goto IL_26F;
			IL_F2:
			ref int ptr = ref this.int_7;
			checked
			{
				this.int_7 = ptr + 1;
				this.int_2 = Conversions.ToInteger(this.TbTime.Text);
				goto IL_26F;
				IL_11A:
				if (!(!this.bool_0 & this.bool_5))
				{
					goto IL_192;
				}
				IL_12C:
				this.string_0 = this.gclass12_0.Pin.Substring(0, 4);
				this.bool_0 = true;
				IL_14B:
				this.list_0 = this.gclass13_0.method_5(Conversions.ToInteger(this.string_0), true);
				IL_168:
				this.list_0.Remove(Conversions.ToString(Conversions.ToUInteger(this.gclass12_0.Pin)));
				this.int_7 = 0;
				goto IL_19F;
				IL_192:
				ptr = ref this.int_7;
				this.int_7 = ptr + 1;
				IL_19F:
				this.int_2 = Conversions.ToInteger(this.TbTime.Text);
				goto IL_26F;
				IL_1BA:
				this.bool_3 = true;
				IL_1C1:
				ptr = ref this.int_5;
				this.int_5 = ptr + 1;
				IL_1CE:
				if (this.int_5 < 6)
				{
					goto IL_1EE;
				}
				IL_1D7:
				this.genum6_0 = RandomPinForm.GEnum6.Fault;
				this.TbStop.PerformClick();
				goto IL_26F;
				IL_1EE:
				this.int_2 = Conversions.ToInteger(this.TbTime.Text);
				goto IL_26F;
				IL_206:
				this.TbStop.PerformClick();
				goto IL_26F;
				IL_213:
				ptr = ref this.int_6;
				this.int_6 = ptr + 1;
				IL_220:
				if (this.int_6 <= 5)
				{
					goto IL_236;
				}
				IL_229:
				this.TbStop.PerformClick();
				goto IL_26F;
				IL_236:
				this.int_2 = Conversions.ToInteger(this.TbTime.Text);
				goto IL_26F;
				IL_24E:
				ptr = ref this.int_6;
				this.int_6 = ptr + 1;
				if (this.int_6 <= 5)
				{
					goto IL_26F;
				}
				IL_264:
				this.TbStop.PerformClick();
				IL_26F:
				this.genum6_1 = this.genum6_0;
				this.genum6_0 = RandomPinForm.GEnum6.None;
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001633C File Offset: 0x0001453C
		private void method_11(object sender, EventArgs e)
		{
			if (base.InvokeRequired)
			{
				RandomPinForm.GDelegate12 method = new RandomPinForm.GDelegate12(this.method_11);
				base.Invoke(method, new object[]
				{
					sender,
					e
				});
				return;
			}
			this.method_12(RuntimeHelpers.GetObjectValue(sender), e);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00016384 File Offset: 0x00014584
		private void method_12(object sender, EventArgs e)
		{
			this.Timer_0.Stop();
			if (this.bool_1)
			{
				double ptr2;
				checked
				{
					if (this.int_2 > 0)
					{
						if (this.int_7 >= this.list_0.Count)
						{
							this.int_7 = this.list_0.Count;
							this.genum6_0 = RandomPinForm.GEnum6.PinNotFound;
							this.genum6_1 = this.genum6_0;
							this.method_2();
							this.TbStop.PerformClick();
						}
						else
						{
							ref int ptr = ref this.int_2;
							this.int_2 = ptr - 1;
							RandomPinForm.bool_2 = false;
						}
					}
					if (RandomPinForm.bool_2)
					{
						ref int ptr = ref this.int_3;
						this.int_3 = ptr + 1;
					}
					else
					{
						this.int_4 = this.int_3;
						this.timeSpan_1 = TimeSpan.FromSeconds((double)((Conversions.ToInteger(this.TbTime.Text) + this.int_4) * (this.list_0.Count - this.int_7)));
					}
					ptr2 = ref this.double_0;
				}
				this.double_0 = ptr2 + 1.0;
				if ((!RandomPinForm.bool_2 & this.genum6_0 > RandomPinForm.GEnum6.None) | (RandomPinForm.bool_2 & this.genum6_0 == RandomPinForm.GEnum6.AssociationFailed))
				{
					this.method_10();
				}
				if (this.int_2 == 0 & !RandomPinForm.bool_2 & this.bool_1)
				{
					if (this.int_7 < this.list_0.Count)
					{
						this.gclass12_0 = new GClass12(this.list_0[this.int_7], GClass12.GEnum5.BruteForce);
						this.bool_3 = false;
						this.genum6_0 = RandomPinForm.GEnum6.None;
						this.genum6_1 = this.genum6_0;
						this.method_2();
						this.GClass8_0.method_7(ref this.gclass9_0, this.gclass12_0);
						RandomPinForm.bool_2 = true;
						this.int_3 = 0;
					}
				}
				else
				{
					this.method_2();
				}
			}
			if ((this.bool_4 & this.bool_5) && (this.tsbAutoSave.Checked & Operators.CompareString(this.string_2, "", false) != 0))
			{
				this.TsbSave.PerformClick();
			}
			this.Timer_0.Start();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00004555 File Offset: 0x00002755
		private void method_13(object sender, EventArgs e)
		{
			this.OpenFileDialog_0.FileName = this.string_2;
			if (this.OpenFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.string_2 = this.OpenFileDialog_0.FileName;
				this.method_0();
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00016584 File Offset: 0x00014784
		private void method_14(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.string_2, "", false) == 0)
			{
				this.SaveFileDialog_0.FileName = this.string_2;
				if (this.SaveFileDialog_0.ShowDialog() == DialogResult.OK)
				{
					this.string_2 = this.SaveFileDialog_0.FileName;
				}
			}
			if (Operators.CompareString(this.string_2, "", false) != 0)
			{
				this.method_17(this.string_2);
				this.bool_4 = false;
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000458F File Offset: 0x0000278F
		private void method_15(object sender, EventArgs e)
		{
			this.TsbSave.Enabled = !this.tsbAutoSave.Checked;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000165FC File Offset: 0x000147FC
		public bool method_16(string string_3)
		{
			FileStream fileStream = new FileStream(string_3, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			string left = new string(binaryReader.ReadChars(7));
			checked
			{
				int num = (int)binaryReader.ReadUInt32();
				int num2 = (int)binaryReader.ReadUInt32();
				string left2 = new string(binaryReader.ReadChars(num2));
				num2 = (int)binaryReader.ReadUInt32();
				new string(binaryReader.ReadChars(num2));
				bool result;
				if (!(Operators.CompareString(left, "WairCut", false) != 0 | num > 2))
				{
					if (Operators.CompareString(left2, this.gclass9_0.BSSID, false) != 0)
					{
						MessageBox.Show(Class10.String_67, "Error...", MessageBoxButtons.OK);
						result = false;
					}
					else
					{
						if (num >= 2)
						{
							num2 = (int)binaryReader.ReadUInt32();
							this.tbPinFormat1.Text = new string(binaryReader.ReadChars(num2));
							num2 = (int)binaryReader.ReadUInt32();
							this.tbPinFormat2.Text = new string(binaryReader.ReadChars(num2));
						}
						this.TbTime.Text = binaryReader.ReadInt32().ToString();
						this.int_7 = binaryReader.ReadInt32();
						this.bool_0 = binaryReader.ReadBoolean();
						this.double_0 = (double)binaryReader.ReadInt32();
						num2 = binaryReader.ReadInt32();
						int num3 = num2 - 1;
						for (int i = 0; i <= num3; i++)
						{
							this.list_0.Add(Conversions.ToString(binaryReader.ReadUInt32()));
						}
						binaryReader.Close();
						fileStream.Close();
						result = true;
					}
				}
				else
				{
					MessageBox.Show(Class10.String_65, "Error...", MessageBoxButtons.OK);
					result = false;
				}
				return result;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0001678C File Offset: 0x0001498C
		private void method_17(string string_3)
		{
			FileStream fileStream = new FileStream(string_3, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write("WairCut".ToCharArray());
			binaryWriter.Write(2);
			binaryWriter.Write(this.gclass9_0.BSSID.Length);
			binaryWriter.Write(this.gclass9_0.BSSID.ToCharArray());
			binaryWriter.Write(this.gclass9_0.SSID.Length);
			binaryWriter.Write(this.gclass9_0.SSID.ToCharArray());
			binaryWriter.Write(this.tbPinFormat1.Text.Length);
			binaryWriter.Write(this.tbPinFormat1.Text.ToCharArray());
			binaryWriter.Write(this.tbPinFormat2.Text.Length);
			binaryWriter.Write(this.tbPinFormat2.Text.ToCharArray());
			binaryWriter.Write(Conversions.ToInteger(this.TbTime.Text));
			binaryWriter.Write(this.int_7);
			binaryWriter.Write(this.bool_0);
			binaryWriter.Write(checked((int)Math.Round(this.double_0)));
			binaryWriter.Write(this.list_0.Count);
			try
			{
				foreach (string value in this.list_0)
				{
					uint value2 = Conversions.ToUInteger(value);
					binaryWriter.Write(value2);
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			binaryWriter.Close();
			fileStream.Close();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000045AA File Offset: 0x000027AA
		private void method_18(object sender, EventArgs e)
		{
			if (this.tsbAutoSave.Checked)
			{
				this.tsbSaveMenu.Image = GClass0.Bitmap_5;
				return;
			}
			this.tsbSaveMenu.Image = GClass0.Bitmap_49;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00003B20 File Offset: 0x00001D20
		private void method_19(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))
			{
				e.Handled = false;
				return;
			}
			e.Handled = true;
		}

		// Token: 0x0400017D RID: 381
		[CompilerGenerated]
		[AccessedThroughProperty("TUpdate")]
		private Timer timer_0;

		// Token: 0x04000184 RID: 388
		[CompilerGenerated]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04000185 RID: 389
		[AccessedThroughProperty("SaveFileDialog1")]
		[CompilerGenerated]
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x0400018E RID: 398
		private const int int_0 = 10000;

		// Token: 0x0400018F RID: 399
		private const int int_1 = 1000;

		// Token: 0x04000190 RID: 400
		private GClass13 gclass13_0;

		// Token: 0x04000191 RID: 401
		private GClass9 gclass9_0;

		// Token: 0x04000192 RID: 402
		private GClass12 gclass12_0;

		// Token: 0x04000193 RID: 403
		private string string_0;

		// Token: 0x04000194 RID: 404
		private bool bool_0;

		// Token: 0x04000195 RID: 405
		[AccessedThroughProperty("jsApi")]
		[CompilerGenerated]
		private GClass8 gclass8_0;

		// Token: 0x04000196 RID: 406
		private int int_2;

		// Token: 0x04000197 RID: 407
		private bool bool_1;

		// Token: 0x04000198 RID: 408
		private static bool bool_2 = false;

		// Token: 0x04000199 RID: 409
		private TimeSpan timeSpan_0;

		// Token: 0x0400019A RID: 410
		private TimeSpan timeSpan_1;

		// Token: 0x0400019B RID: 411
		private double double_0;

		// Token: 0x0400019C RID: 412
		private int int_3;

		// Token: 0x0400019D RID: 413
		private int int_4;

		// Token: 0x0400019E RID: 414
		private string string_1;

		// Token: 0x0400019F RID: 415
		private bool bool_3;

		// Token: 0x040001A0 RID: 416
		private int int_5;

		// Token: 0x040001A1 RID: 417
		private int int_6;

		// Token: 0x040001A2 RID: 418
		private bool bool_4;

		// Token: 0x040001A3 RID: 419
		private string string_2;

		// Token: 0x040001A4 RID: 420
		private RandomPinForm.GEnum6 genum6_0;

		// Token: 0x040001A5 RID: 421
		private RandomPinForm.GEnum6 genum6_1;

		// Token: 0x040001A6 RID: 422
		private int int_7;

		// Token: 0x040001A7 RID: 423
		private bool bool_5;

		// Token: 0x040001A8 RID: 424
		private List<string> list_0;

		// Token: 0x040001A9 RID: 425
		private bool bool_6;

		// Token: 0x02000031 RID: 49
		public enum GEnum6
		{
			// Token: 0x040001AB RID: 427
			None,
			// Token: 0x040001AC RID: 428
			Ok,
			// Token: 0x040001AD RID: 429
			NoOk,
			// Token: 0x040001AE RID: 430
			fHalfOk,
			// Token: 0x040001AF RID: 431
			Fault,
			// Token: 0x040001B0 RID: 432
			ApLocked,
			// Token: 0x040001B1 RID: 433
			PinNotFound,
			// Token: 0x040001B2 RID: 434
			ApNotFound,
			// Token: 0x040001B3 RID: 435
			AssociationFailed
		}

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060003A9 RID: 937
		public delegate void GDelegate11(GClass8.GEnum1 status);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060003AD RID: 941
		public delegate void GDelegate12(object sender, EventArgs e);
	}
}
