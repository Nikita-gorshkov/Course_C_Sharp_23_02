// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void NumsFromTo(int M, int N)
{
    if (M > N) return;

        if(N%2 == 0) 
            {
               NumsFromTo(M, N - 2);
               Console.Write($"{N} "); 
            } 
            
           else if (N%2 != 0)
            {
             N = N - 1;
             NumsFromTo(M, N - 2);

             Console.Write($"{N} "); 
            }
                                  
}


Console.Write("Введите первое число: ");
int Num = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int Num2 = int.Parse(Console.ReadLine()!);


NumsFromTo(Num, Num2);