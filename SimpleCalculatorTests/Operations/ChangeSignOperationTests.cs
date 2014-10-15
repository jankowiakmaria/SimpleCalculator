namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;

    [TestFixture]
    class ChangeSignOperationTests
    {
        [Test]
        public void ExecuteTest()
        {
            var changeSignOperation = new ChangeSignOperation();

            Assert.AreEqual(0.0, changeSignOperation.Execute(0, 0));
            Assert.AreEqual(1, changeSignOperation.Execute(-1, 0));
            Assert.AreEqual(-1, changeSignOperation.Execute(1, 0));
        }
    }
}
