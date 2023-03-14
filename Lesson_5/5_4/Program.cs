﻿// Массив. Найти произведения пар чисел (пара: первый и последний, второй и предпоследний, результат вывести в новый массив)
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

int[] MultiMass(int[] arr)
{
   int size = arr.Length;
   int[] newMass = new int[size/2 + size%2];
   for (int i = 0; i < size/2; i++)
   {
    newMass[i] = arr[i]*arr[size - 1 - i];
   }
   if (size%2 == 1)
   {
    newMass[newMass.Length - 1] = arr[arr.Length/2];
   }
    return newMass; 
} 


Console.Write("Vvedi dlinu: ");
   int dlina = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[] mass = MasNums(dlina, start, stop);
   Print(mass); 

int[] newNewMass = MultiMass(mass);
Print(newNewMass);
