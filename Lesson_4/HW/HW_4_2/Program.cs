// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int a)
{
    int S = 0;

    while (a > 0)
    {
        S = S + a % 10;
        a = a / 10;
    }
        return S; 
    

} 
Console.Write("Vvedi chislo: ");
int A = int.Parse(Console.ReadLine()!);
int result = Sum(A);
Console.WriteLine(result);









