using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new IndividualCustomer { Id = 1, CustomerNo = "123", Name = "Emre", Surname = "Polat", TcNo = "12345678910" };
            Customer musteri2 = new CorporateCustomer { Id = 2, CustomerNo = "234", CompanyName = "Firma", TaxNo = "23456" };

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.PrintCustomerNo(musteri1);
            musteriManager.PrintCustomerNo(musteri2);

            Console.WriteLine(musteri2.CustomerNo); // Customer sınıfının özelliklerine erişemiyoruz bunun için alt satırdaki gibi yazabiliriz.
            Console.WriteLine(((CorporateCustomer)musteri2).CompanyName);
        }
    }
}
