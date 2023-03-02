// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
Console.WriteLine("Vvedi 3 chisla:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int d = int.Parse(Console.ReadLine()!);

int Max = a;
if (a > Max)
{
    Max = a;
}
if (b > Max)
{
    Max = b;
}
if (d > Max)
{
    Max = d;
}
Console.Write("Max=");
    Console.WriteLine(Max);