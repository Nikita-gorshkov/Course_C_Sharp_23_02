// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
int Sum(int M, int N)
{
    if (M > N) return 0;
    return Sum(M, N - 1) + N;
      
}
Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);

Console.Write("Сумма натуральных элементов: ");
Console.WriteLine(Sum(Num, Num2));