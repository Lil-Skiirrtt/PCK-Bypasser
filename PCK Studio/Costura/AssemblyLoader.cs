using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x02000096 RID: 150
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x060002BE RID: 702 RVA: 0x00003F0C File Offset: 0x0000210C
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00042CC8 File Offset: 0x00040EC8
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00042D30 File Offset: 0x00040F30
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00042D64 File Offset: 0x00040F64
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00042DE8 File Offset: 0x00040FE8
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00042E08 File Offset: 0x00041008
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00042E30 File Offset: 0x00041030
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = string.Format("{0}.{1}", requestedAssemblyName.CultureInfo.Name, text);
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00042EF0 File Offset: 0x000410F0
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				obj = AssemblyLoader.nullCacheLock;
				lock (obj)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00042FD0 File Offset: 0x000411D0
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.assemblyNames.Add("cyotek.drawing.bitmapfont", "costura.cyotek.drawing.bitmapfont.dll.compressed");
			AssemblyLoader.assemblyNames.Add("expandablepanel", "costura.expandablepanel.dll.compressed");
			AssemblyLoader.assemblyNames.Add("filetransferprotocollib", "costura.filetransferprotocollib.dll.compressed");
			AssemblyLoader.assemblyNames.Add("ftpmanager", "costura.ftpmanager.dll.compressed");
			AssemblyLoader.assemblyNames.Add("geoapi", "costura.geoapi.dll.compressed");
			AssemblyLoader.assemblyNames.Add("helixtoolkit", "costura.helixtoolkit.dll.compressed");
			AssemblyLoader.assemblyNames.Add("helixtoolkit.wpf", "costura.helixtoolkit.wpf.dll.compressed");
			AssemblyLoader.assemblyNames.Add("helixtoolkit.wpf.sharpdx", "costura.helixtoolkit.wpf.sharpdx.dll.compressed");
			AssemblyLoader.assemblyNames.Add("icsharpcode.sharpziplib", "costura.icsharpcode.sharpziplib.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework", "costura.metroframework.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.sqlserver.types", "costura.microsoft.sqlserver.types.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.primitives", "costura.microsoft.win32.primitives.dll.compressed");
			AssemblyLoader.assemblyNames.Add("mysql.data", "costura.mysql.data.dll.compressed");
			AssemblyLoader.assemblyNames.Add("nettopologysuite", "costura.nettopologysuite.dll.compressed");
			AssemblyLoader.assemblyNames.Add("opengl", "costura.opengl.dll.compressed");
			AssemblyLoader.assemblyNames.Add("powercollections", "costura.powercollections.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.d3dcompiler", "costura.sharpdx.d3dcompiler.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.direct2d1", "costura.sharpdx.direct2d1.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.direct3d11", "costura.sharpdx.direct3d11.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.direct3d11.effects", "costura.sharpdx.direct3d11.effects.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.direct3d9", "costura.sharpdx.direct3d9.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx", "costura.sharpdx.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.dxgi", "costura.sharpdx.dxgi.dll.compressed");
			AssemblyLoader.assemblyNames.Add("sharpdx.mathematics", "costura.sharpdx.mathematics.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.appcontext", "costura.system.appcontext.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.console", "costura.system.console.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.globalization.calendars", "costura.system.globalization.calendars.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.compression", "costura.system.io.compression.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.compression.zipfile", "costura.system.io.compression.zipfile.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.filesystem", "costura.system.io.filesystem.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.filesystem.primitives", "costura.system.io.filesystem.primitives.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.net.http", "costura.system.net.http.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.net.sockets", "costura.system.net.sockets.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.interopservices.runtimeinformation", "costura.system.runtime.interopservices.runtimeinformation.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.algorithms", "costura.system.security.cryptography.algorithms.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.encoding", "costura.system.security.cryptography.encoding.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.primitives", "costura.system.security.cryptography.primitives.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.x509certificates", "costura.system.security.cryptography.x509certificates.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.xml.readerwriter", "costura.system.xml.readerwriter.dll.compressed");
			AssemblyLoader.assemblyNames.Add("tao.freeglut", "costura.tao.freeglut.dll.compressed");
			AssemblyLoader.assemblyNames.Add("thinkgeo.mapsuite", "costura.thinkgeo.mapsuite.dll.compressed");
			AssemblyLoader.assemblyNames.Add("thinkgeo.mapsuite.productcenter", "costura.thinkgeo.mapsuite.productcenter.exe.compressed");
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00003F1D File Offset: 0x0000211D
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain.CurrentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x040004A6 RID: 1190
		private static object nullCacheLock = new object();

		// Token: 0x040004A7 RID: 1191
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x040004A8 RID: 1192
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x040004A9 RID: 1193
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x040004AA RID: 1194
		private static int isAttached;
	}
}
