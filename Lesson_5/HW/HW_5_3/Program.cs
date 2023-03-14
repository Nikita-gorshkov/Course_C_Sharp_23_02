// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void Print(double[] arr)
   {
    int size = arr.Length;
    for (int i = 0; i < size; i++ )
        Console.Write($"{arr[i]} ");
        Console.WriteLine();
        
   }

double[] MasNums(int size, int from, int to)
   {
    double[]arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
   }

void MaxMin(double[] arr)
{
   double max = arr[0];
   double min = arr[0];


   for (int i = 1; i < arr.Length; i++)
   { if (max < arr[i])
         max = arr[i];
     
     else if (min > arr[i])
     min = arr[i];
   } 
Console.WriteLine($"Minimum: {min}, Maximum:  {max}.  ");

Console.WriteLine($"Raznost: ");
Console.Write(Math.Round(max - min, 2));
} 


Console.Write("Vvedi dlinu: ");
   int dlina = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int  start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int  stop = int.Parse(Console.ReadLine()!);

   double[] mass = MasNums(dlina, start, stop);
   Print(mass);
   MaxMin(mass); 

