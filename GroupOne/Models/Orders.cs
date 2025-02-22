﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace GroupOne.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrdersPayment = new HashSet<OrdersPayment>();
            OrdersProduct = new HashSet<OrdersProduct>();
        }

        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrdersPayment> OrdersPayment { get; set; }
        public virtual ICollection<OrdersProduct> OrdersProduct { get; set; }
    }
}