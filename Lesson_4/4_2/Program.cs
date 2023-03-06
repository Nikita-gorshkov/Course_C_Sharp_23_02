// See https://aka.ms/new-console-template for more information

int LengthNum(int num)
{
    int a=0;
    for(int i=1; num>0; i++)
       { num=num/10;
        a++;
       }
    return a;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = LengthNum(num);
Console.WriteLine(result);