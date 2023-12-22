using log4net;
using log4net.Core;
using log4net.Repository;
using System.Reflection;

namespace CallbacksTask
{
    //Keats: added the Logger and LoggerAsync below so you can use it if you want :)

    internal class LizLogger : ILogger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LizLogger));

        private static readonly LizLogger instance = new LizLogger();

        public static LizLogger Instance => instance;

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

    public interface IInternalLogger
    {
        public void LogInfo(string message);
        public void LogDebug(string message);
        public void LogWarning(string message);
        public void LogError(string message, Exception ex = null);
        public void LogFatal(string message, Exception ex = null);
    }

    public sealed class Logger : IInternalLogger
    {
        #region Singleton Instantiation https://csharpindepth.com/articles/singleton version 4

        private static readonly Logger instance = new Logger();

        private ILog _logger = LogManager.GetLogger("root");

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static Logger() { }

        public static Logger Instance
        {
            get { return instance; }
        }

        #endregion

        private Logger()
        {
            ILoggerRepository repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
        }

        public void LogDebug(string message)
        {
            try
            {
                _logger.Debug(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogInfo(string message)
        {
            try
            {
                _logger.Info(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogWarning(string message)
        {
            try
            {
                _logger.Warn(message);
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogError(string message, Exception ex = null)
        {
            try
            {
                if (ex != null)
                {
                    _logger.Error(message, ex);
                }
                else
                {
                    _logger.Error(message);
                }
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }

        public void LogFatal(string message, Exception ex = null)
        {
            try
            {
                if (ex != null)
                {
                    _logger.Fatal(message, ex);
                }
                else
                {
                    _logger.Fatal(message);
                }
            }
            catch (Exception)
            {
                //ignore due to recursion. This will catch synchronous exceptions
            }
        }
    }

    public sealed class LoggerAsync : IInternalLogger
    {
        #region Singleton Instantiation https://csharpindepth.com/articles/singleton version 4

        private static readonly LoggerAsync instance = new LoggerAsync();

        private ILog _logger = LogManager.GetLogger("root");

        // Explicit static constructor to tell C# compiler not to mark type as beforefieldinit
        static LoggerAsync() { }

        public static LoggerAsync Instance
        {
            get { return instance; }
        }

        #endregion

        private LoggerAsync()
        {
            ILoggerRepository repository = LogManager.GetRepository(Assembly.GetCallingAssembly());

            var fileInfo = new FileInfo(@"log4net.config");

            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);
        }

        public void LogDebug(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Debug(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogInfo(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Info(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogWarning(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Warn(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogError(string message, Exception ex = null)
        {
            Task.Run(() =>
            {
                try
                {
                    _logger?.Error(message);
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }

        public void LogFatal(string message, Exception ex = null)
        {
            Task.Run(() =>
            {
                try
                {
                    if (ex != null)
                    {
                        _logger.Fatal(message, ex);
                    }
                    else
                    {
                        _logger.Fatal(message);
                    }
                }
                catch (Exception)
                {
                    //ignore due to recursion
                }
            });
        }
    }

}

