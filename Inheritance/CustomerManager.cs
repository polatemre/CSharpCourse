using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    //Business Classes
    class CustomerManager
    {
        public void PrintCustomerNo(Customer customer)
        {
            Console.WriteLine(customer.CustomerNo);
        }
    }
}
