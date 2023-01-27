namespace minekampf
{
	// Token: 0x02000061 RID: 97
	public partial class colEditor : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002DCB File Offset: 0x00000FCB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005DB0 File Offset: 0x00003FB0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.colEditor));
			this.listView1 = new global::System.Windows.Forms.ListView();
			base.SuspendLayout();
			this.listView1.Location = new global::System.Drawing.Point(23, 63);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(341, 257);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(383, 342);
			base.Controls.Add(this.listView1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "colEditor";
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.AeroShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Color Editor";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.colEditor_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000283 RID: 643
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.ListView listView1;
	}
}
