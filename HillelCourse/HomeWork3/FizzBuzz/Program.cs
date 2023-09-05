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