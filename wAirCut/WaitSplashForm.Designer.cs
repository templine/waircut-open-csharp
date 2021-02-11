namespace wAirCut
{
	// Token: 0x0200003B RID: 59
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WaitSplashForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x0001834C File Offset: 0x0001654C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.ProgressBar = new global::System.Windows.Forms.ProgressBar();
			this.lbMessage = new global::System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.lbMessage);
			this.Panel1.Controls.Add(this.ProgressBar);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(161, 42);
			this.Panel1.TabIndex = 2;
			this.ProgressBar.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ProgressBar.Location = new global::System.Drawing.Point(0, 23);
			this.ProgressBar.Name = "ProgressBar";
			this.ProgressBar.Size = new global::System.Drawing.Size(159, 17);
			this.ProgressBar.TabIndex = 2;
			this.lbMessage.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lbMessage.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lbMessage.Location = new global::System.Drawing.Point(0, 0);
			this.lbMessage.Name = "lbMessage";
			this.lbMessage.Size = new global::System.Drawing.Size(159, 23);
			this.lbMessage.TabIndex = 3;
			this.lbMessage.Text = "message";
			this.lbMessage.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(161, 42);
			base.Controls.Add(this.Panel1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "WaitSplashForm";
			base.Opacity = 0.9;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WaitSplashForm";
			base.TopMost = true;
			this.Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
	}
}
