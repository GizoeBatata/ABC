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
            :this(0)
        {
        }
        public Customer(int customerID)
        {
            this.CustomerID = customerID;
            AddressList = new List<Address>();
        }
    
        //properties
        public static int instanceCount { get; set; }

        public List<Address> AddressList { get; set; }
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
