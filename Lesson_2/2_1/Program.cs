// Прога показывает последнюю цифру трёхзначного числа
Console.WriteLine("Zadacha 1");

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int rezult = TakeNum(new Random().Next(100, 1000));

Console.WriteLine(rezult);

