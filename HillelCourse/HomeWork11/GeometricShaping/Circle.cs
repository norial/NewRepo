//Створіть похідний клас Коло, який успадковує Фігура.
//Додайте до класу Коло додаткове поле Радіус.
//Створіть конструктор для класу Коло, який приймає аргументи для ініціалізації X, Y та Радіуса,
//і викликає конструктор базового класу з використанням оператора base.
namespace GeometricShaping
{
   class Circle : Figure
    {
        double radius;
        public double GetRadius { get { return radius; } set {  radius = value; } }

        
         public string OutputPerimeter(double radius)
        {
            int perimeter = (int)(2 * Math.PI * radius);
            return $"Perimeter is {perimeter}";
        }
        public string OutputArea(double radius)
        {
            int area = (int)(Math.PI*radius*radius);
            return $"Area is {area}";
        }
        public string OutputLength(double radius)
        {
            int length = (int)(Math.PI * radius);
            return $"Length is {length}";
        }
        public Circle(int x, int y, string name, double radius) : base(x, y, name)
        {
            GetRadius = radius;
            Console.WriteLine($"Checking circle {name}, Press enter to continue");
            Console.ReadKey();
        }
    }
}
