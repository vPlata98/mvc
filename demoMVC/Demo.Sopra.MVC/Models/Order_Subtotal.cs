﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Sopra.MVC.Models
{
    public partial class Order_Subtotal
    {
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
