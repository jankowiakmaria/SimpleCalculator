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

        readonly Dictionary<string, IOperation> Operations = new Dictionary<string, IOperation>()
        {
            {"+", new AddOperation()}
        };

        public double Calculate(string operation, double argument)
        {
            try
            {
                result = Operations[operation].Execute(result, argument);
            }
            catch (Exception)
            {
                throw new Exception("Not supported type of operation");
            }

            return result;
        }
    }
}
