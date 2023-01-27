using System;
using System.IO;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200007D RID: 125
	public abstract class FileBase
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001D9 RID: 473
		// (set) Token: 0x060001DA RID: 474
		public abstract Endianness Endian { get; set; }

		// Token: 0x060001DB RID: 475
		public abstract void Read(string filename);

		// Token: 0x060001DC RID: 476
		public abstract byte[] Rebuild();

		// Token: 0x060001DD RID: 477 RVA: 0x000265DC File Offset: 0x000247DC
		public void Save(string filename)
		{
			byte[] array = this.Rebuild();
			if (array.Length == 0)
			{
				throw new Exception("Warning: Data was empty!");
			}
			File.WriteAllBytes(filename, array);
		}
	}
}
