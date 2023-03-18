// Задайте двумерный массив. Найдите элементы, у которых
// обе позиции чётные, и замените эти элементы на их квадраты.
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

   void EvenPos(int[,] arr)
   {
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
        
        for (int i = 1; i < row; i+=2 )
        {
            for (int j = 1; j < column; j+=2 ) 
                 arr[i,j] =   arr[i,j] *   arr[i,j];
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

   int[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 
   
   EvenPos(mass);
   Print(mass); 