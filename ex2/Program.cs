// Написать программу вычисления произведения чисел от 1 до N.
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int f = 1;
int a = 1;

while (a <= n)
{
    f = f * a;
    Console.Write($"{f} ");
    a++;
}
Console.WriteLine($" = {f}");