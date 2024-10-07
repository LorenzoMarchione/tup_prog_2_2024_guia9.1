using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTV.Models
{
    internal class FiscalizadorVTV
    {
        public int CantidadVTV { get { return vtvs.Count; } }
        public List<VTV> vtvs = new List<VTV>();
        public VTV this[int idx] 
        { 
            get 
            {
                if (idx >= 0 && idx < vtvs.Count)
                {
                    return vtvs[idx];
                }
                return null;
            } 
        }

        public VTV AgregarVTV (string patente, Propietario propietario)
        {
            VTV a = new VTV(patente, propietario);
            vtvs.Add(a);
            return a;
        }
        public List<VTV> VerVTVPorPatente (string patente)
        {
            OrdenarVTVsPorDNIPropietario();
            List<VTV> a = new List<VTV>();
            foreach (VTV v in vtvs) 
            {
                if (v.patente == patente)
                {
                    a.Add(v);   
                }
            }
            return a;
        }
        public void OrdenarVTVsPorDNIPropietario()
        {
            vtvs.Sort();
        }
    }
}
