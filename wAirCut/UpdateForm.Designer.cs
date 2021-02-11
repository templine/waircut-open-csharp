namespace wAirCut
{
	// Token: 0x02000039 RID: 57
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class UpdateForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00017480 File Offset: 0x00015680
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.UpdateForm));
			this.lbTitle = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lbVersion = new global::System.Windows.Forms.Label();
			this.lbLastVersion = new global::System.Windows.Forms.Label();
			this.btDonate = new global::System.Windows.Forms.Button();
			this.btDownload = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.ScrollLabel1 = new global::GClass14();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.lbTitle, "lbTitle");
			this.lbTitle.ForeColor = global::System.Drawing.Color.ForestGreen;
			this.lbTitle.Name = "lbTitle";
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			componentResourceManager.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			componentResourceManager.ApplyResources(this.lbVersion, "lbVersion");
			this.lbVersion.ForeColor = global::System.Drawing.Color.Red;
			this.lbVersion.Name = "lbVersion";
			componentResourceManager.ApplyResources(this.lbLastVersion, "lbLastVersion");
			this.lbLastVersion.ForeColor = global::System.Drawing.Color.Green;
			this.lbLastVersion.Name = "lbLastVersion";
			componentResourceManager.ApplyResources(this.btDonate, "btDonate");
			this.btDonate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btDonate.Image = global::GClass0.Bitmap_43;
			this.btDonate.Name = "btDonate";
			this.btDonate.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.btDownload, "btDownload");
			this.btDownload.Image = global::GClass0.Bitmap_14;
			this.btDownload.Name = "btDownload";
			this.btDownload.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.Image = global::GClass0.Bitmap_54;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.Panel2, "Panel2");
			this.Panel2.BackColor = global::System.Drawing.SystemColors.Window;
			this.Panel2.Controls.Add(this.btDonate);
			this.Panel2.Controls.Add(this.PictureBox1);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.lbLastVersion);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.lbVersion);
			this.Panel2.Name = "Panel2";
			componentResourceManager.ApplyResources(this.ScrollLabel1, "ScrollLabel1");
			this.ScrollLabel1.Int32_0 = 60;
			this.ScrollLabel1.Name = "ScrollLabel1";
			this.ScrollLabel1.GEnum7_0 = global::GClass14.GEnum7.vertical;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ScrollLabel1);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.btDownload);
			base.Controls.Add(this.lbTitle);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdateForm";
			base.ShowIcon = false;
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
