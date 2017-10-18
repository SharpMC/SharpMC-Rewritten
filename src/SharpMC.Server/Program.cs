using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using SharpMC.Util;

namespace SharpMC.Server
{
	class Program
	{
		private static readonly ILog Log = LogManager.GetLogger(typeof(Program));
		static void Main(string[] args)
		{
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
