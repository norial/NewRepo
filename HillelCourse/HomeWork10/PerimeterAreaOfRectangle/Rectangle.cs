//Необхідно: створіть клас під назвою Rectangle. 
//   +   У тілі класу створіть два поля, які описують довжини сторін side1, side2.
//   +   Створіть спеціальний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів.
//   +   Створіть два методи, які обчислюють площу прямокутника - double AreaCalculator () і периметр прямокутника - double PerimeterCalculator (). 
//   +   Створіть властивості double Area та double Perimeter за допомогою одного методу get.
//      Напишіть програму, яка приймає від користувача довжину двох сторін прямокутника та відображає периметр і площу на екрані.


namespace PerimeterAreaOfRectangle
{
    public class Rectangle
    {
        double side1;
        double side2;
        public double Side1 
        { 
            set 
            { 
                if (value > 0) side1 = value;
            }
            get { return side1; }
        }
        public double Side2
        {
            set
            {
                if (value > 0) side2 = value;
            }
            get { return side2; }
        }
        public double Area
        {
            get { return AreaCalculator(Side1, Side2); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(Side1, Side2); }
        }
        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public void PrintOut(string name, double option)
        {
            Console.WriteLine($"{name} is: {option}");
        }

        private double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }

        private double PerimeterCalculator(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
    }
}
