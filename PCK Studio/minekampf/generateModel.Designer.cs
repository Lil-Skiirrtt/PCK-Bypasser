namespace minekampf
{
	// Token: 0x02000062 RID: 98
	public partial class generateModel : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000102 RID: 258 RVA: 0x00002E70 File Offset: 0x00001070
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.generateModel));
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Black"
			}, -1, global::System.Drawing.Color.White, global::System.Drawing.Color.Black, null);
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Silver"
			}, -1, global::System.Drawing.Color.Empty, global::System.Drawing.Color.Silver, null);
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Red"
			}, -1, global::System.Drawing.Color.White, global::System.Drawing.Color.Red, null);
			global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Cyan"
			}, -1, global::System.Drawing.Color.Empty, global::System.Drawing.Color.Cyan, null);
			global::System.Windows.Forms.ListViewItem listViewItem5 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Green"
			}, -1, global::System.Drawing.Color.White, global::System.Drawing.Color.Green, null);
			global::System.Windows.Forms.ListViewItem listViewItem6 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Yellow"
			}, -1, global::System.Drawing.Color.Empty, global::System.Drawing.Color.Yellow, null);
			global::System.Windows.Forms.ListViewItem listViewItem7 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Indigo"
			}, -1, global::System.Drawing.Color.White, global::System.Drawing.Color.Indigo, null);
			global::System.Windows.Forms.ListViewItem listViewItem8 = new global::System.Windows.Forms.ListViewItem(new string[]
			{
				"Caption"
			}, -1, global::System.Drawing.Color.Empty, global::System.Drawing.SystemColors.InactiveCaption, null);
			this.buttonImportModel = new global::System.Windows.Forms.Button();
			this.buttonExportModel = new global::System.Windows.Forms.Button();
			this.checkTextureGenerate = new global::System.Windows.Forms.CheckBox();
			this.checkGuide = new global::System.Windows.Forms.CheckBox();
			this.labelView = new global::System.Windows.Forms.Label();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label7 = new global::System.Windows.Forms.Label();
			this.textTextureY = new global::System.Windows.Forms.TextBox();
			this.textTextureX = new global::System.Windows.Forms.TextBox();
			this.buttonIMPORT = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.buttonZcplus = new global::System.Windows.Forms.Button();
			this.buttonXcminus = new global::System.Windows.Forms.Button();
			this.buttonYcminus = new global::System.Windows.Forms.Button();
			this.buttonZcminus = new global::System.Windows.Forms.Button();
			this.buttonYcplus = new global::System.Windows.Forms.Button();
			this.buttonXcplus = new global::System.Windows.Forms.Button();
			this.buttonZfplus = new global::System.Windows.Forms.Button();
			this.buttonXfminus = new global::System.Windows.Forms.Button();
			this.buttonYfminus = new global::System.Windows.Forms.Button();
			this.buttonZfminus = new global::System.Windows.Forms.Button();
			this.buttonYfplus = new global::System.Windows.Forms.Button();
			this.buttonXfplus = new global::System.Windows.Forms.Button();
			this.buttonEXPORT = new global::System.Windows.Forms.Button();
			this.labelTextureMappingPreview = new global::System.Windows.Forms.Label();
			this.buttonDone = new global::System.Windows.Forms.Button();
			this.textYc = new global::System.Windows.Forms.TextBox();
			this.textZc = new global::System.Windows.Forms.TextBox();
			this.textXf = new global::System.Windows.Forms.TextBox();
			this.textYf = new global::System.Windows.Forms.TextBox();
			this.textZf = new global::System.Windows.Forms.TextBox();
			this.textXc = new global::System.Windows.Forms.TextBox();
			this.buttonTemplate = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.tabBody = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.myTablePanel2 = new global::minekampf.Forms.MyTablePanel();
			this.offsetArms = new global::System.Windows.Forms.TextBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.offsetBody = new global::System.Windows.Forms.TextBox();
			this.offsetLegs = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.offsetHead = new global::System.Windows.Forms.TextBox();
			this.label12 = new global::System.Windows.Forms.Label();
			this.tabArmor = new global::System.Windows.Forms.TabPage();
			this.myTablePanel1 = new global::minekampf.Forms.MyTablePanel();
			this.offsetBoots = new global::System.Windows.Forms.TextBox();
			this.offsetPants = new global::System.Windows.Forms.TextBox();
			this.offsetTool = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.offsetHelmet = new global::System.Windows.Forms.TextBox();
			this.label15 = new global::System.Windows.Forms.Label();
			this.label16 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.comboParent = new global::System.Windows.Forms.ComboBox();
			this.labelModeParts = new global::System.Windows.Forms.Label();
			this.listViewBoxes = new global::System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.createToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cloneToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.changeColorToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.labelFullSkinPreview = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.checkBoxArmor = new global::System.Windows.Forms.CheckBox();
			this.labelTheme = new global::System.Windows.Forms.Label();
			this.listViewBGs = new global::System.Windows.Forms.ListView();
			this.tableLayoutPanelMain = new global::System.Windows.Forms.TableLayoutPanel();
			this.displayBox = new global::System.Windows.Forms.PictureBox();
			this.texturePreview = new global::System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.tabBody.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.myTablePanel2.SuspendLayout();
			this.tabArmor.SuspendLayout();
			this.myTablePanel1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.tableLayoutPanelMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.texturePreview).BeginInit();
			base.SuspendLayout();
			this.buttonImportModel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonImportModel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonImportModel.ForeColor = global::System.Drawing.Color.White;
			this.buttonImportModel.Location = new global::System.Drawing.Point(242, 3);
			this.buttonImportModel.Name = "buttonImportModel";
			this.buttonImportModel.Size = new global::System.Drawing.Size(134, 21);
			this.buttonImportModel.TabIndex = 96;
			this.buttonImportModel.Text = "OPEN CSM";
			this.buttonImportModel.UseVisualStyleBackColor = true;
			this.buttonImportModel.Click += new global::System.EventHandler(this.buttonImportModel_Click);
			this.buttonExportModel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.buttonExportModel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonExportModel.ForeColor = global::System.Drawing.Color.White;
			this.buttonExportModel.Location = new global::System.Drawing.Point(453, 3);
			this.buttonExportModel.Name = "buttonExportModel";
			this.buttonExportModel.Size = new global::System.Drawing.Size(119, 21);
			this.buttonExportModel.TabIndex = 97;
			this.buttonExportModel.Text = "EXPORT CSM";
			this.buttonExportModel.UseVisualStyleBackColor = true;
			this.buttonExportModel.Click += new global::System.EventHandler(this.buttonExportModel_Click);
			this.checkTextureGenerate.AutoSize = true;
			this.checkTextureGenerate.Checked = true;
			this.checkTextureGenerate.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTextureGenerate.ForeColor = global::System.Drawing.Color.White;
			this.checkTextureGenerate.Location = new global::System.Drawing.Point(242, 601);
			this.checkTextureGenerate.Name = "checkTextureGenerate";
			this.checkTextureGenerate.Size = new global::System.Drawing.Size(134, 17);
			this.checkTextureGenerate.TabIndex = 104;
			this.checkTextureGenerate.Text = "Auto Generate Texture";
			this.checkTextureGenerate.UseVisualStyleBackColor = true;
			this.checkTextureGenerate.CheckedChanged += new global::System.EventHandler(this.checkTextureGenerate_CheckedChanged);
			this.checkGuide.AutoSize = true;
			this.checkGuide.ForeColor = global::System.Drawing.Color.White;
			this.checkGuide.Location = new global::System.Drawing.Point(130, 601);
			this.checkGuide.Name = "checkGuide";
			this.checkGuide.Size = new global::System.Drawing.Size(82, 17);
			this.checkGuide.TabIndex = 103;
			this.checkGuide.Text = "Guide Lines";
			this.checkGuide.UseVisualStyleBackColor = true;
			this.checkGuide.CheckedChanged += new global::System.EventHandler(this.checkGuide_CheckedChanged);
			this.labelView.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelView.AutoSize = true;
			this.labelView.ForeColor = global::System.Drawing.Color.White;
			this.labelView.Location = new global::System.Drawing.Point(242, 577);
			this.labelView.Name = "labelView";
			this.labelView.Size = new global::System.Drawing.Size(134, 13);
			this.labelView.TabIndex = 102;
			this.labelView.Text = "View:";
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(130, 572);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(89, 23);
			this.button2.TabIndex = 101;
			this.button2.Text = "Rotate Left";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(483, 572);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(89, 23);
			this.button1.TabIndex = 100;
			this.button1.Text = "Rotate Right";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label7.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(578, 194);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(22, 13);
			this.label7.TabIndex = 131;
			this.label7.Text = "UV";
			this.textTextureY.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanelMain.SetColumnSpan(this.textTextureY, 2);
			this.textTextureY.Location = new global::System.Drawing.Point(609, 191);
			this.textTextureY.Name = "textTextureY";
			this.textTextureY.Size = new global::System.Drawing.Size(30, 20);
			this.textTextureY.TabIndex = 130;
			this.textTextureY.TextChanged += new global::System.EventHandler(this.textTextureY_TextChanged);
			this.textTextureY.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textTextureX, 2);
			this.textTextureX.Location = new global::System.Drawing.Point(645, 191);
			this.textTextureX.Name = "textTextureX";
			this.textTextureX.Size = new global::System.Drawing.Size(30, 20);
			this.textTextureX.TabIndex = 129;
			this.textTextureX.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textTextureX.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonIMPORT, 3);
			this.buttonIMPORT.Enabled = false;
			this.buttonIMPORT.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonIMPORT.ForeColor = global::System.Drawing.Color.White;
			this.buttonIMPORT.Location = new global::System.Drawing.Point(578, 164);
			this.buttonIMPORT.Name = "buttonIMPORT";
			this.buttonIMPORT.Size = new global::System.Drawing.Size(61, 21);
			this.buttonIMPORT.TabIndex = 128;
			this.buttonIMPORT.Text = "IMPORT";
			this.buttonIMPORT.UseVisualStyleBackColor = true;
			this.buttonIMPORT.Click += new global::System.EventHandler(this.buttonIMPORT_Click);
			this.label5.AutoSize = true;
			this.tableLayoutPanelMain.SetColumnSpan(this.label5, 3);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(578, 311);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(44, 13);
			this.label5.TabIndex = 127;
			this.label5.Text = "Position";
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonZcplus, 2);
			this.buttonZcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZcplus.Location = new global::System.Drawing.Point(667, 327);
			this.buttonZcplus.Name = "buttonZcplus";
			this.buttonZcplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonZcplus.TabIndex = 126;
			this.buttonZcplus.Text = "+";
			this.buttonZcplus.UseVisualStyleBackColor = true;
			this.buttonZcplus.Click += new global::System.EventHandler(this.buttonZcplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonXcminus, 2);
			this.buttonXcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXcminus.Location = new global::System.Drawing.Point(578, 382);
			this.buttonXcminus.Name = "buttonXcminus";
			this.buttonXcminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonXcminus.TabIndex = 125;
			this.buttonXcminus.Text = "-";
			this.buttonXcminus.UseVisualStyleBackColor = true;
			this.buttonXcminus.Click += new global::System.EventHandler(this.buttonXcminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonYcminus, 2);
			this.buttonYcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYcminus.Location = new global::System.Drawing.Point(622, 382);
			this.buttonYcminus.Name = "buttonYcminus";
			this.buttonYcminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonYcminus.TabIndex = 124;
			this.buttonYcminus.Text = "-";
			this.buttonYcminus.UseVisualStyleBackColor = true;
			this.buttonYcminus.Click += new global::System.EventHandler(this.buttonYcminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonZcminus, 2);
			this.buttonZcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZcminus.Location = new global::System.Drawing.Point(667, 382);
			this.buttonZcminus.Name = "buttonZcminus";
			this.buttonZcminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonZcminus.TabIndex = 123;
			this.buttonZcminus.Text = "-";
			this.buttonZcminus.UseVisualStyleBackColor = true;
			this.buttonZcminus.Click += new global::System.EventHandler(this.buttonZcminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonYcplus, 2);
			this.buttonYcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYcplus.Location = new global::System.Drawing.Point(622, 327);
			this.buttonYcplus.Name = "buttonYcplus";
			this.buttonYcplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonYcplus.TabIndex = 122;
			this.buttonYcplus.Text = "+";
			this.buttonYcplus.UseVisualStyleBackColor = true;
			this.buttonYcplus.Click += new global::System.EventHandler(this.buttonYcplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonXcplus, 2);
			this.buttonXcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXcplus.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXcplus.Location = new global::System.Drawing.Point(578, 327);
			this.buttonXcplus.Name = "buttonXcplus";
			this.buttonXcplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonXcplus.TabIndex = 121;
			this.buttonXcplus.Text = "+";
			this.buttonXcplus.UseVisualStyleBackColor = true;
			this.buttonXcplus.Click += new global::System.EventHandler(this.buttonXcplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonZfplus, 2);
			this.buttonZfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZfplus.Location = new global::System.Drawing.Point(667, 230);
			this.buttonZfplus.Name = "buttonZfplus";
			this.buttonZfplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonZfplus.TabIndex = 120;
			this.buttonZfplus.Text = "+";
			this.buttonZfplus.UseVisualStyleBackColor = true;
			this.buttonZfplus.Click += new global::System.EventHandler(this.buttonZfplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonXfminus, 2);
			this.buttonXfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXfminus.Location = new global::System.Drawing.Point(578, 285);
			this.buttonXfminus.Name = "buttonXfminus";
			this.buttonXfminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonXfminus.TabIndex = 119;
			this.buttonXfminus.Text = "-";
			this.buttonXfminus.UseVisualStyleBackColor = true;
			this.buttonXfminus.Click += new global::System.EventHandler(this.buttonXfminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonYfminus, 2);
			this.buttonYfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYfminus.Location = new global::System.Drawing.Point(622, 285);
			this.buttonYfminus.Name = "buttonYfminus";
			this.buttonYfminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonYfminus.TabIndex = 118;
			this.buttonYfminus.Text = "-";
			this.buttonYfminus.UseVisualStyleBackColor = true;
			this.buttonYfminus.Click += new global::System.EventHandler(this.buttonYfminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonZfminus, 2);
			this.buttonZfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZfminus.Location = new global::System.Drawing.Point(667, 285);
			this.buttonZfminus.Name = "buttonZfminus";
			this.buttonZfminus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonZfminus.TabIndex = 117;
			this.buttonZfminus.Text = "-";
			this.buttonZfminus.UseVisualStyleBackColor = true;
			this.buttonZfminus.Click += new global::System.EventHandler(this.buttonZfminus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonYfplus, 2);
			this.buttonYfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYfplus.Location = new global::System.Drawing.Point(622, 230);
			this.buttonYfplus.Name = "buttonYfplus";
			this.buttonYfplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonYfplus.TabIndex = 116;
			this.buttonYfplus.Text = "+";
			this.buttonYfplus.UseVisualStyleBackColor = true;
			this.buttonYfplus.Click += new global::System.EventHandler(this.buttonYfplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonXfplus, 2);
			this.buttonXfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXfplus.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXfplus.Location = new global::System.Drawing.Point(578, 230);
			this.buttonXfplus.Name = "buttonXfplus";
			this.buttonXfplus.Size = new global::System.Drawing.Size(38, 23);
			this.buttonXfplus.TabIndex = 115;
			this.buttonXfplus.Text = "+";
			this.buttonXfplus.UseVisualStyleBackColor = true;
			this.buttonXfplus.Click += new global::System.EventHandler(this.buttonXfplus_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonEXPORT, 3);
			this.buttonEXPORT.Enabled = false;
			this.buttonEXPORT.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonEXPORT.ForeColor = global::System.Drawing.Color.White;
			this.buttonEXPORT.Location = new global::System.Drawing.Point(645, 164);
			this.buttonEXPORT.Name = "buttonEXPORT";
			this.buttonEXPORT.Size = new global::System.Drawing.Size(61, 21);
			this.buttonEXPORT.TabIndex = 114;
			this.buttonEXPORT.Text = "EXPORT";
			this.buttonEXPORT.UseVisualStyleBackColor = true;
			this.buttonEXPORT.Click += new global::System.EventHandler(this.buttonEXPORT_Click);
			this.labelTextureMappingPreview.AutoSize = true;
			this.tableLayoutPanelMain.SetColumnSpan(this.labelTextureMappingPreview, 6);
			this.labelTextureMappingPreview.ForeColor = global::System.Drawing.Color.White;
			this.labelTextureMappingPreview.Location = new global::System.Drawing.Point(578, 0);
			this.labelTextureMappingPreview.Name = "labelTextureMappingPreview";
			this.labelTextureMappingPreview.Size = new global::System.Drawing.Size(128, 13);
			this.labelTextureMappingPreview.TabIndex = 113;
			this.labelTextureMappingPreview.Text = "Texture Mapping Preview";
			this.tableLayoutPanelMain.SetColumnSpan(this.buttonDone, 3);
			this.buttonDone.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonDone.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDone.ForeColor = global::System.Drawing.Color.White;
			this.buttonDone.Location = new global::System.Drawing.Point(645, 601);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new global::System.Drawing.Size(64, 22);
			this.buttonDone.TabIndex = 111;
			this.buttonDone.Text = "Create";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new global::System.EventHandler(this.buttonDone_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.textYc, 2);
			this.textYc.Location = new global::System.Drawing.Point(622, 356);
			this.textYc.Name = "textYc";
			this.textYc.Size = new global::System.Drawing.Size(38, 20);
			this.textYc.TabIndex = 110;
			this.textYc.TextChanged += new global::System.EventHandler(this.textYc_TextChanged);
			this.textYc.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textZc, 2);
			this.textZc.Location = new global::System.Drawing.Point(667, 356);
			this.textZc.Name = "textZc";
			this.textZc.Size = new global::System.Drawing.Size(38, 20);
			this.textZc.TabIndex = 109;
			this.textZc.TextChanged += new global::System.EventHandler(this.textZc_TextChanged);
			this.textZc.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textXf, 2);
			this.textXf.Location = new global::System.Drawing.Point(578, 259);
			this.textXf.Name = "textXf";
			this.textXf.Size = new global::System.Drawing.Size(38, 20);
			this.textXf.TabIndex = 108;
			this.textXf.TextChanged += new global::System.EventHandler(this.textXf_TextChanged);
			this.textXf.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textYf, 2);
			this.textYf.Location = new global::System.Drawing.Point(622, 259);
			this.textYf.Name = "textYf";
			this.textYf.Size = new global::System.Drawing.Size(38, 20);
			this.textYf.TabIndex = 107;
			this.textYf.TextChanged += new global::System.EventHandler(this.textYf_TextChanged);
			this.textYf.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textZf, 2);
			this.textZf.Location = new global::System.Drawing.Point(667, 259);
			this.textZf.Name = "textZf";
			this.textZf.Size = new global::System.Drawing.Size(38, 20);
			this.textZf.TabIndex = 106;
			this.textZf.TextChanged += new global::System.EventHandler(this.textZf_TextChanged);
			this.textZf.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.tableLayoutPanelMain.SetColumnSpan(this.textXc, 2);
			this.textXc.Location = new global::System.Drawing.Point(578, 356);
			this.textXc.Name = "textXc";
			this.textXc.Size = new global::System.Drawing.Size(38, 20);
			this.textXc.TabIndex = 105;
			this.textXc.TextChanged += new global::System.EventHandler(this.textXc_TextChanged);
			this.textXc.Leave += new global::System.EventHandler(this.textXc_Leave);
			this.buttonTemplate.Location = new global::System.Drawing.Point(3, 601);
			this.buttonTemplate.Name = "buttonTemplate";
			this.buttonTemplate.Size = new global::System.Drawing.Size(114, 23);
			this.buttonTemplate.TabIndex = 140;
			this.buttonTemplate.Text = "Load Template";
			this.buttonTemplate.UseVisualStyleBackColor = true;
			this.buttonTemplate.Click += new global::System.EventHandler(this.buttonTemplate_Click);
			this.tableLayoutPanelMain.SetColumnSpan(this.groupBox1, 6);
			this.groupBox1.Controls.Add(this.tabBody);
			this.groupBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(578, 411);
			this.groupBox1.Name = "groupBox1";
			this.tableLayoutPanelMain.SetRowSpan(this.groupBox1, 2);
			this.groupBox1.Size = new global::System.Drawing.Size(132, 155);
			this.groupBox1.TabIndex = 139;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "OFFSETS";
			this.tabBody.Controls.Add(this.tabPage1);
			this.tabBody.Controls.Add(this.tabArmor);
			this.tabBody.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabBody.Location = new global::System.Drawing.Point(3, 16);
			this.tabBody.Name = "tabBody";
			this.tabBody.SelectedIndex = 0;
			this.tabBody.Size = new global::System.Drawing.Size(126, 136);
			this.tabBody.TabIndex = 144;
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.tabPage1.Controls.Add(this.myTablePanel2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(118, 110);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Body";
			this.myTablePanel2.ColumnCount = 2;
			this.myTablePanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel2.Controls.Add(this.offsetArms, 1, 3);
			this.myTablePanel2.Controls.Add(this.label14, 0, 3);
			this.myTablePanel2.Controls.Add(this.offsetBody, 1, 1);
			this.myTablePanel2.Controls.Add(this.offsetLegs, 1, 2);
			this.myTablePanel2.Controls.Add(this.label10, 0, 0);
			this.myTablePanel2.Controls.Add(this.label13, 0, 2);
			this.myTablePanel2.Controls.Add(this.offsetHead, 1, 0);
			this.myTablePanel2.Controls.Add(this.label12, 0, 1);
			this.myTablePanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanel2.Location = new global::System.Drawing.Point(3, 3);
			this.myTablePanel2.Name = "myTablePanel2";
			this.myTablePanel2.RowCount = 4;
			this.myTablePanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel2.Size = new global::System.Drawing.Size(112, 104);
			this.myTablePanel2.TabIndex = 146;
			this.offsetArms.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetArms.Location = new global::System.Drawing.Point(59, 81);
			this.offsetArms.Name = "offsetArms";
			this.offsetArms.Size = new global::System.Drawing.Size(43, 20);
			this.offsetArms.TabIndex = 85;
			this.offsetArms.Text = "0";
			this.offsetArms.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.label14.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label14.AutoSize = true;
			this.label14.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label14.Location = new global::System.Drawing.Point(3, 84);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(38, 13);
			this.label14.TabIndex = 90;
			this.label14.Text = "ARMS";
			this.offsetBody.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetBody.Location = new global::System.Drawing.Point(59, 29);
			this.offsetBody.Name = "offsetBody";
			this.offsetBody.Size = new global::System.Drawing.Size(43, 20);
			this.offsetBody.TabIndex = 83;
			this.offsetBody.Text = "0";
			this.offsetBody.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.offsetLegs.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetLegs.Location = new global::System.Drawing.Point(59, 55);
			this.offsetLegs.Name = "offsetLegs";
			this.offsetLegs.Size = new global::System.Drawing.Size(43, 20);
			this.offsetLegs.TabIndex = 84;
			this.offsetLegs.Text = "0";
			this.offsetLegs.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.label10.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label10.AutoSize = true;
			this.label10.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.label10.Location = new global::System.Drawing.Point(3, 6);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(37, 13);
			this.label10.TabIndex = 87;
			this.label10.Text = "HEAD";
			this.label13.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label13.AutoSize = true;
			this.label13.ForeColor = global::System.Drawing.Color.FromArgb(64, 0, 64);
			this.label13.Location = new global::System.Drawing.Point(3, 58);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(35, 13);
			this.label13.TabIndex = 89;
			this.label13.Text = "LEGS";
			this.offsetHead.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetHead.Location = new global::System.Drawing.Point(59, 3);
			this.offsetHead.Name = "offsetHead";
			this.offsetHead.Size = new global::System.Drawing.Size(43, 20);
			this.offsetHead.TabIndex = 86;
			this.offsetHead.Text = "0";
			this.offsetHead.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.label12.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label12.AutoSize = true;
			this.label12.ForeColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.label12.Location = new global::System.Drawing.Point(3, 32);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(37, 13);
			this.label12.TabIndex = 88;
			this.label12.Text = "BODY";
			this.tabArmor.BackColor = global::System.Drawing.Color.FromArgb(17, 17, 17);
			this.tabArmor.Controls.Add(this.myTablePanel1);
			this.tabArmor.Location = new global::System.Drawing.Point(4, 22);
			this.tabArmor.Name = "tabArmor";
			this.tabArmor.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabArmor.Size = new global::System.Drawing.Size(118, 110);
			this.tabArmor.TabIndex = 1;
			this.tabArmor.Text = "Armor";
			this.myTablePanel1.ColumnCount = 2;
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.myTablePanel1.Controls.Add(this.offsetBoots, 1, 3);
			this.myTablePanel1.Controls.Add(this.offsetPants, 1, 2);
			this.myTablePanel1.Controls.Add(this.offsetTool, 1, 1);
			this.myTablePanel1.Controls.Add(this.label4, 0, 1);
			this.myTablePanel1.Controls.Add(this.label9, 0, 0);
			this.myTablePanel1.Controls.Add(this.offsetHelmet, 1, 0);
			this.myTablePanel1.Controls.Add(this.label15, 0, 3);
			this.myTablePanel1.Controls.Add(this.label16, 0, 2);
			this.myTablePanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanel1.Location = new global::System.Drawing.Point(3, 3);
			this.myTablePanel1.Name = "myTablePanel1";
			this.myTablePanel1.RowCount = 4;
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.myTablePanel1.Size = new global::System.Drawing.Size(112, 104);
			this.myTablePanel1.TabIndex = 145;
			this.offsetBoots.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetBoots.Location = new global::System.Drawing.Point(60, 81);
			this.offsetBoots.Name = "offsetBoots";
			this.offsetBoots.Size = new global::System.Drawing.Size(43, 20);
			this.offsetBoots.TabIndex = 93;
			this.offsetBoots.Text = "0";
			this.offsetBoots.TextChanged += new global::System.EventHandler(this.offsetBoots_TextChanged);
			this.offsetPants.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetPants.Location = new global::System.Drawing.Point(60, 55);
			this.offsetPants.Name = "offsetPants";
			this.offsetPants.Size = new global::System.Drawing.Size(43, 20);
			this.offsetPants.TabIndex = 91;
			this.offsetPants.Text = "0";
			this.offsetPants.TextChanged += new global::System.EventHandler(this.offsetPants_TextChanged);
			this.offsetTool.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetTool.Location = new global::System.Drawing.Point(60, 29);
			this.offsetTool.Name = "offsetTool";
			this.offsetTool.Size = new global::System.Drawing.Size(43, 20);
			this.offsetTool.TabIndex = 99;
			this.offsetTool.Text = "0";
			this.offsetTool.TextChanged += new global::System.EventHandler(this.offsetTool_TextChanged);
			this.label4.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.FromArgb(128, 64, 0);
			this.label4.Location = new global::System.Drawing.Point(3, 32);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(36, 13);
			this.label4.TabIndex = 100;
			this.label4.Text = "TOOL";
			this.label9.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label9.AutoSize = true;
			this.label9.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.label9.Location = new global::System.Drawing.Point(3, 6);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(51, 13);
			this.label9.TabIndex = 95;
			this.label9.Text = "HELMET";
			this.offsetHelmet.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.offsetHelmet.Location = new global::System.Drawing.Point(60, 3);
			this.offsetHelmet.Name = "offsetHelmet";
			this.offsetHelmet.Size = new global::System.Drawing.Size(43, 20);
			this.offsetHelmet.TabIndex = 94;
			this.offsetHelmet.Text = "0";
			this.offsetHelmet.TextChanged += new global::System.EventHandler(this.offsetHelmet_TextChanged);
			this.label15.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label15.AutoSize = true;
			this.label15.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label15.Location = new global::System.Drawing.Point(3, 84);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(44, 13);
			this.label15.TabIndex = 98;
			this.label15.Text = "BOOTS";
			this.label16.Anchor = global::System.Windows.Forms.AnchorStyles.Left;
			this.label16.AutoSize = true;
			this.label16.ForeColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.label16.Location = new global::System.Drawing.Point(3, 58);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(43, 13);
			this.label16.TabIndex = 96;
			this.label16.Text = "PANTS";
			this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(3, 556);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(38, 13);
			this.label6.TabIndex = 137;
			this.label6.Text = "Parent";
			this.comboParent.FormattingEnabled = true;
			this.comboParent.Items.AddRange(new object[]
			{
				"HEAD",
				"BODY",
				"ARM0",
				"ARM1",
				"LEG0",
				"LEG1"
			});
			this.comboParent.Location = new global::System.Drawing.Point(3, 572);
			this.comboParent.Name = "comboParent";
			this.comboParent.Size = new global::System.Drawing.Size(114, 21);
			this.comboParent.TabIndex = 134;
			this.comboParent.SelectedValueChanged += new global::System.EventHandler(this.comboParent_SelectedIndexChanged);
			this.labelModeParts.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.labelModeParts.AutoSize = true;
			this.labelModeParts.ForeColor = global::System.Drawing.Color.White;
			this.labelModeParts.Location = new global::System.Drawing.Point(3, 14);
			this.labelModeParts.Name = "labelModeParts";
			this.labelModeParts.Size = new global::System.Drawing.Size(63, 13);
			this.labelModeParts.TabIndex = 133;
			this.labelModeParts.Text = "Model Parts";
			this.listViewBoxes.Activation = global::System.Windows.Forms.ItemActivation.OneClick;
			this.listViewBoxes.ContextMenuStrip = this.contextMenuStrip1;
			this.listViewBoxes.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewBoxes.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.listViewBoxes.HideSelection = false;
			this.listViewBoxes.LabelEdit = true;
			this.listViewBoxes.Location = new global::System.Drawing.Point(3, 30);
			this.listViewBoxes.MultiSelect = false;
			this.listViewBoxes.Name = "listViewBoxes";
			this.tableLayoutPanelMain.SetRowSpan(this.listViewBoxes, 14);
			this.listViewBoxes.Size = new global::System.Drawing.Size(121, 346);
			this.listViewBoxes.TabIndex = 132;
			this.listViewBoxes.UseCompatibleStateImageBehavior = false;
			this.listViewBoxes.View = global::System.Windows.Forms.View.Details;
			this.listViewBoxes.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listViewBoxes.Click += new global::System.EventHandler(this.listView1_Click);
			this.listViewBoxes.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick_1);
			this.listViewBoxes.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.delStuffUsingDelKey);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.createToolStripMenuItem,
				this.cloneToolStripMenuItem,
				this.deleteToolStripMenuItem,
				this.changeColorToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(152, 108);
			this.createToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("createToolStripMenuItem.Image");
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new global::System.Drawing.Size(151, 26);
			this.createToolStripMenuItem.Text = "Create";
			this.createToolStripMenuItem.Click += new global::System.EventHandler(this.createToolStripMenuItem_Click);
			this.cloneToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("cloneToolStripMenuItem.Image");
			this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
			this.cloneToolStripMenuItem.Size = new global::System.Drawing.Size(151, 26);
			this.cloneToolStripMenuItem.Text = "Clone";
			this.cloneToolStripMenuItem.Click += new global::System.EventHandler(this.cloneToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteToolStripMenuItem.Image");
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(151, 26);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			this.changeColorToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("changeColorToolStripMenuItem.Image");
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
			this.changeColorToolStripMenuItem.Size = new global::System.Drawing.Size(151, 26);
			this.changeColorToolStripMenuItem.Text = "Change Color";
			this.changeColorToolStripMenuItem.Click += new global::System.EventHandler(this.changeColorToolStripMenuItem_Click);
			this.labelFullSkinPreview.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.labelFullSkinPreview.AutoSize = true;
			this.labelFullSkinPreview.ForeColor = global::System.Drawing.Color.White;
			this.labelFullSkinPreview.Location = new global::System.Drawing.Point(130, 14);
			this.labelFullSkinPreview.Name = "labelFullSkinPreview";
			this.labelFullSkinPreview.Size = new global::System.Drawing.Size(88, 13);
			this.labelFullSkinPreview.TabIndex = 141;
			this.labelFullSkinPreview.Text = "Full Skin Preview";
			this.label3.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label3.AutoSize = true;
			this.tableLayoutPanelMain.SetColumnSpan(this.label3, 2);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(578, 214);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(27, 13);
			this.label3.TabIndex = 142;
			this.label3.Text = "Size";
			this.checkBoxArmor.AutoSize = true;
			this.checkBoxArmor.ForeColor = global::System.Drawing.Color.White;
			this.checkBoxArmor.Location = new global::System.Drawing.Point(382, 601);
			this.checkBoxArmor.Name = "checkBoxArmor";
			this.checkBoxArmor.Size = new global::System.Drawing.Size(119, 17);
			this.checkBoxArmor.TabIndex = 143;
			this.checkBoxArmor.Text = "Show Armor Offsets";
			this.checkBoxArmor.UseVisualStyleBackColor = true;
			this.checkBoxArmor.Click += new global::System.EventHandler(this.checkBoxArmor_Click);
			this.labelTheme.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.labelTheme.AutoSize = true;
			this.labelTheme.ForeColor = global::System.Drawing.Color.White;
			this.labelTheme.Location = new global::System.Drawing.Point(3, 395);
			this.labelTheme.Name = "labelTheme";
			this.labelTheme.Size = new global::System.Drawing.Size(65, 13);
			this.labelTheme.TabIndex = 144;
			this.labelTheme.Text = "Background";
			this.listViewBGs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.listViewBGs.Items.AddRange(new global::System.Windows.Forms.ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4,
				listViewItem5,
				listViewItem6,
				listViewItem7,
				listViewItem8
			});
			this.listViewBGs.Location = new global::System.Drawing.Point(3, 411);
			this.listViewBGs.Name = "listViewBGs";
			this.listViewBGs.Size = new global::System.Drawing.Size(121, 142);
			this.listViewBGs.TabIndex = 145;
			this.listViewBGs.UseCompatibleStateImageBehavior = false;
			this.listViewBGs.SelectedIndexChanged += new global::System.EventHandler(this.listViewBGs_SelectedIndexChanged);
			this.listViewBGs.Click += new global::System.EventHandler(this.listViewBGs_Click);
			this.tableLayoutPanelMain.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanelMain.ColumnCount = 11;
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 31.25f));
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 43.75f));
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanelMain.Controls.Add(this.labelModeParts, 0, 0);
			this.tableLayoutPanelMain.Controls.Add(this.listViewBoxes, 0, 1);
			this.tableLayoutPanelMain.Controls.Add(this.buttonExportModel, 3, 0);
			this.tableLayoutPanelMain.Controls.Add(this.displayBox, 1, 1);
			this.tableLayoutPanelMain.Controls.Add(this.buttonImportModel, 2, 0);
			this.tableLayoutPanelMain.Controls.Add(this.labelFullSkinPreview, 1, 0);
			this.tableLayoutPanelMain.Controls.Add(this.labelTextureMappingPreview, 5, 0);
			this.tableLayoutPanelMain.Controls.Add(this.texturePreview, 5, 1);
			this.tableLayoutPanelMain.Controls.Add(this.buttonIMPORT, 5, 6);
			this.tableLayoutPanelMain.Controls.Add(this.label7, 5, 7);
			this.tableLayoutPanelMain.Controls.Add(this.buttonEXPORT, 8, 6);
			this.tableLayoutPanelMain.Controls.Add(this.textTextureY, 6, 7);
			this.tableLayoutPanelMain.Controls.Add(this.textTextureX, 8, 7);
			this.tableLayoutPanelMain.Controls.Add(this.label3, 5, 8);
			this.tableLayoutPanelMain.Controls.Add(this.buttonXfplus, 5, 9);
			this.tableLayoutPanelMain.Controls.Add(this.textXf, 5, 10);
			this.tableLayoutPanelMain.Controls.Add(this.buttonXfminus, 5, 11);
			this.tableLayoutPanelMain.Controls.Add(this.label5, 5, 12);
			this.tableLayoutPanelMain.Controls.Add(this.buttonXcplus, 5, 13);
			this.tableLayoutPanelMain.Controls.Add(this.textXc, 5, 14);
			this.tableLayoutPanelMain.Controls.Add(this.buttonXcminus, 5, 15);
			this.tableLayoutPanelMain.Controls.Add(this.buttonYfplus, 7, 9);
			this.tableLayoutPanelMain.Controls.Add(this.textYf, 7, 10);
			this.tableLayoutPanelMain.Controls.Add(this.buttonYfminus, 7, 11);
			this.tableLayoutPanelMain.Controls.Add(this.buttonYcplus, 7, 13);
			this.tableLayoutPanelMain.Controls.Add(this.textYc, 7, 14);
			this.tableLayoutPanelMain.Controls.Add(this.buttonYcminus, 7, 15);
			this.tableLayoutPanelMain.Controls.Add(this.buttonZfplus, 9, 9);
			this.tableLayoutPanelMain.Controls.Add(this.textZf, 9, 10);
			this.tableLayoutPanelMain.Controls.Add(this.buttonZfminus, 9, 11);
			this.tableLayoutPanelMain.Controls.Add(this.buttonZcplus, 9, 13);
			this.tableLayoutPanelMain.Controls.Add(this.textZc, 9, 14);
			this.tableLayoutPanelMain.Controls.Add(this.buttonZcminus, 9, 15);
			this.tableLayoutPanelMain.Controls.Add(this.comboParent, 0, 18);
			this.tableLayoutPanelMain.Controls.Add(this.label6, 0, 17);
			this.tableLayoutPanelMain.Controls.Add(this.buttonTemplate, 0, 19);
			this.tableLayoutPanelMain.Controls.Add(this.groupBox1, 5, 16);
			this.tableLayoutPanelMain.Controls.Add(this.labelTheme, 0, 15);
			this.tableLayoutPanelMain.Controls.Add(this.listViewBGs, 0, 16);
			this.tableLayoutPanelMain.Controls.Add(this.button2, 1, 18);
			this.tableLayoutPanelMain.Controls.Add(this.button1, 3, 18);
			this.tableLayoutPanelMain.Controls.Add(this.labelView, 2, 18);
			this.tableLayoutPanelMain.Controls.Add(this.checkGuide, 1, 19);
			this.tableLayoutPanelMain.Controls.Add(this.checkTextureGenerate, 2, 19);
			this.tableLayoutPanelMain.Controls.Add(this.checkBoxArmor, 3, 19);
			this.tableLayoutPanelMain.Controls.Add(this.buttonDone, 8, 19);
			this.tableLayoutPanelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelMain.Location = new global::System.Drawing.Point(20, 60);
			this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
			this.tableLayoutPanelMain.RowCount = 20;
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.tableLayoutPanelMain.Size = new global::System.Drawing.Size(713, 627);
			this.tableLayoutPanelMain.TabIndex = 144;
			this.displayBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanelMain.SetColumnSpan(this.displayBox, 3);
			this.displayBox.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.displayBox.Image = global::minekampf.Properties.Resources.bg2;
			this.displayBox.Location = new global::System.Drawing.Point(130, 30);
			this.displayBox.Name = "displayBox";
			this.tableLayoutPanelMain.SetRowSpan(this.displayBox, 17);
			this.displayBox.Size = new global::System.Drawing.Size(442, 536);
			this.displayBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.displayBox.TabIndex = 98;
			this.displayBox.TabStop = false;
			this.texturePreview.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanelMain.SetColumnSpan(this.texturePreview, 6);
			this.texturePreview.Location = new global::System.Drawing.Point(578, 30);
			this.texturePreview.Name = "texturePreview";
			this.tableLayoutPanelMain.SetRowSpan(this.texturePreview, 5);
			this.texturePreview.Size = new global::System.Drawing.Size(128, 128);
			this.texturePreview.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.texturePreview.TabIndex = 112;
			this.texturePreview.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(753, 707);
			base.Controls.Add(this.tableLayoutPanelMain);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(1114, 1000);
			this.MinimumSize = new global::System.Drawing.Size(753, 707);
			base.Name = "generateModel";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Model Generator";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.generateModel_FormClosing);
			base.Load += new global::System.EventHandler(this.generateModel_Load);
			base.ResizeBegin += new global::System.EventHandler(this.generateModel_ResizeBegin);
			base.ResizeEnd += new global::System.EventHandler(this.generateModel_ResizeEnd);
			base.SizeChanged += new global::System.EventHandler(this.generateModel_SizeChanged);
			this.groupBox1.ResumeLayout(false);
			this.tabBody.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.myTablePanel2.ResumeLayout(false);
			this.myTablePanel2.PerformLayout();
			this.tabArmor.ResumeLayout(false);
			this.myTablePanel1.ResumeLayout(false);
			this.myTablePanel1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.tableLayoutPanelMain.ResumeLayout(false);
			this.tableLayoutPanelMain.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.texturePreview).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400028F RID: 655
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.Button buttonImportModel;

		// Token: 0x04000291 RID: 657
		private global::System.Windows.Forms.Button buttonExportModel;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.PictureBox displayBox;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.CheckBox checkTextureGenerate;

		// Token: 0x04000294 RID: 660
		private global::System.Windows.Forms.CheckBox checkGuide;

		// Token: 0x04000295 RID: 661
		private global::System.Windows.Forms.Label labelView;

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000297 RID: 663
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000298 RID: 664
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.TextBox textTextureY;

		// Token: 0x0400029A RID: 666
		private global::System.Windows.Forms.TextBox textTextureX;

		// Token: 0x0400029B RID: 667
		private global::System.Windows.Forms.Button buttonIMPORT;

		// Token: 0x0400029C RID: 668
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400029D RID: 669
		private global::System.Windows.Forms.Button buttonZcplus;

		// Token: 0x0400029E RID: 670
		private global::System.Windows.Forms.Button buttonXcminus;

		// Token: 0x0400029F RID: 671
		private global::System.Windows.Forms.Button buttonYcminus;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.Button buttonZcminus;

		// Token: 0x040002A1 RID: 673
		private global::System.Windows.Forms.Button buttonYcplus;

		// Token: 0x040002A2 RID: 674
		private global::System.Windows.Forms.Button buttonXcplus;

		// Token: 0x040002A3 RID: 675
		private global::System.Windows.Forms.Button buttonZfplus;

		// Token: 0x040002A4 RID: 676
		private global::System.Windows.Forms.Button buttonXfminus;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Forms.Button buttonYfminus;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Forms.Button buttonZfminus;

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Forms.Button buttonYfplus;

		// Token: 0x040002A8 RID: 680
		private global::System.Windows.Forms.Button buttonXfplus;

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Forms.Button buttonEXPORT;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Forms.Label labelTextureMappingPreview;

		// Token: 0x040002AB RID: 683
		private global::System.Windows.Forms.PictureBox texturePreview;

		// Token: 0x040002AC RID: 684
		private global::System.Windows.Forms.Button buttonDone;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Forms.TextBox textYc;

		// Token: 0x040002AE RID: 686
		private global::System.Windows.Forms.TextBox textZc;

		// Token: 0x040002AF RID: 687
		private global::System.Windows.Forms.TextBox textXf;

		// Token: 0x040002B0 RID: 688
		private global::System.Windows.Forms.TextBox textYf;

		// Token: 0x040002B1 RID: 689
		private global::System.Windows.Forms.TextBox textZf;

		// Token: 0x040002B2 RID: 690
		private global::System.Windows.Forms.TextBox textXc;

		// Token: 0x040002B3 RID: 691
		private global::System.Windows.Forms.Button buttonTemplate;

		// Token: 0x040002B4 RID: 692
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040002B5 RID: 693
		private global::System.Windows.Forms.TextBox offsetBody;

		// Token: 0x040002B6 RID: 694
		private global::System.Windows.Forms.Label label14;

		// Token: 0x040002B7 RID: 695
		private global::System.Windows.Forms.TextBox offsetLegs;

		// Token: 0x040002B8 RID: 696
		private global::System.Windows.Forms.Label label13;

		// Token: 0x040002B9 RID: 697
		private global::System.Windows.Forms.TextBox offsetArms;

		// Token: 0x040002BA RID: 698
		private global::System.Windows.Forms.Label label12;

		// Token: 0x040002BB RID: 699
		private global::System.Windows.Forms.TextBox offsetHead;

		// Token: 0x040002BC RID: 700
		private global::System.Windows.Forms.Label label10;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040002BE RID: 702
		private global::System.Windows.Forms.ComboBox comboParent;

		// Token: 0x040002BF RID: 703
		private global::System.Windows.Forms.Label labelModeParts;

		// Token: 0x040002C0 RID: 704
		private global::System.Windows.Forms.ListView listViewBoxes;

		// Token: 0x040002C1 RID: 705
		private global::System.Windows.Forms.Label labelFullSkinPreview;

		// Token: 0x040002C2 RID: 706
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002C3 RID: 707
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040002C4 RID: 708
		private global::System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;

		// Token: 0x040002C5 RID: 709
		private global::System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x040002C7 RID: 711
		private global::System.Windows.Forms.TabControl tabBody;

		// Token: 0x040002C8 RID: 712
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040002C9 RID: 713
		private global::System.Windows.Forms.TabPage tabArmor;

		// Token: 0x040002CA RID: 714
		private global::System.Windows.Forms.CheckBox checkBoxArmor;

		// Token: 0x040002CB RID: 715
		private global::System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;

		// Token: 0x040002CC RID: 716
		private global::System.Windows.Forms.TextBox offsetPants;

		// Token: 0x040002CD RID: 717
		private global::System.Windows.Forms.Label label9;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040002CF RID: 719
		private global::System.Windows.Forms.TextBox offsetHelmet;

		// Token: 0x040002D0 RID: 720
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040002D1 RID: 721
		private global::System.Windows.Forms.TextBox offsetBoots;

		// Token: 0x040002D2 RID: 722
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040002D3 RID: 723
		private global::System.Windows.Forms.TextBox offsetTool;

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Forms.Label labelTheme;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.ListView listViewBGs;

		// Token: 0x040002D6 RID: 726
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;

		// Token: 0x040002D7 RID: 727
		private global::minekampf.Forms.MyTablePanel myTablePanel2;

		// Token: 0x040002D8 RID: 728
		private global::minekampf.Forms.MyTablePanel myTablePanel1;
	}
}
