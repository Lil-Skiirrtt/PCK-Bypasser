namespace MinecraftUSkinEditor
{
	// Token: 0x0200007A RID: 122
	public partial class DisplayIdPrompt : global::System.Windows.Forms.Form
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000388B File Offset: 0x00001A8B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00025C88 File Offset: 0x00023E88
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.DisplayIdPrompt));
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(161, 27);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Display ID";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(137, 123);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(109, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Default Display Name";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.textBox1.Location = new global::System.Drawing.Point(12, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(360, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox2.Location = new global::System.Drawing.Point(12, 163);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(360, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(384, 239);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "DisplayIdPrompt";
			this.Text = "LOC Editor";
			base.Load += new global::System.EventHandler(this.DisplayIdPrompt_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040003BB RID: 955
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003BC RID: 956
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003BD RID: 957
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040003BE RID: 958
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040003BF RID: 959
		private global::System.Windows.Forms.TextBox textBox2;
	}
}
