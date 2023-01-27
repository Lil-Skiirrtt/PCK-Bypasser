using System;
using System.Collections.Generic;

namespace MinecraftUSkinEditor
{
	// Token: 0x02000089 RID: 137
	public class LOC
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00003D06 File Offset: 0x00001F06
		public LOC()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00003D24 File Offset: 0x00001F24
		public LOC(byte[] data)
		{
			this.Read(data);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0004102C File Offset: 0x0003F22C
		public string readString(FileData f)
		{
			int num = f.readShort();
			string result = f.readString(f.pos(), num);
			f.skip(num);
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00041054 File Offset: 0x0003F254
		public void Read(byte[] data)
		{
			FileData fileData = new FileData(data);
			fileData.Endian = Endianness.Big;
			if (fileData.readInt() != 2)
			{
				throw new NotImplementedException("Not localization data");
			}
			int num = fileData.readInt();
			fileData.skip(1);
			this.ids.Read(fileData);
			for (int i = 0; i < num; i++)
			{
				LOC.Language language = new LOC.Language();
				language.name = this.readString(fileData);
				language.unk1 = fileData.readInt();
				this.langs.Add(language);
			}
			foreach (LOC.Language language2 in this.langs)
			{
				fileData.skip(5);
				fileData.skip(fileData.readShort());
				language2.Read(fileData);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0004112C File Offset: 0x0003F32C
		public byte[] Rebuild()
		{
			FileOutput fileOutput = new FileOutput();
			fileOutput.Endian = Endianness.Big;
			fileOutput.writeInt(2);
			fileOutput.writeInt(this.langs.Count);
			fileOutput.writeByte(0);
			fileOutput.writeBytes(this.ids.Rebuild());
			foreach (LOC.Language language in this.langs)
			{
				fileOutput.writeShort(language.name.Length);
				fileOutput.writeString(language.name);
				fileOutput.writeInt(7 + language.name.Length + language.Rebuild().Length);
			}
			foreach (LOC.Language language2 in this.langs)
			{
				fileOutput.writeInt(2);
				fileOutput.writeByte(0);
				fileOutput.writeShort(language2.name.Length);
				fileOutput.writeString(language2.name);
				fileOutput.writeBytes(language2.Rebuild());
			}
			return fileOutput.getBytes();
		}

		// Token: 0x04000478 RID: 1144
		public LOC.Language ids = new LOC.Language();

		// Token: 0x04000479 RID: 1145
		public List<LOC.Language> langs = new List<LOC.Language>();

		// Token: 0x0200008A RID: 138
		public class Language
		{
			// Token: 0x06000295 RID: 661 RVA: 0x0004102C File Offset: 0x0003F22C
			public string readString(FileData f)
			{
				int num = f.readShort();
				string result = f.readString(f.pos(), num);
				f.skip(num);
				return result;
			}

			// Token: 0x06000297 RID: 663 RVA: 0x00041268 File Offset: 0x0003F468
			public void Read(FileData f)
			{
				int num = f.readInt();
				for (int i = 0; i < num; i++)
				{
					this.names.Add(this.readString(f));
				}
			}

			// Token: 0x06000298 RID: 664 RVA: 0x0004129C File Offset: 0x0003F49C
			public byte[] Rebuild()
			{
				FileOutput fileOutput = new FileOutput();
				fileOutput.Endian = Endianness.Big;
				fileOutput.writeInt(this.names.Count);
				foreach (string text in this.names)
				{
					fileOutput.writeShort(text.Length);
					fileOutput.writeString(text);
				}
				return fileOutput.getBytes();
			}

			// Token: 0x0400047A RID: 1146
			public string name;

			// Token: 0x0400047B RID: 1147
			public int unk1;

			// Token: 0x0400047C RID: 1148
			public List<string> names = new List<string>();
		}
	}
}
