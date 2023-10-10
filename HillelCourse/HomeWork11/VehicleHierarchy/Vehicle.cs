//Створіть базовий клас Транспорт, який містить поля для назви транспортного засобу (Назва) та максимальної швидкості (МаксимальнаШвидкість).

using System.Threading.Channels;
using System.Transactions;

namespace VehicleHierarchy
{
    public class Vehicle
    {
        int maxSpeed;
        string name;
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set { maxSpeed = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Vehicle(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;

        }
    }
}
