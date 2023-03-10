// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Vvedite A, stepen B: ");

double NatStep(int a, int b);

double pr = 1;
int b_abs = Math.Abs(b);

for (int i = 1; i <= b; i++)
{
    pr = a * i; 
}
return pr;


int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

Console.WtiteLine(NatStep(A,B));