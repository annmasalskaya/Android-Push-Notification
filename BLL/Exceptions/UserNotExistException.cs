using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Exceptions
{
    class UserNotExistException : Exception
    {
        public UserNotExistException() :base() {}
        public UserNotExistException(string message) : base(message) { }
    }
}
