using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class LoggerException : Exception
    {
        public LoggerException(string mensaje) : base(mensaje) {}
    }
}
