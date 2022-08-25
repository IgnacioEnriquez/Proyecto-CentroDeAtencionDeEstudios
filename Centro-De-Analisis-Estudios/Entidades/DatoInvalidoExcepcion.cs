using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DatoInvalidoExcepcion : Exception
    {
        public DatoInvalidoExcepcion(string message) : base(message)
        {

        }

        public DatoInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
