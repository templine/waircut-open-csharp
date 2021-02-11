using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;

// Token: 0x0200002E RID: 46
internal class Class12 : ProgressBar
{
	// Token: 0x0600034C RID: 844 RVA: 0x000043AB File Offset: 0x000025AB
	public Class12()
	{
		base.SetStyle(ControlStyles.UserPaint, true);
		base.Style = ProgressBarStyle.Continuous;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00003A31 File Offset: 0x00001C31
	protected virtual void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00013CEC File Offset: 0x00011EEC
	protected virtual void OnPaint(PaintEventArgs e)
	{
		using (Image image = new Bitmap(base.Width, base.Height))
		{
			using (Graphics graphics = Graphics.FromImage(image))
			{
				Rectangle rectangle = new Rectangle(0, 0, base.Width, base.Height);
				if (ProgressBarRenderer.IsSupported)
				{
					ProgressBarRenderer.DrawHorizontalBar(graphics, rectangle);
				}
				rectangle.Inflate(new Size(-2, -2));
				rectangle.Width = checked((int)Math.Round(unchecked((double)rectangle.Width * ((double)base.Value / (double)base.Maximum))));
				if (rectangle.Width == 0)
				{
					rectangle.Width = 1;
				}
				LinearGradientBrush brush = new LinearGradientBrush(rectangle, this.BackColor, this.color_0, LinearGradientMode.Vertical);
				graphics.FillRectangle(brush, 2, 2, rectangle.Width, rectangle.Height);
				e.Graphics.DrawImage(image, 0, 0);
				image.Dispose();
			}
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x0600034F RID: 847 RVA: 0x00013DEC File Offset: 0x00011FEC
	protected virtual CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				if (Environment.OSVersion.Version.Major >= 6)
				{
					createParams.ExStyle |= 33554432;
				}
			}
			return createParams;
		}
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00013E34 File Offset: 0x00012034
	protected virtual void WndProc(ref Message m)
	{
		base.WndProc(ref m);
		if (m.Msg == 15)
		{
			string text = Strings.FormatNumber((double)(checked(base.Value * 100)) / (double)base.Maximum, 2, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault) + "%";
			using (Graphics graphics = base.CreateGraphics())
			{
				using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
				{
					SizeF sizeF = graphics.MeasureString(text, this.System.Windows.Forms.ProgressBar.Font);
					graphics.DrawString(text, this.System.Windows.Forms.ProgressBar.Font, solidBrush, ((float)base.Width - sizeF.Width) / 2f, ((float)base.Height - sizeF.Height) / 2f);
				}
			}
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000351 RID: 849 RVA: 0x000043C2 File Offset: 0x000025C2
	// (set) Token: 0x06000352 RID: 850 RVA: 0x000043CA File Offset: 0x000025CA
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public virtual string Text
	{
		get
		{
			return base.Text;
		}
		set
		{
			base.Text = value;
			this.Refresh();
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000353 RID: 851 RVA: 0x000043D9 File Offset: 0x000025D9
	// (set) Token: 0x06000354 RID: 852 RVA: 0x000043E1 File Offset: 0x000025E1
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public virtual Font Font
	{
		get
		{
			return base.Font;
		}
		set
		{
			base.Font = value;
			this.Refresh();
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000355 RID: 853 RVA: 0x000043F0 File Offset: 0x000025F0
	// (set) Token: 0x06000356 RID: 854 RVA: 0x000043F8 File Offset: 0x000025F8
	[Browsable(true)]
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	public Color Color_0
	{
		get
		{
			return this.color_0;
		}
		set
		{
			this.color_0 = value;
			this.Refresh();
		}
	}

	// Token: 0x04000172 RID: 370
	private Color color_0;
}
