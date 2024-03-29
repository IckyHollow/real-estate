﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Real__estate.Models
{
    public class AgentSellerView
    {
        public Agent Agent { get; set; }
        public Seller Seller { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual User User { get; set; }
    }
}