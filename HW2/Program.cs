//Домашнє завдання #2

//1) Дано тризначне число. Знайти число, отримане під час прочитання його цифр справа наліво.

//Console.Write("enter a number between 100 and 999: ");
//int inputNum = int.Parse(Console.ReadLine());
//int ones = inputNum % 10;
//int tens = (inputNum % 100) / 10; ;
//int hundreds = inputNum / 100;
//int ReverseInput = ones*100 + tens*10 + hundreds;
//Console.WriteLine("{0}{1}{2}", ones, tens, hundreds);
//Console.WriteLine($"Reverse number is :{ReverseInput}");



//2) Написати програму, яка обчислює квадрат будь-якого введеного числа.

//Console.Write("Enter the number whose square root you want to find: ");
//int inputNum = int.Parse(Console.ReadLine());
//Console.WriteLine($"Your square root is: {inputNum *= inputNum}");



//3) Дано тризначне число. Знайти число, отримане під час перестановки першої та другої цифр заданого числа.

//Console.Write("enter a number between 100 and 999: ");
//int inputNum = int.Parse(Console.ReadLine());
//int ones = inputNum % 10;
//int tens = (inputNum % 100) / 10; ;
//int hundreds = inputNum / 100;
//int ReverseTnOInput = ones + tens * 100 + hundreds*10;
//Console.WriteLine($"Reverse number is :{ReverseTnOInput}");



//4) Написати програму, яка обчислює середнє арифметичне двох чисел.

//Console.Write("enter first number: ");
//float inputNum1 = float.Parse(Console.ReadLine());
//Console.Write("enter second number: ");
//float inputNum2 = float.Parse(Console.ReadLine());
//float ArithmMean = (inputNum1 + inputNum2) / 2;
//Console.Write($"arithmetic mean of two numbers is equal to: {ArithmMean}");



//5*) Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної. 

////1
//int a = 3;
//int b = 5;

//a = a ^ b;
//b = a ^ b;
//a = a ^ b;

//Console.WriteLine($"{a}, {b}");

//2

//a = a * b;
//b = a / b;
//a = a / b;

//Console.WriteLine($"{a}, {b}");


//Console.ReadKey();