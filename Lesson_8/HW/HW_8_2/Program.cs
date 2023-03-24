// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] SumNum(int[,] arr)
{
    int[]summ = new int[arr.GetLength(0)];
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {summ[i] += arr[i, j];}
        
    }
    return summ;
}

int MinSumStr (int[] arr)
{
    int minsumm = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < arr[minsumm]) 
        minsumm = i;
    }
    return minsumm;
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

int[] rezult = SumNum(mass);
Console.Write("ИНДЕКС строки с минимальной суммой: ");
Console.WriteLine(MinSumStr(rezult));