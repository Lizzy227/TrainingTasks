﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook
{
    internal class WebSocketAPI
    {

        private ClientWebSocket clientWebSocket;

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
                    string receivedMessage = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                    Console.WriteLine($"Received: {receivedMessage}");
                    // Process the received message as needed
                }
            }
        }

        public async Task Send(string message)
        {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(message);
            await clientWebSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }

    }
}
