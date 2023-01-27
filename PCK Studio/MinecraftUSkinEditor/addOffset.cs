using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000078 RID: 120
	public partial class addOffset : Form
	{
		// Token: 0x060001BB RID: 443 RVA: 0x00003799 File Offset: 0x00001999
		public addOffset()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000037A7 File Offset: 0x000019A7
		private void addOffset_Load(object sender, EventArgs e)
		{
			this.listView1.Columns.Add("PARTS", 100);
		}
	}
}
