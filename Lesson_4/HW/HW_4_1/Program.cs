// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Stepen(int a, int b)
{
    double st = 1;

    for (int i = 1; i <= b; i++)
    {
        st = st * a;
    }    
    return st; 
}
 
 Console.Write("Vvedi 2 chislo A: ");
 int A = int.Parse(Console.ReadLine()!);
 Console.Write("Vvedi 2 chislo B: ");
 int B = int.Parse(Console.ReadLine()!);
 double result = Stepen(A, B);
 Console.WriteLine(result);