using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBiliards.Models
{
    public class Tables
    {
        public int Id { get; set; }
        public string? TableName { get; set; }
        public int StatusId { get; set; }
        public Statuses? Status { get; set; }
        public CountTimeTable? CountTime { get; set; }

    }
}
