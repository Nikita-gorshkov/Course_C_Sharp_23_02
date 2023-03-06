// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Vvedite chislo: ");

void TakeNum(int num)
{
    double[] number = new double[num];
    int i = 0;

    while (i < num)
    {
        number[i] = Math.Pow((i + 1), 3);
        Console.Write($"{number[i]}, ");
        i=i+1;
    }
} 
Console.WriteLine();

TakeNum(int.Parse(Console.ReadLine()!));