﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IErrorLogger
    {
        void Log(string errorMessage);
    }
}