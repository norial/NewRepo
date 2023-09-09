//Урок №4 вивчаємо цикли, массиви та тернаторні оператори

using System.Security;

namespace Lesson4Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вивчаємо псевдорандом
            //Random random = new Random();
            //byte genRandom =(byte)random.Next(2);
            //string output = (genRandom == 0) ? "Bad" : "Good"; // Ternaty operator
            //Console.WriteLine(output);



            ////ForLoop Приклад
            //1) all from 0 till 100 is even
            //for (int i = 0; i < 101; i+=2) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //}
            //for (int i = 0; i < 101; i += 2)
            //{

            //        Console.Write(i + "\t");

            //}
            ////2)From 100 till 0
            //for (int i = 100; i >= 0; i -= 2)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + "\t");
            //    }
            //}

            ////3) sum of all 1 till 100
            //int sum = 0;
            // for (int i = 0; i < 101; i++) 
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}

            //4) is primal num? with Random
            //Random rnd = new Random();
            //int genNum = rnd.Next(2, 1000);
            //CheckAndOutputNum(genNum);
            //Console.ReadKey();



            //private static void CheckAndOutputNum(int genNum)
            //{
            //    for (int i = 2; i < (Math.Sqrt(genNum)); i++)
            //    {
            //        if (genNum % i != 0)
            //        {
            //            Console.WriteLine($"{genNum} is Primal");
            //            return;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{genNum} is Composite");
            //            return;
            //        }
            //    }
            //

            ////WhileLoop Example
            // amount number in numeral
            Random rnd = new Random();
            int number = rnd.Next();
            Console.WriteLine("Random - {0}", number);

            byte countDigits = CountDigits(number);
            Console.WriteLine("CountDigits - {0}", countDigits);
            Console.ReadKey();
        }

        private static byte CountDigits(int number)
        {
            byte count = 1;

            while(number > 9)
            {
                number /= 10;
                count++;
            }

            return count;
        }
    }
}