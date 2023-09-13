//Потрібно додати до масиву елемент на початок. 
//Масив заповнити рандомними числами.
//Той елемент, що потрібно додати, також взяти рандомно.
//Зробити методи, які в якості параметру приймають масив
//(+ вивід на екран,+ заповнення масиву елементами,+ додавання елементу на початок).


using System;

namespace addingElementAtTheBeggining
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            int[] array = new int[10];
            ArrayFiller(array);
            ArrayAddElem(array);
            OutputTheArray(ArrayAddElem(array));
            
        }

        private static void OutputTheArray(int[] a)
        {
            Console.WriteLine($"new first element is :{a[0]}");
            foreach (int elem in a)
            {
                Console.Write($"{elem}, ");
            }
            Console.ReadKey();
        }

        private static int[] ArrayAddElem(int[] array)
        {
            Random rnd = new Random();
            int randomElem = rnd.Next(1, 100);
            int[] largerArray = new int [array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                largerArray[i+1] = array[i];
            }
            largerArray[0] = randomElem;
            
            return largerArray;
        }

        private static void ArrayFiller(int[] array)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++) 
            {
                int randomElem = rnd.Next(1, 100);
                array[i] = randomElem;
            }
        }
    }
}