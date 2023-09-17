//Задано квадратну матрицю цілих чисел. Підрахуйте кількість негативних та позитивних елементів.

namespace AmountOfNegativeAndPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random  random = new Random();
            int matrixSize = random.Next(2,11);
            int[,] matrix = new int[matrixSize, matrixSize];
            ArrayFiller(matrix);
            PrintArray(matrix);
            int[] positiveAndNegativeNums = new int[2];
            positiveAndNegativeNums = CheckMatrix(matrix);
            Console.WriteLine($"Positive nums amount is {positiveAndNegativeNums[0]}" +
                $"\nNegative nums amount is {positiveAndNegativeNums[1]}");
            Console.ReadKey();
        }

        private static int[] CheckMatrix(int[,] matrix)
        {
            int[] nums = new int[2];
            int positiveNum = 0;
            int negativeNum = 0;
            for (int i = 0; i < matrix.GetUpperBound(0); i++)
            {
                for(int j = 0; j < matrix.GetUpperBound(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        positiveNum = nums[0]++;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        negativeNum = nums[1]++;  
                    }
                }
            }
            return nums;
        }

        private static void ArrayFiller(int[,] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.GetUpperBound(0); i++)
            {
                for (int j = 0; j < array.GetUpperBound(1); j++)
                {
                    array[i, j] = rnd.Next(-5, 6);
                }
            }
        }
        private static void PrintArray(int[,] nums)
        {
            for (int i = 0; i < nums.GetUpperBound(0); i++)
            {
                for (int j = 0; j < nums.GetUpperBound(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}