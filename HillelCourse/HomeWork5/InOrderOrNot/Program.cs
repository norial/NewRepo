//Вказано п'ять довільних цілих чисел (елементи масиву).
//Визначити, чи є їхнє розташування в масиві впорядкованим
//(тобто за зростанням або за спаданням) чи невпорядкованим.

namespace InOrderOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5] { 48, 55, 69, 70, 95 };
            //ArrayFiller(array1);
            bool isSortedAscending = IsSortedAscending(array1); // 1 - 5
            bool isSortedDescending = IsSortedDescending(array1); // 5 - 1
            if (isSortedAscending)
            {
                Console.WriteLine("The array is ordered by growth.");
            }
            else if (isSortedDescending)
            {
                Console.WriteLine("The array is ordered in descending order.");
            }
            else
            {
                Console.WriteLine("The array is not ordered.");
            }

            Console.ReadKey();

        }
        static bool IsSortedDescending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        private static bool IsSortedAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    

        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(0, 5);
                array[i] = randomElem;
            }
        }
    }
}