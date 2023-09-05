//Написати програму, в якій користувач вводить номер місяця.
//Якщо місяць 1,2,12 відображає "Зима"; 3,4,5 - «Весна»; 6-8 - «Літо»;
//9-11 – «Осінь». У будь-якому іншому випадку - "Немає такого місяця на цій планеті".

namespace WhatsTheSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hi, enter number 1-12, I'll say what's the season is it: ");
            int inputNum = int.Parse(Console.ReadLine());
            Season(inputNum);
            Console.ReadKey();
        }

        private static void Season(int inputNum)
        {
            if (inputNum == 1 || inputNum == 12 || inputNum == 2)
            {
                Console.WriteLine("Brahhh! it's cold!\nIt's winter!");
            }
            else if (inputNum == 3 || inputNum == 4 || inputNum == 5)
            {
                Console.WriteLine("Wooow! Everything is blooming\nIt's spring");
            }
            else if (inputNum == 6 || inputNum == 7 || inputNum == 8)
            {
                Console.WriteLine("It's crazy hot!\nIt's definitely summer");
            }
            else if (inputNum == 9 || inputNum == 10 || inputNum == 11)
            {
                Console.WriteLine("Leaves are falling everething is orange!\nIts Autumn");
            }
            else 
            {
                Console.WriteLine("There is not an Earth's season");
            }
        }
    }
}