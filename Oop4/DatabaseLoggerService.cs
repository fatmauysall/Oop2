using System;
using System.Collections.Generic;
using System.Text;

namespace Oop4
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri tabanına loglamdı.");
        }
    }
}

