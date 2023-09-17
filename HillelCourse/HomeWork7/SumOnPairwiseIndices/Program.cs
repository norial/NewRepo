//  Знайти суму елементів масиву, які розміщуються на парних індексах
namespace SumOfPairwiseIndices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            ArrayFiller(nums);
            ArrayPrint(nums);
            int sumOfArray = ArraySummarization(nums);
            Console.WriteLine(sumOfArray);
            Console.ReadKey();
        }

        private static void ArrayPrint(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }

        private static int ArraySummarization(int[] array)
        {
            int arraySum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arraySum += array[i];
                }
            }
            return arraySum;
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