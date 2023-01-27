using System;
using System.Windows.Forms;

namespace minekampf.Forms
{
	// Token: 0x0200006F RID: 111
	public class MyNameLabel : Label
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000034F0 File Offset: 0x000016F0
		protected override void OnMouseEnter(EventArgs e)
		{
			this.parentPreview.setHover(true);
			base.OnMouseEnter(e);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00003505 File Offset: 0x00001705
		protected override void OnMouseLeave(EventArgs e)
		{
			this.parentPreview.setHover(false);
			base.OnMouseLeave(e);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000351A File Offset: 0x0000171A
		protected override void OnMouseClick(MouseEventArgs e)
		{
			this.parentPreview.onClick();
			base.OnMouseClick(e);
		}

		// Token: 0x04000328 RID: 808
		public PckPreview parentPreview;
	}
}
