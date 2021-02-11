using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using wAirCut.My;

namespace wAirCut
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class MainForm : Form
	{
		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000039A6 File Offset: 0x00001BA6
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00008E30 File Offset: 0x00007030
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
				GClass8.GDelegate6 value2 = new GClass8.GDelegate6(this.method_21);
				GClass8.GDelegate8 value3 = new GClass8.GDelegate8(this.method_24);
				GClass8 gclass = this.gclass8_0;
				if (gclass != null)
				{
					gclass.Event_0 -= value2;
					gclass.Event_2 -= value3;
				}
				this.gclass8_0 = value;
				gclass = this.gclass8_0;
				if (gclass != null)
				{
					gclass.Event_0 += value2;
					gclass.Event_2 += value3;
				}
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000039AE File Offset: 0x00001BAE
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00008E90 File Offset: 0x00007090
		private virtual GClass10 GClass10_0
		{
			[CompilerGenerated]
			get
			{
				return this.gclass10_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				GClass10.GDelegate9 value2 = new GClass10.GDelegate9(this.method_61);
				GClass10 gclass = this.gclass10_0;
				if (gclass != null)
				{
					gclass.Event_0 -= value2;
				}
				this.gclass10_0 = value;
				gclass = this.gclass10_0;
				if (gclass != null)
				{
					gclass.Event_0 += value2;
				}
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00008ED4 File Offset: 0x000070D4
		public MainForm()
		{
			base.Load += this.MainForm_Load;
			base.FormClosing += this.MainForm_FormClosing;
			this.gclass15_0 = new GClass15<GClass9>();
			this.gclass12_0 = new GClass12();
			this.int_0 = 0;
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.bool_3 = false;
			this.bindingSource_0 = new BindingSource();
			this.bindingSource_1 = new BindingSource();
			if (Operators.CompareString(MySettings.Default.Culture, "", false) == 0)
			{
				MySettings.Default.Culture = Thread.CurrentThread.CurrentUICulture.Name;
			}
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(MySettings.Default.Culture);
			this.InitializeComponent();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008FAC File Offset: 0x000071AC
		private void MainForm_Load(object sender, EventArgs e)
		{
			this.TsCpyRigth.Text = Class6.Form0_0.Info.Copyright;
			string name = Thread.CurrentThread.CurrentUICulture.Name;
			bool flag = true;
			if (true == name.Contains("es"))
			{
				this.cbLanguage.SelectedIndex = 0;
			}
			else if (flag == name.Contains("en"))
			{
				this.cbLanguage.SelectedIndex = 1;
			}
			else if (flag != name.Contains("ru"))
			{
				if (flag != name.Contains("fr"))
				{
					this.cbLanguage.SelectedIndex = 1;
				}
				else
				{
					this.cbLanguage.SelectedIndex = 3;
				}
			}
			else
			{
				this.cbLanguage.SelectedIndex = 2;
			}
			this.cbLanguage.SelectedIndexChanged += this.method_62;
			if (Class13.bool_0)
			{
				this.ScrollLabel1.Visible = false;
				this.btDonate.Visible = false;
			}
			if (!Class13.smethod_4())
			{
				MessageBox.Show(Class10.String_61, "ERROR", MessageBoxButtons.OK);
				Application.Exit();
			}
			else
			{
				DateTime creationTime = File.GetCreationTime(Assembly.GetExecutingAssembly().Location);
				if (DateTime.Compare(MySettings.Default.StartTime, creationTime) < 0)
				{
					if (MessageBox.Show(Class10.String_29, "ATTENTION", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
					{
						MySettings.Default.StartTime = DateAndTime.Now;
					}
					else
					{
						Application.Exit();
					}
				}
				if (!Class13.smethod_5())
				{
					Application.Exit();
				}
			}
			Class13.string_7 = string.Format("waircut_{0}.log", DateAndTime.Now.Date.ToString("ddMMyyyy"));
			this.btPrivateMode.Visible = false;
			this.Text = string.Format("{0} - Release {1}", Class6.Form0_0.Info.Description, Class13.Version);
			this.method_0();
			this.GClass8_0 = new GClass8();
			this.method_1();
			if (this.GClass8_0.list_0.Count == 0)
			{
				MessageBox.Show(Class10.String_55, "ERROR", MessageBoxButtons.OK);
				Application.Exit();
			}
			this.method_2();
			this.DgvAttributes.ClearSelection();
			this.ToolTip_0.SetToolTip(this.BtExpandMessage, Class10.String_5);
			this.DgvAps.AutoGenerateColumns = false;
			this.GClass10_0 = new GClass10();
			if (Operators.CompareString(Class13.string_6, "", false) == 0)
			{
				Class13.string_6 = Class10.String_30;
			}
			this.ScrollLabel1.Text = Class13.string_6;
			this.tbScanTime.Text = Conversions.ToString(MySettings.Default.ScanTime);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000039B6 File Offset: 0x00001BB6
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.GClass10_0 != null)
			{
				this.GClass10_0.method_0();
			}
			Class13.smethod_3(GClass0.String_0);
			MySettings.Default.Save();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000922C File Offset: 0x0000742C
		private void method_0()
		{
			foreach (string str in Class13.string_0)
			{
				this.method_22("\t\t\t\t" + str, Color.Green, true);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009268 File Offset: 0x00007468
		private void method_1()
		{
			this.cbAdapters.Items.Clear();
			this.GClass8_0.method_3();
			try
			{
				foreach (GInterface1 ginterface in this.GClass8_0.list_0)
				{
					this.cbAdapters.Items.Add(ginterface.String_0);
				}
			}
			finally
			{
				List<GInterface1>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			if (this.cbAdapters.Items.Count > 0)
			{
				this.cbAdapters.SelectedIndex = 0;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000930C File Offset: 0x0000750C
		private void method_2()
		{
			this.DgvAttributes.Rows.Add(14);
			this.DgvAttributes.Rows[0].Cells[0].Value = Class10.String_20;
			this.DgvAttributes.Rows[1].Cells[0].Value = Class10.String_17;
			this.DgvAttributes.Rows[2].Cells[0].Value = Class10.String_18;
			this.DgvAttributes.Rows[3].Cells[0].Value = Class10.String_19;
			this.DgvAttributes.Rows[4].Cells[0].Value = Class10.String_23;
			this.DgvAttributes.Rows[5].Cells[0].Value = Class10.String_14;
			this.DgvAttributes.Rows[6].Cells[0].Value = "UUID";
			this.DgvAttributes.Rows[7].Cells[0].Value = Class10.String_25;
			this.DgvAttributes.Rows[8].Cells[0].Value = Class10.String_16;
			this.DgvAttributes.Rows[9].Cells[0].Value = "MAC";
			this.DgvAttributes.Rows[10].Cells[0].Value = Class10.String_22;
			this.DgvAttributes.Rows[11].Cells[0].Value = Class10.String_15;
			this.DgvAttributes.Rows[12].Cells[0].Value = Class10.String_24;
			this.DgvAttributes.Rows[13].Cells[0].Value = Class10.String_21;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000039DF File Offset: 0x00001BDF
		private void method_3(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00009548 File Offset: 0x00007748
		private void method_4(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.gclass15_0 = this.GClass8_0.method_6(this.tsWPSOnly.Checked, MySettings.Default.ScanTime);
			this.Cursor = Cursors.Default;
			this.method_7();
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009598 File Offset: 0x00007798
		private void method_5(object sender, EventArgs e)
		{
			if (this.DgvPins.IsCurrentRowDirty)
			{
				this.DgvPins.EndEdit();
			}
			else
			{
				this.DgvPins.CancelEdit();
			}
			this.method_7();
			this.tsApToolMenu.Enabled = false;
			this.method_23(false);
			GClass8 gclass = this.GClass8_0;
			GClass9 gclass2 = null;
			Control dgvAps = this.DgvAps;
			string text = gclass.method_12(ref gclass2, ref this.gclass15_0, ref dgvAps);
			this.DgvAps = (DataGridView)dgvAps;
			string right = text;
			try
			{
				foreach (GClass9 gclass3 in this.gclass15_0)
				{
					if (Operators.CompareString(gclass3.BSSID, right, false) == 0)
					{
						this.gclass9_0 = gclass3;
						this.gclass12_0.Pin = "";
						this.gclass12_0.Type = GClass12.GEnum5.PushButton;
						this.GClass8_0.method_8(ref this.gclass9_0, ref this.gclass12_0);
					}
				}
			}
			finally
			{
				IEnumerator<GClass9> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			this.tsApToolMenu.Enabled = true;
			this.method_23(true);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000096A8 File Offset: 0x000078A8
		private void method_6(int int_1, GClass9.GEnum3 genum3_0)
		{
			switch (genum3_0)
			{
			case GClass9.GEnum3.Unknow:
				this.DgvAps.Rows[int_1].Cells["dgvApsStatus"].Value = GClass0.Bitmap_6;
				return;
			case GClass9.GEnum3.Ok:
				this.DgvAps.Rows[int_1].Cells["dgvApsStatus"].Value = GClass0.Bitmap_15;
				this.DgvAps.Rows[int_1].Cells["dgvApsStatus"].ToolTipText = Class10.String_12;
				return;
			case GClass9.GEnum3.Nok:
				this.DgvAps.Rows[int_1].Cells["dgvApsStatus"].Value = GClass0.Bitmap_16;
				this.DgvAps.Rows[int_1].Cells["dgvApsStatus"].ToolTipText = Class10.String_11;
				return;
			default:
				return;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000039E7 File Offset: 0x00001BE7
		private void method_7()
		{
			this.bindingSource_0.DataSource = this.gclass15_0;
			this.DgvAps.DataSource = this.bindingSource_0;
			this.DgvAps.Invalidate();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000097A0 File Offset: 0x000079A0
		private void method_8(object sender, EventArgs e)
		{
			if (this.cbAdapters.SelectedIndex >= 0)
			{
				this.DgvAps.Rows.Clear();
				this.DgvPins.Rows.Clear();
				this.DgvAttributes.Rows.Clear();
				this.method_2();
				this.GClass8_0 = new GClass8();
				this.gclass15_0.Clear();
				try
				{
					this.int_0 = this.cbAdapters.SelectedIndex;
					this.GClass8_0.method_4(this.int_0);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000984C File Offset: 0x00007A4C
		private void method_9(ref GClass9 gclass9_1)
		{
			this.DgvAttributes.Rows[0].Cells[1].Value = gclass9_1.string_0;
			this.DgvAttributes.Rows[1].Cells[1].Value = gclass9_1.string_1;
			this.DgvAttributes.Rows[2].Cells[1].Value = gclass9_1.string_2;
			this.DgvAttributes.Rows[3].Cells[1].Value = gclass9_1.string_3;
			this.DgvAttributes.Rows[4].Cells[1].Value = gclass9_1.SerialNumber;
			this.DgvAttributes.Rows[5].Cells[1].Value = gclass9_1.string_5;
			this.DgvAttributes.Rows[6].Cells[1].Value = gclass9_1.UUID;
			this.DgvAttributes.Rows[7].Cells[1].Value = gclass9_1.Version;
			this.DgvAttributes.Rows[8].Cells[1].Value = gclass9_1.ApSetupLocked;
			this.DgvAttributes.Rows[9].Cells[1].Value = gclass9_1.BSSID;
			this.DgvAttributes.Rows[10].Cells[1].Value = gclass9_1.string_9;
			this.DgvAttributes.Rows[11].Cells[1].Value = gclass9_1.string_10;
			this.DgvAttributes.Rows[12].Cells[1].Style.ForeColor = Color.Blue;
			this.DgvAttributes.Rows[12].Cells[1].Value = gclass9_1.Pin.Pin;
			this.DgvAttributes.Rows[13].Cells[1].Style.ForeColor = Color.Blue;
			this.DgvAttributes.Rows[13].Cells[1].Value = gclass9_1.NetworkKey;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00009AF0 File Offset: 0x00007CF0
		private void method_10(object sender, EventArgs e)
		{
			if (this.DgvAps.SelectedRows.Count != 0)
			{
				this.gclass9_0 = (GClass9)this.bindingSource_0.Current;
				this.bindingSource_1.DataSource = this.gclass9_0.gclass15_0;
				this.DgvPins.DataSource = this.bindingSource_1;
				this.DgvPins.Invalidate();
				if (this.DgvAps.SelectedRows.Count == 0 | this.gclass15_0.Count == 0)
				{
					this.TsbPin.Enabled = false;
					this.TsbAllPin.Enabled = false;
					this.TsbRandomPin.Enabled = false;
					this.TsbPixie.Enabled = false;
					this.tsbPButton.Enabled = false;
					return;
				}
				try
				{
					this.method_9(ref this.gclass9_0);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00003A16 File Offset: 0x00001C16
		private void method_11(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			this.DgvPins.Enabled = (this.gclass15_0.Count > 0);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009BE8 File Offset: 0x00007DE8
		private void method_12(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (!this.bool_1)
			{
				if (this.gclass15_0.Count > 0)
				{
					this.TsbPin.Enabled = (this.gclass9_0.gclass15_0.Count > 0);
					this.TsbAllPin.Enabled = (this.gclass9_0.gclass15_0.Count > 1);
					this.tsbPButton.Enabled = true;
					this.TsbRandomPin.Enabled = true;
					this.TsbPixie.Enabled = true;
					return;
				}
				this.TsbPin.Enabled = false;
				this.TsbAllPin.Enabled = false;
				this.TsbRandomPin.Enabled = false;
				this.TsbPixie.Enabled = false;
				this.tsbPButton.Enabled = false;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00009CAC File Offset: 0x00007EAC
		private void method_13(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if ((e.RowIndex >= 0 & e.ColumnIndex >= 0) && Operators.ConditionalCompareObjectNotEqual(e.FormattedValue, this.DgvPins.Rows[e.RowIndex].Cells[e.ColumnIndex].Value, false))
			{
				((GClass12)this.bindingSource_1.Current).Description = "Manual";
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00003A31 File Offset: 0x00001C31
		private void method_14(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00009D28 File Offset: 0x00007F28
		private void method_15(object sender, EventArgs e)
		{
			if (this.DgvPins.IsCurrentRowDirty)
			{
				this.DgvPins.EndEdit();
			}
			else
			{
				this.DgvPins.CancelEdit();
			}
			this.gclass12_0 = (GClass12)this.bindingSource_1.Current;
			this.GClass8_0.method_7(ref this.gclass9_0, this.gclass12_0);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009D8C File Offset: 0x00007F8C
		private void method_16(object sender, EventArgs e)
		{
			if (this.DgvPins.IsCurrentRowDirty)
			{
				this.DgvPins.EndEdit();
			}
			else
			{
				this.DgvPins.CancelEdit();
			}
			GClass8 gclass = this.GClass8_0;
			RandomPinForm randomPinForm = new RandomPinForm(ref gclass, ref this.gclass9_0, false);
			this.GClass8_0 = gclass;
			randomPinForm.ShowDialog();
			randomPinForm.Dispose();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00009DE8 File Offset: 0x00007FE8
		private void method_17(object sender, EventArgs e)
		{
			if (this.DgvPins.IsCurrentRowDirty)
			{
				this.DgvPins.EndEdit();
			}
			else
			{
				this.DgvPins.CancelEdit();
			}
			this.method_23(false);
			this.DgvAps.Enabled = false;
			GClass8 gclass = this.GClass8_0;
			Control rtbMessage = this.RtbMessage;
			string left = gclass.method_12(ref this.gclass9_0, ref this.gclass15_0, ref rtbMessage);
			this.RtbMessage = (RichTextBox)rtbMessage;
			if (Operators.CompareString(left, this.gclass9_0.BSSID, false) == 0)
			{
				this.gclass12_0.Pin = "";
				this.gclass12_0.Type = GClass12.GEnum5.PushButton;
				this.GClass8_0.method_8(ref this.gclass9_0, ref this.gclass12_0);
			}
			this.method_23(true);
			this.DgvAps.Enabled = true;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009EB4 File Offset: 0x000080B4
		private void method_18(object sender, EventArgs e)
		{
			GClass8 gclass = this.GClass8_0;
			RandomPinForm randomPinForm = new RandomPinForm(ref gclass, ref this.gclass9_0, true);
			this.GClass8_0 = gclass;
			randomPinForm.ShowDialog();
			randomPinForm.Dispose();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00003A33 File Offset: 0x00001C33
		private void method_19(object sender, EventArgs e)
		{
			this.GClass8_0.method_9(ref this.gclass9_0);
			this.bool_3 = true;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00003A4D File Offset: 0x00001C4D
		private void method_20(object sender, EventArgs e)
		{
			this.GClass8_0.method_10(true);
			this.bool_3 = false;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009EEC File Offset: 0x000080EC
		private void method_21(string string_0, Color color_0, bool bool_4)
		{
			if (base.InvokeRequired)
			{
				try
				{
					MainForm.GDelegate4 method = new MainForm.GDelegate4(this.method_21);
					base.Invoke(method, new object[]
					{
						string_0,
						color_0,
						bool_4
					});
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			this.method_22(string_0, color_0, bool_4);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009F5C File Offset: 0x0000815C
		public void method_22(string string_0, Color color_0, bool bool_4)
		{
			try
			{
				if (this.RtbMessage.Lines.Count<string>() > 2000)
				{
					this.RtbMessage.Clear();
				}
				if (string_0 != string.Empty)
				{
					this.RtbMessage.SelectionColor = color_0;
					if (bool_4)
					{
						string_0 += "\r\n";
					}
					this.RtbMessage.AppendText(string_0);
					if (Class13.bool_2)
					{
						Class13.smethod_15(Class13.string_7, string_0);
					}
					Class13.smethod_14(this.RtbMessage);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00009FF8 File Offset: 0x000081F8
		private void method_23(bool bool_4)
		{
			try
			{
				this.btScan.Enabled = bool_4;
				this.tsbPbcScan.Enabled = bool_4;
				this.btRefresh.Enabled = bool_4;
				this.tsWPSOnly.Enabled = bool_4;
				this.TsbAllPin.Enabled = (bool_4 & (this.gclass9_0 != null && this.gclass9_0.gclass15_0.Count > 1));
				this.TsbPin.Enabled = (bool_4 & (this.gclass9_0 != null && this.gclass9_0.gclass15_0.Count > 0));
				this.TsbRandomPin.Enabled = bool_4;
				this.TsbPixie.Enabled = bool_4;
				this.tsbPButton.Enabled = bool_4;
				this.TsbStop.Enabled = !bool_4;
				this.cbAdapters.Enabled = bool_4;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000A0EC File Offset: 0x000082EC
		private void method_24(GClass8.GEnum1 genum1_0)
		{
			if (base.InvokeRequired)
			{
				try
				{
					MainForm.GDelegate5 method = new MainForm.GDelegate5(this.method_24);
					base.Invoke(method, new object[]
					{
						genum1_0
					});
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			this.method_25(genum1_0);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000A14C File Offset: 0x0000834C
		private void method_25(GClass8.GEnum1 genum1_0)
		{
			if (genum1_0 <= GClass8.GEnum1.Start)
			{
				if (genum1_0 == GClass8.GEnum1.Stop)
				{
					this.method_23(true);
					this.method_9(ref this.gclass9_0);
					this.bool_1 = false;
					this.method_7();
					return;
				}
				if (genum1_0 != GClass8.GEnum1.Start)
				{
					return;
				}
				this.method_23(false);
				this.bool_1 = true;
				return;
			}
			else
			{
				if (genum1_0 == GClass8.GEnum1.Updated)
				{
					this.method_9(ref this.gclass9_0);
					return;
				}
				if (genum1_0 == GClass8.GEnum1.PixieSucced)
				{
					if (this.bool_3)
					{
						this.GClass8_0.method_10(false);
						this.method_22("\r\n[P] AuthKey: " + this.gclass9_0.AuthKey, Color.White, true);
						this.method_22("[P]     PKE: " + this.gclass9_0.PKE, Color.White, true);
						this.method_22("[P]     PKR: " + this.gclass9_0.PKR, Color.White, true);
						this.method_22("[P] E-HASH1: " + this.gclass9_0.E_HAS1, Color.White, true);
						this.method_22("[P] E-HASH2: " + this.gclass9_0.E_HAS2, Color.White, true);
						this.method_22("[P] E-NONCE: " + this.gclass9_0.E_NONCE, Color.White, true);
						this.method_22("[P] R-NONCE: " + this.gclass9_0.R_NONCE, Color.White, true);
						this.method_22(Class13.string_4, Color.LightGreen, false);
						if (this.bool_3)
						{
							this.method_60("-f", true);
						}
					}
					return;
				}
				return;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000A2D8 File Offset: 0x000084D8
		private void method_26(object sender, EventArgs e)
		{
			this.bool_0 = !this.bool_0;
			if (this.bool_0)
			{
				this.BtExpandMessage.BackgroundImage = GClass0.Bitmap_3;
				this.ToolTip_0.SetToolTip(this.BtExpandMessage, Class10.String_4);
			}
			else
			{
				this.BtExpandMessage.BackgroundImage = GClass0.Bitmap_4;
				this.ToolTip_0.SetToolTip(this.BtExpandMessage, Class10.String_5);
			}
			this.GClass8_0.bool_2 = this.bool_0;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00003A62 File Offset: 0x00001C62
		private void method_27(object sender, EventArgs e)
		{
			this.RtbMessage.Clear();
			this.method_22(Class13.string_4, Color.LightGreen, false);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00003A80 File Offset: 0x00001C80
		private void method_28(object sender, EventArgs e)
		{
			new AboutForm().ShowDialog();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00003A8D File Offset: 0x00001C8D
		private void method_29(object sender, EventArgs e)
		{
			Class13.bool_1 = this.btPrivateMode.Checked;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00003A9F File Offset: 0x00001C9F
		private void method_30(object sender, EventArgs e)
		{
			WpsPinForm wpsPinForm = new WpsPinForm();
			wpsPinForm.ShowDialog();
			wpsPinForm.Dispose();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00003AB2 File Offset: 0x00001CB2
		private void method_31(object sender, EventArgs e)
		{
			ApLogForm apLogForm = new ApLogForm();
			apLogForm.ShowDialog();
			apLogForm.Dispose();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000A35C File Offset: 0x0000855C
		private void method_32(object sender, EventArgs e)
		{
			GClass8 gclass = this.GClass8_0;
			PixieForm pixieForm = new PixieForm(ref gclass, ref this.gclass9_0);
			this.GClass8_0 = gclass;
			pixieForm.ShowDialog();
			pixieForm.Dispose();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00003AC5 File Offset: 0x00001CC5
		private void method_33(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A390 File Offset: 0x00008590
		private void method_34(object sender, DataGridViewCellFormattingEventArgs e)
		{
			string name = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
			IL_119:
			while (Operators.CompareString(name, "dgvApsStatus", false) != 0)
			{
				IL_106:
				while (Operators.CompareString(name, "DgvApsPinStatus", false) == 0)
				{
					for (;;)
					{
						IL_F8:
						GClass3.GEnum0 genum = (GClass3.GEnum0)Conversions.ToInteger(e.Value);
						for (;;)
						{
							IL_DD:
							switch (genum)
							{
							case GClass3.GEnum0.ZAO:
								goto IL_12C;
							case GClass3.GEnum0.FTE:
								goto IL_16C;
							case GClass3.GEnum0.EasyBox:
								goto IL_1A9;
							case GClass3.GEnum0.dLINK:
								goto IL_1E6;
							default:
							{
								uint num2;
								uint num = num2 * 658693119U ^ 2816349336U;
								for (;;)
								{
									switch ((num2 = (num ^ 3477615640U)) % 34U)
									{
									case 0U:
									case 29U:
										goto IL_119;
									case 1U:
									case 13U:
									case 19U:
									case 27U:
										goto IL_221;
									case 2U:
										goto IL_32E;
									case 3U:
										goto IL_16C;
									case 4U:
										goto IL_12C;
									case 5U:
										goto IL_1A9;
									case 6U:
									case 10U:
									case 12U:
									case 31U:
										goto IL_3B3;
									case 7U:
										return;
									case 9U:
										goto IL_177;
									case 11U:
										return;
									case 14U:
										goto IL_1F1;
									case 15U:
										goto IL_378;
									case 16U:
										goto IL_346;
									case 17U:
										goto IL_253;
									case 18U:
										goto IL_29B;
									case 20U:
										goto IL_1E6;
									case 21U:
										goto IL_106;
									case 22U:
										goto IL_30B;
									case 23U:
										goto IL_F8;
									case 24U:
										num = (num2 * 645486715U ^ 2589827669U);
										continue;
									case 25U:
										goto IL_2B0;
									case 26U:
										goto IL_DD;
									case 28U:
										goto IL_33B;
									case 30U:
										goto IL_2CA;
									case 32U:
										goto IL_2C3;
									case 33U:
										goto IL_241;
									}
									goto Block_1;
								}
								break;
							}
							}
						}
					}
					Block_1:
					return;
					IL_12C:
					e.Value = GClass0.Bitmap_21;
					this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_9;
					goto IL_221;
					IL_16C:
					e.Value = GClass0.Bitmap_20;
					IL_177:
					this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_10;
					goto IL_221;
					IL_1A9:
					e.Value = GClass0.Bitmap_22;
					this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_8;
					goto IL_221;
					IL_1E6:
					e.Value = GClass0.Bitmap_19;
					IL_1F1:
					this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_7;
					IL_221:
					if (!((GClass9)this.bindingSource_0[e.RowIndex]).bool_1)
					{
						return;
					}
					IL_241:
					Bitmap bitmap = new Bitmap(16, 16);
					Graphics graphics = Graphics.FromImage(bitmap);
					IL_253:
					object instance = graphics;
					Type type = null;
					string memberName = "DrawImage";
					object[] array;
					object[] arguments = array = new object[]
					{
						e.Value,
						new Point(0, 0)
					};
					string[] argumentNames = null;
					Type[] typeArguments = null;
					bool[] array2 = new bool[2];
					array2[0] = true;
					bool[] array3 = array2;
					NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array2, true);
					if (!array3[0])
					{
						goto IL_2B0;
					}
					IL_29B:
					e.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
					IL_2B0:
					graphics.DrawImage(GClass0.Bitmap_55, new Point(0, 0));
					IL_2C3:
					e.Value = bitmap;
					IL_2CA:
					DataGridViewCell dataGridViewCell;
					(dataGridViewCell = this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex]).ToolTipText = dataGridViewCell.ToolTipText + Class10.String_13;
					return;
				}
				return;
				IL_32E:
				e.Value = GClass0.Bitmap_6;
				goto IL_3B3;
				IL_33B:
				e.Value = GClass0.Bitmap_15;
				IL_346:
				this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_12;
				goto IL_3B3;
				IL_378:
				e.Value = GClass0.Bitmap_16;
				this.DgvAps.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_11;
				IL_3B3:
				e.FormattingApplied = true;
				return;
			}
			IL_30B:
			switch (Conversions.ToInteger(e.Value))
			{
			case 0:
				goto IL_32E;
			case 1:
				goto IL_33B;
			case 2:
				goto IL_378;
			default:
				goto IL_3B3;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A758 File Offset: 0x00008958
		private void method_35(object sender, CancelEventArgs e)
		{
			this.tbMenuPin_Checksum.Enabled = (Operators.CompareString(this.ContextMenuPin.SourceControl.Name, "DgvAps", false) != 0);
			string name = this.ContextMenuPin.SourceControl.Name;
			if (Operators.CompareString(name, "DgvAps", false) == 0)
			{
				e.Cancel = (this.DgvAps.SelectedRows.Count == 0);
				return;
			}
			if (Operators.CompareString(name, "DgvPins", false) == 0)
			{
				e.Cancel = (this.DgvPins.SelectedRows.Count == 0);
				return;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A7F0 File Offset: 0x000089F0
		private void method_36(object sender, EventArgs e)
		{
			if (this.DgvPins.SelectedRows.Count != 0)
			{
				string text = Conversions.ToString(this.DgvPins.SelectedRows[0].Cells["DgvPinsPin"].Value);
				if (Operators.CompareString(text, "", false) != 0)
				{
					text = text.Substring(0, 7);
					text += GClass3.smethod_0(Conversions.ToInteger(text)).ToString();
					this.DgvPins.SelectedRows[0].Cells["DgvPinsPin"].Value = text;
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A894 File Offset: 0x00008A94
		private void method_37(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_1(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.ZAO));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A8F4 File Offset: 0x00008AF4
		private void method_38(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_3(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.AiroConru));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A954 File Offset: 0x00008B54
		private void method_39(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_5(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.EasyBox));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		private void method_40(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_7(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.TrendNet));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000AA14 File Offset: 0x00008C14
		private void method_41(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(Conversions.ToString(GClass3.smethod_4(((GClass9)this.bindingSource_0.Current).BSSID)), GClass3.GEnum0.dLINK));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000AA78 File Offset: 0x00008C78
		private void method_42(object sender, EventArgs e)
		{
			string ssid = ((GClass9)this.bindingSource_0.Current).SSID;
			if (LikeOperator.LikeString(ssid, "FTE-????", CompareMethod.Binary))
			{
				this.bindingSource_1.CancelEdit();
				this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_9(((GClass9)this.bindingSource_0.Current).BSSID, ssid), GClass3.GEnum0.FTE));
				this.bindingSource_1.EndEdit();
				this.DgvPins.Invalidate();
				return;
			}
			string[] array = new string[]
			{
				"",
				"",
				""
			};
			string[] array2 = GClass3.smethod_8(((GClass9)this.bindingSource_0.Current).BSSID);
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(array2[0], GClass3.GEnum0.FTE));
			this.gclass9_0.gclass15_0.Add(new GClass12(array2[1], GClass3.GEnum0.FTE));
			this.gclass9_0.gclass15_0.Add(new GClass12(array2[2], GClass3.GEnum0.FTE));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000ABA4 File Offset: 0x00008DA4
		private void method_43(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_10(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.Asus));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000AC04 File Offset: 0x00008E04
		private void method_44(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_12(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d28bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000AC64 File Offset: 0x00008E64
		private void method_45(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_13(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d32bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		private void method_46(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_14(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d36bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000AD24 File Offset: 0x00008F24
		private void method_47(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_15(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d40bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000AD84 File Offset: 0x00008F84
		private void method_48(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_16(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d44bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		private void method_49(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_17(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d48bit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000AE44 File Offset: 0x00009044
		private void method_50(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_18(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d24rhbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000AEA4 File Offset: 0x000090A4
		private void method_51(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_19(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d32rhbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000AF04 File Offset: 0x00009104
		private void method_52(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_20(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d48rhbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000AF64 File Offset: 0x00009164
		private void method_53(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_21(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d24rnbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000AFC4 File Offset: 0x000091C4
		private void method_54(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_22(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d32rnbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000B024 File Offset: 0x00009224
		private void method_55(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_23(((GClass9)this.bindingSource_0.Current).BSSID), GClass3.GEnum0.d48rnbit));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000B084 File Offset: 0x00009284
		private void method_56(object sender, EventArgs e)
		{
			this.tsMenuPin_ZAO.PerformClick();
			this.tsMenuPin_28bit.PerformClick();
			this.tsMenuPin_32bit.PerformClick();
			this.tsMenuPin_36bit.PerformClick();
			this.tsMenuPin_40bit.PerformClick();
			this.tsMenuPin_44bit.PerformClick();
			this.tsMenuPin_48bit.PerformClick();
			this.tsMenuPin_24RHbit.PerformClick();
			this.tsMenuPin_32RHbit.PerformClick();
			this.tsMenuPin_48RHbit.PerformClick();
			this.tsMenuPin_24RNbit.PerformClick();
			this.tsMenuPin_32RNbit.PerformClick();
			this.tsMenuPin_48RNbit.PerformClick();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000B120 File Offset: 0x00009320
		private void method_57(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_6(((GClass9)this.bindingSource_0.Current).BSSID, ((GClass9)this.bindingSource_0.Current).SerialNumber), GClass3.GEnum0.LiveBox));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003ACE File Offset: 0x00001CCE
		private void method_58(object sender, EventArgs e)
		{
			this.bindingSource_1.CancelEdit();
			this.gclass9_0.gclass15_0.Add(new GClass12(GClass3.smethod_2(), GClass3.GEnum0.PinNull));
			this.bindingSource_1.EndEdit();
			this.DgvPins.Invalidate();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000B194 File Offset: 0x00009394
		private void method_59(object sender, EventArgs e)
		{
			this.tsMenuPin_AiroCon.PerformClick();
			this.tsMenuPin_EasyBox.PerformClick();
			this.tsMenuPin_LiveBox.PerformClick();
			this.tsMenuPin_Trend.PerformClick();
			this.tsMenuPin_Dlink.PerformClick();
			this.tsMenuPin_FTE.PerformClick();
			this.tsMenuPin_Allxbit.PerformClick();
			this.tsMenuPin_Null.PerformClick();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000B1FC File Offset: 0x000093FC
		private void method_60(string string_0, bool bool_4)
		{
			string text = "-e " + this.gclass9_0.PKE;
			text = text + " -r " + this.gclass9_0.PKR;
			text = text + " -s " + this.gclass9_0.E_HAS1;
			text = text + " -z " + this.gclass9_0.E_HAS2;
			text = text + " -a " + this.gclass9_0.AuthKey;
			text = text + " -n " + this.gclass9_0.E_NONCE;
			text = text + " " + string_0;
			this.method_22(" PixieWps " + text, Color.White, true);
			string text2 = GClass3.smethod_27(text);
			this.method_22(text2, Color.White, true);
			this.bool_3 = false;
			if (!Class13.smethod_11(text2, ref this.gclass12_0))
			{
				if (this.gclass9_0.Status == GClass9.GEnum3.Unknow)
				{
					this.gclass9_0.Status = GClass9.GEnum3.Nok;
				}
			}
			else
			{
				this.gclass9_0.Pin = this.gclass12_0;
				this.method_22(Class13.string_4, Color.LightGreen, false);
				if (bool_4)
				{
					this.GClass8_0.method_7(ref this.gclass9_0, this.gclass12_0);
					return;
				}
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003B0C File Offset: 0x00001D0C
		private void method_61(string string_0)
		{
			new UpdateForm
			{
				string_0 = string_0
			}.ShowDialog();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000B340 File Offset: 0x00009540
		private void method_62(object sender, EventArgs e)
		{
			if (MessageBox.Show(Class10.String_58, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				for (;;)
				{
					IL_90:
					int selectedIndex = this.cbLanguage.SelectedIndex;
					for (;;)
					{
						IL_78:
						switch (selectedIndex)
						{
						case 0:
							goto IL_9E;
						case 1:
							goto IL_AF;
						case 2:
							goto IL_C0;
						case 3:
							goto IL_D1;
						default:
						{
							uint num2;
							uint num = num2 * 1094233503U ^ 826448192U;
							for (;;)
							{
								switch ((num2 = (num ^ 3186864924U)) % 12U)
								{
								case 0U:
								case 5U:
								case 8U:
									goto IL_E0;
								case 1U:
									goto IL_AF;
								case 2U:
									goto IL_C0;
								case 3U:
								case 9U:
									goto IL_90;
								case 4U:
									goto IL_D1;
								case 6U:
									goto IL_78;
								case 7U:
									goto IL_9E;
								case 10U:
									num = (num2 * 1563691460U ^ 3985386060U);
									continue;
								}
								goto Block_2;
							}
							break;
						}
						}
					}
				}
				Block_2:
				return;
				IL_9E:
				MySettings.Default.Culture = "es";
				goto IL_E0;
				IL_AF:
				MySettings.Default.Culture = "en";
				goto IL_E0;
				IL_C0:
				MySettings.Default.Culture = "ru";
				goto IL_E0;
				IL_D1:
				MySettings.Default.Culture = "fr";
				IL_E0:
				Application.Restart();
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000B434 File Offset: 0x00009634
		private void method_63(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.tbScanTime.Text, "", false) != 0 & Versioned.IsNumeric(this.tbScanTime.Text))
			{
				MySettings.Default.ScanTime = Conversions.ToInteger(this.tbScanTime.Text);
				MySettings.Default.Save();
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00003B20 File Offset: 0x00001D20
		private void method_64(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))
			{
				e.Handled = false;
				return;
			}
			e.Handled = true;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00003B4A File Offset: 0x00001D4A
		private void method_65(object sender, EventArgs e)
		{
			this.tbScanTime.Text = Conversions.ToString(MySettings.Default.ScanTime);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000B494 File Offset: 0x00009694
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

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00003B66 File Offset: 0x00001D66
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00003B6E File Offset: 0x00001D6E
		internal virtual SplitContainer SplitContainer1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00003B77 File Offset: 0x00001D77
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00003B7F File Offset: 0x00001D7F
		internal virtual RichTextBox RtbMessage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00003B88 File Offset: 0x00001D88
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		internal virtual Button BtExpandMessage
		{
			[CompilerGenerated]
			get
			{
				return this._BtExpandMessage;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_26);
				Button btExpandMessage = this._BtExpandMessage;
				if (btExpandMessage != null)
				{
					btExpandMessage.Click -= value2;
				}
				this._BtExpandMessage = value;
				btExpandMessage = this._BtExpandMessage;
				if (btExpandMessage != null)
				{
					btExpandMessage.Click += value2;
				}
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00003B90 File Offset: 0x00001D90
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00003B98 File Offset: 0x00001D98
		internal virtual ImageList ImageList_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00003BA1 File Offset: 0x00001DA1
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00003BA9 File Offset: 0x00001DA9
		internal virtual ToolTip ToolTip_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00003BB2 File Offset: 0x00001DB2
		// (set) Token: 0x06000200 RID: 512 RVA: 0x00003BBA File Offset: 0x00001DBA
		internal virtual StatusStrip StatusStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00003BC3 File Offset: 0x00001DC3
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00003BCB File Offset: 0x00001DCB
		internal virtual ToolStrip tsInterfaces { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00003BD4 File Offset: 0x00001DD4
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000D81C File Offset: 0x0000BA1C
		internal virtual ToolStripButton btRefresh
		{
			[CompilerGenerated]
			get
			{
				return this._btRefresh;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_3);
				ToolStripButton btRefresh = this._btRefresh;
				if (btRefresh != null)
				{
					btRefresh.Click -= value2;
				}
				this._btRefresh = value;
				btRefresh = this._btRefresh;
				if (btRefresh != null)
				{
					btRefresh.Click += value2;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00003BDC File Offset: 0x00001DDC
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000D860 File Offset: 0x0000BA60
		internal virtual ToolStripComboBox cbAdapters
		{
			[CompilerGenerated]
			get
			{
				return this._cbAdapters;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_8);
				ToolStripComboBox cbAdapters = this._cbAdapters;
				if (cbAdapters != null)
				{
					cbAdapters.SelectedIndexChanged -= value2;
				}
				this._cbAdapters = value;
				cbAdapters = this._cbAdapters;
				if (cbAdapters != null)
				{
					cbAdapters.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00003BEC File Offset: 0x00001DEC
		internal virtual ToolStripSeparator ToolStripSeparator2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00003BF5 File Offset: 0x00001DF5
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00003BFD File Offset: 0x00001DFD
		internal virtual SplitContainer SplitContainer3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00003C06 File Offset: 0x00001E06
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00003C0E File Offset: 0x00001E0E
		internal virtual SplitContainer SplitContainer2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00003C17 File Offset: 0x00001E17
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		internal virtual DataGridView DgvAps
		{
			[CompilerGenerated]
			get
			{
				return this._DgvAps;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_10);
				DataGridViewBindingCompleteEventHandler value3 = new DataGridViewBindingCompleteEventHandler(this.method_11);
				DataGridViewCellFormattingEventHandler value4 = new DataGridViewCellFormattingEventHandler(this.method_34);
				DataGridView dgvAps = this._DgvAps;
				if (dgvAps != null)
				{
					dgvAps.SelectionChanged -= value2;
					dgvAps.DataBindingComplete -= value3;
					dgvAps.CellFormatting -= value4;
				}
				this._DgvAps = value;
				dgvAps = this._DgvAps;
				if (dgvAps != null)
				{
					dgvAps.SelectionChanged += value2;
					dgvAps.DataBindingComplete += value3;
					dgvAps.CellFormatting += value4;
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00003C1F File Offset: 0x00001E1F
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00003C27 File Offset: 0x00001E27
		internal virtual DataGridView DgvAttributes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00003C30 File Offset: 0x00001E30
		// (set) Token: 0x06000212 RID: 530 RVA: 0x0000D920 File Offset: 0x0000BB20
		internal virtual DataGridView DgvPins
		{
			[CompilerGenerated]
			get
			{
				return this._DgvPins;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewBindingCompleteEventHandler value2 = new DataGridViewBindingCompleteEventHandler(this.method_12);
				DataGridViewCellValidatingEventHandler value3 = new DataGridViewCellValidatingEventHandler(this.method_13);
				DataGridViewDataErrorEventHandler value4 = new DataGridViewDataErrorEventHandler(this.method_14);
				DataGridView dgvPins = this._DgvPins;
				if (dgvPins != null)
				{
					dgvPins.DataBindingComplete -= value2;
					dgvPins.CellValidating -= value3;
					dgvPins.DataError -= value4;
				}
				this._DgvPins = value;
				dgvPins = this._DgvPins;
				if (dgvPins != null)
				{
					dgvPins.DataBindingComplete += value2;
					dgvPins.CellValidating += value3;
					dgvPins.DataError += value4;
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00003C38 File Offset: 0x00001E38
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00003C40 File Offset: 0x00001E40
		internal virtual ToolStrip tsApToolMenu { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00003C49 File Offset: 0x00001E49
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000D99C File Offset: 0x0000BB9C
		internal virtual ToolStripButton TsbPin
		{
			[CompilerGenerated]
			get
			{
				return this._TsbPin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_15);
				ToolStripButton tsbPin = this._TsbPin;
				if (tsbPin != null)
				{
					tsbPin.Click -= value2;
				}
				this._TsbPin = value;
				tsbPin = this._TsbPin;
				if (tsbPin != null)
				{
					tsbPin.Click += value2;
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00003C51 File Offset: 0x00001E51
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		internal virtual ToolStripButton TsbAllPin
		{
			[CompilerGenerated]
			get
			{
				return this._TsbAllPin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_16);
				ToolStripButton tsbAllPin = this._TsbAllPin;
				if (tsbAllPin != null)
				{
					tsbAllPin.Click -= value2;
				}
				this._TsbAllPin = value;
				tsbAllPin = this._TsbAllPin;
				if (tsbAllPin != null)
				{
					tsbAllPin.Click += value2;
				}
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00003C59 File Offset: 0x00001E59
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000DA24 File Offset: 0x0000BC24
		internal virtual ToolStripButton TsbRandomPin
		{
			[CompilerGenerated]
			get
			{
				return this._TsbRandomPin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_18);
				ToolStripButton tsbRandomPin = this._TsbRandomPin;
				if (tsbRandomPin != null)
				{
					tsbRandomPin.Click -= value2;
				}
				this._TsbRandomPin = value;
				tsbRandomPin = this._TsbRandomPin;
				if (tsbRandomPin != null)
				{
					tsbRandomPin.Click += value2;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00003C61 File Offset: 0x00001E61
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000DA68 File Offset: 0x0000BC68
		internal virtual ToolStripButton TsbStop
		{
			[CompilerGenerated]
			get
			{
				return this._TsbStop;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_20);
				ToolStripButton tsbStop = this._TsbStop;
				if (tsbStop != null)
				{
					tsbStop.Click -= value2;
				}
				this._TsbStop = value;
				tsbStop = this._TsbStop;
				if (tsbStop != null)
				{
					tsbStop.Click += value2;
				}
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00003C69 File Offset: 0x00001E69
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00003C71 File Offset: 0x00001E71
		internal virtual ToolStripStatusLabel TsCpyRigth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00003C7A File Offset: 0x00001E7A
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00003C82 File Offset: 0x00001E82
		internal virtual PictureBox PbLicense { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00003C8B File Offset: 0x00001E8B
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000DAAC File Offset: 0x0000BCAC
		internal virtual ToolStripButton btAbout
		{
			[CompilerGenerated]
			get
			{
				return this._btAbout;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_28);
				ToolStripButton btAbout = this._btAbout;
				if (btAbout != null)
				{
					btAbout.Click -= value2;
				}
				this._btAbout = value;
				btAbout = this._btAbout;
				if (btAbout != null)
				{
					btAbout.Click += value2;
				}
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00003C93 File Offset: 0x00001E93
		// (set) Token: 0x06000224 RID: 548 RVA: 0x0000DAF0 File Offset: 0x0000BCF0
		internal virtual ToolStripButton btPrivateMode
		{
			[CompilerGenerated]
			get
			{
				return this._btPrivateMode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_29);
				ToolStripButton btPrivateMode = this._btPrivateMode;
				if (btPrivateMode != null)
				{
					btPrivateMode.CheckedChanged -= value2;
				}
				this._btPrivateMode = value;
				btPrivateMode = this._btPrivateMode;
				if (btPrivateMode != null)
				{
					btPrivateMode.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00003C9B File Offset: 0x00001E9B
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00003CA3 File Offset: 0x00001EA3
		internal virtual ToolStripDropDownButton btDataBase { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00003CAC File Offset: 0x00001EAC
		// (set) Token: 0x06000228 RID: 552 RVA: 0x0000DB34 File Offset: 0x0000BD34
		internal virtual ToolStripMenuItem btPinDb
		{
			[CompilerGenerated]
			get
			{
				return this._btPinDb;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_30);
				ToolStripMenuItem btPinDb = this._btPinDb;
				if (btPinDb != null)
				{
					btPinDb.Click -= value2;
				}
				this._btPinDb = value;
				btPinDb = this._btPinDb;
				if (btPinDb != null)
				{
					btPinDb.Click += value2;
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00003CB4 File Offset: 0x00001EB4
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0000DB78 File Offset: 0x0000BD78
		internal virtual ToolStripMenuItem btNetsBD
		{
			[CompilerGenerated]
			get
			{
				return this._btNetsBD;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_31);
				ToolStripMenuItem btNetsBD = this._btNetsBD;
				if (btNetsBD != null)
				{
					btNetsBD.Click -= value2;
				}
				this._btNetsBD = value;
				btNetsBD = this._btNetsBD;
				if (btNetsBD != null)
				{
					btNetsBD.Click += value2;
				}
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00003CBC File Offset: 0x00001EBC
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00003CC4 File Offset: 0x00001EC4
		internal virtual ToolStripSeparator ToolStripSeparator4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00003CCD File Offset: 0x00001ECD
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		internal virtual ContextMenuStrip ContextMenuPin
		{
			[CompilerGenerated]
			get
			{
				return this._ContextMenuPin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.method_35);
				ContextMenuStrip contextMenuPin = this._ContextMenuPin;
				if (contextMenuPin != null)
				{
					contextMenuPin.Opening -= value2;
				}
				this._ContextMenuPin = value;
				contextMenuPin = this._ContextMenuPin;
				if (contextMenuPin != null)
				{
					contextMenuPin.Opening += value2;
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00003CD5 File Offset: 0x00001ED5
		// (set) Token: 0x06000230 RID: 560 RVA: 0x0000DC00 File Offset: 0x0000BE00
		internal virtual ToolStripMenuItem tbMenuPin_Checksum
		{
			[CompilerGenerated]
			get
			{
				return this._tbMenuPin_Checksum;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_36);
				ToolStripMenuItem tbMenuPin_Checksum = this._tbMenuPin_Checksum;
				if (tbMenuPin_Checksum != null)
				{
					tbMenuPin_Checksum.Click -= value2;
				}
				this._tbMenuPin_Checksum = value;
				tbMenuPin_Checksum = this._tbMenuPin_Checksum;
				if (tbMenuPin_Checksum != null)
				{
					tbMenuPin_Checksum.Click += value2;
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00003CDD File Offset: 0x00001EDD
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00003CE5 File Offset: 0x00001EE5
		internal virtual ToolStripSeparator ToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00003CEE File Offset: 0x00001EEE
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00003CF6 File Offset: 0x00001EF6
		internal virtual ToolStripMenuItem tsMenuAlgorithms { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00003CFF File Offset: 0x00001EFF
		// (set) Token: 0x06000236 RID: 566 RVA: 0x0000DC44 File Offset: 0x0000BE44
		internal virtual ToolStripMenuItem tsMenuPin_ZAO
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_ZAO;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_37);
				ToolStripMenuItem tsMenuPin_ZAO = this._tsMenuPin_ZAO;
				if (tsMenuPin_ZAO != null)
				{
					tsMenuPin_ZAO.Click -= value2;
				}
				this._tsMenuPin_ZAO = value;
				tsMenuPin_ZAO = this._tsMenuPin_ZAO;
				if (tsMenuPin_ZAO != null)
				{
					tsMenuPin_ZAO.Click += value2;
				}
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00003D07 File Offset: 0x00001F07
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000DC88 File Offset: 0x0000BE88
		internal virtual ToolStripMenuItem tsMenuPin_EasyBox
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_EasyBox;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_39);
				ToolStripMenuItem tsMenuPin_EasyBox = this._tsMenuPin_EasyBox;
				if (tsMenuPin_EasyBox != null)
				{
					tsMenuPin_EasyBox.Click -= value2;
				}
				this._tsMenuPin_EasyBox = value;
				tsMenuPin_EasyBox = this._tsMenuPin_EasyBox;
				if (tsMenuPin_EasyBox != null)
				{
					tsMenuPin_EasyBox.Click += value2;
				}
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00003D0F File Offset: 0x00001F0F
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000DCCC File Offset: 0x0000BECC
		internal virtual ToolStripMenuItem tsMenuPin_Trend
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_Trend;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_40);
				ToolStripMenuItem tsMenuPin_Trend = this._tsMenuPin_Trend;
				if (tsMenuPin_Trend != null)
				{
					tsMenuPin_Trend.Click -= value2;
				}
				this._tsMenuPin_Trend = value;
				tsMenuPin_Trend = this._tsMenuPin_Trend;
				if (tsMenuPin_Trend != null)
				{
					tsMenuPin_Trend.Click += value2;
				}
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00003D17 File Offset: 0x00001F17
		// (set) Token: 0x0600023C RID: 572 RVA: 0x0000DD10 File Offset: 0x0000BF10
		internal virtual ToolStripMenuItem tsMenuPin_Dlink
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_Dlink;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_41);
				ToolStripMenuItem tsMenuPin_Dlink = this._tsMenuPin_Dlink;
				if (tsMenuPin_Dlink != null)
				{
					tsMenuPin_Dlink.Click -= value2;
				}
				this._tsMenuPin_Dlink = value;
				tsMenuPin_Dlink = this._tsMenuPin_Dlink;
				if (tsMenuPin_Dlink != null)
				{
					tsMenuPin_Dlink.Click += value2;
				}
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00003D1F File Offset: 0x00001F1F
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0000DD54 File Offset: 0x0000BF54
		internal virtual ToolStripMenuItem tsMenuPin_FTE
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_FTE;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_42);
				ToolStripMenuItem tsMenuPin_FTE = this._tsMenuPin_FTE;
				if (tsMenuPin_FTE != null)
				{
					tsMenuPin_FTE.Click -= value2;
				}
				this._tsMenuPin_FTE = value;
				tsMenuPin_FTE = this._tsMenuPin_FTE;
				if (tsMenuPin_FTE != null)
				{
					tsMenuPin_FTE.Click += value2;
				}
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00003D27 File Offset: 0x00001F27
		// (set) Token: 0x06000240 RID: 576 RVA: 0x0000DD98 File Offset: 0x0000BF98
		internal virtual ToolStripMenuItem tsMenuPin_AiroCon
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_AiroCon;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_38);
				ToolStripMenuItem tsMenuPin_AiroCon = this._tsMenuPin_AiroCon;
				if (tsMenuPin_AiroCon != null)
				{
					tsMenuPin_AiroCon.Click -= value2;
				}
				this._tsMenuPin_AiroCon = value;
				tsMenuPin_AiroCon = this._tsMenuPin_AiroCon;
				if (tsMenuPin_AiroCon != null)
				{
					tsMenuPin_AiroCon.Click += value2;
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00003D2F File Offset: 0x00001F2F
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00003D37 File Offset: 0x00001F37
		private virtual ToolStripComboBox cbLanguage { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00003D40 File Offset: 0x00001F40
		// (set) Token: 0x06000244 RID: 580 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		internal virtual Button btClearConsole
		{
			[CompilerGenerated]
			get
			{
				return this._btClearConsole;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_27);
				Button btClearConsole = this._btClearConsole;
				if (btClearConsole != null)
				{
					btClearConsole.Click -= value2;
				}
				this._btClearConsole = value;
				btClearConsole = this._btClearConsole;
				if (btClearConsole != null)
				{
					btClearConsole.Click += value2;
				}
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00003D48 File Offset: 0x00001F48
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00003D50 File Offset: 0x00001F50
		internal virtual Button btDonate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000247 RID: 583 RVA: 0x00003D59 File Offset: 0x00001F59
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00003D61 File Offset: 0x00001F61
		internal virtual GClass14 ScrollLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00003D6A File Offset: 0x00001F6A
		// (set) Token: 0x0600024A RID: 586 RVA: 0x0000DE20 File Offset: 0x0000C020
		internal virtual ToolStripSplitButton TsbPixie
		{
			[CompilerGenerated]
			get
			{
				return this._TsbPixie;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_19);
				ToolStripSplitButton tsbPixie = this._TsbPixie;
				if (tsbPixie != null)
				{
					tsbPixie.ButtonClick -= value2;
				}
				this._TsbPixie = value;
				tsbPixie = this._TsbPixie;
				if (tsbPixie != null)
				{
					tsbPixie.ButtonClick += value2;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600024B RID: 587 RVA: 0x00003D72 File Offset: 0x00001F72
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000DE64 File Offset: 0x0000C064
		internal virtual ToolStripMenuItem TsbPixieAdvance
		{
			[CompilerGenerated]
			get
			{
				return this._TsbPixieAdvance;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_32);
				ToolStripMenuItem tsbPixieAdvance = this._TsbPixieAdvance;
				if (tsbPixieAdvance != null)
				{
					tsbPixieAdvance.Click -= value2;
				}
				this._TsbPixieAdvance = value;
				tsbPixieAdvance = this._TsbPixieAdvance;
				if (tsbPixieAdvance != null)
				{
					tsbPixieAdvance.Click += value2;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003D7A File Offset: 0x00001F7A
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		internal virtual ToolStripMenuItem tsMenuPin_Asus
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_Asus;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_43);
				ToolStripMenuItem tsMenuPin_Asus = this._tsMenuPin_Asus;
				if (tsMenuPin_Asus != null)
				{
					tsMenuPin_Asus.Click -= value2;
				}
				this._tsMenuPin_Asus = value;
				tsMenuPin_Asus = this._tsMenuPin_Asus;
				if (tsMenuPin_Asus != null)
				{
					tsMenuPin_Asus.Click += value2;
				}
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003D82 File Offset: 0x00001F82
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00003D8A File Offset: 0x00001F8A
		internal virtual ToolStripMenuItem XBitToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003D93 File Offset: 0x00001F93
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		internal virtual ToolStripMenuItem tsMenuPin_28bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_28bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_44);
				ToolStripMenuItem tsMenuPin_28bit = this._tsMenuPin_28bit;
				if (tsMenuPin_28bit != null)
				{
					tsMenuPin_28bit.Click -= value2;
				}
				this._tsMenuPin_28bit = value;
				tsMenuPin_28bit = this._tsMenuPin_28bit;
				if (tsMenuPin_28bit != null)
				{
					tsMenuPin_28bit.Click += value2;
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00003D9B File Offset: 0x00001F9B
		// (set) Token: 0x06000254 RID: 596 RVA: 0x0000DF30 File Offset: 0x0000C130
		internal virtual ToolStripMenuItem tsMenuPin_32bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_32bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_45);
				ToolStripMenuItem tsMenuPin_32bit = this._tsMenuPin_32bit;
				if (tsMenuPin_32bit != null)
				{
					tsMenuPin_32bit.Click -= value2;
				}
				this._tsMenuPin_32bit = value;
				tsMenuPin_32bit = this._tsMenuPin_32bit;
				if (tsMenuPin_32bit != null)
				{
					tsMenuPin_32bit.Click += value2;
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00003DA3 File Offset: 0x00001FA3
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000DF74 File Offset: 0x0000C174
		internal virtual ToolStripMenuItem tsMenuPin_36bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_36bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_46);
				ToolStripMenuItem tsMenuPin_36bit = this._tsMenuPin_36bit;
				if (tsMenuPin_36bit != null)
				{
					tsMenuPin_36bit.Click -= value2;
				}
				this._tsMenuPin_36bit = value;
				tsMenuPin_36bit = this._tsMenuPin_36bit;
				if (tsMenuPin_36bit != null)
				{
					tsMenuPin_36bit.Click += value2;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00003DAB File Offset: 0x00001FAB
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		internal virtual ToolStripMenuItem tsMenuPin_40bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_40bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_47);
				ToolStripMenuItem tsMenuPin_40bit = this._tsMenuPin_40bit;
				if (tsMenuPin_40bit != null)
				{
					tsMenuPin_40bit.Click -= value2;
				}
				this._tsMenuPin_40bit = value;
				tsMenuPin_40bit = this._tsMenuPin_40bit;
				if (tsMenuPin_40bit != null)
				{
					tsMenuPin_40bit.Click += value2;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00003DB3 File Offset: 0x00001FB3
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0000DFFC File Offset: 0x0000C1FC
		internal virtual ToolStripMenuItem tsMenuPin_44bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_44bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_48);
				ToolStripMenuItem tsMenuPin_44bit = this._tsMenuPin_44bit;
				if (tsMenuPin_44bit != null)
				{
					tsMenuPin_44bit.Click -= value2;
				}
				this._tsMenuPin_44bit = value;
				tsMenuPin_44bit = this._tsMenuPin_44bit;
				if (tsMenuPin_44bit != null)
				{
					tsMenuPin_44bit.Click += value2;
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00003DBB File Offset: 0x00001FBB
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000E040 File Offset: 0x0000C240
		internal virtual ToolStripMenuItem tsMenuPin_48bit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_48bit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_49);
				ToolStripMenuItem tsMenuPin_48bit = this._tsMenuPin_48bit;
				if (tsMenuPin_48bit != null)
				{
					tsMenuPin_48bit.Click -= value2;
				}
				this._tsMenuPin_48bit = value;
				tsMenuPin_48bit = this._tsMenuPin_48bit;
				if (tsMenuPin_48bit != null)
				{
					tsMenuPin_48bit.Click += value2;
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00003DC3 File Offset: 0x00001FC3
		// (set) Token: 0x0600025E RID: 606 RVA: 0x00003DCB File Offset: 0x00001FCB
		internal virtual ToolStripSeparator AllToolStripMenuItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00003DD4 File Offset: 0x00001FD4
		// (set) Token: 0x06000260 RID: 608 RVA: 0x0000E084 File Offset: 0x0000C284
		internal virtual ToolStripMenuItem tsMenuPin_Allxbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_Allxbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_56);
				ToolStripMenuItem tsMenuPin_Allxbit = this._tsMenuPin_Allxbit;
				if (tsMenuPin_Allxbit != null)
				{
					tsMenuPin_Allxbit.Click -= value2;
				}
				this._tsMenuPin_Allxbit = value;
				tsMenuPin_Allxbit = this._tsMenuPin_Allxbit;
				if (tsMenuPin_Allxbit != null)
				{
					tsMenuPin_Allxbit.Click += value2;
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00003DDC File Offset: 0x00001FDC
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00003DE4 File Offset: 0x00001FE4
		internal virtual ToolStripSeparator AllToolStripMenuItem1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00003DED File Offset: 0x00001FED
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		internal virtual ToolStripMenuItem tsMenuPin_All
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_All;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_59);
				ToolStripMenuItem tsMenuPin_All = this._tsMenuPin_All;
				if (tsMenuPin_All != null)
				{
					tsMenuPin_All.Click -= value2;
				}
				this._tsMenuPin_All = value;
				tsMenuPin_All = this._tsMenuPin_All;
				if (tsMenuPin_All != null)
				{
					tsMenuPin_All.Click += value2;
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00003DF5 File Offset: 0x00001FF5
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000E10C File Offset: 0x0000C30C
		internal virtual ToolStripMenuItem tsMenuPin_24RHbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_24RHbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_50);
				ToolStripMenuItem tsMenuPin_24RHbit = this._tsMenuPin_24RHbit;
				if (tsMenuPin_24RHbit != null)
				{
					tsMenuPin_24RHbit.Click -= value2;
				}
				this._tsMenuPin_24RHbit = value;
				tsMenuPin_24RHbit = this._tsMenuPin_24RHbit;
				if (tsMenuPin_24RHbit != null)
				{
					tsMenuPin_24RHbit.Click += value2;
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00003DFD File Offset: 0x00001FFD
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0000E150 File Offset: 0x0000C350
		internal virtual ToolStripMenuItem tsMenuPin_32RHbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_32RHbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_51);
				ToolStripMenuItem tsMenuPin_32RHbit = this._tsMenuPin_32RHbit;
				if (tsMenuPin_32RHbit != null)
				{
					tsMenuPin_32RHbit.Click -= value2;
				}
				this._tsMenuPin_32RHbit = value;
				tsMenuPin_32RHbit = this._tsMenuPin_32RHbit;
				if (tsMenuPin_32RHbit != null)
				{
					tsMenuPin_32RHbit.Click += value2;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00003E05 File Offset: 0x00002005
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00003E0D File Offset: 0x0000200D
		internal virtual ToolStripSeparator ToolStripMenuItem3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00003E16 File Offset: 0x00002016
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0000E194 File Offset: 0x0000C394
		internal virtual ToolStripMenuItem tsMenuPin_24RNbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_24RNbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_53);
				ToolStripMenuItem tsMenuPin_24RNbit = this._tsMenuPin_24RNbit;
				if (tsMenuPin_24RNbit != null)
				{
					tsMenuPin_24RNbit.Click -= value2;
				}
				this._tsMenuPin_24RNbit = value;
				tsMenuPin_24RNbit = this._tsMenuPin_24RNbit;
				if (tsMenuPin_24RNbit != null)
				{
					tsMenuPin_24RNbit.Click += value2;
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00003E1E File Offset: 0x0000201E
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		internal virtual ToolStripMenuItem tsMenuPin_32RNbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_32RNbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_54);
				ToolStripMenuItem tsMenuPin_32RNbit = this._tsMenuPin_32RNbit;
				if (tsMenuPin_32RNbit != null)
				{
					tsMenuPin_32RNbit.Click -= value2;
				}
				this._tsMenuPin_32RNbit = value;
				tsMenuPin_32RNbit = this._tsMenuPin_32RNbit;
				if (tsMenuPin_32RNbit != null)
				{
					tsMenuPin_32RNbit.Click += value2;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00003E26 File Offset: 0x00002026
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000E21C File Offset: 0x0000C41C
		internal virtual ToolStripMenuItem tsMenuPin_48RNbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_48RNbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_55);
				ToolStripMenuItem tsMenuPin_48RNbit = this._tsMenuPin_48RNbit;
				if (tsMenuPin_48RNbit != null)
				{
					tsMenuPin_48RNbit.Click -= value2;
				}
				this._tsMenuPin_48RNbit = value;
				tsMenuPin_48RNbit = this._tsMenuPin_48RNbit;
				if (tsMenuPin_48RNbit != null)
				{
					tsMenuPin_48RNbit.Click += value2;
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00003E2E File Offset: 0x0000202E
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00003E36 File Offset: 0x00002036
		internal virtual ToolStripSeparator ToolStripMenuItem2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00003E3F File Offset: 0x0000203F
		// (set) Token: 0x06000274 RID: 628 RVA: 0x0000E260 File Offset: 0x0000C460
		internal virtual ToolStripMenuItem tsMenuPin_48RHbit
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_48RHbit;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_52);
				ToolStripMenuItem tsMenuPin_48RHbit = this._tsMenuPin_48RHbit;
				if (tsMenuPin_48RHbit != null)
				{
					tsMenuPin_48RHbit.Click -= value2;
				}
				this._tsMenuPin_48RHbit = value;
				tsMenuPin_48RHbit = this._tsMenuPin_48RHbit;
				if (tsMenuPin_48RHbit != null)
				{
					tsMenuPin_48RHbit.Click += value2;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00003E47 File Offset: 0x00002047
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00003E4F File Offset: 0x0000204F
		internal virtual DataGridViewTextBoxColumn DgvDataCampo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003E60 File Offset: 0x00002060
		internal virtual DataGridViewTextBoxColumn DgvDataValor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00003E69 File Offset: 0x00002069
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		internal virtual ToolStripMenuItem tsMenuPin_LiveBox
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_LiveBox;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_57);
				ToolStripMenuItem tsMenuPin_LiveBox = this._tsMenuPin_LiveBox;
				if (tsMenuPin_LiveBox != null)
				{
					tsMenuPin_LiveBox.Click -= value2;
				}
				this._tsMenuPin_LiveBox = value;
				tsMenuPin_LiveBox = this._tsMenuPin_LiveBox;
				if (tsMenuPin_LiveBox != null)
				{
					tsMenuPin_LiveBox.Click += value2;
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00003E71 File Offset: 0x00002071
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000E2E8 File Offset: 0x0000C4E8
		internal virtual ToolStripMenuItem tsMenuPin_Null
		{
			[CompilerGenerated]
			get
			{
				return this._tsMenuPin_Null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_58);
				ToolStripMenuItem tsMenuPin_Null = this._tsMenuPin_Null;
				if (tsMenuPin_Null != null)
				{
					tsMenuPin_Null.Click -= value2;
				}
				this._tsMenuPin_Null = value;
				tsMenuPin_Null = this._tsMenuPin_Null;
				if (tsMenuPin_Null != null)
				{
					tsMenuPin_Null.Click += value2;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00003E79 File Offset: 0x00002079
		// (set) Token: 0x0600027E RID: 638 RVA: 0x00003E81 File Offset: 0x00002081
		internal virtual DataGridViewTextBoxColumn DgvPinsPin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00003E8A File Offset: 0x0000208A
		// (set) Token: 0x06000280 RID: 640 RVA: 0x00003E92 File Offset: 0x00002092
		internal virtual DataGridViewTextBoxColumn DgvPinsDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00003E9B File Offset: 0x0000209B
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0000E32C File Offset: 0x0000C52C
		internal virtual ToolStripTextBox tbScanTime
		{
			[CompilerGenerated]
			get
			{
				return this._tbScanTime;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_63);
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.method_64);
				EventHandler value4 = new EventHandler(this.method_65);
				ToolStripTextBox tbScanTime = this._tbScanTime;
				if (tbScanTime != null)
				{
					tbScanTime.TextChanged -= value2;
					tbScanTime.KeyPress -= value3;
					tbScanTime.Validated -= value4;
				}
				this._tbScanTime = value;
				tbScanTime = this._tbScanTime;
				if (tbScanTime != null)
				{
					tbScanTime.TextChanged += value2;
					tbScanTime.KeyPress += value3;
					tbScanTime.Validated += value4;
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00003EA3 File Offset: 0x000020A3
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00003EAB File Offset: 0x000020AB
		internal virtual DataGridViewImageColumn dgvApsStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00003EB4 File Offset: 0x000020B4
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00003EBC File Offset: 0x000020BC
		internal virtual DataGridViewImageColumn DgvApsPinStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00003EC5 File Offset: 0x000020C5
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00003ECD File Offset: 0x000020CD
		internal virtual DataGridViewTextBoxColumn DgvApsSSID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00003ED6 File Offset: 0x000020D6
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00003EDE File Offset: 0x000020DE
		internal virtual DataGridViewTextBoxColumn DgvApsBSSID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00003EE7 File Offset: 0x000020E7
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003EEF File Offset: 0x000020EF
		internal virtual DataGridViewTextBoxColumn DgvApsChannel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00003EF8 File Offset: 0x000020F8
		// (set) Token: 0x0600028E RID: 654 RVA: 0x00003F00 File Offset: 0x00002100
		internal virtual DataGridViewTextBoxColumn DgvApsSignal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00003F09 File Offset: 0x00002109
		// (set) Token: 0x06000290 RID: 656 RVA: 0x00003F11 File Offset: 0x00002111
		internal virtual DataGridViewTextBoxColumn DgvApsVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00003F1A File Offset: 0x0000211A
		// (set) Token: 0x06000292 RID: 658 RVA: 0x00003F22 File Offset: 0x00002122
		internal virtual DataGridViewCheckBoxColumn DgvApsLocked { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00003F2B File Offset: 0x0000212B
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000E3A8 File Offset: 0x0000C5A8
		internal virtual ToolStripButton tsbPButton
		{
			[CompilerGenerated]
			get
			{
				return this._tsbPButton;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_17);
				ToolStripButton tsbPButton = this._tsbPButton;
				if (tsbPButton != null)
				{
					tsbPButton.Click -= value2;
				}
				this._tsbPButton = value;
				tsbPButton = this._tsbPButton;
				if (tsbPButton != null)
				{
					tsbPButton.Click += value2;
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00003F33 File Offset: 0x00002133
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000E3EC File Offset: 0x0000C5EC
		internal virtual ToolStripButton tsbPbcScan
		{
			[CompilerGenerated]
			get
			{
				return this._tsbPbcScan;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_5);
				ToolStripButton tsbPbcScan = this._tsbPbcScan;
				if (tsbPbcScan != null)
				{
					tsbPbcScan.Click -= value2;
				}
				this._tsbPbcScan = value;
				tsbPbcScan = this._tsbPbcScan;
				if (tsbPbcScan != null)
				{
					tsbPbcScan.Click += value2;
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00003F3B File Offset: 0x0000213B
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000E430 File Offset: 0x0000C630
		internal virtual ToolStripSplitButton btScan
		{
			[CompilerGenerated]
			get
			{
				return this._btScan;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_4);
				ToolStripSplitButton btScan = this._btScan;
				if (btScan != null)
				{
					btScan.ButtonClick -= value2;
				}
				this._btScan = value;
				btScan = this._btScan;
				if (btScan != null)
				{
					btScan.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00003F43 File Offset: 0x00002143
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00003F4B File Offset: 0x0000214B
		internal virtual ToolStripMenuItem tsWPSOnly { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x0400008C RID: 140
		[CompilerGenerated]
		[AccessedThroughProperty("jsApi")]
		private GClass8 gclass8_0;

		// Token: 0x0400008D RID: 141
		private GClass15<GClass9> gclass15_0;

		// Token: 0x0400008E RID: 142
		private GClass9 gclass9_0;

		// Token: 0x0400008F RID: 143
		private GClass12 gclass12_0;

		// Token: 0x04000090 RID: 144
		private int int_0;

		// Token: 0x04000091 RID: 145
		private bool bool_0;

		// Token: 0x04000092 RID: 146
		private bool bool_1;

		// Token: 0x04000093 RID: 147
		private bool bool_2;

		// Token: 0x04000094 RID: 148
		private bool bool_3;

		// Token: 0x04000095 RID: 149
		private BindingSource bindingSource_0;

		// Token: 0x04000096 RID: 150
		private BindingSource bindingSource_1;

		// Token: 0x04000097 RID: 151
		[CompilerGenerated]
		[AccessedThroughProperty("NewsMangr")]
		private GClass10 gclass10_0;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("ImageList1")]
		[CompilerGenerated]
		private ImageList imageList_0;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("ToolTip1")]
		[CompilerGenerated]
		private ToolTip toolTip_0;

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600029E RID: 670
		public delegate void GDelegate4(string message, Color color, bool autoCrLf);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x060002A2 RID: 674
		public delegate void GDelegate5(GClass8.GEnum1 status);
	}
}
