﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class ErrorLogger : IErrorLogger
    {
        public void Log(string errorMessage)
        {
            
        }

        public void NewErrorlogger()
        {
            throw new NotImplementedException();
        }
    }
}
