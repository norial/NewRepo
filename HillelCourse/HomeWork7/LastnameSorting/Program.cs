// Відсортуйте введений список прізвищ за алфавітом та виведіть його на екран.

namespace LastnameSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[] lastnames = new string[random.Next(2,5)];
            StringFiller(lastnames);
            Array.Sort(lastnames);
            PrintArray(lastnames);
            Console.ReadKey();
        }

        private static void PrintArray(string[] lastnames)
        {
            foreach(string lname in lastnames)
            {
                Console.WriteLine(lname);
            }
        }

        private static string[] StringFiller(string[] lastnames)
        {
                Console.Write("Enter first lastname: ");
                lastnames[0] = Console.ReadLine();
           for (int i = 1; i < lastnames.Length; i++)
            {
                Console.WriteLine($"Enter next lastname ({i+1}/{lastnames.Length})");
                lastnames[i] = Console.ReadLine();
            }
            Console.WriteLine();
            return lastnames;

        }
    }
}
