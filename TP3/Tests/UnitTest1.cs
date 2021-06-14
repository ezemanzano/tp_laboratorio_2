using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Library;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CrearUnAutomovilCorrectamente()
        {
            //A
            Fabrica fabric = new Fabrica("Test Fabrica");
            fabric.StockElectrico = 20;
            Auto carTest = new Auto("Clio", "Azul",1200,Automoviles.Tipo.Auto,Automoviles.TipoModelo.Base,Automoviles.Motor.Electrico,4);
            //A
            bool aux = fabric.ConsumirMotor(3);
            //A
            Assert.AreEqual(true, aux);
        }

        [TestMethod]
        public void CrearUnAutomovilIncorrectamente()
        {
            //A
            Fabrica fabric = new Fabrica("Test Fabrica");
            fabric.StockElectrico = 0;
            Auto carTest = new Auto("Clio", "Azul", 1200, Automoviles.Tipo.Auto, Automoviles.TipoModelo.Base, Automoviles.Motor.Electrico, 4);
            //A
            bool aux = fabric.ConsumirMotor(3);
            //A
            Assert.AreEqual(false, aux);
        }

        [TestMethod]
        public void GuardarCorrectamente()
        {

            Serializadora<int> stockTest = new Serializadora<int>();
            int nafta = 20;

            bool aux = stockTest.Guardar("StockTest.xml", nafta);

            Assert.AreEqual(true, aux);

        }

        [TestMethod]
        [ExpectedException(typeof(System.InvalidOperationException))]
        public void LeerIncorrectamente()
        {
            Serializadora<int> stockDiesel = new Serializadora<int>();

            int diesel = stockDiesel.Leer("StockDies.xml");

        }


    }
}
