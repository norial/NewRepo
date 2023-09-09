namespace IsPrimalNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int genNum = rnd.Next(2, 1000);
            CheckAndOutputNum(genNum);
            Console.ReadKey();

        }

        private static void CheckAndOutputNum(int genNum)
        {
            for (int i = 2; i < (Math.Sqrt(genNum)); i++)
            {
                if (genNum % i != 0)
                {
                    Console.WriteLine($"{genNum} is Primal");
                    return;
                }
                else
                {
                    Console.WriteLine($"{genNum} is Composite");
                    return;
                }
            }
        }
    }

}