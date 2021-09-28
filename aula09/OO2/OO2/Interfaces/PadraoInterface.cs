using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO2.Interfaces
{
    interface ILogger
    {
        public void Log(string text) => Console.WriteLine(text);

    }

    interface ILoggerPrefix
    {
        public void Log(string text) => Console.WriteLine(Prefix + text);
        
        static string Prefix = "Exemplo: ";
    }

    class Logger : ILoggerPrefix
    {
        
    }
}
