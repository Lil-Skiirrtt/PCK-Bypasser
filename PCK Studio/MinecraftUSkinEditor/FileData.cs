using System;
using System.Collections.Generic;
using System.IO;

namespace MinecraftUSkinEditor
{
	// Token: 0x0200007E RID: 126
	public class FileData
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00003952 File Offset: 0x00001B52
		public FileData(string f)
		{
			this.b = File.ReadAllBytes(f);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00003966 File Offset: 0x00001B66
		public FileData(byte[] b)
		{
			this.b = b;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00003975 File Offset: 0x00001B75
		public int eof()
		{
			return this.b.Length;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00026608 File Offset: 0x00024808
		public byte[] read(int length)
		{
			if (length + this.p > this.b.Length)
			{
				throw new IndexOutOfRangeException();
			}
			byte[] array = new byte[length];
			int i = 0;
			while (i < length)
			{
				array[i] = this.b[this.p];
				i++;
				this.p++;
			}
			return array;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00026660 File Offset: 0x00024860
		public int readInt()
		{
			int num;
			if (this.Endian == Endianness.Little)
			{
				byte[] array = this.b;
				num = this.p;
				this.p = num + 1;
				int num2 = array[num] & 255;
				byte[] array2 = this.b;
				num = this.p;
				this.p = num + 1;
				int num3 = num2 | (array2[num] & 255) << 8;
				byte[] array3 = this.b;
				num = this.p;
				this.p = num + 1;
				int num4 = num3 | (array3[num] & 255) << 16;
				byte[] array4 = this.b;
				num = this.p;
				this.p = num + 1;
				return num4 | (array4[num] & 255) << 24;
			}
			byte[] array5 = this.b;
			num = this.p;
			this.p = num + 1;
			int num5 = (array5[num] & 255) << 24;
			byte[] array6 = this.b;
			num = this.p;
			this.p = num + 1;
			int num6 = num5 | (array6[num] & 255) << 16;
			byte[] array7 = this.b;
			num = this.p;
			this.p = num + 1;
			int num7 = num6 | (array7[num] & 255) << 8;
			byte[] array8 = this.b;
			num = this.p;
			this.p = num + 1;
			return num7 | (array8[num] & 255);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00026780 File Offset: 0x00024980
		public int readThree()
		{
			int num;
			if (this.Endian == Endianness.Little)
			{
				byte[] array = this.b;
				num = this.p;
				this.p = num + 1;
				int num2 = array[num] & 255;
				byte[] array2 = this.b;
				num = this.p;
				this.p = num + 1;
				int num3 = num2 | (array2[num] & 255) << 8;
				byte[] array3 = this.b;
				num = this.p;
				this.p = num + 1;
				return num3 | (array3[num] & 255) << 16;
			}
			byte[] array4 = this.b;
			num = this.p;
			this.p = num + 1;
			int num4 = (array4[num] & 255) << 16;
			byte[] array5 = this.b;
			num = this.p;
			this.p = num + 1;
			int num5 = num4 | (array5[num] & 255) << 8;
			byte[] array6 = this.b;
			num = this.p;
			this.p = num + 1;
			return num5 | (array6[num] & 255);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00026858 File Offset: 0x00024A58
		public int readShort()
		{
			int num;
			if (this.Endian == Endianness.Little)
			{
				byte[] array = this.b;
				num = this.p;
				this.p = num + 1;
				int num2 = array[num] & 255;
				byte[] array2 = this.b;
				num = this.p;
				this.p = num + 1;
				return num2 | (array2[num] & 255) << 8;
			}
			byte[] array3 = this.b;
			num = this.p;
			this.p = num + 1;
			int num3 = (array3[num] & 255) << 8;
			byte[] array4 = this.b;
			num = this.p;
			this.p = num + 1;
			return num3 | (array4[num] & 255);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000268EC File Offset: 0x00024AEC
		public int readByte()
		{
			byte[] array = this.b;
			int num = this.p;
			this.p = num + 1;
			return array[num] & 255;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00026918 File Offset: 0x00024B18
		public byte[] readBytes(int length)
		{
			List<byte> list = new List<byte>();
			for (int i = 0; i < length; i++)
			{
				list.Add((byte)this.readByte());
			}
			return list.ToArray();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0002694C File Offset: 0x00024B4C
		public float readFloat()
		{
			byte[] value = new byte[4];
			if (this.Endian == Endianness.Little)
			{
				value = new byte[]
				{
					this.b[this.p],
					this.b[this.p + 1],
					this.b[this.p + 2],
					this.b[this.p + 3]
				};
			}
			else
			{
				value = new byte[]
				{
					this.b[this.p + 3],
					this.b[this.p + 2],
					this.b[this.p + 1],
					this.b[this.p]
				};
			}
			this.p += 4;
			return BitConverter.ToSingle(value, 0);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000397F File Offset: 0x00001B7F
		public float readHalfFloat()
		{
			return FileData.toFloat((int)((short)this.readShort()));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00026A1C File Offset: 0x00024C1C
		public static float toFloat(int hbits)
		{
			int num = hbits & 1023;
			int num2 = hbits & 31744;
			if (num2 == 31744)
			{
				num2 = 261120;
			}
			else if (num2 != 0)
			{
				num2 += 114688;
				if (num == 0 && num2 > 115712)
				{
					return BitConverter.ToSingle(BitConverter.GetBytes((hbits & 32768) << 16 | num2 << 13 | 1023), 0);
				}
			}
			else if (num != 0)
			{
				num2 = 115712;
				do
				{
					num <<= 1;
					num2 -= 1024;
				}
				while ((num & 1024) == 0);
				num &= 1023;
			}
			return BitConverter.ToSingle(BitConverter.GetBytes((hbits & 32768) << 16 | (num2 | num) << 13), 0);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00026AC4 File Offset: 0x00024CC4
		public static int fromFloat(float fval, bool littleEndian)
		{
			int num = FileOutput.SingleToInt32Bits(fval, littleEndian);
			int num2 = num >> 16 & 32768;
			int num3 = (num & int.MaxValue) + 4096;
			if (num3 >= 1199570944)
			{
				if ((num & 2147483647) < 1199570944)
				{
					return num2 | 31743;
				}
				if (num3 < 2139095040)
				{
					return num2 | 31744;
				}
				return num2 | 31744 | (num & 8388607) >> 13;
			}
			else
			{
				if (num3 >= 947912704)
				{
					return num2 | num3 - 939524096 >> 13;
				}
				if (num3 < 855638016)
				{
					return num2;
				}
				num3 = (num & int.MaxValue) >> 23;
				return num2 | ((num & 8388607) | 8388608) + (8388608 >> num3 - 102) >> 126 - num3;
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000398D File Offset: 0x00001B8D
		public static int sign12Bit(int i)
		{
			if ((i >> 11 & 1) == 1)
			{
				i = ~i;
				i &= 4095;
				i++;
				i *= -1;
			}
			return i;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000039B0 File Offset: 0x00001BB0
		public void skip(int i)
		{
			this.p += i;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000039C0 File Offset: 0x00001BC0
		public void seek(int i)
		{
			this.p = i;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000039C9 File Offset: 0x00001BC9
		public int pos()
		{
			return this.p;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00003975 File Offset: 0x00001B75
		public int size()
		{
			return this.b.Length;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00026B84 File Offset: 0x00024D84
		public string readString()
		{
			string text = "";
			while (this.b[this.p] != 0)
			{
				string str = text;
				char c = (char)this.b[this.p];
				text = str + c.ToString();
				this.p++;
			}
			return text;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00026BD4 File Offset: 0x00024DD4
		public byte[] getSection(int offset, int size)
		{
			byte[] array = new byte[size];
			Array.Copy(this.b, offset, array, 0, size);
			return array;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00026BF8 File Offset: 0x00024DF8
		public string readString(int p, int size)
		{
			if (size == -1)
			{
				string text = "";
				while (p < this.b.Length && (this.b[p] & 255) != 0)
				{
					text += ((char)(this.b[p] & byte.MaxValue)).ToString();
					p++;
				}
				return text;
			}
			string text2 = "";
			for (int i = p; i < p + size; i++)
			{
				if ((this.b[i] & 255) != 0)
				{
					text2 += ((char)(this.b[i] & byte.MaxValue)).ToString();
				}
			}
			return text2;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000039D1 File Offset: 0x00001BD1
		public void align(int i)
		{
			while (this.p % i != 0)
			{
				this.p++;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000039ED File Offset: 0x00001BED
		public int readOffset()
		{
			return this.p + this.readInt();
		}

		// Token: 0x040003CF RID: 975
		private byte[] b;

		// Token: 0x040003D0 RID: 976
		private int p;

		// Token: 0x040003D1 RID: 977
		public Endianness Endian;
	}
}
