using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace minekampf.Forms
{
	// Token: 0x02000067 RID: 103
	public partial class creatorSpotlight : MetroForm
	{
		// Token: 0x06000134 RID: 308 RVA: 0x000032B7 File Offset: 0x000014B7
		public creatorSpotlight()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000100C4 File Offset: 0x0000E2C4
		private void creatorSpotlight_Load(object sender, EventArgs e)
		{
			try
			{
				using (WebClient webClient = new WebClient())
				{
					this.data = webClient.DownloadString("https://www.youtube.com/channel/UCaeUL3gsAHK9LSZG4qqHaJQ/videos");
					this.webBrowser1.ScrollBarsEnabled = false;
					string format = "<html><head><meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/></head><body style=\"background-color: #000000;\"><iframe width=\"720\" height=\"439\" src=\"{0}\"frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe></body></html>";
					int num = this.data.LastIndexOf("href=\"/watch?v=");
					string str = this.data.Substring(num + 15, 11);
					string arg = "https://www.youtube.com/embed/" + str;
					this.webBrowser1.DocumentText = string.Format(format, arg);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0001016C File Offset: 0x0000E36C
		private void buttonOpenInBrowser_Click(object sender, EventArgs e)
		{
			try
			{
				Process.Start("https://youtu.be/piZN0UWtHVc" + this.data);
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadString("https://youtu.be/piZN0UWtHVc");
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x040002E1 RID: 737
		private string data;
	}
}
