using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class EvaluacionParametrica:Evaluacion
    {
        public double ValorMinimo { get; private set; }
        public double ValorMaximo { get; private set; }

        public string Unidad { get; private set; }

        public double ValorTolerado { get; private set; }

        public double ValorMedido { get; set; }

        public EvaluacionParametrica(string nombre, string descripcion, double minimo,
                                    double maximo, string unidad, double tolerado):base(nombre, descripcion)
        {
            ValorMinimo = minimo;
            ValorMaximo = maximo;
            Unidad = unidad;
            ValorTolerado = tolerado;
        }

        override public TipoAprobacion Evaluar()
        {
            double valor70 = ValorMinimo * (1-ValorTolerado / 100.0);
            double valor130 = ValorMaximo * (1+ValorTolerado / 100.0);

            if (ValorMedido< valor70)
            {
                return TipoAprobacion.NoAprobacion;
            }
            else if (ValorMedido < ValorMinimo)
            {
                return TipoAprobacion.Parcial;
            }
            else if (ValorMedido <= ValorMaximo)
            {
                return TipoAprobacion.Aprobado;
            }
            else if (ValorMedido < valor130)
            {
                return TipoAprobacion.Parcial;
            }

            return TipoAprobacion.Aprobado;
        }
    }
}
