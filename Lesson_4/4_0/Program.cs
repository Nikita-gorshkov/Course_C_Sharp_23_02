﻿// See https:// Принимает А, а выдаёт сумму чисел от 1 до А
Console.WriteLine("Vvedi chislo A:");
int SumNum (int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    all_sum = all_sum + i;

    return all_sum;
}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);