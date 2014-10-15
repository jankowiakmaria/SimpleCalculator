using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class SqrtOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            if (argument1 >= 0 && argument1 < double.PositiveInfinity)
            {
                return Math.Sqrt(argument1);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Inappropriate input parameter!");
            }
        }
    }
}
