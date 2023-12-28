using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook.WebSocket
{
    internal class WebSocketAPI
    {

        private ClientWebSocket clientWebSocket;

        private static readonly WebSocketAPI instance = new WebSocketAPI();

        private WebSocketAPI()
        {
            // here to prevent instantiation
        }

        public static WebSocketAPI Instance { get { return instance; } }

        public async Task Connect(string uri)
        {
            clientWebSocket = new ClientWebSocket();
            await clientWebSocket.ConnectAsync(new Uri(uri), CancellationToken.None);

            // Start receiving messages
            _ = Task.Run(ReceiveLoop);
        }

        private async Task ReceiveLoop()
        {
            byte[] buffer = new byte[1024]; // Set your buffer size
            while (clientWebSocket.State == WebSocketState.Open)
            {
                WebSocketReceiveResult result = await clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Text)
                {
                    string receivedMessage = Encoding.UTF8.GetString(buffer, 0, result.Count);
                    Console.WriteLine($"Received: {receivedMessage}");

                    // Process the received message as needed
                }
            }
        }

        public async Task Send(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            await clientWebSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }

    }
}
