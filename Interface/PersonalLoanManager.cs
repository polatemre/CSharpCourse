using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class PersonalLoanManager : ILoanManager
    {
        public void Compute()
        {
            throw new NotImplementedException();
        }

        public void Make()
        {
            Console.WriteLine("Bireysel kredi ödeme planı hesaplandı.");
        }
    }
}
