using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShaping
{
   enum MainMenu : byte
    {
        Enter_Rectingle_Sides_And_Coords, 
        Enter_Cirlce_Radius_And_Coords,
        Rectingle_Info,
        Circle_Info,
        Exit,
    }
    enum RectingleMenu : byte
    {
        Output_Rectangle_Coords,
        Output_Rectingle_Perimeter,
        Output_Rectingle_Area,
        Ourput_Rectingle_Sides,
    }
    enum CircleMenu : byte
    {
        Output_Circle_Coords,
        Output_Circle_Perimeter,
        Output_Circle_Area,
        Output_Circle_Length,
        Output_Circle_Radius_And_Diameter,
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
