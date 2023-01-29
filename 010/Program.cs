// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите 3-хзначное число");
var n = Math.Abs(Convert.ToInt64(Console.ReadLine()));
while (n >= 100)
{
    n /= 10;
}
var r = n % 10;
Console.WriteLine(r);