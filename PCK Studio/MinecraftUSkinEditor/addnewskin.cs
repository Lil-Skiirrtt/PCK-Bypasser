using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using minekampf;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000076 RID: 118
	public partial class addnewskin : MetroForm
	{
		// Token: 0x0600019F RID: 415 RVA: 0x00022174 File Offset: 0x00020374
		public addnewskin(PCK currentPCKIn, TreeView treeView1In, string tempIDIn, LOC loc)
		{
			this.InitializeComponent();
			this.currentLoc = loc;
			this.tbl = new DataTable();
			this.tbl.Columns.Add(new DataColumn("Language")
			{
				ReadOnly = true
			});
			this.tbl.Columns.Add("Display Name");
			this.currentPCK = currentPCKIn;
			this.treeView1 = treeView1In;
			this.localID = tempIDIn;
			this.textSkinID.Text = this.localID;
			base.FormBorderStyle = FormBorderStyle.None;
			this.buttonDone.Enabled = false;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000222B8 File Offset: 0x000204B8
		private void checkImage()
		{
			if (Image.FromFile(this.ofd).Height == 64)
			{
				MessageBox.Show("64x64 Skin Detected");
				this.pictureBoxTexture.Width = this.pictureBoxTexture.Height;
				if (this.skinType != "64x64" && this.skinType != "64x64HD")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X - this.pictureBoxTexture.Width, this.buttonSkin.Location.Y);
				}
				this.comboBoxSkinType.Text = "Steve (64x64)";
				this.comboBoxSkinType.Enabled = true;
				if (this.comboBoxSkinType.Items.Count == 3)
				{
					this.comboBoxSkinType.Items.RemoveAt(0);
				}
				this.skinType = "64x64";
			}
			else if (Image.FromFile(this.ofd).Height == 32)
			{
				MessageBox.Show("64x32 Skin Detected");
				this.pictureBoxTexture.Width = this.pictureBoxTexture.Height * 2;
				if (this.skinType == "64x64")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X + this.pictureBoxTexture.Width / 2, this.buttonSkin.Location.Y);
				}
				if (this.skinType == "64x64HD")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X + this.pictureBoxTexture.Width / 2, this.buttonSkin.Location.Y);
				}
				this.comboBoxSkinType.Text = "Default (64x32)";
				this.comboBoxSkinType.Enabled = false;
				this.skinType = "64x32";
			}
			else if (Image.FromFile(this.ofd).Width == Image.FromFile(this.ofd).Height / 1)
			{
				MessageBox.Show("64x64 HD Skin Detected");
				this.pictureBoxTexture.Width = this.pictureBoxTexture.Height;
				if (this.skinType != "64x64" && this.skinType != "64x64HD")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X - this.pictureBoxTexture.Width, this.buttonSkin.Location.Y);
				}
				this.comboBoxSkinType.Text = "Steve (64x64)";
				this.comboBoxSkinType.Enabled = true;
				if (this.comboBoxSkinType.Items.Count == 3)
				{
					this.comboBoxSkinType.Items.RemoveAt(0);
				}
				this.skinType = "64x64";
			}
			else
			{
				if (Image.FromFile(this.ofd).Width != Image.FromFile(this.ofd).Height / 2)
				{
					MessageBox.Show("Not a Valid Skin File");
					this.skinType = "unusable";
					return;
				}
				MessageBox.Show("64x32 HD Skin Detected");
				this.pictureBoxTexture.Width = this.pictureBoxTexture.Height * 2;
				if (this.skinType == "64x64")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X + this.pictureBoxTexture.Width / 2, this.buttonSkin.Location.Y);
				}
				if (this.skinType == "64x64HD")
				{
					this.buttonSkin.Location = new Point(this.buttonSkin.Location.X + this.pictureBoxTexture.Width / 2, this.buttonSkin.Location.Y);
				}
				this.comboBoxSkinType.Text = "Default (64x32)";
				this.comboBoxSkinType.Enabled = false;
				this.skinType = "64x32";
			}
			this.pictureBoxTexture.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBoxTexture.InterpolationMode = InterpolationMode.NearestNeighbor;
			this.pictureBoxTexture.Image = Image.FromFile(this.ofd);
			this.buttonDone.Enabled = true;
			this.labelSelectTexture.Visible = false;
			this.mf.data = File.ReadAllBytes(this.ofd);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000036BD File Offset: 0x000018BD
		private void textSkinName_TextChanged(object sender, EventArgs e)
		{
			this.skinName.Text = "DISPLAYNAME";
			this.skinName.Tag = this.textSkinName.Text;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00022758 File Offset: 0x00020958
		private void textSkinID_TextChanged(object sender, EventArgs e)
		{
			this.skinId = this.textSkinID.Text;
			this.displayNameId.Text = "DISPLAYNAMEID";
			this.displayNameId.Tag = "IDS_dlcskin" + this.textSkinID.Text + "_DISPLAYNAME";
			this.themeName.Text = "THEMENAME";
			this.themeName.Tag = "dlcskin" + this.textSkinID.Text;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000036E5 File Offset: 0x000018E5
		private void radioSteveModel_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Skin Model Set to Steve Model");
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000036F2 File Offset: 0x000018F2
		private void radioAlexModel_CheckedChanged(object sender, EventArgs e)
		{
			MessageBox.Show("Skin Model Set to Alex Model");
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000036FF File Offset: 0x000018FF
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Must be an 8 digit Number");
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000370C File Offset: 0x0000190C
		private void button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This is the Skins Name You'll See In-Game");
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000227DC File Offset: 0x000209DC
		private void addnewskin_Load(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(Application.StartupPath + "\\temp.png"))
				{
					File.Delete(Application.StartupPath + "\\temp.png");
				}
			}
			catch (Exception)
			{
			}
			if (this.skinType == "unusable")
			{
				base.Close();
			}
			else if (this.skinType == "64x64")
			{
				this.comboBoxSkinType.Text = "Steve (64x64)";
			}
			else if (this.skinType == "64x64HD")
			{
				this.comboBoxSkinType.Text = "Steve (64x64)";
			}
			else if (this.skinType == "64x32")
			{
				this.comboBoxSkinType.Text = "Steve (64x32)";
			}
			else if (this.skinType == "64x32HD")
			{
				this.comboBoxSkinType.Text = "Steve (64x32)";
			}
			Bitmap image = new Bitmap(this.displayBox.Width, this.displayBox.Height);
			using (Graphics graphics = Graphics.FromImage(image))
			{
				graphics.DrawRectangle(Pens.Black, 70, 15, 40, 40);
				graphics.FillRectangle(Brushes.Gray, 71, 16, 39, 39);
				graphics.DrawRectangle(Pens.Black, 70, 55, 40, 60);
				graphics.FillRectangle(Brushes.Gray, 71, 56, 39, 59);
				graphics.DrawRectangle(Pens.Black, 50, 55, 20, 60);
				graphics.FillRectangle(Brushes.Gray, 51, 56, 19, 59);
				graphics.DrawRectangle(Pens.Black, 110, 55, 20, 60);
				graphics.FillRectangle(Brushes.Gray, 111, 56, 19, 59);
				graphics.DrawRectangle(Pens.Black, 70, 115, 20, 60);
				graphics.FillRectangle(Brushes.Gray, 71, 116, 19, 59);
				graphics.DrawRectangle(Pens.Black, 90, 115, 20, 60);
				graphics.FillRectangle(Brushes.Gray, 91, 116, 19, 59);
			}
			this.displayBox.Image = image;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003719 File Offset: 0x00001919
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			this.themeName.Text = "THEMENAME";
			this.themeName.Tag = this.textTheme.Text;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00022A00 File Offset: 0x00020C00
		private void buttonSkin_Click(object sender, EventArgs e)
		{
			this.contextMenuSkin.Show(Form.ActiveForm.Location.X + this.buttonSkin.Location.X + 2, Form.ActiveForm.Location.Y + this.buttonSkin.Location.Y + 23);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00022A6C File Offset: 0x00020C6C
		private void buttonCape_Click(object sender, EventArgs e)
		{
			this.contextMenuCape.Show(Form.ActiveForm.Location.X + this.buttonCape.Location.X + 2, Form.ActiveForm.Location.Y + this.buttonCape.Location.Y + 23);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00022AD8 File Offset: 0x00020CD8
		private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.ofd = openFileDialog.FileName;
				this.checkImage();
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00022B08 File Offset: 0x00020D08
		private void replaceToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					openFileDialog.Filter = "PNG Files | *.png";
					openFileDialog.Title = "Select a PNG File";
					if (Image.FromFile(openFileDialog.FileName).Width == Image.FromFile(openFileDialog.FileName).Height * 2)
					{
						this.useCape = true;
						this.pictureBoxWithInterpolationMode1.SizeMode = PictureBoxSizeMode.StretchImage;
						this.pictureBoxWithInterpolationMode1.InterpolationMode = InterpolationMode.NearestNeighbor;
						this.pictureBoxWithInterpolationMode1.Image = Image.FromFile(openFileDialog.FileName);
						this.mfc.data = File.ReadAllBytes(openFileDialog.FileName);
						this.contextMenuCape.Items[0].Text = "Replace";
					}
					else
					{
						MessageBox.Show("Not a Valid Cape File");
					}
				}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00022BF0 File Offset: 0x00020DF0
		private void button1_Click_1(object sender, EventArgs e)
		{
			try
			{
				if (this.textSkinID.Text.Length / 8 == 1)
				{
					bool flag = false;
					int index = 0;
					foreach (object obj in this.treeView1.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						if (treeNode.Text == "Skins")
						{
							flag = true;
							index = treeNode.Index;
						}
					}
					if (this.useCape)
					{
						try
						{
							this.capePath.Text = "CAPEPATH";
							this.capePath.Tag = "dlccape" + this.textSkinID.Text + ".png";
							object[] item = new object[]
							{
								this.capePath.Text,
								this.capePath.Tag
							};
							this.mf.entries.Add(item);
							this.currentPCK.mineFiles.Add(this.mfc);
							this.mfc.filesize = this.mf.data.Length;
							if (flag)
							{
								this.mfc.name = "Skins/dlccape" + this.textSkinID.Text + ".png";
							}
							else
							{
								this.mfc.name = "dlccape" + this.textSkinID.Text + ".png";
							}
							this.mfc.type = 1;
							this.cape.Text = "dlccape" + this.textSkinID.Text + ".png";
							this.cape.Tag = this.mfc;
							this.cape.ImageIndex = 2;
							this.cape.SelectedImageIndex = 2;
							if (flag)
							{
								this.treeView1.Nodes[index].Nodes.Add(this.cape);
							}
							else
							{
								this.treeView1.Nodes.Add(this.cape);
							}
						}
						catch (Exception)
						{
							MessageBox.Show("Cape Could Not be Added");
						}
					}
					this.currentPCK.mineFiles.Add(this.mf);
					this.free.Text = "FREE";
					this.free.Tag = "1";
					this.themeName.Text = "THEMENAME";
					this.themeName.Tag = this.textThemeName.Text;
					this.displayNameId.Text = "DISPLAYNAMEID";
					this.displayNameId.Tag = "IDS_dlcskin" + this.textSkinID.Text + "_DISPLAYNAME";
					this.skinName.Text = "DISPLAYNAME";
					this.skinName.Tag = this.textSkinName.Text;
					this.anim.Text = "ANIM";
					object[] item2 = new object[]
					{
						this.skinName.Text,
						this.skinName.Tag
					};
					this.mf.entries.Add(item2);
					object[] item3 = new object[]
					{
						this.displayNameId.Text,
						this.displayNameId.Tag
					};
					this.mf.entries.Add(item3);
					if (!(this.comboBoxSkinType.Text == "Default (64x32)"))
					{
						if (this.comboBoxSkinType.Text == "Alex (64x64)" && this.skinType != "64x32")
						{
							this.anim.Tag = "0x80000";
							object[] item4 = new object[]
							{
								this.anim.Text,
								this.anim.Tag
							};
							this.mf.entries.Add(item4);
						}
						else if (this.comboBoxSkinType.Text == "Steve (64x64)" && this.skinType != "64x32")
						{
							this.anim.Tag = "0x40000";
							object[] item5 = new object[]
							{
								this.anim.Text,
								this.anim.Tag
							};
							this.mf.entries.Add(item5);
						}
						else if (this.comboBoxSkinType.Text == "Custom")
						{
							this.anim.Tag = "0x7ff5fc10";
							foreach (object[] item6 in this.generatedModel)
							{
								this.mf.entries.Add(item6);
							}
							object[] item7 = new object[]
							{
								this.anim.Text,
								this.anim.Tag
							};
							this.mf.entries.Add(item7);
						}
					}
					if (this.generatedModel != null)
					{
						this.generatedModel.Clear();
					}
					if (this.themeName.Tag.ToString() != "")
					{
						object[] item8 = new object[]
						{
							this.themeName.Text,
							this.themeName.Tag
						};
						this.mf.entries.Add(item8);
					}
					object[] item9 = new object[]
					{
						"GAME_FLAGS",
						"0x18"
					};
					this.mf.entries.Add(item9);
					object[] item10 = new object[]
					{
						this.free.Text,
						this.free.Tag
					};
					this.mf.entries.Add(item10);
					this.mf.filesize = this.mf.data.Length;
					if (flag)
					{
						this.mf.name = "Skins/dlcskin" + this.textSkinID.Text + ".png";
					}
					else
					{
						this.mf.name = "dlcskin" + this.textSkinID.Text + ".png";
					}
					this.mf.type = 0;
					this.skin.Text = "dlcskin" + this.textSkinID.Text + ".png";
					this.skin.Tag = this.mf;
					this.skin.ImageIndex = 2;
					this.skin.SelectedImageIndex = 2;
					if (flag)
					{
						this.treeView1.Nodes[index].Nodes.Add(this.skin);
					}
					else
					{
						this.treeView1.Nodes.Add(this.skin);
					}
					addnewskin.displayId displayId = new addnewskin.displayId();
					displayId.id = "IDS_dlcskin" + this.textSkinID.Text + "_DISPLAYNAME";
					displayId.defaultName = this.textSkinName.Text;
					this.currentLoc.ids.names.Add(displayId.id);
					foreach (LOC.Language language in this.currentLoc.langs)
					{
						language.names.Add(displayId.defaultName);
					}
					addnewskin.displayId displayId2 = new addnewskin.displayId();
					displayId2.id = "IDS_dlcskin" + this.textSkinID.Text + "_THEMENAME";
					displayId2.defaultName = this.textThemeName.Text;
					this.currentLoc.ids.names.Add(displayId2.id);
					foreach (LOC.Language language2 in this.currentLoc.langs)
					{
						language2.names.Add(displayId2.defaultName);
					}
					base.Close();
				}
				else
				{
					MessageBox.Show("The Skin ID Must be a Unique 8 Digit Number Thats Not Already in Use");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				MessageBox.Show("The Skin ID Must be a Unique 8 Digit Number Thats Not Already in Use");
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000234A4 File Offset: 0x000216A4
		private void textSkinID_TextChanged_1(object sender, EventArgs e)
		{
			bool flag = true;
			if (this.textSkinID.Text.Length == 8)
			{
				try
				{
					int.Parse(this.textSkinID.Text);
					goto IL_2F;
				}
				catch
				{
					flag = false;
					goto IL_2F;
				}
			}
			flag = false;
			IL_2F:
			if (!flag)
			{
				this.textSkinID.ForeColor = Color.Red;
				return;
			}
			if (flag)
			{
				this.textSkinID.ForeColor = Color.Green;
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void textSkinName_VisibleChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void textThemeName_VisibleChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void textThemeName_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00023518 File Offset: 0x00021718
		private void button2_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Create your own custom skin model?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
			{
				return;
			}
			PictureBox pictureBox = new PictureBox();
			if (new generateModel(this.generatedModel, pictureBox).ShowDialog() == DialogResult.OK)
			{
				this.comboBoxSkinType.Items.Add("Custom");
				this.comboBoxSkinType.Text = "Custom";
				this.displayBox.Image = pictureBox.Image;
				try
				{
					using (FileStream fileStream = new FileStream(Application.StartupPath + "\\temp.png", FileMode.Open, FileAccess.Read))
					{
						this.pictureBoxTexture.SizeMode = PictureBoxSizeMode.StretchImage;
						this.pictureBoxTexture.InterpolationMode = InterpolationMode.NearestNeighbor;
						this.pictureBoxTexture.Image = Image.FromStream(fileStream);
						fileStream.Close();
						fileStream.Dispose();
					}
					this.ofd = Application.StartupPath + "\\temp.png";
					this.pictureBoxTexture.Width = this.pictureBoxTexture.Height;
					this.buttonDone.Enabled = true;
					this.labelSelectTexture.Visible = false;
					if (this.skinType != "64x64" && this.skinType != "64x64HD")
					{
						this.buttonSkin.Location = new Point(this.buttonSkin.Location.X - this.pictureBoxTexture.Width, this.buttonSkin.Location.Y);
						this.skinType = "64x64";
					}
					this.mf.data = File.ReadAllBytes(this.ofd);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00003741 File Offset: 0x00001941
		private void button3_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Feature not Available in Beta");
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000236F8 File Offset: 0x000218F8
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.radioSERVER.Checked;
			checked
			{
				if (@checked)
				{
					Random random = new Random();
					int num = random.Next(1111111, 9999999);
					try
					{
						bool flag = this.skinid == null;
						if (flag)
						{
							this.serverID = num.ToString();
						}
						bool flag2 = this.serverID.Length < 8;
						if (flag2)
						{
							int num2 = 8 - this.serverID.Length;
							do
							{
								this.serverID = "0" + this.serverID;
								num2--;
							}
							while (num2 > 0);
						}
						this.textSkinID.Text = this.serverID;
						this.textSkinID.Enabled = false;
					}
					catch (Exception)
					{
						MessageBox.Show("Could Not Connect");
						this.radioLOCAL.Checked = true;
					}
				}
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000374E File Offset: 0x0000194E
		private void radioLOCAL_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioLOCAL.Checked)
			{
				this.textSkinID.Text = this.localID;
				this.textSkinID.Enabled = true;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000237EC File Offset: 0x000219EC
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "PNG Files | *.png";
				openFileDialog.Title = "Select a PNG File";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.ofd = openFileDialog.FileName;
					this.checkImage();
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000237EC File Offset: 0x000219EC
		private void label4_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "PNG Files | *.png";
				openFileDialog.Title = "Select a PNG File";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.ofd = openFileDialog.FileName;
					this.checkImage();
				}
			}
		}

		// Token: 0x04000369 RID: 873
		private PCK currentPCK;

		// Token: 0x0400036A RID: 874
		private DataTable tbl;

		// Token: 0x0400036B RID: 875
		private LOC currentLoc;

		// Token: 0x0400036C RID: 876
		private PCK.MineFile mf = new PCK.MineFile();

		// Token: 0x0400036D RID: 877
		private PCK.MineFile mfc = new PCK.MineFile();

		// Token: 0x0400036E RID: 878
		private TreeView treeView1;

		// Token: 0x0400036F RID: 879
		private string skinId = "";

		// Token: 0x04000370 RID: 880
		private TreeNode skin = new TreeNode();

		// Token: 0x04000371 RID: 881
		private TreeNode cape = new TreeNode();

		// Token: 0x04000372 RID: 882
		private TreeNode skinName = new TreeNode();

		// Token: 0x04000373 RID: 883
		private TreeNode displayNameId = new TreeNode();

		// Token: 0x04000374 RID: 884
		private TreeNode themeName = new TreeNode();

		// Token: 0x04000375 RID: 885
		private TreeNode themeNameId = new TreeNode();

		// Token: 0x04000376 RID: 886
		private TreeNode anim = new TreeNode();

		// Token: 0x04000377 RID: 887
		private TreeNode free = new TreeNode();

		// Token: 0x04000378 RID: 888
		private TreeNode theme = new TreeNode();

		// Token: 0x04000379 RID: 889
		private TreeNode capePath = new TreeNode();

		// Token: 0x0400037A RID: 890
		private string skinType = "";

		// Token: 0x0400037B RID: 891
		private string ofd;

		// Token: 0x0400037C RID: 892
		private bool useCape;

		// Token: 0x0400037D RID: 893
		private string capeID;

		// Token: 0x0400037E RID: 894
		private string localID;

		// Token: 0x0400037F RID: 895
		private string serverID;

		// Token: 0x04000380 RID: 896
		private string skinid;

		// Token: 0x04000381 RID: 897
		private List<object[]> generatedModel = new List<object[]>();

		// Token: 0x04000383 RID: 899
		private RadioButton radioUpsideDown;

		// Token: 0x04000384 RID: 900
		private TextBox textBox1;

		// Token: 0x02000077 RID: 119
		public class displayId
		{
			// Token: 0x0400039B RID: 923
			public string id;

			// Token: 0x0400039C RID: 924
			public string defaultName;
		}
	}
}
