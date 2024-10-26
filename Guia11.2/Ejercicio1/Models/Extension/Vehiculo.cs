using System;

namespace Ejercicio1.Models.Extension
{
    public class Vehiculo : IComparable<Vehiculo>
    {
        public string Patente { get; set; }
        public int DNIPropietario { get; set; }
        public string NombrePropietario { get; set; }

        public Vehiculo(string patente, int dNIPropietario, string nombrePropietario)
        {
            Patente = patente;
            DNIPropietario = dNIPropietario;
            NombrePropietario = nombrePropietario;
        }

        public int CompareTo(Vehiculo other)
        {
            if(other!=null) Patente.CompareTo(other.Patente);
            return 1;
        }
    }
}
