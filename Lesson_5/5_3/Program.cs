// Задать мас из 123 эл-ов, Посчитать колличество элементов, лежащих в диапазоне от 10 до 99
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

int RetNum(int[] arr, int from, int to)
{
   int count = 0;
   for (int i = 0; i < arr.Length; i++)
   {
    if (arr[i] >= from & arr[i] <= to)
    count = count + 1;
   }
    return count; 
} 


Console.Write("Vvedi dlinu: ");
   int dlina = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[] mass = MasNums(dlina, start, stop);
   Print(mass); 

Console.Write("Vvedi nachalo intervala: ");   
   int nachalo = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi finish intervala: ");   
   int finish = int.Parse(Console.ReadLine()!);

   int rezult = RetNum(mass, nachalo, finish);
Console.WriteLine(rezult);