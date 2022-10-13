// Напишите программу, которая принимает 
//на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Clear();
Console.WriteLine("Введите число: ");

double n = Convert.ToInt32(Console.ReadLine());
//int n = Convert.ToInt32(Console.ReadLine());
// int i = 1, result = 0;
// while (i<= n)
// {
//     result += i;
//     i++;
// }
// Console.WriteLine(result);
Console.WriteLine((1 + n) / 2 * n);