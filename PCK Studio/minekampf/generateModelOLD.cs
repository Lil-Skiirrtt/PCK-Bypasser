using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace minekampf
{
	// Token: 0x02000063 RID: 99
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class generateModelOLD
	{
		// Token: 0x06000104 RID: 260 RVA: 0x000021D7 File Offset: 0x000003D7
		internal generateModelOLD()
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002E8F File Offset: 0x0000108F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (generateModelOLD.resourceMan == null)
				{
					generateModelOLD.resourceMan = new ResourceManager("minekampf.generateModelOLD", typeof(generateModelOLD).Assembly);
				}
				return generateModelOLD.resourceMan;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00002EBB File Offset: 0x000010BB
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002EC2 File Offset: 0x000010C2
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return generateModelOLD.resourceCulture;
			}
			set
			{
				generateModelOLD.resourceCulture = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002ECA File Offset: 0x000010CA
		internal static Point contextMenuStrip1_TrayLocation
		{
			get
			{
				return (Point)generateModelOLD.ResourceManager.GetObject("contextMenuStrip1.TrayLocation", generateModelOLD.resourceCulture);
			}
		}

		// Token: 0x040002D9 RID: 729
		private static ResourceManager resourceMan;

		// Token: 0x040002DA RID: 730
		private static CultureInfo resourceCulture;
	}
}
