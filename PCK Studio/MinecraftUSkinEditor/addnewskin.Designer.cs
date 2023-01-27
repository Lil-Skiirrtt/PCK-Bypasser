namespace MinecraftUSkinEditor
{
	// Token: 0x02000076 RID: 118
	public partial class addnewskin : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060001B8 RID: 440 RVA: 0x0000377A File Offset: 0x0000197A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0002384C File Offset: 0x00021A4C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.addnewskin));
			this.textTheme = new global::System.Windows.Forms.TextBox();
			this.contextMenuSkin = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuCape = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.buttonDone = new global::System.Windows.Forms.Button();
			this.buttonModelGen = new global::System.Windows.Forms.Button();
			this.comboBoxSkinType = new global::System.Windows.Forms.ComboBox();
			this.buttonCape = new global::System.Windows.Forms.Button();
			this.buttonSkin = new global::System.Windows.Forms.Button();
			this.pictureBoxWithInterpolationMode1 = new global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode();
			this.pictureBoxTexture = new global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode();
			this.displayBox = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textThemeName = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textSkinName = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textSkinID = new global::System.Windows.Forms.TextBox();
			this.radioSERVER = new global::System.Windows.Forms.RadioButton();
			this.radioLOCAL = new global::System.Windows.Forms.RadioButton();
			this.labelSelectTexture = new global::System.Windows.Forms.Label();
			this.contextMenuSkin.SuspendLayout();
			this.contextMenuCape.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxWithInterpolationMode1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxTexture).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).BeginInit();
			base.SuspendLayout();
			this.textTheme.Location = new global::System.Drawing.Point(102, 78);
			this.textTheme.Name = "textTheme";
			this.textTheme.Size = new global::System.Drawing.Size(239, 20);
			this.textTheme.TabIndex = 32;
			this.textTheme.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.contextMenuSkin.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.replaceToolStripMenuItem
			});
			this.contextMenuSkin.Name = "contextMenuSkin";
			this.contextMenuSkin.Size = new global::System.Drawing.Size(116, 26);
			this.replaceToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("replaceToolStripMenuItem.Image");
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new global::System.Drawing.Size(115, 22);
			this.replaceToolStripMenuItem.Text = "Replace";
			this.replaceToolStripMenuItem.Click += new global::System.EventHandler(this.replaceToolStripMenuItem_Click);
			this.contextMenuCape.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.replaceToolStripMenuItem1
			});
			this.contextMenuCape.Name = "contextMenuCape";
			this.contextMenuCape.Size = new global::System.Drawing.Size(127, 26);
			this.replaceToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("replaceToolStripMenuItem1.Image");
			this.replaceToolStripMenuItem1.Name = "replaceToolStripMenuItem1";
			this.replaceToolStripMenuItem1.Size = new global::System.Drawing.Size(126, 22);
			this.replaceToolStripMenuItem1.Text = "Add Cape";
			this.replaceToolStripMenuItem1.Click += new global::System.EventHandler(this.replaceToolStripMenuItem1_Click);
			this.buttonDone.Enabled = false;
			this.buttonDone.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDone.ForeColor = global::System.Drawing.Color.White;
			this.buttonDone.Location = new global::System.Drawing.Point(388, 262);
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Size = new global::System.Drawing.Size(75, 23);
			this.buttonDone.TabIndex = 115;
			this.buttonDone.Text = "Create Skin";
			this.buttonDone.UseVisualStyleBackColor = true;
			this.buttonDone.Click += new global::System.EventHandler(this.button1_Click_1);
			this.buttonModelGen.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonModelGen.ForeColor = global::System.Drawing.Color.White;
			this.buttonModelGen.Location = new global::System.Drawing.Point(14, 259);
			this.buttonModelGen.Name = "buttonModelGen";
			this.buttonModelGen.Size = new global::System.Drawing.Size(61, 23);
			this.buttonModelGen.TabIndex = 113;
			this.buttonModelGen.Text = "Generate";
			this.buttonModelGen.UseVisualStyleBackColor = true;
			this.buttonModelGen.Click += new global::System.EventHandler(this.button2_Click_1);
			this.comboBoxSkinType.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxSkinType.FormattingEnabled = true;
			this.comboBoxSkinType.Items.AddRange(new object[]
			{
				"Default (64x32)",
				"Steve (64x64)",
				"Alex (64x64)"
			});
			this.comboBoxSkinType.Location = new global::System.Drawing.Point(75, 260);
			this.comboBoxSkinType.Name = "comboBoxSkinType";
			this.comboBoxSkinType.Size = new global::System.Drawing.Size(122, 21);
			this.comboBoxSkinType.TabIndex = 112;
			this.comboBoxSkinType.Text = "Select Preset";
			this.buttonCape.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonCape.Image");
			this.buttonCape.Location = new global::System.Drawing.Point(443, 212);
			this.buttonCape.Name = "buttonCape";
			this.buttonCape.Size = new global::System.Drawing.Size(23, 22);
			this.buttonCape.TabIndex = 111;
			this.buttonCape.UseVisualStyleBackColor = true;
			this.buttonCape.Click += new global::System.EventHandler(this.buttonCape_Click);
			this.buttonSkin.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("buttonSkin.Image");
			this.buttonSkin.Location = new global::System.Drawing.Point(359, 212);
			this.buttonSkin.Name = "buttonSkin";
			this.buttonSkin.Size = new global::System.Drawing.Size(23, 22);
			this.buttonSkin.TabIndex = 110;
			this.buttonSkin.UseVisualStyleBackColor = true;
			this.buttonSkin.Click += new global::System.EventHandler(this.buttonSkin_Click);
			this.pictureBoxWithInterpolationMode1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBoxWithInterpolationMode1.InterpolationMode = global::System.Drawing.Drawing2D.InterpolationMode.Default;
			this.pictureBoxWithInterpolationMode1.Location = new global::System.Drawing.Point(388, 152);
			this.pictureBoxWithInterpolationMode1.Name = "pictureBoxWithInterpolationMode1";
			this.pictureBoxWithInterpolationMode1.Size = new global::System.Drawing.Size(208, 88);
			this.pictureBoxWithInterpolationMode1.TabIndex = 109;
			this.pictureBoxWithInterpolationMode1.TabStop = false;
			this.pictureBoxTexture.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBoxTexture.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxTexture.InterpolationMode = global::System.Drawing.Drawing2D.InterpolationMode.Default;
			this.pictureBoxTexture.Location = new global::System.Drawing.Point(218, 152);
			this.pictureBoxTexture.Name = "pictureBoxTexture";
			this.pictureBoxTexture.Size = new global::System.Drawing.Size(164, 82);
			this.pictureBoxTexture.TabIndex = 108;
			this.pictureBoxTexture.TabStop = false;
			this.pictureBoxTexture.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.displayBox.BackColor = global::System.Drawing.SystemColors.ControlDark;
			this.displayBox.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.displayBox.Location = new global::System.Drawing.Point(14, 61);
			this.displayBox.Name = "displayBox";
			this.displayBox.Size = new global::System.Drawing.Size(184, 199);
			this.displayBox.TabIndex = 107;
			this.displayBox.TabStop = false;
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(215, 129);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(71, 13);
			this.label3.TabIndex = 106;
			this.label3.Text = "Theme Name";
			this.textThemeName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textThemeName.Location = new global::System.Drawing.Point(292, 126);
			this.textThemeName.Name = "textThemeName";
			this.textThemeName.Size = new global::System.Drawing.Size(174, 20);
			this.textThemeName.TabIndex = 105;
			this.textThemeName.TextChanged += new global::System.EventHandler(this.textThemeName_TextChanged);
			this.textThemeName.VisibleChanged += new global::System.EventHandler(this.textThemeName_VisibleChanged);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(215, 97);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(59, 13);
			this.label2.TabIndex = 104;
			this.label2.Text = "Skin Name";
			this.textSkinName.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSkinName.Location = new global::System.Drawing.Point(292, 94);
			this.textSkinName.Name = "textSkinName";
			this.textSkinName.Size = new global::System.Drawing.Size(174, 20);
			this.textSkinName.TabIndex = 103;
			this.textSkinName.TextChanged += new global::System.EventHandler(this.textSkinName_TextChanged);
			this.textSkinName.VisibleChanged += new global::System.EventHandler(this.textSkinName_VisibleChanged);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(215, 64);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(42, 13);
			this.label1.TabIndex = 102;
			this.label1.Text = "Skin ID";
			this.textSkinID.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSkinID.Location = new global::System.Drawing.Point(292, 61);
			this.textSkinID.MaxLength = 8;
			this.textSkinID.Name = "textSkinID";
			this.textSkinID.Size = new global::System.Drawing.Size(66, 20);
			this.textSkinID.TabIndex = 101;
			this.textSkinID.Text = "XXXXXXXX";
			this.textSkinID.TextChanged += new global::System.EventHandler(this.textSkinID_TextChanged_1);
			this.radioSERVER.AutoSize = true;
			this.radioSERVER.ForeColor = global::System.Drawing.Color.White;
			this.radioSERVER.Location = new global::System.Drawing.Point(388, 51);
			this.radioSERVER.Name = "radioSERVER";
			this.radioSERVER.Size = new global::System.Drawing.Size(69, 17);
			this.radioSERVER.TabIndex = 117;
			this.radioSERVER.Text = "SERVER";
			this.radioSERVER.UseVisualStyleBackColor = true;
			this.radioSERVER.CheckedChanged += new global::System.EventHandler(this.radioButton1_CheckedChanged);
			this.radioLOCAL.AutoSize = true;
			this.radioLOCAL.Checked = true;
			this.radioLOCAL.ForeColor = global::System.Drawing.Color.White;
			this.radioLOCAL.Location = new global::System.Drawing.Point(388, 71);
			this.radioLOCAL.Name = "radioLOCAL";
			this.radioLOCAL.Size = new global::System.Drawing.Size(59, 17);
			this.radioLOCAL.TabIndex = 118;
			this.radioLOCAL.TabStop = true;
			this.radioLOCAL.Text = "LOCAL";
			this.radioLOCAL.UseVisualStyleBackColor = true;
			this.radioLOCAL.CheckedChanged += new global::System.EventHandler(this.radioLOCAL_CheckedChanged);
			this.labelSelectTexture.AutoSize = true;
			this.labelSelectTexture.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelSelectTexture.ForeColor = global::System.Drawing.Color.White;
			this.labelSelectTexture.Location = new global::System.Drawing.Point(261, 186);
			this.labelSelectTexture.Name = "labelSelectTexture";
			this.labelSelectTexture.Size = new global::System.Drawing.Size(76, 13);
			this.labelSelectTexture.TabIndex = 119;
			this.labelSelectTexture.Text = "Select Texture";
			this.labelSelectTexture.Click += new global::System.EventHandler(this.label4_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(484, 297);
			base.Controls.Add(this.labelSelectTexture);
			base.Controls.Add(this.radioLOCAL);
			base.Controls.Add(this.radioSERVER);
			base.Controls.Add(this.buttonDone);
			base.Controls.Add(this.buttonModelGen);
			base.Controls.Add(this.comboBoxSkinType);
			base.Controls.Add(this.buttonCape);
			base.Controls.Add(this.buttonSkin);
			base.Controls.Add(this.pictureBoxWithInterpolationMode1);
			base.Controls.Add(this.pictureBoxTexture);
			base.Controls.Add(this.displayBox);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textThemeName);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.textSkinName);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textSkinID);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "addnewskin";
			base.Resizable = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Skin Creator";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.addnewskin_Load);
			this.contextMenuSkin.ResumeLayout(false);
			this.contextMenuCape.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxWithInterpolationMode1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxTexture).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.displayBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000382 RID: 898
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000385 RID: 901
		private global::System.Windows.Forms.TextBox textTheme;

		// Token: 0x04000386 RID: 902
		private global::System.Windows.Forms.ContextMenuStrip contextMenuSkin;

		// Token: 0x04000387 RID: 903
		private global::System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Forms.ContextMenuStrip contextMenuCape;

		// Token: 0x04000389 RID: 905
		private global::System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem1;

		// Token: 0x0400038A RID: 906
		private global::System.Windows.Forms.Button buttonDone;

		// Token: 0x0400038B RID: 907
		private global::System.Windows.Forms.Button buttonModelGen;

		// Token: 0x0400038C RID: 908
		private global::System.Windows.Forms.ComboBox comboBoxSkinType;

		// Token: 0x0400038D RID: 909
		private global::System.Windows.Forms.Button buttonCape;

		// Token: 0x0400038E RID: 910
		private global::System.Windows.Forms.Button buttonSkin;

		// Token: 0x0400038F RID: 911
		private global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode pictureBoxWithInterpolationMode1;

		// Token: 0x04000390 RID: 912
		private global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode pictureBoxTexture;

		// Token: 0x04000391 RID: 913
		private global::System.Windows.Forms.PictureBox displayBox;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.TextBox textThemeName;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.TextBox textSkinName;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.TextBox textSkinID;

		// Token: 0x04000398 RID: 920
		private global::System.Windows.Forms.RadioButton radioSERVER;

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Forms.RadioButton radioLOCAL;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.Label labelSelectTexture;
	}
}
