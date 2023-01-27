using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Ohana3DS_Rebirth.Ohana
{
	// Token: 0x02000060 RID: 96
	internal class TextureUtils
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00005D04 File Offset: 0x00003F04
		public static Bitmap getBitmap(byte[] array, int width, int height)
		{
			Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
			Marshal.Copy(array, 0, bitmapData.Scan0, array.Length);
			bitmap.UnlockBits(bitmapData);
			return bitmap;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005D58 File Offset: 0x00003F58
		public static byte[] getArray(Bitmap img)
		{
			BitmapData bitmapData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
			byte[] array = new byte[bitmapData.Stride * img.Height];
			Marshal.Copy(bitmapData.Scan0, array, 0, array.Length);
			img.UnlockBits(bitmapData);
			return array;
		}
	}
}
