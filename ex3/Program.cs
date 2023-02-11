// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число ");
int n = int.Parse(Console.WriteLine()!);
int a = 1;
int cub = 1;

while (a < n)
{
    cub = a * a * a;
    if (cub % 2 == 0)
    {
        Console.Write($"{cub}");
    }
} 
a++;
Console.WriteLine($"{cub}");