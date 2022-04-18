﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Sopra.MVC.Models
{
    public partial class Order_Details_Extended
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
    }
}
