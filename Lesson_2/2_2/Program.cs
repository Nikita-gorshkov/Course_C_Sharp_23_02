// Вывести случ число от 10 до 99 и в нём показать большую цифру
Console.WriteLine("Zadacha 2");

int MaxNum(int num)
{
    Console.WriteLine(num);
    int num1 = num / 10; 
    int num2 = num % 10; 
    if (num1 > num2)
    return num1;
    
    return num2;
}

int rezult = MaxNum(new Random().Next(10, 100));

Console.WriteLine(rezult);