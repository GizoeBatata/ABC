using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
  public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }


        public OrderItem Retrieve(int orderItem)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            bool isValid = true;
            if (OrderQuantity == null) isValid = false;
            if (ProductId == null) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }
    }
}
