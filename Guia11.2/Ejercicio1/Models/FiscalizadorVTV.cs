using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace Ejercicio1.Models
{
    public class FiscalizadorVTV
    {
        List<VTV> vtvs = new List<VTV>();

        public int CantidadVTVs
        {
            get 
            {
                return vtvs.Count;
            }
        }

        public VTV AgregarVTV(string patente, Propietario propietario, DateTime fecha)
        {
            VTV nuevo = new VTV(patente, propietario, fecha);
            vtvs.Add(nuevo);
            return nuevo;
        }

        public VTV this[int idx] 
        {
            get
            {
                if (idx >= 0 && idx < CantidadVTVs)
                    return vtvs[idx];
                return null;
            }
        }

        public List<VTV> VerVTVPorPatente(string patente)
        {
            List<VTV> vtvsPorPantente = new List<VTV>();
            foreach (VTV vtv in vtvs)
            {
                if(vtv.Patente==patente)
                    vtvsPorPantente.Add(vtv);
            }
            return vtvsPorPantente;
        }

        public void OrdenarVTVsPorDNIPropietario()
        {
            vtvs.Sort();
        }

        public void ImportarVTVs(List<string> lineas)
        {
            foreach (string linea in lineas)
            {
                string[] campos = linea.Split(';');

                VTV vtv = null;
                for (int n = 0; n < campos.Length; n++)
                {
                    switch (campos[0])
                    {
                        case "VTV":
                            {
                                Propietario p = new Propietario(45675654, "Marianela");
                                vtv = this.AgregarVTV("ABC123", p, new DateTime(2020, 12, 5));

                            }
                            break;
                        case "EVA":
                            {
                                int nEva = Convert.ToInt32(campos[1]);
                                if (vtv[nEva] is EvaluacionParametrica)
                                {
                                    double valor = Convert.ToInt32(campos[2]);
                                    ((EvaluacionParametrica)vtv[nEva]).ValorMedido = 56;
                                }
                                else if (vtv[nEva] is EvaluacionSimple)
                                {
                                    double valor = Convert.ToInt32(campos[2]);
                                    ((EvaluacionSimple)vtv[nEva]).ValorMedido = 56;
                                }
                            }
                            break;
                        default:
                            {
                                throw new Exception($"Tipo de registro: {campos[0]} no reconocido.");
                            }
                    }
                }
            }
        }
    }
}
