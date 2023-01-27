namespace minekampf.Forms
{
	// Token: 0x0200006B RID: 107
	public partial class pckCenter : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00003470 File Offset: 0x00001670
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000131E8 File Offset: 0x000113E8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.Forms.pckCenter));
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.radioButtonMine = new global::System.Windows.Forms.RadioButton();
			this.radioButtonDevPicks = new global::System.Windows.Forms.RadioButton();
			this.radioButtonNew = new global::System.Windows.Forms.RadioButton();
			this.radioButtonAll = new global::System.Windows.Forms.RadioButton();
			this.radioButtonCommunity = new global::System.Windows.Forms.RadioButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.buttonSubmit = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pckLayout = new global::System.Windows.Forms.FlowLayoutPanel();
			this.contextMenuStripPCK = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource1 = new global::System.Windows.Forms.BindingSource(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.contextMenuStripPCK.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.radioButtonMine, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonDevPicks, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonNew, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonAll, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.radioButtonCommunity, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.buttonSubmit, 0, 6);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 7;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(194, 502);
			this.tableLayoutPanel1.TabIndex = 4;
			this.radioButtonMine.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonMine.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonMine.FlatAppearance.BorderSize = 0;
			this.radioButtonMine.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.radioButtonMine.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonMine.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonMine.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonMine.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonMine.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonMine.Location = new global::System.Drawing.Point(3, 398);
			this.radioButtonMine.Name = "radioButtonMine";
			this.radioButtonMine.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.radioButtonMine.Size = new global::System.Drawing.Size(188, 45);
			this.radioButtonMine.TabIndex = 13;
			this.radioButtonMine.Text = "My Collection";
			this.radioButtonMine.UseVisualStyleBackColor = false;
			this.radioButtonMine.CheckedChanged += new global::System.EventHandler(this.radioButtonMine_CheckedChanged);
			this.radioButtonDevPicks.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonDevPicks.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonDevPicks.FlatAppearance.BorderSize = 0;
			this.radioButtonDevPicks.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.radioButtonDevPicks.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonDevPicks.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonDevPicks.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonDevPicks.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonDevPicks.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonDevPicks.Location = new global::System.Drawing.Point(3, 296);
			this.radioButtonDevPicks.Name = "radioButtonDevPicks";
			this.radioButtonDevPicks.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.radioButtonDevPicks.Size = new global::System.Drawing.Size(188, 45);
			this.radioButtonDevPicks.TabIndex = 12;
			this.radioButtonDevPicks.Text = "Dev Picks";
			this.radioButtonDevPicks.UseVisualStyleBackColor = false;
			this.radioButtonDevPicks.CheckedChanged += new global::System.EventHandler(this.radioButtonDevPicks_CheckedChanged);
			this.radioButtonNew.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonNew.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonNew.FlatAppearance.BorderSize = 0;
			this.radioButtonNew.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.radioButtonNew.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonNew.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonNew.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonNew.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonNew.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonNew.Location = new global::System.Drawing.Point(3, 245);
			this.radioButtonNew.Name = "radioButtonNew";
			this.radioButtonNew.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.radioButtonNew.Size = new global::System.Drawing.Size(188, 45);
			this.radioButtonNew.TabIndex = 11;
			this.radioButtonNew.Text = "New";
			this.radioButtonNew.UseVisualStyleBackColor = false;
			this.radioButtonNew.CheckedChanged += new global::System.EventHandler(this.radioButtonNew_CheckedChanged);
			this.radioButtonAll.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonAll.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonAll.Checked = true;
			this.radioButtonAll.FlatAppearance.BorderSize = 0;
			this.radioButtonAll.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.radioButtonAll.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonAll.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonAll.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonAll.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonAll.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonAll.Location = new global::System.Drawing.Point(3, 194);
			this.radioButtonAll.Name = "radioButtonAll";
			this.radioButtonAll.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.radioButtonAll.Size = new global::System.Drawing.Size(188, 45);
			this.radioButtonAll.TabIndex = 10;
			this.radioButtonAll.TabStop = true;
			this.radioButtonAll.Text = "NoblePCKs";
			this.radioButtonAll.UseVisualStyleBackColor = false;
			this.radioButtonAll.CheckedChanged += new global::System.EventHandler(this.radioButtonAll_CheckedChanged);
			this.radioButtonCommunity.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonCommunity.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonCommunity.FlatAppearance.BorderSize = 0;
			this.radioButtonCommunity.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.radioButtonCommunity.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonCommunity.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.radioButtonCommunity.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonCommunity.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonCommunity.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonCommunity.Location = new global::System.Drawing.Point(3, 347);
			this.radioButtonCommunity.Name = "radioButtonCommunity";
			this.radioButtonCommunity.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.radioButtonCommunity.Size = new global::System.Drawing.Size(188, 45);
			this.radioButtonCommunity.TabIndex = 9;
			this.radioButtonCommunity.Text = "Community";
			this.radioButtonCommunity.UseVisualStyleBackColor = false;
			this.radioButtonCommunity.CheckedChanged += new global::System.EventHandler(this.radioButtonCommunity_CheckedChanged);
			this.pictureBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(188, 185);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.buttonSubmit.FlatAppearance.BorderSize = 0;
			this.buttonSubmit.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonSubmit.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonSubmit.ForeColor = global::System.Drawing.Color.White;
			this.buttonSubmit.Location = new global::System.Drawing.Point(3, 449);
			this.buttonSubmit.Name = "buttonSubmit";
			this.buttonSubmit.Padding = new global::System.Windows.Forms.Padding(15, 0, 0, 0);
			this.buttonSubmit.Size = new global::System.Drawing.Size(188, 45);
			this.buttonSubmit.TabIndex = 14;
			this.buttonSubmit.Text = "Submit PCK";
			this.buttonSubmit.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSubmit.UseVisualStyleBackColor = true;
			this.buttonSubmit.Click += new global::System.EventHandler(this.buttonSubmit_Click);
			this.tableLayoutPanel2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 200f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 610f));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(20, 60);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(810, 508);
			this.tableLayoutPanel2.TabIndex = 5;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.panel1.Controls.Add(this.pckLayout);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(203, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(604, 502);
			this.panel1.TabIndex = 5;
			this.pckLayout.AutoScroll = true;
			this.pckLayout.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pckLayout.Location = new global::System.Drawing.Point(0, 0);
			this.pckLayout.Name = "pckLayout";
			this.pckLayout.Size = new global::System.Drawing.Size(604, 502);
			this.pckLayout.TabIndex = 0;
			this.pckLayout.ControlRemoved += new global::System.Windows.Forms.ControlEventHandler(this.pckLayout_ControlRemoved);
			this.pckLayout.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.pckLayout_MouseClick);
			this.pckLayout.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.pckLayout_MouseDown);
			this.pckLayout.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.pckLayout_MouseMove_1);
			this.contextMenuStripPCK.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.deleteToolStripMenuItem,
				this.exportToolStripMenuItem
			});
			this.contextMenuStripPCK.Name = "contextMenuStripPCK";
			this.contextMenuStripPCK.Size = new global::System.Drawing.Size(108, 48);
			this.deleteToolStripMenuItem.Image = global::minekampf.Properties.Resources.Del;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.exportToolStripMenuItem.Image = global::minekampf.Properties.Resources.ExportFile;
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new global::System.Drawing.Size(107, 22);
			this.exportToolStripMenuItem.Text = "Export";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(850, 588);
			base.Controls.Add(this.tableLayoutPanel2);
			this.MinimumSize = new global::System.Drawing.Size(850, 588);
			base.Name = "pckCenter";
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.White;
			this.Text = "PCK Center";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.pckCenter_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.contextMenuStripPCK.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.bindingSource1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000309 RID: 777
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400030A RID: 778
		private global::System.Windows.Forms.BindingSource bindingSource1;

		// Token: 0x0400030B RID: 779
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400030C RID: 780
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400030D RID: 781
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.RadioButton radioButtonDevPicks;

		// Token: 0x0400030F RID: 783
		private global::System.Windows.Forms.RadioButton radioButtonNew;

		// Token: 0x04000310 RID: 784
		private global::System.Windows.Forms.RadioButton radioButtonAll;

		// Token: 0x04000311 RID: 785
		private global::System.Windows.Forms.RadioButton radioButtonCommunity;

		// Token: 0x04000312 RID: 786
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.FlowLayoutPanel pckLayout;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.RadioButton radioButtonMine;

		// Token: 0x04000315 RID: 789
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStripPCK;

		// Token: 0x04000316 RID: 790
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Button buttonSubmit;
	}
}
