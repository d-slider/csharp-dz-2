// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();
Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] ProductPairsDigit(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size += 1;
    int[] newArray = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }

    if (newArray.Length % 2 != 0) newArray[newArray.Length - 1] = array[array.Length / 2];
    return newArray;
}
Console.WriteLine();
int[] arr = CreateArrayRndInt(5, 1, 5);
PrintArray(arr);
int[] result = ProductPairsDigit(arr);
Console.WriteLine();
PrintArray(result);
Console.WriteLine();