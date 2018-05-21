using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Test
{
    [TestClass]
    public class SquareCalculatorTester
    {
        private SquareCalculator calculator;
        [TestInitialize]
        public void SetUp()
        {
            calculator = new SquareCalculator();
        }

        [TestMethod]
        public void CalcRectangleSquareTests_IntMax()
        {
            decimal expectedSquare = 4611686014132420609;
            decimal actualSquare = calculator.CalcRectangleSquare(int.MaxValue, int.MaxValue);
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalcRectangleSquareTests_NegativeValue()
        {
            decimal actualSquare = calculator.CalcRectangleSquare(-1, 2);            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void CalcRectangleSquareTests_ZeroValue()
        {
            decimal actualSquare = calculator.CalcRectangleSquare(0, 2);
        }
    }
}