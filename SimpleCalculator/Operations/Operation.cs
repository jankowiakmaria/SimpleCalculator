using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public abstract class Operation : IOperation
    {
        public int NumberOfParameters { get; private set; }

        protected Operation(int numberOfParameters)
        {
            NumberOfParameters = numberOfParameters;
        }

        public abstract double Execute(double argument1 = 0.0, double argument2 = 0.0);
    }
}
