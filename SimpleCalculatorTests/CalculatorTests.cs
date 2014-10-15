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
        public void CalculateAdd()
        {
            var calculator = new Calculator();
            Assert.AreEqual(5, calculator.Calculate("+", 5));
        }

        [Test]
        public void CalculateSubtract()
        {
            var calculator = new Calculator();
            Assert.AreEqual(-5, calculator.Calculate("-", 5));
        }
    }
}
