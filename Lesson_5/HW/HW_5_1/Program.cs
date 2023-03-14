// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

   void Print(int[] arr)
   {
    int size = arr.Length;
    for (int i = 0; i < size; i++ )
        Console.Write($"{arr[i]} ");
        Console.WriteLine();
        
   }

int[] MasNums(int size, int from, int to)
   {
    int[]arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
   }

int Chet(int[] arr)
{
   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
       if (arr[i] % 2 == 0)
       count += 1;
   }
    return count; 
} 


Console.Write("Vvedi dlinu: ");
   int dlina = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[] mass = MasNums(dlina, start, stop);
   Print(mass);
  Console.WriteLine(Chet(mass)); 
 
