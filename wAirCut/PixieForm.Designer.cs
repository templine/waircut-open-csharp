namespace wAirCut
{
	// Token: 0x0200002C RID: 44
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PixieForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000317 RID: 791 RVA: 0x00012C1C File Offset: 0x00010E1C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.PixieForm));
			this.cbMode = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dtpStart = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.dtpEnd = new global::System.Windows.Forms.DateTimePicker();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cbxForce = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cbxRNonce = new global::System.Windows.Forms.CheckBox();
			this.cbxEBssid = new global::System.Windows.Forms.CheckBox();
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.btExcute = new global::System.Windows.Forms.ToolStripButton();
			this.btRetry = new global::System.Windows.Forms.ToolStripButton();
			this.btStop = new global::System.Windows.Forms.ToolStripButton();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cbxLength = new global::System.Windows.Forms.CheckBox();
			this.ToolStrip1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.cbMode.FormattingEnabled = true;
			this.cbMode.Items.AddRange(new object[]
			{
				componentResourceManager.GetString("cbMode.Items"),
				componentResourceManager.GetString("cbMode.Items1"),
				componentResourceManager.GetString("cbMode.Items2"),
				componentResourceManager.GetString("cbMode.Items3"),
				componentResourceManager.GetString("cbMode.Items4"),
				componentResourceManager.GetString("cbMode.Items5")
			});
			componentResourceManager.ApplyResources(this.cbMode, "cbMode");
			this.cbMode.Name = "cbMode";
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			componentResourceManager.ApplyResources(this.dtpStart, "dtpStart");
			this.dtpStart.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpStart.Name = "dtpStart";
			this.dtpStart.ShowUpDown = true;
			componentResourceManager.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			componentResourceManager.ApplyResources(this.dtpEnd, "dtpEnd");
			this.dtpEnd.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEnd.Name = "dtpEnd";
			this.dtpEnd.ShowUpDown = true;
			componentResourceManager.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			componentResourceManager.ApplyResources(this.cbxForce, "cbxForce");
			this.cbxForce.Name = "cbxForce";
			this.cbxForce.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			componentResourceManager.ApplyResources(this.cbxRNonce, "cbxRNonce");
			this.cbxRNonce.Name = "cbxRNonce";
			this.cbxRNonce.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.cbxEBssid, "cbxEBssid");
			this.cbxEBssid.Name = "cbxEBssid";
			this.cbxEBssid.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.ToolStrip1, "ToolStrip1");
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.btExcute,
				this.btRetry,
				this.btStop
			});
			this.ToolStrip1.Name = "ToolStrip1";
			this.btExcute.Image = global::GClass0.Bitmap_56;
			componentResourceManager.ApplyResources(this.btExcute, "btExcute");
			this.btExcute.Name = "btExcute";
			componentResourceManager.ApplyResources(this.btRetry, "btRetry");
			this.btRetry.Image = global::GClass0.Bitmap_40;
			this.btRetry.Name = "btRetry";
			this.btStop.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			componentResourceManager.ApplyResources(this.btStop, "btStop");
			this.btStop.Image = global::GClass0.Bitmap_51;
			this.btStop.Name = "btStop";
			this.Panel1.BackColor = global::System.Drawing.SystemColors.GradientInactiveCaption;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.Label5);
			componentResourceManager.ApplyResources(this.Panel1, "Panel1");
			this.Panel1.Name = "Panel1";
			this.PictureBox1.Image = global::GClass0.Bitmap_57;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			componentResourceManager.ApplyResources(this.cbxLength, "cbxLength");
			this.cbxLength.Name = "cbxLength";
			this.cbxLength.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.cbxLength);
			base.Controls.Add(this.ToolStrip1);
			base.Controls.Add(this.cbxEBssid);
			base.Controls.Add(this.cbxRNonce);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.cbxForce);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.dtpEnd);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.dtpStart);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.cbMode);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PixieForm";
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
