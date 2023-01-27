namespace MinecraftUSkinEditor
{
	// Token: 0x0200008E RID: 142
	public partial class MetaADD : global::System.Windows.Forms.Form
	{
		// Token: 0x060002AE RID: 686 RVA: 0x00003E0D File Offset: 0x0000200D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00042160 File Offset: 0x00040360
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.MetaADD));
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.textBox1.Location = new global::System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(259, 20);
			this.textBox1.TabIndex = 0;
			this.button1.Location = new global::System.Drawing.Point(102, 36);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Create/Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(284, 62);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MetaADD";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000492 RID: 1170
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000493 RID: 1171
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000494 RID: 1172
		private global::System.Windows.Forms.Button button1;
	}
}
