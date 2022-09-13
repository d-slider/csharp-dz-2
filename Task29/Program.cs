// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] arr = new int[8];

void FillArray(int[] array)
{
    Random rnd = new Random();
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[count-1]}]");
}

FillArray(arr);
PrintArray(arr);