﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.WriteLine("Enter the first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine($"First number {number1} > {number2}");
}
else 
{
    Console.WriteLine($"Second number {number2} > {number1}");
}
Console.WriteLine();*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

/*Console.WriteLine("Enter three numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine($"The higher of the numbers entered is {max}");*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

/*Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"{number} -> Yes");
}
else 
{
    Console.WriteLine($"{number} -> No");
}
Console.WriteLine();*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/


int i = 1;
Console.WriteLine("Enter the number");
int number = Convert.ToInt32(Console.ReadLine());
while (i <= number)
{
    if( i % 2 == 0)
    {
        Console.Write($"{i},");
    }
    i++;
}
Console.WriteLine();




