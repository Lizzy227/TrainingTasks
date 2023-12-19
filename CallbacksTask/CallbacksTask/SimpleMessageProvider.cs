﻿using log4net;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static CallbacksTask.SimpleMessageProvider;

namespace CallbacksTask
{
    public class SimpleMessageProvider
    {
        private ILogger logger = Logger.Instance;
        public delegate void MessageCallback(object sender, SimpleEventArgs e);
        public event MessageCallback EvenMessageReceivedEvent;
        public event MessageCallback OddMessageReceivedEvent;
        private System.Threading.Timer timer;

        public void StartMessaging()
        {
            try
            {
            logger?.LogInfo("Starting Timer if no timer is instantiated");
                if (timer != null)
                {
                    return;
                }

                timer = new System.Threading.Timer(PrintMessage, null, 0, 1000);

            }
            catch (Exception ex)
            {

                logger?.LogError($"Error when starting Timer: {ex.Message}");
            }
        }

        private void PrintMessage(object state)
        {
            string printMessage = $"Log entry at {DateTime.Now}";
            SimpleEventArgs args = new SimpleEventArgs(printMessage);

            try
            {                
                if (DateTime.Now.Second % 2 == 0)
                {
                    EvenMessageReceivedEvent?.Invoke(this, args);
                }
                else
                {
                    OddMessageReceivedEvent?.Invoke(this, args);
                }
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error when Printing Message: {ex.Message}");
            }
        }

        public void StopMessaging()
        {
            try
            {
                timer?.Dispose();
                timer = null;
                logger?.LogInfo("Timer disposed");
            }
            catch (Exception ex)
            {

                logger?.LogError($"Error when Stopping Timer: {ex.Message}");
            }
        }
    }
}


