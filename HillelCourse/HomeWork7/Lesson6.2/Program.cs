namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            #region Передача масиву у метод
            int[] ints = { 1, 2, 3, 4, 5 };
            PrintArray(ints);
            PrintArray(WorkWithArray(ints));
            PrintArray(ints);
            #endregion

            #region Сортування масиву
            int[] intsToSort = { -1, -20, 30, 4, 15 };
            Array.Sort(intsToSort);
            PrintArray(intsToSort);
            #endregion

            #region Сортування масиву рядків відбувається за алфавітом
            string[] strings = { "jhsdsjk", "df", "sjfjsjk" };
            Array.Sort(strings);
            PrintArray(strings);
            #endregion

            #region Рядок є масивов символів
            char[] chars = "Шалаш".ToUpper().ToArray();
            Array.Reverse(chars);
            PrintArray(chars);
            #endregion

            #region Копіювання масиву
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] num2 = new int[4];
            Array.Copy(num, num2, 3);
            PrintArray(num2);
            #endregion

            #region Практичні задачі на масиви
            //Заданий масив дійсних чисел розмірності 10х10. Знайти максимальний елемент головної діагоналі.
            int n = 10;
            int m = 10;
            int[,] nums = new int[n, m];
            nums = FillArray(n, m);
            PrintArray(nums);

            int max = nums[0, 0];
            for (int i = 1; i < n; i++)
            {
                max = nums[i, i] > max ? nums[i, i] : max;
            }
            Console.WriteLine(max);


            //У масиві рядків (список прізвищ) визначте найдовше прізвище.
            string[] lastNames = { "Примушко", "Шемет", "Пирогов", "Руссавський", "Кравченко" };
            int indexMaxLength = 0;
            for (int i = 1; i < lastNames.Length; i++)
            {
                if (lastNames[i].Length > lastNames[indexMaxLength].Length)
                {
                    indexMaxLength = i;
                }
            }
            Console.WriteLine(lastNames[indexMaxLength]);

            //У заданому масиві дійсних чисел знайдіть різницю між максимальним та мінімальним числом.
            int[] numsInts = { -10, 5, 80, -90, 68, 25, -14, 100 };
            Array.Sort(numsInts);
            Console.WriteLine(numsInts[numsInts.Length - 1] - numsInts[0]);

            // Приклад використання CopyTo, Copy, Clone
            int length = numsInts.Length;
            int[] copyNums = new int[length];
            int[] copyNums2 = new int[length];
            int[] cloneNums = new int[length];
            numsInts.CopyTo(copyNums, 0);
            cloneNums = (int[])numsInts.Clone();
            Array.Copy(numsInts, copyNums2, numsInts.Length);

            numsInts[0] = 11111;
            PrintArray(numsInts);
            PrintArray(copyNums);
            PrintArray(copyNums2);
            PrintArray(cloneNums);
            Console.ReadKey();

            #endregion
        }

        private static int[] WorkWithArray(int[] ints)
        {
            int[] ints2 = new int[5];
            ints2 = ints;
            ints2[0] = 111;

            return ints2;
        }

        private static int[,] FillArray(int bound0, int bound1)
        {
            int[,] res = new int[bound0, bound1];
            Random rand = new Random();
            for (int i = 0; i < res.GetUpperBound(0); i++)
            {
                for (int j = 0; j < res.GetUpperBound(1); j++)
                {
                    res[i, j] = rand.Next(-100, 101);
                }
            }
            return res;
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

        private static void PrintArray(int[] nums)
        {
            foreach (int elem in nums) { Console.Write(elem + "\t"); }
            Console.WriteLine();
        }

        private static void PrintArray(string[] strings)
        {
            foreach (var elem in strings) { Console.WriteLine(elem); }
        }

        private static void PrintArray()
        {
            Console.WriteLine("Test");
        }

        private static void PrintArray(char[] chars)
        {
            Console.WriteLine(string.Join("", chars));
        }
    }
}
