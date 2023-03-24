//Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

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

bool Check(int row, int column)
{
    bool rezult = row != column;
    return rezult;
}

string RowToColumn(int[,] arr)
   {
    if (Check(arr.GetLength(0), arr.GetLength(1)))
        return "Не транспонентен"; 

    for(int i = 1; i  < arr.GetLength(0); i++)     
            {
                for(int j = 0; j  < i; j++ ) 
              {
                (arr[i,j], arr[j,i]) = (arr[j,i], arr[i,j]);
              }
            }  
            Print(arr);
            return "Да, транспонентен";
   }

Console.Write("Введи строки: ");
   int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введи столбцы: ");
   int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Введи start диапазона: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Введи stop диапазона: ");   
   int stop = int.Parse(Console.ReadLine()!);

   // Console.Write("Vvedi Chislo: ");
  //  int chislo = int.Parse(Console.ReadLine()!);

   int[,] mass = MasNums(row_num, column_num, start, stop);
   Print(mass); 
   
  // Console.WriteLine("Массив траспонированный: ");
   Check(row_num, column_num);
   string rezult = RowToColumn(mass);
   Console.WriteLine(rezult);

