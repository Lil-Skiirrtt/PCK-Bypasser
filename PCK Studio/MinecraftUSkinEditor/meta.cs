using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200008D RID: 141
	public partial class meta : MetroForm
	{
		// Token: 0x060002A3 RID: 675 RVA: 0x00003D7B File Offset: 0x00001F7B
		public meta(PCK currentPCKIn)
		{
			this.InitializeComponent();
			this.currentPCK = currentPCKIn;
			base.FormBorderStyle = FormBorderStyle.None;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003D97 File Offset: 0x00001F97
		private void meta_Load(object sender, EventArgs e)
		{
			this.refresh();
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00041D48 File Offset: 0x0003FF48
		private void refresh()
		{
			try
			{
				this.treeView1.Nodes.Clear();
				foreach (string text in this.currentPCK.typeCodes.Keys)
				{
					this.treeView1.Nodes.Add(text);
				}
			}
			catch (Exception)
			{
				base.Close();
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void treeView1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003D9F File Offset: 0x00001F9F
		private void addToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MetaADD metaADD = new MetaADD(this.currentPCK, this.treeView1);
			metaADD.TopMost = true;
			metaADD.TopLevel = true;
			metaADD.ShowDialog();
			this.refresh();
			metaADD.Dispose();
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00041DD8 File Offset: 0x0003FFD8
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.currentPCK.typeCodes.Remove(this.treeView1.SelectedNode.Text);
				this.refresh();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		// Token: 0x0400048A RID: 1162
		private PCK currentPCK;
	}
}
