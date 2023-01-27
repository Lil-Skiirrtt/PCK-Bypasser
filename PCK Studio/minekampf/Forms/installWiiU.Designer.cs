namespace minekampf.Forms
{
	// Token: 0x02000069 RID: 105
	public partial class installWiiU : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000152 RID: 338 RVA: 0x0000332E File Offset: 0x0000152E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00011668 File Offset: 0x0000F868
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.Forms.installWiiU));
			this.metroTabPageMain = new global::MetroFramework.Controls.MetroTabPage();
			this.myTablePanel1 = new global::minekampf.Forms.MyTablePanel();
			this.buttonServerToggle = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.radioButtonSystem = new global::System.Windows.Forms.RadioButton();
			this.buttonSelect = new global::System.Windows.Forms.Button();
			this.radioButtonUSB = new global::System.Windows.Forms.RadioButton();
			this.textBoxHost = new global::MetroFramework.Controls.MetroTextBox();
			this.radioButtonEur = new global::System.Windows.Forms.RadioButton();
			this.radioButtonUs = new global::System.Windows.Forms.RadioButton();
			this.radioButtonJap = new global::System.Windows.Forms.RadioButton();
			this.listViewPCKS = new global::System.Windows.Forms.ListView();
			this.metroTabControlMain = new global::MetroFramework.Controls.MetroTabControl();
			this.contextMenuStripCaffiine = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.replacePCKToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.metroTabPageMain.SuspendLayout();
			this.myTablePanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.metroTabControlMain.SuspendLayout();
			this.contextMenuStripCaffiine.SuspendLayout();
			base.SuspendLayout();
			this.metroTabPageMain.Controls.Add(this.myTablePanel1);
			this.metroTabPageMain.HorizontalScrollbarBarColor = true;
			this.metroTabPageMain.HorizontalScrollbarHighlightOnWheel = false;
			this.metroTabPageMain.HorizontalScrollbarSize = 10;
			this.metroTabPageMain.Location = new global::System.Drawing.Point(4, 38);
			this.metroTabPageMain.Name = "metroTabPageMain";
			this.metroTabPageMain.Size = new global::System.Drawing.Size(427, 537);
			this.metroTabPageMain.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.metroTabPageMain.TabIndex = 0;
			this.metroTabPageMain.Text = "Perma Installer";
			this.metroTabPageMain.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTabPageMain.VerticalScrollbarBarColor = true;
			this.metroTabPageMain.VerticalScrollbarHighlightOnWheel = false;
			this.metroTabPageMain.VerticalScrollbarSize = 10;
			this.myTablePanel1.BackColor = global::System.Drawing.Color.Transparent;
			this.myTablePanel1.ColumnCount = 3;
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33333f));
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 33.33334f));
			this.myTablePanel1.Controls.Add(this.buttonServerToggle, 2, 0);
			this.myTablePanel1.Controls.Add(this.panel1, 0, 1);
			this.myTablePanel1.Controls.Add(this.textBoxHost, 0, 0);
			this.myTablePanel1.Controls.Add(this.radioButtonEur, 0, 2);
			this.myTablePanel1.Controls.Add(this.radioButtonUs, 1, 2);
			this.myTablePanel1.Controls.Add(this.radioButtonJap, 2, 2);
			this.myTablePanel1.Controls.Add(this.listViewPCKS, 0, 3);
			this.myTablePanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanel1.Location = new global::System.Drawing.Point(0, 0);
			this.myTablePanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.myTablePanel1.Name = "myTablePanel1";
			this.myTablePanel1.RowCount = 7;
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 36f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 36f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.Size = new global::System.Drawing.Size(427, 537);
			this.myTablePanel1.TabIndex = 2;
			this.buttonServerToggle.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.buttonServerToggle.BackColor = global::System.Drawing.Color.FromArgb(68, 178, 13);
			this.buttonServerToggle.Enabled = false;
			this.buttonServerToggle.FlatAppearance.BorderSize = 0;
			this.buttonServerToggle.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonServerToggle.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonServerToggle.ForeColor = global::System.Drawing.Color.White;
			this.buttonServerToggle.Location = new global::System.Drawing.Point(287, 3);
			this.buttonServerToggle.Name = "buttonServerToggle";
			this.buttonServerToggle.Size = new global::System.Drawing.Size(137, 27);
			this.buttonServerToggle.TabIndex = 9;
			this.buttonServerToggle.Text = "Start";
			this.buttonServerToggle.UseVisualStyleBackColor = false;
			this.buttonServerToggle.Click += new global::System.EventHandler(this.buttonServerToggle_Click);
			this.myTablePanel1.SetColumnSpan(this.panel1, 3);
			this.panel1.Controls.Add(this.radioButtonSystem);
			this.panel1.Controls.Add(this.buttonSelect);
			this.panel1.Controls.Add(this.radioButtonUSB);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 33);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(427, 36);
			this.panel1.TabIndex = 1;
			this.radioButtonSystem.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonSystem.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonSystem.CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonSystem.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Teal;
			this.radioButtonSystem.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Aqua;
			this.radioButtonSystem.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.radioButtonSystem.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonSystem.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonSystem.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonSystem.Location = new global::System.Drawing.Point(3, 0);
			this.radioButtonSystem.Name = "radioButtonSystem";
			this.radioButtonSystem.Size = new global::System.Drawing.Size(136, 36);
			this.radioButtonSystem.TabIndex = 5;
			this.radioButtonSystem.TabStop = true;
			this.radioButtonSystem.Text = "System";
			this.radioButtonSystem.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonSystem.UseVisualStyleBackColor = false;
			this.radioButtonSystem.CheckedChanged += new global::System.EventHandler(this.radioButtonSystem_CheckedChanged);
			this.buttonSelect.BackgroundImage = global::minekampf.Properties.Resources.sdDownload;
			this.buttonSelect.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.buttonSelect.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonSelect.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonSelect.ForeColor = global::System.Drawing.Color.White;
			this.buttonSelect.Location = new global::System.Drawing.Point(287, 0);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new global::System.Drawing.Size(137, 36);
			this.buttonSelect.TabIndex = 1;
			this.buttonSelect.UseVisualStyleBackColor = true;
			this.buttonSelect.Click += new global::System.EventHandler(this.buttonSelect_Click);
			this.radioButtonUSB.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonUSB.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonUSB.CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonUSB.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Teal;
			this.radioButtonUSB.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Aqua;
			this.radioButtonUSB.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.radioButtonUSB.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonUSB.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonUSB.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonUSB.Location = new global::System.Drawing.Point(145, 0);
			this.radioButtonUSB.Name = "radioButtonUSB";
			this.radioButtonUSB.Size = new global::System.Drawing.Size(136, 36);
			this.radioButtonUSB.TabIndex = 6;
			this.radioButtonUSB.TabStop = true;
			this.radioButtonUSB.Text = "USB";
			this.radioButtonUSB.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonUSB.UseVisualStyleBackColor = false;
			this.radioButtonUSB.CheckedChanged += new global::System.EventHandler(this.radioButtonUSB_CheckedChanged);
			this.textBoxHost.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.textBoxHost.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.myTablePanel1.SetColumnSpan(this.textBoxHost, 2);
			this.textBoxHost.CustomButton.Image = null;
			this.textBoxHost.CustomButton.Location = new global::System.Drawing.Point(260, 2);
			this.textBoxHost.CustomButton.Name = "";
			this.textBoxHost.CustomButton.Size = new global::System.Drawing.Size(15, 15);
			this.textBoxHost.CustomButton.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.textBoxHost.CustomButton.TabIndex = 1;
			this.textBoxHost.CustomButton.Theme = global::MetroFramework.MetroThemeStyle.Light;
			this.textBoxHost.CustomButton.UseSelectable = true;
			this.textBoxHost.CustomButton.Visible = false;
			this.textBoxHost.IconRight = true;
			this.textBoxHost.Lines = new string[0];
			this.textBoxHost.Location = new global::System.Drawing.Point(3, 6);
			this.textBoxHost.MaxLength = 32767;
			this.textBoxHost.Name = "textBoxHost";
			this.textBoxHost.PasswordChar = '\0';
			this.textBoxHost.PromptText = "Wii U IP";
			this.textBoxHost.ScrollBars = global::System.Windows.Forms.ScrollBars.None;
			this.textBoxHost.SelectedText = "";
			this.textBoxHost.SelectionLength = 0;
			this.textBoxHost.SelectionStart = 0;
			this.textBoxHost.ShortcutsEnabled = true;
			this.textBoxHost.Size = new global::System.Drawing.Size(278, 20);
			this.textBoxHost.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.textBoxHost.TabIndex = 10;
			this.textBoxHost.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.textBoxHost.UseSelectable = true;
			this.textBoxHost.WaterMark = "Wii U IP";
			this.textBoxHost.WaterMarkColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.textBoxHost.WaterMarkFont = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Pixel);
			this.radioButtonEur.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonEur.AutoSize = true;
			this.radioButtonEur.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonEur.CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonEur.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radioButtonEur.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Teal;
			this.radioButtonEur.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Aqua;
			this.radioButtonEur.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.radioButtonEur.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonEur.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonEur.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonEur.Location = new global::System.Drawing.Point(3, 72);
			this.radioButtonEur.Name = "radioButtonEur";
			this.radioButtonEur.Size = new global::System.Drawing.Size(136, 30);
			this.radioButtonEur.TabIndex = 1;
			this.radioButtonEur.TabStop = true;
			this.radioButtonEur.Text = "EUR";
			this.radioButtonEur.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonEur.UseVisualStyleBackColor = false;
			this.radioButtonEur.Click += new global::System.EventHandler(this.radioButtonEur_Click);
			this.radioButtonUs.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonUs.AutoSize = true;
			this.radioButtonUs.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonUs.CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonUs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radioButtonUs.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Teal;
			this.radioButtonUs.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Aqua;
			this.radioButtonUs.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.radioButtonUs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonUs.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonUs.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonUs.Location = new global::System.Drawing.Point(145, 72);
			this.radioButtonUs.Name = "radioButtonUs";
			this.radioButtonUs.Size = new global::System.Drawing.Size(136, 30);
			this.radioButtonUs.TabIndex = 0;
			this.radioButtonUs.TabStop = true;
			this.radioButtonUs.Text = "US";
			this.radioButtonUs.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonUs.UseVisualStyleBackColor = false;
			this.radioButtonUs.Click += new global::System.EventHandler(this.radioButtonUs_Click);
			this.radioButtonJap.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.radioButtonJap.AutoSize = true;
			this.radioButtonJap.BackColor = global::System.Drawing.Color.Transparent;
			this.radioButtonJap.CheckAlign = global::System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonJap.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.radioButtonJap.FlatAppearance.CheckedBackColor = global::System.Drawing.Color.Teal;
			this.radioButtonJap.FlatAppearance.MouseDownBackColor = global::System.Drawing.Color.Aqua;
			this.radioButtonJap.FlatAppearance.MouseOverBackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.radioButtonJap.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.radioButtonJap.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.radioButtonJap.ForeColor = global::System.Drawing.Color.White;
			this.radioButtonJap.Location = new global::System.Drawing.Point(287, 72);
			this.radioButtonJap.Name = "radioButtonJap";
			this.radioButtonJap.Size = new global::System.Drawing.Size(137, 30);
			this.radioButtonJap.TabIndex = 2;
			this.radioButtonJap.TabStop = true;
			this.radioButtonJap.Text = "JAP";
			this.radioButtonJap.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonJap.UseVisualStyleBackColor = false;
			this.radioButtonJap.Click += new global::System.EventHandler(this.radioButtonJap_Click);
			this.listViewPCKS.Activation = global::System.Windows.Forms.ItemActivation.TwoClick;
			this.myTablePanel1.SetColumnSpan(this.listViewPCKS, 3);
			this.listViewPCKS.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewPCKS.Enabled = false;
			this.listViewPCKS.Location = new global::System.Drawing.Point(3, 108);
			this.listViewPCKS.Name = "listViewPCKS";
			this.listViewPCKS.Size = new global::System.Drawing.Size(421, 426);
			this.listViewPCKS.TabIndex = 3;
			this.listViewPCKS.UseCompatibleStateImageBehavior = false;
			this.listViewPCKS.View = global::System.Windows.Forms.View.Details;
			this.listViewPCKS.SelectedIndexChanged += new global::System.EventHandler(this.listViewPCKS_SelectedIndexChanged);
			this.listViewPCKS.Click += new global::System.EventHandler(this.listViewPCKS_Click);
			this.listViewPCKS.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listViewPCKS_MouseDown);
			this.metroTabControlMain.Controls.Add(this.metroTabPageMain);
			this.metroTabControlMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.metroTabControlMain.Location = new global::System.Drawing.Point(20, 60);
			this.metroTabControlMain.Name = "metroTabControlMain";
			this.metroTabControlMain.SelectedIndex = 0;
			this.metroTabControlMain.Size = new global::System.Drawing.Size(435, 579);
			this.metroTabControlMain.Style = global::MetroFramework.MetroColorStyle.White;
			this.metroTabControlMain.TabIndex = 0;
			this.metroTabControlMain.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTabControlMain.UseSelectable = true;
			this.contextMenuStripCaffiine.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.replaceToolStripMenuItem,
				this.replacePCKToolStripMenuItem
			});
			this.contextMenuStripCaffiine.Name = "contextMenuStripCaffiine";
			this.contextMenuStripCaffiine.Size = new global::System.Drawing.Size(211, 70);
			this.contextMenuStripCaffiine.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStripCaffiine_Opening);
			this.replacePCKToolStripMenuItem.Image = global::minekampf.Properties.Resources.Replace;
			this.replacePCKToolStripMenuItem.Name = "replacePCKToolStripMenuItem";
			this.replacePCKToolStripMenuItem.Size = new global::System.Drawing.Size(210, 22);
			this.replacePCKToolStripMenuItem.Text = "Replace with external PCK";
			this.replacePCKToolStripMenuItem.Click += new global::System.EventHandler(this.replacePCKToolStripMenuItem_Click);
			this.replaceToolStripMenuItem.Image = global::minekampf.Properties.Resources.Replace;
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new global::System.Drawing.Size(210, 22);
			this.replaceToolStripMenuItem.Text = "Replace";
			this.replaceToolStripMenuItem.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.replaceToolStripMenuItem.Click += new global::System.EventHandler(this.replaceToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(475, 659);
			base.Controls.Add(this.metroTabControlMain);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "installWiiU";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.SystemShadow;
			base.Style = global::MetroFramework.MetroColorStyle.White;
			this.Text = "Install to Wii U";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.metroTabPageMain.ResumeLayout(false);
			this.myTablePanel1.ResumeLayout(false);
			this.myTablePanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.metroTabControlMain.ResumeLayout(false);
			this.contextMenuStripCaffiine.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002EE RID: 750
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002EF RID: 751
		private global::MetroFramework.Controls.MetroTabPage metroTabPageMain;

		// Token: 0x040002F0 RID: 752
		private global::minekampf.Forms.MyTablePanel myTablePanel1;

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Forms.RadioButton radioButtonJap;

		// Token: 0x040002F2 RID: 754
		private global::System.Windows.Forms.RadioButton radioButtonEur;

		// Token: 0x040002F3 RID: 755
		private global::System.Windows.Forms.RadioButton radioButtonUs;

		// Token: 0x040002F4 RID: 756
		private global::System.Windows.Forms.ListView listViewPCKS;

		// Token: 0x040002F5 RID: 757
		private global::MetroFramework.Controls.MetroTabControl metroTabControlMain;

		// Token: 0x040002F6 RID: 758
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStripCaffiine;

		// Token: 0x040002F7 RID: 759
		private global::System.Windows.Forms.ToolStripMenuItem replacePCKToolStripMenuItem;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.RadioButton radioButtonSystem;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.Button buttonSelect;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.RadioButton radioButtonUSB;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.Button buttonServerToggle;

		// Token: 0x040002FD RID: 765
		private global::MetroFramework.Controls.MetroTextBox textBoxHost;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
	}
}
