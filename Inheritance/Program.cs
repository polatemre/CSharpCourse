using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri1 = new IndividualCustomer();
            Customer musteri2 = new CorporateCustomer();

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
        }
    }
}
