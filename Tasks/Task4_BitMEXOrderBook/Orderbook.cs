using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task4_BitMEXOrderbook.WebSocket;

namespace Task4_BitMEXOrderbook
{
    internal class Orderbook
    {
        private DataGridView _dgvBids;
        private DataGridView _dgvAsks;

        private static Orderbook instance;

        public static Orderbook Instance
        {
            get
            {
                if (instance == null)
                {
                    throw new InvalidOperationException("Orderbook has not been initialized.");
                }
                return instance;
            }
        }

        public Orderbook(DataGridView dgvBids, DataGridView dgvAsks)
        {
            _dgvBids = dgvBids;
            _dgvAsks = dgvAsks;
            instance = this; // Initialize the static instance field
        }

        public static void Initialize(DataGridView dgvBids, DataGridView dgvAsks)
        {
            if (instance == null)
            {
                instance = new Orderbook(dgvBids, dgvAsks);
            }
            else
            {
                throw new InvalidOperationException("Orderbook has already been initialized.");
            }
        }

        List<OrderbookEntry> entries = new List<OrderbookEntry>();


        public void SeparateBidAskIntoGrids(List<OrderbookEntry> entries)
        {
            try
            {
            if (entries == null || entries.Count == 0) return;

                var bidEntries = entries.Where(entry => entry.Side == "Buy").ToList();
                UpdateGrid(_dgvBids, bidEntries);
               
                var askEntries = entries.Where(entry => entry.Side == "Sell").ToList();
                UpdateGrid(_dgvAsks, askEntries);
                
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
                if (dataGridView.InvokeRequired)
                {
                    // If not on the UI thread, invoke this method on the UI thread
                    dataGridView.Invoke(new Action(() => BindDataToGridView(dataGridView, entries)));
                }
                else
                {
                    foreach (var entry in entries)
                    {
                        dataGridView.Rows.Add(entry.Price, entry.Size, entry.Total);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void UpdateGrid(DataGridView dataGridView, List<OrderbookEntry> entries, bool reverseSort = false)
        {
            try
            {
                if (entries == null || entries.Count == 0) return;

                if (reverseSort)
                {
                    entries.Sort((b1, b2) => b1.Price.CompareTo(b2.Price));
                }
                else
                {
                    entries.Sort((b1, b2) => b2.Price.CompareTo(b1.Price));
                }

                CalculateTotal(entries);
                BindDataToGridView(dataGridView, entries);
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
