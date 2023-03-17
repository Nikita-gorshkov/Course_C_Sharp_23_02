// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Приветик! Сколько хочешь вввести:");

int Nombers(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write("Ну вводи свои числа:");
        int a = int.Parse(Console.ReadLine()!);
        if (a > 0)
        count = count + 1;
    }
      return count;
}

int chislo = int.Parse(Console.ReadLine()!);
int result = Nombers(chislo);
Console.Write($"А я знаю, что, больше нудя чисел аж ");
Console.WriteLine(result);