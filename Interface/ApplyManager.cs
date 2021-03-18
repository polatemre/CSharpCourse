using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ApplyManager
    {
        public void Apply(ILoanManager loanManager, List<ILoggerService> loggerServices)
        {
            // başvuran bilgileri değerlendirme

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void GivePreliminaryInformation(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Compute();
            }
        }
    }
}
