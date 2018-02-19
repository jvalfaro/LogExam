using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class ConsoleLogger : ILogger
    {
        public void LogMensaje(string mensaje, Seguridad SeguridadLevel)
        {
            switch (SeguridadLevel)
            {
                case Seguridad.ERROR:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Seguridad.WARNING:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Seguridad.MESSAGE:
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                default:
                    return;
            }

            Console.WriteLine(DateTime.Now.ToShortDateString() + " " + mensaje);

            //Sets the foreground and background console colors to their defaults.
            Console.ResetColor();
        }
    }
}
