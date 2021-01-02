using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class AddressRepository
    {
       public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.City = "Denver";
                address.Country = "United States";
                address.State = "Colorado";
                address.StreetLine1 = "123 Federal Blv.";
                address.StreetLine2 = "321 Westminister st.";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Glenwood",
                StreetLine2 = "Glenmwood Ct.",
                City = "Denver",
                State = "Colorado", 
                Country = "United States",
                PostalCode = "7777"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Klenwood",
                StreetLine2 = "Klenmwood Ct.",
                City = "Kenver",
                State = "Kolorado",
                Country = "Knited States",
                PostalCode = "7777"
            };

            addressList.Add(address);
            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
