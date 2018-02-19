using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExamen.Utility
{
    public class ConsoleHelper
    {
        private static TextWriter defaultConsoleOut;
        private static TextWriter stringWriter;
        private static StringBuilder consoleOutput;

        public static void InicializarConsola()
        {
            defaultConsoleOut = Console.Out;
            consoleOutput = new StringBuilder();
            stringWriter = new StringWriter(consoleOutput);
            Console.SetOut(stringWriter);
        }

        public static void ResetearConsola()
        {
            stringWriter.Flush();
            consoleOutput.Clear();
            Console.Clear();

            stringWriter.Dispose();
            Console.SetOut(defaultConsoleOut);
        }

        public static string ObtenerdatosConsola()
        {
            return consoleOutput.ToString();
        }
    }
}
