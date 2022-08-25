using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonaExistenteException : Exception
    {
        public PersonaExistenteException(string message) : base(message)
        {

        }

        public PersonaExistenteException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
