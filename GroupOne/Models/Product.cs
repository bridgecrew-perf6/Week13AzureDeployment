﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GroupOne.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersProduct = new HashSet<OrdersProduct>();
        }

        public int ProductId { get; set; }
        public string ProName { get; set; }
        public string ProVendor { get; set; }
        public string ProDescription { get; set; }
        public int ProQty { get; set; }
        public decimal ProCost { get; set; }
        public decimal ProRevenue { get; set; }
        public string ProType { get; set; }

        public virtual ICollection<OrdersProduct> OrdersProduct { get; set; }
    }
}