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

            string message = e.Message + ": " + DateTime.Now.ToString("HH:mm:ss");
            /*
            try
            {
                
                JObject jsonObject = JObject.Parse(e.Message);
                JToken dataToken = jsonObject["data"];

                List<OrderbookEntry> updatedEntries = new List<OrderbookEntry>();
                string responseBody = dataToken.ToString();
                updatedEntries = JsonConvert.DeserializeObject<List<OrderbookEntry>>(responseBody);

                Orderbook orderbook = Orderbook.Instance;


                if (updatedEntries != null && orderbook.entries != null)
                {
                    foreach (OrderbookEntry updatedEntry in updatedEntries)
                    {
                        OrderbookEntry existingEntry = orderbook.entries.FirstOrDefault(entry => entry.Id == updatedEntry.Id);

                        if (existingEntry != null)
                        {
                            existingEntry.Price = updatedEntry.Price;
                            existingEntry.Size = updatedEntry.Size;
                            // Update other properties as needed
                        }
                        else
                        {
                            // Handle the case when the entry doesn't exist in the snapshot
                        }
                    }
                }
                else
                {
                    // Handle null references if necessary
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
            */
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

                orderbook.ClearOrderBook();

                await Task.Run(() => orderbook.SeparateBidAskIntoGrids(entries));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
