//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//ЗНАЧЕНИЯ ДОЛЖЕН ВВОДИТЬ ПОЛЬЗОВАТЕЛЬ

Console.Clear();

Console.WriteLine("Введите массив из 8-ми чисел: ");


int[] array = new int[8];
for ( int i = 0; i < 8; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"[{string.Join(", ", array)}]");