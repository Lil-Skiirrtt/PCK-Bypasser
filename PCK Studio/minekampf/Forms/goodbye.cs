using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace minekampf.Forms
{
	// Token: 0x02000068 RID: 104
	public partial class goodbye : MetroForm
	{
		// Token: 0x06000139 RID: 313 RVA: 0x000032E4 File Offset: 0x000014E4
		public goodbye()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000032F2 File Offset: 0x000014F2
		private void buttonDonate_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCaeUL3gsAHK9LSZG4qqHaJQ");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000032FF File Offset: 0x000014FF
		private void buttonClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
