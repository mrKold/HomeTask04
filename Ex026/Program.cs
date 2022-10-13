// Напишите программу, которая принимает 
//на вход число и выдаёт количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (n > 0)
{
    n = n / 10;
    result = result + 1;
}
Console.WriteLine(result);
