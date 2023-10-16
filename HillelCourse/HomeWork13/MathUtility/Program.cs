using System;

namespace MathUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 21;
            int b = 3;
            Console.WriteLine(MathUtility.Addition(a, b));
            Console.WriteLine(MathUtility.Subtraction(a, b));
            Console.WriteLine(MathUtility.Multiplication(a, b));
            Console.WriteLine(MathUtility.Division(a, b));
            Console.WriteLine(MathUtility.Division(a, 0));
            
            Console.ReadKey();
        }
    }
}