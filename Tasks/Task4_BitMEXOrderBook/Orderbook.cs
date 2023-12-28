using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task4_BitMEXOrderbook
{
    internal class Orderbook
    {

        List<OrderbookEntry> entries = new List<OrderbookEntry>();
        public OrderBookForm _form;

        public Orderbook()
        {
           
        }

        public void UpdateGrids(DataGridView dgvBids, DataGridView dgvAsks,List<OrderbookEntry> entries)
        {
            try
            {
            if (entries == null || entries.Count == 0) return;

                var bidEntries = entries.Where(entry => entry.Side == "Buy").ToList();
                UpdateBidsGrid(dgvBids, bidEntries);
               
                var askEntries = entries.Where(entry => entry.Side == "Sell").ToList();
                UpdateAsksGrid(dgvAsks, askEntries);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BindDataToGridView(DataGridView dataGridView, List<OrderbookEntry> entries)
        {
            try
            {
                foreach (var entry in entries) 
                {
                    dataGridView.Rows.Add(entry.Price, entry.Size, entry.Total);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void UpdateBidsGrid(DataGridView dgvBids, List<OrderbookEntry> bidEntries)
        {
            try
            {
                if (bidEntries == null || bidEntries.Count == 0) return;

                
                bidEntries.Sort((b1, b2) => b2.Price.CompareTo(b1.Price));
                CalculateTotal(bidEntries);
                BindDataToGridView(dgvBids, bidEntries);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateAsksGrid(DataGridView dgvAsks, List<OrderbookEntry> askEntries)
        {
            try
            {
                if (askEntries == null || askEntries.Count == 0) return;

                askEntries.Sort((b2, b1) => b1.Price.CompareTo(b2.Price));
                CalculateTotal(askEntries);
                BindDataToGridView(dgvAsks, askEntries);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CalculateTotal(List<OrderbookEntry> entries)
        {
            try
            {
            int total = 0;
            foreach (var entry in entries)
            {
                total += entry.Size;
                entry.Total = total;
            }

            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
