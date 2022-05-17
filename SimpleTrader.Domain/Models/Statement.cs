using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public enum StatementType
    {
        ETH,
        GOGN,
        LVCLY
    }
    public class Statement
    {
        public DateTime date { get; set; }
        public string symbol { get; set; }
        public string period { get; set; }
        //public StatementType Type { get; set; }
    }
}
