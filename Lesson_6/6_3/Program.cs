// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Fib (int n)
{
    int firstNum = 0;
    int secondNum = 1;

    for (int i = 0; i < n; i++)
    {
        Console.Write(firstNum + " ");
        (firstNum, secondNum) = (secondNum, firstNum + secondNum);

    } 
}

int N = int.Parse(Console.ReadLine()!);
Fib(N);

