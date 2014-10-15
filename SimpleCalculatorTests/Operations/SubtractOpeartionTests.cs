﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SimpleCalculator.Operations;

namespace SimpleCalculatorTests.Operations
{
    [TestFixture]
    class SubtractOpeartionTests
    {
        [Test]
        public void ExecuteTest()
        {
            var subtractOperation = new SubtractOperation();

            Assert.AreEqual(-1, subtractOperation.Execute(0, 1));
            Assert.AreEqual(0, subtractOperation.Execute(1, 1));
            Assert.AreEqual(1, subtractOperation.Execute(2, 1));
        }
    }
}
