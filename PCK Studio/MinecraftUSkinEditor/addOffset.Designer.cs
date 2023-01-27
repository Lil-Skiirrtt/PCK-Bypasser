namespace MinecraftUSkinEditor
{
	// Token: 0x02000078 RID: 120
	public partial class addOffset : global::System.Windows.Forms.Form
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000037C1 File Offset: 0x000019C1
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000246B0 File Offset: 0x000228B0
		private void InitializeComponent()
		{
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("HEAD");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("BODY");
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("ARM0");
			global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("ARM1");
			global::System.Windows.Forms.ListViewItem listViewItem5 = new global::System.Windows.Forms.ListViewItem("LEG0");
			global::System.Windows.Forms.ListViewItem listViewItem6 = new global::System.Windows.Forms.ListViewItem("LEG1");
			global::System.Windows.Forms.ListViewItem listViewItem7 = new global::System.Windows.Forms.ListViewItem("TOOL0");
			global::System.Windows.Forms.ListViewItem listViewItem8 = new global::System.Windows.Forms.ListViewItem("TOOL1");
			global::System.Windows.Forms.ListViewItem listViewItem9 = new global::System.Windows.Forms.ListViewItem("HELMET");
			global::System.Windows.Forms.ListViewItem listViewItem10 = new global::System.Windows.Forms.ListViewItem("PANTS1");
			global::System.Windows.Forms.ListViewItem listViewItem11 = new global::System.Windows.Forms.ListViewItem("PANTS0");
			global::System.Windows.Forms.ListViewItem listViewItem12 = new global::System.Windows.Forms.ListViewItem("BOOT0");
			global::System.Windows.Forms.ListViewItem listViewItem13 = new global::System.Windows.Forms.ListViewItem("BOOT1");
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::MinecraftUSkinEditor.addOffset));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.pictureHead = new global::System.Windows.Forms.PictureBox();
			this.pictureArm1 = new global::System.Windows.Forms.PictureBox();
			this.pictureArm0 = new global::System.Windows.Forms.PictureBox();
			this.pictureBody = new global::System.Windows.Forms.PictureBox();
			this.pictureLeg0 = new global::System.Windows.Forms.PictureBox();
			this.pictureLeg1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureHead).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureArm1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureArm0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBody).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLeg0).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLeg1).BeginInit();
			base.SuspendLayout();
			this.listView1.Items.AddRange(new global::System.Windows.Forms.ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4,
				listViewItem5,
				listViewItem6,
				listViewItem7,
				listViewItem8,
				listViewItem9,
				listViewItem10,
				listViewItem11,
				listViewItem12,
				listViewItem13
			});
			this.listView1.Location = new global::System.Drawing.Point(13, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new global::System.Drawing.Size(121, 192);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new global::System.EventHandler(this.listView1_SelectedIndexChanged);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(140, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(192, 192);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureHead.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureHead.Image");
			this.pictureHead.Location = new global::System.Drawing.Point(221, 13);
			this.pictureHead.Name = "pictureHead";
			this.pictureHead.Size = new global::System.Drawing.Size(32, 32);
			this.pictureHead.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureHead.TabIndex = 2;
			this.pictureHead.TabStop = false;
			this.pictureArm1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureArm1.Image");
			this.pictureArm1.Location = new global::System.Drawing.Point(253, 45);
			this.pictureArm1.Name = "pictureArm1";
			this.pictureArm1.Size = new global::System.Drawing.Size(16, 48);
			this.pictureArm1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureArm1.TabIndex = 3;
			this.pictureArm1.TabStop = false;
			this.pictureArm0.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureArm0.Image");
			this.pictureArm0.Location = new global::System.Drawing.Point(206, 45);
			this.pictureArm0.Name = "pictureArm0";
			this.pictureArm0.Size = new global::System.Drawing.Size(16, 48);
			this.pictureArm0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureArm0.TabIndex = 4;
			this.pictureArm0.TabStop = false;
			this.pictureBody.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBody.Image");
			this.pictureBody.Location = new global::System.Drawing.Point(221, 45);
			this.pictureBody.Name = "pictureBody";
			this.pictureBody.Size = new global::System.Drawing.Size(32, 48);
			this.pictureBody.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBody.TabIndex = 5;
			this.pictureBody.TabStop = false;
			this.pictureLeg0.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureLeg0.Image");
			this.pictureLeg0.Location = new global::System.Drawing.Point(221, 92);
			this.pictureLeg0.Name = "pictureLeg0";
			this.pictureLeg0.Size = new global::System.Drawing.Size(16, 48);
			this.pictureLeg0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureLeg0.TabIndex = 6;
			this.pictureLeg0.TabStop = false;
			this.pictureLeg1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureLeg1.Image");
			this.pictureLeg1.Location = new global::System.Drawing.Point(237, 92);
			this.pictureLeg1.Name = "pictureLeg1";
			this.pictureLeg1.Size = new global::System.Drawing.Size(16, 48);
			this.pictureLeg1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureLeg1.TabIndex = 7;
			this.pictureLeg1.TabStop = false;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.Location = new global::System.Drawing.Point(374, 45);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(32, 32);
			this.button1.TabIndex = 8;
			this.button1.UseVisualStyleBackColor = true;
			this.button2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
			this.button2.Location = new global::System.Drawing.Point(377, 80);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(25, 25);
			this.button2.TabIndex = 9;
			this.button2.UseVisualStyleBackColor = true;
			this.button3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button3.Image");
			this.button3.Location = new global::System.Drawing.Point(374, 107);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(32, 32);
			this.button3.TabIndex = 10;
			this.button3.UseVisualStyleBackColor = true;
			this.button4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button4.Image");
			this.button4.Location = new global::System.Drawing.Point(342, 76);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(32, 32);
			this.button4.TabIndex = 11;
			this.button4.UseVisualStyleBackColor = true;
			this.button5.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button5.Image");
			this.button5.Location = new global::System.Drawing.Point(405, 76);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(32, 32);
			this.button5.TabIndex = 12;
			this.button5.UseVisualStyleBackColor = true;
			this.button6.Location = new global::System.Drawing.Point(362, 181);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(75, 23);
			this.button6.TabIndex = 13;
			this.button6.Text = "Create/Add";
			this.button6.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(445, 218);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureLeg1);
			base.Controls.Add(this.pictureLeg0);
			base.Controls.Add(this.pictureBody);
			base.Controls.Add(this.pictureArm0);
			base.Controls.Add(this.pictureArm1);
			base.Controls.Add(this.pictureHead);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "addOffset";
			this.Text = "Add Offsets";
			base.Load += new global::System.EventHandler(this.addOffset_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureHead).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureArm1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureArm0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBody).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLeg0).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureLeg1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400039D RID: 925
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.ListView listView1;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.PictureBox pictureHead;

		// Token: 0x040003A1 RID: 929
		private global::System.Windows.Forms.PictureBox pictureArm1;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.PictureBox pictureArm0;

		// Token: 0x040003A3 RID: 931
		private global::System.Windows.Forms.PictureBox pictureBody;

		// Token: 0x040003A4 RID: 932
		private global::System.Windows.Forms.PictureBox pictureLeg0;

		// Token: 0x040003A5 RID: 933
		private global::System.Windows.Forms.PictureBox pictureLeg1;

		// Token: 0x040003A6 RID: 934
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Forms.Button button2;

		// Token: 0x040003A8 RID: 936
		private global::System.Windows.Forms.Button button3;

		// Token: 0x040003A9 RID: 937
		private global::System.Windows.Forms.Button button4;

		// Token: 0x040003AA RID: 938
		private global::System.Windows.Forms.Button button5;

		// Token: 0x040003AB RID: 939
		private global::System.Windows.Forms.Button button6;
	}
}
