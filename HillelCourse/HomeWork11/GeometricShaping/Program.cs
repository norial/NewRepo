/*Ваша мета - створити ієрархію класів для обробки геометричних фігур: кругів і прямокутників.
 * Вам потрібно використовувати успадкування та конструктори з оператором base.
 
 * Створіть об'єкти класу Коло та Прямокутник, ініціалізуйте їх поля і виведіть інформацію про ці фігури на консоль.

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
            ConsoleClass console = new ConsoleClass();
            MenuCreator menu = new MenuCreator();
            string rectName = null;
            string circlName = null;
            int rX = 0;
            int cX = 0;
            int rY = 0;
            int cY = 0;
            double rectWidth = 0;
            double rectHeight = 0;
            double radius = 0;
            while (true)
            {
                int input = menu.OptionChoice(true, new MainMenu());
                switch (input)
                {
                    case (int)MainMenu.Enter_Rectingle_Sides_And_Coords:
                        Console.Clear();
                        Console.WriteLine("Enter some data for yor Rectangle");
                        rectName = console.EnterName();
                        rX = console.EnterCoordX();
                        rY = console.EnterCoordY();
                        rectWidth = console.EnterWidth();
                        rectHeight = console.EnterHeigth();
                        break;
                    case (int)MainMenu.Enter_Cirlce_Radius_And_Coords: 
                        Console.Clear();
                        Console.WriteLine("Enter some data for yor Circle");
                        circlName = console.EnterName();
                        cX = console.EnterCoordX();
                        cY = console.EnterCoordY();
                        radius = console.EnterRadius();
                        break;
                    case (int)MainMenu.Rectingle_Info: Console.Clear();
                        Rectangle rectangle = new Rectangle(rX, rY, rectName, rectHeight, rectWidth);
                            int inputRec = menu.OptionChoice(true, new RectingleMenu()); switch (inputRec)
                        { 
                            case (int)RectingleMenu.Output_Rectangle_Coords:
                                Console.Clear();
                                Console.WriteLine($"{rectangle.Name} start point are X = {rectangle.X}, Y = {rectangle.Y}");
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
                    case (int)MainMenu.Circle_Info:Console.Clear(); Circle circle = new Circle(cX, cY, circlName, radius); int inputCircle = menu.OptionChoice(true, new CircleMenu()); switch (inputCircle)
                        {
                            case (int)CircleMenu.Output_Circle_Coords:
                                Console.Clear();
                                Console.WriteLine($"{circle.Name} start point are X = {circle.X}, Y = {circle.Y}");
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