using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public interface ILogger
    {
        void LogMensaje(string mensaje, Seguridad seguridadLevel);
    }
}
