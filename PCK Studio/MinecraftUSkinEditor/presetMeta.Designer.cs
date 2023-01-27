namespace MinecraftUSkinEditor
{
	// Token: 0x02000091 RID: 145
	public partial class presetMeta : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x060002BB RID: 699 RVA: 0x00003ED6 File Offset: 0x000020D6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000429E4 File Offset: 0x00040BE4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.presetMeta));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.button1 = new global::System.Windows.Forms.Button();
			this.labelSearch = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.listView1.ForeColor = global::System.Drawing.Color.White;
			this.listView1.Location = new global::System.Drawing.Point(11, 63);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(166, 155);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.List;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(53, 224);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.labelSearch.AutoSize = true;
			this.labelSearch.BackColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.labelSearch.ForeColor = global::System.Drawing.Color.White;
			this.labelSearch.Location = new global::System.Drawing.Point(41, 110);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new global::System.Drawing.Size(105, 13);
			this.labelSearch.TabIndex = 2;
			this.labelSearch.Text = "You have no presets";
			this.labelSearch.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = global::MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
			base.ClientSize = new global::System.Drawing.Size(187, 252);
			base.Controls.Add(this.labelSearch);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "presetMeta";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Presets";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.presetMeta_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004A0 RID: 1184
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004A1 RID: 1185
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040004A3 RID: 1187
		private global::System.Windows.Forms.Label labelSearch;
	}
}
