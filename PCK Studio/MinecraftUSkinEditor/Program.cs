using System;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000092 RID: 146
	internal static class Program
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00003EF5 File Offset: 0x000020F5
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMain());
		}
	}
}
