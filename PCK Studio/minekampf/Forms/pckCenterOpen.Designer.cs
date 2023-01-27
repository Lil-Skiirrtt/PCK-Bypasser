namespace minekampf.Forms
{
	// Token: 0x02000070 RID: 112
	public partial class pckCenterOpen : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00003579 File Offset: 0x00001779
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002043C File Offset: 0x0001E63C
		private void InitializeComponent()
		{
			this.buttonDirect = new global::System.Windows.Forms.Button();
			this.buttonAd = new global::System.Windows.Forms.Button();
			this.labelName = new global::System.Windows.Forms.Label();
			this.labelDesc = new global::System.Windows.Forms.Label();
			this.buttonDelete = new global::System.Windows.Forms.Button();
			this.buttonExport = new global::System.Windows.Forms.Button();
			this.buttonInstallPs3 = new global::System.Windows.Forms.Button();
			this.buttonInstallXbox = new global::System.Windows.Forms.Button();
			this.buttonInstallWiiU = new global::System.Windows.Forms.Button();
			this.pictureBoxDisplay = new global::System.Windows.Forms.PictureBox();
			this.buttonBedrock = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDisplay).BeginInit();
			base.SuspendLayout();
			this.buttonDirect.BackColor = global::System.Drawing.Color.Purple;
			this.buttonDirect.FlatAppearance.BorderSize = 0;
			this.buttonDirect.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDirect.ForeColor = global::System.Drawing.Color.White;
			this.buttonDirect.Location = new global::System.Drawing.Point(568, 362);
			this.buttonDirect.Name = "buttonDirect";
			this.buttonDirect.Size = new global::System.Drawing.Size(169, 43);
			this.buttonDirect.TabIndex = 2;
			this.buttonDirect.Text = "DOWNLOAD TO COLLECTION";
			this.buttonDirect.UseVisualStyleBackColor = false;
			this.buttonDirect.Visible = false;
			this.buttonDirect.Click += new global::System.EventHandler(this.buttonDirect_Click);
			this.buttonAd.BackColor = global::System.Drawing.Color.Orange;
			this.buttonAd.FlatAppearance.BorderSize = 0;
			this.buttonAd.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonAd.ForeColor = global::System.Drawing.Color.White;
			this.buttonAd.Location = new global::System.Drawing.Point(384, 362);
			this.buttonAd.Name = "buttonAd";
			this.buttonAd.Size = new global::System.Drawing.Size(169, 43);
			this.buttonAd.TabIndex = 3;
			this.buttonAd.Text = "AD DOWNLOAD";
			this.buttonAd.UseVisualStyleBackColor = false;
			this.buttonAd.Visible = false;
			this.buttonAd.Click += new global::System.EventHandler(this.buttonAd_Click);
			this.labelName.AutoSize = true;
			this.labelName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelName.ForeColor = global::System.Drawing.Color.White;
			this.labelName.Location = new global::System.Drawing.Point(24, 24);
			this.labelName.Name = "labelName";
			this.labelName.Size = new global::System.Drawing.Size(135, 31);
			this.labelName.TabIndex = 5;
			this.labelName.Text = "Skin Pack";
			this.labelDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelDesc.ForeColor = global::System.Drawing.Color.White;
			this.labelDesc.Location = new global::System.Drawing.Point(384, 64);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new global::System.Drawing.Size(353, 285);
			this.labelDesc.TabIndex = 6;
			this.labelDesc.Text = "labelDesc";
			this.buttonDelete.BackColor = global::System.Drawing.Color.Red;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonDelete.ForeColor = global::System.Drawing.Color.White;
			this.buttonDelete.Location = new global::System.Drawing.Point(384, 339);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new global::System.Drawing.Size(178, 66);
			this.buttonDelete.TabIndex = 7;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new global::System.EventHandler(this.buttonDelete_Click);
			this.buttonExport.BackColor = global::System.Drawing.Color.SlateGray;
			this.buttonExport.FlatAppearance.BorderSize = 0;
			this.buttonExport.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonExport.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonExport.ForeColor = global::System.Drawing.Color.White;
			this.buttonExport.Location = new global::System.Drawing.Point(692, 339);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new global::System.Drawing.Size(45, 30);
			this.buttonExport.TabIndex = 8;
			this.buttonExport.Text = "Get";
			this.buttonExport.UseVisualStyleBackColor = false;
			this.buttonExport.Visible = false;
			this.buttonExport.Click += new global::System.EventHandler(this.buttonExport_Click);
			this.buttonInstallPs3.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.buttonInstallPs3.BackgroundImage = global::minekampf.Properties.Resources.ps3;
			this.buttonInstallPs3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.buttonInstallPs3.FlatAppearance.BorderSize = 0;
			this.buttonInstallPs3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonInstallPs3.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonInstallPs3.ForeColor = global::System.Drawing.Color.White;
			this.buttonInstallPs3.Location = new global::System.Drawing.Point(657, 339);
			this.buttonInstallPs3.Name = "buttonInstallPs3";
			this.buttonInstallPs3.Size = new global::System.Drawing.Size(30, 30);
			this.buttonInstallPs3.TabIndex = 11;
			this.buttonInstallPs3.UseVisualStyleBackColor = false;
			this.buttonInstallPs3.Visible = false;
			this.buttonInstallPs3.Click += new global::System.EventHandler(this.buttonInstallPs3_Click);
			this.buttonInstallXbox.BackColor = global::System.Drawing.Color.Lime;
			this.buttonInstallXbox.BackgroundImage = global::minekampf.Properties.Resources.xbox;
			this.buttonInstallXbox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.buttonInstallXbox.FlatAppearance.BorderSize = 0;
			this.buttonInstallXbox.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonInstallXbox.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonInstallXbox.ForeColor = global::System.Drawing.Color.White;
			this.buttonInstallXbox.Location = new global::System.Drawing.Point(621, 339);
			this.buttonInstallXbox.Name = "buttonInstallXbox";
			this.buttonInstallXbox.Size = new global::System.Drawing.Size(30, 30);
			this.buttonInstallXbox.TabIndex = 10;
			this.buttonInstallXbox.UseVisualStyleBackColor = false;
			this.buttonInstallXbox.Visible = false;
			this.buttonInstallXbox.Click += new global::System.EventHandler(this.buttonInstallXbox_Click);
			this.buttonInstallWiiU.BackColor = global::System.Drawing.Color.DeepSkyBlue;
			this.buttonInstallWiiU.BackgroundImage = global::minekampf.Properties.Resources.wiiu;
			this.buttonInstallWiiU.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.buttonInstallWiiU.FlatAppearance.BorderSize = 0;
			this.buttonInstallWiiU.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonInstallWiiU.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonInstallWiiU.ForeColor = global::System.Drawing.Color.White;
			this.buttonInstallWiiU.Location = new global::System.Drawing.Point(585, 339);
			this.buttonInstallWiiU.Name = "buttonInstallWiiU";
			this.buttonInstallWiiU.Size = new global::System.Drawing.Size(30, 30);
			this.buttonInstallWiiU.TabIndex = 9;
			this.buttonInstallWiiU.UseVisualStyleBackColor = false;
			this.buttonInstallWiiU.Visible = false;
			this.buttonInstallWiiU.Click += new global::System.EventHandler(this.buttonInstallWiiU_Click);
			this.pictureBoxDisplay.Location = new global::System.Drawing.Point(24, 64);
			this.pictureBoxDisplay.Name = "pictureBoxDisplay";
			this.pictureBoxDisplay.Size = new global::System.Drawing.Size(341, 341);
			this.pictureBoxDisplay.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxDisplay.TabIndex = 0;
			this.pictureBoxDisplay.TabStop = false;
			this.buttonBedrock.BackColor = global::System.Drawing.Color.Green;
			this.buttonBedrock.FlatAppearance.BorderSize = 0;
			this.buttonBedrock.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonBedrock.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonBedrock.ForeColor = global::System.Drawing.Color.White;
			this.buttonBedrock.Location = new global::System.Drawing.Point(585, 375);
			this.buttonBedrock.Name = "buttonBedrock";
			this.buttonBedrock.Size = new global::System.Drawing.Size(152, 30);
			this.buttonBedrock.TabIndex = 12;
			this.buttonBedrock.Text = "Convert to Bedrock";
			this.buttonBedrock.UseVisualStyleBackColor = false;
			this.buttonBedrock.Visible = false;
			this.buttonBedrock.Click += new global::System.EventHandler(this.convertToBedrockToolStripMenuItem_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(760, 425);
			base.Controls.Add(this.buttonBedrock);
			base.Controls.Add(this.buttonInstallPs3);
			base.Controls.Add(this.buttonInstallXbox);
			base.Controls.Add(this.buttonInstallWiiU);
			base.Controls.Add(this.buttonExport);
			base.Controls.Add(this.buttonDelete);
			base.Controls.Add(this.labelDesc);
			base.Controls.Add(this.labelName);
			base.Controls.Add(this.buttonAd);
			base.Controls.Add(this.buttonDirect);
			base.Controls.Add(this.pictureBoxDisplay);
			base.MaximizeBox = false;
			base.Name = "pckCenterOpen";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.White;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.pckCenterOpen_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxDisplay).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000332 RID: 818
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000333 RID: 819
		private global::System.Windows.Forms.PictureBox pictureBoxDisplay;

		// Token: 0x04000334 RID: 820
		private global::System.Windows.Forms.Button buttonDirect;

		// Token: 0x04000335 RID: 821
		private global::System.Windows.Forms.Button buttonAd;

		// Token: 0x04000336 RID: 822
		private global::System.Windows.Forms.Label labelName;

		// Token: 0x04000337 RID: 823
		private global::System.Windows.Forms.Label labelDesc;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.Button buttonDelete;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.Button buttonExport;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.Button buttonInstallWiiU;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.Button buttonInstallXbox;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.Button buttonInstallPs3;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.Button buttonBedrock;
	}
}
