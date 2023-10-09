using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaping
{
    public class Figure
    {
        int x;
        int y;
        string name;

        public int GetX { get; set; }
        public int GetY { get; set; }
        public string Name { get { return name; } set{ name = value; } }
        public int EnterCoordX()
        {
            Console.Write("Input x Coord:");
            var success = int.TryParse(Console.ReadLine(), out int xCord);
            return xCord;
        }
        public int EnterCoordY()
        {
            Console.Write("Input y Coord:");
            var success = int.TryParse(Console.ReadLine(), out int yCord);
            return yCord;

        }
        public Figure()
        {
            Console.Clear();
            Console.WriteLine("Here you can enter some data for this figure and then check it info");
        }
    }
}
