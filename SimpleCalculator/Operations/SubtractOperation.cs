using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class SubtractOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            return argument1 - argument2;
        }
    }
}
