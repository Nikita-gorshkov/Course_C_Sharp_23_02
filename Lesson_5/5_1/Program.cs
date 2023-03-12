// 
void Print(int[] arr)
   {
    int size = arr.Length;
    for (int i = 0; i < size; i++ )
        Console.Write($"{arr[i]} ");
        Console.WriteLine();
   }

int[] MasNums(int size, int from, int to)
   {
    int[]arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
   }

void SumPosNeg(int[] arr)
{
    int pos, neg;
    pos = neg = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            pos += arr[i];
        else
            neg += arr[i]; 
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg} ");
}

Console.Write("Vvedi num: ");
   int num = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[] mass = MasNums(num, start, stop);
   Print(mass); 
   SumPosNeg(mass);
