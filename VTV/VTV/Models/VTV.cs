using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VTV.Excepciones;

namespace VTV.Models
{
    internal class VTV : IComparable
    {
        public string patente { get; private set; }
        public DateTime fecha { get; private set;}
        public Propietario propietario { get; private set; }
        public int cantverificaciones { get; private set; }
        public List<Evaluacion> verificaciones = new List<Evaluacion>();
        public Evaluacion this[int idx] 
        {
            get
            {
                if (idx >= 0 && idx < verificaciones.Count)
                {
                    return verificaciones[idx];
                }
                return null;
            }
        }
        public Tipoaprobacion Aprobacion 
        { 
            get
            {
                foreach (Evaluacion a in verificaciones)
                {
                    if (a.evaluar() == Tipoaprobacion.noaprobado) return Tipoaprobacion.noaprobado;
                    else if (a.evaluar() == Tipoaprobacion.parcial) return Tipoaprobacion.parcial;
                }
                return Tipoaprobacion.aprobado;
                
            } 
        }

        public VTV(string patente, Propietario propietario)
        {
            Regex patron = new Regex(@"([A-Za-z]{2}\d{3}[A-Za-z]{2})|([A-Za-z]{3}\d{3})");
            Match match = patron.Match(patente);
            if (match.Success == false) { throw new NoEsPatenteException(); }
            
            this.patente = patente;
            this.propietario = propietario;
            fecha = DateTime.Today;
            cantverificaciones = 0;
            verificaciones.Add(new EvaluacionParametrica("Prueba de Frenos delanteros", "Porcentaje de diferencia de frenado entre ejes", 30, 70, "Porcentaje", 40));
            verificaciones.Add(new EvaluacionParametrica("Prueba de Frenos Traseros", "Porcentaje de diferencia de frenado entre ejes", 30, 70, "Porcentaje", 40));
            verificaciones.Add(new EvaluacionParametrica("Alineacion", "Convergencia en grados", 0, 0.5, "Grado", -0.15));
            verificaciones.Add(new EvaluacionParametrica("Luces de corto alcance", "Intensidad lumínica", 10000, 15000, "Candela", 7000));
            verificaciones.Add(new EvaluacionParametrica("Luces de largo alcance", "Intensidad lumínica", 30000, 40000, "Candela", 20000));
            verificaciones.Add(new Evaluacionsimple("Bocina", "Funcionamiento correcto"));
        }
        public string[] EmitirComprobante ()
        {
            string[] listado = new string[8];
            listado[0] = $"{patente} {propietario.ToString()}";
            for (int i = 1; i < 8; i++) 
            {
                listado[i]= verificaciones[i].ToString();
            }
            listado[8] = $"Resultado: {Aprobacion}";
            return listado;
        }
        public override string ToString()
        {
            if (Aprobacion == Tipoaprobacion.parcial)
            {
                int i = 0;
                DateTime reva = fecha;
                while(i != 20)
                {
                    reva.AddDays(1);
                    if(reva.DayOfWeek == DayOfWeek.Monday || reva.DayOfWeek == DayOfWeek.Tuesday || reva.DayOfWeek == DayOfWeek.Wednesday || reva.DayOfWeek == DayOfWeek.Thursday || reva.DayOfWeek == DayOfWeek.Friday)
                    {
                        i++;
                    }
                }
                return $"{patente} | {Aprobacion} | {propietario.DNI} | {fecha} | {reva}";
            }
            return $"{patente} | {Aprobacion} | {propietario.DNI} | {fecha}";
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1 ;
            VTV a = obj as VTV;
            return propietario.DNI.CompareTo(a.propietario.DNI);
        }






    }
}
