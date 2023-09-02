// Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.

Console.Write("enter a number between 100 and 999: ");
int inputNum = int.Parse(Console.ReadLine());
int ones = inputNum % 10;
int tens = (inputNum % 100) / 10; ;
int hundreds = inputNum / 100;
int ReverseTnOInput = ones + tens * 100 + hundreds * 10;
Console.WriteLine($"Reverse number is :{ReverseTnOInput}");
Console.ReadKey();

