using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBiliards.Models
{
    public class Accounts 
    {
        public int Id { get; set; }
        public string? AccountName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Role { get; set; }
    }
}
