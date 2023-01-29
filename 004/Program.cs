// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int N2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int N3 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2)
{
    if (N1 > N3)
    {
        Console.WriteLine("Максимальное число: " + N1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + N3);
    }
}

else if (N2 > N3)
{
    Console.WriteLine("Максимальное число: " + N2);
}
else
{
    Console.WriteLine("Максимальное число: " + N3);
}