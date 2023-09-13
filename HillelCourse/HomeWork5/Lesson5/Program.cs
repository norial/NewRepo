
namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Вивести усі елементи массиву у зворотньому порядку

            //char[] charArray = { 'a', 'b', 'c', 'd' };

            //    for (int i = charArray.Length - 1; i >= 0; i--)
            //    {
            //        Console.WriteLine(charArray[i]);
            //    }

            //    string s = "Hello World!";
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        Console.WriteLine(s[j]);
            //    }
            //    Console.ReadKey();
            #endregion
            #region Виводити парні елементи массиву
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}
            #endregion

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int a = 1000;
            //int[] largerArray = new int[nums.Length + 1];
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    largerArray[i] = nums[i];
            //}
            //largerArray[largerArray.Length - 1] = a;
            //foreach (var elem in largerArray)
            //{
            //    Console.WriteLine(elem);
            //}
            //Створити 2-о вимірний массив


            // 1 2 3
            // 4 5 6
            // 7 8 9
            //Console.WriteLine(a.Rank);
            //Console.WriteLine(a[1,1]);

            //Console.WriteLine(array.GetUpperBound(0));
            //Console.WriteLine(array.GetUpperBound(1));
            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.Write('\n');
            //}

            //К-сть позитивних чисел в массиві
            //
            //int counter = 0;
            //foreach (int x in nums)
            //{
            //    if (x > 0) { counter++; }
            //}
            //Console.Write(counter);


            //Reverse the array
            //int[] nums = { -1, 2, -3, 4, 5, -6, 7, 8, -9, 12};
            //int n = nums.Length;

            //for (int i = 0; i < n/2; i++)
            //{
            //    int temp = nums[i];
            //    nums[i] = nums[n - 1 - i];
            //    nums[n - 1 - i] = temp;
            //}

            //foreach (int elem in nums) { Console.WriteLine(elem);  }

            //int[] nums = { -1, 2, 2, -3, 4, 5, -6, 7, 8, -9, 12 };

            //for (int i = 0; i < nums.Length -1; i++ )
            //{
            //    for (int j = i + 1; j < nums.Length; j++ )
            //    {
            //        if(nums[i] > nums[j])
            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}

            //PrintArray(nums);
            //Створити 25 рандомних инт чисел, розрахувати їх середнє значення
            Random rand = new Random();

            int[] randomNumbers = new int[25];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(0, 101);
            }

            //int sum = 0;
            //foreach (var elem in randomNumbers)
            //{
            //    sum += elem;
            //}
            PrintArray(randomNumbers);
            //Console.WriteLine((double)sum/randomNumbers.Length);

            Console.WriteLine(randomNumbers.Sum() / 25.0);
            Console.WriteLine(randomNumbers.Average());



            Console.ReadKey();
        }

        private static void PrintArray(int[] nums)
        {
            foreach (int elem in nums) { Console.WriteLine(elem);  }

        }
    }
}