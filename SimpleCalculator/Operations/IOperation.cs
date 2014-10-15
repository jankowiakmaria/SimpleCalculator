namespace SimpleCalculator.Operations
{
    interface IOperation
    {
        double Execute(double argument1 = 0.0, double argument2 = 0.0);
    }
}
