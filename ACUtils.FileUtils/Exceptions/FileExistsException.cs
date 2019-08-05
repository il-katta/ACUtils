using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACUtils.Exceptions
{
    public class FileExistsException : System.IO.IOException
    {
        public FileExistsException(string message) : base(message) { }
    }
}
