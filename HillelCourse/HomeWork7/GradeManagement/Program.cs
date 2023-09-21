//Створіть програму, яка дозволяє вводити оцінки студента з різних предметів та обчислювати середню оцінку.
//Використовуйте масиви для зберігання оцінок.
//Завдання повинно включати такі етапи:
//+Введення оцінок студента з різних предметів (наприклад, математика, історія, фізика).
//+Збереження цих оцінок у масивах.
//+Обчислення середньої оцінки студента на основі введених даних.
//+Виведення середньої оцінки на екран. 

using System.ComponentModel;

namespace GradeManagement
{
    class Program
    {
        enum Menu
        {
            AddMark, About, PrintArray, AvarageGrade, Exit, 
        }
        static void Main()
        {
            string[][] gradesNSubject = new string[5][];
            gradesNSubject[0] = new string[12] { "Math", "9", "8", "7", "9", "6", "3", "", "", "", "", "", };
            gradesNSubject[1] = new string[12] { "P.I.", "10", "10", "9", "6", "5", "1", "", "", "", "", "", };
            gradesNSubject[2] = new string[12] { "Physics", "4", "8", "7", "8", "8", "3", "", "", "", "", "", };
            gradesNSubject[3] = new string[12] { "Art", "5", "6", "5", "7", "7", "12", "", "", "", "", "", };
            gradesNSubject[4] = new string[12] { "Programming", "10", "11", "10", "9", "9", "12", "", "", "", "", "", };

            while (true)
            {
                string userInput = null;
                int input = MenuChoice(true, new Menu());
                if ((Menu)input == Menu.AddMark)
                {
                    Console.Clear();
                    PrintArray(gradesNSubject);
                    Console.WriteLine("Which Subject marks you want to augment?");
                    userInput = Console.ReadLine();
                    if (userInput == "Math")
                    {
                        Console.Clear();
                        for (int i = 7; i < gradesNSubject[0].Length; i++)
                        {
                            Console.Clear();
                            Console.Write($"Input new mark here {i}/{gradesNSubject[0].Length - 1}:");
                            gradesNSubject[0][i] = Console.ReadLine();
                        }
                    }
                    if (userInput == "PI")
                    {
                        Console.Clear();
                        for (int i = 7; i < gradesNSubject[1].Length; i++)
                        {
                            Console.Write($"Input new mark here {i}/{gradesNSubject[1].Length - 1}:");
                            gradesNSubject[1][i] = Console.ReadLine();
                        }
                    }
                    if (userInput == "Physics")
                    {
                        Console.Clear();
                        for (int i = 7; i < gradesNSubject[2].Length; i++)
                        {
                            Console.Write($"Input new mark here {i}/{gradesNSubject[2].Length - 1}:");
                            gradesNSubject[2][i] = Console.ReadLine();
                        }
                    }
                    if (userInput == "Art")
                    {
                        Console.Clear();
                        for (int i = 7; i < gradesNSubject[3].Length; i++)
                        {
                            Console.Write($"Input new mark here {i}/{gradesNSubject[3].Length - 1}:");
                            gradesNSubject[3][i] = Console.ReadLine();
                        }
                    }
                    if (userInput == "Programming")
                    {
                        Console.Clear();
                        for (int i = 7; i < gradesNSubject[4].Length; i++)
                        {
                            Console.Write($"Input new mark here {i}/{gradesNSubject[4].Length - 1}:");
                            gradesNSubject[4][i] = Console.ReadLine();
                        }
                    }
                }
                if ((Menu)input == Menu.About)
                {
                    Console.Clear();
                    Console.WriteLine("Hi, Here you can add new marks, here we go!");
                }
                if ((Menu)input == Menu.PrintArray)
                {
                    Console.Clear();
                    PrintArray(gradesNSubject);
                }
                if ((Menu)input == Menu.Exit)
                {
                    break;
                }
                if ((Menu)input == Menu.AvarageGrade)
                {
                    int[] avarageNum = CalculateTheAvarage(gradesNSubject);
                    Console.Clear();
                    for (int i = 0; i < avarageNum.Length; i++)
                    {
                        Console.WriteLine($"{gradesNSubject[i][0]} avarage mark is {avarageNum[i]} ");
                    }
                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        private static int[] CalculateTheAvarage(string[][] gradesNSubject)
        {

            int[] avarage = new int[5];
            for (int i = 0; i < gradesNSubject.Length; i++)
            {
                int amountOfMarks = 0;
                for (int j = 1; j < gradesNSubject[i].Length; j++)
                {
                    int.TryParse(gradesNSubject[i][j], out int result);
                    if (result > 0)
                    {
                        amountOfMarks++;
                    }
                    avarage[i] += result;
                }
                avarage[i] /= amountOfMarks;
            }
            return avarage;
        }

        private static int MenuChoice(bool canCancel, Enum UserEnum, int spacingPerLine = 18, int optionsPerLine = 2, int startX = 1, int startY = 1)
        {
            int selectedNow = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(UserEnum.GetType()).Length;
            do
            {
                Console.Clear();

                for (int i = 0; i < length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == selectedNow)
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.Write(Enum.Parse(UserEnum.GetType(), i.ToString()));

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (selectedNow % optionsPerLine > 0)
                                selectedNow--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (selectedNow % optionsPerLine < optionsPerLine - 1)
                                selectedNow++;
                            break;
                        }
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


        private static void PrintArray(string[][] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i][0]);

                for (int j = 1; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

