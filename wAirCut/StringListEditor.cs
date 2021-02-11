using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace wAirCut
{
	// Token: 0x02000038 RID: 56
	[DesignerGenerated]
	public partial class StringListEditor : Form
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x000046BA File Offset: 0x000028BA
		public StringListEditor()
		{
			this.InitializeComponent();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00017130 File Offset: 0x00015330
		[DebuggerNonUserCode]
		protected virtual void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000046C8 File Offset: 0x000028C8
		// (set) Token: 0x060003CC RID: 972 RVA: 0x000046D0 File Offset: 0x000028D0
		internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000046D9 File Offset: 0x000028D9
		// (set) Token: 0x060003CE RID: 974 RVA: 0x000046E1 File Offset: 0x000028E1
		internal virtual ToolStrip ToolStrip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000046EA File Offset: 0x000028EA
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00017344 File Offset: 0x00015544
		internal virtual ToolStripButton tsbAcept
		{
			[CompilerGenerated]
			get
			{
				return this._tsbAcept;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_1);
				ToolStripButton tsbAcept = this._tsbAcept;
				if (tsbAcept != null)
				{
					tsbAcept.Click -= value2;
				}
				this._tsbAcept = value;
				tsbAcept = this._tsbAcept;
				if (tsbAcept != null)
				{
					tsbAcept.Click += value2;
				}
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x000046F2 File Offset: 0x000028F2
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00017388 File Offset: 0x00015588
		internal virtual ToolStripButton tsbCancel
		{
			[CompilerGenerated]
			get
			{
				return this._tsbCancel;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.method_0);
				ToolStripButton tsbCancel = this._tsbCancel;
				if (tsbCancel != null)
				{
					tsbCancel.Click -= value2;
				}
				this._tsbCancel = value;
				tsbCancel = this._tsbCancel;
				if (tsbCancel != null)
				{
					tsbCancel.Click += value2;
				}
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000046FA File Offset: 0x000028FA
		private void method_0(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00004709 File Offset: 0x00002909
		private void method_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00004718 File Offset: 0x00002918
		public void method_2(string string_0)
		{
			this.TextBox1.Lines = string_0.Split(new char[]
			{
				';'
			});
			this.TextBox1.Select(this.TextBox1.TextLength, 0);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000173CC File Offset: 0x000155CC
		public string method_3()
		{
			string text = "";
			foreach (string text2 in this.TextBox1.Lines)
			{
				text2.Replace(" ", "");
				if (text2.Length > 0)
				{
					text = text + text2 + ";";
				}
			}
			if (text.Length > 0)
			{
				text = text.Remove(checked(text.Length - 1), 1);
			}
			return text;
		}

		// Token: 0x040001C2 RID: 450
		private IContainer icontainer_0;
	}
}
