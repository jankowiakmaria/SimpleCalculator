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
