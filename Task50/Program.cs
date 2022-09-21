// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

void PrintMatrixElement(int[,] matrix, int row, int column)
{
    if (row > 0 && column > 0)
    {  // Номер строки и номер столбца должны быть больше 0
        if (row <= matrix.GetLength(0) && column <= matrix.GetLength(1))
        { // Номер строки и номер столбца должны быть меньше размера матрицы
            Console.WriteLine($"Значение элемента массива: {matrix[row - 1, column - 1]}");
        }
        else Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine("Такого элемента в массиве нет");
}

Console.Clear();

Console.Write("Введите номер строки элемента массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца элемента массива: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 99);

PrintMatrix(array2D);
PrintMatrixElement(array2D, row, column);