using System;

namespace Oop4
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglamdı.");
        }
    }
}

