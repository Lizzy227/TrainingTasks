using System.Text;
using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Task4_BitMEXOrderbook.WebSocket
{
    internal class WebSocketAPI
    {

        private ClientWebSocket clientWebSocket;

        private static readonly WebSocketAPI instance = new WebSocketAPI();
        public static WebSocketAPI Instance { get { return instance; } }

        private WebSocketAPI()
        {
            // here to prevent instantiation
        }


        public async Task Connect(string uri)
        {
            try
            {
                clientWebSocket = new ClientWebSocket();
                await clientWebSocket.ConnectAsync(new Uri(uri), CancellationToken.None);

                // Start receiving messages
                _ = Task.Run(ReceiveLoop);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task ReceiveLoop()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (clientWebSocket.State == WebSocketState.Open)
                {
                    WebSocketReceiveResult result = await clientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                    if (result.MessageType == WebSocketMessageType.Text)
                    {
                        string receivedMessage = Encoding.UTF8.GetString(buffer, 0, result.Count);

                        QueueHandler.Instance.AddEventToQueue(receivedMessage);
                    }
                }
            }catch (Exception ex)
            {

            }
        }

        

        public async Task ProcessQueueEvents()
        {
            try
            {
                Queue<string> eventQueue = QueueHandler.Instance.GetEventQueue();
                string actionType = string.Empty;
                string receivedMessage = string.Empty;
                while(eventQueue.Count > 0)
                {
                    receivedMessage = GetFullMessage(eventQueue);
                    actionType = ExtractActionType(receivedMessage);
                    WebSocketHandler.Instance.OnWebSocketEvent(actionType, receivedMessage);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        string GetFullMessage(Queue<string> eventQueue)
        {
            StringBuilder fullMessageBuilder = new StringBuilder();
            try
            {
                string messageFragment = eventQueue.Dequeue();
                if (IsCompleteMessage(messageFragment))
                    return messageFragment;


                fullMessageBuilder.Append(messageFragment);


                while (eventQueue.Count>0)
                {
                    messageFragment = eventQueue.Dequeue();

                    if (messageFragment.Contains("partial"))
                    {
                        fullMessageBuilder.Clear();
                    }

                    fullMessageBuilder.Append(messageFragment);

                    if (IsCompleteMessage(fullMessageBuilder.ToString()))
                        break;
                }

                return fullMessageBuilder.ToString();
                
            }
            catch(Exception)
            {
                return fullMessageBuilder.ToString();
            }
        }

        private string ExtractActionType(string message)
        {
            try
            {
                JObject jsonObject = JObject.Parse(message);
                JToken actionToken = jsonObject["action"];

                if (actionToken != null)
                {
                    return actionToken.ToString();
                }
            }
            catch (Exception)
            {
                // Handle JSON parsing errors
            }

            return "generic";
        }

        bool IsCompleteMessage(string message)
        {
            try
            {
                JObject.Parse(message);
                return true;
            }catch(JsonReaderException)
            {
                return false;
            }
        }

        public async Task Send(string message)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            await clientWebSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
        }

    }
}
