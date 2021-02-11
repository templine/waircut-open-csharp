namespace wAirCut
{
	// Token: 0x02000038 RID: 56
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StringListEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x060003CA RID: 970 RVA: 0x00017170 File Offset: 0x00015370
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.StringListEditor));
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.ToolStrip1 = new global::System.Windows.Forms.ToolStrip();
			this.tsbAcept = new global::System.Windows.Forms.ToolStripButton();
			this.tsbCancel = new global::System.Windows.Forms.ToolStripButton();
			this.ToolStrip1.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.TextBox1, "TextBox1");
			this.TextBox1.Name = "TextBox1";
			componentResourceManager.ApplyResources(this.ToolStrip1, "ToolStrip1");
			this.ToolStrip1.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip1.ImageScalingSize = new global::System.Drawing.Size(32, 32);
			this.ToolStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.tsbAcept,
				this.tsbCancel
			});
			this.ToolStrip1.Name = "ToolStrip1";
			componentResourceManager.ApplyResources(this.tsbAcept, "tsbAcept");
			this.tsbAcept.Image = global::GClass0.Bitmap_1;
			this.tsbAcept.Name = "tsbAcept";
			componentResourceManager.ApplyResources(this.tsbCancel, "tsbCancel");
			this.tsbCancel.Alignment = global::System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbCancel.Image = global::GClass0.Bitmap_13;
			this.tsbCancel.Name = "tsbCancel";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.ToolStrip1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "StringListEditor";
			base.ShowIcon = false;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
