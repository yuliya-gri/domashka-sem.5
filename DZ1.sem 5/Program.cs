int[] MyArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
int ArrCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] % 2) ==0)
        {
            count =count + 1;
            
        }
    }
    return count;
}
Console.WriteLine("Введите размерность масива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = MyArray(size);
PrintArray(array);
Console.WriteLine("");
Console.WriteLine($"количество четных чисел в масиве {ArrCount(array)}");