//Створіть похідний клас Прямокутник, який успадковує Фігура. 
//Додайте до класу Прямокутник два додаткові поля: Ширина та Висота.
//Створіть конструктор для класу Прямокутник, який приймає аргументи для ініціалізації X, Y, Ширини та Висоти,
//і викликає конструктор базового класу з використанням оператора base
namespace GeometricShaping
{
    public class Rectangle : Figure
    {
        double width;
        double height;
        public double GetWidth { get { return width; } set {  width = value; } }
        public double GetHeight { get { return height; } set { height = value; } }


        public  string OutputPerimeter(double width, double height)
        {
            double perimeter = 2 * (width + height);
            return $"Perimeter is {perimeter}";
        }
        public  string OutputArea(double width, double height)
        {
            double area = height*width;
            return $"Area is {area}";
        }

        public Rectangle(int x, int y, string name, double height, double width) : base(x, y, name)
        {
            GetHeight = height;
            GetWidth = width;
            Console.WriteLine($"Checking Rectangle {name}, Press enter to continue");
            Console.ReadKey();
        }   
    }
}
