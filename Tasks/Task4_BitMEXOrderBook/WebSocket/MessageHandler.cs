using Task4_BitMEXOrderbook;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Task4_BitMEXOrderbook.WebSocket
{
    public static class MessageHandler
    {
        public static async Task HandleUpdateMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static async Task HandleInsertMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static async Task HandleDeleteMessage(WebSocketEventArgs e)
        {
            try
            {
                string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static async Task HandleOrderbookSnapshot(WebSocketEventArgs e)
        {
            try
            {
                JObject jsonObject = JObject.Parse(e.Message);
                JToken dataToken = jsonObject["data"];

                List<OrderbookEntry> entries = new List<OrderbookEntry>();
                string responseBody = dataToken.ToString();
                entries = JsonConvert.DeserializeObject<List<OrderbookEntry>>(responseBody);

                Orderbook orderbook = Orderbook.Instance;

                await Task.Run(() => orderbook.SeparateBidAskIntoGrids(entries));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
