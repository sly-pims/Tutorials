using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Order
    {
        public Order() : this(0)
        {

        }
        public Order(int orderID)
        {
            OrderId = orderID;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
