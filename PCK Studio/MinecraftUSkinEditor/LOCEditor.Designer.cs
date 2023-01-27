namespace MinecraftUSkinEditor
{
	// Token: 0x0200008B RID: 139
	public partial class LOCEditor : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x00003D5C File Offset: 0x00001F5C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00041764 File Offset: 0x0003F964
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.LOCEditor));
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addDisplayIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteDisplayIDToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.locSort = new global::minekampf.Forms.MyTablePanel();
			this.buttonReplaceAll = new global::System.Windows.Forms.Button();
			this.dataGridViewLocEntryData = new global::System.Windows.Forms.DataGridView();
			this.textBoxReplaceAll = new global::System.Windows.Forms.TextBox();
			this.treeViewLocEntries = new global::System.Windows.Forms.TreeView();
			this.contextMenuStrip1.SuspendLayout();
			this.locSort.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewLocEntryData).BeginInit();
			base.SuspendLayout();
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addDisplayIDToolStripMenuItem,
				this.deleteDisplayIDToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(163, 48);
			this.addDisplayIDToolStripMenuItem.Name = "addDisplayIDToolStripMenuItem";
			this.addDisplayIDToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.addDisplayIDToolStripMenuItem.Text = "Add Display ID";
			this.deleteDisplayIDToolStripMenuItem.Name = "deleteDisplayIDToolStripMenuItem";
			this.deleteDisplayIDToolStripMenuItem.Size = new global::System.Drawing.Size(162, 22);
			this.deleteDisplayIDToolStripMenuItem.Text = "Delete Display ID";
			this.deleteDisplayIDToolStripMenuItem.Click += new global::System.EventHandler(this.deleteDisplayIDToolStripMenuItem_Click);
			this.locSort.AccessibleRole = global::System.Windows.Forms.AccessibleRole.Table;
			this.locSort.ColumnCount = 3;
			this.locSort.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 300f));
			this.locSort.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.locSort.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.locSort.Controls.Add(this.buttonReplaceAll, 2, 0);
			this.locSort.Controls.Add(this.dataGridViewLocEntryData, 1, 1);
			this.locSort.Controls.Add(this.textBoxReplaceAll, 1, 0);
			this.locSort.Controls.Add(this.treeViewLocEntries, 0, 0);
			this.locSort.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.locSort.Location = new global::System.Drawing.Point(20, 60);
			this.locSort.Name = "locSort";
			this.locSort.RowCount = 2;
			this.locSort.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.locSort.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.locSort.Size = new global::System.Drawing.Size(861, 587);
			this.locSort.TabIndex = 3;
			this.buttonReplaceAll.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonReplaceAll.ForeColor = global::System.Drawing.Color.White;
			this.buttonReplaceAll.Location = new global::System.Drawing.Point(784, 3);
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.buttonReplaceAll.Size = new global::System.Drawing.Size(74, 23);
			this.buttonReplaceAll.TabIndex = 4;
			this.buttonReplaceAll.Text = "Replace All";
			this.buttonReplaceAll.UseVisualStyleBackColor = true;
			this.buttonReplaceAll.Click += new global::System.EventHandler(this.buttonReplaceAll_Click);
			this.dataGridViewLocEntryData.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.locSort.SetColumnSpan(this.dataGridViewLocEntryData, 2);
			this.dataGridViewLocEntryData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewLocEntryData.Location = new global::System.Drawing.Point(303, 32);
			this.dataGridViewLocEntryData.Name = "dataGridViewLocEntryData";
			this.dataGridViewLocEntryData.Size = new global::System.Drawing.Size(555, 552);
			this.dataGridViewLocEntryData.TabIndex = 1;
			this.dataGridViewLocEntryData.CellEndEdit += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.textBoxReplaceAll.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.textBoxReplaceAll.Location = new global::System.Drawing.Point(303, 3);
			this.textBoxReplaceAll.Name = "textBoxReplaceAll";
			this.textBoxReplaceAll.Size = new global::System.Drawing.Size(475, 20);
			this.textBoxReplaceAll.TabIndex = 2;
			this.treeViewLocEntries.ContextMenuStrip = this.contextMenuStrip1;
			this.treeViewLocEntries.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeViewLocEntries.LabelEdit = true;
			this.treeViewLocEntries.Location = new global::System.Drawing.Point(3, 3);
			this.treeViewLocEntries.Name = "treeViewLocEntries";
			this.locSort.SetRowSpan(this.treeViewLocEntries, 2);
			this.treeViewLocEntries.Size = new global::System.Drawing.Size(294, 581);
			this.treeViewLocEntries.TabIndex = 0;
			this.treeViewLocEntries.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeViewLocEntries.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(901, 667);
			base.Controls.Add(this.locSort);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(901, 667);
			base.Name = "LOCEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "LOC Editor";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.LOCEditor_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.locSort.ResumeLayout(false);
			this.locSort.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridViewLocEntryData).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400047F RID: 1151
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000480 RID: 1152
		private global::System.Windows.Forms.TreeView treeViewLocEntries;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.DataGridView dataGridViewLocEntryData;

		// Token: 0x04000482 RID: 1154
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x04000483 RID: 1155
		private global::System.Windows.Forms.ToolStripMenuItem addDisplayIDToolStripMenuItem;

		// Token: 0x04000484 RID: 1156
		private global::System.Windows.Forms.ToolStripMenuItem deleteDisplayIDToolStripMenuItem;

		// Token: 0x04000485 RID: 1157
		private global::System.Windows.Forms.TextBox textBoxReplaceAll;

		// Token: 0x04000486 RID: 1158
		private global::minekampf.Forms.MyTablePanel locSort;

		// Token: 0x04000487 RID: 1159
		private global::System.Windows.Forms.Button buttonReplaceAll;
	}
}
