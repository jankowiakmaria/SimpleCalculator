namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;

    [TestFixture]
    class MultiplyOperationTests
    {
        [Test]
        public void ExecuteTest()
        {
            var multiplyOperation = new MultiplyOperation();

            Assert.AreEqual(0, multiplyOperation.Execute(0, 10));
            Assert.AreEqual(-10, multiplyOperation.Execute(-1, 10));
            Assert.AreEqual(10, multiplyOperation.Execute(-1, -10));
        }
    }
}
