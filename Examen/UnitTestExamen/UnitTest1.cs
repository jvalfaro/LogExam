using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen;
using UnitTestExamen.Utility;
using System.Diagnostics;

namespace UnitTestExamen
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class LoggerTest
        {

            [TestInitialize]
            public void TestInicio()
            {
                ConsoleHelper.InicializarConsola();
            }

            [TestCleanup]
            public void TestLimpiar()
            {
                ConsoleHelper.ResetearConsola();
            }


            [TestMethod]
            public void ConsolaLogCreado()
            {
                string mensaje = "Test Consola Mensaje 0000001";
                var oJobLogger = new Logger(Tipos.CONSOLE, Seguridad.WARNING);
                oJobLogger.LogMensaje(mensaje);

                string consoleOutput = ConsoleHelper.ObtenerdatosConsola();

                Assert.IsTrue(consoleOutput.Contains(mensaje));
            }

            [TestMethod]
            public void ArchivoLogCreado()
            {
                //Delete Current Log File
                var fileHelper = new FileHelper();
                fileHelper.EliminarLog();

                string mensaje = "Test Archivo Mensaje 0000001";
                var oJobLogger = new Logger(Tipos.FILE, Seguridad.ERROR);
                oJobLogger.LogMensaje(mensaje);

                //Existe Log File?
                Assert.IsTrue(fileHelper.ExisteLog());
            }

            [TestMethod]
            public void BaseDeDatosLogCreado ()
            {
                //Empty Log Table
                var dataHelper = new DataHelper();
                dataHelper.TablaVacio();

                string mensaje = "Test Base de Datos Message 0000001";
                var oJobLogger = new Logger(Tipos.DATABASE, Seguridad.WARNING);
                oJobLogger.LogMensaje(mensaje);

                //IsLogEmpty
                Assert.IsFalse(dataHelper.LogVacio());
            }

        }
    }
}

