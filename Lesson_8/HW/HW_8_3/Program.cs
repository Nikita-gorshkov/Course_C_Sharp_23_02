// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Matrix(int[,] arr1, int[,] arr2)
{
    int row1 = arr1.GetLength(0);
    int column1 = arr1.GetLength(1);
    
    int row2 = arr2.GetLength(0);
    int column2 = arr2.GetLength(1);


    int[,] matrix = new int[row1, column1];

    if (column1 != row2) 
    return matrix;

    else if (column1 == row2)
        matrix = new int[row1, column2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int n = 0; n < column1; n++)

 matrix[i, j] += arr1[i, n] * arr2[n, j];
        }
    }
    return matrix;
}

Console.Write("Количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Количество строк второго массива: ");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов второго массива: ");
int column_num2 = int.Parse(Console.ReadLine()!);

Console.Write("Заполнение массива от: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Заполнение массива до: ");
int stop = int.Parse(Console.ReadLine()!);

Console.Write("Заполнение второго массива от: ");
int start2 = int.Parse(Console.ReadLine()!);
Console.Write("Заполнение второго массива до: ");
int stop2 = int.Parse(Console.ReadLine()!);


int[,] mass1 = MassNums(row_num, column_num, start, stop);
Print(mass1);
int[,] mass2 = MassNums(row_num2, column_num2, start2, stop2);
Print(mass2);


Console.WriteLine("Произведение массивов: ");
int[,] result = Matrix(mass1, mass2);
Print(result);