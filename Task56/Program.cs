// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 2} ");
            else Console.Write($"{matrix[i, j], 2}");
        }
        Console.WriteLine(" |");
    }
}

int[] CalcSum(int[,] matrix)
{
    int[] arrayResultSum = new int[matrix.GetLength(1)];
    int columnsSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        columnsSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            columnsSum += matrix[i, j];
        }
        arrayResultSum[i] = columnsSum;
    }
    return arrayResultSum;
}

void FindMinSum(int[] array)
{
    int min = array[0];
    int indexmin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexmin = i;
        }
    }
    Console.WriteLine($"Min sum string is {indexmin + 1}");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Sum {i + 1} = {array[i], 2} ");
    }
}

int[,] matrix = CreateMatrix(4, 4, 1, 10);
Console.Clear();
Printmatrix(matrix);

Console.WriteLine();
int[] array = CalcSum(matrix);
PrintArray(array);

Console.WriteLine();
FindMinSum(array);