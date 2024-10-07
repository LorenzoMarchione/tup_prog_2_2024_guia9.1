using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Models
{
    internal class Evaluacionsimple : Evaluacion
    {
        public bool haverificado;
        public Evaluacionsimple(string nombre, string descripcion) : base(nombre, descripcion)
        {
            base.nombre = nombre;
            base.descripcion = descripcion;
        }

        public override Tipoaprobacion evaluar()
        {
            if (haverificado) return Tipoaprobacion.aprobado;
            return Tipoaprobacion.noaprobado;
           
        }
        public override string ToString()
        {
            return $"{nombre}  -  {descripcion}  -  {evaluar()}";
        }
    }
}
