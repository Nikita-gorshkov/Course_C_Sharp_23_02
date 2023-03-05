// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Zadacha 2_1   VVEDI 3-h znachnoe chislo:");

int TakeNum(int num)
{
   
    return num /10 % 10;
}

int rezult = TakeNum(int.Parse(Console.ReadLine()!));

Console.WriteLine(rezult);