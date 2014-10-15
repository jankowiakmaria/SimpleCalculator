using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator.Operations;

namespace SimpleCalculator
{
    public class Calculator
    {
        private double result;

        readonly Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>()
        {
            {"+", new AddOperation()},
            {"-", new SubtractOperation()},
            {"C", new ClearOperation()}
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
