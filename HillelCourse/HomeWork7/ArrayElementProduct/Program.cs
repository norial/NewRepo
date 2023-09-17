//Знайти добуток елементів масиву, які більші за задане число.
namespace ArrayElementProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            ArrayFiller(nums);
            ArrayPrint(nums);
            int prodOfArray = ArrayProduct(nums);
            Console.WriteLine(prodOfArray);
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

        private static int ArrayProduct(int[] array)
        {
            Console.Write("Type your num: ");
            int userChoice = int.Parse(Console.ReadLine());
            int arrayProd = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > userChoice)
                {
                    arrayProd *= array[i];
                }
            }
            return arrayProd;
        }
        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(1, 11);
                array[i] = randomElem;
            }
        }
    }
}