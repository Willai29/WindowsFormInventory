﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5_View.Model
{
    public class OrderDetails
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}

