namespace MinecraftUSkinEditor
{
	// Token: 0x0200008D RID: 141
	public partial class meta : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00003DD2 File Offset: 0x00001FD2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00041E24 File Offset: 0x00040024
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.meta));
			this.treeView1 = new global::System.Windows.Forms.TreeView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView1.Location = new global::System.Drawing.Point(7, 62);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new global::System.Drawing.Size(238, 268);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.Click += new global::System.EventHandler(this.treeView1_Click);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addToolStripMenuItem,
				this.deleteToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(108, 48);
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
			this.addToolStripMenuItem.Text = "Add";
			this.addToolStripMenuItem.Click += new global::System.EventHandler(this.addToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(252, 337);
			base.Controls.Add(this.treeView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "meta";
			base.Resizable = false;
			this.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Meta Database";
			base.TextAlign = global::MetroFramework.Forms.MetroFormTextAlign.Center;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.meta_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400048B RID: 1163
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400048C RID: 1164
		private global::System.Windows.Forms.TreeView treeView1;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;

		// Token: 0x0400048F RID: 1167
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
	}
}
