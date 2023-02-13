// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 12321
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 10000 || num > 99999)
{
    Console.WriteLine("Число не пятизначное.");
    return;
}
int f1 = num / 10000;
int f5 = num % 10;
int f2 = (num % 10000) / 1000;
int f4 = (num % 100) / 10;
if (f1 == f5 && f2 == f4)
{
    Console.Write($"Число {num} палиндром.");
}
else
{
    Console.Write($"Число {num} не палиндром.");
}
