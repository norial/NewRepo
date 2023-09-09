//Написати програму, яка перевіряє введене число на парність/непарність.
namespace EvenOddNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, It's Odd/Even number Checker, please enter your number below");
            int inputNum = int.Parse(Console.ReadLine());
            bool resultCheck = CheckNum(inputNum);
            DisplayNum(resultCheck, inputNum);
            Console.ReadKey();
        }

        

        private static bool CheckNum(int inputNum)
        {
            return inputNum % 2 == 0;
        }

        private static void DisplayNum(bool resultCheck,int inputNum)
        {
            if (resultCheck == true)
            {
                Console.WriteLine($"The {inputNum} is Even");
            }
            else
            {
                Console.WriteLine($"The {inputNum} is Odd");
            }
        }
    }
}