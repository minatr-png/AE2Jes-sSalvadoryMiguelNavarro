using Microsoft.VisualStudio.TestTools.UnitTesting;
using AE2.Biz;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE2.Biz.Tests
{
    [TestClass()]
    public class OperacionesTests
    {
        [TestMethod()]
        public void SumarTest()
        {
            //Arrange
            Operaciones oper = new Operaciones(2, 2);

            int expected = 4;

            //Atc
            int actual = oper.Sumar();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestarTest()
        {
            //Arrange
            Operaciones oper = new Operaciones(2, 4);

            int expected = 2;

            //Atc
            int actual = oper.Restar();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultuplicarTest()
        {
            //Arrange
            Operaciones oper = new Operaciones(2, 2);

            int expected = 4;

            //Atc
            int actual = oper.Multiplicar();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}