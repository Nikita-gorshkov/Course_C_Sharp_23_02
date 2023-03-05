// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Zadacha_3");

void TakeNum (int num)
{
    if (num <= 99)
    {
        Console.WriteLine("NET 3 cifri");
    }
    else
    {
        while (num > 999)
        num /= 10;
        Console.WriteLine(num % 10);
    }
}
TakeNum(int.Parse(Console.ReadLine()!));



