using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public  class CustomerRepository

    {
        public Customer Retrive(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName = "medo";
                customer.Lastname = "mohsen";
                customer.EmailAddres = "medomohsen293@gmail.com";
            }

            return customer;

        }
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
