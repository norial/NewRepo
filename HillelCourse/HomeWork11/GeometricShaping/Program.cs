/*Ваша мета - створити ієрархію класів для обробки геометричних фігур: кругів і прямокутників.
 * Вам потрібно використовувати успадкування та конструктори з оператором base.
 * 
        Створіть базовий клас Фігура, який містить поля для координат точки початку фігури (X та Y).

        Створіть похідний клас Коло, який успадковує Фігура.
        Додайте до класу Коло додаткове поле Радіус.
        Створіть конструктор для класу Коло, який приймає аргументи для ініціалізації X, Y та Радіуса,
        і викликає конструктор базового класу з використанням оператора base.

        Створіть похідний клас Прямокутник, який успадковує Фігура. 
        Додайте до класу Прямокутник два додаткові поля: Ширина та Висота.
        Створіть конструктор для класу Прямокутник, який приймає аргументи для ініціалізації X, Y, Ширини та Висоти,
        і викликає конструктор базового класу з використанням оператора base.

        Створіть об'єкти класу Коло та Прямокутник, ініціалізуйте їх поля і виведіть інформацію про ці фігури на консоль.

!!!!!Пам'ятайте про використання конструкторів з оператором base для передачі аргументів до базового класу.!!!!!
*/
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GeometricShaping
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            MenuCreator menu = new MenuCreator();
            while(true)
            {
                int input = menu.OptionChoice(true, new MainMenu());
                switch (input)
                {
                    case (int)MainMenu.Enter_Rectingle_Sides_And_Coords:
                        Console.Clear();
                        Console.WriteLine("Enter some data for yor Rectangle");
                        rectangle.Name = rectangle.EnterName();
                        rectangle.GetWidth = rectangle.EnterWidth();
                        rectangle.GetHeight = rectangle.EnterHeigth();
                        rectangle.GetX = rectangle.EnterCoordX();
                        rectangle.GetY = rectangle.EnterCoordY();
                        break;
                    case (int)MainMenu.Enter_Cirlce_Radius_And_Coords: 
                        Console.Clear();
                        circle.Name = circle.EnterName();
                        circle.GetRadius = circle.EnterRadius();
                        circle.GetX = circle.EnterCoordX();
                        circle.GetY = circle.EnterCoordY(); 
                        break;
                    case (int)MainMenu.Rectingle_Info: Console.Clear(); 
                            int inputRec = menu.OptionChoice(true, new RectingleMenu()); switch (inputRec)
                        { 
                            case (int)RectingleMenu.Output_Rectangle_Coords:
                                Console.Clear();
                                Console.WriteLine($"{rectangle.Name} start point are X = {rectangle.GetX}, Y = {rectangle.GetY}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey(); 
                                break;
                            case (int)RectingleMenu.Output_Rectingle_Perimeter:
                                Console.Clear();
                                Console.WriteLine($"{rectangle.Name} {rectangle.OutputPerimeter(rectangle.GetWidth, rectangle.GetHeight)}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)RectingleMenu.Output_Rectingle_Area:
                                Console.Clear(); Console.WriteLine($"{rectangle.Name} {rectangle.OutputArea(rectangle.GetWidth, rectangle.GetHeight)}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)RectingleMenu.Ourput_Rectingle_Sides:
                                Console.Clear();
                                Console.WriteLine($"{rectangle.Name} sides are:width {rectangle.GetWidth}, height {rectangle.GetHeight}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            }
                            break;
                    case (int)MainMenu.Circle_Info: int inputCircle = menu.OptionChoice(true, new CircleMenu()); switch (inputCircle)
                        {
                            case (int)CircleMenu.Output_Circle_Coords:
                                Console.Clear();
                                Console.WriteLine($"{circle.Name} start point are X = {circle.GetX}, Y = {circle.GetY}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)CircleMenu.Output_Circle_Perimeter:
                                Console.Clear();
                                Console.WriteLine($"{circle.Name} {circle.OutputPerimeter(circle.GetRadius)}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)CircleMenu.Output_Circle_Area:
                                Console.Clear(); Console.WriteLine($"{circle.Name} {circle.OutputArea(circle.GetRadius)}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)CircleMenu.Output_Circle_Radius_And_Diameter:
                                Console.Clear();
                                Console.WriteLine($"{circle.Name}  radius is {circle.GetRadius}, diameter is {circle.GetRadius*2}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            case (int)CircleMenu.Output_Circle_Length:
                                Console.Clear();
                                Console.WriteLine($"{circle.Name} {circle.OutputLength(circle.GetRadius)}");
                                Console.WriteLine("Press Enter to continue");
                                Console.ReadKey();
                                break;
                            }; 
                        break;
                    case (int)MainMenu.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}