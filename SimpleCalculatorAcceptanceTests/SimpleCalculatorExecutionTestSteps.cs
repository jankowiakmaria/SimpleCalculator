using System;
using NUnit.Framework;

namespace SimpleCalculatorAcceptanceTests
{
    using TechTalk.SpecFlow;
    using SimpleCalculator;

    [Binding]
    public class SimpleCalculatorExecutionTestSteps
    {
        private Calculator calculator;
        private string sequence;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(double parameter)
        {
            calculator = new Calculator(parameter);
        }

        [When(@"I enter ""(.*)"" into the calculator")]
        public void WhenIEnterIntoTheCalculator(string p0)
        {
            sequence = p0;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(5, calculator.ExecuteSequenceOfOperations(sequence));
        }

        [Then(@"on the screen should appear error message")]
        public void ThenOnTheScreenSholudAppearErrorMessage()
        {
            Assert.Catch(typeof(ArgumentException), () => calculator.ExecuteSequenceOfOperations(sequence));
        }

    }
}
