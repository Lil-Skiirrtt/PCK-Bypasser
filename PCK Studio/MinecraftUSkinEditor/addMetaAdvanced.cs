using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000075 RID: 117
	public partial class addMetaAdvanced : MetroForm
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00003689 File Offset: 0x00001889
		public addMetaAdvanced(TreeView treeMetaIn)
		{
			this.InitializeComponent();
			this.treeMeta = treeMetaIn;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00021E00 File Offset: 0x00020000
		private void button1_Click(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode();
			treeNode.Text = this.textBox1.Text;
			treeNode.Tag = this.textBox2.Text;
			this.treeMeta.Nodes.Add(treeNode);
			base.Close();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void addMetaAdvanced_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000362 RID: 866
		private TreeView treeMeta;
	}
}
