using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class ErrorLogger : IErrorLogger, INewErrorLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("Error Log");
        }

        public void NewLog(string errorMessage)
        {
            Console.WriteLine("New Log");
        }
    }
}
