using ConcurrentCollections;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook.WebSocket
{
    internal class WebSocketHandler
    {
        public event EventHandler<WebSocketEventArgs> WebSocketEvent;
        private ConcurrentDictionary<string, ConcurrentHashSet<Func<WebSocketEventArgs, Task>>> _webSocketSubscribers = new();
        private delegate Task WebSocketEventDelegate(WebSocketEventArgs eventArgs);

        private static readonly WebSocketHandler instance = new WebSocketHandler();

        public static WebSocketHandler Instance { get { return instance; } }


        public virtual void OnWebSocketEvent(string actionType, string receivedMessage)
        {

            WebSocketEventArgs eventArgs = new WebSocketEventArgs(actionType, receivedMessage);

            if (_webSocketSubscribers.TryGetValue(eventArgs.ActionType, out var subscribers))
            {
                foreach(var subscriber in subscribers)
                {
                    subscriber.Invoke(eventArgs);
                }
            }
        }

        public void Subscribe(string key, Func<WebSocketEventArgs, Task> subscriber)
        {
            try
            {
                _webSocketSubscribers.AddOrUpdate(
                        key,
                        _ => new ConcurrentHashSet<Func<WebSocketEventArgs, Task>>(new List<Func<WebSocketEventArgs, Task>> { subscriber }),
                        (_, set) =>
                        {
                            set.Add(subscriber);
                            return set;
                        });
            }
            catch (Exception)
            {
                //throw;
            }
        }

        public void Unsubscribe(string key)
        {
            try
            {
                _webSocketSubscribers.TryRemove(key, out _);
            }
            catch (Exception)
            {
                //throw;
            }
        }
    }
}
