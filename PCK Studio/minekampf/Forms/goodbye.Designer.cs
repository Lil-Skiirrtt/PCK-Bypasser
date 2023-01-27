namespace minekampf.Forms
{
	// Token: 0x02000068 RID: 104
	public partial class goodbye : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00003307 File Offset: 0x00001507
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001041C File Offset: 0x0000E61C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::minekampf.Forms.goodbye));
			this.label1 = new global::System.Windows.Forms.Label();
			this.buttonDonate = new global::System.Windows.Forms.Button();
			this.buttonClose = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(23, 72);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(630, 460);
			this.label1.TabIndex = 1;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.buttonDonate.BackColor = global::System.Drawing.Color.Blue;
			this.buttonDonate.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonDonate.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonDonate.ForeColor = global::System.Drawing.Color.White;
			this.buttonDonate.Location = new global::System.Drawing.Point(415, 541);
			this.buttonDonate.Name = "buttonDonate";
			this.buttonDonate.Size = new global::System.Drawing.Size(103, 38);
			this.buttonDonate.TabIndex = 2;
			this.buttonDonate.Text = "Subscribe";
			this.buttonDonate.UseVisualStyleBackColor = false;
			this.buttonDonate.Click += new global::System.EventHandler(this.buttonDonate_Click);
			this.buttonClose.BackColor = global::System.Drawing.Color.Red;
			this.buttonClose.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonClose.ForeColor = global::System.Drawing.Color.White;
			this.buttonClose.Location = new global::System.Drawing.Point(529, 541);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new global::System.Drawing.Size(103, 38);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			this.buttonClose.Click += new global::System.EventHandler(this.buttonClose_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(655, 602);
			base.Controls.Add(this.buttonClose);
			base.Controls.Add(this.buttonDonate);
			base.Controls.Add(this.label1);
			base.Name = "Réssucite";
			base.Resizable = false;
			base.Style = global::MetroFramework.MetroColorStyle.Blue;
			this.Text = "PCK Bypasser made by Lil Skiirrtt!";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.ResumeLayout(true);
			base.PerformLayout();
		}

		// Token: 0x040002E5 RID: 741
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002E6 RID: 742
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002E7 RID: 743
		private global::System.Windows.Forms.Button buttonDonate;

		// Token: 0x040002E8 RID: 744
		private global::System.Windows.Forms.Button buttonClose;
	}
}
