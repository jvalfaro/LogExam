using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Examen
{
    public class FileLogger : ILogger
    {
        public void LogMensaje(string mensaje, Seguridad SeguridadLevel)
        {            
            string directory = ConfigurationManager.AppSettings["LogFileDirectory"];
            string fileName = ConfigurationManager.AppSettings["LogFileName"];
            string fileNameDateFormat = ConfigurationManager.AppSettings["LogFileNameDateFormat"] ;
            string lineformat = ConfigurationManager.AppSettings["LogFileLineFormat"];

            string path = directory + fileName + DateTime.Now.ToString(fileNameDateFormat) + ".txt";
            string logMessage = string.Format(lineformat, DateTime.Now.ToString(), SeguridadLevel, mensaje);

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)){}
            }
                      
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(logMessage);
            }                        
                                  
        } 
    }
}