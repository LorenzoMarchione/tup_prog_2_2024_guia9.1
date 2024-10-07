using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Excepciones
{
    internal class NroDNIBajoException : ApplicationException
    {
        public NroDNIBajoException():base("El numero de DNI debe ser mayor a 1000000") { }
        public NroDNIBajoException(string message) : base(message) { }
        public NroDNIBajoException(string message, Exception e) : base(message, e) { }
    }
}
