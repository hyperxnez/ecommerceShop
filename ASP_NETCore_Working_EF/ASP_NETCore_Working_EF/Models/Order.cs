using System;
using System.Collections.Generic;

#nullable disable

namespace ASP_NETCore_Working_EF.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int CheckoutInfoId { get; set; }
        public decimal Total { get; set; }

        public virtual CheckoutInfo CheckoutInfo { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
