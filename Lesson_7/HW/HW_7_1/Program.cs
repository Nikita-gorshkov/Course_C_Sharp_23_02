// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Print(double[,] arr)
   {
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++ )
    {
        for (int j = 0; j < column; j++ )
             Console.Write($"{arr[i,j]} ");
        Console.WriteLine();
    }
   }

double[,] MasNums(int row, int column, int from, int to)
   {
    double[,] arr = new double[row, column];

    Random сhisla = new Random();

    for (int i = 0; i < row; i++ )
    {
        for (int j = 0; j < column; j++ ) 
        arr[i,j] = сhisla.NextDouble() + сhisla.Next(from, to);
    }
    return arr;
   }

Console.Write("Vvedi row_num: ");
   int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi column_num: ");
   int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   double[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 