using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    public class SimpleEventArgs : EventArgs
    {
        public string Message { get; private set; }
       
        public SimpleEventArgs(string message)
        {
            Message = message;
            
        }
    }
}
