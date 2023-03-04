// 2 числа. Если одно кратно второму то КРАТНО, если не кратно, НЕ кратно и остаток от деления пишем
Console.WriteLine("Zadacha 3");

void Div(int num1, int num2)
{
    if (num1 % num2 == 0)
         Console.WriteLine("Kratno");
    else
        Console.WriteLine("NE Kratno " + num1 % num2);
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Div(a, b);
