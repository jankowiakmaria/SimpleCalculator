using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleCalculator.Operations;

namespace SimpleCalculatorTests.Operations
{
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
