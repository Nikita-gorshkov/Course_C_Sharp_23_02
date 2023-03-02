// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Vvedi luboe chislo:");
int a = int.Parse(Console.ReadLine()!);
if (a%2 == 0)
{
   Console.WriteLine("CHETNOE"); 
}
else
{
   Console.WriteLine("NE chetnoe"); 
}