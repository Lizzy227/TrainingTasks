using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal class Logger : ILogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        private static readonly Logger instance = new Logger();

        public static Logger Instance => instance;

        public void LogError(string message)
        {
            log.Error(message);
        }

        public void LogInfo(string message)
        {
            log.Info(message);
        }
    }
}
