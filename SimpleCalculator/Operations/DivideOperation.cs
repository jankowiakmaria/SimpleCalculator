namespace SimpleCalculator.Operations
{
    using System;

    public class DivideOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            if(argument2 != 0.0)
            {
                return argument1/argument2;
            }
            else
            {
                throw new Exception("You cannot divide by zero");
            }
        }
    }
}
