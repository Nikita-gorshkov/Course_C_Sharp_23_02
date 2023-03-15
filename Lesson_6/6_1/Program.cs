// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины. ПОДСКАЗКА: Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


void Triangle (int A, int B, int C)
   {
      if (A < B + C & B < A + C & C < A + B)
        Console.WriteLine("ДА");

        else 
        Console.WriteLine("НЕТ");
        
   }
 
Console.Write("Vvedi 1: ");
   int dlina = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi 2: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi 3: ");   
   int stop = int.Parse(Console.ReadLine()!);

   Triangle(dlina, start, stop); 
   
