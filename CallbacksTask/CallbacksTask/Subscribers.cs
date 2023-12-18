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
            try
            {
            logger.LoggerMessage += HandleLogMessageEvent;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UnsubscribeFromLoggerEvent(Logger logger)
        {
            try
            {
            logger.LoggerMessage -= HandleLogMessageEvent;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void HandleLogMessageEvent(object sender, SimpleEventArgs e) 
        {
            string logMessage = e.LogMessage;

            try
            {
            UpdateTextBox(logMessage);
            }
            catch (Exception)
            {

                throw;
            }
            

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
