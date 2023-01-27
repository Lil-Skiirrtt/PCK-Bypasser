using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using minekampf.Properties;

namespace minekampf.Forms
{
	// Token: 0x0200006B RID: 107
	public partial class pckCenter : MetroForm
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00012934 File Offset: 0x00010B34
		public pckCenter()
		{
			this.InitializeComponent();
			this.cacheDir = this.appData + "PCK Center/cache/";
			if (!Directory.Exists(this.cacheDir))
			{
				Directory.CreateDirectory(this.cacheDir);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000129C4 File Offset: 0x00010BC4
		private void reload(bool checkNeeded)
		{
			using (WebClient webClient = new WebClient())
			{
				try
				{
					if (int.Parse(webClient.DownloadString("http://www.nobledez.com/pckCenterAvailable.txt")) != 1 && int.Parse(webClient.DownloadString("http://www.nobledez.com/pckCenterAvailable.txt")) == 0)
					{
						MessageBox.Show("PCK Center is currently down for maintenance, sorry for any inconveniences");
						this.radioButtonMine.Checked = true;
						return;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}
			}
			using (WebClient webClient2 = new WebClient())
			{
				this.mods.Clear();
				string text = webClient2.DownloadString(this.loadDirectory);
				string text2 = "";
				foreach (char c in text)
				{
					if (c.ToString() != "\n")
					{
						text2 += c.ToString();
					}
					else
					{
						this.mods.Add(text2);
						text2 = "";
					}
				}
				for (int j = this.pckLayout.Controls.Count - 1; j >= 0; j--)
				{
					Control control = this.pckLayout.Controls[j];
					this.pckLayout.Controls.Remove(control);
					control.Dispose();
				}
				foreach (string text4 in this.mods)
				{
					if (File.Exists(this.cacheDir + text4 + ".png") && checkNeeded)
					{
						HttpWebResponse httpWebResponse = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("http://www.nobledez.com//mod/pcks/" + text4 + ".png")).GetResponse();
						DateTime lastWriteTime = File.GetLastWriteTime(this.cacheDir + text4 + ".png");
						DateTime lastModified = httpWebResponse.LastModified;
						httpWebResponse.Dispose();
						if (!(lastWriteTime >= lastModified))
						{
							webClient2.DownloadFile("http://www.nobledez.com//mod/pcks/" + text4 + ".png", this.cacheDir + text4 + ".png");
						}
					}
					else if (!File.Exists(this.cacheDir + text4 + ".png") || checkNeeded)
					{
						webClient2.DownloadFile("http://www.nobledez.com//mod/pcks/" + text4 + ".png", this.cacheDir + text4 + ".png");
					}
					if (File.Exists(this.cacheDir + text4 + ".desc") && checkNeeded)
					{
						HttpWebResponse httpWebResponse2 = (HttpWebResponse)((HttpWebRequest)WebRequest.Create("http://www.nobledez.com//mod/pcks/" + text4 + ".desc")).GetResponse();
						DateTime lastWriteTime2 = File.GetLastWriteTime(this.cacheDir + text4 + ".desc");
						DateTime lastModified2 = httpWebResponse2.LastModified;
						httpWebResponse2.Dispose();
						if (!(lastWriteTime2 >= lastModified2))
						{
							webClient2.DownloadFile("http://www.nobledez.com//mod/pcks/" + text4 + ".desc", this.cacheDir + text4 + ".desc");
						}
					}
					else if (!File.Exists(this.cacheDir + text4 + ".png") || checkNeeded)
					{
						webClient2.DownloadFile("http://www.nobledez.com//mod/pcks/" + text4 + ".desc", this.cacheDir + text4 + ".desc");
					}
					int num = 0;
					string text5 = "";
					string text6 = "";
					string text7 = "";
					string text8 = "";
					string text9 = "";
					string text10 = File.ReadAllText(this.cacheDir + text4 + ".desc");
					Bitmap icon = new Bitmap(Image.FromFile(this.cacheDir + text4 + ".png"));
					foreach (char c2 in text10)
					{
						if (c2.ToString() == "\n")
						{
							num++;
						}
						else if (c2.ToString() != "\n" && num == 0)
						{
							text5 += c2.ToString();
						}
						else if (c2.ToString() != "\n" && num == 1)
						{
							text6 += c2.ToString();
						}
						else if (c2.ToString() != "\n" && num == 2)
						{
							text7 += c2.ToString();
						}
						else if (c2.ToString() != "\n" && num == 3)
						{
							text8 += c2.ToString();
						}
						else if (c2.ToString() != "\n" && num == 4)
						{
							text9 += c2.ToString();
						}
					}
					PckPreview value = new PckPreview(text5, text6, text7, text8, text9, icon, 0, text4, null);
					this.pckLayout.Controls.Add(value);
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000336F File Offset: 0x0000156F
		private void radioButtonNew_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonNew.Checked)
			{
				this.loadDirectory = "http://www.nobledez.com/pckCenterNew.txt";
				this.reload(this.newLoaded);
				this.newLoaded = false;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000339C File Offset: 0x0000159C
		private void radioButtonDevPicks_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonDevPicks.Checked)
			{
				this.loadDirectory = "http://www.nobledez.com/pckCenterPicks.txt";
				this.reload(this.devPicksLoaded);
				this.devPicksLoaded = false;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000033C9 File Offset: 0x000015C9
		private void radioButtonCommunity_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonCommunity.Checked)
			{
				this.loadDirectory = "http://www.nobledez.com/pckCenterCommunity.txt";
				this.reload(this.communityLoaded);
				this.communityLoaded = false;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000033F6 File Offset: 0x000015F6
		private void radioButtonMine_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonMine.Checked)
			{
				this.loadCollectdion();
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00012F00 File Offset: 0x00011100
		private void loadCollectdion()
		{
			for (int i = this.pckLayout.Controls.Count - 1; i >= 0; i--)
			{
				Control control = this.pckLayout.Controls[i];
				this.pckLayout.Controls.Remove(control);
				control.Dispose();
			}
			this.pckLayout.Enabled = false;
			foreach (string path in (from file in Directory.GetFiles(this.appData + "/PCK Center/myPcks/", "*.*", SearchOption.AllDirectories)
			where new string[]
			{
				".pck"
			}.Contains(Path.GetExtension(file))
			select file).ToList<string>())
			{
				int num = 0;
				string text = "";
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				string text6 = Path.GetFileName(path);
				text6 = Path.GetFileNameWithoutExtension(text6);
				foreach (char c in File.ReadAllText(this.appData + "/PCK Center/myPcks/" + text6 + ".desc"))
				{
					if (c.ToString() == "\n")
					{
						num++;
					}
					else if (c.ToString() != "\n" && num == 0)
					{
						text += c.ToString();
					}
					else if (c.ToString() != "\n" && num == 1)
					{
						text2 += c.ToString();
					}
					else if (c.ToString() != "\n" && num == 2)
					{
						text3 += c.ToString();
					}
					else if (c.ToString() != "\n" && num == 3)
					{
						text4 += c.ToString();
					}
					else if (c.ToString() != "\n" && num == 4)
					{
						text5 += c.ToString();
					}
				}
				string path2 = this.appData + "/PCK Center/myPcks/" + text6 + ".png";
				Bitmap icon = null;
				using (FileStream fileStream = new FileStream(path2, FileMode.Open, FileAccess.Read, FileShare.Read))
				{
					icon = (Bitmap)Image.FromStream(fileStream);
				}
				PckPreview value = new PckPreview(text, text2, text3, text4, text5, icon, 1, text6, new MethodInvoker(this.loadCollectdion));
				this.pckLayout.Controls.Add(value);
			}
			this.pckLayout.Enabled = true;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000340B File Offset: 0x0000160B
		private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonAll.Checked)
			{
				this.loadDirectory = "http://www.nobledez.com/pckCenterList.txt";
				this.reload(this.nobleLoaded);
				this.nobleLoaded = false;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003438 File Offset: 0x00001638
		private void pckCenter_Load(object sender, EventArgs e)
		{
			Directory.CreateDirectory(this.appData + "/PCK Center/myPcks/");
			this.reload(this.nobleLoaded);
			this.nobleLoaded = false;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void pckLayout_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void pckLayout_MouseMove_1(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void pckLayout_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void pckLayout_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void pckLayout_ControlRemoved(object sender, ControlEventArgs e)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00003463 File Offset: 0x00001663
		private void buttonSubmit_Click(object sender, EventArgs e)
		{
			Process.Start("http://nobledez.com/pckCenterCommunity");
		}

		// Token: 0x04000301 RID: 769
		private List<string> mods = new List<string>();

		// Token: 0x04000302 RID: 770
		private string loadDirectory = "http://www.nobledez.com/pckCenterList.txt";

		// Token: 0x04000303 RID: 771
		private string appData = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/";

		// Token: 0x04000304 RID: 772
		private string cacheDir;

		// Token: 0x04000305 RID: 773
		private bool nobleLoaded = true;

		// Token: 0x04000306 RID: 774
		private bool newLoaded = true;

		// Token: 0x04000307 RID: 775
		private bool devPicksLoaded = true;

		// Token: 0x04000308 RID: 776
		private bool communityLoaded = true;
	}
}
