using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class CarLoanManager : ILoanManager
    {
        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Make()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
