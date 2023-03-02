// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Vvedite 2 chisla:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.Write("Max=");
    Console.WriteLine(a);
}
else
{
    Console.Write("Max=");
    Console.WriteLine(b);
}