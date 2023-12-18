using log4net;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    public class Logger : ILogger
    {
        private System.Threading.Timer timer;

        public event EventHandler<SimpleEventArgs> LoggerMessage;
        public void StartLogging()
        {
            try
            {
                if (timer == null)
                {

                timer = new System.Threading.Timer(LogMessage, null, 0, 1000);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LogMessage(object state)
        {
            string logMessage = $"Log entry at {DateTime.Now}";
            var args = new SimpleEventArgs(logMessage);
            
            try
            {
                LoggerMessage?.Invoke(this, args);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void StopLogging()
        {
            try
            {
            timer?.Dispose();
                timer = null;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}



