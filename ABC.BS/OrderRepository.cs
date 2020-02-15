using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
  public class OrderRepository
    {
        public Order Retrieve(int orderID)
        {
            Order order = new Order(orderID);

            if (orderID == 10)
            {
                order.OrderDate = DateTimeOffset.Now;
            }
            return order;
        }

        public bool Save()
        {
            return true;
        }
    }
}
