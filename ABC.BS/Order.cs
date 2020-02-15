using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
 public class Order
    {

        public Order()
        {

        }
        public Order(int orderId)
        {
            this.Orderid = orderId;
        }


        public int Orderid { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public Order Retrieve(int orderID)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValid = true;
            if (OrderDate == null)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
