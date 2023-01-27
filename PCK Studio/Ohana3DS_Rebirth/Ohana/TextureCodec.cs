using System;
using System.Drawing;
using System.Linq;

namespace Ohana3DS_Rebirth.Ohana
{
	// Token: 0x0200005F RID: 95
	internal class TextureCodec
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public static Bitmap decode(byte[] data, int width, int height, RenderBase.OTextureFormat format)
		{
			byte[] array = new byte[width * height * 4];
			long num = 0L;
			bool flag = false;
			switch (format)
			{
			case RenderBase.OTextureFormat.rgba8:
				for (int i = 0; i < height / 8; i++)
				{
					for (int j = 0; j < width / 8; j++)
					{
						for (int k = 0; k < 64; k++)
						{
							int num2 = TextureCodec.tileOrder[k] % 8;
							int num3 = (TextureCodec.tileOrder[k] - num2) / 8;
							long num4 = (long)((j * 8 + num2 + (i * 8 + num3) * width) * 4);
							Buffer.BlockCopy(data, (int)num + 1, array, (int)num4, 3);
							checked
							{
								array[(int)((IntPtr)(unchecked(num4 + 3L)))] = data[(int)((IntPtr)num)];
							}
							num += 4L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.rgb8:
				for (int l = 0; l < height / 8; l++)
				{
					for (int m = 0; m < width / 8; m++)
					{
						for (int n = 0; n < 64; n++)
						{
							int num5 = TextureCodec.tileOrder[n] % 8;
							int num6 = (TextureCodec.tileOrder[n] - num5) / 8;
							long num7 = (long)((m * 8 + num5 + (l * 8 + num6) * width) * 4);
							Buffer.BlockCopy(data, (int)num, array, (int)num7, 3);
							array[(int)(checked((IntPtr)(unchecked(num7 + 3L))))] = byte.MaxValue;
							num += 3L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.rgba5551:
				for (int num8 = 0; num8 < height / 8; num8++)
				{
					for (int num9 = 0; num9 < width / 8; num9++)
					{
						for (int num10 = 0; num10 < 64; num10++)
						{
							int num11 = TextureCodec.tileOrder[num10] % 8;
							int num12 = (TextureCodec.tileOrder[num10] - num11) / 8;
							long num13 = (long)((num9 * 8 + num11 + (num8 * 8 + num12) * width) * 4);
							ushort num14 = (ushort)(checked((int)data[(int)((IntPtr)num)] | (int)data[(int)((IntPtr)(unchecked(num + 1L)))] << 8));
							byte b = (byte)((num14 >> 1 & 31) << 3);
							byte b2 = (byte)((num14 >> 6 & 31) << 3);
							byte b3 = (byte)((num14 >> 11 & 31) << 3);
							byte b4 = (byte)((num14 & 1) * 255);
							array[(int)(checked((IntPtr)num13))] = (byte)((int)b | b >> 5);
							array[(int)(checked((IntPtr)(unchecked(num13 + 1L))))] = (byte)((int)b2 | b2 >> 5);
							array[(int)(checked((IntPtr)(unchecked(num13 + 2L))))] = (byte)((int)b3 | b3 >> 5);
							array[(int)(checked((IntPtr)(unchecked(num13 + 3L))))] = b4;
							num += 2L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.rgb565:
				for (int num15 = 0; num15 < height / 8; num15++)
				{
					for (int num16 = 0; num16 < width / 8; num16++)
					{
						for (int num17 = 0; num17 < 64; num17++)
						{
							int num18 = TextureCodec.tileOrder[num17] % 8;
							int num19 = (TextureCodec.tileOrder[num17] - num18) / 8;
							long num20 = (long)((num16 * 8 + num18 + (num15 * 8 + num19) * width) * 4);
							ushort num21 = (ushort)(checked((int)data[(int)((IntPtr)num)] | (int)data[(int)((IntPtr)(unchecked(num + 1L)))] << 8));
							byte b5 = (byte)((num21 & 31) << 3);
							byte b6 = (byte)((num21 >> 5 & 63) << 2);
							byte b7 = (byte)((num21 >> 11 & 31) << 3);
							array[(int)(checked((IntPtr)num20))] = (byte)((int)b5 | b5 >> 5);
							array[(int)(checked((IntPtr)(unchecked(num20 + 1L))))] = (byte)((int)b6 | b6 >> 6);
							array[(int)(checked((IntPtr)(unchecked(num20 + 2L))))] = (byte)((int)b7 | b7 >> 5);
							array[(int)(checked((IntPtr)(unchecked(num20 + 3L))))] = byte.MaxValue;
							num += 2L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.rgba4:
				for (int num22 = 0; num22 < height / 8; num22++)
				{
					for (int num23 = 0; num23 < width / 8; num23++)
					{
						for (int num24 = 0; num24 < 64; num24++)
						{
							int num25 = TextureCodec.tileOrder[num24] % 8;
							int num26 = (TextureCodec.tileOrder[num24] - num25) / 8;
							long num27 = (long)((num23 * 8 + num25 + (num22 * 8 + num26) * width) * 4);
							ushort num28 = (ushort)(checked((int)data[(int)((IntPtr)num)] | (int)data[(int)((IntPtr)(unchecked(num + 1L)))] << 8));
							byte b8 = (byte)(num28 >> 4 & 15);
							byte b9 = (byte)(num28 >> 8 & 15);
							byte b10 = (byte)(num28 >> 12 & 15);
							byte b11 = (byte)(num28 & 15);
							array[(int)(checked((IntPtr)num27))] = (byte)((int)b8 | (int)b8 << 4);
							array[(int)(checked((IntPtr)(unchecked(num27 + 1L))))] = (byte)((int)b9 | (int)b9 << 4);
							array[(int)(checked((IntPtr)(unchecked(num27 + 2L))))] = (byte)((int)b10 | (int)b10 << 4);
							array[(int)(checked((IntPtr)(unchecked(num27 + 3L))))] = (byte)((int)b11 | (int)b11 << 4);
							num += 2L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.la8:
			case RenderBase.OTextureFormat.hilo8:
				for (int num29 = 0; num29 < height / 8; num29++)
				{
					for (int num30 = 0; num30 < width / 8; num30++)
					{
						for (int num31 = 0; num31 < 64; num31++)
						{
							int num32 = TextureCodec.tileOrder[num31] % 8;
							int num33 = (TextureCodec.tileOrder[num31] - num32) / 8;
							long num34 = (long)((num30 * 8 + num32 + (num29 * 8 + num33) * width) * 4);
							checked
							{
								array[(int)((IntPtr)num34)] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num34 + 1L)))] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num34 + 2L)))] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num34 + 3L)))] = data[(int)((IntPtr)(unchecked(num + 1L)))];
							}
							num += 2L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.l8:
				for (int num35 = 0; num35 < height / 8; num35++)
				{
					for (int num36 = 0; num36 < width / 8; num36++)
					{
						for (int num37 = 0; num37 < 64; num37++)
						{
							int num38 = TextureCodec.tileOrder[num37] % 8;
							int num39 = (TextureCodec.tileOrder[num37] - num38) / 8;
							long num40 = (long)((num36 * 8 + num38 + (num35 * 8 + num39) * width) * 4);
							checked
							{
								array[(int)((IntPtr)num40)] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num40 + 1L)))] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num40 + 2L)))] = data[(int)((IntPtr)num)];
								array[(int)((IntPtr)(unchecked(num40 + 3L)))] = byte.MaxValue;
							}
							num += 1L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.a8:
				for (int num41 = 0; num41 < height / 8; num41++)
				{
					for (int num42 = 0; num42 < width / 8; num42++)
					{
						for (int num43 = 0; num43 < 64; num43++)
						{
							int num44 = TextureCodec.tileOrder[num43] % 8;
							int num45 = (TextureCodec.tileOrder[num43] - num44) / 8;
							long num46 = (long)((num42 * 8 + num44 + (num41 * 8 + num45) * width) * 4);
							checked
							{
								array[(int)((IntPtr)num46)] = byte.MaxValue;
								array[(int)((IntPtr)(unchecked(num46 + 1L)))] = byte.MaxValue;
								array[(int)((IntPtr)(unchecked(num46 + 2L)))] = byte.MaxValue;
								array[(int)((IntPtr)(unchecked(num46 + 3L)))] = data[(int)((IntPtr)num)];
							}
							num += 1L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.la4:
				for (int num47 = 0; num47 < height / 8; num47++)
				{
					for (int num48 = 0; num48 < width / 8; num48++)
					{
						for (int num49 = 0; num49 < 64; num49++)
						{
							int num50 = TextureCodec.tileOrder[num49] % 8;
							int num51 = (TextureCodec.tileOrder[num49] - num50) / 8;
							long num52 = (long)((num48 * 8 + num50 + (num47 * 8 + num51) * width) * 4);
							array[(int)(checked((IntPtr)num52))] = (byte)(data[(int)(checked((IntPtr)num))] >> 4);
							array[(int)(checked((IntPtr)(unchecked(num52 + 1L))))] = (byte)(data[(int)(checked((IntPtr)num))] >> 4);
							array[(int)(checked((IntPtr)(unchecked(num52 + 2L))))] = (byte)(data[(int)(checked((IntPtr)num))] >> 4);
							checked
							{
								array[(int)((IntPtr)(unchecked(num52 + 3L)))] = (data[(int)((IntPtr)num)] & 15);
							}
							num += 1L;
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.l4:
				for (int num53 = 0; num53 < height / 8; num53++)
				{
					for (int num54 = 0; num54 < width / 8; num54++)
					{
						for (int num55 = 0; num55 < 64; num55++)
						{
							int num56 = TextureCodec.tileOrder[num55] % 8;
							int num57 = (TextureCodec.tileOrder[num55] - num56) / 8;
							long num58 = (long)((num54 * 8 + num56 + (num53 * 8 + num57) * width) * 4);
							byte b12;
							if (!flag)
							{
								b12 = (data[(int)(checked((IntPtr)num))] & 15);
							}
							else
							{
								long num59 = num;
								num = num59 + 1L;
								b12 = (byte)((data[(int)(checked((IntPtr)num59))] & 240) >> 4);
							}
							byte b13 = b12;
							flag = !flag;
							b13 = (byte)((int)b13 << 4 | (int)b13);
							checked
							{
								array[(int)((IntPtr)num58)] = b13;
								array[(int)((IntPtr)(unchecked(num58 + 1L)))] = b13;
								array[(int)((IntPtr)(unchecked(num58 + 2L)))] = b13;
								array[(int)((IntPtr)(unchecked(num58 + 3L)))] = byte.MaxValue;
							}
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.a4:
				for (int num60 = 0; num60 < height / 8; num60++)
				{
					for (int num61 = 0; num61 < width / 8; num61++)
					{
						for (int num62 = 0; num62 < 64; num62++)
						{
							int num63 = TextureCodec.tileOrder[num62] % 8;
							int num64 = (TextureCodec.tileOrder[num62] - num63) / 8;
							long num65 = (long)((num61 * 8 + num63 + (num60 * 8 + num64) * width) * 4);
							checked
							{
								array[(int)((IntPtr)num65)] = byte.MaxValue;
								array[(int)((IntPtr)(unchecked(num65 + 1L)))] = byte.MaxValue;
								array[(int)((IntPtr)(unchecked(num65 + 2L)))] = byte.MaxValue;
							}
							byte b14;
							if (!flag)
							{
								b14 = (data[(int)(checked((IntPtr)num))] & 15);
							}
							else
							{
								long num66 = num;
								num = num66 + 1L;
								b14 = (byte)((data[(int)(checked((IntPtr)num66))] & 240) >> 4);
							}
							byte b15 = b14;
							flag = !flag;
							array[(int)(checked((IntPtr)(unchecked(num65 + 3L))))] = (byte)((int)b15 << 4 | (int)b15);
						}
					}
				}
				break;
			case RenderBase.OTextureFormat.etc1:
			case RenderBase.OTextureFormat.etc1a4:
			{
				byte[] src = TextureCodec.etc1Decode(data, width, height, format == RenderBase.OTextureFormat.etc1a4);
				int[] array2 = TextureCodec.etc1Scramble(width, height);
				int num67 = 0;
				for (int num68 = 0; num68 < height / 4; num68++)
				{
					for (int num69 = 0; num69 < width / 4; num69++)
					{
						int num70 = array2[num67] % (width / 4);
						int num71 = (array2[num67] - num70) / (width / 4);
						for (int num72 = 0; num72 < 4; num72++)
						{
							for (int num73 = 0; num73 < 4; num73++)
							{
								num = (long)((num70 * 4 + num73 + (num71 * 4 + num72) * width) * 4);
								long num74 = (long)((num69 * 4 + num73 + (num68 * 4 + num72) * width) * 4);
								Buffer.BlockCopy(src, (int)num, array, (int)num74, 4);
							}
						}
						num67++;
					}
				}
				break;
			}
			}
			return TextureUtils.getBitmap(array.ToArray<byte>(), width, height);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00005710 File Offset: 0x00003910
		public static byte[] encode(Bitmap img, RenderBase.OTextureFormat format)
		{
			byte[] array = TextureUtils.getArray(img);
			byte[] array2 = new byte[array.Length];
			uint num = 0U;
			if (format == RenderBase.OTextureFormat.rgba8)
			{
				for (int i = 0; i < img.Height / 8; i++)
				{
					for (int j = 0; j < img.Width / 8; j++)
					{
						for (int k = 0; k < 64; k++)
						{
							int num2 = TextureCodec.tileOrder[k] % 8;
							int num3 = (TextureCodec.tileOrder[k] - num2) / 8;
							long num4 = (long)((j * 8 + num2 + (i * 8 + num3) * img.Width) * 4);
							Buffer.BlockCopy(array, (int)num4, array2, (int)(num + 1U), 3);
							array2[(int)num] = array[(int)(checked((IntPtr)(unchecked(num4 + 3L))))];
							num += 4U;
						}
					}
				}
				return array2;
			}
			throw new NotImplementedException();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000057D0 File Offset: 0x000039D0
		private static byte[] etc1Decode(byte[] input, int width, int height, bool alpha)
		{
			byte[] array = new byte[width * height * 4];
			long num = 0L;
			for (int i = 0; i < height / 4; i++)
			{
				for (int j = 0; j < width / 4; j++)
				{
					byte[] array2 = new byte[8];
					byte[] array3 = new byte[8];
					if (alpha)
					{
						for (int k = 0; k < 8; k++)
						{
							array2[7 - k] = input[(int)(checked((IntPtr)(unchecked(num + 8L + (long)k))))];
							array3[k] = input[(int)(checked((IntPtr)(unchecked(num + (long)k))))];
						}
						num += 16L;
					}
					else
					{
						for (int l = 0; l < 8; l++)
						{
							array2[7 - l] = input[(int)(checked((IntPtr)(unchecked(num + (long)l))))];
							array3[l] = byte.MaxValue;
						}
						num += 8L;
					}
					array2 = TextureCodec.etc1DecodeBlock(array2);
					bool flag = false;
					long num2 = 0L;
					for (int m = 0; m < 4; m++)
					{
						for (int n = 0; n < 4; n++)
						{
							int num3 = (j * 4 + m + (i * 4 + n) * width) * 4;
							int srcOffset = (m + n * 4) * 4;
							Buffer.BlockCopy(array2, srcOffset, array, num3, 3);
							byte b;
							if (!flag)
							{
								b = (array3[(int)(checked((IntPtr)num2))] & 15);
							}
							else
							{
								byte[] array4 = array3;
								long num4 = num2;
								num2 = num4 + 1L;
								b = (byte)((array4[(int)(checked((IntPtr)num4))] & 240) >> 4);
							}
							byte b2 = b;
							array[num3 + 3] = (byte)((int)b2 << 4 | (int)b2);
							flag = !flag;
						}
					}
				}
			}
			return array;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00005928 File Offset: 0x00003B28
		private static byte[] etc1DecodeBlock(byte[] data)
		{
			uint num = BitConverter.ToUInt32(data, 0);
			uint block = BitConverter.ToUInt32(data, 4);
			bool flag = (num & 16777216U) > 0U;
			uint num2;
			uint num3;
			uint num4;
			uint num5;
			uint num6;
			uint num7;
			if ((num & 33554432U) > 0U)
			{
				num2 = (num & 248U);
				num3 = (num & 63488U) >> 8;
				num4 = (num & 16252928U) >> 16;
				num5 = (uint)((int)((sbyte)(num2 >> 3)) + ((sbyte)((num & 7U) << 5) >> 5));
				num6 = (uint)((int)((sbyte)(num3 >> 3)) + ((sbyte)((num & 1792U) >> 3) >> 5));
				num7 = (uint)((int)((sbyte)(num4 >> 3)) + ((sbyte)((num & 458752U) >> 11) >> 5));
				num2 |= num2 >> 5;
				num3 |= num3 >> 5;
				num4 |= num4 >> 5;
				num5 = (num5 << 3 | num5 >> 2);
				num6 = (num6 << 3 | num6 >> 2);
				num7 = (num7 << 3 | num7 >> 2);
			}
			else
			{
				num2 = (num & 240U);
				num3 = (num & 61440U) >> 8;
				num4 = (num & 15728640U) >> 16;
				num5 = (num & 15U) << 4;
				num6 = (num & 3840U) >> 4;
				num7 = (num & 983040U) >> 12;
				num2 |= num2 >> 4;
				num3 |= num3 >> 4;
				num4 |= num4 >> 4;
				num5 |= num5 >> 4;
				num6 |= num6 >> 4;
				num7 |= num7 >> 4;
			}
			uint table = num >> 29 & 7U;
			uint table2 = num >> 26 & 7U;
			byte[] array = new byte[64];
			if (!flag)
			{
				for (int i = 0; i <= 3; i++)
				{
					for (int j = 0; j <= 1; j++)
					{
						Color color = TextureCodec.etc1Pixel(num2, num3, num4, j, i, block, table);
						Color color2 = TextureCodec.etc1Pixel(num5, num6, num7, j + 2, i, block, table2);
						int num8 = (i * 4 + j) * 4;
						array[num8] = color.B;
						array[num8 + 1] = color.G;
						array[num8 + 2] = color.R;
						int num9 = (i * 4 + j + 2) * 4;
						array[num9] = color2.B;
						array[num9 + 1] = color2.G;
						array[num9 + 2] = color2.R;
					}
				}
			}
			else
			{
				for (int k = 0; k <= 1; k++)
				{
					for (int l = 0; l <= 3; l++)
					{
						Color color3 = TextureCodec.etc1Pixel(num2, num3, num4, l, k, block, table);
						Color color4 = TextureCodec.etc1Pixel(num5, num6, num7, l, k + 2, block, table2);
						int num10 = (k * 4 + l) * 4;
						array[num10] = color3.B;
						array[num10 + 1] = color3.G;
						array[num10 + 2] = color3.R;
						int num11 = ((k + 2) * 4 + l) * 4;
						array[num11] = color4.B;
						array[num11 + 1] = color4.G;
						array[num11 + 2] = color4.R;
					}
				}
			}
			return array;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00005BF8 File Offset: 0x00003DF8
		private static Color etc1Pixel(uint r, uint g, uint b, int x, int y, uint block, uint table)
		{
			int num = x * 4 + y;
			uint num2 = block << 1;
			int num3 = (num < 8) ? TextureCodec.etc1LUT[(int)table, (int)((block >> num + 24 & 1U) + (num2 >> num + 8 & 2U))] : TextureCodec.etc1LUT[(int)table, (int)((block >> num + 8 & 1U) + (num2 >> num - 8 & 2U))];
			r = (uint)TextureCodec.saturate((int)((ulong)r + (ulong)((long)num3)));
			g = (uint)TextureCodec.saturate((int)((ulong)g + (ulong)((long)num3)));
			b = (uint)TextureCodec.saturate((int)((ulong)b + (ulong)((long)num3)));
			return Color.FromArgb((int)r, (int)g, (int)b);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002D6D File Offset: 0x00000F6D
		private static byte saturate(int value)
		{
			if (value > 255)
			{
				return byte.MaxValue;
			}
			if (value < 0)
			{
				return 0;
			}
			return (byte)(value & 255);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005C8C File Offset: 0x00003E8C
		private static int[] etc1Scramble(int width, int height)
		{
			int[] array = new int[width / 4 * (height / 4)];
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (i % (width / 4) == 0 && i > 0)
				{
					if (num2 < 1)
					{
						num2++;
						num4 += 2;
						num3 = num4;
					}
					else
					{
						num2 = 0;
						num3 -= 2;
						num4 = num3;
					}
				}
				array[i] = num3;
				if (num < 1)
				{
					num++;
					num3++;
				}
				else
				{
					num = 0;
					num3 += 3;
				}
			}
			return array;
		}

		// Token: 0x04000281 RID: 641
		private static int[] tileOrder = new int[]
		{
			0,
			1,
			8,
			9,
			2,
			3,
			10,
			11,
			16,
			17,
			24,
			25,
			18,
			19,
			26,
			27,
			4,
			5,
			12,
			13,
			6,
			7,
			14,
			15,
			20,
			21,
			28,
			29,
			22,
			23,
			30,
			31,
			32,
			33,
			40,
			41,
			34,
			35,
			42,
			43,
			48,
			49,
			56,
			57,
			50,
			51,
			58,
			59,
			36,
			37,
			44,
			45,
			38,
			39,
			46,
			47,
			52,
			53,
			60,
			61,
			54,
			55,
			62,
			63
		};

		// Token: 0x04000282 RID: 642
		private static int[,] etc1LUT = new int[,]
		{
			{
				2,
				8,
				-2,
				-8
			},
			{
				5,
				17,
				-5,
				-17
			},
			{
				9,
				29,
				-9,
				-29
			},
			{
				13,
				42,
				-13,
				-42
			},
			{
				18,
				60,
				-18,
				-60
			},
			{
				24,
				80,
				-24,
				-80
			},
			{
				33,
				106,
				-33,
				-106
			},
			{
				47,
				183,
				-47,
				-183
			}
		};
	}
}
