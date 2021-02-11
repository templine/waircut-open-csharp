namespace wAirCut
{
	// Token: 0x0200003C RID: 60
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WaitSplashProcess : global::System.Windows.Forms.Form
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x000186A8 File Offset: 0x000168A8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btStop = new global::System.Windows.Forms.Button();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.ScrollLabel1 = new global::GClass14();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.btStop.BackgroundImage = global::GClass0.Bitmap_52;
			this.btStop.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.btStop.Location = new global::System.Drawing.Point(111, 12);
			this.btStop.Name = "btStop";
			this.btStop.Size = new global::System.Drawing.Size(40, 40);
			this.btStop.TabIndex = 0;
			this.btStop.UseVisualStyleBackColor = true;
			this.PictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox1.Image = global::GClass0.Bitmap_35;
			this.PictureBox1.InitialImage = null;
			this.PictureBox1.Location = new global::System.Drawing.Point(12, 6);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(69, 50);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.ScrollLabel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ScrollLabel1.ForeColor = global::System.Drawing.Color.Silver;
			this.ScrollLabel1.Int32_0 = 20;
			this.ScrollLabel1.Location = new global::System.Drawing.Point(0, 50);
			this.ScrollLabel1.Name = "ScrollLabel1";
			this.ScrollLabel1.GEnum7_0 = global::GClass14.GEnum7.horizontal;
			this.ScrollLabel1.Size = new global::System.Drawing.Size(163, 13);
			this.ScrollLabel1.TabIndex = 2;
			this.ScrollLabel1.Text = "Waiting for completion...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(163, 63);
			base.Controls.Add(this.ScrollLabel1);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.btStop);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "WaitSplashProcess";
			base.Opacity = 0.9;
			this.Text = "WaitSplashProcess";
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
		}
	}
}
