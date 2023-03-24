// Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[] Min(int[,] arr)
{
    int min = arr[0, 0];
    int[] ind = new int[2];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (min > arr[i, j])
            {
                min = arr[i, j];
                ind[0] = i;
                ind[1] = j;
            }
    }
    Console.WriteLine(arr[ind[0], ind[1]]);
    return ind;
}

void WithoutRC(int[,] arr, int[] minInd)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (minInd[0] == i || minInd[1] == j) 
            continue;

            else Console.Write($"{arr[i, j],3}");
        Console.WriteLine();

    }
    Console.WriteLine();
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

Console.WriteLine("Массив без строки и столба с минимальным элементом: ");

int[] rezult = Min(mass);
WithoutRC(mass, rezult);
