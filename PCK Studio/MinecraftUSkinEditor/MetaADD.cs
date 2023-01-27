using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200008E RID: 142
	public partial class MetaADD : Form
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public MetaADD(PCK currentPCKIn, TreeView treeView1In)
		{
			this.InitializeComponent();
			this.currentPCK = currentPCKIn;
			this.treeView1 = treeView1In;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000420D4 File Offset: 0x000402D4
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.currentPCK.typeCodes.Add(this.textBox1.Text, this.treeView1.Nodes.Count);
				this.currentPCK.types.Add(this.treeView1.Nodes.Count, this.textBox1.Text);
			}
			catch (Exception)
			{
				MessageBox.Show("This metatag already exits");
			}
			base.Close();
		}

		// Token: 0x04000490 RID: 1168
		private PCK currentPCK;

		// Token: 0x04000491 RID: 1169
		private TreeView treeView1;
	}
}
