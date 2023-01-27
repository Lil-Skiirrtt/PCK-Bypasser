namespace MinecraftUSkinEditor
{
	// Token: 0x02000085 RID: 133
	public partial class generateModelOLD : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00003CB4 File Offset: 0x00001EB4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0003EAE4 File Offset: 0x0003CCE4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.createToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cloneToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.displayBox = new global::System.Windows.Forms.PictureBox();
			this.textXc = new global::System.Windows.Forms.TextBox();
			this.textZf = new global::System.Windows.Forms.TextBox();
			this.textYf = new global::System.Windows.Forms.TextBox();
			this.textXf = new global::System.Windows.Forms.TextBox();
			this.textZc = new global::System.Windows.Forms.TextBox();
			this.textYc = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.buttonDone = new global::System.Windows.Forms.Button();
			this.texturePreview = new global::System.Windows.Forms.PictureBox();
			this.label11 = new global::System.Windows.Forms.Label();
			this.buttonEXPORT = new global::System.Windows.Forms.Button();
			this.buttonXfplus = new global::System.Windows.Forms.Button();
			this.buttonYfplus = new global::System.Windows.Forms.Button();
			this.buttonZfminus = new global::System.Windows.Forms.Button();
			this.buttonYfminus = new global::System.Windows.Forms.Button();
			this.buttonXfminus = new global::System.Windows.Forms.Button();
			this.buttonZfplus = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.buttonZcplus = new global::System.Windows.Forms.Button();
			this.buttonXcminus = new global::System.Windows.Forms.Button();
			this.buttonYcminus = new global::System.Windows.Forms.Button();
			this.buttonZcminus = new global::System.Windows.Forms.Button();
			this.buttonYcplus = new global::System.Windows.Forms.Button();
			this.buttonXcplus = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.comboParent = new global::System.Windows.Forms.ComboBox();
			this.textBoxPartName = new global::System.Windows.Forms.TextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.labelView = new global::System.Windows.Forms.Label();
			this.checkGuide = new global::System.Windows.Forms.CheckBox();
			this.textTextureX = new global::System.Windows.Forms.TextBox();
			this.textTextureY = new global::System.Windows.Forms.TextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.buttonIMPORT = new global::System.Windows.Forms.Button();
			this.label8 = new global::System.Windows.Forms.Label();
			this.checkTextureGenerate = new global::System.Windows.Forms.CheckBox();
			this.label9 = new global::System.Windows.Forms.Label();
			this.offsetBody = new global::System.Windows.Forms.TextBox();
			this.offsetLegs = new global::System.Windows.Forms.TextBox();
			this.offsetArms = new global::System.Windows.Forms.TextBox();
			this.offsetHead = new global::System.Windows.Forms.TextBox();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label14 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.buttonTemplate = new global::System.Windows.Forms.Button();
			this.buttonExportModel = new global::System.Windows.Forms.Button();
			this.buttonImportModel = new global::System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.texturePreview).BeginInit();
			this.groupBox1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.listView1.Location = new global::System.Drawing.Point(22, 92);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(114, 152);
			this.listView1.TabIndex = 28;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.listView1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listView1_MouseDown);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.createToolStripMenuItem,
				this.cloneToolStripMenuItem,
				this.deleteToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(109, 70);
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Size = new global::System.Drawing.Size(108, 22);
			this.createToolStripMenuItem.Text = "Create";
			this.createToolStripMenuItem.Click += new global::System.EventHandler(this.createToolStripMenuItem_Click);
			this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
			this.cloneToolStripMenuItem.Size = new global::System.Drawing.Size(108, 22);
			this.cloneToolStripMenuItem.Text = "Clone";
			this.cloneToolStripMenuItem.Click += new global::System.EventHandler(this.cloneToolStripMenuItem_Click);
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(108, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new global::System.EventHandler(this.deleteToolStripMenuItem_Click);
			this.displayBox.Location = new global::System.Drawing.Point(143, 92);
			this.displayBox.Name = "displayBox";
			this.displayBox.Size = new global::System.Drawing.Size(406, 371);
			this.displayBox.TabIndex = 30;
			this.displayBox.TabStop = false;
			this.textXc.Location = new global::System.Drawing.Point(555, 415);
			this.textXc.Name = "textXc";
			this.textXc.Size = new global::System.Drawing.Size(40, 20);
			this.textXc.TabIndex = 31;
			this.textXc.TextChanged += new global::System.EventHandler(this.textXc_TextChanged);
			this.textZf.Location = new global::System.Drawing.Point(643, 322);
			this.textZf.Name = "textZf";
			this.textZf.Size = new global::System.Drawing.Size(40, 20);
			this.textZf.TabIndex = 32;
			this.textZf.TextChanged += new global::System.EventHandler(this.textZf_TextChanged);
			this.textYf.Location = new global::System.Drawing.Point(599, 322);
			this.textYf.Name = "textYf";
			this.textYf.Size = new global::System.Drawing.Size(40, 20);
			this.textYf.TabIndex = 34;
			this.textYf.TextChanged += new global::System.EventHandler(this.textYf_TextChanged);
			this.textXf.Location = new global::System.Drawing.Point(555, 322);
			this.textXf.Name = "textXf";
			this.textXf.Size = new global::System.Drawing.Size(40, 20);
			this.textXf.TabIndex = 35;
			this.textXf.TextChanged += new global::System.EventHandler(this.textXf_TextChanged);
			this.textZc.Location = new global::System.Drawing.Point(643, 415);
			this.textZc.Name = "textZc";
			this.textZc.Size = new global::System.Drawing.Size(40, 20);
			this.textZc.TabIndex = 36;
			this.textZc.TextChanged += new global::System.EventHandler(this.textZc_TextChanged);
			this.textYc.Location = new global::System.Drawing.Point(599, 415);
			this.textYc.Name = "textYc";
			this.textYc.Size = new global::System.Drawing.Size(40, 20);
			this.textYc.TabIndex = 37;
			this.textYc.TextChanged += new global::System.EventHandler(this.textYc_TextChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(19, 76);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(63, 13);
			this.label1.TabIndex = 39;
			this.label1.Text = "Model Parts";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(139, 76);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(88, 13);
			this.label2.TabIndex = 40;
			this.label2.Text = "Full Skin Preview";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(458, 469);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(91, 23);
			this.button1.TabIndex = 49;
			this.button1.Text = "Rotate Right";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.Color.White;
			this.button2.Location = new global::System.Drawing.Point(142, 469);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(89, 23);
			this.button2.TabIndex = 50;
			this.button2.Text = "Rotate Left";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.buttonDone.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDone.ForeColor = global::System.Drawing.Color.White;
			this.buttonDone.Location = new global::System.Drawing.Point(608, 469);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new global::System.Drawing.Size(75, 23);
			this.buttonDone.TabIndex = 51;
			this.buttonDone.Text = "Create";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new global::System.EventHandler(this.buttonDone_Click);
			this.texturePreview.Location = new global::System.Drawing.Point(555, 92);
			this.texturePreview.Name = "texturePreview";
			this.texturePreview.Size = new global::System.Drawing.Size(128, 128);
			this.texturePreview.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.texturePreview.TabIndex = 52;
			this.texturePreview.TabStop = false;
			this.texturePreview.BackgroundImageChanged += new global::System.EventHandler(this.texturePreview_BackgroundImageChanged);
			this.label11.AutoSize = true;
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(551, 76);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(128, 13);
			this.label11.TabIndex = 53;
			this.label11.Text = "Texture Mapping Preview";
			this.buttonEXPORT.Enabled = false;
			this.buttonEXPORT.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonEXPORT.ForeColor = global::System.Drawing.Color.White;
			this.buttonEXPORT.Location = new global::System.Drawing.Point(620, 221);
			this.buttonEXPORT.Name = "buttonEXPORT";
			this.buttonEXPORT.Size = new global::System.Drawing.Size(64, 23);
			this.buttonEXPORT.TabIndex = 54;
			this.buttonEXPORT.Text = "EXPORT";
			this.buttonEXPORT.UseVisualStyleBackColor = true;
			this.buttonEXPORT.Click += new global::System.EventHandler(this.buttonEXPORT_Click);
			this.buttonXfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXfplus.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXfplus.Location = new global::System.Drawing.Point(555, 296);
			this.buttonXfplus.Name = "buttonXfplus";
			this.buttonXfplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonXfplus.TabIndex = 55;
			this.buttonXfplus.Text = "+";
			this.buttonXfplus.UseVisualStyleBackColor = true;
			this.buttonXfplus.Click += new global::System.EventHandler(this.buttonXfplus_Click);
			this.buttonYfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYfplus.Location = new global::System.Drawing.Point(599, 296);
			this.buttonYfplus.Name = "buttonYfplus";
			this.buttonYfplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonYfplus.TabIndex = 56;
			this.buttonYfplus.Text = "+";
			this.buttonYfplus.UseVisualStyleBackColor = true;
			this.buttonYfplus.Click += new global::System.EventHandler(this.buttonYfplus_Click);
			this.buttonZfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZfminus.Location = new global::System.Drawing.Point(643, 345);
			this.buttonZfminus.Name = "buttonZfminus";
			this.buttonZfminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonZfminus.TabIndex = 57;
			this.buttonZfminus.Text = "-";
			this.buttonZfminus.UseVisualStyleBackColor = true;
			this.buttonZfminus.Click += new global::System.EventHandler(this.buttonZfminus_Click);
			this.buttonYfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYfminus.Location = new global::System.Drawing.Point(599, 345);
			this.buttonYfminus.Name = "buttonYfminus";
			this.buttonYfminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonYfminus.TabIndex = 58;
			this.buttonYfminus.Text = "-";
			this.buttonYfminus.UseVisualStyleBackColor = true;
			this.buttonYfminus.Click += new global::System.EventHandler(this.buttonYfminus_Click);
			this.buttonXfminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXfminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXfminus.Location = new global::System.Drawing.Point(555, 345);
			this.buttonXfminus.Name = "buttonXfminus";
			this.buttonXfminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonXfminus.TabIndex = 59;
			this.buttonXfminus.Text = "-";
			this.buttonXfminus.UseVisualStyleBackColor = true;
			this.buttonXfminus.Click += new global::System.EventHandler(this.buttonXfminus_Click);
			this.buttonZfplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZfplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZfplus.Location = new global::System.Drawing.Point(643, 296);
			this.buttonZfplus.Name = "buttonZfplus";
			this.buttonZfplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonZfplus.TabIndex = 60;
			this.buttonZfplus.Text = "+";
			this.buttonZfplus.UseVisualStyleBackColor = true;
			this.buttonZfplus.Click += new global::System.EventHandler(this.buttonZfplus_Click);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(552, 280);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(27, 13);
			this.label3.TabIndex = 61;
			this.label3.Text = "Size";
			this.buttonZcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZcplus.Location = new global::System.Drawing.Point(643, 389);
			this.buttonZcplus.Name = "buttonZcplus";
			this.buttonZcplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonZcplus.TabIndex = 67;
			this.buttonZcplus.Text = "+";
			this.buttonZcplus.UseVisualStyleBackColor = true;
			this.buttonZcplus.Click += new global::System.EventHandler(this.buttonZcplus_Click);
			this.buttonXcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXcminus.Location = new global::System.Drawing.Point(555, 438);
			this.buttonXcminus.Name = "buttonXcminus";
			this.buttonXcminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonXcminus.TabIndex = 66;
			this.buttonXcminus.Text = "-";
			this.buttonXcminus.UseVisualStyleBackColor = true;
			this.buttonXcminus.Click += new global::System.EventHandler(this.buttonXcminus_Click);
			this.buttonYcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYcminus.Location = new global::System.Drawing.Point(599, 438);
			this.buttonYcminus.Name = "buttonYcminus";
			this.buttonYcminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonYcminus.TabIndex = 65;
			this.buttonYcminus.Text = "-";
			this.buttonYcminus.UseVisualStyleBackColor = true;
			this.buttonYcminus.Click += new global::System.EventHandler(this.buttonYcminus_Click);
			this.buttonZcminus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonZcminus.ForeColor = global::System.Drawing.Color.White;
			this.buttonZcminus.Location = new global::System.Drawing.Point(643, 438);
			this.buttonZcminus.Name = "buttonZcminus";
			this.buttonZcminus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonZcminus.TabIndex = 64;
			this.buttonZcminus.Text = "-";
			this.buttonZcminus.UseVisualStyleBackColor = true;
			this.buttonZcminus.Click += new global::System.EventHandler(this.buttonZcminus_Click);
			this.buttonYcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonYcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonYcplus.Location = new global::System.Drawing.Point(599, 389);
			this.buttonYcplus.Name = "buttonYcplus";
			this.buttonYcplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonYcplus.TabIndex = 63;
			this.buttonYcplus.Text = "+";
			this.buttonYcplus.UseVisualStyleBackColor = true;
			this.buttonYcplus.Click += new global::System.EventHandler(this.buttonYcplus_Click);
			this.buttonXcplus.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonXcplus.ForeColor = global::System.Drawing.Color.White;
			this.buttonXcplus.ImageAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.buttonXcplus.Location = new global::System.Drawing.Point(555, 389);
			this.buttonXcplus.Name = "buttonXcplus";
			this.buttonXcplus.Size = new global::System.Drawing.Size(40, 23);
			this.buttonXcplus.TabIndex = 62;
			this.buttonXcplus.Text = "+";
			this.buttonXcplus.UseVisualStyleBackColor = true;
			this.buttonXcplus.Click += new global::System.EventHandler(this.buttonXcplus_Click);
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(552, 373);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(44, 13);
			this.label5.TabIndex = 68;
			this.label5.Text = "Position";
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
			this.comboParent.Location = new global::System.Drawing.Point(22, 440);
			this.comboParent.Name = "comboParent";
			this.comboParent.Size = new global::System.Drawing.Size(114, 21);
			this.comboParent.TabIndex = 71;
			this.comboParent.SelectedIndexChanged += new global::System.EventHandler(this.comboParent_SelectedIndexChanged);
			this.textBoxPartName.Enabled = false;
			this.textBoxPartName.Location = new global::System.Drawing.Point(22, 395);
			this.textBoxPartName.Name = "textBoxPartName";
			this.textBoxPartName.Size = new global::System.Drawing.Size(114, 20);
			this.textBoxPartName.TabIndex = 72;
			this.textBoxPartName.TextChanged += new global::System.EventHandler(this.textBoxPartName_TextChanged);
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(19, 379);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(57, 13);
			this.label4.TabIndex = 73;
			this.label4.Text = "Part Name";
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(19, 424);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(38, 13);
			this.label6.TabIndex = 74;
			this.label6.Text = "Parent";
			this.labelView.AutoSize = true;
			this.labelView.ForeColor = global::System.Drawing.Color.White;
			this.labelView.Location = new global::System.Drawing.Point(237, 466);
			this.labelView.Name = "labelView";
			this.labelView.Size = new global::System.Drawing.Size(33, 13);
			this.labelView.TabIndex = 75;
			this.labelView.Text = "View:";
			this.checkGuide.AutoSize = true;
			this.checkGuide.ForeColor = global::System.Drawing.Color.White;
			this.checkGuide.Location = new global::System.Drawing.Point(238, 478);
			this.checkGuide.Name = "checkGuide";
			this.checkGuide.Size = new global::System.Drawing.Size(82, 17);
			this.checkGuide.TabIndex = 76;
			this.checkGuide.Text = "Guide Lines";
			this.checkGuide.UseVisualStyleBackColor = true;
			this.checkGuide.CheckedChanged += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkGuide.Click += new global::System.EventHandler(this.checkGuide_Click);
			this.textTextureX.Location = new global::System.Drawing.Point(581, 250);
			this.textTextureX.Name = "textTextureX";
			this.textTextureX.Size = new global::System.Drawing.Size(34, 20);
			this.textTextureX.TabIndex = 77;
			this.textTextureX.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textTextureY.Location = new global::System.Drawing.Point(623, 250);
			this.textTextureY.Name = "textTextureY";
			this.textTextureY.Size = new global::System.Drawing.Size(34, 20);
			this.textTextureY.TabIndex = 78;
			this.textTextureY.TextChanged += new global::System.EventHandler(this.textTextureY_TextChanged);
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(557, 253);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(22, 13);
			this.label7.TabIndex = 79;
			this.label7.Text = "UV";
			this.buttonIMPORT.Enabled = false;
			this.buttonIMPORT.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonIMPORT.ForeColor = global::System.Drawing.Color.White;
			this.buttonIMPORT.Location = new global::System.Drawing.Point(554, 221);
			this.buttonIMPORT.Name = "buttonIMPORT";
			this.buttonIMPORT.Size = new global::System.Drawing.Size(64, 23);
			this.buttonIMPORT.TabIndex = 69;
			this.buttonIMPORT.Text = "IMPORT";
			this.buttonIMPORT.UseVisualStyleBackColor = true;
			this.buttonIMPORT.Click += new global::System.EventHandler(this.buttonIMPORT_Click);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.Black;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(145, 378);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(350, 29);
			this.label8.TabIndex = 80;
			this.label8.Text = "GROUND LEVEL                    ";
			this.checkTextureGenerate.AutoSize = true;
			this.checkTextureGenerate.Checked = true;
			this.checkTextureGenerate.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkTextureGenerate.ForeColor = global::System.Drawing.Color.White;
			this.checkTextureGenerate.Location = new global::System.Drawing.Point(318, 478);
			this.checkTextureGenerate.Name = "checkTextureGenerate";
			this.checkTextureGenerate.Size = new global::System.Drawing.Size(134, 17);
			this.checkTextureGenerate.TabIndex = 81;
			this.checkTextureGenerate.Text = "Auto Generate Texture";
			this.checkTextureGenerate.UseVisualStyleBackColor = true;
			this.checkTextureGenerate.CheckedChanged += new global::System.EventHandler(this.checkTextureGenerate_CheckedChanged);
			this.label9.AutoSize = true;
			this.label9.ForeColor = global::System.Drawing.Color.Maroon;
			this.label9.Location = new global::System.Drawing.Point(-1, 494);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(35, 13);
			this.label9.TabIndex = 82;
			this.label9.Text = "BETA";
			this.offsetBody.Location = new global::System.Drawing.Point(57, 40);
			this.offsetBody.Name = "offsetBody";
			this.offsetBody.Size = new global::System.Drawing.Size(43, 20);
			this.offsetBody.TabIndex = 83;
			this.offsetBody.Text = "0";
			this.offsetBody.TextAlignChanged += new global::System.EventHandler(this.offsetBody_TextAlignChanged);
			this.offsetBody.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.offsetLegs.Location = new global::System.Drawing.Point(57, 66);
			this.offsetLegs.Name = "offsetLegs";
			this.offsetLegs.Size = new global::System.Drawing.Size(43, 20);
			this.offsetLegs.TabIndex = 84;
			this.offsetLegs.Text = "0";
			this.offsetLegs.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.offsetArms.Location = new global::System.Drawing.Point(57, 92);
			this.offsetArms.Name = "offsetArms";
			this.offsetArms.Size = new global::System.Drawing.Size(43, 20);
			this.offsetArms.TabIndex = 85;
			this.offsetArms.Text = "0";
			this.offsetArms.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.offsetHead.Location = new global::System.Drawing.Point(57, 14);
			this.offsetHead.Name = "offsetHead";
			this.offsetHead.Size = new global::System.Drawing.Size(43, 20);
			this.offsetHead.TabIndex = 86;
			this.offsetHead.Text = "0";
			this.offsetHead.TextChanged += new global::System.EventHandler(this.offsetHead_TextChanged);
			this.label10.AutoSize = true;
			this.label10.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.label10.Location = new global::System.Drawing.Point(14, 17);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(37, 13);
			this.label10.TabIndex = 87;
			this.label10.Text = "HEAD";
			this.label12.AutoSize = true;
			this.label12.ForeColor = global::System.Drawing.Color.FromArgb(0, 64, 0);
			this.label12.Location = new global::System.Drawing.Point(14, 43);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(37, 13);
			this.label12.TabIndex = 88;
			this.label12.Text = "BODY";
			this.label13.AutoSize = true;
			this.label13.ForeColor = global::System.Drawing.Color.FromArgb(64, 0, 64);
			this.label13.Location = new global::System.Drawing.Point(14, 69);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(35, 13);
			this.label13.TabIndex = 89;
			this.label13.Text = "LEGS";
			this.label14.AutoSize = true;
			this.label14.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label14.Location = new global::System.Drawing.Point(14, 95);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(38, 13);
			this.label14.TabIndex = 90;
			this.label14.Text = "ARMS";
			this.groupBox1.Controls.Add(this.offsetBody);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.offsetLegs);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.offsetArms);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.offsetHead);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.ForeColor = global::System.Drawing.Color.White;
			this.groupBox1.Location = new global::System.Drawing.Point(22, 250);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(114, 118);
			this.groupBox1.TabIndex = 91;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "OFFSETS";
			this.buttonTemplate.Location = new global::System.Drawing.Point(22, 467);
			this.buttonTemplate.Name = "buttonTemplate";
			this.buttonTemplate.Size = new global::System.Drawing.Size(114, 23);
			this.buttonTemplate.TabIndex = 92;
			this.buttonTemplate.Text = "Load Template";
			this.buttonTemplate.UseVisualStyleBackColor = true;
			this.buttonTemplate.Click += new global::System.EventHandler(this.buttonTemplate_Click);
			this.buttonExportModel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonExportModel.ForeColor = global::System.Drawing.Color.White;
			this.buttonExportModel.Location = new global::System.Drawing.Point(458, 63);
			this.buttonExportModel.Name = "buttonExportModel";
			this.buttonExportModel.Size = new global::System.Drawing.Size(87, 21);
			this.buttonExportModel.TabIndex = 93;
			this.buttonExportModel.Text = "EXPORT CSM";
			this.buttonExportModel.UseVisualStyleBackColor = true;
			this.buttonExportModel.Click += new global::System.EventHandler(this.buttonExportModel_Click);
			this.buttonImportModel.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonImportModel.ForeColor = global::System.Drawing.Color.White;
			this.buttonImportModel.Location = new global::System.Drawing.Point(372, 63);
			this.buttonImportModel.Name = "buttonImportModel";
			this.buttonImportModel.Size = new global::System.Drawing.Size(80, 21);
			this.buttonImportModel.TabIndex = 95;
			this.buttonImportModel.Text = "OPEN CSM";
			this.buttonImportModel.UseVisualStyleBackColor = true;
			this.buttonImportModel.Click += new global::System.EventHandler(this.buttonImportModel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(704, 508);
			base.Controls.Add(this.buttonImportModel);
			base.Controls.Add(this.buttonExportModel);
			base.Controls.Add(this.buttonTemplate);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.checkTextureGenerate);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.textTextureY);
			base.Controls.Add(this.textTextureX);
			base.Controls.Add(this.checkGuide);
			base.Controls.Add(this.labelView);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.textBoxPartName);
			base.Controls.Add(this.comboParent);
			base.Controls.Add(this.buttonIMPORT);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.buttonZcplus);
			base.Controls.Add(this.buttonXcminus);
			base.Controls.Add(this.buttonYcminus);
			base.Controls.Add(this.buttonZcminus);
			base.Controls.Add(this.buttonYcplus);
			base.Controls.Add(this.buttonXcplus);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.buttonZfplus);
			base.Controls.Add(this.buttonXfminus);
			base.Controls.Add(this.buttonYfminus);
			base.Controls.Add(this.buttonZfminus);
			base.Controls.Add(this.buttonYfplus);
			base.Controls.Add(this.buttonXfplus);
			base.Controls.Add(this.buttonEXPORT);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.texturePreview);
			base.Controls.Add(this.buttonDone);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textYc);
			base.Controls.Add(this.textZc);
			base.Controls.Add(this.textXf);
			base.Controls.Add(this.textYf);
			base.Controls.Add(this.textZf);
			base.Controls.Add(this.textXc);
			base.Controls.Add(this.displayBox);
			base.Controls.Add(this.listView1);
			base.MaximizeBox = false;
			base.Name = "generateModelOLD";
			base.Resizable = false;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Model Generator";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.generateModel_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.texturePreview).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400043B RID: 1083
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400043C RID: 1084
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400043D RID: 1085
		private global::System.Windows.Forms.PictureBox displayBox;

		// Token: 0x0400043E RID: 1086
		private global::System.Windows.Forms.TextBox textXc;

		// Token: 0x0400043F RID: 1087
		private global::System.Windows.Forms.TextBox textZf;

		// Token: 0x04000440 RID: 1088
		private global::System.Windows.Forms.TextBox textYf;

		// Token: 0x04000441 RID: 1089
		private global::System.Windows.Forms.TextBox textXf;

		// Token: 0x04000442 RID: 1090
		private global::System.Windows.Forms.TextBox textZc;

		// Token: 0x04000443 RID: 1091
		private global::System.Windows.Forms.TextBox textYc;

		// Token: 0x04000444 RID: 1092
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000445 RID: 1093
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000446 RID: 1094
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000447 RID: 1095
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000448 RID: 1096
		private global::System.Windows.Forms.Button buttonDone;

		// Token: 0x04000449 RID: 1097
		private global::System.Windows.Forms.PictureBox texturePreview;

		// Token: 0x0400044A RID: 1098
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400044B RID: 1099
		private global::System.Windows.Forms.Button buttonEXPORT;

		// Token: 0x0400044C RID: 1100
		private global::System.Windows.Forms.Button buttonXfplus;

		// Token: 0x0400044D RID: 1101
		private global::System.Windows.Forms.Button buttonYfplus;

		// Token: 0x0400044E RID: 1102
		private global::System.Windows.Forms.Button buttonZfminus;

		// Token: 0x0400044F RID: 1103
		private global::System.Windows.Forms.Button buttonYfminus;

		// Token: 0x04000450 RID: 1104
		private global::System.Windows.Forms.Button buttonXfminus;

		// Token: 0x04000451 RID: 1105
		private global::System.Windows.Forms.Button buttonZfplus;

		// Token: 0x04000452 RID: 1106
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000453 RID: 1107
		private global::System.Windows.Forms.Button buttonZcplus;

		// Token: 0x04000454 RID: 1108
		private global::System.Windows.Forms.Button buttonXcminus;

		// Token: 0x04000455 RID: 1109
		private global::System.Windows.Forms.Button buttonYcminus;

		// Token: 0x04000456 RID: 1110
		private global::System.Windows.Forms.Button buttonZcminus;

		// Token: 0x04000457 RID: 1111
		private global::System.Windows.Forms.Button buttonYcplus;

		// Token: 0x04000458 RID: 1112
		private global::System.Windows.Forms.Button buttonXcplus;

		// Token: 0x04000459 RID: 1113
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400045A RID: 1114
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x0400045B RID: 1115
		private global::System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;

		// Token: 0x0400045C RID: 1116
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x0400045D RID: 1117
		private global::System.Windows.Forms.ComboBox comboParent;

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Forms.TextBox textBoxPartName;

		// Token: 0x0400045F RID: 1119
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000460 RID: 1120
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000461 RID: 1121
		private global::System.Windows.Forms.Label labelView;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.CheckBox checkGuide;

		// Token: 0x04000463 RID: 1123
		private global::System.Windows.Forms.TextBox textTextureX;

		// Token: 0x04000464 RID: 1124
		private global::System.Windows.Forms.TextBox textTextureY;

		// Token: 0x04000465 RID: 1125
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000466 RID: 1126
		private global::System.Windows.Forms.Button buttonIMPORT;

		// Token: 0x04000467 RID: 1127
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000468 RID: 1128
		private global::System.Windows.Forms.CheckBox checkTextureGenerate;

		// Token: 0x04000469 RID: 1129
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400046A RID: 1130
		private global::System.Windows.Forms.TextBox offsetBody;

		// Token: 0x0400046B RID: 1131
		private global::System.Windows.Forms.TextBox offsetLegs;

		// Token: 0x0400046C RID: 1132
		private global::System.Windows.Forms.TextBox offsetArms;

		// Token: 0x0400046D RID: 1133
		private global::System.Windows.Forms.TextBox offsetHead;

		// Token: 0x0400046E RID: 1134
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400046F RID: 1135
		private global::System.Windows.Forms.Label label12;

		// Token: 0x04000470 RID: 1136
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000471 RID: 1137
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000472 RID: 1138
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000473 RID: 1139
		private global::System.Windows.Forms.Button buttonTemplate;

		// Token: 0x04000474 RID: 1140
		private global::System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;

		// Token: 0x04000475 RID: 1141
		private global::System.Windows.Forms.Button buttonImportModel;

		// Token: 0x04000476 RID: 1142
		private global::System.Windows.Forms.Button buttonExportModel;
	}
}
