﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Sopra.MVC.Models
{
    public partial class Summary_of_Sales_by_Year
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
