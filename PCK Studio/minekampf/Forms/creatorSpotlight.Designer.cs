namespace minekampf.Forms
{
	// Token: 0x02000067 RID: 103
	public partial class creatorSpotlight : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000137 RID: 311 RVA: 0x000032C5 File Offset: 0x000014C5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000101D0 File Offset: 0x0000E3D0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.Forms.creatorSpotlight));
			this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
			this.buttonOpenInBrowser = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.webBrowser1.AllowWebBrowserDrop = true;
			this.webBrowser1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new global::System.Drawing.Point(20, 60);
			this.webBrowser1.Margin = new global::System.Windows.Forms.Padding(0);
			this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.ScrollBarsEnabled = false;
			this.webBrowser1.Size = new global::System.Drawing.Size(741, 462);
			this.webBrowser1.TabIndex = 0;
			this.buttonOpenInBrowser.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 192);
			this.buttonOpenInBrowser.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonOpenInBrowser.ForeColor = global::System.Drawing.Color.White;
			this.buttonOpenInBrowser.Location = new global::System.Drawing.Point(670, 499);
			this.buttonOpenInBrowser.Name = "buttonOpenInBrowser";
			this.buttonOpenInBrowser.Size = new global::System.Drawing.Size(98, 29);
			this.buttonOpenInBrowser.TabIndex = 1;
			this.buttonOpenInBrowser.Text = "Open in Browser";
			this.buttonOpenInBrowser.UseVisualStyleBackColor = false;
			this.buttonOpenInBrowser.Click += new global::System.EventHandler(this.buttonOpenInBrowser_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(781, 542);
			base.Controls.Add(this.buttonOpenInBrowser);
			base.Controls.Add(this.webBrowser1);
			this.Font = new global::System.Drawing.Font("Segoe UI Semibold", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "creatorSpotlight";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Text = "WHAT THE CREATOR HAS BEEN UP TO (BETA)";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.creatorSpotlight_Load);
			base.ResumeLayout(true);
		}

		// Token: 0x040002E2 RID: 738
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002E3 RID: 739
		private global::System.Windows.Forms.WebBrowser webBrowser1;

		// Token: 0x040002E4 RID: 740
		private global::System.Windows.Forms.Button buttonOpenInBrowser;
	}
}
