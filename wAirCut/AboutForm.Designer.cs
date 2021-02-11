namespace wAirCut
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AboutForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::wAirCut.AboutForm));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.lbVersion = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.btDonate = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.ScrollLabel1 = new global::GClass14();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.StatusStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			componentResourceManager.ApplyResources(this.Label1, "Label1");
			this.Label1.ForeColor = global::System.Drawing.Color.DarkBlue;
			this.Label1.Name = "Label1";
			componentResourceManager.ApplyResources(this.StatusStrip1, "StatusStrip1");
			this.StatusStrip1.BackColor = global::System.Drawing.Color.White;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.lbVersion
			});
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.SizingGrip = false;
			componentResourceManager.ApplyResources(this.lbVersion, "lbVersion");
			this.lbVersion.Name = "lbVersion";
			componentResourceManager.ApplyResources(this.PictureBox2, "PictureBox2");
			this.PictureBox2.BackColor = global::System.Drawing.Color.White;
			this.PictureBox2.Image = global::GClass0.Bitmap_7;
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.TabStop = false;
			componentResourceManager.ApplyResources(this.btDonate, "btDonate");
			this.btDonate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btDonate.Image = global::GClass0.Bitmap_43;
			this.btDonate.Name = "btDonate";
			this.btDonate.UseVisualStyleBackColor = true;
			componentResourceManager.ApplyResources(this.PictureBox1, "PictureBox1");
			this.PictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.PictureBox1.Image = global::GClass0.Bitmap_54;
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.TabStop = false;
			componentResourceManager.ApplyResources(this.ScrollLabel1, "ScrollLabel1");
			this.ScrollLabel1.Int32_0 = 60;
			this.ScrollLabel1.Name = "ScrollLabel1";
			this.ScrollLabel1.GEnum7_0 = global::GClass14.GEnum7.vertical;
			componentResourceManager.ApplyResources(this.Panel1, "Panel1");
			this.Panel1.BackColor = global::System.Drawing.SystemColors.Window;
			this.Panel1.Controls.Add(this.PictureBox1);
			this.Panel1.Controls.Add(this.btDonate);
			this.Panel1.Name = "Panel1";
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.ScrollLabel1);
			base.Controls.Add(this.PictureBox2);
			base.Controls.Add(this.StatusStrip1);
			base.Controls.Add(this.Label1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutForm";
			base.ShowIcon = false;
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
