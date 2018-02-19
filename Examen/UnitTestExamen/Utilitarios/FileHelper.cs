using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnitTestExamen.Utility
{
    public class FileHelper
    {
        public string Path
        {
            get;
            private set;
        }

        public FileHelper()
        {
            string directory = System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"];
            string fileName = System.Configuration.ConfigurationManager.AppSettings["LogFileName"];
            string fileNameDateFormat = System.Configuration.ConfigurationManager.AppSettings["LogFileNameDateFormat"];
            Path = directory + fileName + DateTime.Now.ToString(fileNameDateFormat) + ".txt";
        }

        public void  EliminarLog()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }

        public bool ExisteLog()
        {
            bool exist = File.Exists(Path);
            return exist;
        }
    }
}
