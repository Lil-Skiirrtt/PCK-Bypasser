namespace MinecraftUSkinEditor
{
	// Token: 0x02000074 RID: 116
	public partial class addMeta : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000198 RID: 408 RVA: 0x0000366A File Offset: 0x0000186A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00021A90 File Offset: 0x0001FC90
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.addMeta));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new global::System.Drawing.Point(60, 25);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(193, 20);
			this.textBox1.TabIndex = 0;
			this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new global::System.Drawing.Point(60, 52);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(193, 20);
			this.textBox2.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(12, 28);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(31, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Entry";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(34, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Value";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(96, 78);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(264, 105);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "addMeta";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.addMeta_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400035C RID: 860
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400035D RID: 861
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400035E RID: 862
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400035F RID: 863
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.Button button1;
	}
}
