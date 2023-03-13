// Создать массив. Вывести его ещё раз, но уже чтоб элементы его поменяли знаки (1,-2) --> (-1,2)
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

void MasConverter(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    
           arr[i] = -arr[i];
   
}
    


Console.Write("Vvedi num: ");
   int num = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi start: ");
   int start = int.Parse(Console.ReadLine()!);
Console.Write("Vvedi stop: ");   
   int stop = int.Parse(Console.ReadLine()!);

   int[] mass = MasNums(num, start, stop);
   Print(mass); 
   MasConverter(mass);
   Print(mass); 