// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void tochka(double k1, double b1, double k2, double b2)
{
double k_sub = k1 - k2;
if (k_sub != 0)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;
    Console.WriteLine($"Точки пересечения: ({x}); {y}");
}
else if (k1 == k2 && b1 == b2)
    Console.WriteLine("Наложенные прямые");

else
    Console.WriteLine("Не пересекаются, увы и ах");
}

Console.Write("Введи К1:");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введи B1:");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введи К2:");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введи B2:");
double b2 = double.Parse(Console.ReadLine()!);

tochka(k1, b1, k2, b2 );