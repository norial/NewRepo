//enum

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Enter first operant:");
            oper1 = GetDoubleNumber();
            Console.Write("Enter second operant:");
            oper2 = GetDoubleNumber();
            Console.Write("Enter the operation(1 - +, 2 - -, 3 - *, 4 - /): ");
            operation = GetOperation();
            result = DoOperation(oper1, oper2 , operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, operation, oper2 ,result);
            Console.ReadKey();

        }
        static Operation GetOperation()
        {
            Operation operation;
            do
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    input = "5";
                }
                operation = (Operation)System.Enum.Parse(typeof(Operation), input);
            }
            while ((int)operation < (int)Operation.Add || (int)operation > (int)Operation.Subtract || (int)operation == (int)Operation.None);
            return operation;
        }
         static double GetDoubleNumber()
        {
            double number;
            bool resParse = false;
            do
            {
                string input = Console.ReadLine();
                resParse = double.TryParse(input, out number);
            }
            while (!resParse || number < 1 || number > 30);
            return number;
        }
        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation) 
            {
                case Operation.Add:
                    result = oper1 + oper2; 
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2; 
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2; 
                    break;
                case Operation.Divide:
                    result = oper1 / oper2; 
                    break;
                default: throw new ArgumentException();
            }
            return result;
        }
    }
}