namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;

    [TestFixture]
    class DivideOperationTests
    {
        [Test]
        public void ExecuteTest()
        {
            var divideOperation = new DivideOperation();

            Assert.AreEqual(0, divideOperation.Execute(0, 1));
            Assert.AreEqual(1, divideOperation.Execute(1, 1));
            Assert.AreEqual(-1, divideOperation.Execute(-1, 1));
            Assert.AreEqual(-1, divideOperation.Execute(1, -1));
            Assert.AreEqual(1, divideOperation.Execute(1, 1));
            Assert.Catch(() => divideOperation.Execute(1, 0));
        }
    }
}
