using ACM.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Create an instance of the customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId); 

            // Code to retrieve the defined customer

            // Temp hard coded values to return populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "hpotter@mail.com";
                customer.FirstName = "harry";
                customer.LastName = "potter";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // Code to save passed in customer
            return true;
        }
    }
}
