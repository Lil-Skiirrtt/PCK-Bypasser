using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000079 RID: 121
	public partial class AdvancedOptions : MetroForm
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x000037E0 File Offset: 0x000019E0
		public AdvancedOptions(PCK currentPCKIn)
		{
			this.InitializeComponent();
			this.currentPCK = currentPCKIn;
			base.FormBorderStyle = FormBorderStyle.None;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void AdvancedOptions_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void addPresetToolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000037FC File Offset: 0x000019FC
		private void addEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addMetaAdvanced addMetaAdvanced = new addMetaAdvanced(this.treeMeta);
			addMetaAdvanced.ShowDialog();
			addMetaAdvanced.Dispose();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00003815 File Offset: 0x00001A15
		private void deleteEntryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.treeMeta.SelectedNode.Remove();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000250C8 File Offset: 0x000232C8
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.comboBox1.Text == "All")
				{
					int num = this.treeMeta.Nodes.Count;
					int num2 = 0;
					do
					{
						foreach (PCK.MineFile mineFile in this.currentPCK.mineFiles)
						{
							object[] item = new object[]
							{
								this.treeMeta.Nodes[num2].Text,
								this.treeMeta.Nodes[num2].Tag
							};
							mineFile.entries.Add(item);
						}
						num2++;
						num--;
					}
					while (num != 0);
					MessageBox.Show("Data Added to All Entries");
				}
				else if (this.comboBox1.Text == "64x64")
				{
					int num3 = this.treeMeta.Nodes.Count;
					int num4 = 0;
					do
					{
						foreach (PCK.MineFile mineFile2 in this.currentPCK.mineFiles)
						{
							MemoryStream stream = new MemoryStream(mineFile2.data);
							if (Path.GetExtension(mineFile2.name) == ".png" && Image.FromStream(stream).Size.Height == Image.FromStream(stream).Size.Width)
							{
								object[] item2 = new object[]
								{
									this.treeMeta.Nodes[num4].Text,
									this.treeMeta.Nodes[num4].Tag
								};
								mineFile2.entries.Add(item2);
							}
						}
						num4++;
						num3--;
					}
					while (num3 != 0);
					MessageBox.Show("Data Added to 64x64 Image Entries");
				}
				else if (this.comboBox1.Text == "64x32")
				{
					int num5 = this.treeMeta.Nodes.Count;
					int num6 = 0;
					do
					{
						foreach (PCK.MineFile mineFile3 in this.currentPCK.mineFiles)
						{
							MemoryStream stream2 = new MemoryStream(mineFile3.data);
							if (Path.GetExtension(mineFile3.name) == ".png" && Image.FromStream(stream2).Size.Height == Image.FromStream(stream2).Size.Width / 2)
							{
								object[] item3 = new object[]
								{
									this.treeMeta.Nodes[num6].Text,
									this.treeMeta.Nodes[num6].Tag
								};
								mineFile3.entries.Add(item3);
							}
						}
						num6++;
						num5--;
					}
					while (num5 != 0);
					MessageBox.Show("Data Added to  64x32 Image Entries");
				}
				else if (this.comboBox1.Text == "PNG Files")
				{
					int num7 = this.treeMeta.Nodes.Count;
					int num8 = 0;
					do
					{
						foreach (PCK.MineFile mineFile4 in this.currentPCK.mineFiles)
						{
							if (Path.GetExtension(mineFile4.name) == ".png")
							{
								object[] item4 = new object[]
								{
									this.treeMeta.Nodes[num8].Text,
									this.treeMeta.Nodes[num8].Tag
								};
								mineFile4.entries.Add(item4);
							}
						}
						num8++;
						num7--;
					}
					while (num7 != 0);
					MessageBox.Show("Data Added to All PNG Image Entries");
				}
				else
				{
					MessageBox.Show("Please Select an Application Argument");
				}
			}
			catch (Exception)
			{
				MessageBox.Show("A Probelm Occured..");
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0002556C File Offset: 0x0002376C
		private void treeMeta_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.comboBox2.Items.Clear();
			this.comboBox2.Text = this.treeMeta.SelectedNode.Text;
			this.textBox1.Text = this.treeMeta.SelectedNode.Tag.ToString();
		}

		// Token: 0x040003AC RID: 940
		private PCK.MineFile mf;

		// Token: 0x040003AD RID: 941
		private PCK currentPCK;
	}
}
