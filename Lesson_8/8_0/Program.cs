// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
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

  void ReplaceIndex(int[,] arr)
   {
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
        
            for (int j = 0; j  < column; j++ ) 
              {
                (arr[0,j], arr[row - 1, j]) = (arr[row - 1, j], arr[0,j]);
              }
   }

Console.Write("Vvedi row_num: ");
   int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi column_num: ");
   int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   // Console.Write("Vvedi Chislo: ");
  //  int chislo = int.Parse(Console.ReadLine()!);

   int[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 
   
   Console.WriteLine("Массив с поменятыми первыми и последними строками: ");
   ReplaceIndex(mass);
   Print(mass); 

