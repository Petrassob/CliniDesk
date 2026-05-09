using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniDesk.Business
{
    public class BusinessException : Exception
    {
     public BusinessException(string message) : base(message) { }

    } 
    public class InvalidCredentialsException : BusinessException
    {
        public InvalidCredentialsException(string message)
            : base(message) { }
    }
    public class UserAlreadyExistsException : BusinessException
    {
        public UserAlreadyExistsException(string message)
            : base(message) { }
    }
    public class ValidationException : BusinessException
    {
        public ValidationException(string message)
            : base(message) { }
    }

}
