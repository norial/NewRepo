//Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.

Console.Write("enter a number between 100 and 999: ");
int inputNum = int.Parse(Console.ReadLine());
int ones = inputNum % 10;
int tens = (inputNum % 100) / 10; ;
int hundreds = inputNum / 100;
int ReverseInput = ones * 100 + tens * 10 + hundreds;
Console.WriteLine("{0}{1}{2}", ones, tens, hundreds);
Console.WriteLine($"Reverse number is :{ReverseInput}");
Console.ReadKey();