//6. Логічні функції, побітові логічні операції та оператори зсуву

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] ints = new int[10];
            //ArrayFiller(ints);                      
            //Array.Sort(ints);
            //Array.Reverse(ints);
            //int[] ints2 = new int[7];
            //Array.Copy(ints, ints2, 6);
            //foreach (int k in ints2)
            //{
            //    Console.Write(k);
            //}
            //Console.WriteLine();
            //foreach (int i in ints )
            //{
            //    Console.Write(i);
            //}
            //Console.ReadKey();

            //// Визначити найбільше значення головної діагоналі 10х10
            
        }
        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(0, 9);
                array[i] = randomElem;
            }
        }
    }

}
