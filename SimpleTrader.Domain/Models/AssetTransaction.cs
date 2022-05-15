﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Models
{
    public class AssetTransaction: DomanObject
    {
        
        public Account Account { get; set; }

        public bool IsPurchase { get; set; }
        public Stock Stock { get; set; }   
        public int Share { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
