using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CustomerID { get; private set; }

        public string FullName
        {
            get
            {
                
                if (!string.IsNullOrWhiteSpace(FirstName))
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
    }
}
