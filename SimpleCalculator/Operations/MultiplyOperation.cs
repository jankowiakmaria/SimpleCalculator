namespace SimpleCalculator.Operations
{
    using System;

    public class MultiplyOperation : Operation
    {
        public MultiplyOperation() : base(2) { }

        public override double Execute(double argument1, double argument2)
        {
            return argument1*argument2;
        }
    }
}
