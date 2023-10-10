using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleHierarchy
{
    enum MainMenu
    {
        Create_Car,
        Create_Bicycle,
        Print_Car_info,
        Print_Bicycle_Info,
        Exit
    }
    public class MenuCreator
    {
        //Menu creator method
        public int OptionChoice(bool canCancel, Enum OptionEnum, int spacingPerLine = 18, int optionsPerLine = 1, int startX = 1, int startY = 1)
        {
            int selectedNow = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(OptionEnum.GetType()).Length;
            do
            {
                Console.Clear();
                for (int i = 0; i < length; i++)
                {

                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == selectedNow)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(Enum.Parse(OptionEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        {
                            if (selectedNow >= optionsPerLine)
                                selectedNow -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (selectedNow + optionsPerLine < length)
                                selectedNow += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = true;

            return selectedNow;
        }
    }
}
