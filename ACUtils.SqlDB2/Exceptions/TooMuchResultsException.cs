﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACUtils.Exceptions
{
    public class TooMuchResultsException : System.Exception
    {
        public TooMuchResultsException(string message) : base(message) { }
    }
}
