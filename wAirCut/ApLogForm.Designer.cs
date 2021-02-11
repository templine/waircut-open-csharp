namespace wAirCut
{
	// Token: 0x0200000D RID: 13
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ApLogForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000052E4 File Offset: 0x000034E4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.ApLogForm));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.dgvAp = new global::System.Windows.Forms.DataGridView();
			this.dgvApStatus = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.dgvApBssid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvApSSID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvApPin = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvApKey = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bnavAp = new global::System.Windows.Forms.BindingNavigator(this.icontainer_0);
			this.BindingNavigatorAddNewItem = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorCountItem = new global::System.Windows.Forms.ToolStripLabel();
			this.tbImport = new global::System.Windows.Forms.ToolStripButton();
			this.tbExport = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorMoveFirstItem = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorMovePreviousItem = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorSeparator = new global::System.Windows.Forms.ToolStripSeparator();
			this.BindingNavigatorPositionItem = new global::System.Windows.Forms.ToolStripTextBox();
			this.BindingNavigatorSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.BindingNavigatorMoveNextItem = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorMoveLastItem = new global::System.Windows.Forms.ToolStripButton();
			this.BindingNavigatorSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.BindingNavigatorDeleteItem = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.ToolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.tbSearch = new global::System.Windows.Forms.ToolStripTextBox();
			this.tbUpload = new global::System.Windows.Forms.ToolStripButton();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.tbNetworkKey = new global::System.Windows.Forms.TextBox();
			this.Label12 = new global::System.Windows.Forms.Label();
			this.tbWpsPin = new global::System.Windows.Forms.TextBox();
			this.Label13 = new global::System.Windows.Forms.Label();
			this.Label11 = new global::System.Windows.Forms.Label();
			this.tbConfigMethod = new global::System.Windows.Forms.TextBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.tbEncryption = new global::System.Windows.Forms.TextBox();
			this.Label9 = new global::System.Windows.Forms.Label();
			this.tbVersion = new global::System.Windows.Forms.TextBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.tbUUID = new global::System.Windows.Forms.TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.tbRfBand = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.tbSerialNumber = new global::System.Windows.Forms.TextBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.tbManufacturer = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.tbModelNumber = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.tbModelName = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.tbDeviceName = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ToolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.Timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.dgvAp).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bnavAp).BeginInit();
			this.bnavAp.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.dgvAp.AllowUserToAddRows = false;
			this.dgvAp.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Azure;
			this.dgvAp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dgvAp.ClipboardCopyMode = global::System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dgvAp.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAp.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dgvApStatus,
				this.dgvApBssid,
				this.dgvApSSID,
				this.dgvApPin,
				this.dgvApKey
			});
			componentResourceManager.ApplyResources(this.dgvAp, "dgvAp");
			this.dgvAp.Name = "dgvAp";
			this.dgvAp.ReadOnly = true;
			this.dgvAp.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvApStatus.DataPropertyName = "Status";
			this.dgvApStatus.FillWeight = 80f;
			componentResourceManager.ApplyResources(this.dgvApStatus, "dgvApStatus");
			this.dgvApStatus.Name = "dgvApStatus";
			this.dgvApStatus.ReadOnly = true;
			this.dgvApBssid.DataPropertyName = "BSSID";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dgvApBssid.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvApBssid.FillWeight = 150f;
			componentResourceManager.ApplyResources(this.dgvApBssid, "dgvApBssid");
			this.dgvApBssid.Name = "dgvApBssid";
			this.dgvApBssid.ReadOnly = true;
			this.dgvApSSID.DataPropertyName = "SSID";
			this.dgvApSSID.FillWeight = 200f;
			componentResourceManager.ApplyResources(this.dgvApSSID, "dgvApSSID");
			this.dgvApSSID.Name = "dgvApSSID";
			this.dgvApSSID.ReadOnly = true;
			this.dgvApPin.DataPropertyName = "PIN";
			this.dgvApPin.FillWeight = 150f;
			componentResourceManager.ApplyResources(this.dgvApPin, "dgvApPin");
			this.dgvApPin.Name = "dgvApPin";
			this.dgvApPin.ReadOnly = true;
			this.dgvApKey.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvApKey.DataPropertyName = "Key";
			this.dgvApKey.FillWeight = 200f;
			componentResourceManager.ApplyResources(this.dgvApKey, "dgvApKey");
			this.dgvApKey.Name = "dgvApKey";
			this.dgvApKey.ReadOnly = true;
			this.bnavAp.AddNewItem = this.BindingNavigatorAddNewItem;
			this.bnavAp.CountItem = this.BindingNavigatorCountItem;
			this.bnavAp.CountItemFormat = "of {0}";
			this.bnavAp.DeleteItem = null;
			this.bnavAp.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bnavAp.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tbImport,
				this.tbExport,
				this.BindingNavigatorMoveFirstItem,
				this.BindingNavigatorMovePreviousItem,
				this.BindingNavigatorSeparator,
				this.BindingNavigatorPositionItem,
				this.BindingNavigatorCountItem,
				this.BindingNavigatorSeparator1,
				this.BindingNavigatorMoveNextItem,
				this.BindingNavigatorMoveLastItem,
				this.BindingNavigatorSeparator2,
				this.BindingNavigatorAddNewItem,
				this.BindingNavigatorDeleteItem,
				this.ToolStripSeparator1,
				this.ToolStripLabel1,
				this.tbSearch,
				this.tbUpload
			});
			componentResourceManager.ApplyResources(this.bnavAp, "bnavAp");
			this.bnavAp.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
			this.bnavAp.MoveLastItem = this.BindingNavigatorMoveLastItem;
			this.bnavAp.MoveNextItem = this.BindingNavigatorMoveNextItem;
			this.bnavAp.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
			this.bnavAp.Name = "bnavAp";
			this.bnavAp.PositionItem = this.BindingNavigatorPositionItem;
			this.BindingNavigatorAddNewItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorAddNewItem.Image = global::GClass0.Bitmap_2;
			this.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorAddNewItem, "BindingNavigatorAddNewItem");
			componentResourceManager.ApplyResources(this.BindingNavigatorCountItem, "BindingNavigatorCountItem");
			this.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem";
			this.tbImport.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			componentResourceManager.ApplyResources(this.tbImport, "tbImport");
			this.tbImport.Name = "tbImport";
			this.tbExport.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			componentResourceManager.ApplyResources(this.tbExport, "tbExport");
			this.tbExport.Name = "tbExport";
			this.BindingNavigatorMoveFirstItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorMoveFirstItem.Image = global::GClass0.Bitmap_17;
			this.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorMoveFirstItem, "BindingNavigatorMoveFirstItem");
			this.BindingNavigatorMovePreviousItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorMovePreviousItem.Image = global::GClass0.Bitmap_37;
			this.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorMovePreviousItem, "BindingNavigatorMovePreviousItem");
			this.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator";
			componentResourceManager.ApplyResources(this.BindingNavigatorSeparator, "BindingNavigatorSeparator");
			componentResourceManager.ApplyResources(this.BindingNavigatorPositionItem, "BindingNavigatorPositionItem");
			this.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem";
			this.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1";
			componentResourceManager.ApplyResources(this.BindingNavigatorSeparator1, "BindingNavigatorSeparator1");
			this.BindingNavigatorMoveNextItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorMoveNextItem.Image = global::GClass0.Bitmap_38;
			this.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorMoveNextItem, "BindingNavigatorMoveNextItem");
			this.BindingNavigatorMoveLastItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorMoveLastItem.Image = global::GClass0.Bitmap_18;
			this.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorMoveLastItem, "BindingNavigatorMoveLastItem");
			this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
			componentResourceManager.ApplyResources(this.BindingNavigatorSeparator2, "BindingNavigatorSeparator2");
			this.BindingNavigatorDeleteItem.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BindingNavigatorDeleteItem.Image = global::GClass0.Bitmap_13;
			this.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem";
			componentResourceManager.ApplyResources(this.BindingNavigatorDeleteItem, "BindingNavigatorDeleteItem");
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			componentResourceManager.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
			this.ToolStripLabel1.Image = global::GClass0.Bitmap_36;
			this.ToolStripLabel1.Name = "ToolStripLabel1";
			componentResourceManager.ApplyResources(this.ToolStripLabel1, "ToolStripLabel1");
			this.tbSearch.BackColor = global::System.Drawing.SystemColors.Info;
			this.tbSearch.Name = "tbSearch";
			componentResourceManager.ApplyResources(this.tbSearch, "tbSearch");
			this.tbUpload.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tbUpload.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbUpload.Image = global::GClass0.Bitmap_53;
			componentResourceManager.ApplyResources(this.tbUpload, "tbUpload");
			this.tbUpload.Name = "tbUpload";
			this.Panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.Panel1.Controls.Add(this.tbNetworkKey);
			this.Panel1.Controls.Add(this.Label12);
			this.Panel1.Controls.Add(this.tbWpsPin);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Controls.Add(this.Label11);
			this.Panel1.Controls.Add(this.tbConfigMethod);
			this.Panel1.Controls.Add(this.Label10);
			this.Panel1.Controls.Add(this.tbEncryption);
			this.Panel1.Controls.Add(this.Label9);
			this.Panel1.Controls.Add(this.tbVersion);
			this.Panel1.Controls.Add(this.Label8);
			this.Panel1.Controls.Add(this.tbUUID);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.tbRfBand);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.tbSerialNumber);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.tbManufacturer);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.tbModelNumber);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.tbModelName);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.tbDeviceName);
			this.Panel1.Controls.Add(this.Label1);
			componentResourceManager.ApplyResources(this.Panel1, "Panel1");
			this.Panel1.Name = "Panel1";
			componentResourceManager.ApplyResources(this.tbNetworkKey, "tbNetworkKey");
			this.tbNetworkKey.Name = "tbNetworkKey";
			this.tbNetworkKey.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label12, "Label12");
			this.Label12.Name = "Label12";
			componentResourceManager.ApplyResources(this.tbWpsPin, "tbWpsPin");
			this.tbWpsPin.Name = "tbWpsPin";
			this.tbWpsPin.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label13, "Label13");
			this.Label13.Name = "Label13";
			componentResourceManager.ApplyResources(this.Label11, "Label11");
			this.Label11.Name = "Label11";
			componentResourceManager.ApplyResources(this.tbConfigMethod, "tbConfigMethod");
			this.tbConfigMethod.Name = "tbConfigMethod";
			this.tbConfigMethod.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label10, "Label10");
			this.Label10.Name = "Label10";
			componentResourceManager.ApplyResources(this.tbEncryption, "tbEncryption");
			this.tbEncryption.Name = "tbEncryption";
			this.tbEncryption.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label9, "Label9");
			this.Label9.Name = "Label9";
			componentResourceManager.ApplyResources(this.tbVersion, "tbVersion");
			this.tbVersion.Name = "tbVersion";
			this.tbVersion.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label8, "Label8");
			this.Label8.Name = "Label8";
			componentResourceManager.ApplyResources(this.tbUUID, "tbUUID");
			this.tbUUID.Name = "tbUUID";
			this.tbUUID.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label7, "Label7");
			this.Label7.Name = "Label7";
			componentResourceManager.ApplyResources(this.tbRfBand, "tbRfBand");
			this.tbRfBand.Name = "tbRfBand";
			this.tbRfBand.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label6, "Label6");
			this.Label6.Name = "Label6";
			componentResourceManager.ApplyResources(this.tbSerialNumber, "tbSerialNumber");
			this.tbSerialNumber.Name = "tbSerialNumber";
			this.tbSerialNumber.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			componentResourceManager.ApplyResources(this.tbManufacturer, "tbManufacturer");
			this.tbManufacturer.Name = "tbManufacturer";
			this.tbManufacturer.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			componentResourceManager.ApplyResources(this.tbModelNumber, "tbModelNumber");
			this.tbModelNumber.Name = "tbModelNumber";
			this.tbModelNumber.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			componentResourceManager.ApplyResources(this.tbModelName, "tbModelName");
			this.tbModelName.Name = "tbModelName";
			this.tbModelName.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			componentResourceManager.ApplyResources(this.tbDeviceName, "tbDeviceName");
			this.tbDeviceName.Name = "tbDeviceName";
			this.tbDeviceName.ReadOnly = true;
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			this.ToolTip_0.IsBalloon = true;
			this.ToolTip_0.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.Timer_0.Interval = 1000;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.dgvAp);
			base.Controls.Add(this.bnavAp);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ApLogForm";
			((global::System.ComponentModel.ISupportInitialize)this.dgvAp).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bnavAp).EndInit();
			this.bnavAp.ResumeLayout(false);
			this.bnavAp.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001E RID: 30
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
