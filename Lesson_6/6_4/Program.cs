// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[,] FillMass(int rows, int colums, int start, int end)
{
    int[,] array = new int[rows, colums];

    for(int i = 0; i < rows; i++)
    {
      for(int j = 0; j < colums; j++)
        {
           array[i, j] = new Random().Next(start, end); 
        }
    }
    return array;
}

void Print(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
     {
        for (int j = 0; j < arr.GetLength(1); j++)
     {
     Console.Write($" {arr[i,j]} ");
     }
     Console.WriteLine();
     }
}

int[,]CopyMass(int[,] arr)
{
    int row = arr.GetLength(0);
    int colums = arr.GetLength(1);

    int[,] newArr = new int[row,colums];

     for (int i = 0; i < row; i++)
     {
        for (int j = 0; j < colums; j++)
     {
        newArr[i,j] = arr[i,j];
     }
     Console.WriteLine();
     }
     return newArr;
}

int[,]mass = FillMass(3, 4, 1, 11);
Print(mass);
Console.WriteLine();
int[,]mass2 = CopyMass(mass);
Print(mass2);