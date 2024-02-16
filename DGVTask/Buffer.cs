using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGVTask
{
    internal class Buffer
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public int Length { get; set; }       
        
        public int AvgRuntime { get; set; }

        public int Throughput { get; set; }
        
    }
}
