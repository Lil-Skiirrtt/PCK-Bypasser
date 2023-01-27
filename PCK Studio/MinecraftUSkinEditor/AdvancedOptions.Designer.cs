namespace MinecraftUSkinEditor
{
	// Token: 0x02000079 RID: 121
	public partial class AdvancedOptions : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x00003827 File Offset: 0x00001A27
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000255C4 File Offset: 0x000237C4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.AdvancedOptions));
			this.treeMeta = new global::System.Windows.Forms.TreeView();
			this.contextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.comboBox2 = new global::System.Windows.Forms.ComboBox();
			this.contextMenuStrip2.SuspendLayout();
			base.SuspendLayout();
			this.treeMeta.ContextMenuStrip = this.contextMenuStrip2;
			this.treeMeta.Location = new global::System.Drawing.Point(12, 63);
			this.treeMeta.Name = "treeMeta";
			this.treeMeta.Size = new global::System.Drawing.Size(291, 142);
			this.treeMeta.TabIndex = 0;
			this.treeMeta.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeMeta_AfterSelect);
			this.contextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addEntryToolStripMenuItem,
				this.deleteEntryToolStripMenuItem
			});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new global::System.Drawing.Size(138, 48);
			this.addEntryToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("addEntryToolStripMenuItem.Image");
			this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
			this.addEntryToolStripMenuItem.Size = new global::System.Drawing.Size(137, 22);
			this.addEntryToolStripMenuItem.Text = "Add Entry";
			this.addEntryToolStripMenuItem.Click += new global::System.EventHandler(this.addEntryToolStripMenuItem_Click);
			this.deleteEntryToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteEntryToolStripMenuItem.Image");
			this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
			this.deleteEntryToolStripMenuItem.Size = new global::System.Drawing.Size(155, 22);
			this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
			this.deleteEntryToolStripMenuItem.Click += new global::System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"All",
				"64x64",
				"64x32",
				"PNG Files"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(71, 256);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(82, 21);
			this.comboBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(20, 259);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(45, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Apply to";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(228, 254);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Apply";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(208, 212);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Entry Data";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(52, 212);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(58, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Entry Type";
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new global::System.Drawing.Point(164, 228);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(139, 20);
			this.textBox1.TabIndex = 9;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new global::System.Drawing.Point(12, 227);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new global::System.Drawing.Size(141, 21);
			this.comboBox2.TabIndex = 10;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(315, 283);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.comboBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.treeMeta);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "AdvancedOptions";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Advanced";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.AdvancedOptions_Load);
			this.contextMenuStrip2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003AE RID: 942
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003AF RID: 943
		private global::System.Windows.Forms.TreeView treeMeta;

		// Token: 0x040003B0 RID: 944
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003B2 RID: 946
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040003B3 RID: 947
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003B4 RID: 948
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040003B5 RID: 949
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040003B6 RID: 950
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip2;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;

		// Token: 0x040003B9 RID: 953
		private global::System.Windows.Forms.ComboBox comboBox2;
	}
}
