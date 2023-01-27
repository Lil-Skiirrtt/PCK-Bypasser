using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200007B RID: 123
	public partial class EntryEditor : Form
	{
		// Token: 0x060001CF RID: 463 RVA: 0x000038AA File Offset: 0x00001AAA
		public EntryEditor(Dictionary<int, string> types, PCK.MineFile file)
		{
			this.InitializeComponent();
			this.types = types;
			this.file = file;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void renameProperly()
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00025F2C File Offset: 0x0002412C
		private void EntryEditor_Load(object sender, EventArgs e)
		{
			foreach (int key in this.types.Keys)
			{
				this.comboBox1.Items.Add(this.types[key]);
			}
			foreach (object[] array in this.file.entries)
			{
				object[] array2 = array;
				TreeNode treeNode = new TreeNode();
				foreach (object[] array3 in this.file.entries)
				{
					treeNode.Text = (string)array2[0];
				}
				treeNode.Tag = array;
				this.treeView1.Nodes.Add(treeNode);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00026050 File Offset: 0x00024250
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			object[] array = (object[])e.Node.Tag;
			this.comboBox1.Text = (string)array[0];
			this.textBox1.Text = (string)array[1];
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000038D1 File Offset: 0x00001AD1
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.treeView1.SelectedNode != null)
			{
				((object[])this.treeView1.SelectedNode.Tag)[0] = this.comboBox1.Text;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00003902 File Offset: 0x00001B02
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.treeView1.SelectedNode != null)
			{
				((object[])this.treeView1.SelectedNode.Tag)[1] = this.textBox1.Text;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00026094 File Offset: 0x00024294
		private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			object[] array = new object[]
			{
				"Replace me",
				"Or it won't save"
			};
			this.file.entries.Add(array);
			TreeNode treeNode = new TreeNode("temp name")
			{
				Tag = array
			};
			this.treeView1.Nodes.Add(treeNode);
			this.renameProperly();
			this.treeView1.SelectedNode = treeNode;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00026100 File Offset: 0x00024300
		private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeView1.SelectedNode != null)
			{
				object[] item = (object[])this.treeView1.SelectedNode.Tag;
				this.file.entries.Remove(item);
				this.treeView1.Nodes.Remove(this.treeView1.SelectedNode);
			}
		}

		// Token: 0x040003C0 RID: 960
		private Dictionary<int, string> types;

		// Token: 0x040003C1 RID: 961
		private PCK.MineFile file;

		// Token: 0x040003C2 RID: 962
		private string entryName = "";
	}
}
