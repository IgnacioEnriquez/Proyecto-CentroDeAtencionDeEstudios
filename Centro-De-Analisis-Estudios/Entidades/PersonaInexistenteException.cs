using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaInexistenteException : Exception
    {
        public PersonaInexistenteException(string message) : base(message)
        {

        }

        public PersonaInexistenteException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
