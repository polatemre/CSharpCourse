using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglama yapıldı.");
        }
    }
}
