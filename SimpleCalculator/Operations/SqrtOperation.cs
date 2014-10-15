using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    public class SqrtOperation : Operation
    {
        public SqrtOperation() : base(1) { }

        public override double Execute(double argument1, double argument2 = 0)
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
