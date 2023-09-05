// a * x^2 + b * x + c = 0
// D = b^2 - 4 * a * c 
// 1) немає коренів - D < 0 
// 2) один корінь - D = 0
// 3) два корені - D > 0

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfRooms;

            int a, b, c; // коефіцієнти рівняння
            a = ReadNumberFromConsole("Enter a: ");
            b = ReadNumberFromConsole("Enter b: ");
            c = ReadNumberFromConsole("Enter c: ");

            int d = CalculateDiscriminant(a, b, c);

            PrintResult(d, a, b);
            Console.ReadKey();
        }

        private static void PrintResult(int d, int a, int b)
        {
            if (d < 0)
            {
                Console.WriteLine("No roots");
            }
            else if (d == 0)
            {
                Console.WriteLine($"1 root {-b / (2 * a)}");
            }
            else
            {
                Console.WriteLine($"1 root {(-b + Math.Sqrt(d)) / (2 * a)}");
                Console.WriteLine($"2 root {(-b - Math.Sqrt(d)) / (2 * a)}");
            }
        }

        private static int CalculateDiscriminant(int a, int b, int c)
        {
            return b * b - 4 * a * c;
        }

        private static int ReadNumberFromConsole(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            bool resParse = int.TryParse(input, out int result);
            if (!resParse)
            {
                Console.WriteLine("Error");
                return -1000;
            }
            return result;
        }
    }
}