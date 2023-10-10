using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaping
{
    public class ConsoleClass
    {
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
        public string EnterName()
        {
            Console.Write("Enter Figure name: ");
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
        public double EnterRadius()
        {
            Console.WriteLine("Please, Enter the Radius Below");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int GetRadius);
            return GetRadius;
        }
    }
}
