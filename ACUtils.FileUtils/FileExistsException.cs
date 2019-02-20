using System;
using System.Collections.Generic;
using System.Text;

namespace ACUtils
{
    public class FileExistsException : System.IO.IOException
    {
        public FileExistsException(string message) : base(message) { }
    }
}
