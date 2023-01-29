// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7 ");
int n = int.Parse(Console.ReadLine()!);
if (n < 6)
{
    Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Да");
}
if (n < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
if (n > 7)
{
    Console.WriteLine("Нет такого дня недели");
}