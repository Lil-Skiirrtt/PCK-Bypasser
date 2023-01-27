using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using minekampf.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200008B RID: 139
	public partial class LOCEditor : MetroForm
	{
		// Token: 0x06000299 RID: 665 RVA: 0x00041320 File Offset: 0x0003F520
		public LOCEditor(LOC loc)
		{
			this.InitializeComponent();
			this.tbl = new DataTable();
			this.currentLoc = loc;
			this.tbl.Columns.Add(new DataColumn("Language")
			{
				ReadOnly = true
			});
			this.tbl.Columns.Add("Display Name");
			this.dataGridViewLocEntryData.DataSource = this.tbl;
			this.dataGridViewLocEntryData.Columns[1].Width = 600;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000413B0 File Offset: 0x0003F5B0
		private void LOCEditor_Load(object sender, EventArgs e)
		{
			foreach (string text in this.currentLoc.ids.names)
			{
				this.treeViewLocEntries.Nodes.Add(text);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00041418 File Offset: 0x0003F618
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.tbl.Rows.Clear();
			foreach (LOC.Language language in this.currentLoc.langs)
			{
				this.tbl.Rows.Add(new object[]
				{
					language.name,
					language.names[e.Node.Index]
				});
			}
			try
			{
				if (this.treeViewLocEntries.SelectedNode != null)
				{
					this.buttonReplaceAll.Enabled = true;
				}
				else
				{
					this.buttonReplaceAll.Enabled = false;
				}
			}
			catch (Exception)
			{
				this.buttonReplaceAll.Enabled = false;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000414F8 File Offset: 0x0003F6F8
		private void deleteDisplayIDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewLocEntries.SelectedNode != null)
			{
				int index = this.treeViewLocEntries.SelectedNode.Index;
				this.currentLoc.ids.names.RemoveAt(index);
				foreach (LOC.Language language in this.currentLoc.langs)
				{
					language.names.RemoveAt(index);
				}
				this.treeViewLocEntries.Nodes.RemoveAt(index);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00041598 File Offset: 0x0003F798
		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			for (int i = 0; i < this.tbl.Rows.Count; i++)
			{
				this.currentLoc.langs[i].names[this.treeViewLocEntries.SelectedNode.Index] = (string)this.tbl.Rows[i][1];
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00041608 File Offset: 0x0003F808
		private void treeView1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete && this.treeViewLocEntries.SelectedNode != null)
			{
				int index = this.treeViewLocEntries.SelectedNode.Index;
				this.currentLoc.ids.names.RemoveAt(index);
				foreach (LOC.Language language in this.currentLoc.langs)
				{
					language.names.RemoveAt(index);
				}
				this.treeViewLocEntries.Nodes.RemoveAt(index);
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000416B8 File Offset: 0x0003F8B8
		private void buttonReplaceAll_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < this.tbl.Rows.Count; i++)
			{
				this.tbl.Rows[i][1] = this.textBoxReplaceAll.Text;
			}
			for (int j = 0; j < this.tbl.Rows.Count; j++)
			{
				this.currentLoc.langs[j].names[this.treeViewLocEntries.SelectedNode.Index] = (string)this.tbl.Rows[j][1];
			}
		}

		// Token: 0x0400047D RID: 1149
		private DataTable tbl;

		// Token: 0x0400047E RID: 1150
		private LOC currentLoc;

		// Token: 0x0200008C RID: 140
		public class displayId
		{
			// Token: 0x04000488 RID: 1160
			public string id;

			// Token: 0x04000489 RID: 1161
			public string defaultName;
		}
	}
}
