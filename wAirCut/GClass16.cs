using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// Token: 0x02000037 RID: 55
public class GClass16<T> : Comparer<T>
{
	// Token: 0x060003C1 RID: 961 RVA: 0x00004649 File Offset: 0x00002849
	public GClass16(PropertyDescriptor propertyDescriptor_1, ListSortDirection listSortDirection_1)
	{
		this.propertyDescriptor_0 = propertyDescriptor_1;
		this.listSortDirection_0 = listSortDirection_1;
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00017070 File Offset: 0x00015270
	public virtual int Compare(T x, T y)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(this.method_4(x, this.propertyDescriptor_0.Name));
		object objectValue2 = RuntimeHelpers.GetObjectValue(this.method_4(y, this.propertyDescriptor_0.Name));
		int result;
		if (this.listSortDirection_0 == ListSortDirection.Ascending)
		{
			result = this.method_2(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2));
		}
		else
		{
			result = this.method_3(RuntimeHelpers.GetObjectValue(objectValue), RuntimeHelpers.GetObjectValue(objectValue2));
		}
		return result;
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x0000465F File Offset: 0x0000285F
	public bool method_0(T gparam_0, T gparam_1)
	{
		return gparam_0.Equals(gparam_1);
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00004674 File Offset: 0x00002874
	public int method_1(T gparam_0)
	{
		return gparam_0.GetHashCode();
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x000170E0 File Offset: 0x000152E0
	private int method_2(object object_0, object object_1)
	{
		int result;
		if (object_0 is IComparable)
		{
			result = ((IComparable)object_0).CompareTo(RuntimeHelpers.GetObjectValue(object_1));
		}
		else if (!object_0.Equals(RuntimeHelpers.GetObjectValue(object_1)))
		{
			result = object_0.ToString().CompareTo(object_1.ToString());
		}
		else
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00004683 File Offset: 0x00002883
	private int method_3(object object_0, object object_1)
	{
		return checked(this.method_2(RuntimeHelpers.GetObjectValue(object_0), RuntimeHelpers.GetObjectValue(object_1)) * -1);
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00004699 File Offset: 0x00002899
	private object method_4(T gparam_0, string string_0)
	{
		return gparam_0.GetType().GetProperty(string_0).GetValue(gparam_0, null);
	}

	// Token: 0x040001C0 RID: 448
	private PropertyDescriptor propertyDescriptor_0;

	// Token: 0x040001C1 RID: 449
	private ListSortDirection listSortDirection_0;
}
