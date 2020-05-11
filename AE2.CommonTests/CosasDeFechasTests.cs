using Microsoft.VisualStudio.TestTools.UnitTesting;
using AE2.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Common.Tests
{
    [TestClass()]
    public class CosasDeFechasTests
    {
        [TestMethod()]
        public void DiaSemanaTest()
        {
            //Arrange
            DateTime fecha = new DateTime(2008, 4, 21);
            string expected = "Monday";

            //Atc
            string actual = CosasDeFechas.DiaSemana(fecha);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CuantoFaltaTest()
        {
            //Arrange
            DateTime fecha = new DateTime(2008, 4, 21);
            DateTime cumple = new DateTime(2008, 4, 24);

            string expected = "Faltan 3 días.";

            //Atc
            string actual = CosasDeFechas.CuantoFalta(fecha, cumple);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FechaActualTest()
        {
            //Arrange
            DateTime expected  = new DateTime(2020, 5, 10).Date;

            //Atc
            DateTime actual = CosasDeFechas.FechaActual();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}