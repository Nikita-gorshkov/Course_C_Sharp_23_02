// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.(45 -> 101101, 3 -> 11, 2 -> 
string ConvertBin(int num)
{
     string result = "";
     while (num > 0)
     {result = num % 2 + result;
     num = num / 2; 
     
     } 


    return result;
}
int n = int.Parse(Console.ReadLine()!);
string ResultEnd = ConvertBin(n);
Console.WriteLine(ResultEnd);

