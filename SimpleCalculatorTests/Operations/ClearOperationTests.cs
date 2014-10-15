namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;

    [TestFixture]
    class ClearOperationTests
    {
        [Test]
        public void ExecuteTest()
        {
            var clearOperation = new ClearOperation();

            Assert.AreEqual(0, clearOperation.Execute(10, 0));
            Assert.AreEqual(0, clearOperation.Execute(10, 9));
        }
    }
}
