using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal class Subscribers
    {
        private TextBox textBoxLogs;

        public Subscribers(TextBox logsTextBox)
        {
            textBoxLogs = logsTextBox;
        }
        public void SubscribeToLoggerEvent(Logger logger)
        {
            logger.LoggerMessage += HandleLogMessageEvent;
        }

        public void UnsubscribeFromLoggerEvent(Logger logger)
        {
            logger.LoggerMessage -= HandleLogMessageEvent;
        }

        public void HandleLogMessageEvent(object sender, SimpleEventArgs e) 
        {
            string logMessage = e.LogMessage;
            UpdateTextBox(logMessage);
            

        }

        private void UpdateTextBox(string logMessage)
        {
            try
            {
                if (textBoxLogs.InvokeRequired)
                {
                    textBoxLogs.Invoke(new Action(() =>
                    {
                        textBoxLogs.AppendText(logMessage + Environment.NewLine);
                    }));
                }
                else
                {
                    textBoxLogs.AppendText(logMessage + Environment.NewLine);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
