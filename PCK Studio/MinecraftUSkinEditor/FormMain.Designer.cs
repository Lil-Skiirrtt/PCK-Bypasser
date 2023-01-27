namespace MinecraftUSkinEditor
{
	// Token: 0x02000082 RID: 130
	public partial class FormMain : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000250 RID: 592 RVA: 0x00003C4A File Offset: 0x00001E4A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00036CDC File Offset: 0x00034EDC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.FormMain));
			this.contextMenuPCKEntries = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.createToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.folderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.skinToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.createAnimatedTextureToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importSkinsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importSkinToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importExtractedSkinsFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.importFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.extractToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.moveUpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.moveDownToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new global::System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.extractToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.metaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.advancedMetaAddingToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.convertToBedrockToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.programInfoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.binkaConversionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.tutorialsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.installationToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.fAQToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.donateToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.storeToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.wiiUPCKInstallerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new global::System.Windows.Forms.Label();
			this.contextMenuMetaTree = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.addPresetToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.addEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteEntryToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.labelVersion = new global::System.Windows.Forms.Label();
			this.backgroundWorker1 = new global::System.ComponentModel.BackgroundWorker();
			this.directorySearcher1 = new global::System.DirectoryServices.DirectorySearcher();
			this.openedPCKS = new global::MetroFramework.Controls.MetroTabControl();
			this.tabPage1 = new global::MetroFramework.Controls.MetroTabPage();
			this.myTablePanelPckEdit = new global::minekampf.Forms.MyTablePanel();
			this.treeViewMain = new global::System.Windows.Forms.TreeView();
			this.pictureBoxImagePreview = new global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode();
			this.labelAmount = new global::System.Windows.Forms.Label();
			this.tabDataDisplay = new global::System.Windows.Forms.TabControl();
			this.tabMetaDisplay = new global::System.Windows.Forms.TabPage();
			this.myTablePanel1 = new global::minekampf.Forms.MyTablePanel();
			this.treeMeta = new global::System.Windows.Forms.TreeView();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.labelEntryType = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.labelEntryData = new global::System.Windows.Forms.Label();
			this.buttonEdit = new global::System.Windows.Forms.Button();
			this.labelImageSize = new global::System.Windows.Forms.Label();
			this.myTablePanelStartScreen = new global::minekampf.Forms.MyTablePanel();
			this.richTextBoxChangelog = new global::System.Windows.Forms.RichTextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.pckOpen = new global::System.Windows.Forms.PictureBox();
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.videosToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howToMakeABasicSkinPackToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howToMakeACustomSkinModelToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howPCKsWorkToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.pCKCenterReleaseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.howToMakeCustomMusicToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuPCKEntries.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.contextMenuMetaTree.SuspendLayout();
			this.openedPCKS.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.myTablePanelPckEdit.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxImagePreview).BeginInit();
			this.tabDataDisplay.SuspendLayout();
			this.tabMetaDisplay.SuspendLayout();
			this.myTablePanel1.SuspendLayout();
			this.myTablePanelStartScreen.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pckOpen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.contextMenuPCKEntries.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.createToolStripMenuItem,
				this.importSkinsToolStripMenuItem,
				this.extractToolStripMenuItem,
				this.replaceToolStripMenuItem,
				this.deleteFileToolStripMenuItem,
				this.moveUpToolStripMenuItem,
				this.moveDownToolStripMenuItem
			});
			this.contextMenuPCKEntries.Name = "contextMenuStrip1";
			this.contextMenuPCKEntries.Size = new global::System.Drawing.Size(139, 158);
			this.createToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.folderToolStripMenuItem,
				this.skinToolStripMenuItem,
				this.createAnimatedTextureToolStripMenuItem
			});
			this.createToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("createToolStripMenuItem.Image");
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.createToolStripMenuItem.Text = "Create";
			this.folderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("folderToolStripMenuItem.Image");
			this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
			this.folderToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.folderToolStripMenuItem.Text = "Folder";
			this.folderToolStripMenuItem.Click += new global::System.EventHandler(this.folderToolStripMenuItem_Click);
			this.skinToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("skinToolStripMenuItem.Image");
			this.skinToolStripMenuItem.Name = "skinToolStripMenuItem";
			this.skinToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.skinToolStripMenuItem.Text = "Skin";
			this.skinToolStripMenuItem.Click += new global::System.EventHandler(this.createSkinToolStripMenuItem_Click);
			this.createAnimatedTextureToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("createAnimatedTextureToolStripMenuItem.Image");
			this.createAnimatedTextureToolStripMenuItem.Name = "createAnimatedTextureToolStripMenuItem";
			this.createAnimatedTextureToolStripMenuItem.Size = new global::System.Drawing.Size(167, 22);
			this.createAnimatedTextureToolStripMenuItem.Text = "Animated Texture";
			this.createAnimatedTextureToolStripMenuItem.Click += new global::System.EventHandler(this.createAnimatedTextureToolStripMenuItem_Click);
			this.importSkinsToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.importSkinToolStripMenuItem,
				this.importExtractedSkinsFolderToolStripMenuItem,
				this.importFileToolStripMenuItem
			});
			this.importSkinsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("importSkinsToolStripMenuItem.Image");
			this.importSkinsToolStripMenuItem.Name = "importSkinsToolStripMenuItem";
			this.importSkinsToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.importSkinsToolStripMenuItem.Text = "Import";
			this.importSkinToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("importSkinToolStripMenuItem.Image");
			this.importSkinToolStripMenuItem.Name = "importSkinToolStripMenuItem";
			this.importSkinToolStripMenuItem.Size = new global::System.Drawing.Size(227, 22);
			this.importSkinToolStripMenuItem.Text = "Import Skin";
			this.importSkinToolStripMenuItem.Click += new global::System.EventHandler(this.importSkin);
			this.importExtractedSkinsFolderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("importExtractedSkinsFolderToolStripMenuItem.Image");
			this.importExtractedSkinsFolderToolStripMenuItem.Name = "importExtractedSkinsFolderToolStripMenuItem";
			this.importExtractedSkinsFolderToolStripMenuItem.Size = new global::System.Drawing.Size(227, 22);
			this.importExtractedSkinsFolderToolStripMenuItem.Text = "Import Extracted Skins Folder";
			this.importExtractedSkinsFolderToolStripMenuItem.Click += new global::System.EventHandler(this.importExtractedSkinsFolder);
			this.importFileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("importFileToolStripMenuItem.Image");
			this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
			this.importFileToolStripMenuItem.Size = new global::System.Drawing.Size(227, 22);
			this.importFileToolStripMenuItem.Text = "Import File";
			this.importFileToolStripMenuItem.Click += new global::System.EventHandler(this.addFileToolStripMenuItem_Click);
			this.extractToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("extractToolStripMenuItem.Image");
			this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
			this.extractToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.extractToolStripMenuItem.Text = "Extract";
			this.extractToolStripMenuItem.Click += new global::System.EventHandler(this.extractToolStripMenuItem_Click);
			this.replaceToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("replaceToolStripMenuItem.Image");
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.replaceToolStripMenuItem.Text = "Replace";
			this.replaceToolStripMenuItem.Click += new global::System.EventHandler(this.replaceToolStripMenuItem_Click);
			this.deleteFileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteFileToolStripMenuItem.Image");
			this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
			this.deleteFileToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.deleteFileToolStripMenuItem.Text = "Delete";
			this.deleteFileToolStripMenuItem.Click += new global::System.EventHandler(this.deleteFileToolStripMenuItem_Click);
			this.moveUpToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("moveUpToolStripMenuItem.Image");
			this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
			this.moveUpToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.moveUpToolStripMenuItem.Text = "Move Up";
			this.moveUpToolStripMenuItem.Click += new global::System.EventHandler(this.moveUpToolStripMenuItem_Click);
			this.moveDownToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("moveDownToolStripMenuItem.Image");
			this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
			this.moveDownToolStripMenuItem.Size = new global::System.Drawing.Size(138, 22);
			this.moveDownToolStripMenuItem.Text = "Move Down";
			this.moveDownToolStripMenuItem.Click += new global::System.EventHandler(this.moveDownToolStripMenuItem_Click);
			this.menuStrip.AutoSize = false;
			this.menuStrip.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.menuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.fileToolStripMenuItem,
				this.editToolStripMenuItem,
				this.videosToolStripMenuItem,
				this.helpToolStripMenuItem,
				this.storeToolStripMenuItem
			});
			this.menuStrip.Location = new global::System.Drawing.Point(20, 60);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new global::System.Drawing.Size(778, 24);
			this.menuStrip.TabIndex = 2;
			this.menuStrip.Text = "menuStrip1";
			this.fileToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.newToolStripMenuItem,
				this.openToolStripMenuItem,
				this.extractToolStripMenuItem1,
				this.saveToolStripMenuItem1,
				this.saveToolStripMenuItem,
				this.metaToolStripMenuItem
			});
			this.fileToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			this.newToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("newToolStripMenuItem.Image");
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new global::System.EventHandler(this.skinPackToolStripMenuItem_Click);
			this.openToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("openToolStripMenuItem.Image");
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new global::System.EventHandler(this.openToolStripMenuItem_Click);
			this.extractToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("extractToolStripMenuItem1.Image");
			this.extractToolStripMenuItem1.Name = "extractToolStripMenuItem1";
			this.extractToolStripMenuItem1.Size = new global::System.Drawing.Size(114, 22);
			this.extractToolStripMenuItem1.Text = "Extract";
			this.extractToolStripMenuItem1.Click += new global::System.EventHandler(this.extractToolStripMenuItem1_Click);
			this.saveToolStripMenuItem1.Enabled = false;
			this.saveToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("saveToolStripMenuItem1.Image");
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new global::System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new global::System.EventHandler(this.savePCK);
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.saveToolStripMenuItem.Text = "Save As";
			this.saveToolStripMenuItem.Click += new global::System.EventHandler(this.saveAsPCK);
			this.metaToolStripMenuItem.Enabled = false;
			this.metaToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("metaToolStripMenuItem.Image");
			this.metaToolStripMenuItem.Name = "metaToolStripMenuItem";
			this.metaToolStripMenuItem.Size = new global::System.Drawing.Size(114, 22);
			this.metaToolStripMenuItem.Text = "Meta";
			this.metaToolStripMenuItem.Click += new global::System.EventHandler(this.metaToolStripMenuItem_Click);
			this.editToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.advancedMetaAddingToolStripMenuItem,
				this.convertToBedrockToolStripMenuItem
			});
			this.editToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new global::System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			this.advancedMetaAddingToolStripMenuItem.Enabled = false;
			this.advancedMetaAddingToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("advancedMetaAddingToolStripMenuItem.Image");
			this.advancedMetaAddingToolStripMenuItem.Name = "advancedMetaAddingToolStripMenuItem";
			this.advancedMetaAddingToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.advancedMetaAddingToolStripMenuItem.Text = "Advanced Bulk";
			this.advancedMetaAddingToolStripMenuItem.Click += new global::System.EventHandler(this.advancedMetaAddingToolStripMenuItem_Click);
			this.convertToBedrockToolStripMenuItem.Enabled = false;
			this.convertToBedrockToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("convertToBedrockToolStripMenuItem.Image");
			this.convertToBedrockToolStripMenuItem.Name = "convertToBedrockToolStripMenuItem";
			this.convertToBedrockToolStripMenuItem.Size = new global::System.Drawing.Size(176, 22);
			this.convertToBedrockToolStripMenuItem.Text = "Convert to Bedrock";
			this.convertToBedrockToolStripMenuItem.Click += new global::System.EventHandler(this.convertToBedrockToolStripMenuItem_Click);
			this.helpToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.programInfoToolStripMenuItem,
				this.binkaConversionToolStripMenuItem,
				this.tutorialsToolStripMenuItem,
				this.installationToolStripMenuItem,
				this.fAQToolStripMenuItem1,
				this.donateToolStripMenuItem
			});
			this.helpToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.programInfoToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("programInfoToolStripMenuItem.Image");
			this.programInfoToolStripMenuItem.Name = "programInfoToolStripMenuItem";
			this.programInfoToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
			this.programInfoToolStripMenuItem.Text = "Program Info";
			this.programInfoToolStripMenuItem.Click += new global::System.EventHandler(this.programInfoToolStripMenuItem_Click);
			this.binkaConversionToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("binkaConversionToolStripMenuItem.Image");
			this.binkaConversionToolStripMenuItem.Name = "binkaConversionToolStripMenuItem";
			this.binkaConversionToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
			this.binkaConversionToolStripMenuItem.Text = "Binka Conversion";
			this.binkaConversionToolStripMenuItem.Click += new global::System.EventHandler(this.binkaConversionToolStripMenuItem_Click);
			this.tutorialsToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.tutorialsToolStripMenuItem.Name = "tutorialsToolStripMenuItem";
			this.tutorialsToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
			this.tutorialsToolStripMenuItem.Text = "Tutorials";
			this.tutorialsToolStripMenuItem.Click += new global::System.EventHandler(this.tutorialsToolStripMenuItem_Click);
			this.installationToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("installationToolStripMenuItem.Image");
			this.installationToolStripMenuItem.Name = "installationToolStripMenuItem";
			this.installationToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
			this.installationToolStripMenuItem.Text = "Installation";
			this.installationToolStripMenuItem.Click += new global::System.EventHandler(this.installationToolStripMenuItem_Click);
			this.fAQToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("fAQToolStripMenuItem1.Image");
			this.fAQToolStripMenuItem1.Name = "fAQToolStripMenuItem1";
			this.fAQToolStripMenuItem1.Size = new global::System.Drawing.Size(166, 22);
			this.fAQToolStripMenuItem1.Text = "FAQ";
			this.fAQToolStripMenuItem1.Click += new global::System.EventHandler(this.fAQToolStripMenuItem1_Click);
			this.donateToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("donateToolStripMenuItem.Image");
			this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
			this.donateToolStripMenuItem.Size = new global::System.Drawing.Size(166, 22);
			this.donateToolStripMenuItem.Text = "Donate";
			this.donateToolStripMenuItem.Click += new global::System.EventHandler(this.donateToolStripMenuItem_Click);
			this.storeToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openToolStripMenuItem1,
				this.wiiUPCKInstallerToolStripMenuItem
			});
			this.storeToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.storeToolStripMenuItem.Image = global::minekampf.Properties.Resources.MROE;
			this.storeToolStripMenuItem.Name = "storeToolStripMenuItem";
			this.storeToolStripMenuItem.Size = new global::System.Drawing.Size(63, 20);
			this.storeToolStripMenuItem.Text = "More";
			this.openToolStripMenuItem1.Image = global::minekampf.Properties.Resources.pckCenterHeader;
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.Size = new global::System.Drawing.Size(171, 22);
			this.openToolStripMenuItem1.Text = "Open PCK Center";
			this.openToolStripMenuItem1.Click += new global::System.EventHandler(this.openToolStripMenuItem1_Click);
			this.wiiUPCKInstallerToolStripMenuItem.Image = global::minekampf.Properties.Resources.wii_u_games_tool;
			this.wiiUPCKInstallerToolStripMenuItem.Name = "wiiUPCKInstallerToolStripMenuItem";
			this.wiiUPCKInstallerToolStripMenuItem.Size = new global::System.Drawing.Size(171, 22);
			this.wiiUPCKInstallerToolStripMenuItem.Text = "Wii U PCK Installer";
			this.wiiUPCKInstallerToolStripMenuItem.Click += new global::System.EventHandler(this.wiiUPCKInstallerToolStripMenuItem_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(428, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 13);
			this.label1.TabIndex = 3;
			this.contextMenuMetaTree.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.addPresetToolStripMenuItem1,
				this.addEntryToolStripMenuItem,
				this.deleteEntryToolStripMenuItem
			});
			this.contextMenuMetaTree.Name = "contextMenuStrip1";
			this.contextMenuMetaTree.Size = new global::System.Drawing.Size(138, 70);
			this.addPresetToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("addPresetToolStripMenuItem1.Image");
			this.addPresetToolStripMenuItem1.Name = "addPresetToolStripMenuItem1";
			this.addPresetToolStripMenuItem1.Size = new global::System.Drawing.Size(137, 22);
			this.addPresetToolStripMenuItem1.Text = "Add Preset";
			this.addPresetToolStripMenuItem1.Click += new global::System.EventHandler(this.addPresetToolStripMenuItem1_Click);
			this.addEntryToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("addEntryToolStripMenuItem.Image");
			this.addEntryToolStripMenuItem.Name = "addEntryToolStripMenuItem";
			this.addEntryToolStripMenuItem.Size = new global::System.Drawing.Size(137, 22);
			this.addEntryToolStripMenuItem.Text = "Add Entry";
			this.addEntryToolStripMenuItem.Click += new global::System.EventHandler(this.addEntryToolStripMenuItem_Click_1);
			this.deleteEntryToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("deleteEntryToolStripMenuItem.Image");
			this.deleteEntryToolStripMenuItem.Name = "deleteEntryToolStripMenuItem";
			this.deleteEntryToolStripMenuItem.Size = new global::System.Drawing.Size(137, 22);
			this.deleteEntryToolStripMenuItem.Text = "Delete Entry";
			this.deleteEntryToolStripMenuItem.Click += new global::System.EventHandler(this.deleteEntryToolStripMenuItem_Click);
			this.labelVersion.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelVersion.AutoSize = true;
			this.labelVersion.ForeColor = global::System.Drawing.Color.White;
			this.labelVersion.Location = new global::System.Drawing.Point(722, 588);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new global::System.Drawing.Size(64, 13);
			this.labelVersion.TabIndex = 11;
			this.labelVersion.Text = "PCK Bypasser ";
			this.directorySearcher1.ClientTimeout = global::System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerPageTimeLimit = global::System.TimeSpan.Parse("-00:00:01");
			this.directorySearcher1.ServerTimeLimit = global::System.TimeSpan.Parse("-00:00:01");
			this.openedPCKS.Controls.Add(this.tabPage1);
			this.openedPCKS.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.openedPCKS.Location = new global::System.Drawing.Point(20, 84);
			this.openedPCKS.Margin = new global::System.Windows.Forms.Padding(0);
			this.openedPCKS.Name = "openedPCKS";
			this.openedPCKS.SelectedIndex = 0;
			this.openedPCKS.Size = new global::System.Drawing.Size(778, 498);
			this.openedPCKS.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.openedPCKS.Style = global::MetroFramework.MetroColorStyle.White;
			this.openedPCKS.TabIndex = 0;
			this.openedPCKS.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.openedPCKS.UseSelectable = true;
			this.openedPCKS.Visible = false;
			this.tabPage1.BackColor = global::System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.myTablePanelPckEdit);
			this.tabPage1.Controls.Add(this.labelImageSize);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.HorizontalScrollbarBarColor = true;
			this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
			this.tabPage1.HorizontalScrollbarSize = 0;
			this.tabPage1.Location = new global::System.Drawing.Point(4, 38);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new global::System.Drawing.Size(770, 456);
			this.tabPage1.Style = global::MetroFramework.MetroColorStyle.White;
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "                                                                    ";
			this.tabPage1.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			this.tabPage1.VerticalScrollbarBarColor = true;
			this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
			this.tabPage1.VerticalScrollbarSize = 0;
			this.myTablePanelPckEdit.ColumnCount = 3;
			this.myTablePanelPckEdit.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 200f));
			this.myTablePanelPckEdit.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.myTablePanelPckEdit.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle());
			this.myTablePanelPckEdit.Controls.Add(this.treeViewMain, 0, 0);
			this.myTablePanelPckEdit.Controls.Add(this.pictureBoxImagePreview, 1, 0);
			this.myTablePanelPckEdit.Controls.Add(this.labelAmount, 2, 0);
			this.myTablePanelPckEdit.Controls.Add(this.tabDataDisplay, 1, 4);
			this.myTablePanelPckEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanelPckEdit.Location = new global::System.Drawing.Point(0, 0);
			this.myTablePanelPckEdit.Margin = new global::System.Windows.Forms.Padding(0);
			this.myTablePanelPckEdit.Name = "myTablePanelPckEdit";
			this.myTablePanelPckEdit.RowCount = 4;
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanelPckEdit.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.myTablePanelPckEdit.Size = new global::System.Drawing.Size(770, 456);
			this.myTablePanelPckEdit.TabIndex = 16;
			this.treeViewMain.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.treeViewMain.ContextMenuStrip = this.contextMenuPCKEntries;
			this.treeViewMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeViewMain.ForeColor = global::System.Drawing.Color.White;
			this.treeViewMain.LabelEdit = true;
			this.treeViewMain.Location = new global::System.Drawing.Point(0, 0);
			this.treeViewMain.Margin = new global::System.Windows.Forms.Padding(0);
			this.treeViewMain.Name = "treeViewMain";
			this.myTablePanelPckEdit.SetRowSpan(this.treeViewMain, 6);
			this.treeViewMain.Size = new global::System.Drawing.Size(200, 456);
			this.treeViewMain.TabIndex = 9;
			this.treeViewMain.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.selectNode);
			this.treeViewMain.DoubleClick += new global::System.EventHandler(this.treeView1_DoubleClick);
			this.treeViewMain.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.treeViewMain_KeyDown);
			this.pictureBoxImagePreview.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBoxImagePreview.Image");
			this.pictureBoxImagePreview.InterpolationMode = global::System.Drawing.Drawing2D.InterpolationMode.Default;
			this.pictureBoxImagePreview.Location = new global::System.Drawing.Point(203, 3);
			this.pictureBoxImagePreview.MinimumSize = new global::System.Drawing.Size(157, 157);
			this.pictureBoxImagePreview.Name = "pictureBoxImagePreview";
			this.myTablePanelPckEdit.SetRowSpan(this.pictureBoxImagePreview, 4);
			this.pictureBoxImagePreview.Size = new global::System.Drawing.Size(157, 157);
			this.pictureBoxImagePreview.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImagePreview.TabIndex = 8;
			this.pictureBoxImagePreview.TabStop = false;
			this.labelAmount.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelAmount.AutoSize = true;
			this.labelAmount.ForeColor = global::System.Drawing.Color.White;
			this.labelAmount.Location = new global::System.Drawing.Point(724, 0);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new global::System.Drawing.Size(43, 17);
			this.labelAmount.TabIndex = 18;
			this.labelAmount.Text = "Entries:";
			this.labelAmount.UseCompatibleTextRendering = true;
			this.labelAmount.Visible = false;
			this.myTablePanelPckEdit.SetColumnSpan(this.tabDataDisplay, 2);
			this.tabDataDisplay.Controls.Add(this.tabMetaDisplay);
			this.tabDataDisplay.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tabDataDisplay.Location = new global::System.Drawing.Point(200, 163);
			this.tabDataDisplay.Margin = new global::System.Windows.Forms.Padding(0);
			this.tabDataDisplay.Name = "tabDataDisplay";
			this.myTablePanelPckEdit.SetRowSpan(this.tabDataDisplay, 2);
			this.tabDataDisplay.SelectedIndex = 0;
			this.tabDataDisplay.Size = new global::System.Drawing.Size(570, 293);
			this.tabDataDisplay.TabIndex = 10;
			this.tabMetaDisplay.BackColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.tabMetaDisplay.Controls.Add(this.myTablePanel1);
			this.tabMetaDisplay.Location = new global::System.Drawing.Point(4, 22);
			this.tabMetaDisplay.Name = "tabMetaDisplay";
			this.tabMetaDisplay.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabMetaDisplay.Size = new global::System.Drawing.Size(562, 267);
			this.tabMetaDisplay.TabIndex = 0;
			this.tabMetaDisplay.Text = "Meta";
			this.myTablePanel1.ColumnCount = 2;
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel1.Controls.Add(this.treeMeta, 0, 0);
			this.myTablePanel1.Controls.Add(this.comboBox1, 1, 1);
			this.myTablePanel1.Controls.Add(this.label2, 1, 4);
			this.myTablePanel1.Controls.Add(this.textBox1, 1, 3);
			this.myTablePanel1.Controls.Add(this.labelEntryType, 1, 0);
			this.myTablePanel1.Controls.Add(this.label3, 1, 5);
			this.myTablePanel1.Controls.Add(this.labelEntryData, 1, 2);
			this.myTablePanel1.Controls.Add(this.buttonEdit, 0, 6);
			this.myTablePanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanel1.Location = new global::System.Drawing.Point(3, 3);
			this.myTablePanel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.myTablePanel1.Name = "myTablePanel1";
			this.myTablePanel1.RowCount = 7;
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.myTablePanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle());
			this.myTablePanel1.Size = new global::System.Drawing.Size(556, 261);
			this.myTablePanel1.TabIndex = 19;
			this.treeMeta.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.treeMeta.ContextMenuStrip = this.contextMenuMetaTree;
			this.treeMeta.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeMeta.Enabled = false;
			this.treeMeta.ForeColor = global::System.Drawing.Color.White;
			this.treeMeta.Location = new global::System.Drawing.Point(0, 0);
			this.treeMeta.Margin = new global::System.Windows.Forms.Padding(0);
			this.treeMeta.Name = "treeMeta";
			this.myTablePanel1.SetRowSpan(this.treeMeta, 6);
			this.treeMeta.Size = new global::System.Drawing.Size(278, 189);
			this.treeMeta.TabIndex = 0;
			this.treeMeta.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeMeta_AfterSelect);
			this.treeMeta.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.treeMeta_KeyDown);
			this.comboBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.comboBox1.BackColor = global::System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new global::System.Drawing.Point(339, 64);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(155, 21);
			this.comboBox1.TabIndex = 6;
			this.comboBox1.SelectedIndexChanged += new global::System.EventHandler(this.comboBox1_SelectedIndexChanged);
			this.label2.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(388, 127);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(57, 1);
			this.label2.TabIndex = 8;
			this.label2.Text = "Entry Data";
			this.textBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom);
			this.textBox1.BackColor = global::System.Drawing.Color.White;
			this.textBox1.Location = new global::System.Drawing.Point(338, 104);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(157, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.labelEntryType.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.labelEntryType.AutoSize = true;
			this.labelEntryType.ForeColor = global::System.Drawing.Color.White;
			this.labelEntryType.Location = new global::System.Drawing.Point(388, 48);
			this.labelEntryType.Name = "labelEntryType";
			this.labelEntryType.Size = new global::System.Drawing.Size(58, 13);
			this.labelEntryType.TabIndex = 18;
			this.labelEntryType.Text = "Entry Type";
			this.label3.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(388, 188);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(58, 1);
			this.label3.TabIndex = 7;
			this.label3.Text = "Entry Type";
			this.labelEntryData.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.labelEntryData.AutoSize = true;
			this.labelEntryData.ForeColor = global::System.Drawing.Color.White;
			this.labelEntryData.Location = new global::System.Drawing.Point(388, 88);
			this.labelEntryData.Name = "labelEntryData";
			this.labelEntryData.Size = new global::System.Drawing.Size(57, 13);
			this.labelEntryData.TabIndex = 19;
			this.labelEntryData.Text = "Entry Data";
			this.buttonEdit.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.myTablePanel1.SetColumnSpan(this.buttonEdit, 2);
			this.buttonEdit.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.buttonEdit.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.ForeColor = global::System.Drawing.Color.White;
			this.buttonEdit.Location = new global::System.Drawing.Point(3, 192);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new global::System.Drawing.Size(550, 66);
			this.buttonEdit.TabIndex = 17;
			this.buttonEdit.Text = "EDIT BOXES";
			this.buttonEdit.TextImageRelation = global::System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Visible = false;
			this.buttonEdit.Click += new global::System.EventHandler(this.buttonEditModel_Click);
			this.labelImageSize.AutoSize = true;
			this.labelImageSize.Location = new global::System.Drawing.Point(385, 157);
			this.labelImageSize.Name = "labelImageSize";
			this.labelImageSize.Size = new global::System.Drawing.Size(78, 13);
			this.labelImageSize.TabIndex = 15;
			this.labelImageSize.Text = "labelImageSize";
			this.myTablePanelStartScreen.ColumnCount = 2;
			this.myTablePanelStartScreen.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 58.33333f));
			this.myTablePanelStartScreen.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 41.66667f));
			this.myTablePanelStartScreen.Controls.Add(this.richTextBoxChangelog, 1, 1);
			this.myTablePanelStartScreen.Controls.Add(this.label5, 1, 0);
			this.myTablePanelStartScreen.Controls.Add(this.pckOpen, 0, 0);
			this.myTablePanelStartScreen.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.myTablePanelStartScreen.Location = new global::System.Drawing.Point(20, 84);
			this.myTablePanelStartScreen.Margin = new global::System.Windows.Forms.Padding(0);
			this.myTablePanelStartScreen.Name = "myTablePanelStartScreen";
			this.myTablePanelStartScreen.RowCount = 2;
			this.myTablePanelStartScreen.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 70f));
			this.myTablePanelStartScreen.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.myTablePanelStartScreen.Size = new global::System.Drawing.Size(778, 498);
			this.myTablePanelStartScreen.TabIndex = 16;
			this.richTextBoxChangelog.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.richTextBoxChangelog.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBoxChangelog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxChangelog.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBoxChangelog.ForeColor = global::System.Drawing.Color.White;
			this.richTextBoxChangelog.Location = new global::System.Drawing.Point(453, 70);
			this.richTextBoxChangelog.Margin = new global::System.Windows.Forms.Padding(0, 0, 30, 30);
			this.richTextBoxChangelog.Name = "richTextBoxChangelog";
			this.richTextBoxChangelog.ReadOnly = true;
			this.richTextBoxChangelog.Size = new global::System.Drawing.Size(295, 398);
			this.richTextBoxChangelog.TabIndex = 15;
			this.richTextBoxChangelog.Text = "";
			this.label5.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Minecraft", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(456, 43);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(174, 27);
			this.label5.TabIndex = 12;
			this.label5.Text = "Welcome!";
			this.pckOpen.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pckOpen.Image = global::minekampf.Properties.Resources.pckClosed;
			this.pckOpen.Location = new global::System.Drawing.Point(3, 3);
			this.pckOpen.Name = "pckOpen";
			this.myTablePanelStartScreen.SetRowSpan(this.pckOpen, 2);
			this.pckOpen.Size = new global::System.Drawing.Size(447, 492);
			this.pckOpen.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pckOpen.TabIndex = 16;
			this.pckOpen.TabStop = false;
			this.pckOpen.Click += new global::System.EventHandler(this.openToolStripMenuItem_Click);
			this.pckOpen.DragDrop += new global::System.Windows.Forms.DragEventHandler(this.OpenPck_DragDrop);
			this.pckOpen.DragEnter += new global::System.Windows.Forms.DragEventHandler(this.OpenPck_DragEnter);
			this.pckOpen.DragLeave += new global::System.EventHandler(this.OpenPck_DragLeave);
			this.pckOpen.MouseEnter += new global::System.EventHandler(this.OpenPck_MouseEnter);
			this.pckOpen.MouseLeave += new global::System.EventHandler(this.OpenPck_MouseLeave);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(20, 14);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(147, 43);
			this.pictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.videosToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.howToMakeABasicSkinPackToolStripMenuItem,
				this.howToMakeACustomSkinModelToolStripMenuItem,
				this.howToMakeCustomSkinModelsbedrockToolStripMenuItem,
				this.howToMakeCustomMusicToolStripMenuItem,
				this.howToInstallPcksDirectlyToWiiUToolStripMenuItem,
				this.pCKCenterReleaseToolStripMenuItem,
				this.howPCKsWorkToolStripMenuItem
			});
			this.videosToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.videosToolStripMenuItem.Name = "videosToolStripMenuItem";
			this.videosToolStripMenuItem.Size = new global::System.Drawing.Size(54, 20);
			this.videosToolStripMenuItem.Text = "Videos";
			this.howToMakeABasicSkinPackToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howToMakeABasicSkinPackToolStripMenuItem.Name = "howToMakeABasicSkinPackToolStripMenuItem";
			this.howToMakeABasicSkinPackToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howToMakeABasicSkinPackToolStripMenuItem.Text = "How to make a basic skin pack";
			this.howToMakeABasicSkinPackToolStripMenuItem.Click += new global::System.EventHandler(this.howToMakeABasicSkinPackToolStripMenuItem_Click);
			this.howToMakeACustomSkinModelToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howToMakeACustomSkinModelToolStripMenuItem.Name = "howToMakeACustomSkinModelToolStripMenuItem";
			this.howToMakeACustomSkinModelToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howToMakeACustomSkinModelToolStripMenuItem.Text = "How to make a custom skin model";
			this.howToMakeACustomSkinModelToolStripMenuItem.Click += new global::System.EventHandler(this.howToMakeACustomSkinModelToolStripMenuItem_Click);
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem.Name = "howToInstallPcksDirectlyToWiiUToolStripMenuItem";
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem.Text = "How to install pcks directly to Wii U";
			this.howToInstallPcksDirectlyToWiiUToolStripMenuItem.Click += new global::System.EventHandler(this.howToInstallPcksDirectlyToWiiUToolStripMenuItem_Click);
			this.howPCKsWorkToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howPCKsWorkToolStripMenuItem.Name = "howPCKsWorkToolStripMenuItem";
			this.howPCKsWorkToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howPCKsWorkToolStripMenuItem.Text = "How PCKs work";
			this.howPCKsWorkToolStripMenuItem.Click += new global::System.EventHandler(this.howPCKsWorkToolStripMenuItem_Click);
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem.Name = "howToMakeCustomSkinModelsbedrockToolStripMenuItem";
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem.Text = "How to make a custom skin model (bedrock)";
			this.howToMakeCustomSkinModelsbedrockToolStripMenuItem.Click += new global::System.EventHandler(this.howToMakeCustomSkinModelsbedrockToolStripMenuItem_Click);
			this.pCKCenterReleaseToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.pCKCenterReleaseToolStripMenuItem.Name = "pCKCenterReleaseToolStripMenuItem";
			this.pCKCenterReleaseToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.pCKCenterReleaseToolStripMenuItem.Text = "PCK Center Release";
			this.pCKCenterReleaseToolStripMenuItem.Click += new global::System.EventHandler(this.pCKCenterReleaseToolStripMenuItem_Click);
			this.howToMakeCustomMusicToolStripMenuItem.Image = global::minekampf.Properties.Resources.youtube_PNG152;
			this.howToMakeCustomMusicToolStripMenuItem.Name = "howToMakeCustomMusicToolStripMenuItem";
			this.howToMakeCustomMusicToolStripMenuItem.Size = new global::System.Drawing.Size(312, 22);
			this.howToMakeCustomMusicToolStripMenuItem.Text = "How to make custom music";
			this.howToMakeCustomMusicToolStripMenuItem.Click += new global::System.EventHandler(this.howToMakeCustomMusicToolStripMenuItem_Click);
			base.ApplyImageInvert = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(818, 602);
			base.Controls.Add(this.myTablePanelStartScreen);
			base.Controls.Add(this.openedPCKS);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.labelVersion);
			base.Controls.Add(this.menuStrip);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new global::System.Drawing.Size(818, 602);
			base.Name = "FormMain";
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Text = "PCK Bypasser";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.contextMenuPCKEntries.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.contextMenuMetaTree.ResumeLayout(false);
			this.openedPCKS.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.myTablePanelPckEdit.ResumeLayout(false);
			this.myTablePanelPckEdit.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxImagePreview).EndInit();
			this.tabDataDisplay.ResumeLayout(false);
			this.tabMetaDisplay.ResumeLayout(false);
			this.myTablePanel1.ResumeLayout(false);
			this.myTablePanel1.PerformLayout();
			this.myTablePanelStartScreen.ResumeLayout(false);
			this.myTablePanelStartScreen.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pckOpen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003E5 RID: 997
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003E6 RID: 998
		private global::System.Windows.Forms.MenuStrip menuStrip;

		// Token: 0x040003E7 RID: 999
		private global::System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;

		// Token: 0x040003E8 RID: 1000
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;

		// Token: 0x040003E9 RID: 1001
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;

		// Token: 0x040003EA RID: 1002
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003EB RID: 1003
		private global::System.Windows.Forms.ContextMenuStrip contextMenuPCKEntries;

		// Token: 0x040003EC RID: 1004
		private global::System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;

		// Token: 0x040003ED RID: 1005
		private global::System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;

		// Token: 0x040003EE RID: 1006
		private global::System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;

		// Token: 0x040003EF RID: 1007
		private global::System.Windows.Forms.ContextMenuStrip contextMenuMetaTree;

		// Token: 0x040003F0 RID: 1008
		private global::System.Windows.Forms.ToolStripMenuItem addEntryToolStripMenuItem;

		// Token: 0x040003F1 RID: 1009
		private global::System.Windows.Forms.ToolStripMenuItem deleteEntryToolStripMenuItem;

		// Token: 0x040003F2 RID: 1010
		private global::System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;

		// Token: 0x040003F3 RID: 1011
		private global::System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;

		// Token: 0x040003F4 RID: 1012
		private global::System.Windows.Forms.ToolStripMenuItem metaToolStripMenuItem;

		// Token: 0x040003F5 RID: 1013
		private global::System.Windows.Forms.ToolStripMenuItem addPresetToolStripMenuItem1;

		// Token: 0x040003F6 RID: 1014
		private global::System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;

		// Token: 0x040003F7 RID: 1015
		private global::System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.Forms.ToolStripMenuItem advancedMetaAddingToolStripMenuItem;

		// Token: 0x040003F9 RID: 1017
		private global::System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;

		// Token: 0x040003FA RID: 1018
		private global::System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

		// Token: 0x040003FB RID: 1019
		private global::System.Windows.Forms.ToolStripMenuItem programInfoToolStripMenuItem;

		// Token: 0x040003FD RID: 1021
		private global::System.Windows.Forms.Label labelVersion;

		// Token: 0x040003FE RID: 1022
		private global::System.ComponentModel.BackgroundWorker backgroundWorker1;

		// Token: 0x040003FF RID: 1023
		private global::System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem1;

		// Token: 0x04000400 RID: 1024
		private global::System.DirectoryServices.DirectorySearcher directorySearcher1;

		// Token: 0x04000401 RID: 1025
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000402 RID: 1026
		private global::System.Windows.Forms.ToolStripMenuItem importSkinsToolStripMenuItem;

		// Token: 0x04000403 RID: 1027
		private global::System.Windows.Forms.ToolStripMenuItem importSkinToolStripMenuItem;

		// Token: 0x04000404 RID: 1028
		private global::System.Windows.Forms.ToolStripMenuItem importExtractedSkinsFolderToolStripMenuItem;

		// Token: 0x04000405 RID: 1029
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000406 RID: 1030
		private global::System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;

		// Token: 0x04000407 RID: 1031
		private global::System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;

		// Token: 0x04000408 RID: 1032
		private global::System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;

		// Token: 0x04000409 RID: 1033
		private global::System.Windows.Forms.ToolStripMenuItem skinToolStripMenuItem;

		// Token: 0x0400040A RID: 1034
		private global::System.Windows.Forms.ToolStripMenuItem createAnimatedTextureToolStripMenuItem;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.ToolStripMenuItem installationToolStripMenuItem;

		// Token: 0x0400040C RID: 1036
		private global::System.Windows.Forms.ToolStripMenuItem binkaConversionToolStripMenuItem;

		// Token: 0x0400040D RID: 1037
		private global::System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem1;

		// Token: 0x0400040E RID: 1038
		private global::System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;

		// Token: 0x0400040F RID: 1039
		private global::System.Windows.Forms.ToolStripMenuItem convertToBedrockToolStripMenuItem;

		// Token: 0x04000410 RID: 1040
		private global::System.Windows.Forms.ToolStripMenuItem storeToolStripMenuItem;

		// Token: 0x04000411 RID: 1041
		private global::System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;

		// Token: 0x04000412 RID: 1042
		private global::System.Windows.Forms.RichTextBox richTextBoxChangelog;

		// Token: 0x04000413 RID: 1043
		private global::System.Windows.Forms.ToolStripMenuItem tutorialsToolStripMenuItem;

		// Token: 0x04000414 RID: 1044
		private global::MetroFramework.Controls.MetroTabControl openedPCKS;

		// Token: 0x04000415 RID: 1045
		private global::MetroFramework.Controls.MetroTabPage tabPage1;

		// Token: 0x04000416 RID: 1046
		private global::System.Windows.Forms.TreeView treeViewMain;

		// Token: 0x04000417 RID: 1047
		private global::System.Windows.Forms.TabControl tabDataDisplay;

		// Token: 0x04000418 RID: 1048
		private global::System.Windows.Forms.TabPage tabMetaDisplay;

		// Token: 0x04000419 RID: 1049
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400041B RID: 1051
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400041C RID: 1052
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400041D RID: 1053
		private global::System.Windows.Forms.TreeView treeMeta;

		// Token: 0x0400041E RID: 1054
		private global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode pictureBoxImagePreview;

		// Token: 0x0400041F RID: 1055
		private global::System.Windows.Forms.Label labelImageSize;

		// Token: 0x04000420 RID: 1056
		private global::minekampf.Forms.MyTablePanel myTablePanelPckEdit;

		// Token: 0x04000421 RID: 1057
		private global::minekampf.Forms.MyTablePanel myTablePanelStartScreen;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.Button buttonEdit;

		// Token: 0x04000423 RID: 1059
		private global::System.Windows.Forms.Label labelAmount;

		// Token: 0x04000424 RID: 1060
		private global::minekampf.Forms.MyTablePanel myTablePanel1;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.PictureBox pckOpen;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.Label labelEntryType;

		// Token: 0x04000427 RID: 1063
		private global::System.Windows.Forms.Label labelEntryData;

		// Token: 0x04000428 RID: 1064
		private global::System.Windows.Forms.ToolStripMenuItem wiiUPCKInstallerToolStripMenuItem;

		// Token: 0x04000429 RID: 1065
		private global::System.Windows.Forms.ToolStripMenuItem videosToolStripMenuItem;

		// Token: 0x0400042A RID: 1066
		private global::System.Windows.Forms.ToolStripMenuItem howToMakeABasicSkinPackToolStripMenuItem;

		// Token: 0x0400042B RID: 1067
		private global::System.Windows.Forms.ToolStripMenuItem howToMakeACustomSkinModelToolStripMenuItem;

		// Token: 0x0400042C RID: 1068
		private global::System.Windows.Forms.ToolStripMenuItem howToMakeCustomSkinModelsbedrockToolStripMenuItem;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.ToolStripMenuItem howToMakeCustomMusicToolStripMenuItem;

		// Token: 0x0400042E RID: 1070
		private global::System.Windows.Forms.ToolStripMenuItem howToInstallPcksDirectlyToWiiUToolStripMenuItem;

		// Token: 0x0400042F RID: 1071
		private global::System.Windows.Forms.ToolStripMenuItem pCKCenterReleaseToolStripMenuItem;

		// Token: 0x04000430 RID: 1072
		private global::System.Windows.Forms.ToolStripMenuItem howPCKsWorkToolStripMenuItem;
	}
}
