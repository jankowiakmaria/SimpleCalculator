namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;

    [TestFixture]
    class AddOperationTests
    {
        [Test]
        public void ExecuteTest()
        {
            var addOperation = new AddOperation();

            Assert.AreEqual(0.0, addOperation.Execute(0,0));
            Assert.AreEqual(0.0, addOperation.Execute(-1, 1));
            Assert.AreEqual(1.0, addOperation.Execute(0, 1));
        }
    }
}
