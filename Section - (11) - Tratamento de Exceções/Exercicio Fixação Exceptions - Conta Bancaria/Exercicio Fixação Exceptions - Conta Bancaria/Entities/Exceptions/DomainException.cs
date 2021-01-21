using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixação_Exceptions___Conta_Bancaria.Entities.Exceptions
{
    class DomainException : ApplicationException
    {

        public DomainException (string message) : base(message)
        {   
        }



    }
}
