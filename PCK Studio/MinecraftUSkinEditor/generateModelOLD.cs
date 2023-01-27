using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000085 RID: 133
	public partial class generateModelOLD : MetroForm
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00039AA0 File Offset: 0x00037CA0
		public generateModelOLD(PCK.MineFile mfIn, PictureBox preview)
		{
			this.InitializeComponent();
			this.mf = mfIn;
			this.skinPreview = preview;
			this.direction = "front";
			this.buttonIMPORT.Enabled = false;
			this.buttonEXPORT.Enabled = false;
			this.textBoxPartName.Enabled = false;
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
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void listView1_MouseDown(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00039C04 File Offset: 0x00037E04
		private void render()
		{
			if (this.listView1.Items.Count == 0)
			{
				this.buttonTemplate.Enabled = true;
			}
			else
			{
				this.buttonTemplate.Enabled = false;
			}
			this.setZ();
			this.labelView.Text = "View: " + this.direction;
			Bitmap bitmap = new Bitmap(this.displayBox.Width, this.displayBox.Height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				if (this.direction == "front")
				{
					graphics.DrawImage(this.bg, Point.Empty);
					using (IEnumerator enumerator = this.listView1.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							ListViewItem listViewItem = (ListViewItem)obj;
							int num = 0;
							int num2 = 0;
							try
							{
								if (listViewItem.Tag.ToString() == "HEAD")
								{
									num = 203;
									num2 = 115 + int.Parse(this.offsetHead.Text) * 5 + 40;
								}
								else if (listViewItem.Tag.ToString() == "BODY")
								{
									num = 203;
									num2 = 155 + int.Parse(this.offsetBody.Text) * 5;
								}
								else if (listViewItem.Tag.ToString() == "ARM0")
								{
									num = 178;
									num2 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
								}
								else if (listViewItem.Tag.ToString() == "ARM1")
								{
									num = 228;
									num2 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
								}
								else if (listViewItem.Tag.ToString() == "LEG0")
								{
									num = 193;
									num2 = 215 + int.Parse(this.offsetLegs.Text) * 5;
								}
								else if (listViewItem.Tag.ToString() == "LEG1")
								{
									num = 213;
									num2 = 215 + int.Parse(this.offsetLegs.Text) * 5;
								}
								graphics.FillRectangle(new SolidBrush(listViewItem.ForeColor), num + int.Parse(listViewItem.SubItems[1].Text) * 5, num2 + int.Parse(listViewItem.SubItems[2].Text) * 5, int.Parse(listViewItem.SubItems[4].Text) * 5, int.Parse(listViewItem.SubItems[5].Text) * 5);
								if (listViewItem.Index == this.listView1.SelectedItems[0].Index)
								{
									graphics.DrawRectangle(Pens.Yellow, num + int.Parse(this.listView1.SelectedItems[0].SubItems[1].Text) * 5 - 1, num2 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5 - 1, int.Parse(this.listView1.SelectedItems[0].SubItems[4].Text) * 5 + 2, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5 + 2);
									graphics.DrawRectangle(Pens.Black, num + int.Parse(this.listView1.SelectedItems[0].SubItems[1].Text) * 5, num2 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[4].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5);
								}
								if (!this.autoTexture)
								{
									RectangleF destRect = new RectangleF((float)(num + int.Parse(listViewItem.SubItems[1].Text) * 5), (float)(num2 + int.Parse(listViewItem.SubItems[2].Text) * 5), (float)(int.Parse(listViewItem.SubItems[4].Text) * 5), (float)(int.Parse(listViewItem.SubItems[5].Text) * 5));
									RectangleF srcRect = new RectangleF((float)(int.Parse(listViewItem.SubItems[7].Text) + int.Parse(listViewItem.SubItems[6].Text)), (float)(int.Parse(listViewItem.SubItems[8].Text) + int.Parse(listViewItem.SubItems[6].Text)), (float)int.Parse(listViewItem.SubItems[4].Text), (float)int.Parse(listViewItem.SubItems[5].Text));
									graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
									graphics.DrawImage(this.texturePreview.Image, destRect, srcRect, GraphicsUnit.Pixel);
								}
								if (this.checkGuide.Checked)
								{
									graphics.DrawLine(Pens.Red, 203, 0, 203, 371);
									graphics.DrawLine(Pens.Blue, 228, 0, 228, 371);
									graphics.DrawLine(Pens.Blue, 178, 0, 178, 371);
									graphics.DrawLine(Pens.Purple, 193, 0, 193, 371);
									graphics.DrawLine(Pens.Purple, 213, 0, 213, 371);
									graphics.DrawLine(Pens.Red, 0, 155 + int.Parse(this.offsetHead.Text) * 5, 406, 155 + int.Parse(this.offsetHead.Text) * 5);
									graphics.DrawLine(Pens.Green, 0, 155 + int.Parse(this.offsetBody.Text) * 5, 406, 155 + int.Parse(this.offsetBody.Text) * 5);
									graphics.DrawLine(Pens.Blue, 0, 155 + int.Parse(this.offsetArms.Text) * 5, 406, 155 + int.Parse(this.offsetArms.Text) * 5);
									graphics.DrawLine(Pens.Purple, 0, 215 + int.Parse(this.offsetLegs.Text) * 5, 406, 215 + int.Parse(this.offsetLegs.Text) * 5);
								}
							}
							catch (Exception)
							{
							}
						}
						goto IL_1AB8;
					}
				}
				if (this.direction == "left")
				{
					graphics.DrawImage(this.bg, Point.Empty);
					foreach (object obj2 in this.listView1.Items)
					{
						ListViewItem listViewItem2 = (ListViewItem)obj2;
						int num3 = 0;
						int num4 = 0;
						try
						{
							if (listViewItem2.Tag.ToString() == "HEAD")
							{
								num3 = 203;
								num4 = 115 + int.Parse(this.offsetHead.Text) * 5 + 40;
							}
							else if (listViewItem2.Tag.ToString() == "BODY")
							{
								num3 = 203;
								num4 = 155 + int.Parse(this.offsetBody.Text) * 5;
							}
							else if (listViewItem2.Tag.ToString() == "ARM0")
							{
								num3 = 203;
								num4 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem2.Tag.ToString() == "ARM1")
							{
								num3 = 203;
								num4 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem2.Tag.ToString() == "LEG0")
							{
								num3 = 203;
								num4 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							else if (listViewItem2.Tag.ToString() == "LEG1")
							{
								num3 = 203;
								num4 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							graphics.FillRectangle(new SolidBrush(listViewItem2.ForeColor), num3 + int.Parse(listViewItem2.SubItems[3].Text) * 5, num4 + int.Parse(listViewItem2.SubItems[2].Text) * 5, int.Parse(listViewItem2.SubItems[6].Text) * 5, int.Parse(listViewItem2.SubItems[5].Text) * 5);
							if (listViewItem2.Index == this.listView1.SelectedItems[0].Index)
							{
								graphics.DrawRectangle(Pens.Yellow, num3 + int.Parse(this.listView1.SelectedItems[0].SubItems[3].Text) * 5 - 1, num4 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5 - 1, int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text) * 5 + 2, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5 + 2);
								graphics.DrawRectangle(Pens.Black, num3 + int.Parse(this.listView1.SelectedItems[0].SubItems[3].Text) * 5, num4 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5);
							}
							if (!this.autoTexture)
							{
								RectangleF destRect2 = new RectangleF((float)(num3 + int.Parse(listViewItem2.SubItems[3].Text) * 5), (float)(num4 + int.Parse(listViewItem2.SubItems[2].Text) * 5), (float)(int.Parse(listViewItem2.SubItems[6].Text) * 5), (float)(int.Parse(listViewItem2.SubItems[5].Text) * 5));
								RectangleF srcRect2 = new RectangleF((float)int.Parse(listViewItem2.SubItems[7].Text), (float)(int.Parse(listViewItem2.SubItems[8].Text) + int.Parse(listViewItem2.SubItems[6].Text)), (float)int.Parse(listViewItem2.SubItems[6].Text), (float)int.Parse(listViewItem2.SubItems[5].Text));
								graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
								graphics.DrawImage(this.texturePreview.Image, destRect2, srcRect2, GraphicsUnit.Pixel);
							}
							if (this.checkGuide.Checked)
							{
								graphics.DrawLine(Pens.Red, 203, 0, 203, 371);
								graphics.DrawLine(Pens.Red, 0, 155 + int.Parse(this.offsetHead.Text) * 5, 406, 155 + int.Parse(this.offsetHead.Text) * 5);
								graphics.DrawLine(Pens.Green, 0, 155 + int.Parse(this.offsetBody.Text) * 5, 406, 155 + int.Parse(this.offsetBody.Text) * 5);
								graphics.DrawLine(Pens.Blue, 0, 155 + int.Parse(this.offsetArms.Text) * 5, 406, 155 + int.Parse(this.offsetArms.Text) * 5);
								graphics.DrawLine(Pens.Purple, 0, 215 + int.Parse(this.offsetLegs.Text) * 5, 406, 215 + int.Parse(this.offsetLegs.Text) * 5);
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
					graphics.DrawImage(this.bg, Point.Empty);
					foreach (object obj3 in this.listView1.Items)
					{
						ListViewItem listViewItem3 = (ListViewItem)obj3;
						int num5 = 0;
						int num6 = 0;
						try
						{
							if (listViewItem3.Tag.ToString() == "HEAD")
							{
								num5 = 203;
								num6 = 115 + int.Parse(this.offsetHead.Text) * 5 + 40;
							}
							else if (listViewItem3.Tag.ToString() == "BODY")
							{
								num5 = 203;
								num6 = 155 + int.Parse(this.offsetBody.Text) * 5;
							}
							else if (listViewItem3.Tag.ToString() == "ARM0")
							{
								num5 = 178;
								num6 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem3.Tag.ToString() == "ARM1")
							{
								num5 = 228;
								num6 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem3.Tag.ToString() == "LEG0")
							{
								num5 = 193;
								num6 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							else if (listViewItem3.Tag.ToString() == "LEG1")
							{
								num5 = 213;
								num6 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							graphics.FillRectangle(new SolidBrush(listViewItem3.ForeColor), num5 + int.Parse(listViewItem3.SubItems[1].Text) * 5, num6 + int.Parse(listViewItem3.SubItems[2].Text) * 5, int.Parse(listViewItem3.SubItems[4].Text) * 5, int.Parse(listViewItem3.SubItems[5].Text) * 5);
							if (listViewItem3.Index == this.listView1.SelectedItems[0].Index)
							{
								graphics.DrawRectangle(Pens.Yellow, num5 + int.Parse(this.listView1.SelectedItems[0].SubItems[1].Text) * 5 - 1, num6 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5 - 1, int.Parse(this.listView1.SelectedItems[0].SubItems[4].Text) * 5 + 2, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5 + 2);
								graphics.DrawRectangle(Pens.Black, num5 + int.Parse(this.listView1.SelectedItems[0].SubItems[1].Text) * 5, num6 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[4].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5);
							}
							if (!this.autoTexture)
							{
								RectangleF destRect3 = new RectangleF((float)(num5 + int.Parse(listViewItem3.SubItems[1].Text) * 5), (float)(num6 + int.Parse(listViewItem3.SubItems[2].Text) * 5), (float)(int.Parse(listViewItem3.SubItems[4].Text) * 5), (float)(int.Parse(listViewItem3.SubItems[5].Text) * 5));
								RectangleF srcRect3 = new RectangleF((float)(int.Parse(listViewItem3.SubItems[7].Text) + int.Parse(listViewItem3.SubItems[6].Text) + int.Parse(listViewItem3.SubItems[4].Text) + int.Parse(listViewItem3.SubItems[6].Text)), (float)(int.Parse(listViewItem3.SubItems[8].Text) + int.Parse(listViewItem3.SubItems[6].Text)), (float)int.Parse(listViewItem3.SubItems[4].Text), (float)int.Parse(listViewItem3.SubItems[5].Text));
								graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
								graphics.DrawImage(this.texturePreview.Image, destRect3, srcRect3, GraphicsUnit.Pixel);
							}
							if (this.checkGuide.Checked)
							{
								graphics.DrawLine(Pens.Red, 203, 0, 203, 371);
								graphics.DrawLine(Pens.Blue, 228, 0, 228, 371);
								graphics.DrawLine(Pens.Blue, 178, 0, 178, 371);
								graphics.DrawLine(Pens.Purple, 193, 0, 193, 371);
								graphics.DrawLine(Pens.Purple, 213, 0, 213, 371);
								graphics.DrawLine(Pens.Red, 0, 155 + int.Parse(this.offsetHead.Text) * 5, 406, 155 + int.Parse(this.offsetHead.Text) * 5);
								graphics.DrawLine(Pens.Green, 0, 155 + int.Parse(this.offsetBody.Text) * 5, 406, 155 + int.Parse(this.offsetBody.Text) * 5);
								graphics.DrawLine(Pens.Blue, 0, 155 + int.Parse(this.offsetArms.Text) * 5, 406, 155 + int.Parse(this.offsetArms.Text) * 5);
								graphics.DrawLine(Pens.Purple, 0, 215 + int.Parse(this.offsetLegs.Text) * 5, 406, 215 + int.Parse(this.offsetLegs.Text) * 5);
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
					graphics.DrawImage(this.bg, Point.Empty);
					foreach (object obj4 in this.listView1.Items)
					{
						ListViewItem listViewItem4 = (ListViewItem)obj4;
						int num7 = 0;
						int num8 = 0;
						try
						{
							if (listViewItem4.Tag.ToString() == "HEAD")
							{
								num7 = 203;
								num8 = 115 + int.Parse(this.offsetHead.Text) * 5 + 40;
							}
							else if (listViewItem4.Tag.ToString() == "BODY")
							{
								num7 = 203;
								num8 = 155 + int.Parse(this.offsetBody.Text) * 5;
							}
							else if (listViewItem4.Tag.ToString() == "ARM0")
							{
								num7 = 203;
								num8 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem4.Tag.ToString() == "ARM1")
							{
								num7 = 203;
								num8 = 155 + int.Parse(this.offsetArms.Text) * 5 + 10;
							}
							else if (listViewItem4.Tag.ToString() == "LEG0")
							{
								num7 = 203;
								num8 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							else if (listViewItem4.Tag.ToString() == "LEG1")
							{
								num7 = 203;
								num8 = 215 + int.Parse(this.offsetLegs.Text) * 5;
							}
							graphics.FillRectangle(new SolidBrush(listViewItem4.ForeColor), num7 + int.Parse(listViewItem4.SubItems[3].Text) * 5, num8 + int.Parse(listViewItem4.SubItems[2].Text) * 5, int.Parse(listViewItem4.SubItems[6].Text) * 5, int.Parse(listViewItem4.SubItems[5].Text) * 5);
							if (listViewItem4.Index == this.listView1.SelectedItems[0].Index)
							{
								graphics.DrawRectangle(Pens.Yellow, num7 + int.Parse(this.listView1.SelectedItems[0].SubItems[3].Text) * 5 - 1, num8 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5 - 1, int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text) * 5 + 2, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5 + 2);
								graphics.DrawRectangle(Pens.Black, num7 + int.Parse(this.listView1.SelectedItems[0].SubItems[3].Text) * 5, num8 + int.Parse(this.listView1.SelectedItems[0].SubItems[2].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[6].Text) * 5, int.Parse(this.listView1.SelectedItems[0].SubItems[5].Text) * 5);
							}
							if (!this.autoTexture)
							{
								RectangleF destRect4 = new RectangleF((float)(num7 + int.Parse(listViewItem4.SubItems[3].Text) * 5), (float)(num8 + int.Parse(listViewItem4.SubItems[2].Text) * 5), (float)(int.Parse(listViewItem4.SubItems[6].Text) * 5), (float)(int.Parse(listViewItem4.SubItems[5].Text) * 5));
								RectangleF srcRect4 = new RectangleF((float)(int.Parse(listViewItem4.SubItems[7].Text) + int.Parse(listViewItem4.SubItems[6].Text) + int.Parse(listViewItem4.SubItems[4].Text)), (float)(int.Parse(listViewItem4.SubItems[8].Text) + int.Parse(listViewItem4.SubItems[6].Text)), (float)int.Parse(listViewItem4.SubItems[6].Text), (float)int.Parse(listViewItem4.SubItems[5].Text));
								graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
								graphics.DrawImage(this.texturePreview.Image, destRect4, srcRect4, GraphicsUnit.Pixel);
							}
							if (this.checkGuide.Checked)
							{
								graphics.DrawLine(Pens.Red, 203, 0, 203, 371);
								graphics.DrawLine(Pens.Red, 0, 155 + int.Parse(this.offsetHead.Text) * 5, 406, 155 + int.Parse(this.offsetHead.Text) * 5);
								graphics.DrawLine(Pens.Green, 0, 155 + int.Parse(this.offsetBody.Text) * 5, 406, 155 + int.Parse(this.offsetBody.Text) * 5);
								graphics.DrawLine(Pens.Blue, 0, 155 + int.Parse(this.offsetArms.Text) * 5, 406, 155 + int.Parse(this.offsetArms.Text) * 5);
								graphics.DrawLine(Pens.Purple, 0, 215 + int.Parse(this.offsetLegs.Text) * 5, 406, 215 + int.Parse(this.offsetLegs.Text) * 5);
							}
						}
						catch (Exception)
						{
						}
					}
				}
				IL_1AB8:
				graphics.Dispose();
			}
			this.displayBox.Image = bitmap;
			if (this.autoTexture)
			{
				Bitmap image = new Bitmap(this.texturePreview.Width, this.texturePreview.Height);
				using (Graphics graphics2 = Graphics.FromImage(image))
				{
					foreach (object obj5 in this.listView1.Items)
					{
						ListViewItem listViewItem5 = (ListViewItem)obj5;
						try
						{
							int.Parse(listViewItem5.SubItems[1].Text);
							int.Parse(listViewItem5.SubItems[2].Text);
							int.Parse(listViewItem5.SubItems[3].Text);
							int num9 = int.Parse(listViewItem5.SubItems[4].Text) * 2;
							int height = int.Parse(listViewItem5.SubItems[5].Text) * 2;
							int num10 = int.Parse(listViewItem5.SubItems[6].Text) * 2;
							int num11 = int.Parse(listViewItem5.SubItems[7].Text) * 2;
							int num12 = int.Parse(listViewItem5.SubItems[8].Text) * 2;
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10, num12, num9, num10);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10 + num9, num12, num9, num10);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11, num12 + num10, num10, height);
							graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10, num12 + num10, num9, height);
							if (listViewItem5.Tag.ToString() != "HEAD")
							{
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10 + num9, num12 + num10, num9, height);
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10 + num9 + num9, num12 + num10, num10, height);
							}
							else
							{
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10 + num9 + num9, num12 + num10, num10, height);
								graphics2.FillRectangle(new SolidBrush(listViewItem5.ForeColor), num11 + num10 + num9, num12 + num10, num9, height);
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
			foreach (object obj6 in this.listView1.Items)
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

		// Token: 0x0600025C RID: 604 RVA: 0x0003BB3C File Offset: 0x00039D3C
		private void setZ()
		{
			try
			{
				foreach (object obj in this.listView1.Items)
				{
					((ListViewItem)obj).SubItems.Add("unchecked");
				}
				if (this.direction == "front")
				{
					using (IEnumerator enumerator = this.listView1.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							ListViewItem listViewItem = (ListViewItem)obj2;
							if (listViewItem.SubItems[9].Text == "unchecked")
							{
								bool flag = false;
								int index = listViewItem.Index;
								foreach (object obj3 in this.listView1.Items)
								{
									ListViewItem listViewItem2 = (ListViewItem)obj3;
									if (listViewItem2.SubItems[9].Text == "unchecked" && int.Parse(listViewItem.SubItems[3].Text) + int.Parse(listViewItem.SubItems[6].Text) < int.Parse(listViewItem2.SubItems[3].Text) + int.Parse(listViewItem2.SubItems[6].Text) && listViewItem2.Index + 1 < this.listView1.Items.Count + 1)
									{
										index = listViewItem2.Index + 1;
										flag = true;
									}
								}
								listViewItem.SubItems[9].Text = "checked";
								if (flag)
								{
									ListViewItem item = (ListViewItem)listViewItem.Clone();
									this.listView1.Items.Insert(index, item);
									listViewItem.Remove();
								}
							}
						}
						goto IL_A77;
					}
				}
				if (this.direction == "left")
				{
					using (IEnumerator enumerator = this.listView1.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj4 = enumerator.Current;
							ListViewItem listViewItem3 = (ListViewItem)obj4;
							if (listViewItem3.SubItems[9].Text == "unchecked")
							{
								int num = 0;
								if (listViewItem3.Tag.ToString() == "HEAD")
								{
									num = 203;
								}
								else if (listViewItem3.Tag.ToString() == "BODY")
								{
									num = 203;
								}
								else if (listViewItem3.Tag.ToString() == "ARM0")
								{
									num = 178;
								}
								else if (listViewItem3.Tag.ToString() == "ARM1")
								{
									num = 228;
								}
								else if (listViewItem3.Tag.ToString() == "LEG0")
								{
									num = 193;
								}
								else if (listViewItem3.Tag.ToString() == "LEG1")
								{
									num = 213;
								}
								bool flag2 = false;
								int index2 = listViewItem3.Index;
								foreach (object obj5 in this.listView1.Items)
								{
									ListViewItem listViewItem4 = (ListViewItem)obj5;
									if (listViewItem4.SubItems[9].Text == "unchecked")
									{
										int num2 = 0;
										if (listViewItem4.Tag.ToString() == "HEAD")
										{
											num2 = 203;
										}
										else if (listViewItem4.Tag.ToString() == "BODY")
										{
											num2 = 203;
										}
										else if (listViewItem4.Tag.ToString() == "ARM0")
										{
											num2 = 178;
										}
										else if (listViewItem4.Tag.ToString() == "ARM1")
										{
											num2 = 228;
										}
										else if (listViewItem4.Tag.ToString() == "LEG0")
										{
											num2 = 193;
										}
										else if (listViewItem4.Tag.ToString() == "LEG1")
										{
											num2 = 213;
										}
										if (int.Parse(listViewItem3.SubItems[1].Text) + int.Parse(listViewItem3.SubItems[4].Text) + num < int.Parse(listViewItem4.SubItems[1].Text) + int.Parse(listViewItem4.SubItems[4].Text) + num2 && listViewItem4.Index + 1 < this.listView1.Items.Count + 1)
										{
											index2 = listViewItem4.Index + 1;
											flag2 = true;
										}
									}
								}
								listViewItem3.SubItems[9].Text = "checked";
								if (flag2)
								{
									ListViewItem item2 = (ListViewItem)listViewItem3.Clone();
									this.listView1.Items.Insert(index2, item2);
									listViewItem3.Remove();
								}
							}
						}
						goto IL_A77;
					}
				}
				if (this.direction == "back")
				{
					using (IEnumerator enumerator = this.listView1.Items.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj6 = enumerator.Current;
							ListViewItem listViewItem5 = (ListViewItem)obj6;
							if (listViewItem5.SubItems[9].Text == "unchecked")
							{
								bool flag3 = false;
								int index3 = listViewItem5.Index;
								foreach (object obj7 in this.listView1.Items)
								{
									ListViewItem listViewItem6 = (ListViewItem)obj7;
									if (listViewItem6.SubItems[9].Text == "unchecked" && int.Parse(listViewItem5.SubItems[3].Text) + int.Parse(listViewItem5.SubItems[6].Text) > int.Parse(listViewItem6.SubItems[3].Text) + int.Parse(listViewItem6.SubItems[6].Text) && listViewItem6.Index + 1 < this.listView1.Items.Count + 1)
									{
										index3 = listViewItem6.Index + 1;
										flag3 = true;
									}
								}
								listViewItem5.SubItems[9].Text = "checked";
								if (flag3)
								{
									ListViewItem item3 = (ListViewItem)listViewItem5.Clone();
									this.listView1.Items.Insert(index3, item3);
									listViewItem5.Remove();
								}
							}
						}
						goto IL_A77;
					}
				}
				if (this.direction == "right")
				{
					foreach (object obj8 in this.listView1.Items)
					{
						ListViewItem listViewItem7 = (ListViewItem)obj8;
						if (listViewItem7.SubItems[9].Text == "unchecked")
						{
							int num3 = 0;
							if (listViewItem7.Tag.ToString() == "HEAD")
							{
								num3 = 203;
							}
							else if (listViewItem7.Tag.ToString() == "BODY")
							{
								num3 = 203;
							}
							else if (listViewItem7.Tag.ToString() == "ARM0")
							{
								num3 = 178;
							}
							else if (listViewItem7.Tag.ToString() == "ARM1")
							{
								num3 = 228;
							}
							else if (listViewItem7.Tag.ToString() == "LEG0")
							{
								num3 = 193;
							}
							else if (listViewItem7.Tag.ToString() == "LEG1")
							{
								num3 = 213;
							}
							bool flag4 = false;
							int index4 = listViewItem7.Index;
							foreach (object obj9 in this.listView1.Items)
							{
								ListViewItem listViewItem8 = (ListViewItem)obj9;
								if (listViewItem8.SubItems[9].Text == "unchecked")
								{
									int num4 = 0;
									if (listViewItem8.Tag.ToString() == "HEAD")
									{
										num4 = 203;
									}
									else if (listViewItem8.Tag.ToString() == "BODY")
									{
										num4 = 203;
									}
									else if (listViewItem8.Tag.ToString() == "ARM0")
									{
										num4 = 178;
									}
									else if (listViewItem8.Tag.ToString() == "ARM1")
									{
										num4 = 228;
									}
									else if (listViewItem8.Tag.ToString() == "LEG0")
									{
										num4 = 193;
									}
									else if (listViewItem8.Tag.ToString() == "LEG1")
									{
										num4 = 213;
									}
									if (int.Parse(listViewItem7.SubItems[1].Text) + int.Parse(listViewItem7.SubItems[4].Text) + num3 > int.Parse(listViewItem8.SubItems[1].Text) + int.Parse(listViewItem8.SubItems[4].Text) + num4 && listViewItem8.Index + 1 < this.listView1.Items.Count + 1)
									{
										index4 = listViewItem8.Index + 1;
										flag4 = true;
									}
								}
							}
							listViewItem7.SubItems[9].Text = "checked";
							if (flag4)
							{
								ListViewItem item4 = (ListViewItem)listViewItem7.Clone();
								this.listView1.Items.Insert(index4, item4);
								listViewItem7.Remove();
							}
						}
					}
				}
				IL_A77:
				foreach (object obj10 in this.listView1.Items)
				{
					((ListViewItem)obj10).SubItems[9].Text = "unchecked";
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0003C720 File Offset: 0x0003A920
		private void generateModel_Load(object sender, EventArgs e)
		{
			this.render();
			this.listView1.Columns.Add("Part", 50);
			this.listView1.Columns.Add("Xc", 25);
			this.listView1.Columns.Add("Yc", 25);
			this.listView1.Columns.Add("Zc", 25);
			this.listView1.Columns.Add("Xf", 25);
			this.listView1.Columns.Add("Yf", 25);
			this.listView1.Columns.Add("Zf", 25);
			this.listView1.Columns.Add("Xo", 25);
			this.listView1.Columns.Add("Yo", 25);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0003C80C File Offset: 0x0003AA0C
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
			this.listView1.Items.Add(listViewItem);
			this.render();
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0003C8FC File Offset: 0x0003AAFC
		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.textBoxPartName.Text = this.listView1.SelectedItems[0].Text;
				try
				{
					this.comboParent.Text = this.listView1.SelectedItems[0].Tag.ToString();
				}
				catch (Exception)
				{
					this.comboParent.Text = "";
				}
				this.textXc.Text = this.listView1.SelectedItems[0].SubItems[1].Text;
				this.textYc.Text = this.listView1.SelectedItems[0].SubItems[2].Text;
				this.textZc.Text = this.listView1.SelectedItems[0].SubItems[3].Text;
				this.textXf.Text = this.listView1.SelectedItems[0].SubItems[4].Text;
				this.textYf.Text = this.listView1.SelectedItems[0].SubItems[5].Text;
				this.textZf.Text = this.listView1.SelectedItems[0].SubItems[6].Text;
				this.textTextureX.Text = this.listView1.SelectedItems[0].SubItems[7].Text;
				this.textTextureY.Text = this.listView1.SelectedItems[0].SubItems[8].Text;
			}
			catch (Exception)
			{
			}
			if (this.comboParent.Text == "")
			{
				this.comboParent.Enabled = true;
				this.buttonIMPORT.Enabled = false;
				this.buttonEXPORT.Enabled = false;
				this.textBoxPartName.Enabled = false;
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
				this.textBoxPartName.Enabled = true;
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

		// Token: 0x06000260 RID: 608 RVA: 0x0003CD58 File Offset: 0x0003AF58
		private void textBoxPartName_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].Text = this.textBoxPartName.Text;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0003CD9C File Offset: 0x0003AF9C
		private void comboParent_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].Tag = this.comboParent.Text;
				if (this.comboParent.Text != "")
				{
					this.buttonIMPORT.Enabled = true;
					this.buttonEXPORT.Enabled = true;
					this.textBoxPartName.Enabled = true;
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

		// Token: 0x06000262 RID: 610 RVA: 0x0003CF20 File Offset: 0x0003B120
		private void textXf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[4].Text = int.Parse(this.textXf.Text).ToString();
			}
			catch (Exception)
			{
				this.textXf.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0003CF94 File Offset: 0x0003B194
		private void textYf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[5].Text = int.Parse(this.textYf.Text).ToString();
			}
			catch (Exception)
			{
				this.textYf.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0003D008 File Offset: 0x0003B208
		private void textZf_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[6].Text = int.Parse(this.textZf.Text).ToString();
			}
			catch (Exception)
			{
				this.textZf.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0003D07C File Offset: 0x0003B27C
		private void textXc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[1].Text = int.Parse(this.textXc.Text).ToString();
			}
			catch (Exception)
			{
				this.textXc.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0003D0F0 File Offset: 0x0003B2F0
		private void textYc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[2].Text = int.Parse(this.textYc.Text).ToString();
			}
			catch (Exception)
			{
				this.textYc.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0003D164 File Offset: 0x0003B364
		private void textZc_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.listView1.SelectedItems[0].SubItems[3].Text = int.Parse(this.textZc.Text).ToString();
			}
			catch (Exception)
			{
				this.textZc.Text = "0";
			}
			this.render();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0003D1D8 File Offset: 0x0003B3D8
		private void buttonXfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXf.Text = (int.Parse(this.textXf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void buttonXfminus_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0003D228 File Offset: 0x0003B428
		private void buttonYfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYf.Text = (int.Parse(this.textYf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0003D278 File Offset: 0x0003B478
		private void buttonYfminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYf.Text = (int.Parse(this.textYf.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0003D2C8 File Offset: 0x0003B4C8
		private void buttonZfplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZf.Text = (int.Parse(this.textZf.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0003D318 File Offset: 0x0003B518
		private void buttonZfminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZf.Text = (int.Parse(this.textZf.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0003D368 File Offset: 0x0003B568
		private void buttonXcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXc.Text = (int.Parse(this.textXc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0003D3B8 File Offset: 0x0003B5B8
		private void buttonXcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textXc.Text = (int.Parse(this.textXc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0003D408 File Offset: 0x0003B608
		private void buttonYcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYc.Text = (int.Parse(this.textYc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0003D458 File Offset: 0x0003B658
		private void buttonYcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textYc.Text = (int.Parse(this.textYc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		private void buttonZcplus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZc.Text = (int.Parse(this.textZc.Text) + 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0003D4F8 File Offset: 0x0003B6F8
		private void buttonZcminus_Click(object sender, EventArgs e)
		{
			try
			{
				this.textZc.Text = (int.Parse(this.textZc.Text) - 1).ToString();
			}
			catch (Exception)
			{
			}
			this.render();
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0003D548 File Offset: 0x0003B748
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

		// Token: 0x06000275 RID: 629 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
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

		// Token: 0x06000276 RID: 630 RVA: 0x00003C8B File Offset: 0x00001E8B
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002DC9 File Offset: 0x00000FC9
		private void checkGuide_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0003D668 File Offset: 0x0003B868
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.listView1.SelectedItems[0] != null)
				{
					this.listView1.SelectedItems[0].Remove();
					this.render();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0003D6BC File Offset: 0x0003B8BC
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int.Parse(this.textTextureX.Text);
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
				this.listView1.SelectedItems[0].SubItems[7].Text = int.Parse(this.textTextureX.Text).ToString();
			}
			catch (Exception)
			{
				this.listView1.SelectedItems[0].SubItems[7].Text = 0.ToString();
			}
			this.render();
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0003D7AC File Offset: 0x0003B9AC
		private void textTextureY_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int.Parse(this.textTextureY.Text);
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
				this.listView1.SelectedItems[0].SubItems[8].Text = int.Parse(this.textTextureY.Text).ToString();
			}
			catch (Exception)
			{
				this.listView1.SelectedItems[0].SubItems[8].Text = 0.ToString();
			}
			this.render();
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0003D89C File Offset: 0x0003BA9C
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

		// Token: 0x0600027C RID: 636 RVA: 0x0003D8EC File Offset: 0x0003BAEC
		private void buttonIMPORT_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PNG Image Files | *.png";
			openFileDialog.Title = "Select Skin Texture";
			if (openFileDialog.ShowDialog() == DialogResult.OK && Image.FromFile(openFileDialog.FileName).Width == Image.FromFile(openFileDialog.FileName).Height)
			{
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

		// Token: 0x0600027D RID: 637 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		private void buttonDone_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Finish? You won't be able to come back and edit this skins model settings once created.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
			{
				return;
			}
			Bitmap image = new Bitmap(this.displayBox.Width, this.displayBox.Height);
			foreach (object obj in this.listView1.Items)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				this.mf.entries.Add(new object[]
				{
					"BOX",
					new ListViewItem
					{
						Tag = string.Concat(new string[]
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
					}.Tag
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
							num2 = 16 + int.Parse(this.offsetHead.Text) * 5 + 40;
						}
						else if (listViewItem.Tag.ToString() == "BODY")
						{
							num = 80;
							num2 = 56 + int.Parse(this.offsetBody.Text) * 5;
						}
						else if (listViewItem.Tag.ToString() == "ARM0")
						{
							num = 55;
							num2 = 56 + int.Parse(this.offsetArms.Text) * 5 + 10;
						}
						else if (listViewItem.Tag.ToString() == "ARM1")
						{
							num = 105;
							num2 = 55 + int.Parse(this.offsetArms.Text) * 5 + 10;
						}
						else if (listViewItem.Tag.ToString() == "LEG0")
						{
							num = 70;
							num2 = 116 + int.Parse(this.offsetLegs.Text) * 5;
						}
						else if (listViewItem.Tag.ToString() == "LEG1")
						{
							num = 90;
							num2 = 116 + int.Parse(this.offsetLegs.Text) * 5;
						}
						graphics.FillRectangle(new SolidBrush(listViewItem.ForeColor), num + int.Parse(listViewItem.SubItems[1].Text) * 5, num2 + int.Parse(listViewItem.SubItems[2].Text) * 5, int.Parse(listViewItem.SubItems[4].Text) * 5, int.Parse(listViewItem.SubItems[5].Text) * 5);
					}
					catch (Exception)
					{
					}
				}
			}
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "HEAD Y " + this.offsetHead.Text
				}.Tag
			});
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				new ListViewItem
				{
					Tag = "BODY Y " + this.offsetBody.Text
				}.Tag
			});
			ListViewItem listViewItem2 = new ListViewItem();
			ListViewItem listViewItem3 = new ListViewItem();
			listViewItem2.Tag = "ARM0 Y " + this.offsetArms.Text;
			listViewItem3.Tag = "ARM1 Y " + this.offsetArms.Text;
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				listViewItem2.Tag
			});
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				listViewItem3.Tag
			});
			ListViewItem listViewItem4 = new ListViewItem();
			ListViewItem listViewItem5 = new ListViewItem();
			listViewItem4.Tag = "LEG0 Y " + this.offsetLegs.Text;
			listViewItem5.Tag = "LEG1 Y " + this.offsetLegs.Text;
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				listViewItem4.Tag
			});
			this.mf.entries.Add(new object[]
			{
				"OFFSET",
				listViewItem5.Tag
			});
			Bitmap bitmap = new Bitmap(64, 64);
			using (Graphics graphics2 = Graphics.FromImage(bitmap))
			{
				graphics2.DrawImage(this.texturePreview.Image, 0, 0, 64, 64);
				graphics2.InterpolationMode = InterpolationMode.NearestNeighbor;
			}
			this.texturePreview.Image = bitmap;
			bitmap.Save(Application.StartupPath + "\\temp.png");
			this.skinPreview.Image = image;
			base.Close();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00003C8B File Offset: 0x00001E8B
		private void texturePreview_BackgroundImageChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003C93 File Offset: 0x00001E93
		private void checkTextureGenerate_CheckedChanged(object sender, EventArgs e)
		{
			if (this.autoTexture)
			{
				this.autoTexture = false;
				return;
			}
			this.autoTexture = true;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			ColorDialog colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			this.listView1.SelectedItems[0].ForeColor = colorDialog.Color;
			this.render();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003C8B File Offset: 0x00001E8B
		private void offsetHead_TextChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00003C8B File Offset: 0x00001E8B
		private void offsetBody_TextAlignChanged(object sender, EventArgs e)
		{
			this.render();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0003E01C File Offset: 0x0003C21C
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
			this.listView1.Items.Add(listViewItem);
			this.listView1.Items.Add(new ListViewItem
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
			this.listView1.Items.Add(new ListViewItem
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
			this.listView1.Items.Add(new ListViewItem
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
			this.listView1.Items.Add(new ListViewItem
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
			this.listView1.Items.Add(new ListViewItem
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

		// Token: 0x06000284 RID: 644 RVA: 0x0003E5D8 File Offset: 0x0003C7D8
		private void cloneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = this.listView1.SelectedItems[0].Text;
				listViewItem.Tag = this.listView1.SelectedItems[0].Tag;
				int num = 0;
				foreach (object obj in this.listView1.SelectedItems[0].SubItems)
				{
					ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj;
					if (num > 0)
					{
						listViewItem.SubItems.Add(listViewSubItem.Text);
					}
					num++;
				}
				this.listView1.Items.Add(listViewItem);
			}
			catch (Exception)
			{
				MessageBox.Show("Please Select a Part");
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0003E6C8 File Offset: 0x0003C8C8
		private void buttonExportModel_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Custom Skin Model File | *.CSM";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string text = "";
			foreach (object obj in this.listView1.Items)
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

		// Token: 0x06000286 RID: 646 RVA: 0x0003E804 File Offset: 0x0003CA04
		private void buttonImportModel_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Custom Skin Model File | *.CSM";
			openFileDialog.Title = "Select Custom Skin Model File";
			if (MessageBox.Show("Import custom model project file? Your current work will be lost!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes && openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.listView1.Items.Clear();
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
								this.listView1.Items.Add(listViewItem2);
							}
						}
					}
					while (num4 < num);
				}
			}
			this.render();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00003CAC File Offset: 0x00001EAC
		private void button3_Click(object sender, EventArgs e)
		{
			this.setZ();
		}

		// Token: 0x04000435 RID: 1077
		private ListView storeData = new ListView();

		// Token: 0x04000436 RID: 1078
		private bool autoTexture = true;

		// Token: 0x04000437 RID: 1079
		private Bitmap bg;

		// Token: 0x04000438 RID: 1080
		private string direction;

		// Token: 0x04000439 RID: 1081
		private PCK.MineFile mf;

		// Token: 0x0400043A RID: 1082
		private PictureBox skinPreview;
	}
}
