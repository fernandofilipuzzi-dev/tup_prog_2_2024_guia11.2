
using System.Text.RegularExpressions;

namespace Ejercicio1.Models
{
    public class Propietario
    {
        private int dni;
        public int DNI 
        {
            get 
            { 
                return dni; 
            }
            set 
            {
                if (value < 1000000) 
                    throw new DNINoValidoException($"DNI:{value} rechazado es menor 1000000");

                dni = value;
            }
        }
        public string ApellidosNombres { get; set; }

        string email;
        public string Email 
        {
            get 
            {
                return email;
            }
            set
            {
                if (Regex.Match(value, @"^\s+@{1}\s+\.com\.\s{2}").Success==false)
                    throw new EmailNoValidoException($"Email:{value} no corresponde al formato aceptado");

                email = value;
            }
        }

        public Propietario(int dNI, string nombre)
        {
            DNI = dNI;
            ApellidosNombres = nombre;
        }

        public override string ToString()
        {
            return $"{ApellidosNombres}({DNI})";
        }
    }
}
