namespace SimpleCalculatorTests
{
    using NUnit.Framework;
    using SimpleCalculator;

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

        [Test]
        public void MultiplyWhenZeroTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(0, calculator.Calculate("*", 10));
        }

        [Test]
        public void MultiplyWhenPositiveTest()
        {
            var calculator = new Calculator(1.5);

            Assert.AreEqual(15, calculator.Calculate("*", 10));
        }

        [Test]
        public void MultiplyWhenNegativeTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.AreEqual(-15, calculator.Calculate("*", 10));
        }

        [Test]
        public void MultiplyWhenBothNegativeTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.AreEqual(15, calculator.Calculate("*", -10));
        }
    }
}
