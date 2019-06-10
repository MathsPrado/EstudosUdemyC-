using System;
using System.Collections.Generic;
using System.Text;

namespace Exceções_Personalizadas.Entities
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
