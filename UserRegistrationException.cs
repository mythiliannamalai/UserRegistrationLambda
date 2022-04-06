using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    public class UserRegistrationException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Invalid
        }
        public UserRegistrationException(ExceptionType type, string Message) : base(Message)
        {
            this.type = type;
        }
    } 
}
