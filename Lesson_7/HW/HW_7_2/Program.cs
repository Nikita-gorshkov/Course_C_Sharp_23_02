// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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



 string SearchNum(int[,] arr, int gor, int vert)
   {
   int row = arr.GetLength(0);
   int column = arr.GetLength(1);
   
   int chislo = 0;
   
        
       for (int i = 0; i < row; i++ )
        
          for (int j = 0; j < column; j++ ) 
              
                if (gor >= row || vert >= column)
                    return $"А вот нет такого элемента...";
                  else
                   chislo = arr[gor - 1,vert - 1];           
            
                   return $"{chislo}";
                   
                    
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

   Console.Write("Введи позицию в массиве по горизонтали: ");
   int gorizont = int.Parse(Console.ReadLine()!);
   Console.Write("Введи позицию в массиве по вертикали: ");
   int vertikal = int.Parse(Console.ReadLine()!);
   
   Console.Write("Число: ");
   string result = SearchNum(mass, gorizont, vertikal);
   Console.WriteLine(result);
   