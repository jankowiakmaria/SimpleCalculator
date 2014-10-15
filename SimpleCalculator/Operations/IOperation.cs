using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Operations
{
    interface IOperation
    {
        double Execute(double argument1, double argument2);
    }
}
