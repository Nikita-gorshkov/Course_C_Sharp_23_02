﻿// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Vvedi luboe chislo:");
int a = int.Parse(Console.ReadLine()!);
int i = 2;
while (i <= a)
{
    Console.Write($"{i} ");
    i += 2;
}