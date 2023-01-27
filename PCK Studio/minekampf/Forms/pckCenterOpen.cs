using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MinecraftUSkinEditor;
using minekampf.Properties;

namespace minekampf.Forms
{
	// Token: 0x02000070 RID: 112
	public partial class pckCenterOpen : MetroForm
	{
		// Token: 0x0600017A RID: 378 RVA: 0x000143FC File Offset: 0x000125FC
		public pckCenterOpen(string name, string authorIn, string descIn, string directIn, string adIn, Bitmap display, int mode, string mod, MethodInvoker reloader)
		{
			this.InitializeComponent();
			this.pictureBoxDisplay.Image = display;
			this.reloader = reloader;
			this.mode = mode;
			this.mod = mod;
			this.reloader = reloader;
			this.name = name;
			this.author = authorIn;
			this.desc = descIn;
			this.direct = directIn;
			this.ad = adIn;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00014480 File Offset: 0x00012680
		private void pckCenterOpen_Load(object sender, EventArgs e)
		{
			if (this.mode == 0)
			{
				this.buttonAd.Visible = true;
				this.buttonDirect.Visible = true;
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/PCK Center/myPcks/" + this.direct + ".pck"))
				{
					this.buttonDirect.Enabled = false;
					this.buttonDirect.Text = "Already in Collection";
					this.buttonDirect.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
					this.buttonDirect.ForeColor = Color.White;
				}
				this.buttonBedrock.Visible = false;
				this.buttonDelete.Visible = false;
				this.buttonExport.Visible = false;
				this.buttonInstallPs3.Visible = false;
				this.buttonInstallXbox.Visible = false;
				this.buttonInstallWiiU.Visible = false;
			}
			else if (this.mode == 1)
			{
				this.buttonBedrock.Visible = true;
				this.buttonInstallPs3.Visible = true;
				this.buttonInstallXbox.Visible = true;
				this.buttonInstallWiiU.Visible = true;
				this.buttonDelete.Visible = true;
				this.buttonExport.Visible = true;
				this.buttonAd.Visible = false;
				this.buttonDirect.Visible = false;
			}
			this.labelName.Text = this.name;
			this.labelDesc.Text = this.desc;
			Label label = this.labelDesc;
			label.Text = string.Concat(new string[]
			{
				label.Text,
				Environment.NewLine,
				Environment.NewLine,
				"Creator: ",
				this.author
			});
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00014630 File Offset: 0x00012830
		private void buttonDirect_Click(object sender, EventArgs e)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile("http://www.nobledez.com//mod/pcks/" + this.direct + ".pck", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/PCK Center/myPcks/" + this.direct + ".pck");
				webClient.DownloadFile("http://www.nobledez.com//mod/pcks/" + this.direct + ".png", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/PCK Center/myPcks/" + this.direct + ".png");
				webClient.DownloadFile("http://www.nobledez.com//mod/pcks/" + this.direct + ".desc", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/PCK Center/myPcks/" + this.direct + ".desc");
				MessageBox.Show("PCK added to your PCKs Collection!");
				this.buttonDirect.Enabled = false;
				this.buttonDirect.Text = "Already in Collection";
				this.buttonDirect.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
				this.buttonDirect.ForeColor = Color.White;
				webClient.DownloadString("http://nobledez.com/mod/pckDownloadData/downloaded.php?name=" + this.direct);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00014778 File Offset: 0x00012978
		private void convertToBedrockToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.mod;
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
					foreach (PCK.MineFile mineFile in new PCK(this.appData + "/PCK Center/myPcks/" + this.mod + ".pck").mineFiles)
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
												string text6 = "";
												foreach (char c in array2[1].ToString())
												{
													if (!(c.ToString() != " "))
													{
														text6 = array2[1].ToString().Remove(0, text5.Count<char>() + 1);
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
														Name = text6
													});
												}
												else if (text5 == "BODY")
												{
													text5 = "body";
													list5.Add(new FormMain.Item
													{
														Id = text5,
														Name = text6
													});
												}
												else if (text5 == "ARM0")
												{
													text5 = "rightArm";
													list7.Add(new FormMain.Item
													{
														Id = text5,
														Name = text6
													});
												}
												else if (text5 == "ARM1")
												{
													text5 = "leftArm";
													list6.Add(new FormMain.Item
													{
														Id = text5,
														Name = text6
													});
												}
												else if (text5 == "LEG0")
												{
													text5 = "leftLeg";
													list8.Add(new FormMain.Item
													{
														Id = text5,
														Name = text6
													});
												}
												else if (text5 == "LEG1")
												{
													text5 = "rightLeg";
													list9.Add(new FormMain.Item
													{
														Id = text5,
														Name = text6
													});
												}
											}
											if (array2[0].ToString() == "OFFSET")
											{
												string text8 = "";
												foreach (char c2 in array2[1].ToString())
												{
													string text9 = array2[1].ToString();
													if (!(c2.ToString() != " "))
													{
														break;
													}
													text8 += c2.ToString();
													if (text8 == "HEAD")
													{
														num3 += double.Parse(text9.Remove(0, 7)) * -1.0;
													}
													else if (text8 == "BODY")
													{
														num4 += double.Parse(text9.Remove(0, 7)) * -1.0;
													}
													else if (text8 == "ARM0")
													{
														num5 += double.Parse(text9.Remove(0, 7)) * -1.0;
													}
													else if (text8 == "LEG0")
													{
														num6 += double.Parse(text9.Remove(0, 7)) * -1.0;
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
											string text10 = "";
											string text11 = "";
											string text12 = "";
											string text13 = "";
											string text14 = "";
											string text15 = "";
											string text16 = "";
											string text17 = "";
											int num8 = 0;
											foreach (char c3 in item.Name.ToString())
											{
												if (c3.ToString() != " " && num8 == 0)
												{
													text10 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 1)
												{
													text11 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 2)
												{
													text12 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 3)
												{
													text13 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 4)
												{
													text14 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 5)
												{
													text15 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 6)
												{
													text16 += c3.ToString();
												}
												else if (c3.ToString() != " " && num8 == 7)
												{
													text17 += c3.ToString();
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
													double.Parse(text10),
													", ",
													(double.Parse(text11) + 0.0) * -1.0 + num3 + 24.0 - double.Parse(text14),
													", ",
													double.Parse(text12),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text13),
													", ",
													double.Parse(text14),
													", ",
													double.Parse(text15),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text16),
													", ",
													double.Parse(text17),
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
											string text18 = "";
											string text19 = "";
											string text20 = "";
											string text21 = "";
											string text22 = "";
											string text23 = "";
											string text24 = "";
											string text25 = "";
											int num9 = 0;
											foreach (char c4 in item2.Name.ToString())
											{
												if (c4.ToString() != " " && num9 == 0)
												{
													text18 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 1)
												{
													text19 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 2)
												{
													text20 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 3)
												{
													text21 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 4)
												{
													text22 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 5)
												{
													text23 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 6)
												{
													text24 += c4.ToString();
												}
												else if (c4.ToString() != " " && num9 == 7)
												{
													text25 += c4.ToString();
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
													double.Parse(text18),
													", ",
													(double.Parse(text19) + 0.0) * -1.0 + num4 + 24.0 - double.Parse(text22),
													", ",
													double.Parse(text20),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text21),
													", ",
													double.Parse(text22),
													", ",
													double.Parse(text23),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text24),
													", ",
													double.Parse(text25),
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
											string text26 = "";
											string text27 = "";
											string text28 = "";
											string text29 = "";
											string text30 = "";
											string text31 = "";
											string text32 = "";
											string text33 = "";
											int num10 = 0;
											foreach (char c5 in item3.Name.ToString())
											{
												if (c5.ToString() != " " && num10 == 0)
												{
													text26 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 1)
												{
													text27 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 2)
												{
													text28 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 3)
												{
													text29 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 4)
												{
													text30 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 5)
												{
													text31 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 6)
												{
													text32 += c5.ToString();
												}
												else if (c5.ToString() != " " && num10 == 7)
												{
													text33 += c5.ToString();
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
													double.Parse(text26) + 5.0,
													", ",
													double.Parse(text27) * -1.0 + num5 + 22.0 - double.Parse(text30),
													", ",
													double.Parse(text28),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text29),
													", ",
													double.Parse(text30),
													", ",
													double.Parse(text31),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text32),
													", ",
													double.Parse(text33),
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
											string text34 = "";
											string text35 = "";
											string text36 = "";
											string text37 = "";
											string text38 = "";
											string text39 = "";
											string text40 = "";
											string text41 = "";
											int num11 = 0;
											foreach (char c6 in item4.Name.ToString())
											{
												if (c6.ToString() != " " && num11 == 0)
												{
													text34 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 1)
												{
													text35 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 2)
												{
													text36 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 3)
												{
													text37 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 4)
												{
													text38 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 5)
												{
													text39 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 6)
												{
													text40 += c6.ToString();
												}
												else if (c6.ToString() != " " && num11 == 7)
												{
													text41 += c6.ToString();
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
													double.Parse(text34) - 5.0,
													", ",
													double.Parse(text35) * -1.0 + num5 + 22.0 - double.Parse(text38),
													", ",
													double.Parse(text36),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text37),
													", ",
													double.Parse(text38),
													", ",
													double.Parse(text39),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text40),
													", ",
													double.Parse(text41),
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
											string text42 = "";
											string text43 = "";
											string text44 = "";
											string text45 = "";
											string text46 = "";
											string text47 = "";
											string text48 = "";
											string text49 = "";
											int num12 = 0;
											foreach (char c7 in item5.Name.ToString())
											{
												if (c7.ToString() != " " && num12 == 0)
												{
													text42 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 1)
												{
													text43 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 2)
												{
													text44 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 3)
												{
													text45 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 4)
												{
													text46 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 5)
												{
													text47 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 6)
												{
													text48 += c7.ToString();
												}
												else if (c7.ToString() != " " && num12 == 7)
												{
													text49 += c7.ToString();
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
													double.Parse(text42) - 1.9,
													", ",
													double.Parse(text43) * -1.0 + num6 + 12.0 - double.Parse(text46),
													", ",
													double.Parse(text44),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text45),
													", ",
													double.Parse(text46),
													", ",
													double.Parse(text47),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text48),
													", ",
													double.Parse(text49),
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
											string text50 = "";
											string text51 = "";
											string text52 = "";
											string text53 = "";
											string text54 = "";
											string text55 = "";
											string text56 = "";
											string text57 = "";
											int num13 = 0;
											foreach (char c8 in item6.Name.ToString())
											{
												if (c8.ToString() != " " && num13 == 0)
												{
													text50 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 1)
												{
													text51 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 2)
												{
													text52 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 3)
												{
													text53 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 4)
												{
													text54 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 5)
												{
													text55 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 6)
												{
													text56 += c8.ToString();
												}
												else if (c8.ToString() != " " && num13 == 7)
												{
													text57 += c8.ToString();
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
													double.Parse(text50) + 1.9,
													", ",
													double.Parse(text51) * -1.0 + num6 + 12.0 - double.Parse(text54),
													", ",
													double.Parse(text52),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"size\": [ ",
													double.Parse(text53),
													", ",
													double.Parse(text54),
													", ",
													double.Parse(text55),
													" ],"
												}));
												streamWriter2.WriteLine(string.Concat(new object[]
												{
													"            \"uv\": [ ",
													double.Parse(text56),
													", ",
													double.Parse(text57),
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
						string text58 = num14.ToString() + num15.ToString() + num16.ToString();
						if (text58.Count<char>() > 12)
						{
							text58.Remove(0, text58.Count<char>() - 12);
						}
						else if (text58.Count<char>() < 12)
						{
							int num17 = 12 - text58.Count<char>();
							for (int j = 0; j < num17; j++)
							{
								text58 += 0;
							}
						}
						else
						{
							text58.Count<char>();
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
								text58,
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
								pckCenterOpen.ResizeImage(bitmap, 64, 64);
							}
							else if (bitmap.Height == bitmap.Width / 2)
							{
								pckCenterOpen.ResizeImage(bitmap, 64, 32);
							}
							else
							{
								pckCenterOpen.ResizeImage(bitmap, 64, 64);
							}
							bitmap.Save(text2 + "/" + mineFile4.name, ImageFormat.Png);
						}
						foreach (PCK.MineFile mineFile5 in list3)
						{
							File.WriteAllBytes(text2 + "/" + mineFile5.name, mineFile5.data);
						}
						string sourceDirectoryName = text2;
						string text59 = text3 + "content.zipe";
						try
						{
							ZipFile.CreateFromDirectory(sourceDirectoryName, text59);
						}
						catch (Exception)
						{
							File.Delete(text59);
							ZipFile.CreateFromDirectory(sourceDirectoryName, text59);
						}
						text3 = text2 + "temp/";
						Directory.CreateDirectory(text3);
						File.Move(text59, text3 + "content.zipe");
						File.Copy(text2 + "/manifest.json", text3 + "/manifest.json");
						ZipFile.CreateFromDirectory(text3, saveFileDialog.FileName);
						Directory.Delete(text2, true);
						Directory.Delete(text3, true);
						MessageBox.Show("Conversion Complete");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00020264 File Offset: 0x0001E464
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

		// Token: 0x0600017F RID: 383 RVA: 0x00003536 File Offset: 0x00001736
		private void buttonAd_Click(object sender, EventArgs e)
		{
			Process.Start(this.ad);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00020318 File Offset: 0x0001E518
		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				File.Delete(this.appData + "/PCK Center/myPcks/" + this.mod + ".pck");
				File.Delete(this.appData + "/PCK Center/myPcks/" + this.mod + ".png");
				File.Delete(this.appData + "/PCK Center/myPcks/" + this.mod + ".desc");
				this.reloader();
			}
			catch (Exception)
			{
				MessageBox.Show("Error");
			}
			base.Close();
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000203B8 File Offset: 0x0001E5B8
		private void buttonExport_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Get your PCK file";
			saveFileDialog.Filter = "PCK (Minecraft Wii U Package)|*.pck";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					File.Copy(this.appData + "/PCK Center/myPcks/" + this.mod + ".pck", saveFileDialog.FileName);
					MessageBox.Show("PCK Received from location!");
				}
				catch (Exception)
				{
					MessageBox.Show("Error");
				}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003544 File Offset: 0x00001744
		private void buttonInstallXbox_Click(object sender, EventArgs e)
		{
			Process.Start("http://nobledez.com/pckStudio#install");
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003544 File Offset: 0x00001744
		private void buttonInstallPs3_Click(object sender, EventArgs e)
		{
			Process.Start("http://nobledez.com/pckStudio#install");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00003551 File Offset: 0x00001751
		private void buttonInstallWiiU_Click(object sender, EventArgs e)
		{
			new installWiiU(this.appData + "/PCK Center/myPcks/" + this.mod + ".pck").ShowDialog();
		}

		// Token: 0x04000329 RID: 809
		private string name;

		// Token: 0x0400032A RID: 810
		private string author;

		// Token: 0x0400032B RID: 811
		private string desc;

		// Token: 0x0400032C RID: 812
		private string direct;

		// Token: 0x0400032D RID: 813
		private string ad;

		// Token: 0x0400032E RID: 814
		private int mode;

		// Token: 0x0400032F RID: 815
		private string mod;

		// Token: 0x04000330 RID: 816
		private string appData = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "/PCK Studio/";

		// Token: 0x04000331 RID: 817
		private MethodInvoker reloader;
	}
}
