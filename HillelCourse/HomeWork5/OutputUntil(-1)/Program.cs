//Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.

namespace OutputUntil
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int [10];
            ArrayFiller(nums);
            ArrayNumOutput(nums);
            Console.ReadKey();
        }

        private static void ArrayNumOutput(int[] nums)
        {
            Console.Write("Hi, I'll count elements in array until it equials (-1): ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]}, ");
                if (nums[i] == -1)
                {
                    break;
                }
            }
        }

        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(-2, 5) ;
                array[i] = randomElem;
            }
        }
    }
}
