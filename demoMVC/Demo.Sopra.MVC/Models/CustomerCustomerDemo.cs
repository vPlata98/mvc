﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Demo.Sopra.MVC.Models
{
    public partial class CustomerCustomerDemo
    {
        public string CustomerID { get; set; }
        public string CustomerTypeID { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographic CustomerType { get; set; }
    }
}
