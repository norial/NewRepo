//Необхідно: створіть клас під назвою Rectangle. 
//    +  У тілі класу створіть два поля, які описують довжини сторін side1, side2.
//    +  Створіть спеціальний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів.
//    +  Створіть два методи, які обчислюють площу прямокутника - double AreaCalculator () і периметр прямокутника - double PerimeterCalculator (). 
//    +  Створіть властивості double Area та double Perimeter за допомогою одного методу get.
//    +  Напишіть програму, яка приймає від користувача довжину двох сторін прямокутника та відображає периметр і площу на екрані.

using System.Runtime.InteropServices;

namespace PerimeterAreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Side1 = UserInput();
            rectangle.Side2 = UserInput();
            Console.Clear();
            new Rectangle(rectangle.Side1, rectangle.Side2);
            Console.ReadKey();
        }

        private static double UserInput()
        {
            double result = 0;
            while (result < 1)
            {
                Console.Write("Enter side of rectangle: ");
                string userInput = Console.ReadLine();
                double.TryParse(userInput, out result);
                if (result < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Unacceptable side value!\n\n");
                }
            }
            return result;
        }
    }
}