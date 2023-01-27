using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace minekampf.Properties
{
	// Token: 0x02000066 RID: 102
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00003292 File Offset: 0x00001492
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040002E0 RID: 736
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
