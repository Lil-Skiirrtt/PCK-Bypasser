namespace MinecraftUSkinEditor
{
	// Token: 0x02000075 RID: 117
	public partial class addMetaAdvanced : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x0600019D RID: 413 RVA: 0x0000369E File Offset: 0x0000189E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00021E50 File Offset: 0x00020050
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.addMetaAdvanced));
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(93, 87);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(10, 64);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(34, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Value";
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(10, 37);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(31, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Entry";
			this.textBox2.Location = new global::System.Drawing.Point(58, 61);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(193, 20);
			this.textBox2.TabIndex = 6;
			this.textBox1.Location = new global::System.Drawing.Point(58, 34);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(193, 20);
			this.textBox1.TabIndex = 5;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(262, 119);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			this.ForeColor = global::System.Drawing.Color.White;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "addMetaAdvanced";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.addMetaAdvanced_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000363 RID: 867
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000364 RID: 868
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000365 RID: 869
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000366 RID: 870
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000367 RID: 871
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000368 RID: 872
		private global::System.Windows.Forms.TextBox textBox1;
	}
}
