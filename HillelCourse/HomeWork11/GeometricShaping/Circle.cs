//Створіть похідний клас Коло, який успадковує Фігура.
//Додайте до класу Коло додаткове поле Радіус.
//Створіть конструктор для класу Коло, який приймає аргументи для ініціалізації X, Y та Радіуса,
//і викликає конструктор базового класу з використанням оператора base.
namespace GeometricShaping
{
   class Circle : Figure
    {
        string name;
        double radius;
        public string Name { get; set; }
        public double GetRadius { get { return radius; } set {  radius = value; } }

        public string EnterName()
        {
            Console.Write("Enter Rectangle name: ");
            string name = Console.ReadLine();
            return name;
        }
        public double EnterRadius()
        {
            Console.WriteLine("Please, Enter the Radius Below");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int GetRadius);
            return GetRadius;
        }
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
        public Circle()
        {
            Console.WriteLine("Creating circle, Press enter to continue");
            GetX = base.GetX;
            GetY = base.GetY;
            Console.ReadKey();
        }
    }
}
