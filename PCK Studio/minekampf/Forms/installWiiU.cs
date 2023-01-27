using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;
using FileTransferProtocolLib;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using minekampf.Properties;

namespace minekampf.Forms
{
	// Token: 0x02000069 RID: 105
	public partial class installWiiU : MetroForm
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00010724 File Offset: 0x0000E924
		public installWiiU(string mod)
		{
			this.InitializeComponent();
			this.mod = mod;
			if (mod == null)
			{
				this.replaceToolStripMenuItem.Visible = false;
				return;
			}
			this.replaceToolStripMenuItem.Text = "Replace with " + Path.GetFileName(mod);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0001079C File Offset: 0x0000E99C
		private void buttonSelect_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string directoryRoot = Directory.GetDirectoryRoot(folderBrowserDialog.SelectedPath);
					if (!Directory.Exists(directoryRoot + "/wiiu/apps/"))
					{
						Directory.CreateDirectory(directoryRoot + "/wiiu/apps/");
					}
					using (WebClient webClient = new WebClient())
					{
						webClient.DownloadFile("http://nobledez.com/programs/assets/WiiUMapManager/apps.zip", directoryRoot + "/wiiu/apps/apps.zip");
					}
					string sourceArchiveFileName = directoryRoot + "/wiiu/apps/apps.zip";
					string destinationDirectoryName = directoryRoot + "/wiiu/apps/temp";
					ZipFile.ExtractToDirectory(sourceArchiveFileName, destinationDirectoryName);
					if (!Directory.Exists(directoryRoot + "/wiiu/apps/ftpiiu_everywhere"))
					{
						Directory.Move(directoryRoot + "/wiiu/apps/temp/ftpiiu_everywhere", directoryRoot + "/wiiu/apps/ftpiiu_everywhere");
					}
					if (!Directory.Exists(directoryRoot + "/wiiu/apps/homebrew_launcher"))
					{
						Directory.Move(directoryRoot + "/wiiu/apps/temp/homebrew_launcher", directoryRoot + "/wiiu/apps/homebrew_launcher");
					}
					if (!Directory.Exists(directoryRoot + "/wiiu/apps/mocha_fshax"))
					{
						Directory.Move(directoryRoot + "/wiiu/apps/temp/mocha_fshax", directoryRoot + "/wiiu/apps/mocha_fshax");
					}
					if (!File.Exists(directoryRoot + "/wiiu/apps/.DS_Store"))
					{
						File.Move(directoryRoot + "/wiiu/apps/temp/.DS_Store", directoryRoot + "/wiiu/apps/.DS_Store");
					}
					if (!File.Exists(directoryRoot + "/wiiu/apps/sign_c2w_patcher.elf"))
					{
						File.Move(directoryRoot + "/wiiu/apps/temp/sign_c2w_patcher.elf", directoryRoot + "/wiiu/apps/sign_c2w_patcher.elf");
					}
					File.Delete(directoryRoot + "/wiiu/apps/apps.zip");
					Directory.Delete(directoryRoot + "/wiiu/apps/temp/", true);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
				MessageBox.Show("Done");
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00010980 File Offset: 0x0000EB80
		private void updateDatabase()
		{
			this.pcks.Clear();
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Battle & Beasts",
				file = "BattleAndBeasts.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Battle & Beasts 2",
				file = "BattleAndBeasts2.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Biome Settlers Pack 1",
				file = "SkinsBiomeSettlers1.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Biome Settlers Pack 2",
				file = "SkinsBiomeSettlers2.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Doctor Who Skins Volume I",
				file = "SkinPackDrWho.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Doctor Who Skins Volume II",
				file = "SkinPackDrWho.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Festive Skin Pack",
				file = "SkinsFestive.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "FINAL FANTASY XV Skin Pack",
				file = "FinalFantasyXV.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Magic The Gathering Skin Pack",
				file = "magicthegathering.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Mini Game Heroes Skin Pack",
				file = "Minigame2.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Mini Game Masters Skin Pack",
				file = "Minigame.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Moana Character Pack",
				file = "Moana.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Power Rangers Skin Pack",
				file = "PowerRangers.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Redstone Specialists Skin Pack",
				file = "SkinsRedstoneSpecialists.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Skin Pack 1",
				file = "Skins1.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Star Wars Classic Skin Pack",
				file = "StarWarsClassicPack.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Star Wars Prequel Skin Pack",
				file = "StarWarsPrequel.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Star Wars Rebels Skin Pack",
				file = "StarWarsRebelsPack.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Star Wars Sequel Skin Pack",
				file = "StarWarsSequel.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Story Mode Skin Pack",
				file = "PackStoryMode.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Stranger Things Skin Pack",
				file = "StrangerThings.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Strangers Biome Settlers 3 Skin Pack",
				file = "BiomeSettlers3_Strangers.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "The Incredibles Skin Pack",
				file = "Incredibles.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "The Simpsons Skin Pack",
				file = "SkinPackSimpsons.pck"
			});
			this.pcks.Add(new installWiiU.pckDir
			{
				folder = "Villains Skin Pack",
				file = "Villains.pck"
			});
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00010D50 File Offset: 0x0000EF50
		public void buttonMode(string mode)
		{
			if (mode == "start")
			{
				this.buttonServerToggle.BackColor = Color.FromArgb(68, 178, 13);
				this.serverOn = false;
				this.buttonServerToggle.Text = "Start";
				this.listViewPCKS.Enabled = false;
				return;
			}
			if (mode == "stop")
			{
				this.serverOn = true;
				this.buttonServerToggle.BackColor = Color.Red;
				this.buttonServerToggle.Text = "Stop";
				this.listViewPCKS.Enabled = true;
				return;
			}
			if (mode == "loading")
			{
				this.buttonServerToggle.BackColor = Color.MediumAquamarine;
				this.buttonServerToggle.Text = "Wait..";
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00010E18 File Offset: 0x0000F018
		private void loadPcks()
		{
			string text = "";
			if (this.radioButtonEur.Checked)
			{
				text = "101d7500";
			}
			else if (this.radioButtonUs.Checked)
			{
				text = "101d9d00";
			}
			else if (this.radioButtonJap.Checked)
			{
				text = "101dbe00";
			}
			string text2 = "";
			if (this.radioButtonSystem.Checked)
			{
				text2 = "storage_mlc";
			}
			else if (this.radioButtonUSB.Checked)
			{
				text2 = "storage_usb";
			}
			if (text != "" && text2 != "")
			{
				this.dlcPath = text2 + "/usr/title/0005000e/" + text + "/content/WiiU/DLC/";
				this.buttonServerToggle.Enabled = true;
				if (this.listViewPCKS.Columns.Count == 0)
				{
					this.listViewPCKS.Columns.Add(this.dlcPath, 395);
				}
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00010F04 File Offset: 0x0000F104
		private void buttonServerToggle_Click(object sender, EventArgs e)
		{
			if (!this.serverOn)
			{
				if (this.textBoxHost.Text == "")
				{
					MessageBox.Show("Please enter a valid Wii U IP!");
					return;
				}
				try
				{
					this.buttonMode("loading");
					ServicePointManager.Expect100Continue = true;
					FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create("ftp://" + this.textBoxHost.Text + "/" + this.dlcPath);
					ftpWebRequest.Method = "NLST";
					ftpWebRequest.Credentials = new NetworkCredential("", "a3262443");
					ftpWebRequest.EnableSsl = false;
					ftpWebRequest.Timeout = 1200000;
					ServicePoint servicePoint = ftpWebRequest.ServicePoint;
					Console.WriteLine("ServicePoint connections = {0}.", servicePoint.ConnectionLimit);
					servicePoint.ConnectionLimit = 1;
					using (FtpWebResponse ftpWebResponse = (FtpWebResponse)ftpWebRequest.GetResponse())
					{
						using (Stream responseStream = ftpWebResponse.GetResponseStream())
						{
							using (StreamReader streamReader = new StreamReader(responseStream, true))
							{
								for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
								{
									this.listViewPCKS.Items.Add(text);
								}
							}
						}
					}
					foreach (object obj in this.listViewPCKS.Items)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						int num = 0;
						FtpWebRequest ftpWebRequest2 = (FtpWebRequest)WebRequest.Create(string.Concat(new string[]
						{
							"ftp://",
							this.textBoxHost.Text,
							"/",
							this.dlcPath,
							"/",
							listViewItem.Text,
							"/"
						}));
						ftpWebRequest2.Method = "NLST";
						ftpWebRequest2.Credentials = new NetworkCredential("", "a3262443");
						ftpWebRequest2.EnableSsl = false;
						ftpWebRequest2.Timeout = 1200000;
						ServicePoint servicePoint2 = ftpWebRequest2.ServicePoint;
						Console.WriteLine("NOBLEDEZ WAS HERE", servicePoint2.ConnectionLimit);
						servicePoint2.ConnectionLimit = 1;
						using (FtpWebResponse ftpWebResponse2 = (FtpWebResponse)ftpWebRequest2.GetResponse())
						{
							using (Stream responseStream2 = ftpWebResponse2.GetResponseStream())
							{
								using (StreamReader streamReader2 = new StreamReader(responseStream2, true))
								{
									for (string tag = streamReader2.ReadLine(); tag != null; tag = streamReader2.ReadLine())
									{
										num++;
										listViewItem.Tag = tag;
									}
								}
							}
						}
						if (num != 1)
						{
							listViewItem.Remove();
						}
					}
					this.buttonMode("stop");
					return;
				}
				catch (Exception ex)
				{
					this.buttonMode("start");
					MessageBox.Show(ex.ToString());
					return;
				}
			}
			if (this.serverOn)
			{
				this.listViewPCKS.Items.Clear();
				try
				{
					this.buttonMode("start");
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.ToString());
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003326 File Offset: 0x00001526
		private void radioButtonEur_Click(object sender, EventArgs e)
		{
			this.loadPcks();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003326 File Offset: 0x00001526
		private void radioButtonUs_Click(object sender, EventArgs e)
		{
			this.loadPcks();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003326 File Offset: 0x00001526
		private void radioButtonJap_Click(object sender, EventArgs e)
		{
			this.loadPcks();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listViewPCKS_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000112F4 File Offset: 0x0000F4F4
		private void listViewPCKS_MouseDown(object sender, MouseEventArgs e)
		{
			ListViewHitTestInfo listViewHitTestInfo = this.listViewPCKS.HitTest(e.Location);
			if (e.Button == MouseButtons.Right && listViewHitTestInfo.Location != ListViewHitTestLocations.None)
			{
				this.contextMenuStripCaffiine.Show(Cursor.Position);
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0001133C File Offset: 0x0000F53C
		private void replacePCKToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listViewPCKS.SelectedItems.Count != 0)
			{
				this.buttonMode("loading");
				OpenFileDialog openFileDialog = new OpenFileDialog();
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					new FTP("ftp://" + this.textBoxHost.Text, "", "a3262443").UploadFile(openFileDialog.FileName, string.Concat(new string[]
					{
						this.dlcPath,
						"/",
						this.listViewPCKS.SelectedItems[0].Text,
						"/",
						this.listViewPCKS.SelectedItems[0].Tag.ToString()
					}));
					MessageBox.Show("PCK Replaced!");
				}
			}
			this.buttonMode("stop");
			this.loadPcks();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listViewPCKS_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00011424 File Offset: 0x0000F624
		private void buttonInstall_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Replace with " + Path.GetFileNameWithoutExtension(this.mod) + "?", "Install Mod", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				if (!Directory.Exists(this.dlcPath + this.pcks[this.listViewPCKS.SelectedItems[0].Index].folder + "/"))
				{
					Directory.CreateDirectory(this.dlcPath + this.pcks[this.listViewPCKS.SelectedItems[0].Index].folder + "/");
				}
				File.Copy(this.mod, this.dlcPath + this.pcks[this.listViewPCKS.SelectedItems[0].Index].folder + "/" + this.pcks[this.listViewPCKS.SelectedItems[0].Index].file);
			}
			this.loadPcks();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00011544 File Offset: 0x0000F744
		private void deletePCKModToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Directory.Delete(this.dlcPath + this.pcks[this.listViewPCKS.SelectedItems[0].Index].folder + "/", true);
			this.loadPcks();
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void buttonServerToggle_Clic(object sender, EventArgs e)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void contextMenuStripCaffiine_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003326 File Offset: 0x00001526
		private void radioButtonSystem_CheckedChanged(object sender, EventArgs e)
		{
			this.loadPcks();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003326 File Offset: 0x00001526
		private void radioButtonUSB_CheckedChanged(object sender, EventArgs e)
		{
			this.loadPcks();
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00011594 File Offset: 0x0000F794
		private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.listViewPCKS.SelectedItems.Count != 0)
			{
				this.buttonMode("loading");
				new FTP("ftp://" + this.textBoxHost.Text, "", "a3262443").UploadFile(this.mod, string.Concat(new string[]
				{
					this.dlcPath,
					"/",
					this.listViewPCKS.SelectedItems[0].Text,
					"/",
					this.listViewPCKS.SelectedItems[0].Tag.ToString()
				}));
				MessageBox.Show("PCK Replaced!");
			}
			this.buttonMode("stop");
			this.loadPcks();
		}

		// Token: 0x040002E9 RID: 745
		private string loca = "";

		// Token: 0x040002EA RID: 746
		private string dlcPath = "";

		// Token: 0x040002EB RID: 747
		private string mod = "";

		// Token: 0x040002EC RID: 748
		private bool serverOn;

		// Token: 0x040002ED RID: 749
		private List<installWiiU.pckDir> pcks = new List<installWiiU.pckDir>();

		// Token: 0x0200006A RID: 106
		public class pckDir
		{
			// Token: 0x1700004D RID: 77
			// (get) Token: 0x06000154 RID: 340 RVA: 0x0000334D File Offset: 0x0000154D
			// (set) Token: 0x06000155 RID: 341 RVA: 0x00003355 File Offset: 0x00001555
			public string folder { get; set; }

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x06000156 RID: 342 RVA: 0x0000335E File Offset: 0x0000155E
			// (set) Token: 0x06000157 RID: 343 RVA: 0x00003366 File Offset: 0x00001566
			public string file { get; set; }
		}
	}
}
