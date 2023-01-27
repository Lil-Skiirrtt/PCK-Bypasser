namespace MinecraftUSkinEditor
{
	// Token: 0x0200007B RID: 123
	public partial class EntryEditor : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00003933 File Offset: 0x00001B33
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00026160 File Offset: 0x00024360
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.EntryEditor));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.treeView1 = new global::System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(5, 235);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(201, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(7, 196);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(201, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(76, 178);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(58, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Entry Type";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(74, 219);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Entry Data";
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.HideSelection = false;
			this.treeView1.Location = new global::System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new global::System.Drawing.Size(214, 173);
			this.treeView1.TabIndex = 5;
			this.treeView1.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addEntryToolStripMenuItem,
				this.deleteEntryToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(153, 70);
			this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
			this.addEntryToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.addEntryToolStripMenuItem.Text = "Add Entry";
			this.addEntryToolStripMenuItem.Click += new global::System.EventHandler(this.addEntryToolStripMenuItem_Click);
			this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
			this.deleteEntryToolStripMenuItem.Size = new global::System.Drawing.Size(152, 22);
			this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
			this.deleteEntryToolStripMenuItem.Click += new global::System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(214, 270);
			base.Controls.Add(this.treeView1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "EntryEditor";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Entry Editor";
			base.Load += new global::System.EventHandler(this.EntryEditor_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003C3 RID: 963
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003C4 RID: 964
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040003C5 RID: 965
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040003C6 RID: 966
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003C7 RID: 967
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.TreeView treeView1;

		// Token: 0x040003C9 RID: 969
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040003CA RID: 970
		private global::System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;

		// Token: 0x040003CB RID: 971
		private global::System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;
	}
}
