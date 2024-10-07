using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VTV.Excepciones;

namespace VTV.Models
{
    internal class Propietario
    {
        public int DNI;
        public string ApellidosNombres;
        public string Email;

        public Propietario(int dni, string nombre, string email) 
        {
            if (dni <= 1000000) { throw new NroDNIBajoException(); }

            DNI = dni;
            ApellidosNombres = nombre;

            Regex patron = new Regex(@"^[A-Za-z0-9]+@[A-Za-z0-9]+\.com\.[A-Za-z]{2}$");
            Match match = patron.Match(email);
            if (match.Success == false) { throw new DireccionDeCorreoInvalidaException(); }

            Email = email;
        }
        public override string ToString()
        {
            return $"{ApellidosNombres}({DNI})";
        }
    }
}
