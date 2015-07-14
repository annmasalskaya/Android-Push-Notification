using System;

namespace BLL.Exceptions
{
    public class UserNotExistException : Exception
    {
        public UserNotExistException() :base() {}
        public UserNotExistException(string message) : base(message) { }
    }
}
