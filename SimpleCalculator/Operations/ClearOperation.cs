namespace SimpleCalculator.Operations
{
    public class ClearOperation : Operation
    {
        public ClearOperation() : base(0) { }

        public override double Execute(double argument1 = 0, double argument2 = 0)
        {
            return 0.0;
        }
    }
}
