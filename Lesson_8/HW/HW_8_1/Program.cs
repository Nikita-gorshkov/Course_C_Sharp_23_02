// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        
        Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

void Sorter(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
          for (int n = 0; n < column_size - j - 1; n++)
            if (arr[i, n] < arr[i, n + 1])
            
        (arr[i, n], arr[i, n + 1]) = (arr[i, n + 1], arr[i, n]);
        }
    }
}


Console.Write("Количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Заполнение массива от: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Заполнение массива до: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);

Sorter(mass);
Print(mass);