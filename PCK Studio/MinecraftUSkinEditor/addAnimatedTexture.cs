using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000072 RID: 114
	public partial class addAnimatedTexture : MetroForm
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00021104 File Offset: 0x0001F304
		public addAnimatedTexture(PCK currentPCKIn, TreeView treeView1In, string ofdIn, string name)
		{
			this.InitializeComponent();
			this.textBox1.Text = name;
			this.currentPCK = currentPCKIn;
			this.treeView1 = treeView1In;
			this.ofd = ofdIn;
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.pictureBox1.Image = Image.FromFile(this.ofd);
			this.mf.data = File.ReadAllBytes(this.ofd);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000211A4 File Offset: 0x0001F3A4
		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				int num = int.Parse(this.textBox2.Text);
				this.speed = int.Parse(this.textBox3.Text);
				this.data = "0*" + this.speed + ",";
				this.loop = num - 1;
				this.generateANIM();
				object[] item = new object[]
				{
					"ANIM",
					this.data
				};
				this.mf.entries.Add(item);
				string text;
				if (this.radioButton1.Checked)
				{
					text = "res/textures/blocks/" + this.textBox1.Text + ".png";
				}
				else
				{
					text = "res/textures/items/" + this.textBox1.Text + ".png";
				}
				this.mf.filesize = this.mf.data.Length;
				this.mf.name = text;
				this.mf.type = 0;
				this.currentPCK.mineFiles.Add(this.mf);
				this.texture.Text = text;
				this.texture.Tag = this.mf;
				this.treeView1.Nodes.Insert(17, this.texture);
				base.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("Invalid values were entered");
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00021328 File Offset: 0x0001F528
		private void generateANIM()
		{
			do
			{
				this.i++;
				this.data = string.Concat(new object[]
				{
					this.data,
					this.i,
					"*",
					this.speed,
					","
				});
				this.loop--;
			}
			while (this.loop != 0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void addAnimatedTexture_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000342 RID: 834
		private PCK currentPCK;

		// Token: 0x04000343 RID: 835
		private TreeView treeView1;

		// Token: 0x04000344 RID: 836
		private TreeNode texture = new TreeNode();

		// Token: 0x04000345 RID: 837
		private PCK.MineFile mf = new PCK.MineFile();

		// Token: 0x04000346 RID: 838
		private PCK.MineFile mfc = new PCK.MineFile();

		// Token: 0x04000347 RID: 839
		private string ofd;

		// Token: 0x04000348 RID: 840
		private bool useCape;

		// Token: 0x04000349 RID: 841
		private int loop;

		// Token: 0x0400034A RID: 842
		private int i;

		// Token: 0x0400034B RID: 843
		private string data;

		// Token: 0x0400034C RID: 844
		private int speed;

		// Token: 0x02000073 RID: 115
		public class displayId
		{
			// Token: 0x04000358 RID: 856
			public string id;

			// Token: 0x04000359 RID: 857
			public string defaultName;
		}
	}
}
