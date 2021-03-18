using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class MortgageLoanManager : ILoanManager
    {
        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Make()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
