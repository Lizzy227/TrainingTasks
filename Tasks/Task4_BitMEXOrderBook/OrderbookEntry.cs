using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_BitMEXOrderbook
{
    internal class OrderbookEntry
    {
        public string Symbol { get; set; }
        public Int64 Id { get; set; }
        public string Side { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }       
        public DateTime Timestamp { get; set; }

        public int Total { get; set; }

        

    }
}
