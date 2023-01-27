using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200007F RID: 127
	public class FileOutput
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x000039FC File Offset: 0x00001BFC
		public byte[] getBytes()
		{
			return this.data.ToArray();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00026C94 File Offset: 0x00024E94
		public void writeString(string s)
		{
			char[] array = s.ToCharArray();
			for (int i = 0; i < array.Length; i++)
			{
				this.data.Add((byte)array[i]);
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003A09 File Offset: 0x00001C09
		public int size()
		{
			return this.data.Count;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00026CC8 File Offset: 0x00024EC8
		public void writeOutput(FileOutput d)
		{
			foreach (byte item in d.data)
			{
				this.data.Add(item);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00026D20 File Offset: 0x00024F20
		private static char[] HexToCharArray(string hex)
		{
			return (from x in Enumerable.Range(0, hex.Length)
			where x % 2 == 0
			select Convert.ToByte(hex.Substring(x, 2), 16) into x
			select Convert.ToChar(x)).ToArray<char>();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00026DAC File Offset: 0x00024FAC
		public void writeHex(string s)
		{
			char[] array = FileOutput.HexToCharArray(s);
			for (int i = 0; i < array.Length; i++)
			{
				this.data.Add((byte)array[i]);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00026DE0 File Offset: 0x00024FE0
		public void writeInt(int i)
		{
			if (this.Endian == Endianness.Little)
			{
				this.data.Add((byte)(i & 255));
				this.data.Add((byte)(i >> 8 & 255));
				this.data.Add((byte)(i >> 16 & 255));
				this.data.Add((byte)(i >> 24 & 255));
				return;
			}
			this.data.Add((byte)(i >> 24 & 255));
			this.data.Add((byte)(i >> 16 & 255));
			this.data.Add((byte)(i >> 8 & 255));
			this.data.Add((byte)(i & 255));
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00026EA0 File Offset: 0x000250A0
		public void writeIntAt(int i, int p)
		{
			if (this.Endian == Endianness.Little)
			{
				this.data[p++] = (byte)(i & 255);
				this.data[p++] = (byte)(i >> 8 & 255);
				this.data[p++] = (byte)(i >> 16 & 255);
				this.data[p++] = (byte)(i >> 24 & 255);
				return;
			}
			this.data[p++] = (byte)(i >> 24 & 255);
			this.data[p++] = (byte)(i >> 16 & 255);
			this.data[p++] = (byte)(i >> 8 & 255);
			this.data[p++] = (byte)(i & 255);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00026F90 File Offset: 0x00025190
		public void writeShortAt(int i, int p)
		{
			if (this.Endian == Endianness.Little)
			{
				this.data[p++] = (byte)(i & 255);
				this.data[p++] = (byte)(i >> 8 & 255);
				return;
			}
			this.data[p++] = (byte)(i >> 8 & 255);
			this.data[p++] = (byte)(i & 255);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00003A16 File Offset: 0x00001C16
		public void align(int i)
		{
			while (this.data.Count % i != 0)
			{
				this.writeByte(0);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003A30 File Offset: 0x00001C30
		public void align(int i, int v)
		{
			while (this.data.Count % i != 0)
			{
				this.writeByte(v);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00027010 File Offset: 0x00025210
		public void writeFloat(float f)
		{
			int num = FileOutput.SingleToInt32Bits(f, this.Endian == Endianness.Big);
			this.data.Add((byte)(num & 255));
			this.data.Add((byte)(num >> 8 & 255));
			this.data.Add((byte)(num >> 16 & 255));
			this.data.Add((byte)(num >> 24 & 255));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00027084 File Offset: 0x00025284
		public static int SingleToInt32Bits(float value, bool littleEndian)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			if (!littleEndian)
			{
				return (int)(bytes[num++] & byte.MaxValue) | (int)(bytes[num++] & byte.MaxValue) << 8 | (int)(bytes[num++] & byte.MaxValue) << 16 | (int)(bytes[num++] & byte.MaxValue) << 24;
			}
			return (int)(bytes[num++] & byte.MaxValue) << 24 | (int)(bytes[num++] & byte.MaxValue) << 16 | (int)(bytes[num++] & byte.MaxValue) << 8 | (int)(bytes[num++] & byte.MaxValue);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0002711C File Offset: 0x0002531C
		public void writeHalfFloat(float f)
		{
			int num = FileData.fromFloat(f, this.Endian == Endianness.Little);
			this.data.Add((byte)(num >> 8 & 255));
			this.data.Add((byte)(num & 255));
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00027164 File Offset: 0x00025364
		public void writeShort(int i)
		{
			if (this.Endian == Endianness.Little)
			{
				this.data.Add((byte)(i & 255));
				this.data.Add((byte)(i >> 8 & 255));
				return;
			}
			this.data.Add((byte)(i >> 8 & 255));
			this.data.Add((byte)(i & 255));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00003A4A File Offset: 0x00001C4A
		public void writeByte(int i)
		{
			this.data.Add((byte)(i & 255));
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000271CC File Offset: 0x000253CC
		public void writeChars(char[] c)
		{
			foreach (char value in c)
			{
				this.writeByte((int)Convert.ToByte(value));
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000271FC File Offset: 0x000253FC
		public void writeBytes(byte[] bytes)
		{
			foreach (byte i2 in bytes)
			{
				this.writeByte((int)i2);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00003A5F File Offset: 0x00001C5F
		public void writeFlag(bool b)
		{
			if (b)
			{
				this.writeByte(1);
				return;
			}
			this.writeByte(0);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00003A09 File Offset: 0x00001C09
		public int pos()
		{
			return this.data.Count;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00003A73 File Offset: 0x00001C73
		public void save(string fname)
		{
			File.WriteAllBytes(fname, this.data.ToArray());
		}

		// Token: 0x040003D2 RID: 978
		private List<byte> data = new List<byte>();

		// Token: 0x040003D3 RID: 979
		public Endianness Endian;
	}
}
