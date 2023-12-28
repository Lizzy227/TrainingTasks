using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook
{
    internal class OrderBookEventArgs : EventArgs
    {
        public string Message { get; }

        public OrderBookEventArgs(string message)
        {
            Message = message;
        }
    }
}
