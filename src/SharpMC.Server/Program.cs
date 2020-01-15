using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using SharpMC.Util;

namespace SharpMC.Server
{
	class Program
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
		static void Main(string[] args)
		{
			var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
			XmlConfigurator.Configure(logRepository, new FileInfo(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "log4net.xml")));
			
			MinecraftServer server = new MinecraftServer();
			try
			{
				server.Start();
				Console.ReadLine();
			}
			finally
			{
				server.Stop();
			}
		}
	}
}
