// Число. Кратно 7 и 23 ?
Console.WriteLine("Zadacha 4");

void Div(int N)
{
    if (N % 7 == 0 && N % 23 == 0)
         Console.WriteLine("Kratno 7 и 23 odnovremenno");
    else
        Console.WriteLine("NE Kratno");
}
int N = int.Parse(Console.ReadLine()!);

Div(N);