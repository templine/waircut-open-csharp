namespace wAirCut
{
	// Token: 0x0200003D RID: 61
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WpsPinForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000425 RID: 1061 RVA: 0x00018B08 File Offset: 0x00016D08
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.WpsPinForm));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.bnavWpsPin = new global::System.Windows.Forms.BindingNavigator(this.icontainer_0);
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
			this.dgvWps = new global::System.Windows.Forms.DataGridView();
			this.dgvWPSId = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWpsDeviceName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWPSModelName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWPSModelNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWpsBssid = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWpsPin = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvWpsAlgorithmId = new global::System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgvWpsPixie = new global::System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.ToolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			((global::System.ComponentModel.ISupportInitialize)this.bnavWpsPin).BeginInit();
			this.bnavWpsPin.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvWps).BeginInit();
			base.SuspendLayout();
			this.bnavWpsPin.AddNewItem = this.BindingNavigatorAddNewItem;
			this.bnavWpsPin.CountItem = this.BindingNavigatorCountItem;
			this.bnavWpsPin.CountItemFormat = "of {0}";
			this.bnavWpsPin.DeleteItem = null;
			this.bnavWpsPin.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bnavWpsPin.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
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
				this.tbSearch
			});
			componentResourceManager.ApplyResources(this.bnavWpsPin, "bnavWpsPin");
			this.bnavWpsPin.MoveFirstItem = this.BindingNavigatorMoveFirstItem;
			this.bnavWpsPin.MoveLastItem = this.BindingNavigatorMoveLastItem;
			this.bnavWpsPin.MoveNextItem = this.BindingNavigatorMoveNextItem;
			this.bnavWpsPin.MovePreviousItem = this.BindingNavigatorMovePreviousItem;
			this.bnavWpsPin.Name = "bnavWpsPin";
			this.bnavWpsPin.PositionItem = this.BindingNavigatorPositionItem;
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
			this.tbSearch.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbSearch.Name = "tbSearch";
			componentResourceManager.ApplyResources(this.tbSearch, "tbSearch");
			this.dgvWps.AllowUserToAddRows = false;
			this.dgvWps.AllowUserToDeleteRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Azure;
			this.dgvWps.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dgvWps.ClipboardCopyMode = global::System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			this.dgvWps.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWps.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.dgvWPSId,
				this.dgvWpsDeviceName,
				this.dgvWPSModelName,
				this.dgvWPSModelNumber,
				this.dgvWpsBssid,
				this.dgvWpsPin,
				this.dgvWpsAlgorithmId,
				this.dgvWpsPixie
			});
			componentResourceManager.ApplyResources(this.dgvWps, "dgvWps");
			this.dgvWps.Name = "dgvWps";
			this.dgvWps.RowHeadersWidthSizeMode = global::System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvWps.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWPSId.DataPropertyName = "id";
			componentResourceManager.ApplyResources(this.dgvWPSId, "dgvWPSId");
			this.dgvWPSId.Name = "dgvWPSId";
			this.dgvWPSId.ReadOnly = true;
			this.dgvWpsDeviceName.DataPropertyName = "DeviceName";
			componentResourceManager.ApplyResources(this.dgvWpsDeviceName, "dgvWpsDeviceName");
			this.dgvWpsDeviceName.Name = "dgvWpsDeviceName";
			this.dgvWPSModelName.DataPropertyName = "ModelName";
			componentResourceManager.ApplyResources(this.dgvWPSModelName, "dgvWPSModelName");
			this.dgvWPSModelName.Name = "dgvWPSModelName";
			this.dgvWPSModelNumber.DataPropertyName = "ModelNumber";
			componentResourceManager.ApplyResources(this.dgvWPSModelNumber, "dgvWPSModelNumber");
			this.dgvWPSModelNumber.Name = "dgvWPSModelNumber";
			this.dgvWpsBssid.DataPropertyName = "BSSID";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Lucida Console", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dgvWpsBssid.DefaultCellStyle = dataGridViewCellStyle2;
			componentResourceManager.ApplyResources(this.dgvWpsBssid, "dgvWpsBssid");
			this.dgvWpsBssid.Name = "dgvWpsBssid";
			this.dgvWpsPin.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dgvWpsPin.DataPropertyName = "PIN";
			this.dgvWpsPin.FillWeight = 200f;
			componentResourceManager.ApplyResources(this.dgvWpsPin, "dgvWpsPin");
			this.dgvWpsPin.Name = "dgvWpsPin";
			componentResourceManager.ApplyResources(this.dgvWpsAlgorithmId, "dgvWpsAlgorithmId");
			this.dgvWpsAlgorithmId.Name = "dgvWpsAlgorithmId";
			this.dgvWpsPixie.DataPropertyName = "PixieDust";
			this.dgvWpsPixie.FalseValue = "0";
			this.dgvWpsPixie.FillWeight = 80f;
			componentResourceManager.ApplyResources(this.dgvWpsPixie, "dgvWpsPixie");
			this.dgvWpsPixie.IndeterminateValue = "0";
			this.dgvWpsPixie.Name = "dgvWpsPixie";
			this.dgvWpsPixie.TrueValue = "1";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.Controls.Add(this.dgvWps);
			base.Controls.Add(this.bnavWpsPin);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "WpsPinForm";
			((global::System.ComponentModel.ISupportInitialize)this.bnavWpsPin).EndInit();
			this.bnavWpsPin.ResumeLayout(false);
			this.bnavWpsPin.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvWps).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040001EF RID: 495
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
