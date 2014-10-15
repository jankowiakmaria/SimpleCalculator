namespace SimpleCalculatorTests.Operations
{
    using NUnit.Framework;
    using SimpleCalculator.Operations;
    using System;

    [TestFixture]
    class SqrtOperationTest
    {
        [Test]
        public void ExecuteTest()
        {
            var sqrtOperation = new SqrtOperation();

            Assert.AreEqual(0, sqrtOperation.Execute(0, 0));
            Assert.AreEqual(2, sqrtOperation.Execute(4, 0));
            Assert.Catch(typeof(ArgumentOutOfRangeException), () => sqrtOperation.Execute(-1, 0));
        }
    }
}
