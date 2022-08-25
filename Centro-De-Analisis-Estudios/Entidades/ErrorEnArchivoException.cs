using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorEnArchivoException : Exception
    {
        public ErrorEnArchivoException(string message) : base(message)
        {

        }

        public ErrorEnArchivoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
