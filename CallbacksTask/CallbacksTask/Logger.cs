using log4net;
using log4net.Core;
using log4net.Repository;
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

        public string Name => throw new NotImplementedException();

        public ILoggerRepository Repository => throw new NotImplementedException();

        public void Log(Type callerStackBoundaryDeclaringType, Level level, object message, Exception exception)
        {
            // Implement the Log method using log4net or your preferred logging library
            log.Logger.Log(callerStackBoundaryDeclaringType, level, message, exception);
        }

        public void Log(LoggingEvent logEvent)
        {
            // Implement the Log method using log4net or your preferred logging library
            log.Logger.Log(logEvent);
        }

        public bool IsEnabledFor(Level level)
        {
            // Implement the IsEnabledFor method using log4net or your preferred logging library
            return log.Logger.IsEnabledFor(level);
        }
    }
}

