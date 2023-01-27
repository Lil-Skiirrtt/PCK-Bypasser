using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200008F RID: 143
	public class PCK
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00003E2C File Offset: 0x0000202C
		public PCK()
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003E55 File Offset: 0x00002055
		public PCK(string filename)
		{
			this.Read(File.ReadAllBytes(filename));
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000422E4 File Offset: 0x000404E4
		private static byte[] endianReverseUnicode(byte[] str)
		{
			byte[] array = new byte[str.Length];
			for (int i = 0; i < str.Length; i += 2)
			{
				array[i] = str[i + 1];
				array[i + 1] = str[i];
			}
			return array;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0004231C File Offset: 0x0004051C
		public static string readMineString(FileData f)
		{
			int length = f.readInt() * 2;
			return Encoding.Unicode.GetString(PCK.endianReverseUnicode(f.readBytes(length)));
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00042348 File Offset: 0x00040548
		public void Read(byte[] data)
		{
			FileData fileData = new FileData(data);
			fileData.Endian = Endianness.Big;
			fileData.readInt();
			int num = fileData.readInt();
			for (int i = 0; i < num; i++)
			{
				int num2 = fileData.readInt();
				string text = PCK.readMineString(fileData);
				this.types.Add(num2, text);
				this.typeCodes.Add(text, num2);
				fileData.skip(4);
			}
			int num3 = fileData.readInt();
			for (int j = 0; j < num3; j++)
			{
				PCK.MineFile mineFile = new PCK.MineFile();
				mineFile.filesize = fileData.readInt();
				mineFile.type = fileData.readInt();
				int length = fileData.readInt() * 2;
				mineFile.name = Encoding.Unicode.GetString(PCK.endianReverseUnicode(fileData.readBytes(length)));
				fileData.skip(4);
				this.mineFiles.Add(mineFile);
			}
			foreach (PCK.MineFile mineFile2 in this.mineFiles)
			{
				int num4 = fileData.readInt();
				for (int k = 0; k < num4; k++)
				{
					object[] array = new object[2];
					int key = fileData.readInt();
					array[0] = this.types[key];
					array[1] = PCK.readMineString(fileData);
					fileData.skip(4);
					mineFile2.entries.Add(array);
				}
				mineFile2.data = fileData.readBytes(mineFile2.filesize);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000424D4 File Offset: 0x000406D4
		private static void writeMinecraftString(FileOutput f, string str)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(str);
			f.writeInt(bytes.Length / 2);
			f.writeBytes(PCK.endianReverseUnicode(bytes));
			f.writeInt(0);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0004250C File Offset: 0x0004070C
		public byte[] Rebuild()
		{
			FileOutput fileOutput = new FileOutput();
			fileOutput.Endian = Endianness.Big;
			fileOutput.writeInt(3);
			fileOutput.writeInt(this.types.Count);
			foreach (int num in this.types.Keys)
			{
				fileOutput.writeInt(num);
				PCK.writeMinecraftString(fileOutput, this.types[num]);
			}
			fileOutput.writeInt(this.mineFiles.Count);
			foreach (PCK.MineFile mineFile in this.mineFiles)
			{
				fileOutput.writeInt(mineFile.data.Length);
				fileOutput.writeInt(mineFile.type);
				PCK.writeMinecraftString(fileOutput, mineFile.name);
			}
			foreach (PCK.MineFile mineFile2 in this.mineFiles)
			{
				string str = "";
				try
				{
					fileOutput.writeInt(mineFile2.entries.Count);
					foreach (object[] array in mineFile2.entries)
					{
						str = array[0].ToString();
						fileOutput.writeInt(this.typeCodes[(string)array[0]]);
						PCK.writeMinecraftString(fileOutput, (string)array[1]);
					}
					fileOutput.writeBytes(mineFile2.data);
				}
				catch (Exception)
				{
					MessageBox.Show(str + " is not in the main metadatabase");
					break;
				}
			}
			return fileOutput.getBytes();
		}

		// Token: 0x04000495 RID: 1173
		public Dictionary<int, string> types = new Dictionary<int, string>();

		// Token: 0x04000496 RID: 1174
		public Dictionary<string, int> typeCodes = new Dictionary<string, int>();

		// Token: 0x04000497 RID: 1175
		public List<PCK.MineFile> mineFiles = new List<PCK.MineFile>();

		// Token: 0x02000090 RID: 144
		public class MineFile
		{
			// Token: 0x04000498 RID: 1176
			public int filesize;

			// Token: 0x04000499 RID: 1177
			public int type;

			// Token: 0x0400049A RID: 1178
			public string name;

			// Token: 0x0400049B RID: 1179
			public byte[] data;

			// Token: 0x0400049C RID: 1180
			public List<object[]> entries = new List<object[]>();
		}
	}
}
