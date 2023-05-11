using System;
namespace Gil.ApiDotNet7.Domain.Validations
{
    public class DomainValidationExceptionException : Exception
    {
        public DomainValidationExceptionException(string error) : base(error) 
        { 

        }
        
        public static void When(bool hasError, string message)
        {
            if(hasError)
                throw new DomainValidationExceptionException(message);
        }
    }
}
