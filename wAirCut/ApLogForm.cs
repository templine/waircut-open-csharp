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
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class ApLogForm : Form
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0000523C File Offset: 0x0000343C
		public ApLogForm()
		{
			base.Load += this.ApLogForm_Load;
			this.sqliteConnection_0 = new SQLiteConnection("Data Source=Bd\\ApLog.db;Version=3;");
			this.dataTable_0 = new DataTable();
			this.BindingSource_0 = new BindingSource();
			this.dataTable_1 = new DataTable();
			this.toolTip_1 = new ToolTip();
			this.InitializeComponent();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000052A4 File Offset: 0x000034A4
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000034D1 File Offset: 0x000016D1
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000063C0 File Offset: 0x000045C0
		internal virtual DataGridView dgvAp
		{
			[CompilerGenerated]
			get
			{
				return this._dgvAp;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.method_1);
				KeyEventHandler value3 = new KeyEventHandler(this.method_3);
				DataGridViewRowsRemovedEventHandler value4 = new DataGridViewRowsRemovedEventHandler(this.method_4);
				DataGridViewDataErrorEventHandler value5 = new DataGridViewDataErrorEventHandler(this.method_5);
				DataGridViewCellFormattingEventHandler value6 = new DataGridViewCellFormattingEventHandler(this.method_6);
				DataGridView dgvAp = this._dgvAp;
				if (dgvAp != null)
				{
					dgvAp.RowValidated -= value2;
					dgvAp.KeyDown -= value3;
					dgvAp.RowsRemoved -= value4;
					dgvAp.DataError -= value5;
					dgvAp.CellFormatting -= value6;
				}
				this._dgvAp = value;
				dgvAp = this._dgvAp;
				if (dgvAp != null)
				{
					dgvAp.RowValidated += value2;
					dgvAp.KeyDown += value3;
					dgvAp.RowsRemoved += value4;
					dgvAp.DataError += value5;
					dgvAp.CellFormatting += value6;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000034D9 File Offset: 0x000016D9
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000034E1 File Offset: 0x000016E1
		internal virtual BindingNavigator bnavAp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000034EA File Offset: 0x000016EA
		// (set) Token: 0x060000EF RID: 239 RVA: 0x000034F2 File Offset: 0x000016F2
		internal virtual ToolStripButton BindingNavigatorAddNewItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000034FB File Offset: 0x000016FB
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00003503 File Offset: 0x00001703
		internal virtual ToolStripLabel BindingNavigatorCountItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000350C File Offset: 0x0000170C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00006480 File Offset: 0x00004680
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00003514 File Offset: 0x00001714
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000351C File Offset: 0x0000171C
		internal virtual ToolStripButton BindingNavigatorMoveFirstItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00003525 File Offset: 0x00001725
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000352D File Offset: 0x0000172D
		internal virtual ToolStripButton BindingNavigatorMovePreviousItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00003536 File Offset: 0x00001736
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000353E File Offset: 0x0000173E
		internal virtual ToolStripSeparator BindingNavigatorSeparator { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00003547 File Offset: 0x00001747
		// (set) Token: 0x060000FB RID: 251 RVA: 0x0000354F File Offset: 0x0000174F
		internal virtual ToolStripTextBox BindingNavigatorPositionItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00003558 File Offset: 0x00001758
		// (set) Token: 0x060000FD RID: 253 RVA: 0x00003560 File Offset: 0x00001760
		internal virtual ToolStripSeparator BindingNavigatorSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00003569 File Offset: 0x00001769
		// (set) Token: 0x060000FF RID: 255 RVA: 0x00003571 File Offset: 0x00001771
		internal virtual ToolStripButton BindingNavigatorMoveNextItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000357A File Offset: 0x0000177A
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00003582 File Offset: 0x00001782
		internal virtual ToolStripButton BindingNavigatorMoveLastItem { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000358B File Offset: 0x0000178B
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00003593 File Offset: 0x00001793
		internal virtual ToolStripSeparator BindingNavigatorSeparator2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000359C File Offset: 0x0000179C
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000035A4 File Offset: 0x000017A4
		internal virtual ToolStripSeparator ToolStripSeparator1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000035AD File Offset: 0x000017AD
		// (set) Token: 0x06000107 RID: 263 RVA: 0x000064C4 File Offset: 0x000046C4
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000108 RID: 264 RVA: 0x000035B5 File Offset: 0x000017B5
		// (set) Token: 0x06000109 RID: 265 RVA: 0x000035BD File Offset: 0x000017BD
		internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600010A RID: 266 RVA: 0x000035C6 File Offset: 0x000017C6
		// (set) Token: 0x0600010B RID: 267 RVA: 0x000035CE File Offset: 0x000017CE
		internal virtual TextBox tbDeviceName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000035D7 File Offset: 0x000017D7
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000035DF File Offset: 0x000017DF
		internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000035E8 File Offset: 0x000017E8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000035F0 File Offset: 0x000017F0
		internal virtual TextBox tbConfigMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000035F9 File Offset: 0x000017F9
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00003601 File Offset: 0x00001801
		internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000360A File Offset: 0x0000180A
		// (set) Token: 0x06000113 RID: 275 RVA: 0x00003612 File Offset: 0x00001812
		internal virtual TextBox tbEncryption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000361B File Offset: 0x0000181B
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00003623 File Offset: 0x00001823
		internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00003634 File Offset: 0x00001834
		internal virtual TextBox tbVersion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000363D File Offset: 0x0000183D
		// (set) Token: 0x06000119 RID: 281 RVA: 0x00003645 File Offset: 0x00001845
		internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000364E File Offset: 0x0000184E
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00006508 File Offset: 0x00004708
		internal virtual TextBox tbUUID
		{
			[CompilerGenerated]
			get
			{
				return this._tbUUID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_7);
				TextBox tbUUID = this._tbUUID;
				if (tbUUID != null)
				{
					tbUUID.TextChanged -= value2;
				}
				this._tbUUID = value;
				tbUUID = this._tbUUID;
				if (tbUUID != null)
				{
					tbUUID.TextChanged += value2;
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00003656 File Offset: 0x00001856
		// (set) Token: 0x0600011D RID: 285 RVA: 0x0000365E File Offset: 0x0000185E
		internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00003667 File Offset: 0x00001867
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000366F File Offset: 0x0000186F
		internal virtual TextBox tbRfBand { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00003678 File Offset: 0x00001878
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00003680 File Offset: 0x00001880
		internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003689 File Offset: 0x00001889
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000654C File Offset: 0x0000474C
		internal virtual TextBox tbSerialNumber
		{
			[CompilerGenerated]
			get
			{
				return this._tbSerialNumber;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_8);
				TextBox tbSerialNumber = this._tbSerialNumber;
				if (tbSerialNumber != null)
				{
					tbSerialNumber.TextChanged -= value2;
				}
				this._tbSerialNumber = value;
				tbSerialNumber = this._tbSerialNumber;
				if (tbSerialNumber != null)
				{
					tbSerialNumber.TextChanged += value2;
				}
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003691 File Offset: 0x00001891
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00003699 File Offset: 0x00001899
		internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000036A2 File Offset: 0x000018A2
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000036AA File Offset: 0x000018AA
		internal virtual TextBox tbManufacturer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000036B3 File Offset: 0x000018B3
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000036BB File Offset: 0x000018BB
		internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x0600012B RID: 299 RVA: 0x000036CC File Offset: 0x000018CC
		internal virtual TextBox tbModelNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000036D5 File Offset: 0x000018D5
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000036DD File Offset: 0x000018DD
		internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000036E6 File Offset: 0x000018E6
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000036EE File Offset: 0x000018EE
		internal virtual TextBox tbModelName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000036F7 File Offset: 0x000018F7
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000036FF File Offset: 0x000018FF
		internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00003708 File Offset: 0x00001908
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00003710 File Offset: 0x00001910
		internal virtual ToolStripButton tbImport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00003719 File Offset: 0x00001919
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00003721 File Offset: 0x00001921
		internal virtual ToolStripButton tbExport { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000372A File Offset: 0x0000192A
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00003732 File Offset: 0x00001932
		internal virtual ToolStripLabel ToolStripLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000373B File Offset: 0x0000193B
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00003743 File Offset: 0x00001943
		internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00003754 File Offset: 0x00001954
		internal virtual DataGridViewImageColumn dgvApStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000375D File Offset: 0x0000195D
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00003765 File Offset: 0x00001965
		internal virtual DataGridViewTextBoxColumn dgvApBssid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000376E File Offset: 0x0000196E
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00003776 File Offset: 0x00001976
		internal virtual DataGridViewTextBoxColumn dgvApSSID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000377F File Offset: 0x0000197F
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00003787 File Offset: 0x00001987
		internal virtual DataGridViewTextBoxColumn dgvApPin { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00003790 File Offset: 0x00001990
		// (set) Token: 0x06000143 RID: 323 RVA: 0x00003798 File Offset: 0x00001998
		internal virtual DataGridViewTextBoxColumn dgvApKey { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000037A1 File Offset: 0x000019A1
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00006590 File Offset: 0x00004790
		internal virtual TextBox tbNetworkKey
		{
			[CompilerGenerated]
			get
			{
				return this._tbNetworkKey;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_10);
				TextBox tbNetworkKey = this._tbNetworkKey;
				if (tbNetworkKey != null)
				{
					tbNetworkKey.TextChanged -= value2;
				}
				this._tbNetworkKey = value;
				tbNetworkKey = this._tbNetworkKey;
				if (tbNetworkKey != null)
				{
					tbNetworkKey.TextChanged += value2;
				}
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000037A9 File Offset: 0x000019A9
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000037B1 File Offset: 0x000019B1
		internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000037BA File Offset: 0x000019BA
		// (set) Token: 0x06000149 RID: 329 RVA: 0x000065D4 File Offset: 0x000047D4
		internal virtual TextBox tbWpsPin
		{
			[CompilerGenerated]
			get
			{
				return this._tbWpsPin;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_9);
				TextBox tbWpsPin = this._tbWpsPin;
				if (tbWpsPin != null)
				{
					tbWpsPin.TextChanged -= value2;
				}
				this._tbWpsPin = value;
				tbWpsPin = this._tbWpsPin;
				if (tbWpsPin != null)
				{
					tbWpsPin.TextChanged += value2;
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000037C2 File Offset: 0x000019C2
		// (set) Token: 0x0600014B RID: 331 RVA: 0x000037CA File Offset: 0x000019CA
		internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600014C RID: 332 RVA: 0x000037D3 File Offset: 0x000019D3
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00006618 File Offset: 0x00004818
		internal virtual ToolStripButton tbUpload
		{
			[CompilerGenerated]
			get
			{
				return this._tbUpload;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_11);
				ToolStripButton tbUpload = this._tbUpload;
				if (tbUpload != null)
				{
					tbUpload.Click -= value2;
				}
				this._tbUpload = value;
				tbUpload = this._tbUpload;
				if (tbUpload != null)
				{
					tbUpload.Click += value2;
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600014E RID: 334 RVA: 0x000037DB File Offset: 0x000019DB
		// (set) Token: 0x0600014F RID: 335 RVA: 0x000037E3 File Offset: 0x000019E3
		internal virtual ToolTip ToolTip_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000037EC File Offset: 0x000019EC
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000665C File Offset: 0x0000485C
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
				EventHandler value2 = new EventHandler(this.method_12);
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000037F4 File Offset: 0x000019F4
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000037FC File Offset: 0x000019FC
		private virtual BindingSource BindingSource_0 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x06000154 RID: 340 RVA: 0x000066A0 File Offset: 0x000048A0
		private void ApLogForm_Load(object sender, EventArgs e)
		{
			this.sqliteCommand_0 = new SQLiteCommand("Select * From Networks", this.sqliteConnection_0);
			this.sqliteCommand_1 = new SQLiteCommand("Select * From Algorithms", this.sqliteConnection_0);
			this.sqliteDataAdapter_0 = new SQLiteDataAdapter(this.sqliteCommand_0);
			this.sqliteDataAdapter_1 = new SQLiteDataAdapter(this.sqliteCommand_1);
			this.sqliteCommandBuilder_0 = new SQLiteCommandBuilder(this.sqliteDataAdapter_0);
			this.dataTable_0.Locale = CultureInfo.InvariantCulture;
			this.sqliteDataAdapter_0.Fill(this.dataTable_0);
			this.BindingSource_0.DataSource = this.dataTable_0;
			this.sqliteDataAdapter_1.Fill(this.dataTable_1);
			this.dgvAp.AutoGenerateColumns = false;
			this.dgvAp.DataSource = this.BindingSource_0;
			this.tbDeviceName.DataBindings.Add("Text", this.BindingSource_0, "DeviceName");
			this.tbModelName.DataBindings.Add("Text", this.BindingSource_0, "ModelName");
			this.tbModelNumber.DataBindings.Add("Text", this.BindingSource_0, "ModelNumber");
			this.tbManufacturer.DataBindings.Add("Text", this.BindingSource_0, "Manufacturer");
			this.tbSerialNumber.DataBindings.Add("Text", this.BindingSource_0, "SerialNumber");
			this.tbRfBand.DataBindings.Add("Text", this.BindingSource_0, "RfBand");
			this.tbUUID.DataBindings.Add("Text", this.BindingSource_0, "UUID");
			this.tbVersion.DataBindings.Add("Text", this.BindingSource_0, "Version");
			this.tbEncryption.DataBindings.Add("Text", this.BindingSource_0, "Encryption");
			this.tbConfigMethod.DataBindings.Add("Text", this.BindingSource_0, "ConfigMethods");
			this.tbWpsPin.DataBindings.Add("Text", this.BindingSource_0, "PIN");
			this.tbNetworkKey.DataBindings.Add("Text", this.BindingSource_0, "Key");
			this.bnavAp.BindingSource = this.BindingSource_0;
			this.tbUpload.Enabled = Class13.smethod_16();
			this.Timer_0.Enabled = Class13.smethod_16();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003805 File Offset: 0x00001A05
		private void method_0(object sender, EventArgs e)
		{
			this.BindingSource_0.Filter = string.Format("BSSID like '%{0}%' or SSID like '%{0}%' or ModelName like '%{0}%'", this.tbSearch.Text);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000692C File Offset: 0x00004B2C
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

		// Token: 0x06000157 RID: 343 RVA: 0x0000696C File Offset: 0x00004B6C
		private void method_2(object sender, EventArgs e)
		{
			if (MessageBox.Show("Se van a eliminar los datos seleccionados, ¿desea continuar?", "Confirm Delete!", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				try
				{
					foreach (object obj in this.dgvAp.SelectedRows)
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

		// Token: 0x06000158 RID: 344 RVA: 0x00003827 File Offset: 0x00001A27
		private void method_3(object sender, KeyEventArgs e)
		{
			if ((((-(((e.KeyCode == Keys.Delete) > false) ? DataGridViewEditMode.EditOnKeystroke : DataGridViewEditMode.EditOnEnter)) ? DataGridViewEditMode.EditOnKeystroke : DataGridViewEditMode.EditOnEnter) & ~this.dgvAp.EditMode) > DataGridViewEditMode.EditOnEnter && this.dgvAp.SelectedRows.Count > 0)
			{
				this.BindingNavigatorDeleteItem.PerformClick();
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000692C File Offset: 0x00004B2C
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

		// Token: 0x0600015A RID: 346 RVA: 0x00003867 File Offset: 0x00001A67
		private void method_5(object sender, DataGridViewDataErrorEventArgs e)
		{
			MessageBox.Show(e.Exception.Message, "Wps Pin data base Error", MessageBoxButtons.OK);
			e.Cancel = true;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000069F4 File Offset: 0x00004BF4
		private void method_6(object sender, DataGridViewCellFormattingEventArgs e)
		{
			string name = ((DataGridView)sender).Columns[e.ColumnIndex].Name;
			if (Operators.CompareString(name, "dgvApStatus", false) == 0)
			{
				for (;;)
				{
					IL_CE:
					GClass9.GEnum3 genum = (GClass9.GEnum3)Conversions.ToInteger(e.Value);
					for (;;)
					{
						IL_B7:
						switch (genum)
						{
						case GClass9.GEnum3.Unknow:
							goto IL_16A;
						case GClass9.GEnum3.Ok:
							goto IL_177;
						case GClass9.GEnum3.Nok:
							goto IL_1B4;
						default:
						{
							uint num2;
							uint num = num2 * 401074821U ^ 2237776855U;
							for (;;)
							{
								switch ((num2 = (num ^ 1994210728U)) % 21U)
								{
								case 0U:
									goto IL_EA;
								case 1U:
								case 4U:
								case 18U:
									goto IL_1EF;
								case 2U:
									goto IL_146;
								case 3U:
									num = (num2 * 2268136565U ^ 3654789821U);
									continue;
								case 5U:
									goto IL_14E;
								case 6U:
									goto IL_182;
								case 7U:
									goto IL_16A;
								case 8U:
									return;
								case 9U:
									goto IL_F8;
								case 10U:
									goto IL_B7;
								case 11U:
									goto IL_106;
								case 13U:
								case 16U:
									goto IL_DC;
								case 14U:
									goto IL_177;
								case 15U:
									return;
								case 17U:
									goto IL_1BF;
								case 19U:
									goto IL_1B4;
								case 20U:
									goto IL_CE;
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
				IL_16A:
				e.Value = GClass0.Bitmap_6;
				goto IL_1EF;
				IL_177:
				e.Value = GClass0.Bitmap_15;
				IL_182:
				this.dgvAp.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_12;
				goto IL_1EF;
				IL_1B4:
				e.Value = GClass0.Bitmap_16;
				IL_1BF:
				this.dgvAp.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = Class10.String_11;
				IL_1EF:
				e.FormattingApplied = true;
				return;
			}
			IL_DC:
			if (Operators.CompareString(name, "dgvApSSID", false) == 0)
			{
				goto IL_146;
			}
			IL_EA:
			if (Operators.CompareString(name, "dgvApKey", false) == 0)
			{
				goto IL_146;
			}
			IL_F8:
			if (Operators.CompareString(name, "dgvApBSSID", false) != 0)
			{
				return;
			}
			IL_106:
			e.Value = Operators.ConcatenateObject(NewLateBinding.LateGet(e.Value, null, "Substring", new object[]
			{
				0,
				9
			}, null, null, null), "XX:XX:XX");
			return;
			IL_146:
			if (Class13.bool_1)
			{
				goto IL_14E;
			}
			return;
			IL_14E:
			e.Value = Class13.smethod_13(Conversions.ToString(e.Value), "X");
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003887 File Offset: 0x00001A87
		private void method_7(object sender, EventArgs e)
		{
			if (Class13.bool_1)
			{
				this.tbUUID.Text = Class13.smethod_13(this.tbUUID.Text, "X");
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000038B0 File Offset: 0x00001AB0
		private void method_8(object sender, EventArgs e)
		{
			if (Class13.bool_1)
			{
				this.tbSerialNumber.Text = Class13.smethod_13(this.tbSerialNumber.Text, "X");
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000038D9 File Offset: 0x00001AD9
		private void method_9(object sender, EventArgs e)
		{
			if (Class13.bool_1)
			{
				this.tbWpsPin.Text = Class13.smethod_13(this.tbWpsPin.Text, "X");
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00003902 File Offset: 0x00001B02
		private void method_10(object sender, EventArgs e)
		{
			if (Class13.bool_1)
			{
				this.tbNetworkKey.Text = Class13.smethod_13(this.tbNetworkKey.Text, "X");
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000392B File Offset: 0x00001B2B
		private void method_11(object sender, EventArgs e)
		{
			if (Class13.smethod_16())
			{
				new GClass1().method_0();
				MessageBox.Show("Gracias, Thanks, merci, спасибо", "Uploaded...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006BF8 File Offset: 0x00004DF8
		private void method_12(object sender, EventArgs e)
		{
			if (this.Timer_0.Interval < 4000)
			{
				this.toolTip_1.ToolTipIcon = ToolTipIcon.None;
				this.toolTip_1.IsBalloon = true;
				this.toolTip_1.UseAnimation = true;
				this.toolTip_1.UseFading = true;
				this.toolTip_1.AutomaticDelay = 500;
				this.toolTip_1.Show(this.tbUpload.ToolTipText, this, new Point(this.tbUpload.Bounds.Location.X, checked(this.tbUpload.Bounds.Location.Y - 7)));
				this.Timer_0.Interval = 4000;
				return;
			}
			this.toolTip_1.Dispose();
			this.Timer_0.Enabled = false;
		}

		// Token: 0x04000051 RID: 81
		[AccessedThroughProperty("ToolTip1")]
		[CompilerGenerated]
		private ToolTip toolTip_0;

		// Token: 0x04000052 RID: 82
		[CompilerGenerated]
		[AccessedThroughProperty("TimerToolTip")]
		private Timer timer_0;

		// Token: 0x04000053 RID: 83
		private SQLiteConnection sqliteConnection_0;

		// Token: 0x04000054 RID: 84
		private SQLiteCommand sqliteCommand_0;

		// Token: 0x04000055 RID: 85
		private SQLiteDataAdapter sqliteDataAdapter_0;

		// Token: 0x04000056 RID: 86
		private SQLiteCommandBuilder sqliteCommandBuilder_0;

		// Token: 0x04000057 RID: 87
		private DataTable dataTable_0;

		// Token: 0x04000058 RID: 88
		[CompilerGenerated]
		[AccessedThroughProperty("bsAp")]
		private BindingSource bindingSource_0;

		// Token: 0x04000059 RID: 89
		private SQLiteCommand sqliteCommand_1;

		// Token: 0x0400005A RID: 90
		private SQLiteDataAdapter sqliteDataAdapter_1;

		// Token: 0x0400005B RID: 91
		private DataTable dataTable_1;

		// Token: 0x0400005C RID: 92
		private ToolTip toolTip_1;
	}
}
