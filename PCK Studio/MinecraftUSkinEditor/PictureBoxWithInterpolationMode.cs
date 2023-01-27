using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000087 RID: 135
	public class PictureBoxWithInterpolationMode : PictureBox
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00003CD3 File Offset: 0x00001ED3
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00003CDB File Offset: 0x00001EDB
		public InterpolationMode InterpolationMode { get; set; }

		// Token: 0x0600028D RID: 653 RVA: 0x00003CE4 File Offset: 0x00001EE4
		protected override void OnPaint(PaintEventArgs paintEventArgs)
		{
			paintEventArgs.Graphics.InterpolationMode = this.InterpolationMode;
			base.OnPaint(paintEventArgs);
		}
	}
}
