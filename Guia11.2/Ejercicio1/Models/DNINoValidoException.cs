using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class DNINoValidoException : ApplicationException
    {
        public DNINoValidoException() : base("DNI No Valido") { }
        public DNINoValidoException(string message):base(message) { }
        public DNINoValidoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
