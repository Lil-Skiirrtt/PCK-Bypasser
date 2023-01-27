using System;
using System.Windows.Forms;

namespace minekampf.Forms
{
	// Token: 0x0200006E RID: 110
	public class MyTablePanel : TableLayoutPanel
	{
		// Token: 0x06000171 RID: 369 RVA: 0x00014324 File Offset: 0x00012524
		protected override void OnMouseEnter(EventArgs e)
		{
			try
			{
				this.parentPreview.setHover(true);
				base.OnMouseEnter(e);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0001435C File Offset: 0x0001255C
		protected override void OnMouseLeave(EventArgs e)
		{
			try
			{
				this.parentPreview.setHover(false);
				base.OnMouseLeave(e);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00014394 File Offset: 0x00012594
		protected override void OnMouseClick(MouseEventArgs e)
		{
			try
			{
				this.parentPreview.onClick();
				base.OnMouseClick(e);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000143C8 File Offset: 0x000125C8
		protected override void OnMouseDoubleClick(MouseEventArgs e)
		{
			try
			{
				this.parentPreview.onDoubleClick();
				base.OnMouseDoubleClick(e);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000327 RID: 807
		public PckPreview parentPreview;
	}
}
