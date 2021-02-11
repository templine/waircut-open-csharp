namespace wAirCut
{
	// Token: 0x02000030 RID: 48
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RandomPinForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000360 RID: 864 RVA: 0x0001429C File Offset: 0x0001249C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.RandomPinForm));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.tsbOpen = new global::System.Windows.Forms.ToolStripButton();
			this.tsbSaveMenu = new global::System.Windows.Forms.ToolStripDropDownButton();
			this.TsbSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tsbAutoSave = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.TbTime = new global::System.Windows.Forms.ToolStripTextBox();
			this.TbStart = new global::System.Windows.Forms.ToolStripButton();
			this.TbStop = new global::System.Windows.Forms.ToolStripButton();
			this.Timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.DgvInfo = new global::System.Windows.Forms.DataGridView();
			this.DgvDataCampo = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DgvDataValor = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OpenFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.lbResult = new global::System.Windows.Forms.Label();
			this.tsFormatMenu = new global::System.Windows.Forms.ToolStrip();
			this.ToolStripLabel1 = new global::System.Windows.Forms.ToolStripLabel();
			this.tbPinFormat1 = new global::System.Windows.Forms.ToolStripTextBox();
			this.tbPinFormat2 = new global::System.Windows.Forms.ToolStripTextBox();
			this.tsbCalculate = new global::System.Windows.Forms.ToolStripButton();
			this.ProgressBar1 = new global::Class12();
			this.ToolStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DgvInfo).BeginInit();
			this.tsFormatMenu.SuspendLayout();
			base.SuspendLayout();
			this.ToolStrip1.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tsbOpen,
				this.tsbSaveMenu,
				this.ToolStripSeparator1,
				this.TbTime,
				this.TbStart,
				this.TbStop
			});
			componentResourceManager.ApplyResources(this.ToolStrip1, "ToolStrip1");
			this.ToolStrip1.Name = "ToolStrip1";
			this.tsbOpen.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbOpen.Image = global::GClass0.Bitmap_39;
			componentResourceManager.ApplyResources(this.tsbOpen, "tsbOpen");
			this.tsbOpen.Name = "tsbOpen";
			this.tsbSaveMenu.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbSaveMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.TsbSave,
				this.tsbAutoSave
			});
			this.tsbSaveMenu.Image = global::GClass0.Bitmap_49;
			componentResourceManager.ApplyResources(this.tsbSaveMenu, "tsbSaveMenu");
			this.tsbSaveMenu.Name = "tsbSaveMenu";
			this.TsbSave.Image = global::GClass0.Bitmap_49;
			this.TsbSave.Name = "TsbSave";
			componentResourceManager.ApplyResources(this.TsbSave, "TsbSave");
			this.tsbAutoSave.Checked = true;
			this.tsbAutoSave.CheckOnClick = true;
			this.tsbAutoSave.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.tsbAutoSave.Name = "tsbAutoSave";
			componentResourceManager.ApplyResources(this.tsbAutoSave, "tsbAutoSave");
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			componentResourceManager.ApplyResources(this.ToolStripSeparator1, "ToolStripSeparator1");
			this.TbTime.Name = "TbTime";
			componentResourceManager.ApplyResources(this.TbTime, "TbTime");
			this.TbStart.Image = global::GClass0.Bitmap_40;
			componentResourceManager.ApplyResources(this.TbStart, "TbStart");
			this.TbStart.Name = "TbStart";
			componentResourceManager.ApplyResources(this.TbStop, "TbStop");
			this.TbStop.Image = global::GClass0.Bitmap_51;
			this.TbStop.Name = "TbStop";
			this.Timer_0.Interval = 1000;
			this.DgvInfo.AllowUserToAddRows = false;
			this.DgvInfo.AllowUserToDeleteRows = false;
			this.DgvInfo.AllowUserToResizeColumns = false;
			this.DgvInfo.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.LemonChiffon;
			this.DgvInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DgvInfo.BackgroundColor = global::System.Drawing.SystemColors.Info;
			this.DgvInfo.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvInfo.ColumnHeadersVisible = false;
			this.DgvInfo.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.DgvDataCampo,
				this.DgvDataValor
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.LightGoldenrodYellow;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DgvInfo.DefaultCellStyle = dataGridViewCellStyle2;
			componentResourceManager.ApplyResources(this.DgvInfo, "DgvInfo");
			this.DgvInfo.MultiSelect = false;
			this.DgvInfo.Name = "DgvInfo";
			this.DgvInfo.ReadOnly = true;
			this.DgvInfo.RowHeadersVisible = false;
			this.DgvInfo.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgvInfo.ShowCellErrors = false;
			this.DgvInfo.StandardTab = true;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DgvDataCampo.DefaultCellStyle = dataGridViewCellStyle3;
			componentResourceManager.ApplyResources(this.DgvDataCampo, "DgvDataCampo");
			this.DgvDataCampo.Name = "DgvDataCampo";
			this.DgvDataCampo.ReadOnly = true;
			this.DgvDataValor.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			componentResourceManager.ApplyResources(this.DgvDataValor, "DgvDataValor");
			this.DgvDataValor.Name = "DgvDataValor";
			this.DgvDataValor.ReadOnly = true;
			this.OpenFileDialog_0.DefaultExt = "log";
			this.OpenFileDialog_0.FileName = "OpenFileDialog1";
			componentResourceManager.ApplyResources(this.OpenFileDialog_0, "OpenFileDialog1");
			this.OpenFileDialog_0.InitialDirectory = "Log";
			this.SaveFileDialog_0.DefaultExt = "log";
			componentResourceManager.ApplyResources(this.SaveFileDialog_0, "SaveFileDialog1");
			this.SaveFileDialog_0.InitialDirectory = "Log";
			this.lbResult.BackColor = global::System.Drawing.Color.Red;
			componentResourceManager.ApplyResources(this.lbResult, "lbResult");
			this.lbResult.ForeColor = global::System.Drawing.Color.White;
			this.lbResult.Name = "lbResult";
			this.tsFormatMenu.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsFormatMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripLabel1,
				this.tbPinFormat1,
				this.tbPinFormat2,
				this.tsbCalculate
			});
			componentResourceManager.ApplyResources(this.tsFormatMenu, "tsFormatMenu");
			this.tsFormatMenu.Name = "tsFormatMenu";
			this.ToolStripLabel1.Name = "ToolStripLabel1";
			componentResourceManager.ApplyResources(this.ToolStripLabel1, "ToolStripLabel1");
			componentResourceManager.ApplyResources(this.tbPinFormat1, "tbPinFormat1");
			this.tbPinFormat1.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.tbPinFormat1.Name = "tbPinFormat1";
			this.tbPinFormat1.Tag = "";
			componentResourceManager.ApplyResources(this.tbPinFormat2, "tbPinFormat2");
			this.tbPinFormat2.ForeColor = global::System.Drawing.Color.DarkGreen;
			this.tbPinFormat2.Name = "tbPinFormat2";
			this.tsbCalculate.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbCalculate.Image = global::GClass0.Bitmap_9;
			componentResourceManager.ApplyResources(this.tsbCalculate, "tsbCalculate");
			this.tsbCalculate.Name = "tsbCalculate";
			this.ProgressBar1.Color_0 = global::System.Drawing.Color.Red;
			componentResourceManager.ApplyResources(this.ProgressBar1, "ProgressBar1");
			this.ProgressBar1.ForeColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Style = global::System.Windows.Forms.ProgressBarStyle.Continuous;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.lbResult);
			base.Controls.Add(this.DgvInfo);
			base.Controls.Add(this.ProgressBar1);
			base.Controls.Add(this.tsFormatMenu);
			base.Controls.Add(this.ToolStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RandomPinForm";
			base.ShowIcon = false;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DgvInfo).EndInit();
			this.tsFormatMenu.ResumeLayout(false);
			this.tsFormatMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000177 RID: 375
		private global::System.ComponentModel.IContainer icontainer_0;
	}
}
