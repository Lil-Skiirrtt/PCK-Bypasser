using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using minekampf;
using minekampf.Forms;
using minekampf.Properties;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000082 RID: 130
	public partial class FormMain : MetroForm
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00027224 File Offset: 0x00025424
		public FormMain()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			Label label = this.labelVersion;
			label.Text += this.ver;
			this.pckOpen.AllowDrop = true;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00027294 File Offset: 0x00025494
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					openFileDialog.CheckFileExists = true;
					openFileDialog.Filter = "PCK (Minecraft Console Package)|*.pck";
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						this.openPck(openFileDialog.FileName);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("The PCK you're trying to use currently isn't supported");
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00027308 File Offset: 0x00025508
		private void openPck(string filePath)
		{
			new TabPage();
			this.treeViewMain.Nodes.Clear();
			PCK pck = new PCK(filePath);
			this.currentPCK = pck;
			foreach (PCK.MineFile mineFile in pck.mineFiles)
			{
				if (mineFile.name == "0")
				{
					foreach (object[] array in mineFile.entries)
					{
						if (array[0].ToString() == "LOCK" && (new pckLocked(array[1].ToString(), FormMain.correct).ShowDialog() != DialogResult.OK || FormMain.correct))
						{
							return;
						}
					}
				}
			}
			this.openedPCKS.SelectedTab.Text = Path.GetFileName(filePath);
			this.saveLocation = filePath;
			TreeView treeView = this.treeViewMain;
			PictureBoxWithInterpolationMode pictureBoxWithInterpolationMode = this.pictureBoxImagePreview;
			TreeView treeView2 = this.treeMeta;
			TextBox textBox = this.textBox1;
			Label label = this.label1;
			Label label2 = this.label2;
			TabControl tabControl = this.tabDataDisplay;
			ImageList imageList = new ImageList();
			imageList.ColorDepth = ColorDepth.Depth32Bit;
			imageList.ImageSize = new Size(20, 20);
			imageList.Images.Add(Resources.ZZFolder);
			imageList.Images.Add(Resources.BINKA_ICON);
			imageList.Images.Add(Resources.IMAGE_ICON);
			imageList.Images.Add(Resources.LOC_ICON);
			imageList.Images.Add(Resources.PCK_ICON);
			imageList.Images.Add(Resources.ZUnknown);
			this.treeViewMain.ImageList = imageList;
			foreach (PCK.MineFile mineFile2 in pck.mineFiles)
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Text = mineFile2.name;
				treeNode.Tag = mineFile2;
				string text = "";
				int num = 0;
				new List<string>();
				TreeNodeCollection nodes = this.treeViewMain.Nodes;
				do
				{
					text = "";
					foreach (char c in mineFile2.name)
					{
						bool flag = false;
						if (c == '/')
						{
							foreach (object obj in nodes)
							{
								TreeNode treeNode2 = (TreeNode)obj;
								if (treeNode2.Text == text)
								{
									nodes = nodes[treeNode2.Index].Nodes;
									flag = true;
								}
							}
							if (!flag)
							{
								nodes.Add(text);
								nodes = nodes[nodes.Count - 1].Nodes;
							}
							flag = false;
							text = "";
						}
						else
						{
							text += c.ToString();
						}
						num++;
					}
				}
				while (num != mineFile2.name.Length);
				if (Path.GetExtension(text) == ".binka")
				{
					treeNode.ImageIndex = 1;
					treeNode.SelectedImageIndex = 1;
				}
				else if (Path.GetExtension(text) == ".png")
				{
					treeNode.ImageIndex = 2;
					treeNode.SelectedImageIndex = 2;
				}
				else if (Path.GetExtension(text) == ".loc")
				{
					treeNode.ImageIndex = 3;
					treeNode.SelectedImageIndex = 3;
				}
				else if (Path.GetExtension(text) == ".pck")
				{
					treeNode.ImageIndex = 4;
					treeNode.SelectedImageIndex = 4;
				}
				else
				{
					treeNode.ImageIndex = 5;
					treeNode.SelectedImageIndex = 5;
				}
				treeNode.Text = text;
				nodes.Add(treeNode);
				this.saved = false;
			}
			this.myTablePanelStartScreen.Visible = false;
			this.pckOpen.Visible = false;
			this.label5.Visible = false;
			this.labelAmount.Visible = true;
			this.richTextBoxChangelog.Visible = false;
			this.openedPCKS.Visible = true;
			foreach (object obj2 in this.fileToolStripMenuItem.DropDownItems)
			{
				((ToolStripMenuItem)obj2).Enabled = true;
			}
			foreach (object obj3 in this.editToolStripMenuItem.DropDownItems)
			{
				((ToolStripMenuItem)obj3).Enabled = true;
			}
			foreach (object obj4 in this.treeViewMain.Nodes)
			{
				TreeNode treeNode3 = (TreeNode)obj4;
				if (treeNode3.Text == "languages.loc")
				{
					this.mfLoc = (PCK.MineFile)this.treeViewMain.Nodes[treeNode3.Index].Tag;
				}
				if (treeNode3.Text == "localisation.loc")
				{
					this.mfLoc = (PCK.MineFile)this.treeViewMain.Nodes[treeNode3.Index].Tag;
				}
			}
			this.fileCount = 0;
			foreach (PCK.MineFile mineFile3 in this.currentPCK.mineFiles)
			{
				this.fileCount++;
			}
			this.labelAmount.Text = "Files:" + this.fileCount;
			this.saved = false;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000279B8 File Offset: 0x00025BB8
		private void selectNode(object sender, TreeViewEventArgs e)
		{
			this.treeMeta.Enabled = true;
			int num = this.tabPage1.Height / 2 - this.tabPage1.Height / 10;
			if (this.treeViewMain.SelectedNode.Tag != null)
			{
				this.fileCount = 0;
				foreach (PCK.MineFile mineFile in this.currentPCK.mineFiles)
				{
					this.fileCount++;
				}
				this.labelAmount.Text = "Files:" + this.fileCount;
				Dictionary<int, string> dictionary = this.currentPCK.types;
				PCK.MineFile mineFile2 = (PCK.MineFile)e.Node.Tag;
				this.types = this.currentPCK.types;
				this.file = mineFile2;
				this.treeMeta.Nodes.Clear();
				this.comboBox1.Items.Clear();
				this.textBox1.Text = "";
				foreach (int key in this.types.Keys)
				{
					this.comboBox1.Items.Add(this.types[key]);
				}
				int num2 = 0;
				foreach (object[] array in this.file.entries)
				{
					object[] array2 = array;
					TreeNode treeNode = new TreeNode();
					foreach (object[] array3 in this.file.entries)
					{
						treeNode.Text = (string)array2[0];
					}
					treeNode.Tag = array;
					this.treeMeta.Nodes.Add(treeNode);
					if (array[0].ToString() == "BOX")
					{
						num2++;
						this.buttonEdit.Text = "EDIT BOXES";
						this.buttonEdit.Visible = true;
					}
					else if (num2 == 0)
					{
						this.buttonEdit.Visible = false;
					}
				}
				if (Path.GetExtension(mineFile2.name) == ".png")
				{
					this.pictureBoxImagePreview.SizeMode = PictureBoxSizeMode.StretchImage;
					this.pictureBoxImagePreview.InterpolationMode = InterpolationMode.NearestNeighbor;
					Image image = Image.FromStream(new MemoryStream(mineFile2.data));
					this.pictureBoxImagePreview.Image = image;
					if (image.Size.Height == image.Size.Width / 2)
					{
						this.pictureBoxImagePreview.Size = new Size(num * 2, num);
						this.labelImageSize.Text = image.Size.Width.ToString() + "x" + image.Size.Height.ToString();
						return;
					}
					if (image.Size.Height == image.Size.Width)
					{
						this.pictureBoxImagePreview.Size = new Size(num, num);
						this.labelImageSize.Text = image.Size.Width.ToString() + "x" + image.Size.Height.ToString();
						return;
					}
					Size size = new Size(this.tabPage1.Size.Width / 2 - 5, this.tabPage1.Size.Height / 2 - 5);
					if (image.Size.Width > size.Width)
					{
						float num3 = (float)image.Width / (float)image.Height;
						int num4 = (int)((float)size.Height * num3);
						int num5 = (int)((float)num4 / num3);
						if (num4 > image.Width || num5 > image.Height)
						{
							if (num4 > num5)
							{
								num4 = size.Width;
								num5 = (int)((float)num4 / num3);
							}
							else
							{
								num5 = size.Height;
								num4 = (int)((float)num5 * num3);
							}
						}
						this.pictureBoxImagePreview.Size = new Size(num4, num5);
					}
					else if (image.Size.Height > size.Height)
					{
						float num6 = (float)image.Width / (float)image.Height;
						int num7 = (int)((float)size.Width * num6);
						int num8 = (int)((float)num7 / num6);
						if (num7 > image.Width || num8 > image.Height)
						{
							if (num7 > num8)
							{
								num7 = size.Width;
								num8 = (int)((float)num7 / num6);
							}
							else
							{
								num8 = size.Height;
								num7 = (int)((float)num8 * num6);
							}
						}
						this.pictureBoxImagePreview.Size = new Size(num7, num8);
					}
					else
					{
						this.pictureBoxImagePreview.Size = new Size(image.Size.Width, image.Size.Height);
					}
					this.labelImageSize.Text = image.Size.Width.ToString() + "x" + image.Size.Height.ToString();
					return;
				}
				else if (Path.GetExtension(mineFile2.name) == ".loc")
				{
					this.buttonEdit.Text = "EDIT LOC";
					this.buttonEdit.Visible = true;
				}
				else
				{
					this.buttonEdit.Visible = false;
					this.pictureBoxImagePreview.Image = Resources.NoImageFound;
					this.pictureBoxImagePreview.Size = new Size(num, num);
					this.labelImageSize.Text = "";
				}
			}
			else
			{
				this.pictureBoxImagePreview.Image = Resources.NoImageFound;
				this.pictureBoxImagePreview.Size = new Size(num, num);
			}
			this.labelImageSize.Text = "";
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0002802C File Offset: 0x0002622C
		public void editModel(PCK.MineFile skin)
		{
			List<object[]> list = new List<object[]>();
			List<object[]> list2 = new List<object[]>();
			foreach (object[] array in skin.entries)
			{
				if (array[0].ToString() == "BOX")
				{
					list2.Add(array);
				}
				else if (array[0].ToString() == "OFFSET")
				{
					list2.Add(array);
				}
				else if (array[0].ToString() != "BOX" && array[0].ToString() != "OFFSET")
				{
					list.Add(array);
				}
			}
			skin.entries = list;
			new generateModel(list2, new PictureBox()).ShowDialog();
			foreach (object[] item in list2)
			{
				skin.entries.Add(item);
			}
			this.treeMeta.Nodes.Clear();
			this.comboBox1.Items.Clear();
			this.textBox1.Text = "";
			foreach (int key in this.types.Keys)
			{
				this.comboBox1.Items.Add(this.types[key]);
			}
			foreach (object[] array2 in this.file.entries)
			{
				object[] array3 = array2;
				TreeNode treeNode = new TreeNode();
				foreach (object[] array4 in this.file.entries)
				{
					treeNode.Text = (string)array3[0];
				}
				treeNode.Tag = array2;
				this.treeMeta.Nodes.Add(treeNode);
			}
			this.saved = false;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002829C File Offset: 0x0002649C
		private void extractToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode.Tag is PCK.MineFile)
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.ShowDialog();
				string text = Path.Combine(saveFileDialog.FileName, ((PCK.MineFile)this.treeViewMain.SelectedNode.Tag).name);
				if (!string.IsNullOrWhiteSpace(Path.GetDirectoryName(text)))
				{
					Directory.CreateDirectory(Path.GetDirectoryName(text));
					File.WriteAllBytes(text, ((PCK.MineFile)this.treeViewMain.SelectedNode.Tag).data);
					if (this.treeViewMain.SelectedNode.Tag.ToString() != "")
					{
						try
						{
							string text2 = "";
							this.types = this.currentPCK.types;
							this.file = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
							new MemoryStream(File.ReadAllBytes(text).ToArray<byte>());
							MemoryStream stream = new MemoryStream();
							new Bitmap(Image.FromFile(text)).Save(stream, ImageFormat.Png);
							foreach (object[] array in this.file.entries)
							{
								text2 = string.Concat(new string[]
								{
									text2,
									(string)array[0],
									":",
									(string)array[1],
									Environment.NewLine
								});
							}
							File.WriteAllText(text + ".txt", text2);
						}
						catch (Exception)
						{
						}
						MessageBox.Show("File Extracted");
						return;
					}
				}
			}
			else if (this.treeViewMain.SelectedNode != null)
			{
				SaveFileDialog saveFileDialog2 = new SaveFileDialog();
				saveFileDialog2.ShowDialog();
				string fileName = saveFileDialog2.FileName;
				foreach (object obj in this.treeViewMain.SelectedNode.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (treeNode.Tag is PCK.MineFile)
					{
						string text3 = Path.Combine(fileName, ((PCK.MineFile)treeNode.Tag).name);
						if (!string.IsNullOrWhiteSpace(Path.GetDirectoryName(text3)))
						{
							Directory.CreateDirectory(Path.GetDirectoryName(text3));
							File.WriteAllBytes(text3, ((PCK.MineFile)treeNode.Tag).data);
							if (treeNode.Tag.ToString() != "")
							{
								try
								{
									string text4 = "";
									this.types = this.currentPCK.types;
									this.file = this.mf;
									new MemoryStream(File.ReadAllBytes(text3).ToArray<byte>());
									MemoryStream stream2 = new MemoryStream();
									new Bitmap(Image.FromFile(text3)).Save(stream2, ImageFormat.Png);
									foreach (object[] array2 in this.file.entries)
									{
										text4 = string.Concat(new string[]
										{
											text4,
											(string)array2[0],
											":",
											(string)array2[1],
											Environment.NewLine
										});
									}
									File.WriteAllText(text3 + ".txt", text4);
								}
								catch (Exception)
								{
								}
								MessageBox.Show("Path Extracted");
							}
						}
					}
				}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00028694 File Offset: 0x00026894
		private void save(string saveType)
		{
			TreeView treeView = new TreeView();
			foreach (object obj in this.treeViewMain.Nodes)
			{
				TreeNode treeNode = (TreeNode)obj;
				TreeNode treeNode2 = new TreeNode();
				if (treeNode.Parent != null)
				{
					string str = "";
					List<TreeNode> list = new List<TreeNode>();
					this.GetPathToRoot(this.treeViewMain.SelectedNode, list);
					foreach (TreeNode treeNode3 in list)
					{
						str = str + treeNode3.Text + "/";
					}
					treeNode2.Text = str + treeNode.Text;
				}
				else
				{
					treeNode2.Text = treeNode.Text;
				}
				treeNode2.Tag = treeNode.Tag;
				treeView.Nodes.Add(treeNode2);
				treeNode2.Remove();
			}
			foreach (object obj2 in treeView.Nodes)
			{
				TreeNode treeNode4 = (TreeNode)obj2;
				this.currentPCK.mineFiles[treeNode4.Index] = (PCK.MineFile)treeNode4.Tag;
			}
			for (int i = 0; i < treeView.Nodes.Count; i++)
			{
				this.currentPCK.mineFiles[i].name = treeView.Nodes[i].Text;
			}
			if (this.saveLocation == Application.StartupPath + "\\templates\\UntitledSkinPCK.pck")
			{
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "PCK (Minecraft Console Package)|*.pck";
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						try
						{
							File.WriteAllBytes(saveFileDialog.FileName, this.currentPCK.Rebuild());
							this.saveLocation = saveFileDialog.FileName;
							this.openedPCKS.SelectedTab.Text = Path.GetFileName(saveFileDialog.FileName);
							this.saved = true;
							MessageBox.Show("PCK Saved!");
						}
						catch (Exception)
						{
							MessageBox.Show("No PCK loaded");
						}
					}
					goto IL_3D6;
				}
			}
			if (saveType == "Save As")
			{
				using (SaveFileDialog saveFileDialog2 = new SaveFileDialog())
				{
					saveFileDialog2.Filter = "PCK (Minecraft Console Package)|*.pck";
					if (saveFileDialog2.ShowDialog() == DialogResult.OK)
					{
						try
						{
							File.WriteAllBytes(saveFileDialog2.FileName, this.currentPCK.Rebuild());
							this.saveLocation = saveFileDialog2.FileName;
							this.openedPCKS.SelectedTab.Text = Path.GetFileName(saveFileDialog2.FileName);
							this.saved = true;
							MessageBox.Show("PCK Saved!");
						}
						catch (Exception)
						{
							MessageBox.Show("No PCK loaded");
						}
					}
					goto IL_3D6;
				}
			}
			if (MessageBox.Show("Are you sure you wanna save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				try
				{
					File.WriteAllBytes(this.saveLocation, this.currentPCK.Rebuild());
				}
				catch (Exception)
				{
					for (int j = 0; j < treeView.Nodes.Count; j++)
					{
						this.currentPCK.mineFiles[j].name = treeView.Nodes[j].Text;
					}
					using (SaveFileDialog saveFileDialog3 = new SaveFileDialog())
					{
						saveFileDialog3.Filter = "PCK (Minecraft Console Package)|*.pck";
						if (saveFileDialog3.ShowDialog() == DialogResult.OK)
						{
							try
							{
								File.WriteAllBytes(saveFileDialog3.FileName, this.currentPCK.Rebuild());
								this.saved = true;
								MessageBox.Show("PCK Saved!");
							}
							catch (Exception)
							{
								MessageBox.Show("No PCK loaded");
							}
						}
					}
				}
			}
			IL_3D6:
			treeView.Dispose();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00028AFC File Offset: 0x00026CFC
		private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode.Tag is PCK.MineFile)
			{
				PCK.MineFile mineFile = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						mineFile.data = File.ReadAllBytes(openFileDialog.FileName);
						mineFile.filesize = mineFile.data.Length;
					}
				}
			}
			this.saved = false;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003ACB File Offset: 0x00001CCB
		private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
		{
			this.saved = false;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00028B88 File Offset: 0x00026D88
		private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode.Tag is PCK.MineFile)
			{
				PCK.MineFile item = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
				this.treeViewMain.Nodes.Remove(this.treeViewMain.SelectedNode);
				this.currentPCK.mineFiles.Remove(item);
			}
			else if (MessageBox.Show("Are you sure want to delete this folder? All contents will be deleted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				foreach (object obj in this.treeViewMain.SelectedNode.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (treeNode.Tag == null)
					{
						MessageBox.Show("Can't fully delete directory with subdirectories");
						return;
					}
					if (treeNode.Tag is PCK.MineFile)
					{
						PCK.MineFile item2 = (PCK.MineFile)treeNode.Tag;
						this.currentPCK.mineFiles.Remove(item2);
						treeNode.Remove();
					}
				}
				this.treeViewMain.SelectedNode.Remove();
			}
			this.saved = false;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00028CBC File Offset: 0x00026EBC
		private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					PCK.MineFile mineFile = new PCK.MineFile();
					mineFile.data = File.ReadAllBytes(openFileDialog.FileName);
					mineFile.filesize = mineFile.data.Length;
					mineFile.name = Path.GetFileName(openFileDialog.FileName);
					mineFile.type = 0;
					TreeNode treeNode = new TreeNode(mineFile.name)
					{
						Tag = mineFile
					};
					if (Path.GetExtension(treeNode.Text) == ".binka")
					{
						treeNode.ImageIndex = 1;
						treeNode.SelectedImageIndex = 1;
					}
					else if (Path.GetExtension(treeNode.Text) == ".png")
					{
						treeNode.ImageIndex = 2;
						treeNode.SelectedImageIndex = 2;
					}
					else if (Path.GetExtension(treeNode.Text) == ".loc")
					{
						treeNode.ImageIndex = 3;
						treeNode.SelectedImageIndex = 3;
					}
					else if (Path.GetExtension(treeNode.Text) == ".pck")
					{
						treeNode.ImageIndex = 4;
						treeNode.SelectedImageIndex = 4;
					}
					else
					{
						treeNode.ImageIndex = 5;
						treeNode.SelectedImageIndex = 5;
					}
					if (this.treeViewMain.SelectedNode.Tag == null)
					{
						this.treeViewMain.SelectedNode.Nodes.Add(treeNode);
						this.currentPCK.mineFiles.Insert(this.treeViewMain.SelectedNode.Nodes.Count - 1, mineFile);
						string str = "";
						List<TreeNode> list = new List<TreeNode>();
						this.GetPathToRoot(this.treeViewMain.SelectedNode, list);
						foreach (TreeNode treeNode2 in list)
						{
							str = str + treeNode2.Text + "/";
						}
						this.currentPCK.mineFiles[this.treeViewMain.SelectedNode.Nodes.Count - 1].name = str + this.treeViewMain.SelectedNode.Nodes[this.treeViewMain.SelectedNode.Nodes.Count - 1].Text;
					}
					else
					{
						this.currentPCK.mineFiles.Add(mineFile);
						this.treeViewMain.Nodes.Add(treeNode);
					}
				}
			}
			this.saved = false;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00003AD4 File Offset: 0x00001CD4
		private void GetPathToRoot(TreeNode node, List<TreeNode> path)
		{
			if (node == null)
			{
				return;
			}
			path.Insert(0, node);
			this.GetPathToRoot(node.Parent, path);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00028F5C File Offset: 0x0002715C
		private void createSkinToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int index = this.treeViewMain.Nodes.Count - 1;
			int num;
			try
			{
				num = int.Parse(this.treeViewMain.Nodes[index].Text.Remove(this.treeViewMain.Nodes[index].Text.Length - 4, 4).Remove(0, 8)) + 1;
			}
			catch (Exception)
			{
				num = 0;
			}
			PCK.MineFile mineFile = this.mfLoc;
			try
			{
				this.l = new LOC(mineFile.data);
			}
			catch
			{
				MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			addnewskin addnewskin = new addnewskin(this.currentPCK, this.treeViewMain, num.ToString(), this.l);
			addnewskin.ShowDialog();
			mineFile.data = this.l.Rebuild();
			addnewskin.Dispose();
			this.saved = false;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0002905C File Offset: 0x0002725C
		private void createAnimatedTextureToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "PNG Files | *.png";
				openFileDialog.Title = "Select a PNG File";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					addAnimatedTexture addAnimatedTexture = new addAnimatedTexture(this.currentPCK, this.treeViewMain, openFileDialog.FileName, Path.GetFileName(openFileDialog.FileName).Remove(Path.GetFileName(openFileDialog.FileName).Length - 4, 4));
					addAnimatedTexture.ShowDialog();
					addAnimatedTexture.Dispose();
				}
			}
			this.saved = false;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000290F8 File Offset: 0x000272F8
		private void treeView1_DoubleClick(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode.Tag != null)
			{
				this.mf = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
				if (Path.GetExtension(this.mf.name) == ".loc" && this.treeViewMain.SelectedNode.Tag is PCK.MineFile)
				{
					LOC loc;
					try
					{
						loc = new LOC(this.mf.data);
					}
					catch
					{
						MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
					new LOCEditor(loc).ShowDialog();
					this.mf.data = loc.Rebuild();
				}
				if (Path.GetExtension(this.mf.name) == ".col")
				{
					MessageBox.Show(".COL Editor Coming Soon!");
				}
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000291E8 File Offset: 0x000273E8
		private void treeMeta_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.comboBox1.Items.Clear();
			object[] array = (object[])e.Node.Tag;
			foreach (int key in this.types.Keys)
			{
				this.comboBox1.Items.Add(this.types[key]);
			}
			this.comboBox1.Text = (string)array[0];
			this.textBox1.Text = (string)array[1];
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00003AEF File Offset: 0x00001CEF
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.treeMeta.SelectedNode != null)
			{
				((object[])this.treeMeta.SelectedNode.Tag)[0] = this.comboBox1.Text;
			}
			this.saved = false;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00003B27 File Offset: 0x00001D27
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (this.treeMeta.SelectedNode != null)
			{
				((object[])this.treeMeta.SelectedNode.Tag)[1] = this.textBox1.Text;
			}
			this.saved = false;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000292A0 File Offset: 0x000274A0
		private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeMeta.SelectedNode != null)
			{
				object[] item = (object[])this.treeMeta.SelectedNode.Tag;
				this.file.entries.Remove(item);
				this.treeMeta.Nodes.Remove(this.treeMeta.SelectedNode);
				this.treeMeta.Nodes.Clear();
			}
			this.saved = false;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00029314 File Offset: 0x00027514
		private void addEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.mf = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
			addMeta addMeta = new addMeta(this.mf, this.currentPCK);
			addMeta.ShowDialog();
			addMeta.Dispose();
			this.treeMeta.Nodes.Clear();
			foreach (int key in this.types.Keys)
			{
				this.comboBox1.Items.Add(this.types[key]);
			}
			foreach (object[] array in this.file.entries)
			{
				object[] array2 = array;
				TreeNode treeNode = new TreeNode();
				foreach (object[] array3 in this.file.entries)
				{
					treeNode.Text = (string)array2[0];
				}
				treeNode.Tag = array;
				this.treeMeta.Nodes.Add(treeNode);
			}
			this.saved = false;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00029488 File Offset: 0x00027688
		private void moveUpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode != null && this.treeViewMain.SelectedNode.Tag != null && this.treeViewMain.SelectedNode.Index - 1 >= 0)
			{
				this.currentPCK.mineFiles[this.treeViewMain.SelectedNode.Index - 1] = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
				this.currentPCK.mineFiles[this.treeViewMain.SelectedNode.Index] = (PCK.MineFile)this.treeViewMain.Nodes[this.treeViewMain.SelectedNode.Index - 1].Tag;
				TreeNode node = (TreeNode)this.treeViewMain.SelectedNode.Clone();
				this.treeViewMain.Nodes.Insert(this.treeViewMain.SelectedNode.Index - 1, node);
				this.treeViewMain.SelectedNode.Remove();
			}
			this.saved = false;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000295A8 File Offset: 0x000277A8
		private void moveDownToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.treeViewMain.SelectedNode != null && this.treeViewMain.SelectedNode.Tag != null && this.treeViewMain.Nodes[this.treeViewMain.SelectedNode.Index + 1] != null)
			{
				this.currentPCK.mineFiles[this.treeViewMain.SelectedNode.Index + 1] = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
				this.currentPCK.mineFiles[this.treeViewMain.SelectedNode.Index] = (PCK.MineFile)this.treeViewMain.Nodes[this.treeViewMain.SelectedNode.Index + 1].Tag;
				TreeNode node = (TreeNode)this.treeViewMain.SelectedNode.Clone();
				this.treeViewMain.Nodes.Insert(this.treeViewMain.SelectedNode.Index + 2, node);
				this.treeViewMain.SelectedNode.Remove();
			}
			this.saved = false;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000296D4 File Offset: 0x000278D4
		private void metaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				new meta(this.currentPCK)
				{
					TopMost = true,
					TopLevel = true
				}.Show();
			}
			catch (Exception)
			{
				MessageBox.Show("No PCK Data Loaded");
			}
			this.saved = false;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00029728 File Offset: 0x00027928
		private void addPresetToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.mf = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
			presetMeta presetMeta = new presetMeta(this.mf, this.currentPCK);
			presetMeta.ShowDialog();
			presetMeta.Dispose();
			this.treeMeta.Nodes.Clear();
			foreach (int key in this.types.Keys)
			{
				this.comboBox1.Items.Add(this.types[key]);
			}
			foreach (object[] array in this.file.entries)
			{
				object[] array2 = array;
				TreeNode treeNode = new TreeNode();
				foreach (object[] array3 in this.file.entries)
				{
					treeNode.Text = (string)array2[0];
				}
				treeNode.Tag = array;
				this.treeMeta.Nodes.Add(treeNode);
			}
			this.saved = false;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0002989C File Offset: 0x00027A9C
		private void skinPackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.saveLocation = "";
			this.myTablePanelStartScreen.Visible = false;
			this.pckOpen.Visible = false;
			this.label5.Visible = false;
			this.labelAmount.Visible = true;
			this.richTextBoxChangelog.Visible = false;
			this.openedPCKS.Visible = true;
			foreach (object obj in this.fileToolStripMenuItem.DropDownItems)
			{
				((ToolStripMenuItem)obj).Enabled = true;
			}
			foreach (object obj2 in this.editToolStripMenuItem.DropDownItems)
			{
				((ToolStripMenuItem)obj2).Enabled = true;
			}
			this.openedPCKS.SelectedTab.Text = "Empty_Skin_Pack.pck";
			ImageList imageList = new ImageList();
			imageList.ColorDepth = ColorDepth.Depth32Bit;
			imageList.ImageSize = new Size(20, 20);
			string filename = Application.StartupPath + "\\templates\\UntitledSkinPCK.pck";
			imageList.Images.Add(Resources.ZZFolder);
			imageList.Images.Add(Resources.BINKA_ICON);
			imageList.Images.Add(Resources.IMAGE_ICON);
			imageList.Images.Add(Resources.LOC_ICON);
			imageList.Images.Add(Resources.PCK_ICON);
			imageList.Images.Add(Resources.ZUnknown);
			this.treeViewMain.ImageList = imageList;
			this.treeViewMain.Nodes.Clear();
			PCK pck = new PCK(filename);
			this.currentPCK = pck;
			foreach (PCK.MineFile mineFile in pck.mineFiles)
			{
				TreeNode treeNode = new TreeNode();
				treeNode.Text = mineFile.name;
				treeNode.Tag = mineFile;
				if (Path.GetExtension(mineFile.name) == ".binka")
				{
					treeNode.ImageIndex = 1;
					treeNode.SelectedImageIndex = 1;
				}
				else if (Path.GetExtension(mineFile.name) == ".png")
				{
					treeNode.ImageIndex = 2;
					treeNode.SelectedImageIndex = 2;
				}
				else if (Path.GetExtension(mineFile.name) == ".loc")
				{
					treeNode.ImageIndex = 3;
					treeNode.SelectedImageIndex = 3;
				}
				else if (Path.GetExtension(mineFile.name) == ".pck")
				{
					treeNode.ImageIndex = 4;
					treeNode.SelectedImageIndex = 4;
				}
				else
				{
					treeNode.ImageIndex = 5;
					treeNode.SelectedImageIndex = 5;
				}
				this.treeViewMain.Nodes.Add(treeNode);
			}
			foreach (object obj3 in this.treeViewMain.Nodes)
			{
				TreeNode treeNode2 = (TreeNode)obj3;
				if (treeNode2.Text == "languages.loc")
				{
					this.mfLoc = (PCK.MineFile)this.treeViewMain.Nodes[treeNode2.Index].Tag;
				}
				if (treeNode2.Text == "localisation.loc")
				{
					this.mfLoc = (PCK.MineFile)this.treeViewMain.Nodes[treeNode2.Index].Tag;
				}
			}
			this.saved = false;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00029C88 File Offset: 0x00027E88
		private void advancedMetaAddingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openedPCKS.Visible)
			{
				AdvancedOptions advancedOptions = new AdvancedOptions(this.currentPCK);
				advancedOptions.ShowDialog();
				advancedOptions.Dispose();
				this.saved = false;
				return;
			}
			if (!this.openedPCKS.Visible)
			{
				MessageBox.Show("Open PCK file first!");
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000032FF File Offset: 0x000014FF
		private void buttonShutdown_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00003B5F File Offset: 0x00001D5F
		private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			programInfo programInfo = new programInfo();
			programInfo.ShowDialog();
			programInfo.Dispose();
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00029CDC File Offset: 0x00027EDC
		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Welcome to PCK Bypasser made by Lil Skiirrtt!\n\nContinue make Custom Skins c:\n\nEnjoy", "PCK Bypasser made by Lil Skiirrtt!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			if (!File.Exists(this.appData + "date.txt"))
			{
				base.Resizable = false;
			}
			bool flag = !File.Exists(this.appData + "date.txt");
			this.richTextBoxChangelog.Text = File.ReadAllText(Application.StartupPath + "\\ver.txt");
			if (flag)
			{
				File.WriteAllText(this.appData + "date.txt", DateTime.Now.ToString("MM/dd/yyyy"));
			}
			else if (DateTime.Now.ToString("MM/dd/yyyy") != File.ReadAllText(this.appData + "date.txt"))
			{
				File.WriteAllText(this.appData + "date.txt", DateTime.Now.ToString("MM/dd/yyyy"));
			}
			if (!Directory.Exists(Application.StartupPath + "\\changelogs\\"))
			{
				Directory.CreateDirectory(Application.StartupPath + "\\changelogs\\");
			}
			if (!Directory.Exists(this.appData))
			{
				Directory.CreateDirectory(this.appData);
			}
			try
			{
				new creatorSpotlight().ShowDialog();
				new goodbye().ShowDialog();
				if (!File.Exists(Application.StartupPath + "/updateF"))
				{
					new creatorSpotlight().ShowDialog();
					new goodbye().ShowDialog();
					File.Create(Application.StartupPath + "/updateF");
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00029E84 File Offset: 0x00028084
		private void treeViewMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				if (this.treeViewMain.SelectedNode.Tag is PCK.MineFile)
				{
					PCK.MineFile item = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
					this.currentPCK.mineFiles.Remove(item);
					this.treeViewMain.Nodes.Remove(this.treeViewMain.SelectedNode);
				}
				else if (MessageBox.Show("Are you sure want to delete this folder? All contents will be deleted", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
				{
					foreach (object obj in this.treeViewMain.SelectedNode.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						if (treeNode.Tag == null)
						{
							MessageBox.Show("Can't fully delete directory with subdirectories");
							return;
						}
						if (treeNode.Tag is PCK.MineFile)
						{
							PCK.MineFile item2 = (PCK.MineFile)treeNode.Tag;
							this.currentPCK.mineFiles.Remove(item2);
							treeNode.Remove();
						}
					}
					this.treeViewMain.SelectedNode.Remove();
				}
			}
			this.saved = false;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00029FC4 File Offset: 0x000281C4
		private void extractToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
				openFileDialog.CheckFileExists = true;
				openFileDialog.Filter = "PCK (Minecraft Wii U Package)|*.pck";
				if (openFileDialog.ShowDialog() == DialogResult.OK && folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					foreach (PCK.MineFile mineFile in new PCK(openFileDialog.FileName).mineFiles)
					{
						new FileInfo(folderBrowserDialog.SelectedPath + "\\" + mineFile.name).Directory.Create();
						File.WriteAllBytes(folderBrowserDialog.SelectedPath + "\\" + mineFile.name, mineFile.data);
						string text = "";
						foreach (object[] array in mineFile.entries)
						{
							text = string.Concat(new string[]
							{
								text,
								(string)array[0],
								":",
								(string)array[1],
								Environment.NewLine
							});
						}
						File.WriteAllText(folderBrowserDialog.SelectedPath + "\\" + mineFile.name + ".txt", text);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Unsupported PCK");
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0002A17C File Offset: 0x0002837C
		private void treeMeta_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete && this.treeMeta.SelectedNode != null)
			{
				object[] item = (object[])this.treeMeta.SelectedNode.Tag;
				this.file.entries.Remove(item);
				this.treeMeta.Nodes.Remove(this.treeMeta.SelectedNode);
				this.treeMeta.Nodes.Clear();
				foreach (int key in this.types.Keys)
				{
					this.comboBox1.Items.Add(this.types[key]);
				}
				foreach (object[] array in this.file.entries)
				{
					object[] array2 = array;
					TreeNode treeNode = new TreeNode();
					foreach (object[] array3 in this.file.entries)
					{
						treeNode.Text = (string)array2[0];
					}
					treeNode.Tag = array;
					this.treeMeta.Nodes.Add(treeNode);
				}
			}
			this.saved = false;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0002A31C File Offset: 0x0002851C
		private void importExtractedSkinsFolder(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				if (!Directory.Exists(folderBrowserDialog.SelectedPath))
				{
					MessageBox.Show("Directory Lost");
					return;
				}
				string selectedPath = folderBrowserDialog.SelectedPath;
				DirectoryInfo directoryInfo = new DirectoryInfo(folderBrowserDialog.SelectedPath);
				bool flag = false;
				int index = 0;
				foreach (object obj in this.treeViewMain.Nodes)
				{
					TreeNode treeNode = (TreeNode)obj;
					if (treeNode.Text == "Skins")
					{
						flag = true;
						index = treeNode.Index;
					}
				}
				foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.png"))
				{
					PCK.MineFile mineFile = new PCK.MineFile();
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = fileInfo.Name.Remove(fileInfo.Name.Length - 4, 4);
					mineFile.data = File.ReadAllBytes(folderBrowserDialog.SelectedPath + "\\" + fileInfo.Name.Remove(fileInfo.Name.Length - 4, 4) + ".png");
					TreeNode treeNode2 = new TreeNode();
					this.currentPCK.mineFiles.Add(mineFile);
					mineFile.filesize = mineFile.data.Length;
					if (flag)
					{
						mineFile.name = "Skins/" + listViewItem.Text + ".png";
					}
					else
					{
						mineFile.name = listViewItem.Text + ".png";
					}
					if (listViewItem.Text.Remove(7, listViewItem.Text.Length - 7) == "dlccape")
					{
						mineFile.type = 1;
					}
					else if (listViewItem.Text.Remove(7, listViewItem.Text.Length - 7) == "DLCCAPE")
					{
						mineFile.type = 1;
					}
					else
					{
						mineFile.type = 0;
					}
					treeNode2.Text = listViewItem.Text + ".png";
					treeNode2.Tag = mineFile;
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					string text6 = "";
					bool flag2 = true;
					foreach (char c in File.ReadAllText(folderBrowserDialog.SelectedPath + "\\" + listViewItem.Text + ".png.txt").ToList<char>())
					{
						if (c.ToString() != ":" && c.ToString() != "\n" && flag2)
						{
							text += c.ToString();
						}
						else if (c.ToString() != ":" && c.ToString() != "\n" && !flag2)
						{
							text2 += c.ToString();
						}
						else if (c.ToString() == ":" && flag2)
						{
							flag2 = false;
						}
						else
						{
							object[] item = new object[]
							{
								text,
								text2
							};
							mineFile.entries.Add(item);
							if (text == "DISPLAYNAMEID")
							{
								text3 = text2;
							}
							if (text == "DISPLAYNAME")
							{
								text4 = text2;
							}
							if (text == "THEMENAMEID")
							{
								text5 = text2;
							}
							if (text == "THEMENAME")
							{
								text6 = text2;
							}
							if (text3 != "" && text4 != "")
							{
								LOC loc;
								try
								{
									loc = new LOC(this.mfLoc.data);
								}
								catch
								{
									MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								FormMain.displayId displayId = new FormMain.displayId();
								displayId.id = text3;
								displayId.defaultName = text4;
								loc.ids.names.Add(displayId.id);
								foreach (LOC.Language language in loc.langs)
								{
									language.names.Add(displayId.defaultName);
								}
								this.mfLoc.data = loc.Rebuild();
								text3 = "";
								text4 = "";
							}
							if (text5 != "" && text6 != "")
							{
								LOC loc2;
								try
								{
									loc2 = new LOC(this.mfLoc.data);
								}
								catch
								{
									MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								FormMain.displayId displayId2 = new FormMain.displayId();
								displayId2.id = text5;
								displayId2.defaultName = text6;
								loc2.ids.names.Add(displayId2.id);
								foreach (LOC.Language language2 in loc2.langs)
								{
									language2.names.Add(displayId2.defaultName);
								}
								this.mfLoc.data = loc2.Rebuild();
								text5 = "";
								text6 = "";
							}
							text = "";
							text2 = "";
							flag2 = true;
						}
					}
					treeNode2.ImageIndex = 2;
					treeNode2.SelectedImageIndex = 2;
					if (flag)
					{
						this.treeViewMain.Nodes[index].Nodes.Add(treeNode2);
					}
					else
					{
						this.treeViewMain.Nodes.Add(treeNode2);
					}
				}
			}
			folderBrowserDialog.Dispose();
			this.saved = false;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0002A998 File Offset: 0x00028B98
		private void importSkin(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Select Extracted Skin Data File";
			openFileDialog.Filter = "Text Files (*.txt)|*.txt";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string fileName = Path.GetFileName(openFileDialog.FileName);
					PCK.MineFile mineFile = new PCK.MineFile();
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = fileName.Remove(fileName.Length - 4, 4);
					mineFile.data = File.ReadAllBytes(openFileDialog.FileName.Remove(openFileDialog.FileName.Length - 4, 4));
					bool flag = false;
					int index = 0;
					foreach (object obj in this.treeViewMain.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						if (treeNode.Text == "Skins")
						{
							flag = true;
							index = treeNode.Index;
						}
					}
					TreeNode treeNode2 = new TreeNode();
					this.currentPCK.mineFiles.Add(mineFile);
					mineFile.filesize = mineFile.data.Length;
					if (flag)
					{
						mineFile.name = "Skins/" + listViewItem.Text;
					}
					else
					{
						mineFile.name = listViewItem.Text;
					}
					mineFile.type = 0;
					treeNode2.Text = listViewItem.Text;
					treeNode2.Tag = mineFile;
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					string text6 = "";
					bool flag2 = true;
					foreach (char c in File.ReadAllText(openFileDialog.FileName).ToList<char>())
					{
						if (c.ToString() != ":" && c.ToString() != "\n" && flag2)
						{
							text += c.ToString();
						}
						else if (c.ToString() != ":" && c.ToString() != "\n" && !flag2)
						{
							text2 += c.ToString();
						}
						else if (c.ToString() == ":" && flag2)
						{
							flag2 = false;
						}
						else
						{
							object[] item = new object[]
							{
								text,
								text2
							};
							mineFile.entries.Add(item);
							if (text == "DISPLAYNAMEID")
							{
								text3 = text2;
							}
							if (text == "DISPLAYNAME")
							{
								text4 = text2;
							}
							if (text == "THEMENAMEID")
							{
								text5 = text2;
							}
							if (text == "THEMENAME")
							{
								text6 = text2;
							}
							if (text3 != "" && text4 != "")
							{
								LOC loc;
								try
								{
									loc = new LOC(this.mfLoc.data);
								}
								catch
								{
									MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								FormMain.displayId displayId = new FormMain.displayId();
								displayId.id = text3;
								displayId.defaultName = text4;
								loc.ids.names.Add(displayId.id);
								foreach (LOC.Language language in loc.langs)
								{
									language.names.Add(displayId.defaultName);
								}
								this.mfLoc.data = loc.Rebuild();
								text3 = "";
								text4 = "";
							}
							if (text5 != "" && text6 != "")
							{
								LOC loc2;
								try
								{
									loc2 = new LOC(this.mfLoc.data);
								}
								catch
								{
									MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
								FormMain.displayId displayId2 = new FormMain.displayId();
								displayId2.id = text5;
								displayId2.defaultName = text6;
								loc2.ids.names.Add(displayId2.id);
								foreach (LOC.Language language2 in loc2.langs)
								{
									language2.names.Add(displayId2.defaultName);
								}
								this.mfLoc.data = loc2.Rebuild();
								text5 = "";
								text6 = "";
							}
							text = "";
							text2 = "";
							flag2 = true;
						}
					}
					treeNode2.ImageIndex = 2;
					treeNode2.SelectedImageIndex = 2;
					if (flag)
					{
						this.treeViewMain.Nodes[index].Nodes.Add(treeNode2);
					}
					else
					{
						this.treeViewMain.Nodes.Add(treeNode2);
					}
				}
				catch (Exception)
				{
					MessageBox.Show("Something went wrong");
				}
			}
			openFileDialog.Dispose();
			this.saved = false;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0002AF48 File Offset: 0x00029148
		private void folderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode treeNode = new TreeNode();
			treeNode.ImageIndex = 0;
			treeNode.SelectedImageIndex = 0;
			treeNode.Text = "New Folder";
			if (this.treeViewMain.SelectedNode.Tag == null)
			{
				this.treeViewMain.SelectedNode.Nodes.Add(treeNode);
			}
			else
			{
				this.treeViewMain.Nodes.Add(treeNode);
			}
			this.saved = false;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00003B72 File Offset: 0x00001D72
		private void installationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This part has not been restored yet!", "ERROR");
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00003B84 File Offset: 0x00001D84
		private void binkaConversionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=v6EYr4zc7rI");
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00003B91 File Offset: 0x00001D91
		private void donateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.me/realnobledez");
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00003B72 File Offset: 0x00001D72
		private void fAQToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This part has not been restored yet!", "ERROR");
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0002AFB8 File Offset: 0x000291B8
		private void convertToBedrockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openedPCKS.Visible && MessageBox.Show("Convert " + this.openedPCKS.SelectedTab.Text + " to a Bedrock Edition format?", "Convert", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
			{
				try
				{
					string text = this.openedPCKS.SelectedTab.Text.Remove(this.openedPCKS.SelectedTab.Text.Count<char>() - 4, 4);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "PCK (Minecarft Bedrock DLC)|*.mcpack";
					saveFileDialog.FileName = text;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						string text2 = Path.GetDirectoryName(saveFileDialog.FileName) + "\\" + text;
						string text3 = Path.GetDirectoryName(saveFileDialog.FileName) + "\\";
						string text4 = "99999999";
						List<FormMain.Item> list = new List<FormMain.Item>();
						List<PCK.MineFile> list2 = new List<PCK.MineFile>();
						List<PCK.MineFile> list3 = new List<PCK.MineFile>();
						foreach (PCK.MineFile mineFile in this.currentPCK.mineFiles)
						{
							if (mineFile.name.Count<char>() == 19)
							{
								if (mineFile.name.Remove(7, mineFile.name.Count<char>() - 7) == "dlcskin")
								{
									list2.Add(mineFile);
									text4 = mineFile.name.Remove(12, 7);
									text4 = text4.Remove(0, 7);
									text4 = "abcdefa" + text4;
								}
								if (mineFile.name.Remove(7, mineFile.name.Count<char>() - 7) == "dlccape")
								{
									list3.Add(mineFile);
								}
							}
						}
						if (list2.Count<PCK.MineFile>() == 0)
						{
							MessageBox.Show("No skins were found");
						}
						else
						{
							Directory.CreateDirectory(text2);
							Directory.CreateDirectory(text2 + "/texts");
							using (StreamWriter streamWriter = new StreamWriter(text2 + "/skins.json"))
							{
								streamWriter.WriteLine("{");
								streamWriter.WriteLine("  \"skins\": [");
								int num = 0;
								foreach (PCK.MineFile mineFile2 in list2)
								{
									num++;
									string str = "";
									bool flag = false;
									foreach (object[] array in mineFile2.entries)
									{
										if (array[0].ToString() == "DISPLAYNAME")
										{
											array[1].ToString();
											list.Add(new FormMain.Item
											{
												Id = mineFile2.name.Remove(15, 4),
												Name = array[1].ToString()
											});
										}
										if (array[0].ToString() == "CAPEPATH")
										{
											flag = true;
											str = array[1].ToString();
										}
									}
									streamWriter.WriteLine("    {");
									streamWriter.WriteLine("      \"localization_name\": \"" + mineFile2.name.Remove(15, 4) + "\",");
									Image image = Image.FromStream(new MemoryStream(mineFile2.data));
									if (image.Height == image.Width)
									{
										streamWriter.WriteLine(string.Concat(new string[]
										{
											"      \"geometry\": \"geometry.",
											text,
											".",
											mineFile2.name.Remove(15, 4),
											"\","
										}));
									}
									streamWriter.WriteLine("      \"texture\": \"" + mineFile2.name + "\",");
									if (flag)
									{
										streamWriter.WriteLine("      \"cape\":\"" + str + "\",");
									}
									streamWriter.WriteLine("      \"type\": \"free\"");
									if (num != list2.Count)
									{
										streamWriter.WriteLine("    },");
									}
									else
									{
										streamWriter.WriteLine("    }");
									}
								}
								streamWriter.WriteLine("  ],");
								streamWriter.WriteLine("  \"serialize_name\": \"" + text + "\",");
								streamWriter.WriteLine("  \"localization_name\": \"" + text + "\"");
								streamWriter.WriteLine("}");
							}
							using (StreamWriter streamWriter2 = new StreamWriter(text2 + "/geometry.json"))
							{
								streamWriter2.WriteLine("{");
								int num2 = 0;
								foreach (PCK.MineFile mineFile3 in list2)
								{
									num2++;
									string a = "steve";
									Image image2 = Image.FromStream(new MemoryStream(mineFile3.data));
									if (image2.Height == image2.Width / 2)
									{
										a = "64x32";
									}
									else
									{
										double num3 = 0.0;
										double num4 = 0.0;
										double num5 = 0.0;
										double num6 = 0.0;
										List<FormMain.Item> list4 = new List<FormMain.Item>();
										List<FormMain.Item> list5 = new List<FormMain.Item>();
										List<FormMain.Item> list6 = new List<FormMain.Item>();
										List<FormMain.Item> list7 = new List<FormMain.Item>();
										List<FormMain.Item> list8 = new List<FormMain.Item>();
										List<FormMain.Item> list9 = new List<FormMain.Item>();
										new List<FormMain.Item>();
										if (image2.Height == image2.Width)
										{
											foreach (object[] array2 in mineFile3.entries)
											{
												if (array2[0].ToString() == "BOX")
												{
													string text5 = "";
													string name = "";
													foreach (char c in array2[1].ToString())
													{
														if (!(c.ToString() != " "))
														{
															name = array2[1].ToString().Remove(0, text5.Count<char>() + 1);
															break;
														}
														text5 += c.ToString();
													}
													if (text5 == "HEAD")
													{
														text5 = "head";
														list4.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
													else if (text5 == "BODY")
													{
														text5 = "body";
														list5.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
													else if (text5 == "ARM0")
													{
														text5 = "rightArm";
														list7.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
													else if (text5 == "ARM1")
													{
														text5 = "leftArm";
														list6.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
													else if (text5 == "LEG0")
													{
														text5 = "leftLeg";
														list8.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
													else if (text5 == "LEG1")
													{
														text5 = "rightLeg";
														list9.Add(new FormMain.Item
														{
															Id = text5,
															Name = name
														});
													}
												}
												if (array2[0].ToString() == "OFFSET")
												{
													string text7 = "";
													foreach (char c2 in array2[1].ToString())
													{
														string text8 = array2[1].ToString();
														if (!(c2.ToString() != " "))
														{
															break;
														}
														text7 += c2.ToString();
														if (text7 == "HEAD")
														{
															num3 += double.Parse(text8.Remove(0, 7)) * -1.0;
														}
														else if (text7 == "BODY")
														{
															num4 += double.Parse(text8.Remove(0, 7)) * -1.0;
														}
														else if (text7 == "ARM0")
														{
															num5 += double.Parse(text8.Remove(0, 7)) * -1.0;
														}
														else if (text7 == "LEG0")
														{
															num6 += double.Parse(text8.Remove(0, 7)) * -1.0;
														}
													}
												}
												if (array2[0].ToString() == "ANIM" && !(array2[1].ToString() == "0x40000") && array2[1].ToString() == "0x80000")
												{
													a = "alex";
												}
											}
											if (list4.Count + list5.Count + list6.Count + list7.Count + list8.Count + list9.Count > 0)
											{
												a = "custom";
											}
										}
										streamWriter2.WriteLine(string.Concat(new string[]
										{
											"  \"geometry.",
											text,
											".",
											mineFile3.name.Remove(15, 4),
											"\": {"
										}));
										if (a == "custom")
										{
											streamWriter2.WriteLine("    \"bones\": [");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ 0, 24, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											int num7 = 0;
											foreach (FormMain.Item item in list4)
											{
												num7++;
												string text9 = "";
												string text10 = "";
												string text11 = "";
												string text12 = "";
												string text13 = "";
												string text14 = "";
												string text15 = "";
												string text16 = "";
												int num8 = 0;
												foreach (char c3 in item.Name.ToString())
												{
													if (c3.ToString() != " " && num8 == 0)
													{
														text9 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 1)
													{
														text10 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 2)
													{
														text11 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 3)
													{
														text12 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 4)
													{
														text13 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 5)
													{
														text14 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 6)
													{
														text15 += c3.ToString();
													}
													else if (c3.ToString() != " " && num8 == 7)
													{
														text16 += c3.ToString();
													}
													else if (c3.ToString() == " ")
													{
														num8++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text9),
														", ",
														(double.Parse(text10) + 0.0) * -1.0 + num3 + 24.0 - double.Parse(text13),
														", ",
														double.Parse(text11),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text12),
														", ",
														double.Parse(text13),
														", ",
														double.Parse(text14),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text15),
														", ",
														double.Parse(text16),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A HEAD BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list4.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"clothing\",");
											streamWriter2.WriteLine("        \"name\": \"head\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        },");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ 0, 12, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											num7 = 0;
											foreach (FormMain.Item item2 in list5)
											{
												num7++;
												string text17 = "";
												string text18 = "";
												string text19 = "";
												string text20 = "";
												string text21 = "";
												string text22 = "";
												string text23 = "";
												string text24 = "";
												int num9 = 0;
												foreach (char c4 in item2.Name.ToString())
												{
													if (c4.ToString() != " " && num9 == 0)
													{
														text17 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 1)
													{
														text18 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 2)
													{
														text19 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 3)
													{
														text20 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 4)
													{
														text21 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 5)
													{
														text22 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 6)
													{
														text23 += c4.ToString();
													}
													else if (c4.ToString() != " " && num9 == 7)
													{
														text24 += c4.ToString();
													}
													else if (c4.ToString() == " ")
													{
														num9++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text17),
														", ",
														(double.Parse(text18) + 0.0) * -1.0 + num4 + 24.0 - double.Parse(text21),
														", ",
														double.Parse(text19),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text20),
														", ",
														double.Parse(text21),
														", ",
														double.Parse(text22),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text23),
														", ",
														double.Parse(text24),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A BODY BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list5.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"base\",");
											streamWriter2.WriteLine("        \"name\": \"body\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        },");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ 5, 22, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											num7 = 0;
											foreach (FormMain.Item item3 in list6)
											{
												num7++;
												string text25 = "";
												string text26 = "";
												string text27 = "";
												string text28 = "";
												string text29 = "";
												string text30 = "";
												string text31 = "";
												string text32 = "";
												int num10 = 0;
												foreach (char c5 in item3.Name.ToString())
												{
													if (c5.ToString() != " " && num10 == 0)
													{
														text25 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 1)
													{
														text26 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 2)
													{
														text27 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 3)
													{
														text28 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 4)
													{
														text29 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 5)
													{
														text30 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 6)
													{
														text31 += c5.ToString();
													}
													else if (c5.ToString() != " " && num10 == 7)
													{
														text32 += c5.ToString();
													}
													else if (c5.ToString() == " ")
													{
														num10++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text25) + 5.0,
														", ",
														double.Parse(text26) * -1.0 + num5 + 22.0 - double.Parse(text29),
														", ",
														double.Parse(text27),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text28),
														", ",
														double.Parse(text29),
														", ",
														double.Parse(text30),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text31),
														", ",
														double.Parse(text32),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A ARM0 BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list6.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"base\",");
											streamWriter2.WriteLine("        \"name\": \"leftArm\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        },");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ -5, 22, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											num7 = 0;
											foreach (FormMain.Item item4 in list7)
											{
												num7++;
												string text33 = "";
												string text34 = "";
												string text35 = "";
												string text36 = "";
												string text37 = "";
												string text38 = "";
												string text39 = "";
												string text40 = "";
												int num11 = 0;
												foreach (char c6 in item4.Name.ToString())
												{
													if (c6.ToString() != " " && num11 == 0)
													{
														text33 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 1)
													{
														text34 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 2)
													{
														text35 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 3)
													{
														text36 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 4)
													{
														text37 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 5)
													{
														text38 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 6)
													{
														text39 += c6.ToString();
													}
													else if (c6.ToString() != " " && num11 == 7)
													{
														text40 += c6.ToString();
													}
													else if (c6.ToString() == " ")
													{
														num11++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text33) - 5.0,
														", ",
														double.Parse(text34) * -1.0 + num5 + 22.0 - double.Parse(text37),
														", ",
														double.Parse(text35),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text36),
														", ",
														double.Parse(text37),
														", ",
														double.Parse(text38),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text39),
														", ",
														double.Parse(text40),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A ARM1 BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list7.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"base\",");
											streamWriter2.WriteLine("        \"name\": \"rightArm\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        },");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ 1.9, 12, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											num7 = 0;
											foreach (FormMain.Item item5 in list8)
											{
												num7++;
												string text41 = "";
												string text42 = "";
												string text43 = "";
												string text44 = "";
												string text45 = "";
												string text46 = "";
												string text47 = "";
												string text48 = "";
												int num12 = 0;
												foreach (char c7 in item5.Name.ToString())
												{
													if (c7.ToString() != " " && num12 == 0)
													{
														text41 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 1)
													{
														text42 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 2)
													{
														text43 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 3)
													{
														text44 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 4)
													{
														text45 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 5)
													{
														text46 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 6)
													{
														text47 += c7.ToString();
													}
													else if (c7.ToString() != " " && num12 == 7)
													{
														text48 += c7.ToString();
													}
													else if (c7.ToString() == " ")
													{
														num12++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text41) - 1.9,
														", ",
														double.Parse(text42) * -1.0 + num6 + 12.0 - double.Parse(text45),
														", ",
														double.Parse(text43),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text44),
														", ",
														double.Parse(text45),
														", ",
														double.Parse(text46),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text47),
														", ",
														double.Parse(text48),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A LEG1 BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list8.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"base\",");
											streamWriter2.WriteLine("        \"name\": \"leftLeg\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        },");
											streamWriter2.WriteLine("      {");
											streamWriter2.WriteLine("        \"pivot\": [ -1.9, 12, 0 ],");
											streamWriter2.WriteLine("         \"rotation\": [ 0, 0, 0 ],");
											streamWriter2.WriteLine("          \"cubes\": [ ");
											num7 = 0;
											foreach (FormMain.Item item6 in list9)
											{
												num7++;
												string text49 = "";
												string text50 = "";
												string text51 = "";
												string text52 = "";
												string text53 = "";
												string text54 = "";
												string text55 = "";
												string text56 = "";
												int num13 = 0;
												foreach (char c8 in item6.Name.ToString())
												{
													if (c8.ToString() != " " && num13 == 0)
													{
														text49 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 1)
													{
														text50 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 2)
													{
														text51 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 3)
													{
														text52 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 4)
													{
														text53 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 5)
													{
														text54 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 6)
													{
														text55 += c8.ToString();
													}
													else if (c8.ToString() != " " && num13 == 7)
													{
														text56 += c8.ToString();
													}
													else if (c8.ToString() == " ")
													{
														num13++;
													}
												}
												streamWriter2.WriteLine("           {");
												try
												{
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"origin\": [ ",
														double.Parse(text49) + 1.9,
														", ",
														double.Parse(text50) * -1.0 + num6 + 12.0 - double.Parse(text53),
														", ",
														double.Parse(text51),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"size\": [ ",
														double.Parse(text52),
														", ",
														double.Parse(text53),
														", ",
														double.Parse(text54),
														" ],"
													}));
													streamWriter2.WriteLine(string.Concat(new object[]
													{
														"            \"uv\": [ ",
														double.Parse(text55),
														", ",
														double.Parse(text56),
														" ],"
													}));
													streamWriter2.WriteLine("            \"inflate\": 0,");
													streamWriter2.WriteLine("            \"mirror\": false");
												}
												catch (Exception)
												{
													MessageBox.Show("A LEG0 BOX tag in " + mineFile3.name + " has an invalid value!");
												}
												if (num7 != list9.Count)
												{
													streamWriter2.WriteLine("    },");
												}
												else
												{
													streamWriter2.WriteLine("    }");
												}
											}
											streamWriter2.WriteLine("        ],");
											streamWriter2.WriteLine("        \"META_BoneType\": \"base\",");
											streamWriter2.WriteLine("        \"name\": \"rightLeg\",");
											streamWriter2.WriteLine("        \"parent\": null");
											streamWriter2.WriteLine("        }");
											streamWriter2.WriteLine("    ],");
										}
										else if (a == "64x32")
										{
											streamWriter2.Write("    \"bones\": [ ],");
										}
										else if (a == "steve")
										{
											streamWriter2.Write(string.Concat(new string[]
											{
												"    \"bones\": [ ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"body\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"bodyArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"belt\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 24, -4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 8, 8 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"head\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 24, -4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 8, 8 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 32, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.5, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"hat\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"helmet\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 32, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArm\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -8, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 40, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArm\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArmArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArmArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 48, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftSleeve\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -8, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 40, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightSleeve\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -0.1, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLeg\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -3.9, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLeg\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLegging\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLegging\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -0.1, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftPants\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -3.9, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightPants\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"jacket\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"helmetArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"bodyArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArmArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 22, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArmArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"waist\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLegArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLegArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightBootArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftBootArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -6, 15, 1 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"item\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightItem\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 6, 15, 1 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"item\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftItem\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"     ],"
											}));
										}
										else if (a == "alex")
										{
											streamWriter2.Write(string.Concat(new string[]
											{
												"    \"bones\": [ ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"body\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"bodyArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"belt\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 24, -4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 8, 8 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"head\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 24, -4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 8, 8 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 32, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.5, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"hat\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"helmet\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 4, 11.5, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 3, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 32, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArm\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -7, 11.5, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 3, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 40, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArm\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArmArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArmArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 4, 11.5, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 3, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 48, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftSleeve\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -7, 11.5, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 3, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 40, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightSleeve\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -0.1, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLeg\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -3.9, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 16 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"base\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLeg\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": null ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLegArmor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLegging\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -0.1, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 48 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftPants\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -3.9, 0, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 4, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 0, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightPants\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [  ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"            { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"origin\": [ -4, 12, -2 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"size\": [ 8, 12, 4 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"uv\": [ 16, 32 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"inflate\": 0.25, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"             \"mirror\": false ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"clothing\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"jacket\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"helmetArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"head\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 24, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"bodyArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightArmArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 5, 21.5, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftArmArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 0, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"waist\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"body\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightLegArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftLegArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightBootArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 1.9, 12, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"armor_offset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftBootArmorOffset\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftLeg\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ -6, 14.5, 1 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"item\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"rightItem\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"rightArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       }, ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       { ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"pivot\": [ 6, 14.5, 1 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"          \"rotation\": [ 0, 0, 0 ], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"           \"cubes\": [], ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"META_BoneType\": \"item\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"name\": \"leftItem\", ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"         \"parent\": \"leftArm\" ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"       } ",
												Environment.NewLine,
												"  ",
												Environment.NewLine,
												"     ],"
											}));
										}
										streamWriter2.WriteLine("    \"texturewidth\": 64 , ");
										streamWriter2.WriteLine("    \"textureheight\": 64,");
										streamWriter2.WriteLine("    \"META_ModelVersion\": \"1.0.6\",");
										streamWriter2.WriteLine("    \"rigtype\": \"normal\",");
										streamWriter2.WriteLine("    \"animationArmsDown\": false,");
										streamWriter2.WriteLine("    \"animationArmsOutFront\": false,");
										streamWriter2.WriteLine("    \"animationStatueOfLibertyArms\": false,");
										streamWriter2.WriteLine("    \"animationSingleArmAnimation\": false,");
										streamWriter2.WriteLine("    \"animationStationaryLegs\": false,");
										streamWriter2.WriteLine("    \"animationSingleLegAnimation\": false,");
										streamWriter2.WriteLine("    \"animationNoHeadBob\": false,");
										streamWriter2.WriteLine("    \"animationDontShowArmor\": false,");
										streamWriter2.WriteLine("    \"animationUpsideDown\": false,");
										streamWriter2.WriteLine("    \"animationInvertedCrouch\": false");
										if (num2 != list2.Count)
										{
											streamWriter2.WriteLine("  },");
										}
										else
										{
											streamWriter2.WriteLine("  }");
										}
									}
								}
							}
							Random random = new Random();
							int num14 = random.Next(1, 13);
							int num15 = random.Next(1, 7);
							int num16 = random.Next(52);
							string text57 = num14.ToString() + num15.ToString() + num16.ToString();
							if (text57.Count<char>() > 12)
							{
								text57.Remove(0, text57.Count<char>() - 12);
							}
							else if (text57.Count<char>() < 12)
							{
								int num17 = 12 - text57.Count<char>();
								for (int j = 0; j < num17; j++)
								{
									text57 += 0;
								}
							}
							else
							{
								text57.Count<char>();
							}
							using (StreamWriter streamWriter3 = new StreamWriter(text2 + "/manifest.json"))
							{
								streamWriter3.WriteLine("{");
								streamWriter3.WriteLine("  \"header\": {");
								streamWriter3.WriteLine("    \"version\": [");
								streamWriter3.WriteLine("      1,");
								streamWriter3.WriteLine("      0,");
								streamWriter3.WriteLine("      0");
								streamWriter3.WriteLine("    ],");
								streamWriter3.WriteLine("    \"description\": \"Template by Ultmate_Mario, Conversion by Nobledez\",");
								streamWriter3.WriteLine("    \"name\": \"" + text + "\",");
								streamWriter3.WriteLine(string.Concat(new string[]
								{
									"    \"uuid\": \"",
									text4.Remove(0, 4),
									"-",
									text4.Remove(0, 8),
									"-",
									text4.Remove(1, 8),
									"-",
									text4.Remove(2, 8),
									"-",
									text57,
									"\""
								}));
								streamWriter3.WriteLine("  },");
								streamWriter3.WriteLine("  \"modules\": [");
								streamWriter3.WriteLine("    {");
								streamWriter3.WriteLine("      \"version\": [");
								streamWriter3.WriteLine("        1,");
								streamWriter3.WriteLine("        0,");
								streamWriter3.WriteLine("        0");
								streamWriter3.WriteLine("      ],");
								streamWriter3.WriteLine("      \"type\": \"skin_pack\",");
								streamWriter3.WriteLine("      \"uuid\": \"8dfd1d65-b3ca-4726-b9e0-9b46a40b72a4\"");
								streamWriter3.WriteLine("    }");
								streamWriter3.WriteLine("  ],");
								streamWriter3.WriteLine("  \"format_version\": 1");
								streamWriter3.WriteLine("}");
							}
							using (StreamWriter streamWriter4 = new StreamWriter(text2 + "/texts/en_US.lang"))
							{
								streamWriter4.WriteLine("skinpack." + text + "=" + Path.GetFileNameWithoutExtension(saveFileDialog.FileName));
								foreach (FormMain.Item item7 in list)
								{
									streamWriter4.WriteLine(string.Concat(new string[]
									{
										"skin.",
										text,
										".",
										item7.Id,
										"=",
										item7.Name
									}));
								}
							}
							foreach (PCK.MineFile mineFile4 in list2)
							{
								Bitmap bitmap = new Bitmap(Image.FromStream(new MemoryStream(mineFile4.data)));
								if (bitmap.Width == bitmap.Height)
								{
									FormMain.ResizeImage(bitmap, 64, 64);
								}
								else if (bitmap.Height == bitmap.Width / 2)
								{
									FormMain.ResizeImage(bitmap, 64, 32);
								}
								else
								{
									FormMain.ResizeImage(bitmap, 64, 64);
								}
								bitmap.Save(text2 + "/" + mineFile4.name, ImageFormat.Png);
							}
							foreach (PCK.MineFile mineFile5 in list3)
							{
								File.WriteAllBytes(text2 + "/" + mineFile5.name, mineFile5.data);
							}
							string sourceDirectoryName = text2;
							string text58 = text3 + "content.zipe";
							try
							{
								ZipFile.CreateFromDirectory(sourceDirectoryName, text58);
							}
							catch (Exception)
							{
								File.Delete(text58);
								ZipFile.CreateFromDirectory(sourceDirectoryName, text58);
							}
							text3 = text2 + "temp/";
							Directory.CreateDirectory(text3);
							File.Move(text58, text3 + "content.zipe");
							File.Copy(text2 + "/manifest.json", text3 + "/manifest.json");
							ZipFile.CreateFromDirectory(text3, saveFileDialog.FileName);
							Directory.Delete(text2, true);
							Directory.Delete(text3, true);
							MessageBox.Show("Conversion Complete");
						}
					}
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					return;
				}
			}
			if (!this.openedPCKS.Visible)
			{
				MessageBox.Show("Open PCK file first!");
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00020264 File Offset: 0x0001E464
		public static Bitmap ResizeImage(Image image, int width, int height)
		{
			Rectangle destRect = new Rectangle(0, 0, width, height);
			Bitmap bitmap = new Bitmap(width, height);
			bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				using (ImageAttributes imageAttributes = new ImageAttributes())
				{
					imageAttributes.SetWrapMode(WrapMode.TileFlipXY);
					graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
				}
			}
			return bitmap;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void ds()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00036AFC File Offset: 0x00034CFC
		private void buttonEditModel_Click(object sender, EventArgs e)
		{
			PCK.MineFile mineFile = (PCK.MineFile)this.treeViewMain.SelectedNode.Tag;
			if (Path.GetExtension(mineFile.name) == ".png")
			{
				this.editModel(mineFile);
			}
			if (Path.GetExtension(mineFile.name) == ".loc")
			{
				LOC loc;
				try
				{
					loc = new LOC(mineFile.data);
				}
				catch
				{
					MessageBox.Show("No localization data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				new LOCEditor(loc).ShowDialog();
				mineFile.data = loc.Rebuild();
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00003B9E File Offset: 0x00001D9E
		private void openToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This part has not yet been restored!", "ERROR");
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00003BB0 File Offset: 0x00001DB0
		private void OpenPck_MouseEnter(object sender, EventArgs e)
		{
			this.pckOpen.Image = Resources.pckOpen;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00003BC2 File Offset: 0x00001DC2
		private void OpenPck_MouseLeave(object sender, EventArgs e)
		{
			this.pckOpen.Image = Resources.pckClosed;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00003B72 File Offset: 0x00001D72
		private void tutorialsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("This part has not been restored yet!", "ERROR");
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00036BA0 File Offset: 0x00034DA0
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			MessageBox.Show("Thanks for using PCK Bypasser made by Lil Skiirrtt!", "PCK Bypasser made by Lil Skiirrtt!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			if (!this.saved && MessageBox.Show("Save PCK?", "Unsaved PCK", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				if (this.saveLocation == Application.StartupPath + "\\templates\\UntitledSkinPCK.pck")
				{
					this.save("Save As");
				}
				else
				{
					this.save("Save");
				}
			}
			if (this.needsUpdate)
			{
				new Process
				{
					StartInfo = 
					{
						FileName = Application.StartupPath + "\\nobleUpdater.exe"
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00036C44 File Offset: 0x00034E44
		private void OpenPck_DragEnter(object sender, DragEventArgs e)
		{
			this.pckOpen.Image = Resources.pckDrop;
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
			int num = 0;
			if (num >= array.Length)
			{
				return;
			}
			if (Path.GetExtension(array[num]).Equals(".pck", StringComparison.CurrentCultureIgnoreCase))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00036C9C File Offset: 0x00034E9C
		private void OpenPck_DragDrop(object sender, DragEventArgs e)
		{
			foreach (string filePath in (string[])e.Data.GetData(DataFormats.FileDrop, false))
			{
				this.openPck(filePath);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00003BC2 File Offset: 0x00001DC2
		private void OpenPck_DragLeave(object sender, EventArgs e)
		{
			this.pckOpen.Image = Resources.pckClosed;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00003BD4 File Offset: 0x00001DD4
		private void savePCK(object sender, EventArgs e)
		{
			this.save("Save");
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003BE1 File Offset: 0x00001DE1
		private void saveAsPCK(object sender, EventArgs e)
		{
			this.save("Save As");
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void openPck(object sender, EventArgs e)
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00003BEE File Offset: 0x00001DEE
		private void wiiUPCKInstallerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new installWiiU(null).ShowDialog();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00003BFC File Offset: 0x00001DFC
		private void howToMakeABasicSkinPackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=A43aHRHkKxk");
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00003C09 File Offset: 0x00001E09
		private void howToMakeACustomSkinModelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=pEC_ug55lag");
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00003C16 File Offset: 0x00001E16
		private void howToMakeCustomSkinModelsbedrockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=6z8NTogw5x4");
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00003B84 File Offset: 0x00001D84
		private void howToMakeCustomMusicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=v6EYr4zc7rI");
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00003C23 File Offset: 0x00001E23
		private void howToInstallPcksDirectlyToWiiUToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=hRQagnEplec");
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00003C30 File Offset: 0x00001E30
		private void pCKCenterReleaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=E_6bXSh6yqw");
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00003C3D File Offset: 0x00001E3D
		private void howPCKsWorkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=hTlImrRrCKQ");
		}

		// Token: 0x040003D8 RID: 984
		private string saveLocation;

		// Token: 0x040003D9 RID: 985
		private int fileCount;

		// Token: 0x040003DA RID: 986
		private PCK.MineFile mf;

		// Token: 0x040003DB RID: 987
		private PCK currentPCK;

		// Token: 0x040003DC RID: 988
		private LOC l;

		// Token: 0x040003DD RID: 989
		private PCK.MineFile mfLoc;

		// Token: 0x040003DE RID: 990
		private Dictionary<int, string> types;

		// Token: 0x040003DF RID: 991
		private PCK.MineFile file;

		// Token: 0x040003E0 RID: 992
		private string ver = "2.0";

		// Token: 0x040003E1 RID: 993
		private bool needsUpdate;

		// Token: 0x040003E2 RID: 994
		private bool saved = true;

		// Token: 0x040003E3 RID: 995
		private string appData = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/";

		// Token: 0x040003E4 RID: 996
		public static bool correct;

		// Token: 0x040003FC RID: 1020
		private PictureBox OpenPck;

		// Token: 0x02000083 RID: 131
		public class displayId
		{
			// Token: 0x04000431 RID: 1073
			public string id;

			// Token: 0x04000432 RID: 1074
			public string defaultName;
		}

		// Token: 0x02000084 RID: 132
		public class Item
		{
			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000254 RID: 596 RVA: 0x00003C69 File Offset: 0x00001E69
			// (set) Token: 0x06000255 RID: 597 RVA: 0x00003C71 File Offset: 0x00001E71
			public string Id { get; set; }

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000256 RID: 598 RVA: 0x00003C7A File Offset: 0x00001E7A
			// (set) Token: 0x06000257 RID: 599 RVA: 0x00003C82 File Offset: 0x00001E82
			public string Name { get; set; }
		}
	}
}
