// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите 3-хзначное число");
int n = int.Parse(Console.ReadLine()!);
while (n >= 100)
{
    n /= 10;
}
int result = n % 10;
Console.WriteLine($"{result}");