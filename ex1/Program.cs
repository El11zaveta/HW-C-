// Подсчитать сумму цифр в числе/
Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine()!);
int n1 = n % 10;
int sum = 0;

while(n / 10 !=0)
{
    n = n / 10;
    sum = sum + n % 10;
}
Console.WriteLine(sum + n1);