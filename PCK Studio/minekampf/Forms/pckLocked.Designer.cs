namespace minekampf.Forms
{
	// Token: 0x02000071 RID: 113
	public partial class pckLocked : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00003609 File Offset: 0x00001809
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00020EBC File Offset: 0x0001F0BC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.Forms.pckLocked));
			this.textBoxPass = new global::System.Windows.Forms.TextBox();
			this.buttonUnlocked = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBoxPass.Location = new global::System.Drawing.Point(23, 67);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new global::System.Drawing.Size(244, 20);
			this.textBoxPass.TabIndex = 0;
			this.textBoxPass.Text = "Password";
			this.textBoxPass.Click += new global::System.EventHandler(this.textBoxPass_Click);
			this.textBoxPass.TextChanged += new global::System.EventHandler(this.textBoxPass_TextChanged);
			this.textBoxPass.Enter += new global::System.EventHandler(this.textBoxPass_Enter);
			this.textBoxPass.Visible = false;
			this.buttonUnlocked.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonUnlocked.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonUnlocked.ForeColor = global::System.Drawing.Color.White;
			this.buttonUnlocked.Location = new global::System.Drawing.Point(124, 63);
			this.buttonUnlocked.Name = "buttonUnlocked";
			this.buttonUnlocked.Size = new global::System.Drawing.Size(126, 39);
			this.buttonUnlocked.TabIndex = 1;
			this.buttonUnlocked.Text = "UNLOCK!";
			this.buttonUnlocked.UseVisualStyleBackColor = true;
			this.buttonUnlocked.Click += new global::System.EventHandler(this.buttonUnlocked_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(362, 113);
			base.Controls.Add(this.buttonUnlocked);
			base.Controls.Add(this.textBoxPass);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "pckLocked";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Text = "This PCK is UNLOCKED!";
			base.TextAlign = global::MetroFramework.Forms.MetroFormTextAlign.Center;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400033F RID: 831
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.TextBox textBoxPass;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.Button buttonUnlocked;
	}
}
