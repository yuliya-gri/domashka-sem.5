double[] MyArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble()*100;
    return array;
}
void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = MyArray(size);
PrintArray(array);
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");