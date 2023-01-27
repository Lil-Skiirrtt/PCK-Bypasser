namespace MinecraftUSkinEditor
{
	// Token: 0x02000072 RID: 114
	public partial class addAnimatedTexture : global::MetroFramework.Forms.MetroForm
	{
		// Token: 0x06000192 RID: 402 RVA: 0x00003628 File Offset: 0x00001828
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000213A0 File Offset: 0x0001F5A0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.addAnimatedTexture));
			this.pictureBox1 = new global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.radioButton1 = new global::System.Windows.Forms.RadioButton();
			this.radioButton2 = new global::System.Windows.Forms.RadioButton();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox1.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.InterpolationMode = global::System.Drawing.Drawing2D.InterpolationMode.Default;
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 59);
			this.pictureBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(119, 251);
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			this.textBox1.Location = new global::System.Drawing.Point(182, 63);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(74, 20);
			this.textBox1.TabIndex = 43;
			this.textBox2.Location = new global::System.Drawing.Point(182, 113);
			this.textBox2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(74, 20);
			this.textBox2.TabIndex = 44;
			this.textBox3.Location = new global::System.Drawing.Point(182, 165);
			this.textBox3.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(74, 20);
			this.textBox3.TabIndex = 45;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(138, 67);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(41, 13);
			this.label1.TabIndex = 46;
			this.label1.Text = "Item ID";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(138, 115);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(41, 13);
			this.label2.TabIndex = 47;
			this.label2.Text = "Frames";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(138, 167);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(38, 13);
			this.label3.TabIndex = 48;
			this.label3.Text = "Speed";
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new global::System.Drawing.Point(182, 286);
			this.button1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 22);
			this.button1.TabIndex = 49;
			this.button1.Text = "Create/Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new global::System.Drawing.Point(141, 202);
			this.radioButton1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new global::System.Drawing.Size(52, 17);
			this.radioButton1.TabIndex = 50;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Block";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new global::System.Drawing.Point(212, 202);
			this.radioButton2.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new global::System.Drawing.Size(45, 17);
			this.radioButton2.TabIndex = 51;
			this.radioButton2.Text = "Item";
			this.radioButton2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(270, 325);
			base.Controls.Add(this.radioButton2);
			base.Controls.Add(this.radioButton1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.textBox3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.pictureBox1);
			this.ForeColor = global::System.Drawing.Color.White;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.MaximizeBox = false;
			base.Name = "addAnimatedTexture";
			base.Resizable = false;
			base.ShadowType = global::MetroFramework.Forms.MetroFormShadowType.DropShadow;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.Style = global::MetroFramework.MetroColorStyle.Silver;
			this.Text = "Texture Animator";
			base.Theme = global::MetroFramework.MetroThemeStyle.Dark;
			base.Load += new global::System.EventHandler(this.addAnimatedTexture_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400034D RID: 845
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400034E RID: 846
		private global::MinecraftUSkinEditor.PictureBoxWithInterpolationMode pictureBox1;

		// Token: 0x0400034F RID: 847
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000350 RID: 848
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000351 RID: 849
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x04000352 RID: 850
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000353 RID: 851
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000356 RID: 854
		private global::System.Windows.Forms.RadioButton radioButton1;

		// Token: 0x04000357 RID: 855
		private global::System.Windows.Forms.RadioButton radioButton2;
	}
}
