using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItem
    {

        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemID = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderItemID { get; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int ordemitemId)
        {
            return new OrderItem(); 
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    
    }
}
