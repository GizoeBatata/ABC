using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.BS
{
   public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "konijnenberg 24";
                address.StreetLine2 = "konijnenberg 30";
                address.State = "NB";
                address.City = "Breda";
                address.Country = "Netherlands";
                address.PostalCode = "4444 KL";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerID)
        {
            var addresslist = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "babsbs 24",
                StreetLine2 = "dndnddb 30",
                State = "NB",
                City = "EL",
                Country = "Netherlands",
                PostalCode = "dds KL",

            };
            addresslist.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "konijnenberg 1",
                StreetLine2 = "konijnenberg 2",
                State = "NB",
                City = "Teike",
                Country = "Netherlands",
                PostalCode = "7557 KL",
            };
            addresslist.Add(address);

            return addresslist;
        }


        public bool Save (Address address)
        {
            return true;
        }
    }
}
