using System;

namespace Ejercicio1.Models
{
    abstract public class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }

        public Evaluacion(string nombre, string descripcion)
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        abstract public TipoAprobacion Evaluar();

        public override string ToString()
        {
            string nombre = Nombre.Length > 20 ? Nombre.Substring(0, 17)+"..." : Nombre.PadRight(20,'_');//padright rellena hasta que el largo sea 20
            string descripcion = Descripcion.Length > 20 ? Descripcion.Substring(0, 17) + "..." : Descripcion.PadRight(20, '_');
            return $"{nombre} - {descripcion} - {Evaluar()}";
        }
    }
}
