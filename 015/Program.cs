// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7 ");
int n = int.Parse(Console.ReadLine()!);
if (n <= 6)
{
    Console.WriteLine("Да");
}
else if (n <= 5)
{
    Console.WriteLine("Нет");
}
else if (n > 7)
{
    Console.WriteLine("Вы ошиблись");
}