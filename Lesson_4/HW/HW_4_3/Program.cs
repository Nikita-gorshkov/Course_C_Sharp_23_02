// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



void Massif(int[] mas)
   {
    for (int i = 0; i < mas.Length; i++ )
        Console.Write($"{mas[i]} ");
   }

int[] MasVvod(int start, int finish, int size)
   {
    int[]mas = new int[size];
    for (int i = 0; i < size; i++)
        mas[i] = new Random().Next(start, finish);
    return mas;
   }

Console.Write("Vvedi OT: ");
   int ot = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi TO: ");
   int to = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi DLINA: ");   
   int dlina = int.Parse(Console.ReadLine()!);

   int[] massss = MasVvod(ot, to, dlina);
   Massif(massss);