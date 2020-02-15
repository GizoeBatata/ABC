using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
    public class Customer
    {
        //constructor
        public Customer()
        {
        }
        public Customer(int customerID)
        {
            this.CustomerID = customerID;
        }
    
        //properties
        public static int instanceCount;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }

        public string FullName
        {
            get
            {if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        return LastName + ", " + FirstName;
                    }
                    return FirstName;
                }
                return LastName;
            }
         }

        public Customer Retrieve(int customerId)
        {
            return new Customer();

        }

        public List<Customer> Retrieve()
        {

            return new List<Customer>();
         }

        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
            {
                isValid = false;
            }
            if (string.IsNullOrWhiteSpace(EmailAddress))
            {
                isValid = false;
            }
            return isValid;
        }

    }
}
