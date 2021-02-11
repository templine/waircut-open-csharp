using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x02000034 RID: 52
public class GClass14 : Label
{
	// Token: 0x17000180 RID: 384
	// (get) Token: 0x060003AE RID: 942 RVA: 0x000045DA File Offset: 0x000027DA
	// (set) Token: 0x060003AF RID: 943 RVA: 0x00016918 File Offset: 0x00014B18
	private virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return this.timer_0;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			EventHandler value2 = new EventHandler(this.method_2);
			Timer timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick -= value2;
			}
			this.timer_0 = value;
			timer = this.timer_0;
			if (timer != null)
			{
				timer.Tick += value2;
			}
		}
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x0001695C File Offset: 0x00014B5C
	public GClass14()
	{
		this.Timer_0 = new Timer();
		this.int_0 = base.Width;
		checked
		{
			this.int_1 = (int)Math.Round((double)(unchecked((float)base.Height - this.sizeF_0.Height) / 2f));
			this.list_0 = new List<string>();
			this.DoubleBuffered = true;
			this.int_0 = base.Width;
			this.Timer_0.Interval = 200;
			this.Timer_0.Start();
			if (this.GEnum7_0 == GClass14.GEnum7.vertical)
			{
				this.int_1 = (int)Math.Round((double)base.Height / 2.0);
			}
		}
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00016A10 File Offset: 0x00014C10
	protected virtual void OnPaint(PaintEventArgs e)
	{
		this.method_0();
		using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
		{
			GClass14.GEnum7 genum = this.genum7_0;
			if (genum != GClass14.GEnum7.horizontal)
			{
				if (genum != GClass14.GEnum7.vertical)
				{
					return;
				}
				this.sizeF_0 = e.Graphics.MeasureString(this.Text, this.Font);
				int num = this.int_1;
				try
				{
					List<string>.Enumerator enumerator = this.list_0.GetEnumerator();
					IL_275:
					while (enumerator.MoveNext())
					{
						string text;
						for (;;)
						{
							IL_153:
							text = enumerator.Current;
							for (;;)
							{
								IL_143:
								ContentAlignment textAlign = this.TextAlign;
								if (textAlign > ContentAlignment.MiddleCenter)
								{
									goto Block_12;
								}
								for (;;)
								{
									IL_125:
									switch (textAlign)
									{
									case ContentAlignment.TopLeft:
										goto IL_192;
									case ContentAlignment.TopCenter:
										goto IL_1A9;
									case (ContentAlignment)3:
										goto IL_224;
									case ContentAlignment.TopRight:
										goto IL_1E2;
									default:
									{
										uint num3;
										uint num2 = num3 * 3534347052U ^ 3729251263U;
										for (;;)
										{
											switch ((num3 = (num2 ^ 2784004114U)) % 22U)
											{
											case 0U:
												goto IL_1A9;
											case 1U:
												num2 = (((textAlign == ContentAlignment.MiddleLeft) ? 3795029050U : 2683898963U) ^ num3 * 3972945967U);
												continue;
											case 2U:
											case 13U:
											case 18U:
												goto IL_275;
											case 3U:
												goto IL_192;
											case 4U:
												goto IL_125;
											case 5U:
											case 9U:
											case 12U:
												goto IL_224;
											case 6U:
												goto IL_167;
											case 7U:
												goto IL_242;
											case 8U:
												num2 = (num3 * 2137640444U ^ 513112017U);
												continue;
											case 10U:
												num2 = (((textAlign == ContentAlignment.MiddleCenter) ? 2211913550U : 2576379918U) ^ num3 * 1822409120U);
												continue;
											case 11U:
												goto IL_1E2;
											case 14U:
												goto IL_184;
											case 15U:
												goto IL_170;
											case 16U:
												goto IL_143;
											case 19U:
												goto IL_15E;
											case 20U:
												goto IL_153;
											case 21U:
												goto IL_17E;
											}
											goto Block_10;
										}
										break;
									}
									}
								}
							}
						}
						IL_242:
						checked
						{
							num = (int)Math.Round(unchecked((double)num + (double)e.Graphics.MeasureString(text, this.Font).Height * 1.3));
							continue;
							IL_224:
							e.Graphics.DrawString(text, this.Font, solidBrush, (float)this.int_0, (float)num);
							goto IL_242;
							Block_10:
							break;
							IL_170:
							ContentAlignment textAlign;
							if (textAlign != ContentAlignment.BottomRight)
							{
								goto IL_224;
							}
							goto IL_1E2;
							IL_167:
							if (textAlign != ContentAlignment.BottomCenter)
							{
								goto IL_170;
							}
							goto IL_1A9;
							IL_15E:
							if (textAlign > ContentAlignment.BottomLeft)
							{
								goto IL_167;
							}
							goto IL_17E;
							Block_12:
							goto IL_15E;
							IL_184:
							if (textAlign != ContentAlignment.BottomLeft)
							{
								goto IL_224;
							}
							goto IL_192;
							IL_17E:
							if (textAlign != ContentAlignment.MiddleRight)
							{
								goto IL_184;
							}
							goto IL_1E2;
							IL_192:
							this.int_0 = base.Margin.Left;
							goto IL_224;
							IL_1A9:
							this.int_0 = (int)Math.Round((double)(unchecked((float)base.Width - e.Graphics.MeasureString(text, this.Font).Width) / 2f));
							goto IL_224;
							IL_1E2:
							this.int_0 = (int)Math.Round((double)(unchecked((float)base.Width - e.Graphics.MeasureString(text, this.Font).Width - (float)base.Margin.Right)));
							goto IL_224;
						}
					}
					return;
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
			string text2 = "";
			try
			{
				foreach (string str in this.list_0)
				{
					text2 = text2 + str + " ";
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			this.sizeF_0 = e.Graphics.MeasureString(text2, this.Font);
			e.Graphics.DrawString(text2, this.Font, solidBrush, (float)this.int_0, (float)this.int_1);
		}
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00016D88 File Offset: 0x00014F88
	private void method_0()
	{
		string text = "";
		char[] separator = new char[]
		{
			' ',
			'\r'
		};
		string[] array = this.Text.Split(separator);
		Graphics graphics = base.CreateGraphics();
		this.list_0.Clear();
		foreach (string text2 in array)
		{
			if (graphics.MeasureString(text + text2, this.Font).Width < (float)base.Width & !text2.Contains("\n") & !text2.Contains("\r") & !text2.Contains("\r\n"))
			{
				text = text + text2 + " ";
			}
			else
			{
				this.list_0.Add(text);
				text2 = text2.Replace("\n", "");
				text2 = text2.Replace("\r", "");
				text2 = text2.Replace("\r\n", "");
				text = text2 + " ";
			}
		}
		if (Operators.CompareString(text, "", false) != 0)
		{
			this.list_0.Add(text);
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00016EC0 File Offset: 0x000150C0
	private void method_1()
	{
		this.Timer_0.Stop();
		GClass14.GEnum7 genum = this.genum7_0;
		if (genum != GClass14.GEnum7.horizontal)
		{
			if (genum == GClass14.GEnum7.vertical)
			{
				this.int_0 = 0;
				if ((double)this.int_1 >= -((double)(checked((this.list_0.Count + 1) * this.Font.Height)) * 1.3))
				{
					ref int ptr = ref this.int_1;
					this.int_1 = checked(ptr - 1);
				}
				else
				{
					this.int_1 = base.Height;
				}
			}
		}
		else
		{
			this.int_1 = checked((int)Math.Round((double)(base.Height - this.Font.Height) / 2.0));
			if ((float)this.int_0 < -this.sizeF_0.Width)
			{
				this.int_0 = base.Width;
			}
			else
			{
				ref int ptr = ref this.int_0;
				this.int_0 = checked(ptr - 1);
			}
		}
		base.Invalidate();
		this.Timer_0.Start();
	}

	// Token: 0x17000181 RID: 385
	// (get) Token: 0x060003B4 RID: 948 RVA: 0x000045E2 File Offset: 0x000027E2
	// (set) Token: 0x060003B5 RID: 949 RVA: 0x000045EF File Offset: 0x000027EF
	[Browsable(true)]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Category("Behavior")]
	public int Int32_0
	{
		get
		{
			return this.Timer_0.Interval;
		}
		set
		{
			this.Timer_0.Interval = value;
		}
	}

	// Token: 0x17000182 RID: 386
	// (get) Token: 0x060003B6 RID: 950 RVA: 0x000045FD File Offset: 0x000027FD
	// (set) Token: 0x060003B7 RID: 951 RVA: 0x00004605 File Offset: 0x00002805
	[Category("Appearance")]
	[EditorBrowsable(EditorBrowsableState.Always)]
	[Browsable(true)]
	public GClass14.GEnum7 GEnum7_0
	{
		get
		{
			return this.genum7_0;
		}
		set
		{
			this.genum7_0 = value;
		}
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x0000460E File Offset: 0x0000280E
	[CompilerGenerated]
	private void method_2(object sender, EventArgs e)
	{
		this.method_1();
	}

	// Token: 0x040001B4 RID: 436
	[CompilerGenerated]
	[AccessedThroughProperty("tick")]
	private Timer timer_0;

	// Token: 0x040001B5 RID: 437
	private int int_0;

	// Token: 0x040001B6 RID: 438
	private int int_1;

	// Token: 0x040001B7 RID: 439
	private SizeF sizeF_0;

	// Token: 0x040001B8 RID: 440
	private List<string> list_0;

	// Token: 0x040001B9 RID: 441
	private GClass14.GEnum7 genum7_0;

	// Token: 0x02000035 RID: 53
	public enum GEnum7
	{
		// Token: 0x040001BB RID: 443
		horizontal,
		// Token: 0x040001BC RID: 444
		vertical
	}
}
