﻿// Дослідити інші способи поміняти місцями значення двох змінних без використання тимчасової змінної. 

////1
//int a = 3;
//int b = 5;

//a = a ^ b;
//b = a ^ b;
//a = a ^ b;

// Опис, розглянемо числа 3 та 5 у двоїчній системі, 3 - 0011, 5 - 0101. застосовуючи побітове виключення OR 
//    X         Y       X^Y
//    1         1        0
//    1         0        1
//    0         1        1
//    0         0        0
//
//На 53 строке: a = a ^ b => 0011 ^ 0101 => 0110 => 6
//На 54 строке: b = a ^ b => 0110 ^ 0101 => 0011 => 3
//На 55 строке: a = a ^ b => 0110 ^ 0011 => 0101 => 5

//Console.WriteLine($"{a}, {b}");

//2

//a = a * b;
//b = a / b;
//a = a / b;

//Console.WriteLine($"{a}, {b}");


//Console.ReadKey();