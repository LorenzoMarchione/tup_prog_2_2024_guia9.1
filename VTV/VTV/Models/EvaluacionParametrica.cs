using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Models
{
    internal class EvaluacionParametrica : Evaluacion
    {
        public double valormin { get; private set; }
        public double valormax { get; private set; }
        public string unidad { get; private set; }
        public double valortolerado { get; private set; }   
        public double valormedido;

        public EvaluacionParametrica(string nombre, string descricpion, double min, double max, string unidad, double tolerado): base(nombre, descricpion)
        {
            base.nombre = nombre;
            base.descripcion = descricpion;
            valormin = min;
            valormax = max;
            this.unidad = unidad;
            valortolerado = tolerado;
        }
        public override Tipoaprobacion evaluar()
        {
            if (valormedido < valormin * 0.7 | valormedido > valormax * 1.3) return Tipoaprobacion.noaprobado;
            if (valormedido < valormin | valormedido > valormax) return Tipoaprobacion.parcial;
            return Tipoaprobacion.aprobado;
           /* if (valormedido<=valormax && valormedido>=valormin) { return Tipoaprobacion.aprobado;  }
            else if (valormedido<=valormax*1.3 && valormedido>=valormin*0.7) { return Tipoaprobacion.parcial; }
            return Tipoaprobacion.noaprobado;*/
        }
        public override string ToString()
        {
            return $"{nombre}  -  {descripcion} - {evaluar()}";
        }

    }
}
