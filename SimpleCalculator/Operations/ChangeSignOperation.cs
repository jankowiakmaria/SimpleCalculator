namespace SimpleCalculator.Operations
{
    public class ChangeSignOperation : Operation
    {
        public ChangeSignOperation() : base(1) { }

        public override double Execute(double argument1, double argument2 = 0)
        {
            return -argument1;
        }
    }
}
