using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000074 RID: 116
	public partial class addMeta : MetroForm
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00003647 File Offset: 0x00001847
		public addMeta(PCK.MineFile fileIn, PCK currentPCKIn)
		{
			this.InitializeComponent();
			this.file = fileIn;
			this.currentPCK = currentPCKIn;
			base.FormBorderStyle = FormBorderStyle.None;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00021A48 File Offset: 0x0001FC48
		private void button1_Click(object sender, EventArgs e)
		{
			object[] item = new object[]
			{
				this.textBox1.Text,
				this.textBox2.Text
			};
			this.file.entries.Add(item);
			base.Close();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void addMeta_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400035A RID: 858
		private PCK currentPCK;

		// Token: 0x0400035B RID: 859
		private PCK.MineFile file;
	}
}
