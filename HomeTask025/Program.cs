// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число a: ");
Console.WriteLine("Введите число b: ");

double a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
double result = 1;

for (int i = 0; i < b; i++)
{
    result = result * a;
}
Console.WriteLine(result);