namespace SimpleCalculator.Operations
{
    public class ChangeSignOperation : IOperation
    {
        public double Execute(double argument1, double argument2)
        {
            return -argument1;
        }
    }
}
