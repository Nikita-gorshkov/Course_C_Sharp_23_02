// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a)
{
   Console.Write($"{b} ");
   b++; 
}
