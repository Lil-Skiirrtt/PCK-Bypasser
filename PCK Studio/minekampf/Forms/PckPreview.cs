using System;
using System.Drawing;
using System.Windows.Forms;

namespace minekampf.Forms
{
	// Token: 0x0200006D RID: 109
	public class PckPreview : UserControl
	{
		// Token: 0x0600016D RID: 365 RVA: 0x000140C4 File Offset: 0x000122C4
		public PckPreview(string name, string author, string desc, string direct, string ad, Bitmap icon, int mode, string mod, MethodInvoker Reloader)
		{
			this.reloader = Reloader;
			this.nameLabel.parentPreview = this;
			this.layout.parentPreview = this;
			this.name = name;
			this.author = author;
			this.desc = desc;
			this.direct = direct;
			this.ad = ad;
			this.mode = mode;
			this.mod = mod;
			this.icon = icon;
			this.layout.BackColor = Color.White;
			base.Size = new Size(250, 280);
			this.nameLabel.Dock = DockStyle.Fill;
			this.nameLabel.Location = new Point(0, 0);
			this.nameLabel.Size = new Size(230, 30);
			this.iconBox.Image = icon;
			this.iconBox.Anchor = AnchorStyles.None;
			this.nameLabel.Text = name;
			this.iconBox.SizeMode = PictureBoxSizeMode.StretchImage;
			this.iconBox.Size = new Size(230, 230);
			this.layout.Margin = new Padding(0, 0, 0, 0);
			base.Margin = new Padding(20, 15, 20, 15);
			this.nameLabel.ForeColor = Color.Black;
			this.nameLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.nameLabel.Font = new Font(this.nameLabel.Font.FontFamily, 14f);
			this.layout.Controls.Add(this.iconBox, 0, 1);
			this.layout.Controls.Add(this.nameLabel, 0, 0);
			this.layout.Parent = this;
			this.layout.Dock = DockStyle.Fill;
			this.iconBox.Enabled = false;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000034B6 File Offset: 0x000016B6
		public void setHover(bool hover)
		{
			if (hover)
			{
				this.layout.BackColor = Color.LightGray;
			}
			else
			{
				this.layout.BackColor = Color.White;
			}
			this.layout.Refresh();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000142B8 File Offset: 0x000124B8
		public void onClick()
		{
			this.layout.BackColor = Color.Gray;
			this.layout.Refresh();
			new pckCenterOpen(this.name, this.author, this.desc, this.direct, this.ad, this.icon, this.mode, this.mod, this.reloader).ShowDialog();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002DC9 File Offset: 0x00000FC9
		public void onDoubleClick()
		{
		}

		// Token: 0x0400031B RID: 795
		private string name;

		// Token: 0x0400031C RID: 796
		private string author;

		// Token: 0x0400031D RID: 797
		private string desc;

		// Token: 0x0400031E RID: 798
		private string direct;

		// Token: 0x0400031F RID: 799
		private string ad;

		// Token: 0x04000320 RID: 800
		private int mode;

		// Token: 0x04000321 RID: 801
		private string mod;

		// Token: 0x04000322 RID: 802
		private Bitmap icon;

		// Token: 0x04000323 RID: 803
		private PictureBox iconBox = new PictureBox();

		// Token: 0x04000324 RID: 804
		public MyNameLabel nameLabel = new MyNameLabel();

		// Token: 0x04000325 RID: 805
		private MyTablePanel layout = new MyTablePanel();

		// Token: 0x04000326 RID: 806
		private MethodInvoker reloader;
	}
}
