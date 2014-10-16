using System.Linq;

namespace SimpleCalculator
{
    using System;
    using System.Collections.Generic;
    using Operations;

    public class Calculator
    {
        private double result;

        readonly Dictionary<string, Operation> operations = new Dictionary<string, Operation>()
        {
            {"+", new AddOperation()},
            {"-", new SubtractOperation()},
            {"C", new ClearOperation()},
            {"*", new MultiplyOperation()},
            {"/", new DivideOperation()},
            {"+/-", new ChangeSignOperation()},
            {"sqrt", new SqrtOperation()}
        };

        public Queue<List<string>> SequenceOfOperationsWithArguments;

        public Calculator(double value = 0.0)
        {
            result = value;
        }

        public double Calculate(string operation, double argument)  //maybe second parameter sholud be optional for operations which require only one argument (the same in interface)
        {
            Operation currentOperation;

            if (operations.TryGetValue(operation, out currentOperation))
            {
                result = currentOperation.Execute(result, argument);
            }
            else
            {
                throw new ArgumentException("Not supported type of operation!");
            }

            return result;
        }

        public void ParseParameters(string parameters)
        {
            SequenceOfOperationsWithArguments = new Queue<List<string>>();
            var parameterList = parameters.Split();

            for (int i = 0; i < parameterList.Length; )
            {
                Operation currentOperation;
                if (operations.TryGetValue(parameterList[i], out currentOperation))
                {
                    var list = new List<string>();
                    list.Add(parameterList[i]);

                    if (parameterList.Length < i + currentOperation.NumberOfParameters)
                    {
                        throw new ArgumentException("Invalid number of parameters for operation: {0}!", parameterList[i]);
                    }
                    for (int j = i + 1; j < i + currentOperation.NumberOfParameters && j < parameterList.Length; j++)
                    {                        
                        double parameter;
                        if (Double.TryParse(parameterList[j], out parameter))
                        {
                            list.Add(parameterList[j]);
                        }
                        else
                        {
                            throw new ArgumentException("Invalid type of parameter: {0}!", parameterList[j]);
                        }
                    }
                    SequenceOfOperationsWithArguments.Enqueue(list);
                    i += Math.Max(1, currentOperation.NumberOfParameters);
                }
                else
                {
                    throw new ArgumentException("Inapropriate type of operation: {0}!", parameterList[i]);
                }
            }
        }

        public double ExecuteSequenceOfOperations(string parameters)
        {
            ParseParameters(parameters);
            foreach (var operationWithArguments in SequenceOfOperationsWithArguments)
            {
                var parameter = operationWithArguments.ElementAtOrDefault(1) ?? "0";
                double parameterValue;
                if (double.TryParse(parameter, out parameterValue))
                {
                    result = Calculate(operationWithArguments[0], parameterValue);
                }
                else
                {
                    throw new ArgumentException("Invalid type of parameter: {0}!", parameter);
                }
            }
            return result;
        }
    }
}
