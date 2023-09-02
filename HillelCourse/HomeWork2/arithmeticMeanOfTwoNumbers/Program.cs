// Написати програму, яка обчислює середнє арифметичне двох чисел.

Console.Write("enter first number: ");
float inputNum1 = float.Parse(Console.ReadLine());
Console.Write("enter second number: ");
float inputNum2 = float.Parse(Console.ReadLine());
float ArithmMean = (inputNum1 + inputNum2) / 2;
Console.Write($"arithmetic mean of two numbers is equal to: {ArithmMean}");
Console.ReadKey();

