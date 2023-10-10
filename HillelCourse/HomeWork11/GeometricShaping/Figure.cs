//Створіть базовий клас Фігура, який містить поля для координат точки початку фігури (X та Y).

namespace GeometricShaping
{
    public class Figure
    {
        int x;
        int y;
        string name;

        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get { return name; } set{ name = value; } }
       

        public Figure(int x, int y, string name)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
        }
    }
}
