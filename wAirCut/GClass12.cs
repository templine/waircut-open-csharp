using System;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200002A RID: 42
public class GClass12
{
	// Token: 0x0600030A RID: 778 RVA: 0x00004209 File Offset: 0x00002409
	public GClass12()
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000128C8 File Offset: 0x00010AC8
	public GClass12(string string_1, GClass12.GEnum5 genum5_0)
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
		this.string_0 = string_1;
		this.Type = genum5_0;
	}

	// Token: 0x0600030C RID: 780 RVA: 0x00012918 File Offset: 0x00010B18
	public GClass12(GClass12.GEnum5 genum5_0, GClass11 gclass11_1)
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
		this.Type = genum5_0;
		this.gclass11_0 = gclass11_1;
	}

	// Token: 0x0600030D RID: 781 RVA: 0x00012968 File Offset: 0x00010B68
	public GClass12(string string_1, GClass12.GEnum5 genum5_0, GClass11 gclass11_1)
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
		this.string_0 = string_1;
		this.Type = genum5_0;
		this.gclass11_0 = gclass11_1;
	}

	// Token: 0x0600030E RID: 782 RVA: 0x000129C0 File Offset: 0x00010BC0
	public GClass12(string string_1, GClass3.GEnum0 genum0_1)
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
		this.string_0 = string_1;
		this.Type = GClass12.GEnum5.Algorithm;
		this.genum0_0 = genum0_1;
	}

	// Token: 0x0600030F RID: 783 RVA: 0x00012A18 File Offset: 0x00010C18
	public GClass12(string string_1, GClass3.GEnum0 genum0_1, GClass11 gclass11_1)
	{
		this.Type = GClass12.GEnum5.Manual;
		this._description = "";
		this.string_0 = "";
		this.genum0_0 = GClass3.GEnum0.Nothing;
		this.gclass11_0 = new GClass11();
		this.string_0 = string_1;
		this.Type = GClass12.GEnum5.Algorithm;
		this.genum0_0 = genum0_1;
		this.gclass11_0 = gclass11_1;
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000310 RID: 784 RVA: 0x00012A78 File Offset: 0x00010C78
	// (set) Token: 0x06000311 RID: 785 RVA: 0x00004240 File Offset: 0x00002440
	public string Description
	{
		get
		{
			this._description = this.Type.ToString();
			if (Operators.CompareString(this.gclass11_0.string_1, "", false) != 0)
			{
				ref string ptr = ref this._description;
				this._description = ptr + " | " + this.gclass11_0.string_1;
			}
			if (Operators.CompareString(this.gclass11_0.string_2, "", false) != 0 && Operators.CompareString(this._description, "", false) != 0)
			{
				ref string ptr = ref this._description;
				this._description = ptr + " | " + this.gclass11_0.string_2;
			}
			if (this.genum0_0 != GClass3.GEnum0.Nothing)
			{
				if (Operators.CompareString(this._description, "", false) != 0)
				{
					ref string ptr = ref this._description;
					this._description = ptr + " | " + this.genum0_0.ToString();
				}
			}
			if (this.Type == GClass12.GEnum5.PixieDust)
			{
				if (Operators.CompareString(this._description, "", false) != 0)
				{
					ref string ptr = ref this._description;
					this._description = ptr + " | " + GClass12.GEnum5.PixieDust.ToString();
				}
			}
			return this._description;
		}
		set
		{
			this._description = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000312 RID: 786 RVA: 0x00004249 File Offset: 0x00002449
	// (set) Token: 0x06000313 RID: 787 RVA: 0x00004251 File Offset: 0x00002451
	public string Pin
	{
		get
		{
			return this.string_0;
		}
		set
		{
			this.string_0 = value;
		}
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00012BAC File Offset: 0x00010DAC
	public virtual bool Equals(object obj)
	{
		GClass12 gclass = obj as GClass12;
		return gclass != null && gclass.Pin.Equals(this.Pin);
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000425A File Offset: 0x0000245A
	public virtual int GetHashCode()
	{
		return this.Pin.GetHashCode();
	}

	// Token: 0x0400014F RID: 335
	public GClass12.GEnum5 Type;

	// Token: 0x04000150 RID: 336
	private string _description;

	// Token: 0x04000151 RID: 337
	private string string_0;

	// Token: 0x04000152 RID: 338
	public GClass3.GEnum0 genum0_0;

	// Token: 0x04000153 RID: 339
	public GClass11 gclass11_0;

	// Token: 0x0200002B RID: 43
	public enum GEnum5
	{
		// Token: 0x04000155 RID: 341
		Manual,
		// Token: 0x04000156 RID: 342
		Generic,
		// Token: 0x04000157 RID: 343
		Algorithm,
		// Token: 0x04000158 RID: 344
		PixieDust,
		// Token: 0x04000159 RID: 345
		BruteForce,
		// Token: 0x0400015A RID: 346
		PushButton
	}
}
