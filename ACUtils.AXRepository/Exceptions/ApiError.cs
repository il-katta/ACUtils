using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACUtils.AXRepository.Exceptions
{
    public class ApiError : Exception
    {
        public ApiError(string message) : base(message) { }
        public ApiError(string message, Exception innerException) : base(message, innerException) { }
    }
}
