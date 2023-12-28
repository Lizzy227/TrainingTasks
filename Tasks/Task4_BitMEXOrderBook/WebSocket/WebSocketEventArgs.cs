using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook.WebSocket
{
    public class WebSocketEventArgs: EventArgs
    {
        public string Message { get; }
        public string ActionType { get; }
        public WebSocketEventArgs(string actionType, string message)
        { 
            ActionType = actionType;
            Message = message;
        }
    }
}
