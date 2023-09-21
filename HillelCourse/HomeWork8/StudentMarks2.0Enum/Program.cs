using StudentMarks2._0Enum;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace StudentMarks2_0Enum
{
    class Program
    {

        static void Main()
        {
            Random rand = new Random();
            string[][] gradesNSubject = new string[5][];
            gradesNSubject[0] = RandomArrayFiller(gradesNSubject[0], "Math");
            gradesNSubject[1] = RandomArrayFiller(gradesNSubject[1], "P.I.");
            gradesNSubject[2] = RandomArrayFiller(gradesNSubject[2], "Physics");
            gradesNSubject[3] = RandomArrayFiller(gradesNSubject[3], "Art");
            gradesNSubject[4] = RandomArrayFiller(gradesNSubject[4], "Programming");

            while (true)
            {
                string userInput = null;
                int input = MenuChoice(true, new MainMenu());
                switch (input)
                {
                    case (int)MainMenu.AddMark:
                        Console.Clear();
                        int inputMark = ArrayChoice(true, new ArrayType());
                        switch (inputMark)
                        {
                            case (int)ArrayType.Math:
                                do
                                {
                                    ArrayUserFiller(gradesNSubject, inputMark);
                                }
                                while (false);
                                break;
                            case (int)ArrayType.PI:
                                do
                                {
                                    ArrayUserFiller(gradesNSubject, inputMark);
                                }
                                while (false);
                                break;
                            case (int)ArrayType.Physics:
                                do
                                {
                                    ArrayUserFiller(gradesNSubject, inputMark);
                                }
                                while (false);
                                break;
                            case (int)ArrayType.Art:
                                do
                                {
                                    ArrayUserFiller(gradesNSubject, inputMark);
                                }
                                while (false);
                                break;
                            case (int)ArrayType.Programming:
                                do
                                {
                                    ArrayUserFiller(gradesNSubject, inputMark);
                                }
                                while (false);
                                break;
                            case (int)ArrayType.Back:
                                break;
                        }
                        break;
                    case (int)MainMenu.About:
                        Console.Clear();
                        Console.WriteLine("Hi, Here you can add new marks, here we go!");
                        break;
                    case (int)MainMenu.PrintArray:
                        Console.Clear();
                        int inputArray = ArrayChoice(true, new ArrayType());
                        switch (inputArray)
                        {
                            case (int)ArrayType.Math:
                                Console.Clear();
                                PrintArray(gradesNSubject[(int)ArrayType.Math]);
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                            case (int)ArrayType.PI:
                                Console.Clear();
                                PrintArray(gradesNSubject[(int)ArrayType.PI]);
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                            case (int)ArrayType.Physics:
                                Console.Clear();
                                PrintArray(gradesNSubject[(int)ArrayType.Physics]);
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                            case (int)ArrayType.Art:
                                Console.Clear();
                                PrintArray(gradesNSubject[(int)ArrayType.Art]);
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                            case (int)ArrayType.Programming:
                                Console.Clear();
                                PrintArray(gradesNSubject[(int)ArrayType.Programming]);
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                            case (int)ArrayType.Back:
                                break;
                            default: Console.WriteLine("Wrong command!");
                                break;
                        }
                            
                        break;
                    case (int)MainMenu.Exit:
                            Environment.Exit(0);
                            break;
                    case (int)MainMenu.AvarageGrade:
                        Console.Clear();
                        int inputAvarageGrade = ArrayChoice(true, new ArrayType());
                        switch (inputAvarageGrade)
                        {
                            case (int)ArrayType.Math:
                                Console.Clear();
                                int result = CalculateTheAvarage(gradesNSubject[(int)ArrayType.Math]);
                                Console.WriteLine("{0} avarage mark is {1}", ArrayType.Math, result);
                                    break;
                            case (int)ArrayType.PI:
                                Console.Clear();
                                result = CalculateTheAvarage(gradesNSubject[(int)ArrayType.PI]);
                                Console.WriteLine("{0} avarage mark is {1}", ArrayType.PI, result);
                                break;
                            case (int)ArrayType.Physics:
                                Console.Clear();
                                result = CalculateTheAvarage(gradesNSubject[(int)ArrayType.Physics]);
                                Console.WriteLine("{0} avarage mark is {1}", ArrayType.Physics, result);
                                break;
                            case (int)ArrayType.Art:
                                Console.Clear();
                                result = CalculateTheAvarage(gradesNSubject[(int)ArrayType.Art]);
                                Console.WriteLine("{0} avarage mark is {1}", ArrayType.Art, result);
                                break;
                            case (int)ArrayType.Programming:
                                Console.Clear();
                                result = CalculateTheAvarage(gradesNSubject[(int)ArrayType.Programming]);
                                Console.WriteLine("{0} avarage mark is {1}", ArrayType.Programming, result);
                                break;
                            case (int)ArrayType.Back:
                                Console.WriteLine("\nPress ENTER to go back");
                                break;
                        }

                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static string[] RandomArrayFiller(string[] gradesNSubject, string objName)
                                            {
            Random random = new Random();
            gradesNSubject = new string[random.Next(9, 20)];
            gradesNSubject[0] = objName;
            for (int i = 1; i < gradesNSubject.Length - random.Next(1, 7); i++)
            {
                int randomElem = random.Next(1, 13);
                gradesNSubject[i] = randomElem.ToString();
            }
            return gradesNSubject;
        }

        private static void ArrayUserFiller(string[][] gradesNSubject, int inputMark)
        {
            for (int i = 1; i < gradesNSubject[inputMark].Length; i++)
            {
                Console.Clear();
                PrintArray(gradesNSubject[inputMark]);
                Console.WriteLine("\nEnter Continue enter the marks \n\n");
                var mark = int.TryParse(gradesNSubject[inputMark][i], out int markRes);
                if (markRes == 0)
                {
                    gradesNSubject[inputMark][i] = Console.ReadLine();
                }
            }
            
        }

        private static int CalculateTheAvarage(string[] gradesNSubject)
        {
            int avarage = 0;
            int amountOfMarks = 0;
            for(int i = 0;i < gradesNSubject.Length; i++)
            {
                int.TryParse(gradesNSubject[i], out int result);
                if (result > 0)
                {
                    amountOfMarks++;
                }
                avarage += result;
            }
            avarage /= amountOfMarks;
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
                        Console.ForegroundColor = ConsoleColor.Green;

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
        private static int ArrayChoice(bool canCancel, Enum ArrayEnum, int spacingPerLine = 18, int optionsPerLine = 1, int startX = 1, int startY = 1)
        {
            int selectedNow = 0;
            ConsoleKey key;
            Console.CursorVisible = false;
            int length = Enum.GetValues(ArrayEnum.GetType()).Length;
            do
            {
                Console.Clear();
                Console.WriteLine(" Which subject you want to see? \n");
                for (int i = 0; i < length; i++)
                {
                    
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);

                    if (i == selectedNow)
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(Enum.Parse(ArrayEnum.GetType(), i.ToString()));

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
        private static void PrintArray(string[] nums)
        {
            for (int i = 0;i < nums.Length;i++)
            {
                Console.Write(nums[i] + "\t");
            }
        }
    }
}