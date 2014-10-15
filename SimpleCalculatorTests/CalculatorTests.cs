using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void AddTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(5, calculator.Calculate("+", 5));
        }

        [Test]
        public void SubtractTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(-5, calculator.Calculate("-", 5));
        }

        [Test]
        public void ClearTest()
        {
            var calculator = new Calculator(5.0);

            Assert.AreEqual(0, calculator.Calculate("C", 0));
        }
    }
}
