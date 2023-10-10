//Створіть похідний клас Велосипед, який успадковує Транспорт.
//  Додайте до класу Велосипед додаткове поле ТипВелосипеда.
//  Створіть конструктор для класу Велосипед, який приймає аргументи для ініціалізації Назви, МаксимальноїШвидкості та ТипуВелосипеда, і викликає конструктор базового класу з використанням оператора base.

namespace VehicleHierarchy
{
    internal class Bicycle : Vehicle
    {
        string type;
        public string Type { get; set; }

        public Bicycle(string type, string name, int maxSpeed) : base(name, maxSpeed)
        {
            Type = type;
            Console.WriteLine($"Checking {name} info...");
        }
    }
}
