//Написати програму, яка виводить назву дня неділі за його номером (1 - понеділок, 7 - неділя)
namespace WeekApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("I can name the day of the week throw the numbers you enter" +
                "\nEnter the number from 1 till 7: ");
            int enterNum = int.Parse(Console.ReadLine());
            WeekCheck(enterNum);
            Console.ReadKey();
        }

        private static void WeekCheck(int enterNum)
        {
            switch (enterNum)
            {
                case 1:
                    Console.WriteLine("Wow, it's Monday!"); break;
                case 2:
                    Console.WriteLine("Wow, it's Tuesday!"); break;
                case 3:
                    Console.WriteLine("Wow, it's Wednesday!"); break;
                case 4:
                    Console.WriteLine("Wow, it's Thursday!"); break;
                case 5:
                    Console.WriteLine("Wow, it's Friday!"); break;
                case 6:
                    Console.WriteLine("Wow, it's Saturday!"); break;
                case 7:
                    Console.WriteLine("Wow, it's Sunday!"); break;
                default:
                    Console.WriteLine("This is the wrong Number!"); break;
            }
        }
    }
}