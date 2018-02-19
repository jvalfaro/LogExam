using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Logger
    {
        private Tipos logTipo;
        private Seguridad seguridadLevel;
        private ILogger logger;

        public Logger(Tipos logTipo, Seguridad seguridadLevel)
        {
            this.logTipo = logTipo;
            this.seguridadLevel = seguridadLevel;
            AsignarTipoLog();
        }

        private void AsignarTipoLog()
        {
            switch (logTipo)
            {
                case Tipos.CONSOLE:
                    logger = new ConsoleLogger();
                    break;
                case Tipos.FILE:
                    logger = new FileLogger();
                    break;
                case Tipos.DATABASE:
                    logger = new DataBaseLogger();
                    break;
                default:
                    break;
            }
        }

        public void LogMensaje(string mensaje)
        {
            if (mensaje != null)
            {
                mensaje.Trim();
                if (mensaje.Length == 0)
                {
                    return;
                }
            }
            else
            {
                return;
            }

            ValidarLogTipo();
            ValidarLogSeguridad();

            logger.LogMensaje(mensaje, seguridadLevel);
        }

        public void ValidarLogTipo()
        {
            if (!Enum.IsDefined(typeof(Tipos), logTipo))
            {
                throw new LoggerException("Registro Invalido");
            }
        }

        public void ValidarLogSeguridad()
        {
            if (!Enum.IsDefined(typeof(Seguridad), seguridadLevel))
            {
                throw new LoggerException("Error o advertencia no especificado");
            }
        }
    }
}