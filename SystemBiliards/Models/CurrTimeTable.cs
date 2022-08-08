using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBiliards.Models
{
    public class CurrTimeTable
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime NowTime { get; set; }
        public bool NoLimitedStatuse { get; set; }
        public bool ByTimeStatuse { get; set; }
        public double ByTime { get; set; }
        public bool UntilTheTimeStatuse { get; set; }
        public DateTime UntilTheTime { get; set; }
        public bool ByAmountStatuse { get; set; }
        public double ByAmount { get; set; }


    }
}
