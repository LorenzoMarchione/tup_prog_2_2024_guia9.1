using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Excepciones
{
    internal class DireccionDeCorreoInvalidaException : ApplicationException
    {
        public DireccionDeCorreoInvalidaException() : base("Ingrese una dirección de correo valido") { }
        public DireccionDeCorreoInvalidaException(string message) : base(message) { }
        public DireccionDeCorreoInvalidaException(string message, Exception e) : base(message, e) { }

    }
}
