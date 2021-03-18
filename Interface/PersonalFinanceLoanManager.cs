using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PersonalFinanceLoanManager : ILoanManager
    {
        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Make()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }
    }
}
