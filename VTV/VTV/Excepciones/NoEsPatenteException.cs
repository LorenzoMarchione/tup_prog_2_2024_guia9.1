using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Excepciones
{
    internal class NoEsPatenteException : ApplicationException
    {

        public NoEsPatenteException(): base("El texto ingresado debe ser una patente") { }
        public NoEsPatenteException(string message) : base(message) { }
        public NoEsPatenteException(string message, Exception innerException) : base(message, innerException) { }

    }
}
