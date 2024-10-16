
namespace Ejercicio1.Models
{
    public class EvaluacionSimple : Evaluacion
    {
        public bool HaVerificado { get; set; }

        public EvaluacionSimple(string nombre, string descripcion) :base(nombre, descripcion)
        {
        }

        override public TipoAprobacion Evaluar()
        {
            if(HaVerificado)
                return TipoAprobacion.Aprobado;
            else
                return TipoAprobacion.NoAprobacion;
        }
    }
}
