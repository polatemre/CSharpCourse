using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglama yapıldı.");
        }
    }
}
