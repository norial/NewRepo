//Ваша мета - створити ієрархію класів для обробки транспортних засобів: автомобілів та велосипедів. Вам потрібно використовувати успадкування та конструктори з оператором base.

//  Створіть об'єкти класу Автомобіль та Велосипед, ініціалізуйте їх поля і виведіть інформацію про ці транспортні засоби на консоль.
//  Пам'ятайте про використання конструкторів з оператором base для передачі аргументів до базового класу та про роботу з транспортними засобами.

using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace VehicleHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            string bicycleName = null;
            string carName = null;
            string bicycleType = null;
            int bMaxSpeed = 0;
            int cMaxSpeed = 0;
            int carDoors = 0;
            MenuCreator menu = new MenuCreator();

            while (true)
            {
                int input = menu.OptionChoice(true, new MainMenu());
                switch (input)
                {
                    case (int)MainMenu.Create_Car:
                        Console.Clear();
                        Console.WriteLine("\tCreating new car");
                        Thread.Sleep(750);
                        Console.Clear();
                        Car car = new Car(carDoors = GetAmountOfDoors(), cMaxSpeed = GetMaxSpeed(), carName = GetName());
                        break;
                    case (int)MainMenu.Create_Bicycle: 
                        Console.Clear();
                        Console.WriteLine("\tCreating new bicycle");
                        Thread.Sleep(750);
                        Console.Clear();
                        Bicycle bicycle = new Bicycle(bicycleType = GetBicycleType(), bicycleName = GetName(), bMaxSpeed = GetMaxSpeed());
                        break;
                    case (int)MainMenu.Print_Bicycle_Info: 
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(" Loading");
                            Thread.Sleep(300);
                            Console.Clear() ;
                            Console.WriteLine(" Loading.");
                            Thread.Sleep(300);
                            Console.Clear() ;
                            Console.WriteLine(" Loading..");
                            Thread.Sleep(300);
                            Console.Clear();
                            Console.WriteLine(" Loading...");
                            Thread.Sleep(300);
                            Console.Clear();
                        }
                        Console.WriteLine($"\tBicycle {bicycleName}\n\ttype {bicycleType}\n\tmax speed {bMaxSpeed} km/h \n\tPress Enter to continue");
                        Console.ReadKey();
                        break;
                    case (int)MainMenu.Print_Car_info:
                        Console.Clear();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(" Loading");
                            Thread.Sleep(300);
                            Console.Clear();
                            Console.WriteLine(" Loading.");
                            Thread.Sleep(300);
                            Console.Clear();
                            Console.WriteLine(" Loading..");
                            Thread.Sleep(300);
                            Console.Clear();
                            Console.WriteLine(" Loading...");
                            Thread.Sleep(300);
                            Console.Clear();
                        }
                        Console.WriteLine($"\tCar {carName}\n\tThere are {carDoors} doors in it\n\tmax speed {cMaxSpeed} km/h \n\tPress Enter to continue");
                        Console.ReadKey();
                        break;
                    case (int)MainMenu.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static int GetAmountOfDoors()
        {
            Console.Write("\tEnter amount of doors in vechicle: ");
            bool success = int.TryParse(Console.ReadLine(), out var doors);
            return doors;
        }

        private static int GetMaxSpeed()
        {
            Console.Write("\tEnter max speed of vechicle: ");
            bool success = int.TryParse(Console.ReadLine(), out var speed);
            return speed;
        }

        private static string GetBicycleType()
        {
            Console.WriteLine("\tEnter bicycle type: ");
            return Console.ReadLine();
        }

        public static string GetName()
        {
            Console.WriteLine("\tEnter Vehicle name: ");
            return Console.ReadLine();
        }
    }

}