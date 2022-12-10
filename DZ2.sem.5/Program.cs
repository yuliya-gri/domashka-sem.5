﻿int[] MyArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-99, 100);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int ElSumm(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i+=2)
    {
        sum = sum + array[i];         
    }
    return sum;
}
Console.WriteLine("Введите размерность массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = MyArray(size);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях {ElSumm(array)}");