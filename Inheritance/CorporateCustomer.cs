using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
