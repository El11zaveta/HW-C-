// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите натуральное число больше 1:");
int n = int.Parse(Console.ReadLine());
void NumberCounter(int n)
{
    if (n < 0) Console.Write($"{n} не натуральное число");
    if (n == 0) return;
    Console.Write("{0,4}", n);
    NumberCounter(n - 1);
}

NumberCounter(n);