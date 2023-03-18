// Задайте двумерный массив. Найдите сумму элементов
// главной диагонали.
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

   int EvenPos(int[,] arr)
   {
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int sum = 0;
        
        for (int i = 0; i < row; i++ )
        {
            for (int j = 0; j < column; j++ ) 
              {
                if (i == j)
                   sum = sum + arr[i,j];
              }
        }
        return sum;
   }

Console.Write("Vvedi row_num: ");
   int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi column_num: ");
   int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 

   Console.Write("Сумма по диагонали равна: ");
   Console.WriteLine(EvenPos(mass));
   
   
