using Microsoft.VisualStudio.TestTools.UnitTesting;
using AE2.Biz;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Biz.Tests
{
    [TestClass()]
    public class CadenasTests
    {
        [TestMethod()]
        public void cadenaPriTest()
        {
            //Arrange
            Cadenas cad = new Cadenas("PruebaUnitaria");

            char expected = 'P';

            //Atc
            int actual = cad.cadenaPri();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void cadenaUltTest()
        {
            //Arrange
            Cadenas cad = new Cadenas("PruebaUnitaria");

            char expected = 'a';

            //Atc
            int actual = cad.cadenaUlt();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void cadenaDetTest()
        {
            //Arrange
            Cadenas cad = new Cadenas("PruebaUnitaria");

            char expected = 'r';

            //Atc
            int actual = cad.cadenaDet(1);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}