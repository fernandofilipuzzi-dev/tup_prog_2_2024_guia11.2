using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;

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
                if (vtv.Patente == patente)
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
            VTV vtv = null;

            foreach (string linea in lineas)
            {
                #region parsing
                string[] campos = linea.Split(';');
                string tipo = campos[0].Trim();
                #endregion

                switch (tipo)
                {
                    case "VTV":
                        {
                            #region parsing
                            string patente = campos[1].Trim();
                            int dni = Convert.ToInt32(campos[2].Trim());
                            string nombre = campos[3].Trim();
                            string fechaString = campos[4].Trim();
                            DateTime fecha = DateTime.ParseExact(fechaString, "d-M-yyyy", CultureInfo.InvariantCulture);
                            #endregion

                            /*el vtv me devuelve un objetos con todas las evaluaciones listas para completarle el valor
                             medido*/
                            Propietario p = new Propietario(dni, nombre);
                            vtv = this.AgregarVTV(patente, p, fecha);
                        }
                        break;
                    case "EVA":
                        {
                            #region parsing
                            int nEva = Convert.ToInt32(campos[1]);
                            #endregion

                            if (vtv[nEva] is EvaluacionParametrica)
                            {
                                EvaluacionParametrica evap = (EvaluacionParametrica)vtv[nEva];

                                #region parsing
                                double valorMedido = Convert.ToDouble(campos[2].Trim());
                                #endregion

                                evap.ValorMedido = valorMedido;
                            }
                            else if (vtv[nEva] is EvaluacionSimple)
                            {
                                EvaluacionSimple evaS = (EvaluacionSimple)vtv[nEva];

                                #region parsing
                                bool haVerificado = Convert.ToInt32(campos[2].Trim()) >= 1;
                                #endregion

                                evaS.HaVerificado = haVerificado;
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
