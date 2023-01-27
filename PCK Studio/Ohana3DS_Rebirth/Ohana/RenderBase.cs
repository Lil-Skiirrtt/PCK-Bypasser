using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Ohana3DS_Rebirth.Ohana
{
	// Token: 0x02000002 RID: 2
	public class RenderBase
	{
		// Token: 0x02000003 RID: 3
		public class OVector2
		{
			// Token: 0x06000003 RID: 3 RVA: 0x000021DF File Offset: 0x000003DF
			public OVector2(float _x, float _y)
			{
				this.x = _x;
				this.y = _y;
			}

			// Token: 0x06000004 RID: 4 RVA: 0x000021F5 File Offset: 0x000003F5
			public OVector2(RenderBase.OVector2 vector)
			{
				this.x = vector.x;
				this.y = vector.y;
			}

			// Token: 0x06000005 RID: 5 RVA: 0x000021D7 File Offset: 0x000003D7
			public OVector2()
			{
			}

			// Token: 0x06000006 RID: 6 RVA: 0x00002215 File Offset: 0x00000415
			public void write(BinaryWriter output)
			{
				output.Write(this.x);
				output.Write(this.y);
			}

			// Token: 0x06000007 RID: 7 RVA: 0x0000222F File Offset: 0x0000042F
			public override bool Equals(object obj)
			{
				return obj != null && this == (RenderBase.OVector2)obj;
			}

			// Token: 0x06000008 RID: 8 RVA: 0x00002242 File Offset: 0x00000442
			public override int GetHashCode()
			{
				return this.x.GetHashCode() ^ this.y.GetHashCode();
			}

			// Token: 0x06000009 RID: 9 RVA: 0x0000225B File Offset: 0x0000045B
			public static bool operator ==(RenderBase.OVector2 a, RenderBase.OVector2 b)
			{
				return a.x == b.x && a.y == b.y;
			}

			// Token: 0x0600000A RID: 10 RVA: 0x0000227B File Offset: 0x0000047B
			public static bool operator !=(RenderBase.OVector2 a, RenderBase.OVector2 b)
			{
				return !(a == b);
			}

			// Token: 0x0600000B RID: 11 RVA: 0x00002287 File Offset: 0x00000487
			public override string ToString()
			{
				return string.Format("X:{0}; Y:{1}", this.x, this.y);
			}

			// Token: 0x04000001 RID: 1
			public float x;

			// Token: 0x04000002 RID: 2
			public float y;
		}

		// Token: 0x02000004 RID: 4
		public class OVector3
		{
			// Token: 0x0600000C RID: 12 RVA: 0x000022A9 File Offset: 0x000004A9
			public OVector3(float _x, float _y, float _z)
			{
				this.x = _x;
				this.y = _y;
				this.z = _z;
			}

			// Token: 0x0600000D RID: 13 RVA: 0x000022C6 File Offset: 0x000004C6
			public OVector3(RenderBase.OVector3 vector)
			{
				this.x = vector.x;
				this.y = vector.y;
				this.z = vector.z;
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000021D7 File Offset: 0x000003D7
			public OVector3()
			{
			}

			// Token: 0x0600000F RID: 15 RVA: 0x000022F2 File Offset: 0x000004F2
			public void write(BinaryWriter output)
			{
				output.Write(this.x);
				output.Write(this.y);
				output.Write(this.z);
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00003F44 File Offset: 0x00002144
			public static RenderBase.OVector3 transform(RenderBase.OVector3 input, RenderBase.OMatrix matrix)
			{
				return new RenderBase.OVector3
				{
					x = input.x * matrix.M11 + input.y * matrix.M21 + input.z * matrix.M31 + matrix.M41,
					y = input.x * matrix.M12 + input.y * matrix.M22 + input.z * matrix.M32 + matrix.M42,
					z = input.x * matrix.M13 + input.y * matrix.M23 + input.z * matrix.M33 + matrix.M43
				};
			}

			// Token: 0x06000011 RID: 17 RVA: 0x00002318 File Offset: 0x00000518
			public override bool Equals(object obj)
			{
				return obj != null && this == (RenderBase.OVector3)obj;
			}

			// Token: 0x06000012 RID: 18 RVA: 0x0000232B File Offset: 0x0000052B
			public override int GetHashCode()
			{
				return this.x.GetHashCode() ^ this.y.GetHashCode() ^ this.z.GetHashCode();
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00002350 File Offset: 0x00000550
			public static RenderBase.OVector3 operator *(RenderBase.OVector3 a, float b)
			{
				return new RenderBase.OVector3(a.x * b, a.y * b, a.z * b);
			}

			// Token: 0x06000014 RID: 20 RVA: 0x0000236F File Offset: 0x0000056F
			public static RenderBase.OVector3 operator *(RenderBase.OVector3 a, RenderBase.OVector3 b)
			{
				return new RenderBase.OVector3(a.x * b.x, a.y * b.y, a.z * b.z);
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0000239D File Offset: 0x0000059D
			public static RenderBase.OVector3 operator /(RenderBase.OVector3 a, float b)
			{
				return new RenderBase.OVector3(a.x / b, a.y / b, a.z / b);
			}

			// Token: 0x06000016 RID: 22 RVA: 0x000023BC File Offset: 0x000005BC
			public static bool operator ==(RenderBase.OVector3 a, RenderBase.OVector3 b)
			{
				return a.x == b.x && a.y == b.y && a.z == b.z;
			}

			// Token: 0x06000017 RID: 23 RVA: 0x000023EA File Offset: 0x000005EA
			public static bool operator !=(RenderBase.OVector3 a, RenderBase.OVector3 b)
			{
				return !(a == b);
			}

			// Token: 0x06000018 RID: 24 RVA: 0x000023F6 File Offset: 0x000005F6
			public float length()
			{
				return (float)Math.Sqrt((double)RenderBase.OVector3.dot(this, this));
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002406 File Offset: 0x00000606
			public RenderBase.OVector3 normalize()
			{
				return this / this.length();
			}

			// Token: 0x0600001A RID: 26 RVA: 0x00003FF8 File Offset: 0x000021F8
			public static float dot(RenderBase.OVector3 a, RenderBase.OVector3 b)
			{
				float num = a.x * b.x;
				float num2 = a.y * b.y;
				float num3 = a.z * b.z;
				return num + num2 + num3;
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00002414 File Offset: 0x00000614
			public override string ToString()
			{
				return string.Format("X:{0}; Y:{1}; Z:{2}", this.x, this.y, this.z);
			}

			// Token: 0x04000003 RID: 3
			public float x;

			// Token: 0x04000004 RID: 4
			public float y;

			// Token: 0x04000005 RID: 5
			public float z;
		}

		// Token: 0x02000005 RID: 5
		public class OVector4
		{
			// Token: 0x0600001C RID: 28 RVA: 0x00002441 File Offset: 0x00000641
			public OVector4(float _x, float _y, float _z, float _w)
			{
				this.x = _x;
				this.y = _y;
				this.z = _z;
				this.w = _w;
			}

			// Token: 0x0600001D RID: 29 RVA: 0x00002466 File Offset: 0x00000666
			public OVector4(RenderBase.OVector4 vector)
			{
				this.x = vector.x;
				this.y = vector.y;
				this.z = vector.z;
				this.w = vector.w;
			}

			// Token: 0x0600001E RID: 30 RVA: 0x00004034 File Offset: 0x00002234
			public OVector4(RenderBase.OVector3 vector, float angle)
			{
				this.x = (float)(Math.Sin((double)(angle * 0.5f)) * (double)vector.x);
				this.y = (float)(Math.Sin((double)(angle * 0.5f)) * (double)vector.y);
				this.z = (float)(Math.Sin((double)(angle * 0.5f)) * (double)vector.z);
				this.w = (float)Math.Cos((double)(angle * 0.5f));
			}

			// Token: 0x0600001F RID: 31 RVA: 0x000021D7 File Offset: 0x000003D7
			public OVector4()
			{
			}

			// Token: 0x06000020 RID: 32 RVA: 0x0000249E File Offset: 0x0000069E
			public void write(BinaryWriter output)
			{
				output.Write(this.x);
				output.Write(this.y);
				output.Write(this.z);
				output.Write(this.w);
			}

			// Token: 0x06000021 RID: 33 RVA: 0x000040B0 File Offset: 0x000022B0
			public RenderBase.OVector3 toEuler()
			{
				return new RenderBase.OVector3
				{
					z = (float)Math.Atan2((double)(2f * (this.x * this.y + this.z * this.w)), (double)(1f - 2f * (this.y * this.y + this.z * this.z))),
					y = -(float)Math.Asin((double)(2f * (this.x * this.z - this.w * this.y))),
					x = (float)Math.Atan2((double)(2f * (this.x * this.w + this.y * this.z)), (double)(-(double)(1f - 2f * (this.z * this.z + this.w * this.w))))
				};
			}

			// Token: 0x06000022 RID: 34 RVA: 0x000024D0 File Offset: 0x000006D0
			public override bool Equals(object obj)
			{
				return obj != null && this == (RenderBase.OVector4)obj;
			}

			// Token: 0x06000023 RID: 35 RVA: 0x000024E3 File Offset: 0x000006E3
			public override int GetHashCode()
			{
				return this.x.GetHashCode() ^ this.y.GetHashCode() ^ this.z.GetHashCode() ^ this.w.GetHashCode();
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002514 File Offset: 0x00000714
			public static RenderBase.OVector4 operator *(RenderBase.OVector4 a, float b)
			{
				return new RenderBase.OVector4(a.x * b, a.y * b, a.z * b, a.w * b);
			}

			// Token: 0x06000025 RID: 37 RVA: 0x0000253B File Offset: 0x0000073B
			public static RenderBase.OVector4 operator *(RenderBase.OVector4 a, RenderBase.OVector4 b)
			{
				return new RenderBase.OVector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002576 File Offset: 0x00000776
			public static bool operator ==(RenderBase.OVector4 a, RenderBase.OVector4 b)
			{
				return a.x == b.x && a.y == b.y && a.z == b.z && a.w == b.w;
			}

			// Token: 0x06000027 RID: 39 RVA: 0x000025B2 File Offset: 0x000007B2
			public static bool operator !=(RenderBase.OVector4 a, RenderBase.OVector4 b)
			{
				return !(a == b);
			}

			// Token: 0x06000028 RID: 40 RVA: 0x000041A0 File Offset: 0x000023A0
			public override string ToString()
			{
				return string.Format("X:{0}; Y:{1}; Z:{2}; W:{3}", new object[]
				{
					this.x,
					this.y,
					this.z,
					this.w
				});
			}

			// Token: 0x04000006 RID: 6
			public float x;

			// Token: 0x04000007 RID: 7
			public float y;

			// Token: 0x04000008 RID: 8
			public float z;

			// Token: 0x04000009 RID: 9
			public float w;
		}

		// Token: 0x02000006 RID: 6
		public class OVertex : IEquatable<RenderBase.OVertex>
		{
			// Token: 0x06000029 RID: 41 RVA: 0x000041F8 File Offset: 0x000023F8
			public OVertex()
			{
				this.node = new List<int>();
				this.weight = new List<float>();
				this.position = new RenderBase.OVector3();
				this.normal = new RenderBase.OVector3();
				this.tangent = new RenderBase.OVector3();
				this.texture0 = new RenderBase.OVector2();
				this.texture1 = new RenderBase.OVector2();
				this.texture2 = new RenderBase.OVector2();
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00004264 File Offset: 0x00002464
			public OVertex(RenderBase.OVertex vertex)
			{
				this.node = new List<int>();
				this.weight = new List<float>();
				this.node.AddRange(vertex.node);
				this.weight.AddRange(vertex.weight);
				this.position = new RenderBase.OVector3(vertex.position);
				this.normal = new RenderBase.OVector3(vertex.normal);
				this.tangent = new RenderBase.OVector3(vertex.tangent);
				this.texture0 = new RenderBase.OVector2(vertex.texture0);
				this.texture1 = new RenderBase.OVector2(vertex.texture1);
				this.texture2 = new RenderBase.OVector2(vertex.texture2);
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00004318 File Offset: 0x00002518
			public OVertex(RenderBase.OVector3 _position, RenderBase.OVector3 _normal, RenderBase.OVector2 _texture0, uint _color)
			{
				this.node = new List<int>();
				this.weight = new List<float>();
				this.position = new RenderBase.OVector3(_position);
				this.normal = new RenderBase.OVector3(_normal);
				this.texture0 = new RenderBase.OVector2(_texture0);
				this.diffuseColor = _color;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00004370 File Offset: 0x00002570
			public bool Equals(RenderBase.OVertex vertex)
			{
				return this.position == vertex.position && this.normal == vertex.normal && this.tangent == vertex.tangent && this.texture0 == vertex.texture0 && this.texture1 == vertex.texture1 && this.texture2 == vertex.texture2 && this.node.SequenceEqual(vertex.node) && this.weight.SequenceEqual(vertex.weight) && this.diffuseColor == vertex.diffuseColor;
			}

			// Token: 0x0400000A RID: 10
			public RenderBase.OVector3 position;

			// Token: 0x0400000B RID: 11
			public RenderBase.OVector3 normal;

			// Token: 0x0400000C RID: 12
			public RenderBase.OVector3 tangent;

			// Token: 0x0400000D RID: 13
			public RenderBase.OVector2 texture0;

			// Token: 0x0400000E RID: 14
			public RenderBase.OVector2 texture1;

			// Token: 0x0400000F RID: 15
			public RenderBase.OVector2 texture2;

			// Token: 0x04000010 RID: 16
			public List<int> node;

			// Token: 0x04000011 RID: 17
			public List<float> weight;

			// Token: 0x04000012 RID: 18
			public uint diffuseColor;
		}

		// Token: 0x02000007 RID: 7
		public class OMatrix
		{
			// Token: 0x0600002D RID: 45 RVA: 0x0000442C File Offset: 0x0000262C
			public OMatrix()
			{
				this.matrix = new float[4, 4];
				this.matrix[0, 0] = 1f;
				this.matrix[1, 1] = 1f;
				this.matrix[2, 2] = 1f;
				this.matrix[3, 3] = 1f;
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600002E RID: 46 RVA: 0x000025BE File Offset: 0x000007BE
			// (set) Token: 0x0600002F RID: 47 RVA: 0x000025CD File Offset: 0x000007CD
			public float M11
			{
				get
				{
					return this.matrix[0, 0];
				}
				set
				{
					this.matrix[0, 0] = value;
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000030 RID: 48 RVA: 0x000025DD File Offset: 0x000007DD
			// (set) Token: 0x06000031 RID: 49 RVA: 0x000025EC File Offset: 0x000007EC
			public float M12
			{
				get
				{
					return this.matrix[0, 1];
				}
				set
				{
					this.matrix[0, 1] = value;
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000032 RID: 50 RVA: 0x000025FC File Offset: 0x000007FC
			// (set) Token: 0x06000033 RID: 51 RVA: 0x0000260B File Offset: 0x0000080B
			public float M13
			{
				get
				{
					return this.matrix[0, 2];
				}
				set
				{
					this.matrix[0, 2] = value;
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000034 RID: 52 RVA: 0x0000261B File Offset: 0x0000081B
			// (set) Token: 0x06000035 RID: 53 RVA: 0x0000262A File Offset: 0x0000082A
			public float M14
			{
				get
				{
					return this.matrix[0, 3];
				}
				set
				{
					this.matrix[0, 3] = value;
				}
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000036 RID: 54 RVA: 0x0000263A File Offset: 0x0000083A
			// (set) Token: 0x06000037 RID: 55 RVA: 0x00002649 File Offset: 0x00000849
			public float M21
			{
				get
				{
					return this.matrix[1, 0];
				}
				set
				{
					this.matrix[1, 0] = value;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00002659 File Offset: 0x00000859
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00002668 File Offset: 0x00000868
			public float M22
			{
				get
				{
					return this.matrix[1, 1];
				}
				set
				{
					this.matrix[1, 1] = value;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002678 File Offset: 0x00000878
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002687 File Offset: 0x00000887
			public float M23
			{
				get
				{
					return this.matrix[1, 2];
				}
				set
				{
					this.matrix[1, 2] = value;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002697 File Offset: 0x00000897
			// (set) Token: 0x0600003D RID: 61 RVA: 0x000026A6 File Offset: 0x000008A6
			public float M24
			{
				get
				{
					return this.matrix[1, 3];
				}
				set
				{
					this.matrix[1, 3] = value;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000026B6 File Offset: 0x000008B6
			// (set) Token: 0x0600003F RID: 63 RVA: 0x000026C5 File Offset: 0x000008C5
			public float M31
			{
				get
				{
					return this.matrix[2, 0];
				}
				set
				{
					this.matrix[2, 0] = value;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000040 RID: 64 RVA: 0x000026D5 File Offset: 0x000008D5
			// (set) Token: 0x06000041 RID: 65 RVA: 0x000026E4 File Offset: 0x000008E4
			public float M32
			{
				get
				{
					return this.matrix[2, 1];
				}
				set
				{
					this.matrix[2, 1] = value;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000042 RID: 66 RVA: 0x000026F4 File Offset: 0x000008F4
			// (set) Token: 0x06000043 RID: 67 RVA: 0x00002703 File Offset: 0x00000903
			public float M33
			{
				get
				{
					return this.matrix[2, 2];
				}
				set
				{
					this.matrix[2, 2] = value;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002713 File Offset: 0x00000913
			// (set) Token: 0x06000045 RID: 69 RVA: 0x00002722 File Offset: 0x00000922
			public float M34
			{
				get
				{
					return this.matrix[2, 3];
				}
				set
				{
					this.matrix[2, 3] = value;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002732 File Offset: 0x00000932
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00002741 File Offset: 0x00000941
			public float M41
			{
				get
				{
					return this.matrix[3, 0];
				}
				set
				{
					this.matrix[3, 0] = value;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000048 RID: 72 RVA: 0x00002751 File Offset: 0x00000951
			// (set) Token: 0x06000049 RID: 73 RVA: 0x00002760 File Offset: 0x00000960
			public float M42
			{
				get
				{
					return this.matrix[3, 1];
				}
				set
				{
					this.matrix[3, 1] = value;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600004A RID: 74 RVA: 0x00002770 File Offset: 0x00000970
			// (set) Token: 0x0600004B RID: 75 RVA: 0x0000277F File Offset: 0x0000097F
			public float M43
			{
				get
				{
					return this.matrix[3, 2];
				}
				set
				{
					this.matrix[3, 2] = value;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600004C RID: 76 RVA: 0x0000278F File Offset: 0x0000098F
			// (set) Token: 0x0600004D RID: 77 RVA: 0x0000279E File Offset: 0x0000099E
			public float M44
			{
				get
				{
					return this.matrix[3, 3];
				}
				set
				{
					this.matrix[3, 3] = value;
				}
			}

			// Token: 0x17000011 RID: 17
			public float this[int col, int row]
			{
				get
				{
					return this.matrix[col, row];
				}
				set
				{
					this.matrix[col, row] = value;
				}
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00004494 File Offset: 0x00002694
			public static RenderBase.OMatrix operator *(RenderBase.OMatrix a, RenderBase.OMatrix b)
			{
				RenderBase.OMatrix omatrix = new RenderBase.OMatrix();
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						float num = 0f;
						for (int k = 0; k < 4; k++)
						{
							num += a[i, k] * b[k, j];
						}
						omatrix[i, j] = num;
					}
				}
				return omatrix;
			}

			// Token: 0x06000051 RID: 81 RVA: 0x000044F8 File Offset: 0x000026F8
			public RenderBase.OMatrix invert()
			{
				float[,] array = new float[4, 8];
				for (int i = 0; i < 4; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						array[j, i] = this.matrix[j, i];
					}
				}
				for (int k = 0; k < 4; k++)
				{
					for (int l = 0; l < 4; l++)
					{
						if (k == l)
						{
							array[l, k + 4] = 1f;
						}
						else
						{
							array[l, k + 4] = 0f;
						}
					}
				}
				for (int m = 0; m < 4; m++)
				{
					if (array[m, m] == 0f)
					{
						int num = 0;
						for (int n = m; n < 4; n++)
						{
							if (array[n, m] != 0f)
							{
								num = n;
								break;
							}
						}
						for (int num2 = m; num2 < 8; num2++)
						{
							float num3 = array[m, num2];
							array[m, num2] = array[num, num2];
							array[num, num2] = num3;
						}
					}
					float num4 = array[m, m];
					for (int num5 = m; num5 < 8; num5++)
					{
						array[m, num5] /= num4;
					}
					int num6 = 0;
					while (num6 < 4 && (num6 != m || num6 != 3))
					{
						if (num6 == m && num6 < 3)
						{
							num6++;
						}
						if (array[num6, m] != 0f)
						{
							float num7 = array[num6, m] / array[m, m];
							for (int num8 = m; num8 < 8; num8++)
							{
								array[num6, num8] -= array[m, num8] * num7;
							}
						}
						num6++;
					}
				}
				return new RenderBase.OMatrix
				{
					M11 = array[0, 4],
					M12 = array[0, 5],
					M13 = array[0, 6],
					M14 = array[0, 7],
					M21 = array[1, 4],
					M22 = array[1, 5],
					M23 = array[1, 6],
					M24 = array[1, 7],
					M31 = array[2, 4],
					M32 = array[2, 5],
					M33 = array[2, 6],
					M34 = array[2, 7],
					M41 = array[3, 4],
					M42 = array[3, 5],
					M43 = array[3, 6],
					M44 = array[3, 7]
				};
			}

			// Token: 0x06000052 RID: 82 RVA: 0x000027CD File Offset: 0x000009CD
			public static RenderBase.OMatrix scale(RenderBase.OVector3 scale)
			{
				return new RenderBase.OMatrix
				{
					M11 = scale.x,
					M22 = scale.y,
					M33 = scale.z
				};
			}

			// Token: 0x06000053 RID: 83 RVA: 0x000027F8 File Offset: 0x000009F8
			public static RenderBase.OMatrix scale(RenderBase.OVector2 scale)
			{
				return new RenderBase.OMatrix
				{
					M11 = scale.x,
					M22 = scale.y
				};
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00002817 File Offset: 0x00000A17
			public static RenderBase.OMatrix scale(float scale)
			{
				return new RenderBase.OMatrix
				{
					M11 = scale,
					M22 = scale,
					M33 = scale
				};
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00002833 File Offset: 0x00000A33
			public static RenderBase.OMatrix rotateX(float angle)
			{
				return new RenderBase.OMatrix
				{
					M22 = (float)Math.Cos((double)angle),
					M32 = -(float)Math.Sin((double)angle),
					M23 = (float)Math.Sin((double)angle),
					M33 = (float)Math.Cos((double)angle)
				};
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00002873 File Offset: 0x00000A73
			public static RenderBase.OMatrix rotateY(float angle)
			{
				return new RenderBase.OMatrix
				{
					M11 = (float)Math.Cos((double)angle),
					M31 = (float)Math.Sin((double)angle),
					M13 = -(float)Math.Sin((double)angle),
					M33 = (float)Math.Cos((double)angle)
				};
			}

			// Token: 0x06000057 RID: 87 RVA: 0x000028B3 File Offset: 0x00000AB3
			public static RenderBase.OMatrix rotateZ(float angle)
			{
				return new RenderBase.OMatrix
				{
					M11 = (float)Math.Cos((double)angle),
					M21 = -(float)Math.Sin((double)angle),
					M12 = (float)Math.Sin((double)angle),
					M22 = (float)Math.Cos((double)angle)
				};
			}

			// Token: 0x06000058 RID: 88 RVA: 0x000028F3 File Offset: 0x00000AF3
			public static RenderBase.OMatrix translate(RenderBase.OVector3 position)
			{
				return new RenderBase.OMatrix
				{
					M41 = position.x,
					M42 = position.y,
					M43 = position.z
				};
			}

			// Token: 0x06000059 RID: 89 RVA: 0x0000291E File Offset: 0x00000B1E
			public static RenderBase.OMatrix translate(RenderBase.OVector2 position)
			{
				return new RenderBase.OMatrix
				{
					M31 = position.x,
					M32 = position.y
				};
			}

			// Token: 0x0600005A RID: 90 RVA: 0x000047A0 File Offset: 0x000029A0
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 4; j++)
					{
						stringBuilder.Append(string.Format("M{0}{1}: {2,-16}", i + 1, j + 1, this[j, i]));
					}
					stringBuilder.Append(Environment.NewLine);
				}
				return stringBuilder.ToString();
			}

			// Token: 0x04000013 RID: 19
			private float[,] matrix;
		}

		// Token: 0x02000008 RID: 8
		public class OOrientedBoundingBox
		{
			// Token: 0x0600005B RID: 91 RVA: 0x0000293D File Offset: 0x00000B3D
			public OOrientedBoundingBox()
			{
				this.orientationMatrix = new RenderBase.OMatrix();
			}

			// Token: 0x04000014 RID: 20
			public string name;

			// Token: 0x04000015 RID: 21
			public RenderBase.OVector3 centerPosition;

			// Token: 0x04000016 RID: 22
			public RenderBase.OMatrix orientationMatrix;

			// Token: 0x04000017 RID: 23
			public RenderBase.OVector3 size;
		}

		// Token: 0x02000009 RID: 9
		public enum OTranslucencyKind
		{
			// Token: 0x04000019 RID: 25
			opaque,
			// Token: 0x0400001A RID: 26
			translucent,
			// Token: 0x0400001B RID: 27
			subtractive,
			// Token: 0x0400001C RID: 28
			additive
		}

		// Token: 0x0200000A RID: 10
		public enum OSkinningMode
		{
			// Token: 0x0400001E RID: 30
			none,
			// Token: 0x0400001F RID: 31
			smoothSkinning,
			// Token: 0x04000020 RID: 32
			rigidSkinning
		}

		// Token: 0x0200000B RID: 11
		public class OMesh
		{
			// Token: 0x0600005C RID: 92 RVA: 0x00002950 File Offset: 0x00000B50
			public OMesh()
			{
				this.vertices = new List<RenderBase.OVertex>();
				this.boundingBox = new RenderBase.OOrientedBoundingBox();
				this.isVisible = true;
			}

			// Token: 0x04000021 RID: 33
			public List<RenderBase.OVertex> vertices;

			// Token: 0x04000022 RID: 34
			public ushort materialId;

			// Token: 0x04000023 RID: 35
			public ushort renderPriority;

			// Token: 0x04000024 RID: 36
			public string name;

			// Token: 0x04000025 RID: 37
			public bool isVisible;

			// Token: 0x04000026 RID: 38
			public RenderBase.OOrientedBoundingBox boundingBox;

			// Token: 0x04000027 RID: 39
			public bool hasNormal;

			// Token: 0x04000028 RID: 40
			public bool hasTangent;

			// Token: 0x04000029 RID: 41
			public bool hasColor;

			// Token: 0x0400002A RID: 42
			public bool hasNode;

			// Token: 0x0400002B RID: 43
			public bool hasWeight;

			// Token: 0x0400002C RID: 44
			public int texUVCount;
		}

		// Token: 0x0200000C RID: 12
		public enum OBillboardMode
		{
			// Token: 0x0400002E RID: 46
			off,
			// Token: 0x0400002F RID: 47
			world = 2,
			// Token: 0x04000030 RID: 48
			worldViewpoint,
			// Token: 0x04000031 RID: 49
			screen,
			// Token: 0x04000032 RID: 50
			screenViewpoint,
			// Token: 0x04000033 RID: 51
			yAxial,
			// Token: 0x04000034 RID: 52
			yAxialViewpoint
		}

		// Token: 0x0200000D RID: 13
		public class OBone
		{
			// Token: 0x0600005D RID: 93 RVA: 0x00002975 File Offset: 0x00000B75
			public OBone()
			{
				this.translation = new RenderBase.OVector3();
				this.rotation = new RenderBase.OVector3();
				this.scale = new RenderBase.OVector3();
				this.userData = new List<RenderBase.OMetaData>();
			}

			// Token: 0x04000035 RID: 53
			public RenderBase.OVector3 translation;

			// Token: 0x04000036 RID: 54
			public RenderBase.OVector3 rotation;

			// Token: 0x04000037 RID: 55
			public RenderBase.OVector3 scale;

			// Token: 0x04000038 RID: 56
			public RenderBase.OVector3 absoluteScale;

			// Token: 0x04000039 RID: 57
			public RenderBase.OMatrix invTransform;

			// Token: 0x0400003A RID: 58
			public short parentId;

			// Token: 0x0400003B RID: 59
			public string name;

			// Token: 0x0400003C RID: 60
			public RenderBase.OBillboardMode billboardMode;

			// Token: 0x0400003D RID: 61
			public bool isSegmentScaleCompensate;

			// Token: 0x0400003E RID: 62
			public List<RenderBase.OMetaData> userData;
		}

		// Token: 0x0200000E RID: 14
		public struct OMaterialColor
		{
			// Token: 0x0400003F RID: 63
			public Color emission;

			// Token: 0x04000040 RID: 64
			public Color ambient;

			// Token: 0x04000041 RID: 65
			public Color diffuse;

			// Token: 0x04000042 RID: 66
			public Color specular0;

			// Token: 0x04000043 RID: 67
			public Color specular1;

			// Token: 0x04000044 RID: 68
			public Color constant0;

			// Token: 0x04000045 RID: 69
			public Color constant1;

			// Token: 0x04000046 RID: 70
			public Color constant2;

			// Token: 0x04000047 RID: 71
			public Color constant3;

			// Token: 0x04000048 RID: 72
			public Color constant4;

			// Token: 0x04000049 RID: 73
			public Color constant5;

			// Token: 0x0400004A RID: 74
			public float colorScale;
		}

		// Token: 0x0200000F RID: 15
		public enum OCullMode
		{
			// Token: 0x0400004C RID: 76
			never,
			// Token: 0x0400004D RID: 77
			frontFace,
			// Token: 0x0400004E RID: 78
			backFace
		}

		// Token: 0x02000010 RID: 16
		public struct ORasterization
		{
			// Token: 0x0400004F RID: 79
			public RenderBase.OCullMode cullMode;

			// Token: 0x04000050 RID: 80
			public bool isPolygonOffsetEnabled;

			// Token: 0x04000051 RID: 81
			public float polygonOffsetUnit;
		}

		// Token: 0x02000011 RID: 17
		public enum OTextureMinFilter
		{
			// Token: 0x04000053 RID: 83
			nearestMipmapNearest = 1,
			// Token: 0x04000054 RID: 84
			nearestMipmapLinear,
			// Token: 0x04000055 RID: 85
			linearMipmapNearest = 4,
			// Token: 0x04000056 RID: 86
			linearMipmapLinear
		}

		// Token: 0x02000012 RID: 18
		public enum OTextureMagFilter
		{
			// Token: 0x04000058 RID: 88
			nearest,
			// Token: 0x04000059 RID: 89
			linear
		}

		// Token: 0x02000013 RID: 19
		public enum OTextureWrap
		{
			// Token: 0x0400005B RID: 91
			clampToEdge,
			// Token: 0x0400005C RID: 92
			clampToBorder,
			// Token: 0x0400005D RID: 93
			repeat,
			// Token: 0x0400005E RID: 94
			mirroredRepeat
		}

		// Token: 0x02000014 RID: 20
		public enum OTextureProjection
		{
			// Token: 0x04000060 RID: 96
			uvMap,
			// Token: 0x04000061 RID: 97
			cameraCubeMap,
			// Token: 0x04000062 RID: 98
			cameraSphereMap,
			// Token: 0x04000063 RID: 99
			projectionMap,
			// Token: 0x04000064 RID: 100
			shadowMap,
			// Token: 0x04000065 RID: 101
			shadowCubeMap
		}

		// Token: 0x02000015 RID: 21
		public enum OConstantColor
		{
			// Token: 0x04000067 RID: 103
			constant0,
			// Token: 0x04000068 RID: 104
			constant1,
			// Token: 0x04000069 RID: 105
			constant2,
			// Token: 0x0400006A RID: 106
			constant3,
			// Token: 0x0400006B RID: 107
			constant4,
			// Token: 0x0400006C RID: 108
			constant5,
			// Token: 0x0400006D RID: 109
			emission,
			// Token: 0x0400006E RID: 110
			ambient,
			// Token: 0x0400006F RID: 111
			diffuse,
			// Token: 0x04000070 RID: 112
			specular0,
			// Token: 0x04000071 RID: 113
			specular1
		}

		// Token: 0x02000016 RID: 22
		public enum OCombineOperator
		{
			// Token: 0x04000073 RID: 115
			replace,
			// Token: 0x04000074 RID: 116
			modulate,
			// Token: 0x04000075 RID: 117
			add,
			// Token: 0x04000076 RID: 118
			addSigned,
			// Token: 0x04000077 RID: 119
			interpolate,
			// Token: 0x04000078 RID: 120
			subtract,
			// Token: 0x04000079 RID: 121
			dot3Rgb,
			// Token: 0x0400007A RID: 122
			dot3Rgba,
			// Token: 0x0400007B RID: 123
			multiplyAdd,
			// Token: 0x0400007C RID: 124
			addMultiply
		}

		// Token: 0x02000017 RID: 23
		public enum OCombineSource
		{
			// Token: 0x0400007E RID: 126
			primaryColor,
			// Token: 0x0400007F RID: 127
			fragmentPrimaryColor,
			// Token: 0x04000080 RID: 128
			fragmentSecondaryColor,
			// Token: 0x04000081 RID: 129
			texture0,
			// Token: 0x04000082 RID: 130
			texture1,
			// Token: 0x04000083 RID: 131
			texture2,
			// Token: 0x04000084 RID: 132
			texture3,
			// Token: 0x04000085 RID: 133
			previousBuffer = 13,
			// Token: 0x04000086 RID: 134
			constant,
			// Token: 0x04000087 RID: 135
			previous
		}

		// Token: 0x02000018 RID: 24
		public enum OCombineOperandRgb
		{
			// Token: 0x04000089 RID: 137
			color,
			// Token: 0x0400008A RID: 138
			oneMinusColor,
			// Token: 0x0400008B RID: 139
			alpha,
			// Token: 0x0400008C RID: 140
			oneMinusAlpha,
			// Token: 0x0400008D RID: 141
			red,
			// Token: 0x0400008E RID: 142
			oneMinusRed,
			// Token: 0x0400008F RID: 143
			green = 8,
			// Token: 0x04000090 RID: 144
			oneMinusGreen,
			// Token: 0x04000091 RID: 145
			blue = 12,
			// Token: 0x04000092 RID: 146
			oneMinusBlue
		}

		// Token: 0x02000019 RID: 25
		public enum OCombineOperandAlpha
		{
			// Token: 0x04000094 RID: 148
			alpha,
			// Token: 0x04000095 RID: 149
			oneMinusAlpha,
			// Token: 0x04000096 RID: 150
			red,
			// Token: 0x04000097 RID: 151
			oneMinusRed,
			// Token: 0x04000098 RID: 152
			green,
			// Token: 0x04000099 RID: 153
			oneMinusGreen,
			// Token: 0x0400009A RID: 154
			blue,
			// Token: 0x0400009B RID: 155
			oneMinusBlue
		}

		// Token: 0x0200001A RID: 26
		public struct OTextureCoordinator
		{
			// Token: 0x0400009C RID: 156
			public RenderBase.OTextureProjection projection;

			// Token: 0x0400009D RID: 157
			public uint referenceCamera;

			// Token: 0x0400009E RID: 158
			public float scaleU;

			// Token: 0x0400009F RID: 159
			public float scaleV;

			// Token: 0x040000A0 RID: 160
			public float rotate;

			// Token: 0x040000A1 RID: 161
			public float translateU;

			// Token: 0x040000A2 RID: 162
			public float translateV;
		}

		// Token: 0x0200001B RID: 27
		public struct OTextureMapper
		{
			// Token: 0x040000A3 RID: 163
			public RenderBase.OTextureMinFilter minFilter;

			// Token: 0x040000A4 RID: 164
			public RenderBase.OTextureMagFilter magFilter;

			// Token: 0x040000A5 RID: 165
			public RenderBase.OTextureWrap wrapU;

			// Token: 0x040000A6 RID: 166
			public RenderBase.OTextureWrap wrapV;

			// Token: 0x040000A7 RID: 167
			public uint minLOD;

			// Token: 0x040000A8 RID: 168
			public float LODBias;

			// Token: 0x040000A9 RID: 169
			public Color borderColor;
		}

		// Token: 0x0200001C RID: 28
		public enum OBumpTexture
		{
			// Token: 0x040000AB RID: 171
			texture0,
			// Token: 0x040000AC RID: 172
			texture1,
			// Token: 0x040000AD RID: 173
			texture2,
			// Token: 0x040000AE RID: 174
			texture3
		}

		// Token: 0x0200001D RID: 29
		public enum OBumpMode
		{
			// Token: 0x040000B0 RID: 176
			notUsed,
			// Token: 0x040000B1 RID: 177
			asBump,
			// Token: 0x040000B2 RID: 178
			asTangent
		}

		// Token: 0x0200001E RID: 30
		public struct OFragmentBump
		{
			// Token: 0x040000B3 RID: 179
			public RenderBase.OBumpTexture texture;

			// Token: 0x040000B4 RID: 180
			public RenderBase.OBumpMode mode;

			// Token: 0x040000B5 RID: 181
			public bool isBumpRenormalize;
		}

		// Token: 0x0200001F RID: 31
		public enum OFresnelConfig
		{
			// Token: 0x040000B7 RID: 183
			none,
			// Token: 0x040000B8 RID: 184
			primary,
			// Token: 0x040000B9 RID: 185
			secondary,
			// Token: 0x040000BA RID: 186
			primarySecondary
		}

		// Token: 0x02000020 RID: 32
		public enum OFragmentSamplerInput
		{
			// Token: 0x040000BC RID: 188
			halfNormalCosine,
			// Token: 0x040000BD RID: 189
			halfViewCosine,
			// Token: 0x040000BE RID: 190
			viewNormalCosine,
			// Token: 0x040000BF RID: 191
			normalLightCosine,
			// Token: 0x040000C0 RID: 192
			spotLightCosine,
			// Token: 0x040000C1 RID: 193
			phiCosine
		}

		// Token: 0x02000021 RID: 33
		public enum OFragmentSamplerScale
		{
			// Token: 0x040000C3 RID: 195
			one,
			// Token: 0x040000C4 RID: 196
			two,
			// Token: 0x040000C5 RID: 197
			four,
			// Token: 0x040000C6 RID: 198
			eight,
			// Token: 0x040000C7 RID: 199
			quarter = 6,
			// Token: 0x040000C8 RID: 200
			half
		}

		// Token: 0x02000022 RID: 34
		public struct OFragmentSampler
		{
			// Token: 0x040000C9 RID: 201
			public bool isAbsolute;

			// Token: 0x040000CA RID: 202
			public RenderBase.OFragmentSamplerInput input;

			// Token: 0x040000CB RID: 203
			public RenderBase.OFragmentSamplerScale scale;

			// Token: 0x040000CC RID: 204
			public string samplerName;

			// Token: 0x040000CD RID: 205
			public string tableName;
		}

		// Token: 0x02000023 RID: 35
		public struct OFragmentLighting
		{
			// Token: 0x040000CE RID: 206
			public RenderBase.OFresnelConfig fresnelConfig;

			// Token: 0x040000CF RID: 207
			public bool isClampHighLight;

			// Token: 0x040000D0 RID: 208
			public bool isDistribution0Enabled;

			// Token: 0x040000D1 RID: 209
			public bool isDistribution1Enabled;

			// Token: 0x040000D2 RID: 210
			public bool isGeometryFactor0Enabled;

			// Token: 0x040000D3 RID: 211
			public bool isGeometryFactor1Enabled;

			// Token: 0x040000D4 RID: 212
			public bool isReflectionEnabled;

			// Token: 0x040000D5 RID: 213
			public RenderBase.OFragmentSampler reflectanceRSampler;

			// Token: 0x040000D6 RID: 214
			public RenderBase.OFragmentSampler reflectanceGSampler;

			// Token: 0x040000D7 RID: 215
			public RenderBase.OFragmentSampler reflectanceBSampler;

			// Token: 0x040000D8 RID: 216
			public RenderBase.OFragmentSampler distribution0Sampler;

			// Token: 0x040000D9 RID: 217
			public RenderBase.OFragmentSampler distribution1Sampler;

			// Token: 0x040000DA RID: 218
			public RenderBase.OFragmentSampler fresnelSampler;
		}

		// Token: 0x02000024 RID: 36
		public class OTextureCombiner
		{
			// Token: 0x0600005E RID: 94 RVA: 0x000029A9 File Offset: 0x00000BA9
			public OTextureCombiner()
			{
				this.rgbSource = new RenderBase.OCombineSource[3];
				this.rgbOperand = new RenderBase.OCombineOperandRgb[3];
				this.alphaSource = new RenderBase.OCombineSource[3];
				this.alphaOperand = new RenderBase.OCombineOperandAlpha[3];
			}

			// Token: 0x040000DB RID: 219
			public ushort rgbScale;

			// Token: 0x040000DC RID: 220
			public ushort alphaScale;

			// Token: 0x040000DD RID: 221
			public RenderBase.OConstantColor constantColor;

			// Token: 0x040000DE RID: 222
			public RenderBase.OCombineOperator combineRgb;

			// Token: 0x040000DF RID: 223
			public RenderBase.OCombineOperator combineAlpha;

			// Token: 0x040000E0 RID: 224
			public RenderBase.OCombineSource[] rgbSource;

			// Token: 0x040000E1 RID: 225
			public RenderBase.OCombineOperandRgb[] rgbOperand;

			// Token: 0x040000E2 RID: 226
			public RenderBase.OCombineSource[] alphaSource;

			// Token: 0x040000E3 RID: 227
			public RenderBase.OCombineOperandAlpha[] alphaOperand;
		}

		// Token: 0x02000025 RID: 37
		public struct OAlphaTest
		{
			// Token: 0x040000E4 RID: 228
			public bool isTestEnabled;

			// Token: 0x040000E5 RID: 229
			public RenderBase.OTestFunction testFunction;

			// Token: 0x040000E6 RID: 230
			public uint testReference;
		}

		// Token: 0x02000026 RID: 38
		public class OFragmentShader
		{
			// Token: 0x0600005F RID: 95 RVA: 0x0000480C File Offset: 0x00002A0C
			public OFragmentShader()
			{
				this.textureCombiner = new RenderBase.OTextureCombiner[6];
				for (int i = 0; i < 6; i++)
				{
					this.textureCombiner[i] = new RenderBase.OTextureCombiner();
				}
			}

			// Token: 0x040000E7 RID: 231
			public uint layerConfig;

			// Token: 0x040000E8 RID: 232
			public Color bufferColor;

			// Token: 0x040000E9 RID: 233
			public RenderBase.OFragmentBump bump;

			// Token: 0x040000EA RID: 234
			public RenderBase.OFragmentLighting lighting;

			// Token: 0x040000EB RID: 235
			public RenderBase.OTextureCombiner[] textureCombiner;

			// Token: 0x040000EC RID: 236
			public RenderBase.OAlphaTest alphaTest;
		}

		// Token: 0x02000027 RID: 39
		public enum OTestFunction
		{
			// Token: 0x040000EE RID: 238
			never,
			// Token: 0x040000EF RID: 239
			always,
			// Token: 0x040000F0 RID: 240
			equal,
			// Token: 0x040000F1 RID: 241
			notEqual,
			// Token: 0x040000F2 RID: 242
			less,
			// Token: 0x040000F3 RID: 243
			lessOrEqual,
			// Token: 0x040000F4 RID: 244
			greater,
			// Token: 0x040000F5 RID: 245
			greaterOrEqual
		}

		// Token: 0x02000028 RID: 40
		public struct ODepthOperation
		{
			// Token: 0x040000F6 RID: 246
			public bool isTestEnabled;

			// Token: 0x040000F7 RID: 247
			public RenderBase.OTestFunction testFunction;

			// Token: 0x040000F8 RID: 248
			public bool isMaskEnabled;
		}

		// Token: 0x02000029 RID: 41
		public enum OBlendMode
		{
			// Token: 0x040000FA RID: 250
			logical,
			// Token: 0x040000FB RID: 251
			notUsed = 2,
			// Token: 0x040000FC RID: 252
			blend
		}

		// Token: 0x0200002A RID: 42
		public enum OLogicalOperation
		{
			// Token: 0x040000FE RID: 254
			clear,
			// Token: 0x040000FF RID: 255
			and,
			// Token: 0x04000100 RID: 256
			andReverse,
			// Token: 0x04000101 RID: 257
			copy,
			// Token: 0x04000102 RID: 258
			set,
			// Token: 0x04000103 RID: 259
			copyInverted,
			// Token: 0x04000104 RID: 260
			noOperation,
			// Token: 0x04000105 RID: 261
			invert,
			// Token: 0x04000106 RID: 262
			notAnd,
			// Token: 0x04000107 RID: 263
			or,
			// Token: 0x04000108 RID: 264
			notOr,
			// Token: 0x04000109 RID: 265
			exclusiveOr,
			// Token: 0x0400010A RID: 266
			equiv,
			// Token: 0x0400010B RID: 267
			andInverted,
			// Token: 0x0400010C RID: 268
			orReverse,
			// Token: 0x0400010D RID: 269
			orInverted
		}

		// Token: 0x0200002B RID: 43
		public enum OBlendFunction
		{
			// Token: 0x0400010F RID: 271
			zero,
			// Token: 0x04000110 RID: 272
			one,
			// Token: 0x04000111 RID: 273
			sourceColor,
			// Token: 0x04000112 RID: 274
			oneMinusSourceColor,
			// Token: 0x04000113 RID: 275
			destinationColor,
			// Token: 0x04000114 RID: 276
			oneMinusDestinationColor,
			// Token: 0x04000115 RID: 277
			sourceAlpha,
			// Token: 0x04000116 RID: 278
			oneMinusSourceAlpha,
			// Token: 0x04000117 RID: 279
			destinationAlpha,
			// Token: 0x04000118 RID: 280
			oneMinusDestinationAlpha,
			// Token: 0x04000119 RID: 281
			constantColor,
			// Token: 0x0400011A RID: 282
			oneMinusConstantColor,
			// Token: 0x0400011B RID: 283
			constantAlpha,
			// Token: 0x0400011C RID: 284
			oneMinusConstantAlpha,
			// Token: 0x0400011D RID: 285
			sourceAlphaSaturate
		}

		// Token: 0x0200002C RID: 44
		public enum OBlendEquation
		{
			// Token: 0x0400011F RID: 287
			add,
			// Token: 0x04000120 RID: 288
			subtract,
			// Token: 0x04000121 RID: 289
			reverseSubtract,
			// Token: 0x04000122 RID: 290
			min,
			// Token: 0x04000123 RID: 291
			max
		}

		// Token: 0x0200002D RID: 45
		public struct OBlendOperation
		{
			// Token: 0x04000124 RID: 292
			public RenderBase.OBlendMode mode;

			// Token: 0x04000125 RID: 293
			public RenderBase.OLogicalOperation logicalOperation;

			// Token: 0x04000126 RID: 294
			public RenderBase.OBlendFunction rgbFunctionSource;

			// Token: 0x04000127 RID: 295
			public RenderBase.OBlendFunction rgbFunctionDestination;

			// Token: 0x04000128 RID: 296
			public RenderBase.OBlendEquation rgbBlendEquation;

			// Token: 0x04000129 RID: 297
			public RenderBase.OBlendFunction alphaFunctionSource;

			// Token: 0x0400012A RID: 298
			public RenderBase.OBlendFunction alphaFunctionDestination;

			// Token: 0x0400012B RID: 299
			public RenderBase.OBlendEquation alphaBlendEquation;

			// Token: 0x0400012C RID: 300
			public Color blendColor;
		}

		// Token: 0x0200002E RID: 46
		public enum OStencilOp
		{
			// Token: 0x0400012E RID: 302
			keep,
			// Token: 0x0400012F RID: 303
			zero,
			// Token: 0x04000130 RID: 304
			replace,
			// Token: 0x04000131 RID: 305
			increase,
			// Token: 0x04000132 RID: 306
			decrease,
			// Token: 0x04000133 RID: 307
			increaseWrap,
			// Token: 0x04000134 RID: 308
			decreaseWrap
		}

		// Token: 0x0200002F RID: 47
		public struct OStencilOperation
		{
			// Token: 0x04000135 RID: 309
			public bool isTestEnabled;

			// Token: 0x04000136 RID: 310
			public RenderBase.OTestFunction testFunction;

			// Token: 0x04000137 RID: 311
			public uint testReference;

			// Token: 0x04000138 RID: 312
			public uint testMask;

			// Token: 0x04000139 RID: 313
			public RenderBase.OStencilOp failOperation;

			// Token: 0x0400013A RID: 314
			public RenderBase.OStencilOp zFailOperation;

			// Token: 0x0400013B RID: 315
			public RenderBase.OStencilOp passOperation;
		}

		// Token: 0x02000030 RID: 48
		public struct OFragmentOperation
		{
			// Token: 0x0400013C RID: 316
			public RenderBase.ODepthOperation depth;

			// Token: 0x0400013D RID: 317
			public RenderBase.OBlendOperation blend;

			// Token: 0x0400013E RID: 318
			public RenderBase.OStencilOperation stencil;
		}

		// Token: 0x02000031 RID: 49
		public class OReference
		{
			// Token: 0x06000060 RID: 96 RVA: 0x000029E1 File Offset: 0x00000BE1
			public OReference(string _id, string _name)
			{
				this.id = _id;
				this.name = _name;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00004844 File Offset: 0x00002A44
			public OReference(string _name)
			{
				if (_name == null)
				{
					return;
				}
				if (_name.Contains("@"))
				{
					string[] array = _name.Split(new char[]
					{
						Convert.ToChar("@")
					});
					this.id = array[0];
					this.name = array[1];
					return;
				}
				this.name = _name;
			}

			// Token: 0x06000062 RID: 98 RVA: 0x000021D7 File Offset: 0x000003D7
			public OReference()
			{
			}

			// Token: 0x06000063 RID: 99 RVA: 0x000029F7 File Offset: 0x00000BF7
			public override string ToString()
			{
				return this.id + "@" + this.name;
			}

			// Token: 0x0400013F RID: 319
			public string id;

			// Token: 0x04000140 RID: 320
			public string name;
		}

		// Token: 0x02000032 RID: 50
		public class OMaterial
		{
			// Token: 0x06000064 RID: 100 RVA: 0x0000489C File Offset: 0x00002A9C
			public OMaterial()
			{
				this.userData = new List<RenderBase.OMetaData>();
				this.textureCoordinator = new RenderBase.OTextureCoordinator[3];
				this.textureMapper = new RenderBase.OTextureMapper[3];
				this.fragmentShader = new RenderBase.OFragmentShader();
				this.name = "material";
				this.fragmentShader.alphaTest.isTestEnabled = true;
				this.fragmentShader.alphaTest.testFunction = RenderBase.OTestFunction.greater;
				this.textureMapper[0].wrapU = RenderBase.OTextureWrap.repeat;
				this.textureMapper[0].wrapV = RenderBase.OTextureWrap.repeat;
				this.textureMapper[0].minFilter = RenderBase.OTextureMinFilter.linearMipmapLinear;
				this.textureMapper[0].magFilter = RenderBase.OTextureMagFilter.linear;
				for (int i = 0; i < 6; i++)
				{
					this.fragmentShader.textureCombiner[i].rgbSource[0] = RenderBase.OCombineSource.texture0;
					this.fragmentShader.textureCombiner[i].rgbSource[1] = RenderBase.OCombineSource.primaryColor;
					this.fragmentShader.textureCombiner[i].combineRgb = RenderBase.OCombineOperator.modulate;
					this.fragmentShader.textureCombiner[i].alphaSource[0] = RenderBase.OCombineSource.texture0;
					this.fragmentShader.textureCombiner[i].rgbScale = 1;
					this.fragmentShader.textureCombiner[i].alphaScale = 1;
				}
				this.fragmentOperation.depth.isTestEnabled = true;
				this.fragmentOperation.depth.testFunction = RenderBase.OTestFunction.lessOrEqual;
				this.fragmentOperation.depth.isMaskEnabled = true;
			}

			// Token: 0x04000141 RID: 321
			public string name;

			// Token: 0x04000142 RID: 322
			public string name0;

			// Token: 0x04000143 RID: 323
			public string name1;

			// Token: 0x04000144 RID: 324
			public string name2;

			// Token: 0x04000145 RID: 325
			public RenderBase.OReference shaderReference;

			// Token: 0x04000146 RID: 326
			public RenderBase.OReference modelReference;

			// Token: 0x04000147 RID: 327
			public List<RenderBase.OMetaData> userData;

			// Token: 0x04000148 RID: 328
			public RenderBase.OMaterialColor materialColor;

			// Token: 0x04000149 RID: 329
			public RenderBase.ORasterization rasterization;

			// Token: 0x0400014A RID: 330
			public RenderBase.OTextureCoordinator[] textureCoordinator;

			// Token: 0x0400014B RID: 331
			public RenderBase.OTextureMapper[] textureMapper;

			// Token: 0x0400014C RID: 332
			public RenderBase.OFragmentShader fragmentShader;

			// Token: 0x0400014D RID: 333
			public RenderBase.OFragmentOperation fragmentOperation;

			// Token: 0x0400014E RID: 334
			public uint lightSetIndex;

			// Token: 0x0400014F RID: 335
			public uint fogIndex;

			// Token: 0x04000150 RID: 336
			public bool isFragmentLightEnabled;

			// Token: 0x04000151 RID: 337
			public bool isVertexLightEnabled;

			// Token: 0x04000152 RID: 338
			public bool isHemiSphereLightEnabled;

			// Token: 0x04000153 RID: 339
			public bool isHemiSphereOcclusionEnabled;

			// Token: 0x04000154 RID: 340
			public bool isFogEnabled;
		}

		// Token: 0x02000033 RID: 51
		public enum OMetaDataValueType
		{
			// Token: 0x04000156 RID: 342
			integer,
			// Token: 0x04000157 RID: 343
			single,
			// Token: 0x04000158 RID: 344
			utf8String,
			// Token: 0x04000159 RID: 345
			utf16String
		}

		// Token: 0x02000034 RID: 52
		public class OMetaData
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00002A0F File Offset: 0x00000C0F
			public OMetaData()
			{
				this.values = new List<object>();
			}

			// Token: 0x0400015A RID: 346
			public string name;

			// Token: 0x0400015B RID: 347
			public RenderBase.OMetaDataValueType type;

			// Token: 0x0400015C RID: 348
			public List<object> values;
		}

		// Token: 0x02000035 RID: 53
		public enum OModelCullingMode
		{
			// Token: 0x0400015E RID: 350
			dynamic,
			// Token: 0x0400015F RID: 351
			always,
			// Token: 0x04000160 RID: 352
			never
		}

		// Token: 0x02000036 RID: 54
		public class OModel
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00004A0C File Offset: 0x00002C0C
			public int verticesCount
			{
				get
				{
					int num = 0;
					foreach (RenderBase.OMesh omesh in this.mesh)
					{
						num += omesh.vertices.Count;
					}
					return num;
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00004A6C File Offset: 0x00002C6C
			public OModel()
			{
				this.mesh = new List<RenderBase.OMesh>();
				this.skeleton = new List<RenderBase.OBone>();
				this.material = new List<RenderBase.OMaterial>();
				this.userData = new List<RenderBase.OMetaData>();
				this.transform = new RenderBase.OMatrix();
				this.minVector = new RenderBase.OVector3();
				this.maxVector = new RenderBase.OVector3();
			}

			// Token: 0x04000161 RID: 353
			public string name;

			// Token: 0x04000162 RID: 354
			public uint layerId;

			// Token: 0x04000163 RID: 355
			public List<RenderBase.OMesh> mesh;

			// Token: 0x04000164 RID: 356
			public List<RenderBase.OBone> skeleton;

			// Token: 0x04000165 RID: 357
			public List<RenderBase.OMaterial> material;

			// Token: 0x04000166 RID: 358
			public List<RenderBase.OMetaData> userData;

			// Token: 0x04000167 RID: 359
			public RenderBase.OMatrix transform;

			// Token: 0x04000168 RID: 360
			public RenderBase.OVector3 minVector;

			// Token: 0x04000169 RID: 361
			public RenderBase.OVector3 maxVector;
		}

		// Token: 0x02000037 RID: 55
		public enum OTextureFormat
		{
			// Token: 0x0400016B RID: 363
			rgba8,
			// Token: 0x0400016C RID: 364
			rgb8,
			// Token: 0x0400016D RID: 365
			rgba5551,
			// Token: 0x0400016E RID: 366
			rgb565,
			// Token: 0x0400016F RID: 367
			rgba4,
			// Token: 0x04000170 RID: 368
			la8,
			// Token: 0x04000171 RID: 369
			hilo8,
			// Token: 0x04000172 RID: 370
			l8,
			// Token: 0x04000173 RID: 371
			a8,
			// Token: 0x04000174 RID: 372
			la4,
			// Token: 0x04000175 RID: 373
			l4,
			// Token: 0x04000176 RID: 374
			a4,
			// Token: 0x04000177 RID: 375
			etc1,
			// Token: 0x04000178 RID: 376
			etc1a4,
			// Token: 0x04000179 RID: 377
			dontCare
		}

		// Token: 0x02000038 RID: 56
		public class OTexture
		{
			// Token: 0x06000068 RID: 104 RVA: 0x00002A22 File Offset: 0x00000C22
			public OTexture(Bitmap _texture, string _name)
			{
				this.texture = new Bitmap(_texture);
				_texture.Dispose();
				this.name = _name;
			}

			// Token: 0x0400017A RID: 378
			public Bitmap texture;

			// Token: 0x0400017B RID: 379
			public string name;
		}

		// Token: 0x02000039 RID: 57
		public class OLookUpTableSampler
		{
			// Token: 0x06000069 RID: 105 RVA: 0x00002A43 File Offset: 0x00000C43
			public OLookUpTableSampler()
			{
				this.table = new float[256];
			}

			// Token: 0x0400017C RID: 380
			public string name;

			// Token: 0x0400017D RID: 381
			public float[] table;
		}

		// Token: 0x0200003A RID: 58
		public class OLookUpTable
		{
			// Token: 0x0600006A RID: 106 RVA: 0x00002A5B File Offset: 0x00000C5B
			public OLookUpTable()
			{
				this.sampler = new List<RenderBase.OLookUpTableSampler>();
			}

			// Token: 0x0400017E RID: 382
			public string name;

			// Token: 0x0400017F RID: 383
			public List<RenderBase.OLookUpTableSampler> sampler;
		}

		// Token: 0x0200003B RID: 59
		public enum OLightType
		{
			// Token: 0x04000181 RID: 385
			directional,
			// Token: 0x04000182 RID: 386
			point,
			// Token: 0x04000183 RID: 387
			spot
		}

		// Token: 0x0200003C RID: 60
		public enum OLightUse
		{
			// Token: 0x04000185 RID: 389
			hemiSphere,
			// Token: 0x04000186 RID: 390
			vertex,
			// Token: 0x04000187 RID: 391
			fragment,
			// Token: 0x04000188 RID: 392
			ambient
		}

		// Token: 0x0200003D RID: 61
		public class OLight
		{
			// Token: 0x04000189 RID: 393
			public string name;

			// Token: 0x0400018A RID: 394
			public RenderBase.OVector3 transformScale;

			// Token: 0x0400018B RID: 395
			public RenderBase.OVector3 transformRotate;

			// Token: 0x0400018C RID: 396
			public RenderBase.OVector3 transformTranslate;

			// Token: 0x0400018D RID: 397
			public Color ambient;

			// Token: 0x0400018E RID: 398
			public Color diffuse;

			// Token: 0x0400018F RID: 399
			public Color specular0;

			// Token: 0x04000190 RID: 400
			public Color specular1;

			// Token: 0x04000191 RID: 401
			public RenderBase.OVector3 direction;

			// Token: 0x04000192 RID: 402
			public float attenuationStart;

			// Token: 0x04000193 RID: 403
			public float attenuationEnd;

			// Token: 0x04000194 RID: 404
			public bool isLightEnabled;

			// Token: 0x04000195 RID: 405
			public bool isTwoSideDiffuse;

			// Token: 0x04000196 RID: 406
			public bool isDistanceAttenuationEnabled;

			// Token: 0x04000197 RID: 407
			public RenderBase.OLightType lightType;

			// Token: 0x04000198 RID: 408
			public RenderBase.OLightUse lightUse;

			// Token: 0x04000199 RID: 409
			public float distanceAttenuationConstant;

			// Token: 0x0400019A RID: 410
			public float distanceAttenuationLinear;

			// Token: 0x0400019B RID: 411
			public float distanceAttenuationQuadratic;

			// Token: 0x0400019C RID: 412
			public float spotExponent;

			// Token: 0x0400019D RID: 413
			public float spotCutoffAngle;

			// Token: 0x0400019E RID: 414
			public Color groundColor;

			// Token: 0x0400019F RID: 415
			public Color skyColor;

			// Token: 0x040001A0 RID: 416
			public float lerpFactor;

			// Token: 0x040001A1 RID: 417
			public RenderBase.OFragmentSampler angleSampler;

			// Token: 0x040001A2 RID: 418
			public RenderBase.OFragmentSampler distanceSampler;
		}

		// Token: 0x0200003E RID: 62
		public enum OCameraView
		{
			// Token: 0x040001A4 RID: 420
			aimTarget,
			// Token: 0x040001A5 RID: 421
			lookAtTarget,
			// Token: 0x040001A6 RID: 422
			rotate
		}

		// Token: 0x0200003F RID: 63
		public enum OCameraProjection
		{
			// Token: 0x040001A8 RID: 424
			perspective,
			// Token: 0x040001A9 RID: 425
			orthogonal
		}

		// Token: 0x02000040 RID: 64
		public class OCamera
		{
			// Token: 0x040001AA RID: 426
			public string name;

			// Token: 0x040001AB RID: 427
			public RenderBase.OVector3 transformScale;

			// Token: 0x040001AC RID: 428
			public RenderBase.OVector3 transformRotate;

			// Token: 0x040001AD RID: 429
			public RenderBase.OVector3 transformTranslate;

			// Token: 0x040001AE RID: 430
			public RenderBase.OVector3 target;

			// Token: 0x040001AF RID: 431
			public RenderBase.OVector3 rotation;

			// Token: 0x040001B0 RID: 432
			public RenderBase.OVector3 upVector;

			// Token: 0x040001B1 RID: 433
			public float twist;

			// Token: 0x040001B2 RID: 434
			public RenderBase.OCameraView view;

			// Token: 0x040001B3 RID: 435
			public RenderBase.OCameraProjection projection;

			// Token: 0x040001B4 RID: 436
			public float zNear;

			// Token: 0x040001B5 RID: 437
			public float zFar;

			// Token: 0x040001B6 RID: 438
			public float fieldOfViewY;

			// Token: 0x040001B7 RID: 439
			public float height;

			// Token: 0x040001B8 RID: 440
			public float aspectRatio;

			// Token: 0x040001B9 RID: 441
			public bool isInheritingTargetRotate;

			// Token: 0x040001BA RID: 442
			public bool isInheritingTargetTranslate;

			// Token: 0x040001BB RID: 443
			public bool isInheritingUpRotate;
		}

		// Token: 0x02000041 RID: 65
		public enum OFogUpdater
		{
			// Token: 0x040001BD RID: 445
			linear,
			// Token: 0x040001BE RID: 446
			exponent,
			// Token: 0x040001BF RID: 447
			exponentSquare
		}

		// Token: 0x02000042 RID: 66
		public class OFog
		{
			// Token: 0x040001C0 RID: 448
			public string name;

			// Token: 0x040001C1 RID: 449
			public RenderBase.OVector3 transformScale;

			// Token: 0x040001C2 RID: 450
			public RenderBase.OVector3 transformRotate;

			// Token: 0x040001C3 RID: 451
			public RenderBase.OVector3 transformTranslate;

			// Token: 0x040001C4 RID: 452
			public Color fogColor;

			// Token: 0x040001C5 RID: 453
			public RenderBase.OFogUpdater fogUpdater;

			// Token: 0x040001C6 RID: 454
			public float minFogDepth;

			// Token: 0x040001C7 RID: 455
			public float maxFogDepth;

			// Token: 0x040001C8 RID: 456
			public float fogDensity;

			// Token: 0x040001C9 RID: 457
			public bool isZFlip;

			// Token: 0x040001CA RID: 458
			public bool isAttenuateDistance;
		}

		// Token: 0x02000043 RID: 67
		public enum ORepeatMethod
		{
			// Token: 0x040001CC RID: 460
			none,
			// Token: 0x040001CD RID: 461
			repeat,
			// Token: 0x040001CE RID: 462
			mirror,
			// Token: 0x040001CF RID: 463
			relativeRepeat
		}

		// Token: 0x02000044 RID: 68
		public class OAnimationKeyFrame
		{
			// Token: 0x0600006E RID: 110 RVA: 0x00002A6E File Offset: 0x00000C6E
			public OAnimationKeyFrame(float _value, float _inSlope, float _outSlope, float _frame)
			{
				this.value = _value;
				this.inSlope = _inSlope;
				this.outSlope = _outSlope;
				this.frame = _frame;
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00002A93 File Offset: 0x00000C93
			public OAnimationKeyFrame(float _value, float _frame)
			{
				this.value = _value;
				this.frame = _frame;
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002AA9 File Offset: 0x00000CA9
			public OAnimationKeyFrame(bool _value, float _frame)
			{
				this.bValue = _value;
				this.frame = _frame;
			}

			// Token: 0x06000071 RID: 113 RVA: 0x000021D7 File Offset: 0x000003D7
			public OAnimationKeyFrame()
			{
			}

			// Token: 0x06000072 RID: 114 RVA: 0x00004ACC File Offset: 0x00002CCC
			public override string ToString()
			{
				return string.Format("Frame:{0}; Value (float):{1}; Value (boolean):{2}; InSlope:{3}; OutSlope:{4}", new object[]
				{
					this.frame,
					this.value,
					this.bValue,
					this.inSlope,
					this.outSlope
				});
			}

			// Token: 0x040001D0 RID: 464
			public float frame;

			// Token: 0x040001D1 RID: 465
			public float value;

			// Token: 0x040001D2 RID: 466
			public float inSlope;

			// Token: 0x040001D3 RID: 467
			public float outSlope;

			// Token: 0x040001D4 RID: 468
			public bool bValue;
		}

		// Token: 0x02000045 RID: 69
		public enum OInterpolationMode
		{
			// Token: 0x040001D6 RID: 470
			step,
			// Token: 0x040001D7 RID: 471
			linear,
			// Token: 0x040001D8 RID: 472
			hermite
		}

		// Token: 0x02000046 RID: 70
		public class OAnimationKeyFrameGroup
		{
			// Token: 0x06000073 RID: 115 RVA: 0x00002ABF File Offset: 0x00000CBF
			public OAnimationKeyFrameGroup()
			{
				this.keyFrames = new List<RenderBase.OAnimationKeyFrame>();
			}

			// Token: 0x040001D9 RID: 473
			public List<RenderBase.OAnimationKeyFrame> keyFrames;

			// Token: 0x040001DA RID: 474
			public RenderBase.OInterpolationMode interpolation;

			// Token: 0x040001DB RID: 475
			public float startFrame;

			// Token: 0x040001DC RID: 476
			public float endFrame;

			// Token: 0x040001DD RID: 477
			public bool exists;

			// Token: 0x040001DE RID: 478
			public bool defaultValue;

			// Token: 0x040001DF RID: 479
			public RenderBase.ORepeatMethod preRepeat;

			// Token: 0x040001E0 RID: 480
			public RenderBase.ORepeatMethod postRepeat;
		}

		// Token: 0x02000047 RID: 71
		public class OAnimationFrame
		{
			// Token: 0x06000074 RID: 116 RVA: 0x00002AD2 File Offset: 0x00000CD2
			public OAnimationFrame()
			{
				this.vector = new List<RenderBase.OVector4>();
			}

			// Token: 0x040001E1 RID: 481
			public List<RenderBase.OVector4> vector;

			// Token: 0x040001E2 RID: 482
			public float startFrame;

			// Token: 0x040001E3 RID: 483
			public float endFrame;

			// Token: 0x040001E4 RID: 484
			public bool exists;

			// Token: 0x040001E5 RID: 485
			public RenderBase.ORepeatMethod preRepeat;

			// Token: 0x040001E6 RID: 486
			public RenderBase.ORepeatMethod postRepeat;
		}

		// Token: 0x02000048 RID: 72
		public enum OSegmentType
		{
			// Token: 0x040001E8 RID: 488
			single,
			// Token: 0x040001E9 RID: 489
			vector2 = 2,
			// Token: 0x040001EA RID: 490
			vector3,
			// Token: 0x040001EB RID: 491
			transform,
			// Token: 0x040001EC RID: 492
			rgbaColor,
			// Token: 0x040001ED RID: 493
			integer,
			// Token: 0x040001EE RID: 494
			transformQuaternion,
			// Token: 0x040001EF RID: 495
			boolean,
			// Token: 0x040001F0 RID: 496
			transformMatrix
		}

		// Token: 0x02000049 RID: 73
		public enum OSegmentQuantization
		{
			// Token: 0x040001F2 RID: 498
			hermite128,
			// Token: 0x040001F3 RID: 499
			hermite64,
			// Token: 0x040001F4 RID: 500
			hermite48,
			// Token: 0x040001F5 RID: 501
			unifiedHermite96,
			// Token: 0x040001F6 RID: 502
			unifiedHermite48,
			// Token: 0x040001F7 RID: 503
			unifiedHermite32,
			// Token: 0x040001F8 RID: 504
			stepLinear64,
			// Token: 0x040001F9 RID: 505
			stepLinear32
		}

		// Token: 0x0200004A RID: 74
		public class OSkeletalAnimationBone
		{
			// Token: 0x06000075 RID: 117 RVA: 0x00004B30 File Offset: 0x00002D30
			public OSkeletalAnimationBone()
			{
				this.scaleX = new RenderBase.OAnimationKeyFrameGroup();
				this.scaleY = new RenderBase.OAnimationKeyFrameGroup();
				this.scaleZ = new RenderBase.OAnimationKeyFrameGroup();
				this.rotationX = new RenderBase.OAnimationKeyFrameGroup();
				this.rotationY = new RenderBase.OAnimationKeyFrameGroup();
				this.rotationZ = new RenderBase.OAnimationKeyFrameGroup();
				this.translationX = new RenderBase.OAnimationKeyFrameGroup();
				this.translationY = new RenderBase.OAnimationKeyFrameGroup();
				this.translationZ = new RenderBase.OAnimationKeyFrameGroup();
				this.rotationQuaternion = new RenderBase.OAnimationFrame();
				this.translation = new RenderBase.OAnimationFrame();
				this.scale = new RenderBase.OAnimationFrame();
				this.transform = new List<RenderBase.OMatrix>();
			}

			// Token: 0x040001FA RID: 506
			public string name;

			// Token: 0x040001FB RID: 507
			public RenderBase.OAnimationKeyFrameGroup scaleX;

			// Token: 0x040001FC RID: 508
			public RenderBase.OAnimationKeyFrameGroup scaleY;

			// Token: 0x040001FD RID: 509
			public RenderBase.OAnimationKeyFrameGroup scaleZ;

			// Token: 0x040001FE RID: 510
			public RenderBase.OAnimationKeyFrameGroup rotationX;

			// Token: 0x040001FF RID: 511
			public RenderBase.OAnimationKeyFrameGroup rotationY;

			// Token: 0x04000200 RID: 512
			public RenderBase.OAnimationKeyFrameGroup rotationZ;

			// Token: 0x04000201 RID: 513
			public RenderBase.OAnimationKeyFrameGroup translationX;

			// Token: 0x04000202 RID: 514
			public RenderBase.OAnimationKeyFrameGroup translationY;

			// Token: 0x04000203 RID: 515
			public RenderBase.OAnimationKeyFrameGroup translationZ;

			// Token: 0x04000204 RID: 516
			public bool isAxisAngle;

			// Token: 0x04000205 RID: 517
			public RenderBase.OAnimationFrame rotationQuaternion;

			// Token: 0x04000206 RID: 518
			public RenderBase.OAnimationFrame translation;

			// Token: 0x04000207 RID: 519
			public RenderBase.OAnimationFrame scale;

			// Token: 0x04000208 RID: 520
			public bool isFrameFormat;

			// Token: 0x04000209 RID: 521
			public List<RenderBase.OMatrix> transform;

			// Token: 0x0400020A RID: 522
			public bool isFullBakedFormat;
		}

		// Token: 0x0200004B RID: 75
		public enum OLoopMode
		{
			// Token: 0x0400020C RID: 524
			oneTime,
			// Token: 0x0400020D RID: 525
			loop
		}

		// Token: 0x0200004C RID: 76
		public class OAnimationBase
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00002AE5 File Offset: 0x00000CE5
			// (set) Token: 0x06000077 RID: 119 RVA: 0x00002AED File Offset: 0x00000CED
			public virtual string name { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00002AF6 File Offset: 0x00000CF6
			// (set) Token: 0x06000079 RID: 121 RVA: 0x00002AFE File Offset: 0x00000CFE
			public virtual float frameSize { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600007A RID: 122 RVA: 0x00002B07 File Offset: 0x00000D07
			// (set) Token: 0x0600007B RID: 123 RVA: 0x00002B0F File Offset: 0x00000D0F
			public virtual RenderBase.OLoopMode loopMode { get; set; }
		}

		// Token: 0x0200004D RID: 77
		public class OAnimationListBase
		{
			// Token: 0x0600007D RID: 125 RVA: 0x00002B18 File Offset: 0x00000D18
			public OAnimationListBase()
			{
				this.list = new List<RenderBase.OAnimationBase>();
			}

			// Token: 0x04000211 RID: 529
			public List<RenderBase.OAnimationBase> list;
		}

		// Token: 0x0200004E RID: 78
		public class OSkeletalAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00002B2B File Offset: 0x00000D2B
			// (set) Token: 0x0600007F RID: 127 RVA: 0x00002B33 File Offset: 0x00000D33
			public override string name { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000080 RID: 128 RVA: 0x00002B3C File Offset: 0x00000D3C
			// (set) Token: 0x06000081 RID: 129 RVA: 0x00002B44 File Offset: 0x00000D44
			public override float frameSize { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000082 RID: 130 RVA: 0x00002B4D File Offset: 0x00000D4D
			// (set) Token: 0x06000083 RID: 131 RVA: 0x00002B55 File Offset: 0x00000D55
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x06000084 RID: 132 RVA: 0x00002B5E File Offset: 0x00000D5E
			public OSkeletalAnimation()
			{
				this.bone = new List<RenderBase.OSkeletalAnimationBone>();
				this.userData = new List<RenderBase.OMetaData>();
			}

			// Token: 0x04000215 RID: 533
			public List<RenderBase.OSkeletalAnimationBone> bone;

			// Token: 0x04000216 RID: 534
			public List<RenderBase.OMetaData> userData;
		}

		// Token: 0x0200004F RID: 79
		public enum OMaterialAnimationType
		{
			// Token: 0x04000218 RID: 536
			constant0 = 1,
			// Token: 0x04000219 RID: 537
			constant1,
			// Token: 0x0400021A RID: 538
			constant2,
			// Token: 0x0400021B RID: 539
			constant3,
			// Token: 0x0400021C RID: 540
			constant4,
			// Token: 0x0400021D RID: 541
			constant5,
			// Token: 0x0400021E RID: 542
			emission,
			// Token: 0x0400021F RID: 543
			ambient,
			// Token: 0x04000220 RID: 544
			diffuse,
			// Token: 0x04000221 RID: 545
			specular0,
			// Token: 0x04000222 RID: 546
			specular1,
			// Token: 0x04000223 RID: 547
			borderColorMapper0,
			// Token: 0x04000224 RID: 548
			textureMapper0,
			// Token: 0x04000225 RID: 549
			borderColorMapper1,
			// Token: 0x04000226 RID: 550
			textureMapper1,
			// Token: 0x04000227 RID: 551
			borderColorMapper2,
			// Token: 0x04000228 RID: 552
			textureMapper2,
			// Token: 0x04000229 RID: 553
			blendColor,
			// Token: 0x0400022A RID: 554
			scaleCoordinator0,
			// Token: 0x0400022B RID: 555
			rotateCoordinator0,
			// Token: 0x0400022C RID: 556
			translateCoordinator0,
			// Token: 0x0400022D RID: 557
			scaleCoordinator1,
			// Token: 0x0400022E RID: 558
			rotateCoordinator1,
			// Token: 0x0400022F RID: 559
			translateCoordinator1,
			// Token: 0x04000230 RID: 560
			scaleCoordinator2,
			// Token: 0x04000231 RID: 561
			rotateCoordinator2,
			// Token: 0x04000232 RID: 562
			translateCoordinator2
		}

		// Token: 0x02000050 RID: 80
		public class OMaterialAnimationData
		{
			// Token: 0x06000085 RID: 133 RVA: 0x00002B7C File Offset: 0x00000D7C
			public OMaterialAnimationData()
			{
				this.frameList = new List<RenderBase.OAnimationKeyFrameGroup>();
			}

			// Token: 0x04000233 RID: 563
			public string name;

			// Token: 0x04000234 RID: 564
			public RenderBase.OMaterialAnimationType type;

			// Token: 0x04000235 RID: 565
			public List<RenderBase.OAnimationKeyFrameGroup> frameList;
		}

		// Token: 0x02000051 RID: 81
		public class OMaterialAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00002B8F File Offset: 0x00000D8F
			// (set) Token: 0x06000087 RID: 135 RVA: 0x00002B97 File Offset: 0x00000D97
			public override string name { get; set; }

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00002BA0 File Offset: 0x00000DA0
			// (set) Token: 0x06000089 RID: 137 RVA: 0x00002BA8 File Offset: 0x00000DA8
			public override float frameSize { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00002BB1 File Offset: 0x00000DB1
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00002BB9 File Offset: 0x00000DB9
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x0600008C RID: 140 RVA: 0x00002BC2 File Offset: 0x00000DC2
			public OMaterialAnimation()
			{
				this.data = new List<RenderBase.OMaterialAnimationData>();
				this.textureName = new List<string>();
			}

			// Token: 0x04000239 RID: 569
			public List<RenderBase.OMaterialAnimationData> data;

			// Token: 0x0400023A RID: 570
			public List<string> textureName;
		}

		// Token: 0x02000052 RID: 82
		public class OVisibilityAnimationData
		{
			// Token: 0x0600008D RID: 141 RVA: 0x00002BE0 File Offset: 0x00000DE0
			public OVisibilityAnimationData()
			{
				this.visibilityList = new RenderBase.OAnimationKeyFrameGroup();
			}

			// Token: 0x0400023B RID: 571
			public string name;

			// Token: 0x0400023C RID: 572
			public RenderBase.OAnimationKeyFrameGroup visibilityList;
		}

		// Token: 0x02000053 RID: 83
		public class OVisibilityAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00002BF3 File Offset: 0x00000DF3
			// (set) Token: 0x0600008F RID: 143 RVA: 0x00002BFB File Offset: 0x00000DFB
			public override string name { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000090 RID: 144 RVA: 0x00002C04 File Offset: 0x00000E04
			// (set) Token: 0x06000091 RID: 145 RVA: 0x00002C0C File Offset: 0x00000E0C
			public override float frameSize { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00002C15 File Offset: 0x00000E15
			// (set) Token: 0x06000093 RID: 147 RVA: 0x00002C1D File Offset: 0x00000E1D
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x06000094 RID: 148 RVA: 0x00002C26 File Offset: 0x00000E26
			public OVisibilityAnimation()
			{
				this.data = new List<RenderBase.OVisibilityAnimationData>();
			}

			// Token: 0x04000240 RID: 576
			public List<RenderBase.OVisibilityAnimationData> data;
		}

		// Token: 0x02000054 RID: 84
		public enum OLightAnimationType
		{
			// Token: 0x04000242 RID: 578
			transform = 28,
			// Token: 0x04000243 RID: 579
			ambient,
			// Token: 0x04000244 RID: 580
			diffuse,
			// Token: 0x04000245 RID: 581
			specular0,
			// Token: 0x04000246 RID: 582
			specular1,
			// Token: 0x04000247 RID: 583
			direction,
			// Token: 0x04000248 RID: 584
			distanceAttenuationStart,
			// Token: 0x04000249 RID: 585
			distanceAttenuationEnd,
			// Token: 0x0400024A RID: 586
			isLightEnabled
		}

		// Token: 0x02000055 RID: 85
		public class OLightAnimationData
		{
			// Token: 0x06000095 RID: 149 RVA: 0x00002C39 File Offset: 0x00000E39
			public OLightAnimationData()
			{
				this.frameList = new List<RenderBase.OAnimationKeyFrameGroup>();
			}

			// Token: 0x0400024B RID: 587
			public string name;

			// Token: 0x0400024C RID: 588
			public RenderBase.OLightAnimationType type;

			// Token: 0x0400024D RID: 589
			public List<RenderBase.OAnimationKeyFrameGroup> frameList;
		}

		// Token: 0x02000056 RID: 86
		public class OLightAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00002C4C File Offset: 0x00000E4C
			// (set) Token: 0x06000097 RID: 151 RVA: 0x00002C54 File Offset: 0x00000E54
			public override string name { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000098 RID: 152 RVA: 0x00002C5D File Offset: 0x00000E5D
			// (set) Token: 0x06000099 RID: 153 RVA: 0x00002C65 File Offset: 0x00000E65
			public override float frameSize { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600009A RID: 154 RVA: 0x00002C6E File Offset: 0x00000E6E
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00002C76 File Offset: 0x00000E76
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x0600009C RID: 156 RVA: 0x00002C7F File Offset: 0x00000E7F
			public OLightAnimation()
			{
				this.data = new List<RenderBase.OLightAnimationData>();
			}

			// Token: 0x04000251 RID: 593
			public RenderBase.OLightType lightType;

			// Token: 0x04000252 RID: 594
			public RenderBase.OLightUse lightUse;

			// Token: 0x04000253 RID: 595
			public List<RenderBase.OLightAnimationData> data;
		}

		// Token: 0x02000057 RID: 87
		public enum OCameraAnimationType
		{
			// Token: 0x04000255 RID: 597
			transform = 5,
			// Token: 0x04000256 RID: 598
			vuTargetPosition,
			// Token: 0x04000257 RID: 599
			vuTwist,
			// Token: 0x04000258 RID: 600
			vuUpwardVector,
			// Token: 0x04000259 RID: 601
			vuViewRotate,
			// Token: 0x0400025A RID: 602
			puNear,
			// Token: 0x0400025B RID: 603
			puFar,
			// Token: 0x0400025C RID: 604
			puFovy,
			// Token: 0x0400025D RID: 605
			puAspectRatio,
			// Token: 0x0400025E RID: 606
			puHeight
		}

		// Token: 0x02000058 RID: 88
		public class OCameraAnimationData
		{
			// Token: 0x0600009D RID: 157 RVA: 0x00002C92 File Offset: 0x00000E92
			public OCameraAnimationData()
			{
				this.frameList = new List<RenderBase.OAnimationKeyFrameGroup>();
			}

			// Token: 0x0400025F RID: 607
			public string name;

			// Token: 0x04000260 RID: 608
			public RenderBase.OCameraAnimationType type;

			// Token: 0x04000261 RID: 609
			public List<RenderBase.OAnimationKeyFrameGroup> frameList;
		}

		// Token: 0x02000059 RID: 89
		public class OCameraAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00002CA5 File Offset: 0x00000EA5
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00002CAD File Offset: 0x00000EAD
			public override string name { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002CB6 File Offset: 0x00000EB6
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002CBE File Offset: 0x00000EBE
			public override float frameSize { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002CC7 File Offset: 0x00000EC7
			// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002CCF File Offset: 0x00000ECF
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x060000A4 RID: 164 RVA: 0x00002CD8 File Offset: 0x00000ED8
			public OCameraAnimation()
			{
				this.data = new List<RenderBase.OCameraAnimationData>();
			}

			// Token: 0x04000265 RID: 613
			public RenderBase.OCameraView viewMode;

			// Token: 0x04000266 RID: 614
			public RenderBase.OCameraProjection projectionMode;

			// Token: 0x04000267 RID: 615
			public List<RenderBase.OCameraAnimationData> data;
		}

		// Token: 0x0200005A RID: 90
		public class OFogAnimationData
		{
			// Token: 0x060000A5 RID: 165 RVA: 0x00002CEB File Offset: 0x00000EEB
			public OFogAnimationData()
			{
				this.colorList = new List<RenderBase.OAnimationKeyFrameGroup>();
			}

			// Token: 0x04000268 RID: 616
			public string name;

			// Token: 0x04000269 RID: 617
			public List<RenderBase.OAnimationKeyFrameGroup> colorList;
		}

		// Token: 0x0200005B RID: 91
		public class OFogAnimation : RenderBase.OAnimationBase
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002CFE File Offset: 0x00000EFE
			// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002D06 File Offset: 0x00000F06
			public override string name { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002D0F File Offset: 0x00000F0F
			// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002D17 File Offset: 0x00000F17
			public override float frameSize { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x060000AA RID: 170 RVA: 0x00002D20 File Offset: 0x00000F20
			// (set) Token: 0x060000AB RID: 171 RVA: 0x00002D28 File Offset: 0x00000F28
			public override RenderBase.OLoopMode loopMode { get; set; }

			// Token: 0x060000AC RID: 172 RVA: 0x00002D31 File Offset: 0x00000F31
			public OFogAnimation()
			{
				this.data = new List<RenderBase.OFogAnimationData>();
			}

			// Token: 0x0400026D RID: 621
			public List<RenderBase.OFogAnimationData> data;
		}

		// Token: 0x0200005C RID: 92
		public struct OSceneReference
		{
			// Token: 0x0400026E RID: 622
			public uint slotIndex;

			// Token: 0x0400026F RID: 623
			public string name;
		}

		// Token: 0x0200005D RID: 93
		public class OScene
		{
			// Token: 0x060000AD RID: 173 RVA: 0x00002D44 File Offset: 0x00000F44
			public OScene()
			{
				this.cameras = new List<RenderBase.OSceneReference>();
				this.lights = new List<RenderBase.OSceneReference>();
				this.fogs = new List<RenderBase.OSceneReference>();
			}

			// Token: 0x04000270 RID: 624
			public string name;

			// Token: 0x04000271 RID: 625
			public List<RenderBase.OSceneReference> cameras;

			// Token: 0x04000272 RID: 626
			public List<RenderBase.OSceneReference> lights;

			// Token: 0x04000273 RID: 627
			public List<RenderBase.OSceneReference> fogs;
		}

		// Token: 0x0200005E RID: 94
		public class OModelGroup
		{
			// Token: 0x060000AE RID: 174 RVA: 0x00004BD4 File Offset: 0x00002DD4
			public OModelGroup()
			{
				this.model = new List<RenderBase.OModel>();
				this.texture = new List<RenderBase.OTexture>();
				this.lookUpTable = new List<RenderBase.OLookUpTable>();
				this.light = new List<RenderBase.OLight>();
				this.camera = new List<RenderBase.OCamera>();
				this.fog = new List<RenderBase.OFog>();
				this.skeletalAnimation = new RenderBase.OAnimationListBase();
				this.materialAnimation = new RenderBase.OAnimationListBase();
				this.visibilityAnimation = new RenderBase.OAnimationListBase();
				this.lightAnimation = new RenderBase.OAnimationListBase();
				this.cameraAnimation = new RenderBase.OAnimationListBase();
				this.fogAnimation = new RenderBase.OAnimationListBase();
				this.scene = new List<RenderBase.OScene>();
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00004C78 File Offset: 0x00002E78
			public void merge(RenderBase.OModelGroup data)
			{
				this.model.AddRange(data.model);
				this.texture.AddRange(data.texture);
				this.lookUpTable.AddRange(data.lookUpTable);
				this.light.AddRange(data.light);
				this.camera.AddRange(data.camera);
				this.fog.AddRange(data.fog);
				this.skeletalAnimation.list.AddRange(data.skeletalAnimation.list);
				this.materialAnimation.list.AddRange(data.materialAnimation.list);
				this.visibilityAnimation.list.AddRange(data.visibilityAnimation.list);
				this.lightAnimation.list.AddRange(data.lightAnimation.list);
				this.cameraAnimation.list.AddRange(data.cameraAnimation.list);
				this.fogAnimation.list.AddRange(data.fogAnimation.list);
				this.scene.AddRange(data.scene);
			}

			// Token: 0x04000274 RID: 628
			public List<RenderBase.OModel> model;

			// Token: 0x04000275 RID: 629
			public List<RenderBase.OTexture> texture;

			// Token: 0x04000276 RID: 630
			public List<RenderBase.OLookUpTable> lookUpTable;

			// Token: 0x04000277 RID: 631
			public List<RenderBase.OLight> light;

			// Token: 0x04000278 RID: 632
			public List<RenderBase.OCamera> camera;

			// Token: 0x04000279 RID: 633
			public List<RenderBase.OFog> fog;

			// Token: 0x0400027A RID: 634
			public RenderBase.OAnimationListBase skeletalAnimation;

			// Token: 0x0400027B RID: 635
			public RenderBase.OAnimationListBase materialAnimation;

			// Token: 0x0400027C RID: 636
			public RenderBase.OAnimationListBase visibilityAnimation;

			// Token: 0x0400027D RID: 637
			public RenderBase.OAnimationListBase lightAnimation;

			// Token: 0x0400027E RID: 638
			public RenderBase.OAnimationListBase cameraAnimation;

			// Token: 0x0400027F RID: 639
			public RenderBase.OAnimationListBase fogAnimation;

			// Token: 0x04000280 RID: 640
			public List<RenderBase.OScene> scene;
		}
	}
}
