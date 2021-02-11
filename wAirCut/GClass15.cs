using System;
using System.Collections.Generic;
using System.ComponentModel;

// Token: 0x02000036 RID: 54
public class GClass15<T> : BindingList<T>
{
	// Token: 0x060003B9 RID: 953 RVA: 0x00004616 File Offset: 0x00002816
	public GClass15()
	{
		this.bool_0 = false;
	}

	// Token: 0x17000183 RID: 387
	// (get) Token: 0x060003BA RID: 954 RVA: 0x00004625 File Offset: 0x00002825
	protected virtual bool SupportsSortingCore
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000184 RID: 388
	// (get) Token: 0x060003BB RID: 955 RVA: 0x00004628 File Offset: 0x00002828
	protected virtual bool IsSortedCore
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00004630 File Offset: 0x00002830
	protected virtual void RemoveSortCore()
	{
		this.bool_0 = false;
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00016FA8 File Offset: 0x000151A8
	public void method_0(IEnumerable<T> ienumerable_0)
	{
		try
		{
			foreach (T item in ienumerable_0)
			{
				base.Items.Add(item);
			}
		}
		finally
		{
			IEnumerator<T> enumerator;
			if (enumerator != null)
			{
				enumerator.Dispose();
			}
		}
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00016FF8 File Offset: 0x000151F8
	protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
	{
		List<T> list = base.Items as List<T>;
		try
		{
			if (list != null)
			{
				this.listSortDirection_0 = direction;
				this.propertyDescriptor_0 = prop;
				GClass16<T> comparer = new GClass16<T>(prop, direction);
				list.Sort(comparer);
				this.bool_0 = true;
			}
			else
			{
				this.bool_0 = false;
			}
			this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}
		catch (Exception ex)
		{
		}
	}

	// Token: 0x17000185 RID: 389
	// (get) Token: 0x060003BF RID: 959 RVA: 0x00004639 File Offset: 0x00002839
	protected virtual PropertyDescriptor SortPropertyCore
	{
		get
		{
			return this.propertyDescriptor_0;
		}
	}

	// Token: 0x17000186 RID: 390
	// (get) Token: 0x060003C0 RID: 960 RVA: 0x00004641 File Offset: 0x00002841
	protected virtual ListSortDirection SortDirectionCore
	{
		get
		{
			return this.listSortDirection_0;
		}
	}

	// Token: 0x040001BD RID: 445
	private bool bool_0;

	// Token: 0x040001BE RID: 446
	private ListSortDirection listSortDirection_0;

	// Token: 0x040001BF RID: 447
	private PropertyDescriptor propertyDescriptor_0;
}
