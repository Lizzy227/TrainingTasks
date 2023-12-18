using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    public class SimpleEventArgs : EventArgs
    {
        public string LogMessage { get; private set; }
        //public DateTime LogDateTime { get; private set; }

        public SimpleEventArgs(string logMessage)
        {
            LogMessage = logMessage;
            
        }
    }
}
