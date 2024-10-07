using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTV.Models;

namespace VTV
{
    abstract internal class Evaluacion
    {
        public string nombre { get; protected set; }
        public string descripcion {get; protected set; }

        public Evaluacion(string descripcion, string nombre)
        {
            this.descripcion = descripcion;
            this.nombre = nombre;
        }

        public abstract Tipoaprobacion evaluar();
        
        public override string ToString()
        { return ($"nombre {nombre}, descripcion {descripcion}"); }


    }
}
