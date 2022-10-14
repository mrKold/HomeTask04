

Console.Clear();

Console.WriteLine("Введите числа: ");

int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int secondmax = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max)
    {
        secondmax = max;
        max = n;
    }
    else if (n > secondmax)
    {
        secondmax = n;
    }
}

Console.WriteLine(secondmax);