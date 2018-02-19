using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje = "Mensaje de prueba 2";
            Logger oJobLogger = new Logger(Tipos.FILE, Seguridad.ERROR);
            oJobLogger.LogMensaje(mensaje);
            Console.ReadLine();
        }
    }
}
