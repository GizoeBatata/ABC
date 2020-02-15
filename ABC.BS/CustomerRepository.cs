using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
  public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "hanskazan@gmail.com";
                customer.FirstName = "Hans";
                customer.LastName = "Kazan";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {

            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
