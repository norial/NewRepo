//Створіть похідний клас Прямокутник, який успадковує Фігура. 
//Додайте до класу Прямокутник два додаткові поля: Ширина та Висота.
//Створіть конструктор для класу Прямокутник, який приймає аргументи для ініціалізації X, Y, Ширини та Висоти,
//і викликає конструктор базового класу з використанням оператора base
namespace GeometricShaping
{
    public class Rectangle : Figure
    {
        string name;
        double width;
        double height;
        public string Name { get { return name; } set { name = value; } }
        public double GetWidth { get { return width; } set {  width = value; } }
        public double GetHeight { get { return height; } set { height = value; } }

        public string EnterName()
        {
            Console.Write("Enter Rectangle name: ");
            string name = Console.ReadLine();
            return name;
        }
        public double EnterHeigth()
        {
            Console.WriteLine("Please, Enter the Heigth Below");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int HSide);
            return HSide;
        }
        public double EnterWidth()
        {
            Console.WriteLine("Please, Enter the Width Below");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int WSide);
            return WSide;
        }
        public string OutputPerimeter(double Width, double Height)
        {
            double perimeter = 2*(Width+Height);
            return $"Perimeter is {perimeter}";
        }
        public string OutputArea(double Width, double Height)
        {
            double area = Height*Width;
            return $"Area is {area}";
        }

        public Rectangle() : base()
        {
            Console.WriteLine("Creating Rectangle, Press enter to continue");
            GetX = base.GetX;
            GetY = base.GetY;
            Console.ReadKey();
        }   
    }
}
