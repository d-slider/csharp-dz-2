// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    double random;
    for (int i = 0; i < size; i++)
    {
        random = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(random, 1, MidpointRounding.ToZero);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double DifferenceMaxMinValue(double[] array)
{
    double difference, min = array[0], max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    difference = max - min;

    return Math.Round(difference, 1, MidpointRounding.ToZero);
}

double[] array = CreateArrayRndDouble(5, 0, 100);
PrintArray(array);

double difference = DifferenceMaxMinValue(array);
Console.Write($" -> {difference}");