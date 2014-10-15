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
            {"*", new MultiplyOperation()},
            {"/", new DivideOperation()}
        };

        public Calculator(double value = 0.0)
        {
            result = value;
        }

        public double Calculate(string operation, double argument)  //maybe second parameter sholud be optional for operations which require only one argument (the same in interface)
        {
            IOperation currentOperation;

            if(operations.TryGetValue(operation, out currentOperation))
            {
                result = currentOperation.Execute(result, argument);
            }
            else
            {
                throw new Exception("Not supported type of operation!");
            }

            return result;
        }
    }
}
