using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Token: 0x0200002F RID: 47
public class GClass13
{
	// Token: 0x06000357 RID: 855 RVA: 0x00004407 File Offset: 0x00002607
	public GClass13()
	{
		this.random_0 = new Random();
		this.list_0 = new List<string>();
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00013F10 File Offset: 0x00012110
	public object method_0(bool bool_0)
	{
		object result;
		if (bool_0)
		{
			result = 11000;
		}
		else
		{
			result = 20000;
		}
		return result;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00013F3C File Offset: 0x0001213C
	private void method_1(bool bool_0)
	{
		checked
		{
			if (bool_0)
			{
				int num = 0;
				do
				{
					int num2 = num * 1000 + this.random_0.Next(0, 999);
					num2 = num2 * 10 + GClass3.smethod_0(num2);
					this.list_0.Add(num2.ToString("00000000"));
					num++;
				}
				while (num <= 9999);
				return;
			}
			int num3 = 0;
			do
			{
				this.list_0.Add((num3 * 10000 + this.random_0.Next(0, 9999)).ToString("00000000"));
				num3++;
			}
			while (num3 <= 9999);
		}
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00013FE0 File Offset: 0x000121E0
	private void method_2(string string_0, bool bool_0)
	{
		checked
		{
			if (bool_0)
			{
				int num = 0;
				do
				{
					int num2 = (int)Math.Round(unchecked(Conversions.ToDouble(string_0) * 1000.0 + (double)num));
					num2 = num2 * 10 + GClass3.smethod_0(Conversions.ToInteger(num2.ToString("0000000")));
					this.list_0.Add(Conversions.ToString(num2));
					num++;
				}
				while (num <= 999);
				return;
			}
			int num3 = 0;
			do
			{
				this.list_0.Add((unchecked(Conversions.ToDouble(string_0) * 10000.0 + (double)num3)).ToString("00000000"));
				num3++;
			}
			while (num3 <= 9999);
		}
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00014088 File Offset: 0x00012288
	public List<string> method_3(bool bool_0)
	{
		List<string> list = new List<string>();
		this.method_1(bool_0);
		checked
		{
			int num = this.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int index = this.random_0.Next(0, this.list_0.Count - 1);
				list.Add(this.list_0[index]);
				this.list_0.RemoveAt(index);
			}
			return list;
		}
	}

	// Token: 0x0600035C RID: 860 RVA: 0x000140F8 File Offset: 0x000122F8
	public List<string> method_4(string string_0, string string_1)
	{
		string text = string_0 + string_1;
		bool bool_ = Operators.CompareString(Conversions.ToString(text.Last<char>()), "C", false) == 0;
		List<string> list = new List<string>();
		if (string_0.Contains("?") | string_0.Contains("["))
		{
			this.method_1(bool_);
		}
		else
		{
			this.method_2(Conversions.ToString(Conversions.ToUInteger(string_0)), bool_);
		}
		text = text.Replace("C", "?");
		checked
		{
			int num = this.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int index = this.random_0.Next(0, this.list_0.Count - 1);
				if (LikeOperator.LikeString(this.list_0[index], text, CompareMethod.Binary))
				{
					list.Add(this.list_0[index]);
				}
				this.list_0.RemoveAt(index);
			}
			return list;
		}
	}

	// Token: 0x0600035D RID: 861 RVA: 0x000141E4 File Offset: 0x000123E4
	public List<string> method_5(int int_2, bool bool_0)
	{
		List<string> list = new List<string>();
		this.method_2(Conversions.ToString(int_2), bool_0);
		checked
		{
			int num = this.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				int index = this.random_0.Next(0, this.list_0.Count - 1);
				list.Add(this.list_0[index]);
				this.list_0.RemoveAt(index);
			}
			return list;
		}
	}

	// Token: 0x04000173 RID: 371
	private const int int_0 = 10000;

	// Token: 0x04000174 RID: 372
	private const int int_1 = 1000;

	// Token: 0x04000175 RID: 373
	private Random random_0;

	// Token: 0x04000176 RID: 374
	private List<string> list_0;
}
