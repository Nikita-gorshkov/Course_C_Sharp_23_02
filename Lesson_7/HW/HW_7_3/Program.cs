// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


void Print(int[,] arr)
   {
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++ )
    {
        for (int j = 0; j < column; j++ )
             Console.Write($"{arr[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
   }


int[,] MasNums(int row, int column, int from, int to)
   {
    int[,]arr = new int[row, column];

    for (int i = 0; i < row; i++ )
    {
        for (int j = 0; j < column; j++ ) 
    
        arr[i,j] = new Random().Next(from, to);
   }
   return arr;
   }



 double[] ColumAverage(int[,] array)
   {
    double[] average = new double[array.GetLength(1)];
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        average[i] += array[j,i];
        average[i] /= array.GetLength(0);
    }
   return average;               
  }

string PrintDoubleArray(double[] array)
{
string res = string.Empty;
for (int i = 0; i < array.Length; i++)
{
res += Math.Round(array[i], 2);
}
return res;
}

Console.Write("Введи количество строк: ");
   int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введи количество столбцов: ");
   int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введи start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Введи stop: ");   
   int stop = int.Parse(Console.ReadLine()!);
   
   int[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 

   Console.WriteLine("Среднее арифметическое:");
   double[] result = ColumAverage(mass);
   string rezultat = PrintDoubleArray(result);
   Console.WriteLine(rezultat);
   