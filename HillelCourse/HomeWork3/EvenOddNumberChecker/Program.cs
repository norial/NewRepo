//Написати програму, яка перевіряє введене число на парність/непарність.
namespace EvenOddNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, It's Odd/Even number Checker, please enter your number below");
            int inputNum = int.Parse(Console.ReadLine());
            int checkedNum = inputNum;
            CheckNum(inputNum, checkedNum);
            Console.ReadKey();
        }

        private static void CheckNum(int inputNum,int checkedNum)
        {
            checkedNum = inputNum % 2;
            if (checkedNum == 0)
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