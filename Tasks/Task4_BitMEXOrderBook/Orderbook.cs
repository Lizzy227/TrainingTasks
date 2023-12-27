using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook
{
    internal class Orderbook
    {

        List<OrderbookEntry> entries = new List<OrderbookEntry>();
        private OrderBookForm _form;
        private DataGridView dgvBids;
        private DataGridView dgvAsks;

        public Orderbook()
        {
           
        }

        public void UpdateGrids(List<OrderbookEntry> entries)
        {
            try
            {
            if (entries == null || entries.Count == 0) return;

                var bidEntries = entries.Where(entry => entry.Side == "Buy").ToList();
                BindDataToGridView(dgvBids, bidEntries);
                var askEntries = entries.Where(entry => entry.Side == "Sell").ToList();
                BindDataToGridView(dgvAsks, askEntries);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BindDataToGridView(DataGridView dataGridView, List<OrderbookEntry> entries)
        {
            try
            {
                foreach (var entry in entries) 
                {
                    dataGridView.Rows.Add(entry.Price, entry.Size);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
