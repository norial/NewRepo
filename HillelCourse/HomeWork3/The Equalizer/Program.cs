//Необхідно написати консольну програму, де користувач вводитиме з клавіатури 2 числа.
//Числа будуть порівнюватися з наступним виведенням в консоль результату цього порівняння 
//(чи рівні значення, а якщо ні, яке число більше/менше).
namespace TheEqualizer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, lets equalize two numbers below \n Type your first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int secondNum = int.Parse(Console.ReadLine());
            TheEqualizer(firstNum, secondNum);
            Console.ReadKey();
        }

        private static void TheEqualizer(int firstNum, int secondNum)
        {
            if (firstNum > secondNum) 
            {
                Console.WriteLine($"The {firstNum} is bigger then {secondNum}");
            }
            else if (firstNum < secondNum)
            {
                Console.WriteLine($"The {firstNum} is lower then {secondNum}");
            }
            else
            {
                Console.WriteLine("the numbers are equal");
            }
        }
    }
}