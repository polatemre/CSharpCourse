using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        //Interface new'lenemez.
        static void Main(string[] args)
        {
            ILoanManager personalLoanManager = new PersonalLoanManager();
            ILoanManager personalFinanceLoanManager = new PersonalFinanceLoanManager();
            ILoanManager carLoanManager = new CarLoanManager();
            ILoanManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            ApplyManager applyManager = new ApplyManager();
            applyManager.Apply(new PersonalFinanceLoanManager(), loggers);

            // Alt satırdaki parantez default constructor çalışacağını belirtir. Parantez konmasa da default constructor çalışacaktır.
            List<ILoanManager> loans = new List<ILoanManager>() { personalLoanManager, carLoanManager };
        }
    }
}
