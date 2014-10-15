namespace SimpleCalculator.Operations
{
    using System;

    public class DivideOperation : Operation
    {
        public DivideOperation() : base(2) { }

        public override double Execute(double argument1, double argument2)
        {
            if(argument2 != 0.0)
            {
                return argument1/argument2;
            }
            else
            {
                throw new DivideByZeroException("You cannot divide by zero");
            }
        }
    }
}
