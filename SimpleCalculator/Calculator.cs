namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using Operations;

    public class Calculator
    {
        private double result;

        readonly Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>()
        {
            {"+", new AddOperation()},
            {"-", new SubtractOperation()},
            {"C", new ClearOperation()},
            {"*", new MultiplyOperation()}
        };

        public Calculator(double value = 0.0)
        {
            result = value;
        }

        public double Calculate(string operation, double argument)  //maybe second parameter sholud be optional for operations which require only one argument (the same in interface)
        {
            try
            {
                result = operations[operation].Execute(result, argument);
            }
            catch (Exception)
            {
                throw new Exception("Not supported type of operation");
            }

            return result;
        }
    }
}
