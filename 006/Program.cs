// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

num = num % 2;
if(num % 2 != 0)
{
    Console.WriteLine("Нечётное число");
}
else
{
    Console.WriteLine("Чётное число");
}