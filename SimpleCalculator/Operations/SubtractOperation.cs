namespace SimpleCalculator.Operations
{
    public class SubtractOperation : Operation
    {
        public SubtractOperation() : base(2) { }

        public override double Execute(double argument1, double argument2)
        {
            return argument1 - argument2;
        }
    }
}
