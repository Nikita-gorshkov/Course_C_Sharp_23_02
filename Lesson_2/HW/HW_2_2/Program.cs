//   Напишите программу, которая выводит
//   случайное трёхзначное число и удаляет вторую цифру
//   этого числа.

Console.WriteLine("Zadacha_2");

void GivNum (int num)
{
    Console.WriteLine(num);
    Console.Write($"{num / 100}");
    Console.Write($"{num % 10}");
}
  int num = new Random().Next(100, 1000);

GivNum(num);
