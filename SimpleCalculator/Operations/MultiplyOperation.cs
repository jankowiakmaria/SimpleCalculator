namespace SimpleCalculator.Operations
{
    using System;

    public class MultiplyOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            return argument1*argument2;
        }
    }
}
