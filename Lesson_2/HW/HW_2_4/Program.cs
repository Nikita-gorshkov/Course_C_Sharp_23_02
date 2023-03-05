//   Напишите программу, которая принимает на
//   вход цифру, обозначающую день недели, и проверяет,
//   является ли этот день выходным.

Console.WriteLine("Zadacha_4");

void Week (int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("DA - Ondihay moy drug");
    }
    else
    {
        Console.WriteLine("NO - idi rabotay");
    }
}
Week(int.Parse(Console.ReadLine()!));
