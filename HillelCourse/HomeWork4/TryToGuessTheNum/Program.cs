//Програма загадує число від 1 до 146 (привіт, Random).
//Користувач намагається вгадати його.
//У разі неправильної відповіді програма підказує «більше» або «менше»

using System.ComponentModel.Design;

namespace TryToGuessTheNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randNum = random.Next(1, 146);
            Console.WriteLine("Try to guess the number I gave you,\np.s. your pc.");
            int userInput = int.Parse(Console.ReadLine());
            CheckTheGuessing(randNum, userInput);
            Console.ReadKey();
        }

        private static void CheckTheGuessing(int randNum, int userInput)
        {
            while (randNum != userInput) 
            {
                if (userInput > randNum)
                {
                    Console.WriteLine("Your answer is bigger!\nTry again");
                    userInput = int.Parse(Console.ReadLine());
                }
                else if (userInput < randNum)
                {
                    Console.WriteLine("Your answer is lower!\nTry again");
                    userInput = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You guessed, well done!!!");
        }
    }
}
