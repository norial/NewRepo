namespace VehicleMoving
{
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car();
            Console.WriteLine($"" +
            $"{ toyota.Move(6, 3) }\n" +
            $"{ toyota.StartEngine() }\n" +
            $"{ toyota.Move(9, 9) } \n" +
            $"{ toyota.StopEngine() } \n");
            Console.ReadLine();
        }
    }
}