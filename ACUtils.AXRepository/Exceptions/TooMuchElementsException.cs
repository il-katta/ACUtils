using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACUtils.AXRepository.Exceptions
{
    public class TooMuchElementsException : Exception
    {
        public TooMuchElementsException(string message) : base(message) { }
    }
}
