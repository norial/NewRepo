//Написати програму створення масиву із двох масивів. У підсумковому масиві мають бути елементи першого та другого масиву.

namespace SumOfArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array1 = new int[random.Next(2, 10)];
            int[] array2 = new int[random.Next(2, 10)];
            ArrayFiller(array1);
            ArrayFiller(array2);
            CommonArray(array1, array2 );
            OutputArrays(CommonArray(array1, array2), array1, array2);
            Console.ReadKey();
        }

        private static void OutputArrays(int[] ints, int[] array1, int[] array2)
        {
            Console.Write("First array is: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write( $"{array1[i]}, ");
            }
            Console.Write("\nSecond array is: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write( $"{array2[i]}, ");
            }
            Console.Write("\nCommon Array is: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write( $"{ints[i]}, ");
            }
        }

        private static int[] CommonArray(int[] array1, int[] array2)
        {
            int[] commonArray = new int[array2.Length + array1.Length];
            for (int i = 0; i < array1.Length; i++) 
            {
                commonArray[i] = array1[i];
            }
            for (int j = array1.Length; j < commonArray.Length; j++)
            {
                commonArray[j] = array2[j - array1.Length];
            }
            return commonArray;
        }

        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(0, 10);
                array[i] = randomElem;
            }
        }
    }
}