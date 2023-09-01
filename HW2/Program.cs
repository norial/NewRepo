// See https://aka.ms/new-console-template for more information
//1) Вивести число пі

//1
//Console.WriteLine(Math.PI);

//2
//Console.WriteLine(Math.Acos(-1));

//2) поміняти змінні місцями 2
//byte a = 1;
//byte b = 5;


//1
//c = b;
//b = a;
//a = c;


//2

//a = (byte) (a + b);
//b = (byte) (a - b);
//a = (byte) (a - b);

//Console.WriteLine(a);
//Console.WriteLine(b);


//3) перевести см у м
//float dist;

//Console.WriteLine("Enter distance!");
//string input = Console.ReadLine();
//dist = float.Parse(input);
//dist /= 100;
//Console.WriteLine("distance: {0}", dist);

//4)


//Console.Write("Write value 10-99: ");
//int inputNum = int.Parse(Console.ReadLine());
//int firstDigit = inputNum / 10;
//int secondDigit = inputNum % 10;


//Console.WriteLine($"{firstDigit}") ;
//Console.WriteLine($"{secondDigit}") ;
//Console.WriteLine($"{firstDigit + secondDigit}") ;
//Console.WriteLine($"{firstDigit * secondDigit}") ;

//Console.ReadKey();