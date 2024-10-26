using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class EmailNoValidoException : ApplicationException
    {
        public EmailNoValidoException() : base("Email No Valido") { }
        public EmailNoValidoException(string message) : base(message) { }
        public EmailNoValidoException(string message, Exception innerException) : base(message, innerException) { }
    }
}
