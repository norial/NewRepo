using System.Drawing;

namespace VehicleMoving
{
    internal class Vehicle : IMovable
    {
        public Point Position { get; set; }
        public string Move(int x, int y)
        {
            Position = new Point(x, y);
            return $"moved to {Position}";
        }
    }
}
