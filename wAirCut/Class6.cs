using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using wAirCut;

// Token: 0x02000004 RID: 4
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class Class6
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000007 RID: 7 RVA: 0x0000215D File Offset: 0x0000035D
	[HelpKeyword("My.Computer")]
	internal static Class5 Class5_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_0.Prop_0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002169 File Offset: 0x00000369
	[HelpKeyword("My.Application")]
	internal static Form0 Form0_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_1.Prop_0;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000009 RID: 9 RVA: 0x00002175 File Offset: 0x00000375
	[HelpKeyword("My.User")]
	internal static User User_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_2.Prop_0;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000A RID: 10 RVA: 0x00002181 File Offset: 0x00000381
	[HelpKeyword("My.Forms")]
	internal static Class6.Class7 Class7_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_3.Prop_0;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600000B RID: 11 RVA: 0x0000218D File Offset: 0x0000038D
	[HelpKeyword("My.WebServices")]
	internal static Class6.Class8 Class8_0
	{
		[DebuggerHidden]
		get
		{
			return Class6.class9_4.Prop_0;
		}
	}

	// Token: 0x04000001 RID: 1
	private static readonly Class6.Class9<Class5> class9_0 = new Class6.Class9<Class5>();

	// Token: 0x04000002 RID: 2
	private static readonly Class6.Class9<Form0> class9_1 = new Class6.Class9<Form0>();

	// Token: 0x04000003 RID: 3
	private static readonly Class6.Class9<User> class9_2 = new Class6.Class9<User>();

	// Token: 0x04000004 RID: 4
	private static Class6.Class9<Class6.Class7> class9_3 = new Class6.Class9<Class6.Class7>();

	// Token: 0x04000005 RID: 5
	private static readonly Class6.Class9<Class6.Class8> class9_4 = new Class6.Class9<Class6.Class8>();

	// Token: 0x02000005 RID: 5
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class Class7
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00004C10 File Offset: 0x00002E10
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : Form, new()
		{
			T result;
			if (gparam_0 != null && !gparam_0.IsDisposed)
			{
				result = gparam_0;
			}
			else
			{
				if (Class6.Class7.hashtable_0 != null)
				{
					if (Class6.Class7.hashtable_0.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					Class6.Class7.hashtable_0 = new Hashtable();
				}
				Class6.Class7.hashtable_0.Add(typeof(T), null);
				try
				{
					result = Activator.CreateInstance<T>();
				}
				catch (TargetInvocationException ex) when (ex.InnerException != null)
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
					{
						ex.InnerException.Message
					}), ex.InnerException);
				}
				finally
				{
					Class6.Class7.hashtable_0.Remove(typeof(T));
				}
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002199 File Offset: 0x00000399
		[DebuggerHidden]
		private void method_0<T>(ref T gparam_0) where T : Form
		{
			gparam_0.Dispose();
			gparam_0 = default(T);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021AE File Offset: 0x000003AE
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class7()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021B6 File Offset: 0x000003B6
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021C4 File Offset: 0x000003C4
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000021CC File Offset: 0x000003CC
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal Type method_1()
		{
			return typeof(Class6.Class7);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021D8 File Offset: 0x000003D8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ToString()
		{
			return base.ToString();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000021E0 File Offset: 0x000003E0
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002276 File Offset: 0x00000476
		public AboutForm AboutForm_0
		{
			get
			{
				this.aboutForm_0 = Class6.Class7.smethod_0<AboutForm>(this.aboutForm_0);
				return this.aboutForm_0;
			}
			set
			{
				if (value != this.aboutForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<AboutForm>(ref this.aboutForm_0);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021F9 File Offset: 0x000003F9
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000229B File Offset: 0x0000049B
		public ApLogForm ApLogForm_0
		{
			get
			{
				this.apLogForm_0 = Class6.Class7.smethod_0<ApLogForm>(this.apLogForm_0);
				return this.apLogForm_0;
			}
			set
			{
				if (value != this.apLogForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<ApLogForm>(ref this.apLogForm_0);
				}
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002212 File Offset: 0x00000412
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000022C2 File Offset: 0x000004C2
		public MainForm MainForm_0
		{
			get
			{
				this.mainForm_0 = Class6.Class7.smethod_0<MainForm>(this.mainForm_0);
				return this.mainForm_0;
			}
			set
			{
				if (value != this.mainForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<MainForm>(ref this.mainForm_0);
				}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000222B File Offset: 0x0000042B
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000022E9 File Offset: 0x000004E9
		public StringListEditor StringListEditor_0
		{
			get
			{
				this.stringListEditor_0 = Class6.Class7.smethod_0<StringListEditor>(this.stringListEditor_0);
				return this.stringListEditor_0;
			}
			set
			{
				if (value != this.stringListEditor_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<StringListEditor>(ref this.stringListEditor_0);
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002244 File Offset: 0x00000444
		// (set) Token: 0x0600001D RID: 29 RVA: 0x0000230E File Offset: 0x0000050E
		public UpdateForm UpdateForm_0
		{
			get
			{
				this.updateForm_0 = Class6.Class7.smethod_0<UpdateForm>(this.updateForm_0);
				return this.updateForm_0;
			}
			set
			{
				if (value != this.updateForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<UpdateForm>(ref this.updateForm_0);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000225D File Offset: 0x0000045D
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002333 File Offset: 0x00000533
		public WpsPinForm WpsPinForm_0
		{
			get
			{
				this.wpsPinForm_0 = Class6.Class7.smethod_0<WpsPinForm>(this.wpsPinForm_0);
				return this.wpsPinForm_0;
			}
			set
			{
				if (value != this.wpsPinForm_0)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					this.method_0<WpsPinForm>(ref this.wpsPinForm_0);
				}
			}
		}

		// Token: 0x04000006 RID: 6
		[ThreadStatic]
		private static Hashtable hashtable_0;

		// Token: 0x04000007 RID: 7
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AboutForm aboutForm_0;

		// Token: 0x04000008 RID: 8
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ApLogForm apLogForm_0;

		// Token: 0x04000009 RID: 9
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MainForm mainForm_0;

		// Token: 0x0400000A RID: 10
		[EditorBrowsable(EditorBrowsableState.Never)]
		public StringListEditor stringListEditor_0;

		// Token: 0x0400000B RID: 11
		[EditorBrowsable(EditorBrowsableState.Never)]
		public UpdateForm updateForm_0;

		// Token: 0x0400000C RID: 12
		[EditorBrowsable(EditorBrowsableState.Never)]
		public WpsPinForm wpsPinForm_0;
	}

	// Token: 0x02000006 RID: 6
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class Class8
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000021B6 File Offset: 0x000003B6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public bool Equals(object obj)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(obj));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021C4 File Offset: 0x000003C4
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002358 File Offset: 0x00000558
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal Type method_0()
		{
			return typeof(Class6.Class8);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000021D8 File Offset: 0x000003D8
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004D14 File Offset: 0x00002F14
		[DebuggerHidden]
		private static T smethod_0<T>(T gparam_0) where T : new()
		{
			T result;
			if (gparam_0 == null)
			{
				result = Activator.CreateInstance<T>();
			}
			else
			{
				result = gparam_0;
			}
			return result;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002364 File Offset: 0x00000564
		[DebuggerHidden]
		private void method_1<T>(ref T gparam_0)
		{
			gparam_0 = default(T);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000021AE File Offset: 0x000003AE
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Class8()
		{
		}
	}

	// Token: 0x02000007 RID: 7
	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class Class9<T> where T : new()
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000236D File Offset: 0x0000056D
		internal T Prop_0
		{
			[DebuggerHidden]
			get
			{
				if (Class6.Class9<T>.gparam_0 == null)
				{
					Class6.Class9<T>.gparam_0 = Activator.CreateInstance<T>();
				}
				return Class6.Class9<T>.gparam_0;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000021AE File Offset: 0x000003AE
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public Class9()
		{
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		[ThreadStatic]
		private static T gparam_0;
	}
}
