using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000091 RID: 145
	public partial class presetMeta : MetroForm
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00003E9D File Offset: 0x0000209D
		public presetMeta(PCK.MineFile fileIn, PCK currentPCKIn)
		{
			this.InitializeComponent();
			this.file = fileIn;
			this.currentPCK = currentPCKIn;
			base.FormBorderStyle = FormBorderStyle.None;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00042714 File Offset: 0x00040914
		private void presetMeta_Load(object sender, EventArgs e)
		{
			this.listView1.View = View.Details;
			this.listView1.Columns.Add("Meta Presets", 135);
			if (Directory.Exists(Application.StartupPath + "\\plugins\\presets\\"))
			{
				Directory.Move(Application.StartupPath + "\\plugins\\presets\\", this.appData + "presets");
			}
			if (!Directory.Exists(this.appData + "presets"))
			{
				Directory.CreateDirectory(this.appData + "presets");
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(this.appData + "presets");
			try
			{
				foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.txt"))
				{
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = fileInfo.Name.Remove(fileInfo.Name.Length - 4, 4);
					listViewItem.Tag = File.ReadAllText(fileInfo.FullName);
					this.listView1.Items.Add(listViewItem);
				}
			}
			catch (Exception)
			{
			}
			if (this.listView1.Items.Count == 0)
			{
				this.labelSearch.Visible = true;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00042864 File Offset: 0x00040A64
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.listView1.SelectedItems.Count != 0)
			{
				try
				{
					string text = "";
					string text2 = "";
					bool flag = true;
					foreach (char c in this.listView1.SelectedItems[0].Tag.ToString().ToList<char>())
					{
						if (c.ToString() != ":" && c.ToString() != "\n" && flag)
						{
							text += c.ToString();
						}
						else if (c.ToString() != ":" && c.ToString() != "\n" && !flag)
						{
							text2 += c.ToString();
						}
						else if (c.ToString() == ":" && flag)
						{
							flag = false;
						}
						else
						{
							object[] item = new object[]
							{
								text,
								text2
							};
							this.file.entries.Add(item);
							text = "";
							text2 = "";
							flag = true;
						}
						base.Close();
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x0400049D RID: 1181
		private PCK currentPCK;

		// Token: 0x0400049E RID: 1182
		private PCK.MineFile file;

		// Token: 0x0400049F RID: 1183
		private string appData = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/";
	}
}
