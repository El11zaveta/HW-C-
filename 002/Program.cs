// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите два числа ");
int a, b;
Console.WriteLine("Введте первое число: ");
a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введиет второе число: ");
b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else if (a < b)
{
    Console.WriteLine($"Число {b} больше числа {a}");
}