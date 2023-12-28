using log4net.Core;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    public class SimpleMessageProvider
    {

        public event EventHandler<SimpleEventArgs> EvenMessageReceivedEvent;
        public event EventHandler<SimpleEventArgs> OddMessageReceivedEvent;

        //Keats: I see what you did here, however our convention is to use
        //public event EventHandler<SimpleEventArgs> EvenMessageReceivedEvent;
        //public event EventHandler<SimpleEventArgs> OddMessageReceivedEvent;

        private System.Threading.Timer timer;

        public void StartMessaging()
        {
            try
            {
                LizLogger.Instance.Log(typeof(SimpleMessageProvider), Level.Info,"Starting Timer if no timer is instantiated", null);
                if (timer != null)
                {
                    return;
                }

                timer = new System.Threading.Timer(PrintMessage, null, 0, 1000);

            }
            catch (Exception ex)
            {
                LizLogger.Instance.Log(typeof(SimpleMessageProvider), Level.Error, $"Error when starting Timer: {ex.Message}", null);                
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
                LizLogger.Instance.Log(typeof(SimpleMessageProvider), Level.Error, $"Error when Printing Message: {ex.Message}", null);                
            }
        }

        public void StopMessaging()
        {
            try
            {
                timer?.Dispose();
                timer = null;                
                LizLogger.Instance.Log(typeof(SimpleMessageProvider), Level.Info, "Timer disposed", null);
            }
            catch (Exception ex)
            {                                
                LizLogger.Instance.Log(typeof(SimpleMessageProvider), Level.Error, $"Error when Stopping Timer: {ex.Message}", null);
            }
        }
    }
}



