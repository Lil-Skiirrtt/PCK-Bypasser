namespace minekampf
{
	// Token: 0x02000064 RID: 100
	public partial class programInfo : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600010C RID: 268 RVA: 0x00002EF3 File Offset: 0x000010F3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000FF40 File Offset: 0x0000E140
		private void InitializeComponent()
		{
			this.folderBrowserDialog1 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Image = global::minekampf.Properties.Resources.Splash;
			this.pictureBox1.Location = new global::System.Drawing.Point(4, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(575, 293);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(582, 330);
			base.Controls.Add(this.pictureBox1);
			base.DisplayHeader = false;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "programInfo";
			base.Padding = new global::System.Windows.Forms.Padding(20, 30, 20, 20);
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "programInfo";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.programInfo_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002DB RID: 731
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002DC RID: 732
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

		// Token: 0x040002DD RID: 733
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
