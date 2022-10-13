// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
int i = 0;

while (n > 0)
{
    i = n % 10;
    n = n / 10;
    result = result + i;
}
Console.WriteLine(result);