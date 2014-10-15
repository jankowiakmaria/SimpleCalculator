using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class ClearOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            return 0.0;
        }
    }
}
