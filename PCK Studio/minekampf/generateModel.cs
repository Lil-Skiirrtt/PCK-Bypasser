using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using minekampf.Forms;
using minekampf.Properties;

namespace minekampf
{
	// Token: 0x02000062 RID: 98
	public partial class generateModel : MetroForm
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00005EE0 File Offset: 0x000040E0
		private void checkSelect()
		{
			if (this.listViewBoxes.SelectedItems.Count == 0)
			{
				this.textXc.Enabled = false;
				this.textYc.Enabled = false;
				this.textZc.Enabled = false;
				this.textXf.Enabled = false;
				this.textYf.Enabled = false;
				this.textZf.Enabled = false;
				this.textTextureX.Enabled = false;
				this.textTextureY.Enabled = false;
				this.buttonXcminus.Enabled = false;
				this.buttonYcminus.Enabled = false;
				this.buttonZcminus.Enabled = false;
				this.buttonXcplus.Enabled = false;
				this.buttonYcplus.Enabled = false;
				this.buttonZcplus.Enabled = false;
				this.buttonXfminus.Enabled = false;
				this.buttonYfminus.Enabled = false;
				this.buttonZfminus.Enabled = false;
				this.buttonXfplus.Enabled = false;
				this.buttonYfplus.Enabled = false;
				this.buttonZfplus.Enabled = false;
				this.comboParent.Enabled = false;
				return;
			}
			this.selected = this.listViewBoxes.SelectedItems[0];
			if (this.selected == null)
			{
				this.textXc.Enabled = false;
				this.textYc.Enabled = false;
				this.textZc.Enabled = false;
				this.textXf.Enabled = false;
				this.textYf.Enabled = false;
				this.textZf.Enabled = false;
				this.textTextureX.Enabled = false;
				this.textTextureY.Enabled = false;
				this.buttonXcminus.Enabled = false;
				this.buttonYcminus.Enabled = false;
				this.buttonZcminus.Enabled = false;
				this.buttonXcplus.Enabled = false;
				this.buttonYcplus.Enabled = false;
				this.buttonZcplus.Enabled = false;
				this.buttonXfminus.Enabled = false;
				this.buttonYfminus.Enabled = false;
				this.buttonZfminus.Enabled = false;
				this.buttonXfplus.Enabled = false;
				this.buttonYfplus.Enabled = false;
				this.buttonZfplus.Enabled = false;
				return;
			}
			this.textXc.Enabled = true;
			this.textYc.Enabled = true;
			this.textZc.Enabled = true;
			this.textXf.Enabled = true;
			this.textYf.Enabled = true;
			this.textZf.Enabled = true;
			this.textTextureX.Enabled = true;
			this.textTextureY.Enabled = true;
			this.buttonXcminus.Enabled = true;
			this.buttonYcminus.Enabled = true;
			this.buttonZcminus.Enabled = true;
			this.buttonXcplus.Enabled = true;
			this.buttonYcplus.Enabled = true;
			this.buttonZcplus.Enabled = true;
			this.buttonXfminus.Enabled = true;
			this.buttonYfminus.Enabled = true;
			this.buttonZfminus.Enabled = true;
			this.buttonXfplus.Enabled = true;
			this.buttonYfplus.Enabled = true;
			this.buttonZfplus.Enabled = true;
			this.comboParent.Enabled = true;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006210 File Offset: 0x00004410
		public generateModel(List<object[]> boxesIn, PictureBox preview)
		{
			this.InitializeComponent();
			this.boxes = new List<object[]>();
			this.boxes = boxesIn;
			this.skinPreview = preview;
			this.direction = "front";
			this.bg = new Bitmap(this.displayBox.Image);
			this.buttonIMPORT.Enabled = false;
			this.buttonEXPORT.Enabled = false;
			this.textXc.Enabled = false;
			this.textYc.Enabled = false;
			this.textZc.Enabled = false;
			this.textXf.Enabled = false;
			this.textYf.Enabled = false;
			this.textZf.Enabled = false;
			this.textTextureX.Enabled = false;
			this.textTextureY.Enabled = false;
			this.buttonXcminus.Enabled = false;
			this.buttonYcminus.Enabled = false;
			this.buttonZcminus.Enabled = false;
			this.buttonXcplus.Enabled = false;
			this.buttonYcplus.Enabled = false;
			this.buttonZcplus.Enabled = false;
			this.buttonXfminus.Enabled = false;
			this.buttonYfminus.Enabled = false;
			this.buttonZfminus.Enabled = false;
			this.buttonXfplus.Enabled = false;
			this.buttonYfplus.Enabled = false;
			this.buttonZfplus.Enabled = false;
			this.comboParent.Enabled = false;
			this.loadData();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000639C File Offset: 0x0000459C
		private void loadData()
		{
			foreach (object[] array in this.boxes)
			{
				if (array[0].ToString() == "BOX")
				{
					int num = 0;
					string text = "";
					string text2 = "";
					string text3 = "";
					string text4 = "";
					string text5 = "";
					string text6 = "";
					string text7 = "";
					string text8 = "";
					string text9 = "";
					foreach (char c in array[1].ToString())
					{
						if (c.ToString() == " ")
						{
							num++;
						}
						else if (num == 0 && c.ToString() != " ")
						{
							text += c.ToString();
						}
						else if (num == 1 && c.ToString() != " ")
						{
							text2 += c.ToString();
						}
						else if (num == 2 && c.ToString() != " ")
						{
							text3 += c.ToString();
						}
						else if (num == 3 && c.ToString() != " ")
						{
							text4 += c.ToString();
						}
						else if (num == 4 && c.ToString() != " ")
						{
							text5 += c.ToString();
						}
						else if (num == 5 && c.ToString() != " ")
						{
							text6 += c.ToString();
						}
						else if (num == 6 && c.ToString() != " ")
						{
							text7 += c.ToString();
						}
						else if (num == 7 && c.ToString() != " ")
						{
							text8 += c.ToString();
						}
						else if (num == 8 && c.ToString() != " ")
						{
							text9 += c.ToString();
						}
					}
					ListViewItem listViewItem = new ListViewItem();
					listViewItem.Text = "BOX";
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text2));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text3));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text4));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text5));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text6));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text7));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text8));
					listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, text9));
					listViewItem.Tag = text;
					this.listViewBoxes.Items.Add(listViewItem);
					this.comboParent.Enabled = true;
				}
			}
			this.render();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002DEA File Offset: 0x00000FEA
		private void listView1_DoubleClick_1(object sender, EventArgs e)
		{
			this.listViewBoxes.SelectedItems[0].BeginEdit();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000670C File Offset: 0x0000490C
		private void render()
		{
			if (this.listViewBoxes.Items.Count == 0)
			{
				this.buttonTemplate.Enabled = true;
			}
			else
			{
				this.buttonTemplate.Enabled = false;
			}
			this.setZ();
			this.labelView.Text = "View: " + this.direction;
			try
			{
				Bitmap bitmap = new Bitmap(this.displayBox.Width, this.displayBox.Height);
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.Clear(this.backgroundColor);
					int num = this.displayBox.Height / 2 + 25;
					int num2 = this.displayBox.Height / 2 + 35;
					int num3 = this.displayBox.Height / 2 + 85;
					int num4 = this.displayBox.Height / 2 + 145;
					graphics.DrawLine(Pens.White, 0, num4, this.displayBox.Width, num4);
					if (this.direction == "front")
					{
						if (this.checkGuide.Checked)
						{
							try
							{
								graphics.DrawLine(Pens.Red, this.displayBox.Width / 2, 0, this.displayBox.Width / 2, this.displayBox.Height);
								graphics.DrawLine(Pens.Blue, this.displayBox.Width / 2 + 30, 0, this.displayBox.Width / 2 + 30, this.displayBox.Height);
								graphics.DrawLine(Pens.Blue, this.displayBox.Width / 2 - 30, 0, this.displayBox.Width / 2 - 30, this.displayBox.Height);
								graphics.DrawLine(Pens.Purple, this.displayBox.Width / 2 - 10, 0, this.displayBox.Width / 2 - 10, this.displayBox.Height);
								graphics.DrawLine(Pens.Purple, this.displayBox.Width / 2 + 10, 0, this.displayBox.Width / 2 + 10, this.displayBox.Height);
								graphics.DrawLine(Pens.Red, 0f, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f);
								graphics.DrawLine(Pens.Green, 0f, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f);
								graphics.DrawLine(Pens.Blue, 0f, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f);
								graphics.DrawLine(Pens.Purple, 0f, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f, (float)this.displayBox.Width, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f);
							}
							catch (Exception)
							{
							}
						}
						using (IEnumerator enumerator = this.listViewBoxes.Items.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								ListViewItem listViewItem = (ListViewItem)obj;
								int num5 = 0;
								int num6 = 0;
								try
								{
									if (listViewItem.Tag.ToString() == "HEAD")
									{
										num5 = this.displayBox.Width / 2;
										num6 = num + int.Parse(this.offsetHead.Text) * 5;
									}
									else if (listViewItem.Tag.ToString() == "BODY")
									{
										num5 = this.displayBox.Width / 2;
										num6 = num + int.Parse(this.offsetBody.Text) * 5;
									}
									else if (listViewItem.Tag.ToString() == "ARM0")
									{
										num5 = this.displayBox.Width / 2 - 25;
										num6 = num2 + int.Parse(this.offsetArms.Text) * 5;
									}
									else if (listViewItem.Tag.ToString() == "ARM1")
									{
										num5 = this.displayBox.Width / 2 + 25;
										num6 = num2 + int.Parse(this.offsetArms.Text) * 5;
									}
									else if (listViewItem.Tag.ToString() == "LEG0")
									{
										num5 = this.displayBox.Width / 2 - 10;
										num6 = num3 + int.Parse(this.offsetLegs.Text) * 5;
									}
									else if (listViewItem.Tag.ToString() == "LEG1")
									{
										num5 = this.displayBox.Width / 2 + 10;
										num6 = num3 + int.Parse(this.offsetLegs.Text) * 5;
									}
									if (!this.autoTexture)
									{
										RectangleF destRect = new RectangleF((float)num5 + (float)double.Parse(listViewItem.SubItems[1].Text) * 5f, (float)num6 + (float)double.Parse(listViewItem.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem.SubItems[4].Text) * 5f, (float)double.Parse(listViewItem.SubItems[5].Text) * 5f);
										RectangleF srcRect = new RectangleF((float)double.Parse(listViewItem.SubItems[7].Text) + (float)double.Parse(listViewItem.SubItems[6].Text), (float)double.Parse(listViewItem.SubItems[8].Text) + (float)double.Parse(listViewItem.SubItems[6].Text), (float)double.Parse(listViewItem.SubItems[4].Text), (float)double.Parse(listViewItem.SubItems[5].Text));
										graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
										graphics.DrawImage(this.texturePreview.Image, destRect, srcRect, GraphicsUnit.Pixel);
									}
									else
									{
										graphics.FillRectangle(new SolidBrush(listViewItem.ForeColor), (float)num5 + (float)double.Parse(listViewItem.SubItems[1].Text) * 5f, (float)num6 + (float)double.Parse(listViewItem.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem.SubItems[4].Text) * 5f, (float)double.Parse(listViewItem.SubItems[5].Text) * 5f);
									}
									if (this.checkBoxArmor.Checked)
									{
										SolidBrush brush = new SolidBrush(Color.FromArgb(80, 50, 50, 75));
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2 - 20), (float)(num - 40) + (float)double.Parse(this.offsetHelmet.Text) * 5f, 40f, 40f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2 - 35), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2 + 25), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2 - 20), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2 - 20), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
										graphics.FillRectangle(brush, (float)(this.displayBox.Width / 2), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
									}
									if (listViewItem.Index == this.selected.Index)
									{
										graphics.DrawRectangle(Pens.Yellow, (float)num5 + (float)double.Parse(this.selected.SubItems[1].Text) * 5f - 1f, (float)num6 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f - 1f, (float)double.Parse(this.selected.SubItems[4].Text) * 5f + 2f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f + 2f);
										graphics.DrawRectangle(Pens.Black, (float)num5 + (float)double.Parse(this.selected.SubItems[1].Text) * 5f, (float)num6 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f, (float)double.Parse(this.selected.SubItems[4].Text) * 5f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f);
									}
								}
								catch (Exception)
								{
								}
							}
							goto IL_2435;
						}
					}
					if (this.direction == "left")
					{
						if (this.checkGuide.Checked)
						{
							try
							{
								graphics.DrawLine(Pens.Red, this.displayBox.Width / 2, 0, this.displayBox.Width / 2, this.displayBox.Height);
								graphics.DrawLine(Pens.Red, 0f, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f);
								graphics.DrawLine(Pens.Green, 0f, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f);
								graphics.DrawLine(Pens.Blue, 0f, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f);
								graphics.DrawLine(Pens.Purple, 0f, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f, (float)this.displayBox.Width, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f);
							}
							catch (Exception)
							{
							}
						}
						foreach (object obj2 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem2 = (ListViewItem)obj2;
							int num7 = 0;
							int num8 = 0;
							try
							{
								if (listViewItem2.Tag.ToString() == "HEAD")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num + int.Parse(this.offsetHead.Text) * 5;
								}
								else if (listViewItem2.Tag.ToString() == "BODY")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num + int.Parse(this.offsetBody.Text) * 5;
								}
								else if (listViewItem2.Tag.ToString() == "ARM0")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem2.Tag.ToString() == "ARM1")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem2.Tag.ToString() == "LEG0")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								else if (listViewItem2.Tag.ToString() == "LEG1")
								{
									num7 = this.displayBox.Width / 2;
									num8 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								if (!this.autoTexture)
								{
									RectangleF destRect2 = new RectangleF((float)((double)num7 + double.Parse(listViewItem2.SubItems[3].Text) * 5.0), (float)((double)num8 + double.Parse(listViewItem2.SubItems[2].Text) * 5.0), (float)(double.Parse(listViewItem2.SubItems[6].Text) * 5.0), (float)(double.Parse(listViewItem2.SubItems[5].Text) * 5.0));
									RectangleF srcRect2 = new RectangleF((float)double.Parse(listViewItem2.SubItems[7].Text) + (float)double.Parse(listViewItem2.SubItems[6].Text) + (float)double.Parse(listViewItem2.SubItems[4].Text), (float)(double.Parse(listViewItem2.SubItems[8].Text) + double.Parse(listViewItem2.SubItems[6].Text)), (float)double.Parse(listViewItem2.SubItems[6].Text), (float)double.Parse(listViewItem2.SubItems[5].Text));
									graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
									graphics.DrawImage(this.texturePreview.Image, destRect2, srcRect2, GraphicsUnit.Pixel);
								}
								else
								{
									graphics.FillRectangle(new SolidBrush(listViewItem2.ForeColor), (float)num7 + (float)double.Parse(listViewItem2.SubItems[3].Text) * 5f, (float)num8 + (float)double.Parse(listViewItem2.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem2.SubItems[6].Text) * 5f, (float)double.Parse(listViewItem2.SubItems[5].Text) * 5f);
								}
								if (this.checkBoxArmor.Checked)
								{
									SolidBrush brush2 = new SolidBrush(Color.FromArgb(80, 50, 50, 75));
									graphics.FillRectangle(brush2, (float)(this.displayBox.Width / 2 - 20), (float)(num - 40) + (float)double.Parse(this.offsetHelmet.Text) * 5f, 40f, 40f);
									graphics.FillRectangle(brush2, (float)(this.displayBox.Width / 2 - 5), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
									graphics.FillRectangle(brush2, (float)(this.displayBox.Width / 2 - 10), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
									graphics.FillRectangle(brush2, (float)(this.displayBox.Width / 2 - 10), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
								}
								if (listViewItem2.Index == this.selected.Index)
								{
									graphics.DrawRectangle(Pens.Yellow, (float)num7 + (float)double.Parse(this.selected.SubItems[3].Text) * 5f - 1f, (float)num8 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f - 1f, (float)double.Parse(this.selected.SubItems[6].Text) * 5f + 2f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f + 2f);
									graphics.DrawRectangle(Pens.Black, (float)num7 + (float)double.Parse(this.selected.SubItems[3].Text) * 5f, (float)num8 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f, (float)double.Parse(this.selected.SubItems[6].Text) * 5f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f);
								}
							}
							catch (Exception)
							{
							}
						}
						bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
					}
					else if (this.direction == "back")
					{
						if (this.checkGuide.Checked)
						{
							try
							{
								graphics.DrawLine(Pens.Red, this.displayBox.Width / 2, 0, this.displayBox.Width / 2, this.displayBox.Height);
								graphics.DrawLine(Pens.Blue, this.displayBox.Width / 2 + 30, 0, this.displayBox.Width / 2 + 30, this.displayBox.Height);
								graphics.DrawLine(Pens.Blue, this.displayBox.Width / 2 - 30, 0, this.displayBox.Width / 2 - 30, this.displayBox.Height);
								graphics.DrawLine(Pens.Purple, this.displayBox.Width / 2 - 10, 0, this.displayBox.Width / 2 - 10, this.displayBox.Height);
								graphics.DrawLine(Pens.Purple, this.displayBox.Width / 2 + 10, 0, this.displayBox.Width / 2 + 10, this.displayBox.Height);
								graphics.DrawLine(Pens.Red, 0f, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f);
								graphics.DrawLine(Pens.Green, 0f, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f);
								graphics.DrawLine(Pens.Blue, 0f, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f);
								graphics.DrawLine(Pens.Purple, 0f, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f, (float)this.displayBox.Width, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f);
							}
							catch (Exception)
							{
							}
						}
						foreach (object obj3 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem3 = (ListViewItem)obj3;
							int num9 = 0;
							int num10 = 0;
							try
							{
								if (listViewItem3.Tag.ToString() == "HEAD")
								{
									num9 = this.displayBox.Width / 2;
									num10 = num + int.Parse(this.offsetHead.Text) * 5;
								}
								else if (listViewItem3.Tag.ToString() == "BODY")
								{
									num9 = this.displayBox.Width / 2;
									num10 = num + int.Parse(this.offsetBody.Text) * 5;
								}
								else if (listViewItem3.Tag.ToString() == "ARM0")
								{
									num9 = this.displayBox.Width / 2 - 25;
									num10 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem3.Tag.ToString() == "ARM1")
								{
									num9 = this.displayBox.Width / 2 + 25;
									num10 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem3.Tag.ToString() == "LEG0")
								{
									num9 = this.displayBox.Width / 2 - 10;
									num10 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								else if (listViewItem3.Tag.ToString() == "LEG1")
								{
									num9 = this.displayBox.Width / 2 + 10;
									num10 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								if (!this.autoTexture)
								{
									RectangleF destRect3 = new RectangleF((float)num9 + (float)double.Parse(listViewItem3.SubItems[1].Text) * 5f, (float)num10 + (float)double.Parse(listViewItem3.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem3.SubItems[4].Text) * 5f, (float)double.Parse(listViewItem3.SubItems[5].Text) * 5f);
									RectangleF srcRect3 = new RectangleF((float)double.Parse(listViewItem3.SubItems[7].Text) + (float)double.Parse(listViewItem3.SubItems[6].Text) + (float)double.Parse(listViewItem3.SubItems[4].Text) + (float)double.Parse(listViewItem3.SubItems[6].Text), (float)double.Parse(listViewItem3.SubItems[8].Text) + (float)double.Parse(listViewItem3.SubItems[6].Text), (float)double.Parse(listViewItem3.SubItems[4].Text), (float)double.Parse(listViewItem3.SubItems[5].Text));
									graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
									graphics.DrawImage(this.texturePreview.Image, destRect3, srcRect3, GraphicsUnit.Pixel);
								}
								else
								{
									graphics.FillRectangle(new SolidBrush(listViewItem3.ForeColor), (float)num9 + (float)double.Parse(listViewItem3.SubItems[1].Text) * 5f, (float)num10 + (float)double.Parse(listViewItem3.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem3.SubItems[4].Text) * 5f, (float)double.Parse(listViewItem3.SubItems[5].Text) * 5f);
								}
								if (this.checkBoxArmor.Checked)
								{
									SolidBrush brush3 = new SolidBrush(Color.FromArgb(80, 50, 50, 75));
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2 - 20), (float)(num - 40) + (float)double.Parse(this.offsetHelmet.Text) * 5f, 40f, 40f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2 - 35), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2 + 25), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2 - 20), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2 - 20), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
									graphics.FillRectangle(brush3, (float)(this.displayBox.Width / 2), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
								}
								if (listViewItem3.Index == this.selected.Index)
								{
									graphics.DrawRectangle(Pens.Yellow, (float)num9 + (float)double.Parse(this.selected.SubItems[1].Text) * 5f - 1f, (float)num10 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f - 1f, (float)double.Parse(this.selected.SubItems[4].Text) * 5f + 2f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f + 2f);
									graphics.DrawRectangle(Pens.Black, (float)num9 + (float)double.Parse(this.selected.SubItems[1].Text) * 5f, (float)num10 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f, (float)double.Parse(this.selected.SubItems[4].Text) * 5f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f);
								}
							}
							catch (Exception)
							{
							}
						}
						bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
					}
					else if (this.direction == "right")
					{
						if (this.checkGuide.Checked)
						{
							try
							{
								graphics.DrawLine(Pens.Red, this.displayBox.Width / 2, 0, this.displayBox.Width / 2, this.displayBox.Height);
								graphics.DrawLine(Pens.Red, 0f, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetHead.Text) * 5f);
								graphics.DrawLine(Pens.Green, 0f, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetBody.Text) * 5f);
								graphics.DrawLine(Pens.Blue, 0f, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f, (float)this.displayBox.Width, (float)num + (float)double.Parse(this.offsetArms.Text) * 5f);
								graphics.DrawLine(Pens.Purple, 0f, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f, (float)this.displayBox.Width, (float)num3 + (float)double.Parse(this.offsetLegs.Text) * 5f);
							}
							catch (Exception)
							{
							}
						}
						foreach (object obj4 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem4 = (ListViewItem)obj4;
							int num11 = 0;
							int num12 = 0;
							try
							{
								if (listViewItem4.Tag.ToString() == "HEAD")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num + int.Parse(this.offsetHead.Text) * 5;
								}
								else if (listViewItem4.Tag.ToString() == "BODY")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num + int.Parse(this.offsetBody.Text) * 5;
								}
								else if (listViewItem4.Tag.ToString() == "ARM0")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem4.Tag.ToString() == "ARM1")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num2 + int.Parse(this.offsetArms.Text) * 5;
								}
								else if (listViewItem4.Tag.ToString() == "LEG0")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								else if (listViewItem4.Tag.ToString() == "LEG1")
								{
									num11 = this.displayBox.Width / 2;
									num12 = num3 + int.Parse(this.offsetLegs.Text) * 5;
								}
								if (!this.autoTexture)
								{
									RectangleF destRect4 = new RectangleF((float)((double)num11 + double.Parse(listViewItem4.SubItems[3].Text) * 5.0), (float)((double)num12 + double.Parse(listViewItem4.SubItems[2].Text) * 5.0), (float)(double.Parse(listViewItem4.SubItems[6].Text) * 5.0), (float)(double.Parse(listViewItem4.SubItems[5].Text) * 5.0));
									RectangleF srcRect4 = new RectangleF((float)(double.Parse(listViewItem4.SubItems[7].Text) + double.Parse(listViewItem4.SubItems[6].Text) + double.Parse(listViewItem4.SubItems[4].Text)), (float)(double.Parse(listViewItem4.SubItems[8].Text) + double.Parse(listViewItem4.SubItems[6].Text)), (float)double.Parse(listViewItem4.SubItems[6].Text), (float)double.Parse(listViewItem4.SubItems[5].Text));
									graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
									graphics.DrawImage(this.texturePreview.Image, destRect4, srcRect4, GraphicsUnit.Pixel);
								}
								else
								{
									graphics.FillRectangle(new SolidBrush(listViewItem4.ForeColor), (float)num11 + (float)double.Parse(listViewItem4.SubItems[3].Text) * 5f, (float)num12 + (float)double.Parse(listViewItem4.SubItems[2].Text) * 5f, (float)double.Parse(listViewItem4.SubItems[6].Text) * 5f, (float)double.Parse(listViewItem4.SubItems[5].Text) * 5f);
								}
								if (this.checkBoxArmor.Checked)
								{
									SolidBrush brush4 = new SolidBrush(Color.FromArgb(80, 50, 50, 75));
									graphics.FillRectangle(brush4, (float)(this.displayBox.Width / 2 - 20), (float)(num - 40) + (float)double.Parse(this.offsetHelmet.Text) * 5f, 40f, 40f);
									graphics.FillRectangle(brush4, (float)(this.displayBox.Width / 2 - 5), (float)(num2 + 45) + (float)double.Parse(this.offsetTool.Text) * 5f, 10f, 10f);
									graphics.FillRectangle(brush4, (float)(this.displayBox.Width / 2 - 10), (float)num3 + (float)double.Parse(this.offsetPants.Text) * 5f, 20f, 40f);
									graphics.FillRectangle(brush4, (float)(this.displayBox.Width / 2 - 10), (float)(num3 + 40) + (float)double.Parse(this.offsetBoots.Text) * 5f, 20f, 20f);
								}
								if (listViewItem4.Index == this.selected.Index)
								{
									graphics.DrawRectangle(Pens.Yellow, (float)num11 + (float)double.Parse(this.selected.SubItems[3].Text) * 5f - 1f, (float)num12 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f - 1f, (float)double.Parse(this.selected.SubItems[6].Text) * 5f + 2f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f + 2f);
									graphics.DrawRectangle(Pens.Black, (float)num11 + (float)double.Parse(this.selected.SubItems[3].Text) * 5f, (float)num12 + (float)double.Parse(this.selected.SubItems[2].Text) * 5f, (float)double.Parse(this.selected.SubItems[6].Text) * 5f, (float)double.Parse(this.selected.SubItems[5].Text) * 5f);
								}
							}
							catch (Exception)
							{
							}
						}
					}
					IL_2435:
					graphics.Dispose();
				}
				this.displayBox.Image = bitmap;
			}
			catch (Exception)
			{
				return;
			}
			if (this.autoTexture)
			{
				Bitmap image = new Bitmap(this.texturePreview.Width, this.texturePreview.Height);
				using (Graphics graphics2 = Graphics.FromImage(image))
				{
					foreach (object obj5 in this.listViewBoxes.Items)
					{
						ListViewItem listViewItem5 = (ListViewItem)obj5;
						try
						{
							double.Parse(listViewItem5.SubItems[1].Text);
							double.Parse(listViewItem5.SubItems[2].Text);
							double.Parse(listViewItem5.SubItems[3].Text);
							double num13 = (double)((float)double.Parse(listViewItem5.SubItems[4].Text) * 2f);
							double num14 = (double)((float)double.Parse(listViewItem5.SubItems[5].Text) * 2f);
							double num15 = (double)((float)double.Parse(listViewItem5.SubItems[6].Text) * 2f);
							double num16 = (double)((float)double.Parse(listViewItem5.SubItems[7].Text) * 2f);
							double num17 = (double)((float)double.Parse(listViewItem5.SubItems[8].Text) * 2f);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)(num16 + num15), (float)num17, (float)num13, (float)num15);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)(num16 + num15 + num13), (float)num17, (float)num13, (float)num15);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16, (float)num17 + (float)num15, (float)num15, (float)num14);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16 + (float)num15, (float)num17 + (float)num15, (float)num13, (float)num14);
							if (listViewItem5.Tag.ToString() != "HEAD")
							{
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16 + (float)num15 + (float)num13, (float)num17 + (float)num15, (float)num13, (float)num14);
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16 + (float)num15 + (float)num13 + (float)num13, (float)num17 + (float)num15, (float)num15, (float)num14);
							}
							else
							{
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16 + (float)num15 + (float)num13 + (float)num13, (float)num17 + (float)num15, (float)num15, (float)num14);
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), (float)num16 + (float)num15 + (float)num13, (float)num17 + (float)num15, (float)num13, (float)num14);
							}
						}
						catch
						{
						}
					}
					graphics2.Dispose();
				}
				this.texturePreview.Image = image;
			}
			this.checkSelect();
			foreach (object obj6 in this.listViewBoxes.Items)
			{
				ListViewItem listViewItem6 = (ListViewItem)obj6;
				try
				{
					if (listViewItem6.Tag == null)
					{
						this.buttonDone.Enabled = false;
					}
					else
					{
						this.buttonDone.Enabled = true;
					}
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000909C File Offset: 0x0000729C
		private void setZ()
		{
			try
			{
				foreach (object obj in this.listViewBoxes.Items)
				{
					((ListViewItem)obj).SubItems.Add("unchecked");
				}
				if (this.listViewBoxes.SelectedItems.Count != 0)
				{
					this.selected = this.listViewBoxes.SelectedItems[0];
				}
				else
				{
					this.selected = null;
				}
				if (this.direction == "front")
				{
					int num = 0;
					do
					{
						foreach (object obj2 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj2;
							if (listViewItem.SubItems[9].Text == "unchecked")
							{
								if (listViewItem.Tag.ToString() == "HEAD")
								{
									int num2 = this.displayBox.Width / 2;
								}
								else if (listViewItem.Tag.ToString() == "BODY")
								{
									int num3 = this.displayBox.Width / 2;
								}
								else if (!(listViewItem.Tag.ToString() == "ARM0") && !(listViewItem.Tag.ToString() == "ARM1") && !(listViewItem.Tag.ToString() == "LEG0"))
								{
									listViewItem.Tag.ToString() == "LEG1";
								}
								bool flag = false;
								int index = listViewItem.Index;
								foreach (object obj3 in this.listViewBoxes.Items)
								{
									ListViewItem listViewItem2 = (ListViewItem)obj3;
									if (listViewItem2.SubItems[9].Text == "unchecked" && (int)double.Parse(listViewItem.SubItems[3].Text) + (int)double.Parse(listViewItem.SubItems[6].Text) < (int)double.Parse(listViewItem2.SubItems[3].Text) + (int)double.Parse(listViewItem2.SubItems[6].Text) && listViewItem2.Index < this.listViewBoxes.Items.Count + 1)
									{
										index = listViewItem2.Index + 1;
										flag = true;
									}
								}
								listViewItem.SubItems[9].Text = "checked";
								num++;
								if (flag)
								{
									ListViewItem item = (ListViewItem)listViewItem.Clone();
									this.listViewBoxes.Items.Insert(index, item);
									if (this.listViewBoxes.SelectedItems.Count != 0 && this.selected.Index == listViewItem.Index)
									{
										this.selected = item;
									}
									listViewItem.Remove();
								}
							}
							else
							{
								num++;
							}
						}
					}
					while (num < this.listViewBoxes.Items.Count);
				}
				else if (this.direction == "left")
				{
					int num4 = 0;
					do
					{
						foreach (object obj4 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem3 = (ListViewItem)obj4;
							if (listViewItem3.SubItems[listViewItem3.SubItems.Count - 1].Text == "unchecked")
							{
								int num5 = 0;
								if (listViewItem3.Tag.ToString() == "HEAD")
								{
									num5 = this.displayBox.Width / 2;
								}
								else if (listViewItem3.Tag.ToString() == "BODY")
								{
									num5 = this.displayBox.Width / 2;
								}
								else if (listViewItem3.Tag.ToString() == "ARM0")
								{
									num5 = 178;
								}
								else if (listViewItem3.Tag.ToString() == "ARM1")
								{
									num5 = 228;
								}
								else if (listViewItem3.Tag.ToString() == "LEG0")
								{
									num5 = 193;
								}
								else if (listViewItem3.Tag.ToString() == "LEG1")
								{
									num5 = 213;
								}
								bool flag2 = false;
								int index2 = listViewItem3.Index;
								foreach (object obj5 in this.listViewBoxes.Items)
								{
									ListViewItem listViewItem4 = (ListViewItem)obj5;
									if (listViewItem4.SubItems[9].Text == "unchecked")
									{
										int num6 = 0;
										if (listViewItem4.Tag.ToString() == "HEAD")
										{
											num6 = this.displayBox.Width / 2;
										}
										else if (listViewItem4.Tag.ToString() == "BODY")
										{
											num6 = this.displayBox.Width / 2;
										}
										else if (listViewItem4.Tag.ToString() == "ARM0")
										{
											num6 = 178;
										}
										else if (listViewItem4.Tag.ToString() == "ARM1")
										{
											num6 = 228;
										}
										else if (listViewItem4.Tag.ToString() == "LEG0")
										{
											num6 = 193;
										}
										else if (listViewItem4.Tag.ToString() == "LEG1")
										{
											num6 = 213;
										}
										if ((int)double.Parse(listViewItem3.SubItems[1].Text) + (int)double.Parse(listViewItem3.SubItems[4].Text) + num5 < (int)double.Parse(listViewItem4.SubItems[1].Text) + (int)double.Parse(listViewItem4.SubItems[4].Text) + num6 && listViewItem4.Index + 1 < this.listViewBoxes.Items.Count + 1)
										{
											index2 = listViewItem4.Index + 1;
											flag2 = true;
										}
									}
								}
								listViewItem3.SubItems[9].Text = "checked";
								num4++;
								if (flag2)
								{
									ListViewItem item2 = (ListViewItem)listViewItem3.Clone();
									this.listViewBoxes.Items.Insert(index2, item2);
									if (this.listViewBoxes.SelectedItems.Count != 0 && this.selected.Index == listViewItem3.Index)
									{
										this.selected = item2;
									}
									listViewItem3.Remove();
								}
							}
							else
							{
								num4++;
							}
						}
					}
					while (num4 < this.listViewBoxes.Items.Count);
				}
				else if (this.direction == "back")
				{
					int num7 = 0;
					do
					{
						foreach (object obj6 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem5 = (ListViewItem)obj6;
							if (listViewItem5.SubItems[listViewItem5.SubItems.Count - 1].Text == "unchecked")
							{
								bool flag3 = false;
								int index3 = listViewItem5.Index;
								foreach (object obj7 in this.listViewBoxes.Items)
								{
									ListViewItem listViewItem6 = (ListViewItem)obj7;
									if (listViewItem6.SubItems[9].Text == "unchecked" && (int)double.Parse(listViewItem5.SubItems[3].Text) + (int)double.Parse(listViewItem5.SubItems[6].Text) > (int)double.Parse(listViewItem6.SubItems[3].Text) + (int)double.Parse(listViewItem6.SubItems[6].Text) && listViewItem6.Index < this.listViewBoxes.Items.Count + 1)
									{
										index3 = listViewItem6.Index + 1;
										flag3 = true;
									}
								}
								listViewItem5.SubItems[9].Text = "checked";
								num7++;
								if (flag3)
								{
									ListViewItem item3 = (ListViewItem)listViewItem5.Clone();
									this.listViewBoxes.Items.Insert(index3, item3);
									if (this.listViewBoxes.SelectedItems.Count != 0 && this.selected.Index == listViewItem5.Index)
									{
										this.selected = item3;
									}
									listViewItem5.Remove();
								}
							}
							else
							{
								num7++;
							}
						}
					}
					while (num7 < this.listViewBoxes.Items.Count);
				}
				else if (this.direction == "right")
				{
					int num8 = 0;
					do
					{
						foreach (object obj8 in this.listViewBoxes.Items)
						{
							ListViewItem listViewItem7 = (ListViewItem)obj8;
							if (listViewItem7.SubItems[listViewItem7.SubItems.Count - 1].Text == "unchecked")
							{
								int num9 = 0;
								if (listViewItem7.Tag.ToString() == "HEAD")
								{
									num9 = this.displayBox.Width / 2;
								}
								else if (listViewItem7.Tag.ToString() == "BODY")
								{
									num9 = this.displayBox.Width / 2;
								}
								else if (listViewItem7.Tag.ToString() == "ARM0")
								{
									num9 = 178;
								}
								else if (listViewItem7.Tag.ToString() == "ARM1")
								{
									num9 = 228;
								}
								else if (listViewItem7.Tag.ToString() == "LEG0")
								{
									num9 = 193;
								}
								else if (listViewItem7.Tag.ToString() == "LEG1")
								{
									num9 = 213;
								}
								bool flag4 = false;
								int index4 = listViewItem7.Index;
								foreach (object obj9 in this.listViewBoxes.Items)
								{
									ListViewItem listViewItem8 = (ListViewItem)obj9;
									if (listViewItem8.SubItems[9].Text == "unchecked")
									{
										int num10 = 0;
										if (listViewItem8.Tag.ToString() == "HEAD")
										{
											num10 = this.displayBox.Width / 2;
										}
										else if (listViewItem8.Tag.ToString() == "BODY")
										{
											num10 = this.displayBox.Width / 2;
										}
										else if (listViewItem8.Tag.ToString() == "ARM0")
										{
											num10 = 178;
										}
										else if (listViewItem8.Tag.ToString() == "ARM1")
										{
											num10 = 228;
										}
										else if (listViewItem8.Tag.ToString() == "LEG0")
										{
											num10 = 193;
										}
										else if (listViewItem8.Tag.ToString() == "LEG1")
										{
											num10 = 213;
										}
										if ((int)double.Parse(listViewItem7.SubItems[1].Text) + (int)double.Parse(listViewItem7.SubItems[4].Text) - num9 > (int)double.Parse(listViewItem8.SubItems[1].Text) + (int)double.Parse(listViewItem8.SubItems[4].Text) + num10 && listViewItem8.Index + 1 < this.listViewBoxes.Items.Count + 1)
										{
											index4 = listViewItem8.Index + 1;
											flag4 = true;
										}
									}
								}
								listViewItem7.SubItems[9].Text = "checked";
								num8++;
								if (flag4)
								{
									ListViewItem item4 = (ListViewItem)listViewItem7.Clone();
									this.listViewBoxes.Items.Insert(index4, item4);
									if (this.listViewBoxes.SelectedItems.Count != 0 && this.selected.Index == listViewItem7.Index)
									{
										this.selected = item4;
									}
									listViewItem7.Remove();
								}
							}
							else
							{
								num8++;
							}
						}
					}
					while (num8 < this.listViewBoxes.Items.Count);
				}
				foreach (object obj10 in this.listViewBoxes.Items)
				{
					((ListViewItem)obj10).SubItems[9].Text = "unchecked";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009F28 File Offset: 0x00008128
		private void generateModel_Load(object sender, EventArgs e)
		{
			this.render();
			this.listViewBoxes.Columns.Add("Part", 50);
			this.listViewBoxes.Columns.Add("Xc", 25);
			this.listViewBoxes.Columns.Add("Yc", 25);
			this.listViewBoxes.Columns.Add("Zc", 25);
			this.listViewBoxes.Columns.Add("Xf", 25);
			this.listViewBoxes.Columns.Add("Yf", 25);
			this.listViewBoxes.Columns.Add("Zf", 25);
			this.listViewBoxes.Columns.Add("Xo", 25);
			this.listViewBoxes.Columns.Add("Yo", 25);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000A014 File Offset: 0x00008214
		private void createToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "New Part";
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			this.listViewBoxes.Items.Add(listViewItem);
			this.render();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000A104 File Offset: 0x00008304
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listViewBoxes.SelectedItems.Count != 0)
			{
				this.selected = this.listViewBoxes.SelectedItems[0];
				try
				{
					try
					{
						this.comboParent.Text = this.selected.Tag.ToString();
					}
					catch (Exception)
					{
						this.comboParent.Text = "";
					}
					this.textXc.Text = this.selected.SubItems[1].Text;
					this.textYc.Text = this.selected.SubItems[2].Text;
					this.textZc.Text = this.selected.SubItems[3].Text;
					this.textXf.Text = this.selected.SubItems[4].Text;
					this.textYf.Text = this.selected.SubItems[5].Text;
					this.textZf.Text = this.selected.SubItems[6].Text;
					this.textTextureX.Text = this.selected.SubItems[7].Text;
					this.textTextureY.Text = this.selected.SubItems[8].Text;
				}
				catch (Exception)
				{
				}
				if (this.comboParent.Text == "")
				{
					this.comboParent.Enabled = true;
					this.buttonIMPORT.Enabled = false;
					this.buttonEXPORT.Enabled = false;
					this.textXc.Enabled = false;
					this.textYc.Enabled = false;
					this.textZc.Enabled = false;
					this.textXf.Enabled = false;
					this.textYf.Enabled = false;
					this.textZf.Enabled = false;
					this.textTextureX.Enabled = false;
					this.textTextureY.Enabled = false;
					this.buttonXcminus.Enabled = false;
					this.buttonYcminus.Enabled = false;
					this.buttonZcminus.Enabled = false;
					this.buttonXcplus.Enabled = false;
					this.buttonYcplus.Enabled = false;
					this.buttonZcplus.Enabled = false;
					this.buttonXfminus.Enabled = false;
					this.buttonYfminus.Enabled = false;
					this.buttonZfminus.Enabled = false;
					this.buttonXfplus.Enabled = false;
					this.buttonYfplus.Enabled = false;
					this.buttonZfplus.Enabled = false;
				}
				else
				{
					this.buttonIMPORT.Enabled = true;
					this.buttonEXPORT.Enabled = true;
					this.textXc.Enabled = true;
					this.textYc.Enabled = true;
					this.textZc.Enabled = true;
					this.textXf.Enabled = true;
					this.textYf.Enabled = true;
					this.textZf.Enabled = true;
					this.textTextureX.Enabled = true;
					this.textTextureY.Enabled = true;
					this.buttonXcminus.Enabled = true;
					this.buttonYcminus.Enabled = true;
					this.buttonZcminus.Enabled = true;
					this.buttonXcplus.Enabled = true;
					this.buttonYcplus.Enabled = true;
					this.buttonZcplus.Enabled = true;
					this.buttonXfminus.Enabled = true;
					this.buttonYfminus.Enabled = true;
					this.buttonZfminus.Enabled = true;
					this.buttonXfplus.Enabled = true;
					this.buttonYfplus.Enabled = true;
					this.buttonZfplus.Enabled = true;
				}
				this.render();
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000A4F0 File Offset: 0x000086F0
		private void comboParent_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.Tag = this.comboParent.Text;
				if (this.comboParent.Text != "")
				{
					this.buttonIMPORT.Enabled = true;
					this.buttonEXPORT.Enabled = true;
					this.textXc.Enabled = true;
					this.textYc.Enabled = true;
					this.textZc.Enabled = true;
					this.textXf.Enabled = true;
					this.textYf.Enabled = true;
					this.textZf.Enabled = true;
					this.textTextureX.Enabled = true;
					this.textTextureY.Enabled = true;
					this.buttonXcminus.Enabled = true;
					this.buttonYcminus.Enabled = true;
					this.buttonZcminus.Enabled = true;
					this.buttonXcplus.Enabled = true;
					this.buttonYcplus.Enabled = true;
					this.buttonZcplus.Enabled = true;
					this.buttonXfminus.Enabled = true;
					this.buttonYfminus.Enabled = true;
					this.buttonZfminus.Enabled = true;
					this.buttonXfplus.Enabled = true;
					this.buttonYfplus.Enabled = true;
					this.buttonZfplus.Enabled = true;
				}
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000A65C File Offset: 0x0000885C
		private void textBoxFailCheck(TextBox textBox)
		{
			try
			{
				textBox.Text = double.Parse(textBox.Text).ToString();
			}
			catch (Exception)
			{
				textBox.Text = "0";
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000A6A4 File Offset: 0x000088A4
		private void textXf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[4].Text = double.Parse(this.textXf.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000A6FC File Offset: 0x000088FC
		private void textYf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[5].Text = double.Parse(this.textYf.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000A754 File Offset: 0x00008954
		private void textZf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[6].Text = double.Parse(this.textZf.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000A7AC File Offset: 0x000089AC
		private void textXc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[1].Text = double.Parse(this.textXc.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000A804 File Offset: 0x00008A04
		private void textYc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[2].Text = double.Parse(this.textYc.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000A85C File Offset: 0x00008A5C
		private void textZc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.selected.SubItems[3].Text = double.Parse(this.textZc.Text).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		private void buttonXfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXf.Text = ((int)double.Parse(this.textXf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000A904 File Offset: 0x00008B04
		private void buttonXfminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXf.Text = ((int)double.Parse(this.textXf.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A954 File Offset: 0x00008B54
		private void buttonYfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYf.Text = ((int)double.Parse(this.textYf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		private void buttonYfminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYf.Text = ((int)double.Parse(this.textYf.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		private void buttonZfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZf.Text = ((int)double.Parse(this.textZf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000AA44 File Offset: 0x00008C44
		private void buttonZfminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZf.Text = ((int)double.Parse(this.textZf.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000AA94 File Offset: 0x00008C94
		private void buttonXcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXc.Text = ((int)double.Parse(this.textXc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		private void buttonXcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXc.Text = ((int)double.Parse(this.textXc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000AB34 File Offset: 0x00008D34
		private void buttonYcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYc.Text = ((int)double.Parse(this.textYc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000AB84 File Offset: 0x00008D84
		private void buttonYcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYc.Text = ((int)double.Parse(this.textYc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		private void buttonZcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZc.Text = ((int)double.Parse(this.textZc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000AC24 File Offset: 0x00008E24
		private void buttonZcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZc.Text = ((int)double.Parse(this.textZc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000AC74 File Offset: 0x00008E74
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.direction == "front")
			{
				this.direction = "left";
			}
			else if (this.direction == "left")
			{
				this.direction = "back";
			}
			else if (this.direction == "back")
			{
				this.direction = "right";
			}
			else if (this.direction == "right")
			{
				this.direction = "front";
			}
			this.render();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000AD04 File Offset: 0x00008F04
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.direction == "front")
			{
				this.direction = "right";
			}
			else if (this.direction == "right")
			{
				this.direction = "back";
			}
			else if (this.direction == "back")
			{
				this.direction = "left";
			}
			else if (this.direction == "left")
			{
				this.direction = "front";
			}
			this.render();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000AD94 File Offset: 0x00008F94
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double.Parse(this.textTextureX.Text);
			}
			catch (Exception)
			{
				try
				{
					this.textTextureX.Text = this.textTextureX.Text.Remove(this.textTextureX.Text.Count<char>() - 1, 1);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				this.selected.SubItems[7].Text = double.Parse(this.textTextureX.Text).ToString();
			}
			catch (Exception)
			{
				this.selected.SubItems[7].Text = 0.ToString();
			}
			this.render();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000AE6C File Offset: 0x0000906C
		private void textTextureY_TextChanged(object sender, EventArgs e)
		{
			try
			{
				double.Parse(this.textTextureY.Text);
			}
			catch (Exception)
			{
				try
				{
					this.textTextureY.Text = this.textTextureY.Text.Remove(this.textTextureY.Text.Count<char>() - 1, 1);
				}
				catch (Exception)
				{
				}
			}
			try
			{
				this.selected.SubItems[8].Text = double.Parse(this.textTextureY.Text).ToString();
			}
			catch (Exception)
			{
				this.selected.SubItems[8].Text = 0.ToString();
			}
			this.render();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000AF44 File Offset: 0x00009144
		private void buttonEXPORT_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(this.texturePreview.Image, 64, 64);
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PNG Image Files | *.png";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000AF94 File Offset: 0x00009194
		private void buttonIMPORT_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PNG Image Files | *.png";
			openFileDialog.Title = "Select Skin Texture";
			if (openFileDialog.ShowDialog() == DialogResult.OK && Image.FromFile(openFileDialog.FileName).Width == Image.FromFile(openFileDialog.FileName).Height)
			{
				this.checkTextureGenerate.Checked = false;
				Bitmap image = new Bitmap(64, 64);
				using (Graphics graphics = Graphics.FromImage(image))
				{
					graphics.DrawImage(Image.FromFile(openFileDialog.FileName), 0, 0, 64, 64);
					graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
				}
				this.texturePreview.Image = image;
			}
			this.render();
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000B054 File Offset: 0x00009254
		private void buttonDone_Click(object sender, EventArgs e)
		{
			this.boxes.Clear();
			Bitmap image = new Bitmap(this.displayBox.Width, this.displayBox.Height);
			foreach (object obj in this.listViewBoxes.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				this.boxes.Add(new object[]
				{
					"BOX",
					string.Concat(new string[]
					{
						listViewItem.Tag.ToString(),
						" ",
						listViewItem.SubItems[1].Text,
						" ",
						listViewItem.SubItems[2].Text,
						" ",
						listViewItem.SubItems[3].Text,
						" ",
						listViewItem.SubItems[4].Text,
						" ",
						listViewItem.SubItems[5].Text,
						" ",
						listViewItem.SubItems[6].Text,
						" ",
						listViewItem.SubItems[7].Text,
						" ",
						listViewItem.SubItems[8].Text
					})
				});
				using (Graphics graphics = Graphics.FromImage(image))
				{
					int num = 0;
					int num2 = 0;
					try
					{
						if (listViewItem.Tag.ToString() == "HEAD")
						{
							num = 80;
							num2 = 16 + (int)double.Parse(this.offsetHead.Text) * 5 + 40;
						}
						else if (listViewItem.Tag.ToString() == "BODY")
						{
							num = 80;
							num2 = 56 + (int)double.Parse(this.offsetBody.Text) * 5;
						}
						else if (listViewItem.Tag.ToString() == "ARM0")
						{
							num = 55;
							num2 = 56 + (int)double.Parse(this.offsetArms.Text) * 5 + 10;
						}
						else if (listViewItem.Tag.ToString() == "ARM1")
						{
							num = 105;
							num2 = 55 + (int)double.Parse(this.offsetArms.Text) * 5 + 10;
						}
						else if (listViewItem.Tag.ToString() == "LEG0")
						{
							num = 70;
							num2 = 116 + (int)double.Parse(this.offsetLegs.Text) * 5;
						}
						else if (listViewItem.Tag.ToString() == "LEG1")
						{
							num = 90;
							num2 = 116 + (int)double.Parse(this.offsetLegs.Text) * 5;
						}
						graphics.FillRectangle(new SolidBrush(listViewItem.ForeColor), num + (int)double.Parse(listViewItem.SubItems[1].Text) * 5, num2 + (int)double.Parse(listViewItem.SubItems[2].Text) * 5, (int)double.Parse(listViewItem.SubItems[4].Text) * 5, (int)double.Parse(listViewItem.SubItems[5].Text) * 5);
						listViewItem.Remove();
					}
					catch (Exception)
					{
					}
				}
			}
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "HEAD Y " + this.offsetHead.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "BODY Y " + this.offsetBody.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "ARM0 Y " + this.offsetArms.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "ARM1 Y " + this.offsetArms.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "LEG0 Y " + this.offsetLegs.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "LEG1 Y " + this.offsetLegs.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "HELMET Y " + this.offsetHelmet.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "TOOL0 Y " + this.offsetTool.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "TOOL1 Y " + this.offsetTool.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "PANTS0 Y " + this.offsetPants.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "PANTS1 Y " + this.offsetPants.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "BOOTS0 Y " + this.offsetBoots.Text
				}.Tag
			});
			this.boxes.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "BOOTS1 Y " + this.offsetBoots.Text
				}.Tag
			});
			Bitmap bitmap = new Bitmap(64, 64);
			using (Graphics graphics2 = Graphics.FromImage(bitmap))
			{
				graphics2.DrawImage(this.texturePreview.Image, 0, 0, 64, 64);
				graphics2.InterpolationMode = InterpolationMode.NearestNeighbor;
			}
			this.texturePreview.Image = bitmap;
			try
			{
				using (FileStream fileStream = new FileStream(Application.StartupPath + "\\temp.png", FileMode.Create, FileAccess.Write))
				{
					bitmap.Save(fileStream, ImageFormat.Png);
					fileStream.Close();
					fileStream.Dispose();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			this.skinPreview.Image = image;
			base.Close();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002E02 File Offset: 0x00001002
		private void texturePreview_BackgroundImageChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002E0A File Offset: 0x0000100A
		private void checkTextureGenerate_CheckedChanged(object sender, EventArgs e)
		{
			if (this.autoTexture)
			{
				this.autoTexture = false;
				return;
			}
			this.autoTexture = true;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000B868 File Offset: 0x00009A68
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			this.selected.ForeColor = colorDialog.Color;
			this.render();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetHead_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetBody_TextAlignChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000B89C File Offset: 0x00009A9C
		private void buttonTemplate_Click(object sender, EventArgs e)
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "HEAD";
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "-4"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "-8"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "-4"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "8"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "8"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "8"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "0"));
			listViewItem.Tag = "HEAD";
			listViewItem.ForeColor = Color.Yellow;
			this.listViewBoxes.Items.Add(listViewItem);
			this.listViewBoxes.Items.Add(new ListViewItem
			{
				Text = "BODY",
				SubItems = 
				{
					new ListViewItem.ListViewSubItem(listViewItem, "-4"),
					new ListViewItem.ListViewSubItem(listViewItem, "0"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "8"),
					new ListViewItem.ListViewSubItem(listViewItem, "12"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "16"),
					new ListViewItem.ListViewSubItem(listViewItem, "16")
				},
				Tag = "BODY",
				ForeColor = Color.Violet
			});
			this.listViewBoxes.Items.Add(new ListViewItem
			{
				Text = "ARM0",
				SubItems = 
				{
					new ListViewItem.ListViewSubItem(listViewItem, "-3"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "12"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "40"),
					new ListViewItem.ListViewSubItem(listViewItem, "16")
				},
				Tag = "ARM0",
				ForeColor = Color.SkyBlue
			});
			this.listViewBoxes.Items.Add(new ListViewItem
			{
				Text = "ARM1",
				SubItems = 
				{
					new ListViewItem.ListViewSubItem(listViewItem, "-1"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "12"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "40"),
					new ListViewItem.ListViewSubItem(listViewItem, "16")
				},
				Tag = "ARM1",
				ForeColor = Color.SkyBlue
			});
			this.listViewBoxes.Items.Add(new ListViewItem
			{
				Text = "LEG0",
				SubItems = 
				{
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "0"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "12"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "0"),
					new ListViewItem.ListViewSubItem(listViewItem, "16")
				},
				Tag = "LEG0",
				ForeColor = Color.SpringGreen
			});
			this.listViewBoxes.Items.Add(new ListViewItem
			{
				Text = "LEG1",
				SubItems = 
				{
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "0"),
					new ListViewItem.ListViewSubItem(listViewItem, "-2"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "12"),
					new ListViewItem.ListViewSubItem(listViewItem, "4"),
					new ListViewItem.ListViewSubItem(listViewItem, "0"),
					new ListViewItem.ListViewSubItem(listViewItem, "16")
				},
				Tag = "LEG1",
				ForeColor = Color.SpringGreen
			});
			this.comboParent.Enabled = true;
			this.render();
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000BE58 File Offset: 0x0000A058
		private void buttonExportModel_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Custom Skin Model File | *.CSM";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string text = "";
			foreach (object obj in this.listViewBoxes.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				string text2 = "";
				foreach (object obj2 in listViewItem.SubItems)
				{
					ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj2;
					if (listViewSubItem.Text != "unchecked")
					{
						text2 = text2 + listViewSubItem.Text + Environment.NewLine;
					}
				}
				text = string.Concat(new object[]
				{
					text,
					listViewItem.Text,
					Environment.NewLine,
					listViewItem.Tag,
					Environment.NewLine,
					text2
				});
			}
			File.WriteAllText(saveFileDialog.FileName, text);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000BF94 File Offset: 0x0000A194
		private void buttonImportModel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Custom Skin Model File | *.CSM";
			openFileDialog.Title = "Select Custom Skin Model File";
			if (MessageBox.Show("Import custom model project file? Your current work will be lost!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes && openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.listViewBoxes.Items.Clear();
				string text = File.ReadAllText(openFileDialog.FileName);
				int num = 0;
				foreach (string text2 in text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
				{
					num++;
				}
				int num2 = num / 11;
				ListView listView = new ListView();
				int num3 = 0;
				do
				{
					listView.Items.Add("BOX");
					num3++;
				}
				while (num3 < num2);
				foreach (ListViewItem listViewItem in listView.Items)
				{
					ListViewItem listViewItem2 = new ListViewItem();
					int num4 = 0;
					do
					{
						foreach (string text3 in text.Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
						{
							num4++;
							if (num4 == 1 + 11 * listViewItem.Index)
							{
								listViewItem2.Text = text3;
							}
							else if (num4 == 2 + 11 * listViewItem.Index)
							{
								listViewItem2.Tag = text3;
							}
							else if (num4 == 4 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 5 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 6 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 7 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 8 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 9 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 10 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
							}
							else if (num4 == 11 + 11 * listViewItem.Index)
							{
								listViewItem2.SubItems.Add(text3);
								this.listViewBoxes.Items.Add(listViewItem2);
							}
						}
					}
					while (num4 < num);
				}
			}
			this.render();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002E23 File Offset: 0x00001023
		private void button3_Click(object sender, EventArgs e)
		{
			this.setZ();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002E02 File Offset: 0x00001002
		private void checkGuide_CheckedChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000C274 File Offset: 0x0000A474
		private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = this.selected.Text;
				listViewItem.Tag = this.selected.Tag;
				int num = 0;
				foreach (object obj in this.selected.SubItems)
				{
					ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj;
					if (num > 0)
					{
						listViewItem.SubItems.Add(listViewSubItem.Text);
					}
					num++;
				}
				this.listViewBoxes.Items.Add(listViewItem);
			}
			catch (Exception)
			{
				MessageBox.Show("Please Select a Part");
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000C340 File Offset: 0x0000A540
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.selected != null)
				{
					this.selected.Remove();
					this.render();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000C380 File Offset: 0x0000A580
		private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ColorDialog colorDialog = new ColorDialog();
				colorDialog.ShowDialog();
				this.selected.ForeColor = colorDialog.Color;
				this.render();
			}
			catch (Exception)
			{
				MessageBox.Show("Please Select a Part");
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetTool_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetHelmet_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetPants_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetLeggings_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002E02 File Offset: 0x00001002
		private void offsetBoots_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002E02 File Offset: 0x00001002
		private void checkBoxArmor_Click(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		private void listView1_Click(object sender, EventArgs e)
		{
			try
			{
				this.selected = this.listViewBoxes.SelectedItems[0];
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void generateModel_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002E2B File Offset: 0x0000102B
		private void delStuffUsingDelKey(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 46)
			{
				this.selected.Remove();
				this.render();
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void generateModel_ResizeBegin(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void generateModel_ResizeEnd(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000C414 File Offset: 0x0000A614
		public void ResizeWidth(int newWidth, int newHeight)
		{
			base.Width = (int)((double)newHeight * 1.1186666666666667);
			base.Height = newHeight;
			int num = newHeight - 170;
			this.displayBox.Width = (int)((double)num * 0.9137931034482759);
			this.displayBox.Height = num;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002E48 File Offset: 0x00001048
		private void generateModel_SizeChanged(object sender, EventArgs e)
		{
			this.ResizeWidth(base.Width, base.Height);
			this.render();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listViewBGs_ItemActivate(object sender, EventArgs e)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listViewBGs_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000C468 File Offset: 0x0000A668
		private void listViewBGs_Click(object sender, EventArgs e)
		{
			try
			{
				this.backgroundColor = this.listViewBGs.SelectedItems[0].BackColor;
				this.render();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002E62 File Offset: 0x00001062
		private void textXc_Leave(object sender, EventArgs e)
		{
			this.textBoxFailCheck((TextBox)sender);
		}

		// Token: 0x04000285 RID: 645
		private PictureBox skinPreview;

		// Token: 0x04000286 RID: 646
		private Bitmap bg;

		// Token: 0x04000287 RID: 647
		private string direction;

		// Token: 0x04000288 RID: 648
		private List<object[]> boxes;

		// Token: 0x04000289 RID: 649
		private ListView storeData = new ListView();

		// Token: 0x0400028A RID: 650
		private bool autoTexture = true;

		// Token: 0x0400028B RID: 651
		private int textureW;

		// Token: 0x0400028C RID: 652
		private int textureH;

		// Token: 0x0400028D RID: 653
		private Color backgroundColor = Color.Black;

		// Token: 0x0400028E RID: 654
		private ListViewItem selected;
	}
}
