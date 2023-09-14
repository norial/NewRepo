//Написати програму, в якій з масиву видаляється один елемент з позиції, яку вводить користувач. 


namespace RemoveElemInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[random.Next(2, 10)];
            ArrayFiller(array);
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            
            int indexToRemove = GetTheElemToDelete(array);
            int[] newArray = ElementRemover(indexToRemove, array);
            Console.WriteLine("New Array is: ");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ") ;
            }
            Console.ReadKey();
        }

        private static int GetTheElemToDelete(int[] array)
        {
            Console.WriteLine($"\nWhat elem do you want to remove? 1\\{array.Length}");
            int indexToRemove = int.Parse(Console.ReadLine());
            return indexToRemove;
        }

        private static int[] ElementRemover(int remover, int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != remover - 1)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }

        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomElem = rnd.Next(0, 100);
                array[i] = randomElem;
            }
        }
    }
}
