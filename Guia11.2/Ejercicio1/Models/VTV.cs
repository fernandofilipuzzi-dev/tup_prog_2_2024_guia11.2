using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Ejercicio1.Models
{
    public class VTV : IComparable
    {
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }
        public DateTime FechaVencimiento
        {
            get
            {
                if (Aprobacion == TipoAprobacion.Parcial)
                {
                    DateTime vencimiento = Fecha;
                    int diasHabiles = 20;
                    while (diasHabiles > 0)//mientras queden dias habiles
                    {
                        if (vencimiento.DayOfWeek != DayOfWeek.Saturday && vencimiento.DayOfWeek != DayOfWeek.Saturday)
                        {
                            diasHabiles--;
                        }
                        vencimiento=vencimiento.AddDays(1);
                    }
                    return vencimiento;
                }
                else if (Aprobacion == TipoAprobacion.Aprobado)
                {
                    return Fecha.AddYears(1);
                }
                return DateTime.MinValue;//recuerden que admite null
            }
        }

        public int CantidadVerificaciones
        {
            get 
            {
                return evaluaciones.Count;
            }
        }

        public List<Evaluacion> evaluaciones =new List<Evaluacion>();
        public Evaluacion this[int idx]
        {
            get 
            {
                return evaluaciones[idx];
            }
        }

        public Propietario Propietario { get; private set; }

        public TipoAprobacion Aprobacion 
        {
            get
            {
                TipoAprobacion menor = TipoAprobacion.NoAprobacion;
                int n = 0;
                foreach (Evaluacion ev in evaluaciones)
                {
                    TipoAprobacion valor = ev.Evaluar();

                    if (n == 0 || valor < menor)
                        menor = valor;
                    n++;
                }
                return (TipoAprobacion)menor;
            }
        }

        public VTV(string patente, Propietario propietario, DateTime fecha)
        {
            if (Regex.Match(patente, @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$|^[A-Z]{3}[0-9]{3}$", RegexOptions.IgnoreCase).Success==false)
                throw new PatenteNoValidoException($"Patente:{patente} formato no reconocido");

            Patente = patente;

            Propietario = propietario;
            Fecha = fecha;

            evaluaciones.AddRange(
                new Evaluacion[]
                {
                    new EvaluacionParametrica("Prueba de frenos delanteros", "Porcentaje de diferencia de freando entre ejes", 0,30, "Porcentaje", 30),
                    new EvaluacionParametrica("Prueba de frenos traseros", "Porcentaje de diferencia de freando entre ejes", 0, 30, "Porcentaje", 30),
                    new EvaluacionParametrica("Alineación", "Convergencia en grados", 0, 0.5, "Grado", 30),
                    new EvaluacionParametrica("Luces de corto alcance", "Intensidad lumínica", 10000, 15000, "Candela", 30),
                    new EvaluacionParametrica("Luces de largo alcance", "Intensidad lumínica", 30000, 40000, "Candela", 30),
                    new EvaluacionSimple("Bocina", "Funcionamiento correcto")
                });
        }

        public string[] EmitirComprobante()
        {   
            string[] lineas = new string[evaluaciones.Count+2];

            int n = 0;
            
            lineas[n++] = ToString();

            foreach (Evaluacion ev in evaluaciones)
            {
                lineas[n++] = ev.ToString();
            }

            string fechaVencimiento =  FechaVencimiento> DateTime.MinValue ? $"- Vencimiento:{FechaVencimiento:dd/MM/yyyy}" : "";
            lineas[n] = $"Resultado:{Aprobacion} {fechaVencimiento}";


            return lineas;
        }

        public int CompareTo(object obj)
        {
            VTV otro= obj as VTV;
            if (otro != null) this.Propietario.DNI.CompareTo(otro.Propietario.DNI);
            return 1;
        }

        public override string ToString()
        {
            //patente| Estado Aprobación| fecha realización | fecha de vencimiento.
            TipoAprobacion estado = Aprobacion;
            if(estado == TipoAprobacion.NoAprobacion )
                return $"{Patente,8} | {estado,15} | {Propietario.DNI,10}|{Fecha:dd/MM/yyyy} ";
            else
                return $"{Patente,8} | {estado,15} | {Propietario.DNI,10}|{Fecha:dd/MM/yyyy} | {FechaVencimiento:dd/MM/yyyy}";
        }
    }
}
