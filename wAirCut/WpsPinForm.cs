using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200003D RID: 61
	[DesignerGenerated]
	public partial class WpsPinForm : Form
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00018A6C File Offset: 0x00016C6C
		public WpsPinForm()
		{
			base.Load += this.WpsPinForm_Load;
			this.sqliteConnection_0 = new SQLiteConnection("Data Source=Bd\\WpsProbePin.db;Version=3;");
			this.dataTable_0 = new DataTable();
			this.BindingSource_0 = new BindingSource();
			this.dataTable_1 = new DataTable();
			this.InitializeComponent();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00018AC8 File Offset: 0x00016CC8
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000049C5 File Offset: 0x00002BC5
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x000049CD File Offset: 0x00002BCD
		internal virtual BindingNavigator bnavWpsPin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000049D6 File Offset: 0x00002BD6
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000049DE File Offset: 0x00002BDE
		internal virtual ToolStripButton BindingNavigatorAddNewItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x000049E7 File Offset: 0x00002BE7
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x000049EF File Offset: 0x00002BEF
		internal virtual ToolStripLabel BindingNavigatorCountItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x000049F8 File Offset: 0x00002BF8
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00019480 File Offset: 0x00017680
		internal virtual ToolStripButton BindingNavigatorDeleteItem
		{
			[CompilerGenerated]
			get
			{
				return this._BindingNavigatorDeleteItem;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_2);
				ToolStripButton bindingNavigatorDeleteItem = this._BindingNavigatorDeleteItem;
				if (bindingNavigatorDeleteItem != null)
				{
					bindingNavigatorDeleteItem.Click -= value2;
				}
				this._BindingNavigatorDeleteItem = value;
				bindingNavigatorDeleteItem = this._BindingNavigatorDeleteItem;
				if (bindingNavigatorDeleteItem != null)
				{
					bindingNavigatorDeleteItem.Click += value2;
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00004A00 File Offset: 0x00002C00
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00004A08 File Offset: 0x00002C08
		internal virtual ToolStripButton BindingNavigatorMoveFirstItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x00004A11 File Offset: 0x00002C11
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004A19 File Offset: 0x00002C19
		internal virtual ToolStripButton BindingNavigatorMovePreviousItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00004A22 File Offset: 0x00002C22
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00004A2A File Offset: 0x00002C2A
		internal virtual ToolStripSeparator BindingNavigatorSeparator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x00004A33 File Offset: 0x00002C33
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00004A3B File Offset: 0x00002C3B
		internal virtual ToolStripTextBox BindingNavigatorPositionItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00004A44 File Offset: 0x00002C44
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00004A4C File Offset: 0x00002C4C
		internal virtual ToolStripSeparator BindingNavigatorSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00004A55 File Offset: 0x00002C55
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00004A5D File Offset: 0x00002C5D
		internal virtual ToolStripButton BindingNavigatorMoveNextItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00004A66 File Offset: 0x00002C66
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00004A6E File Offset: 0x00002C6E
		internal virtual ToolStripButton BindingNavigatorMoveLastItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00004A77 File Offset: 0x00002C77
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00004A7F File Offset: 0x00002C7F
		internal virtual ToolStripSeparator BindingNavigatorSeparator2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004A90 File Offset: 0x00002C90
		internal virtual ToolStripSeparator ToolStripSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00004A99 File Offset: 0x00002C99
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x000194C4 File Offset: 0x000176C4
		internal virtual ToolStripTextBox tbSearch
		{
			[CompilerGenerated]
			get
			{
				return this._tbSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				ToolStripTextBox tbSearch = this._tbSearch;
				if (tbSearch != null)
				{
					tbSearch.TextChanged -= value2;
				}
				this._tbSearch = value;
				tbSearch = this._tbSearch;
				if (tbSearch != null)
				{
					tbSearch.TextChanged += value2;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00004AA1 File Offset: 0x00002CA1
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00019508 File Offset: 0x00017708
		internal virtual DataGridView dgvWps
		{
			[CompilerGenerated]
			get
			{
				return this._dgvWps;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_1);
				KeyEventHandler value3 = new KeyEventHandler(this.method_3);
				DataGridViewRowsRemovedEventHandler value4 = new DataGridViewRowsRemovedEventHandler(this.method_4);
				DataGridViewDataErrorEventHandler value5 = new DataGridViewDataErrorEventHandler(this.method_5);
				DataGridViewCellCancelEventHandler value6 = new DataGridViewCellCancelEventHandler(this.method_8);
				DataGridView dgvWps = this._dgvWps;
				if (dgvWps != null)
				{
					dgvWps.RowValidated -= value2;
					dgvWps.KeyDown -= value3;
					dgvWps.RowsRemoved -= value4;
					dgvWps.DataError -= value5;
					dgvWps.CellBeginEdit -= value6;
				}
				this._dgvWps = value;
				dgvWps = this._dgvWps;
				if (dgvWps != null)
				{
					dgvWps.RowValidated += value2;
					dgvWps.KeyDown += value3;
					dgvWps.RowsRemoved += value4;
					dgvWps.DataError += value5;
					dgvWps.CellBeginEdit += value6;
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00004AA9 File Offset: 0x00002CA9
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00004AB1 File Offset: 0x00002CB1
		internal virtual ToolStripButton tbExport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00004ABA File Offset: 0x00002CBA
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00004AC2 File Offset: 0x00002CC2
		internal virtual ToolStripButton tbImport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00004ACB File Offset: 0x00002CCB
		// (set) Token: 0x06000449 RID: 1097 RVA: 0x00004AD3 File Offset: 0x00002CD3
		internal virtual ToolStripLabel ToolStripLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x00004ADC File Offset: 0x00002CDC
		// (set) Token: 0x0600044B RID: 1099 RVA: 0x00004AE4 File Offset: 0x00002CE4
		internal virtual ToolTip ToolTip_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00004AED File Offset: 0x00002CED
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00004AF5 File Offset: 0x00002CF5
		internal virtual DataGridViewTextBoxColumn dgvWPSId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00004AFE File Offset: 0x00002CFE
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x00004B06 File Offset: 0x00002D06
		internal virtual DataGridViewTextBoxColumn dgvWpsDeviceName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00004B0F File Offset: 0x00002D0F
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00004B17 File Offset: 0x00002D17
		internal virtual DataGridViewTextBoxColumn dgvWPSModelName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00004B20 File Offset: 0x00002D20
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00004B28 File Offset: 0x00002D28
		internal virtual DataGridViewTextBoxColumn dgvWPSModelNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00004B31 File Offset: 0x00002D31
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00004B39 File Offset: 0x00002D39
		internal virtual DataGridViewTextBoxColumn dgvWpsBssid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00004B42 File Offset: 0x00002D42
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x00004B4A File Offset: 0x00002D4A
		internal virtual DataGridViewTextBoxColumn dgvWpsPin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00004B53 File Offset: 0x00002D53
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00004B5B File Offset: 0x00002D5B
		internal virtual DataGridViewComboBoxColumn dgvWpsAlgorithmId { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00004B64 File Offset: 0x00002D64
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x00004B6C File Offset: 0x00002D6C
		internal virtual DataGridViewCheckBoxColumn dgvWpsPixie { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00004B75 File Offset: 0x00002D75
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x000195C8 File Offset: 0x000177C8
		private virtual BindingSource BindingSource_0
		{
			[CompilerGenerated]
			get
			{
				return this.bindingSource_0;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				AddingNewEventHandler value2 = new AddingNewEventHandler(this.method_6);
				BindingSource bindingSource = this.bindingSource_0;
				if (bindingSource != null)
				{
					bindingSource.AddingNew -= value2;
				}
				this.bindingSource_0 = value;
				bindingSource = this.bindingSource_0;
				if (bindingSource != null)
				{
					bindingSource.AddingNew += value2;
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001960C File Offset: 0x0001780C
		private void WpsPinForm_Load(object sender, EventArgs e)
		{
			this.sqliteCommand_0 = new SQLiteCommand("Select * From WPSPins", this.sqliteConnection_0);
			this.sqliteCommand_1 = new SQLiteCommand("Select * From Algorithms", this.sqliteConnection_0);
			this.sqliteDataAdapter_0 = new SQLiteDataAdapter(this.sqliteCommand_0);
			this.sqliteDataAdapter_1 = new SQLiteDataAdapter(this.sqliteCommand_1);
			this.sqliteCommandBuilder_0 = new SQLiteCommandBuilder(this.sqliteDataAdapter_0);
			this.dataTable_0.Locale = CultureInfo.InvariantCulture;
			this.sqliteDataAdapter_0.Fill(this.dataTable_0);
			this.BindingSource_0.DataSource = this.dataTable_0;
			this.sqliteDataAdapter_1.Fill(this.dataTable_1);
			this.dgvWpsAlgorithmId.DataSource = this.dataTable_1;
			this.dgvWpsAlgorithmId.DataPropertyName = "AlgorithmId";
			this.dgvWpsAlgorithmId.DisplayMember = "Name";
			this.dgvWpsAlgorithmId.ValueMember = "id";
			this.dgvWps.AutoGenerateColumns = false;
			this.dgvWps.DataSource = this.BindingSource_0;
			this.bnavWpsPin.BindingSource = this.BindingSource_0;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00004B7D File Offset: 0x00002D7D
		private void method_0(object sender, EventArgs e)
		{
			this.BindingSource_0.Filter = string.Format("BSSID like '%{0}%' or ModelName like '%{0}%' or ModelNumber like '%{0}%' or DeviceName like '%{0}%' or PIN like '%{0}%'", this.tbSearch.Text);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001972C File Offset: 0x0001792C
		private void method_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.sqliteDataAdapter_0.Update(this.dataTable_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001976C File Offset: 0x0001796C
		private void method_2(object sender, EventArgs e)
		{
			if (MessageBox.Show("Se van a eliminar los datos seleccionados, ¿desea continuar?", "Confirm Delete!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					foreach (object obj in this.dgvWps.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow)
						{
							this.BindingSource_0.RemoveAt(dataGridViewRow.Index);
						}
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
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00004B9F File Offset: 0x00002D9F
		private void method_3(object sender, KeyEventArgs e)
		{
			if ((((-(((e.KeyCode == Keys.Delete) > false) ? DataGridViewEditMode.EditOnKeystroke : DataGridViewEditMode.EditOnEnter)) ? DataGridViewEditMode.EditOnKeystroke : DataGridViewEditMode.EditOnEnter) & ~this.dgvWps.EditMode) > DataGridViewEditMode.EditOnEnter && this.dgvWps.SelectedRows.Count > 0)
			{
				this.BindingNavigatorDeleteItem.PerformClick();
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001972C File Offset: 0x0001792C
		private void method_4(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			try
			{
				this.sqliteDataAdapter_0.Update(this.dataTable_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00003867 File Offset: 0x00001A67
		private void method_5(object sender, DataGridViewDataErrorEventArgs e)
		{
			MessageBox.Show(e.Exception.Message, "Wps Pin data base Error", MessageBoxButtons.OK);
			e.Cancel = true;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000197F4 File Offset: 0x000179F4
		private void method_6(object sender, AddingNewEventArgs e)
		{
			DataRowView dataRowView = ((DataView)this.BindingSource_0.List).AddNew();
			dataRowView["id"] = checked(this.method_7(this.sqliteConnection_0, "WPSPins") + 1);
			dataRowView["AlgorithmId"] = -1;
			dataRowView["PixieDust"] = 0;
			dataRowView["DeviceName"] = "";
			dataRowView["ModelName"] = "";
			dataRowView["ModelNumber"] = "";
			e.NewObject = dataRowView;
			this.BindingSource_0.MoveLast();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00004BDF File Offset: 0x00002DDF
		private int method_7(SQLiteConnection sqliteConnection_1, string string_0)
		{
			SQLiteCommand sqliteCommand = new SQLiteCommand("Select MAX(id) From " + string_0, sqliteConnection_1);
			sqliteConnection_1.Open();
			int result = Conversions.ToInteger(sqliteCommand.ExecuteScalar());
			sqliteConnection_1.Close();
			return result;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000198A0 File Offset: 0x00017AA0
		private void method_8(object sender, DataGridViewCellCancelEventArgs e)
		{
			StringListEditor stringListEditor = new StringListEditor();
			if ((e.ColumnIndex == 4 | e.ColumnIndex == 5) && !Information.IsDBNull(this.dgvWps.SelectedCells[e.ColumnIndex]))
			{
				stringListEditor.method_2(Conversions.ToString(this.dgvWps.SelectedCells[e.ColumnIndex].Value));
				stringListEditor.Text = this.dgvWps.Columns[e.ColumnIndex].HeaderText;
				if (stringListEditor.ShowDialog() == DialogResult.OK)
				{
					this.dgvWps.SelectedCells[e.ColumnIndex].Value = stringListEditor.method_3();
				}
			}
		}

		// Token: 0x04000202 RID: 514
		[CompilerGenerated]
		[AccessedThroughProperty("ToolTip1")]
		private ToolTip toolTip_0;

		// Token: 0x0400020B RID: 523
		private SQLiteConnection sqliteConnection_0;

		// Token: 0x0400020C RID: 524
		private SQLiteCommand sqliteCommand_0;

		// Token: 0x0400020D RID: 525
		private SQLiteDataAdapter sqliteDataAdapter_0;

		// Token: 0x0400020E RID: 526
		private SQLiteCommandBuilder sqliteCommandBuilder_0;

		// Token: 0x0400020F RID: 527
		private DataTable dataTable_0;

		// Token: 0x04000210 RID: 528
		[CompilerGenerated]
		[AccessedThroughProperty("bsPin")]
		private BindingSource bindingSource_0;

		// Token: 0x04000211 RID: 529
		private SQLiteCommand sqliteCommand_1;

		// Token: 0x04000212 RID: 530
		private SQLiteDataAdapter sqliteDataAdapter_1;

		// Token: 0x04000213 RID: 531
		private DataTable dataTable_1;
	}
}
