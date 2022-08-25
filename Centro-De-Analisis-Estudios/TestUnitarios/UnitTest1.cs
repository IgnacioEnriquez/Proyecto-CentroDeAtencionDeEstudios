using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class CentroDeAnalisisTest
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorEnArchivoException))]
        public void TestTipoDeArchivoMetodoGuardar()
        {
            CentroDeAnalisis c1 = new CentroDeAnalisis("Centro prueba");

            Universitario u1 = new Universitario("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "Porque abandono");
            Universitario u2 = new Universitario("Fabian", "Ruiz", 45, ESexo.Hombre, EClaseSocial.Clase_Baja, true, 5, "Porque abandono se");

            c1.AgregarPersona(u1);
            c1.AgregarPersona(u2);

            //Pruebo el metodo guardar de CentroDeAnalisis pero le paso mal el formato que deseo,deberia lanzar ErrorEnArchivoException
            c1.Guardar(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"adad");

        }

        [TestMethod]
        [ExpectedException(typeof(PersonaExistenteException))]
        public void TestAgregarPersona()
        {
            CentroDeAnalisis c1 = new CentroDeAnalisis("Centro prueba");

            Universitario u1 = new Universitario("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "Porque abandono");            

            c1.AgregarPersona(u1);

            //Al agregar devuelta a la misma persona deberia lanzar PersonaExistenteException
            c1.AgregarPersona(u1);
        }

        [TestMethod]
        [ExpectedException(typeof(PersonaExistenteException))]
        public void TestCargarEnBaseDeDatos()
        {            
            CentroDeAnalisisBD centroBD = new CentroDeAnalisisBD("CentroBD Prueba");

            Universitario u1 = new Universitario("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "Porque abandono");

            centroBD.CreatePersona(u1);

            //Al agregar devuelta a la misma persona deberia lanzar PersonaExistenteException por la Base de Datos
            centroBD.CreatePersona(u1);

        }

        [TestMethod]

        public void TestContadorInicialesExtension()
        {
            //Creo el centro y añado las personas
            CentroDeAnalisis c1 = new CentroDeAnalisis("Centro prueba");
            Universitario u1 = new Universitario("Ignacio", "Enriquez", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "Porque abandono");
            Universitario u2 = new Universitario("Ignacio", "Scocco", 20, ESexo.Hombre, EClaseSocial.Clase_Media, false, 2, "Porque se retiro");

            //Agrego
            c1.AgregarPersona(u1);
            c1.AgregarPersona(u2);

            //Chequeo que cuente que hay 2 iniciales con I
            Assert.AreEqual(2, c1.ContadorInicialesCentro('I'));

        }
    }
}
