//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//ЗНАЧЕНИЯ ДОЛЖЕН ВВОДИТЬ ПОЛЬЗОВАТЕЛЬ

Console.Clear();

Console.WriteLine("Введите первое число массива: ");
Console.WriteLine("Введите второе число массива: ");
Console.WriteLine("Введите третье число массива: ");
Console.WriteLine("Введите четвертое число массива: ");
Console.WriteLine("Введите пятое число массива: ");
Console.WriteLine("Введите шестое число массива: ");
Console.WriteLine("Введите седьмое число массива: ");
Console.WriteLine("Введите восьмое число массива: ");

int[] array = new int[8];
for ( int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");