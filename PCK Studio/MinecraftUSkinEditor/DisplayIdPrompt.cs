using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200007A RID: 122
	public partial class DisplayIdPrompt : Form
	{
		// Token: 0x060001C9 RID: 457 RVA: 0x00003846 File Offset: 0x00001A46
		public DisplayIdPrompt(FormMain.displayId d)
		{
			this.InitializeComponent();
			this.disp = d;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000385B File Offset: 0x00001A5B
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.disp.id = this.textBox1.Text;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00003873 File Offset: 0x00001A73
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			this.disp.defaultName = this.textBox2.Text;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void DisplayIdPrompt_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040003BA RID: 954
		private FormMain.displayId disp;
	}
}
