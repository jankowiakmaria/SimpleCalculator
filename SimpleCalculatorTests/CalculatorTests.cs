using System;

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

        [Test]
        public void DivideWhenZeroTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(0, calculator.Calculate("/", 10));
        }

        [Test]
        public void DivideWhenPositiveTest()
        {
            var calculator = new Calculator(1.5);

            Assert.AreEqual(0.15, calculator.Calculate("/", 10));
        }

        [Test]
        public void DivideWhenNegativeTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.AreEqual(-0.15, calculator.Calculate("/", 10));
        }

        [Test]
        public void DivideWhenBothNegativeTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.AreEqual(0.15, calculator.Calculate("/", -10));
        }
        [Test]
        public void DivideByZeroTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.Catch(typeof(DivideByZeroException), () => calculator.Calculate("/", 0));
        }

        [Test]
        public void ChangeSignWhenZeroTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(0, calculator.Calculate("+/-", 10));
        }

        [Test]
        public void ChangeSignWhenPositiveTest()
        {
            var calculator = new Calculator(1.5);

            Assert.AreEqual(-1.5, calculator.Calculate("+/-", 10));
        }

        [Test]
        public void ChangeSignWhenNegativeTest()
        {
            var calculator = new Calculator(-1.5);

            Assert.AreEqual(1.5, calculator.Calculate("+/-", 10));
        }

        [Test]
        public void SqrtWhenNegativeTest()
        {
            var calculator = new Calculator(-1);

            Assert.Catch(typeof(ArgumentOutOfRangeException), () => calculator.Calculate("sqrt", 0));
        }

        [Test]
        public void SqrtWhenZeroTest()
        {
            var calculator = new Calculator();

            Assert.AreEqual(0, calculator.Calculate("sqrt", 0));
        }

        [Test]
        public void SqrtWhenPositiveTest()
        {
            var calculator = new Calculator(4);

            Assert.AreEqual(2, calculator.Calculate("sqrt", 0));
        }

        [Test]
        public void InvalidOperationTest()
        {
            var calculator = new Calculator();

            Assert.Catch(typeof (ArgumentException), () => calculator.Calculate("xyz", 15));
        }

        [Test]
        public void CheckOperationSequenceTest()
        {
            var calculator = new Calculator();
            calculator.ParseParameters("C + 3 - 7 +/- sqrt * 5 / 2");

            Assert.AreEqual("C", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("+", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("-", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("+/-", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("sqrt", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("*", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
            Assert.AreEqual("/", calculator.SequenceOfOperationsWithArguments.Dequeue()[0]);
        }

        [Test]
        public void CheckOperationParametersTest()
        {
            var calculator = new Calculator();
            calculator.ParseParameters("C + 3 - 7 +/- sqrt * 5 / 2");

            Assert.AreEqual(1, calculator.SequenceOfOperationsWithArguments.Dequeue().Count);
            Assert.AreEqual("3", calculator.SequenceOfOperationsWithArguments.Dequeue()[1]);
            Assert.AreEqual("7", calculator.SequenceOfOperationsWithArguments.Dequeue()[1]);
            Assert.AreEqual(1, calculator.SequenceOfOperationsWithArguments.Dequeue().Count);
            Assert.AreEqual(1, calculator.SequenceOfOperationsWithArguments.Dequeue().Count);
            Assert.AreEqual("5", calculator.SequenceOfOperationsWithArguments.Dequeue()[1]);
            Assert.AreEqual("2", calculator.SequenceOfOperationsWithArguments.Dequeue()[1]);
        }

        [Test]
        public void CheckInappropriateParametersTest()
        {
            var calculator = new Calculator();
            Assert.Catch(typeof (ArgumentException), () => calculator.ParseParameters("C 3 - 7 +/- sqrt * 5 / 2"));

        }
    }
}
