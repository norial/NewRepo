//Напишіть програму, яка приймає від користувача число від 1 до 100. 
//При цьому якщо число кратне трьом, програма повинна виводити слово Fizz, а якщо кратно п'яти - слово Buzz. 
//Якщо число кратно п'ятнадцяти, програма повинна виводити слово FizzBuzz. 
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1-100: ");
            int InputNum = int.Parse(Console.ReadLine());
            CalculateInput(InputNum);
            Console.ReadKey();
        }

        private static void CalculateInput(int inputNum)
        {
           if (inputNum % 3 == 0 && inputNum % 5 != 0) 
            {
                Console.WriteLine("Fizz, Fizz, Fizz");
            }
           else if (inputNum % 5 == 0 && inputNum % 3 != 0)
           {
                Console.WriteLine("Buzz, Buzz, Buzz");
           }
           else if ( inputNum % 3 == 0 && inputNum % 5 == 0)
            {
                Console.WriteLine("Fizz-Buzz, Fizz-Buzz, Fizz-Buzz");
            }
            else
            {
                Console.WriteLine("Nothing Happend");
            }
        }
    }
}
