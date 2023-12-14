using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_HierarchicalStructure.Model
{
    internal class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }


        public DateRange(DateTime startDate, DateTime? endDate = null)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
