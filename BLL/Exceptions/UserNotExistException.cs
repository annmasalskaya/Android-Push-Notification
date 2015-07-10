using System;

namespace BLL.Exceptions
{
    class UserNotExistException : Exception
    {
        public UserNotExistException() :base() {}
        public UserNotExistException(string message) : base(message) { }
    }
}
