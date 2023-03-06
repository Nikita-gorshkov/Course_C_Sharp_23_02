// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Zadacha_1_VVEDI 5-ти значное число:");

void Polindrom(int num)
 {    
    int a1 = num / 10000;
    int b1 = num % 10;
    int a2 = num / 1000 % 10;
    int b2 = num % 100 /10;

    if (a1 == b1 && a2 == b2)
           Console.WriteLine("Polindrom");
     
    else 
           Console.WriteLine("NE Polindrom");
    }   

 Polindrom(int.Parse(Console.ReadLine()!));