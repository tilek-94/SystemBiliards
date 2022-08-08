using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBiliards.Models
{
    public class Historys
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int TableId { get; set; }
        public Tables? Table { get; set; }
        public int AccountId { get; set; }
        public Accounts? Account { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int StatusId { get; set; }
        public Statuses? Status { get; set; }
        public double Summa { get; set; }
    }
}
