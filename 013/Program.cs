// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число ");
int n = int.Parse(Console.ReadLine()!);
int result = 0;
if (n >= 100)
{
    while (n > 999)
    {
        n = n / 10;
    }
    result = n % 10;
}
Console.WriteLine($"{result}");