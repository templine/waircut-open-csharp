using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

// Token: 0x02000002 RID: 2
[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	// Token: 0x06000002 RID: 2 RVA: 0x000020D3 File Offset: 0x000002D3
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoOptimization)]
	internal static void Main(string[] args)
	{
		Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		Class6.Form0_0.Run(args);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000020EA File Offset: 0x000002EA
	[DebuggerStepThrough]
	public Form0() : base(AuthenticationMode.Windows)
	{
		base.IsSingleInstance = true;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000210F File Offset: 0x0000030F
	[DebuggerStepThrough]
	protected virtual void OnCreateMainForm()
	{
		base.MainForm = Class6.Class7_0.MainForm_0;
	}
}
