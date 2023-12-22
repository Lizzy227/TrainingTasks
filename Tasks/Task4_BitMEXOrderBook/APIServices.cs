using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Task4_BitMEXOrderbook
{
    internal class APIServices
    {
        private readonly HttpClient client;

        public APIServices()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://testnet.bitmex.com/api/v1"); 
            InitializeHttpClient();
        }

        public void InitializeHttpClient()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Orderbook> GetOrderBookAsync(string symbol)
        {
            try
            {
                using (HttpResponseMessage response = await client.GetAsync($"/orderbook/L2?symbol={symbol}&depth=25"))
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Orderbook orderBook = JsonConvert.DeserializeObject<Orderbook>(responseBody);
                    return orderBook;
                }
                else
                {
                    // Handle unsuccessful response (e.g., log or throw exception)
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., log or throw)
                return null;
            }
        }
    }
}
