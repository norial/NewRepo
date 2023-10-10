//Створіть похідний клас Автомобіль, який успадковує Транспорт.
//  Додайте до класу Автомобіль додаткове поле КількістьДверей.
//  Створіть конструктор для класу Автомобіль, який приймає аргументи для ініціалізації Назви, МаксимальноїШвидкості та КількостіДверей, і викликає конструктор базового класу з використанням оператора base.

namespace VehicleHierarchy
{
    internal class Car : Vehicle
    
    {
        int amountOfDoors;
        public int AmountOfDoors
        {
            get { return amountOfDoors; }
            set { amountOfDoors = value; }
        }
        
        public Car(int doors, int maxSpeed, string name) : base(name, maxSpeed) 
        {
            amountOfDoors = doors;
            Console.WriteLine($"Checking {name} info...");
        }
    }
}
