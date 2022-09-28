// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

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
        Console.Write("["); 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | "); 
            else Console.Write($"{matrix[i, j],3} "); 
        } 
        Console.WriteLine("]"); 
    } 
} 
 
void PrintArrayDouble(double[] array) 
{ 
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1),3} | "); 
        else Console.Write($"{Math.Round(array[i], 1),3}"); 
    } 
    Console.Write(" ]"); 
} 
 
double[] ColumnArithmeticMean(int[,] matrix) 
{ 
    double[] ArithmeticMean = new double[matrix.GetLength(1)]; 
    double rowSum; 
 
    for (int j = 0; j < matrix.GetLength(1); j++) 
    { 
        rowSum = 0; 
        for (int i = 0; i < matrix.GetLength(0); i++) 
        { 
            rowSum += matrix[i, j]; 
        } 
        ArithmeticMean[j] = rowSum / matrix.GetLength(0); 
    } 
    return ArithmeticMean; 
} 
Console.Clear(); 
int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10); 
PrintMatrix(array2D); 
 
Console.WriteLine(); 
double[] arithmeticMean = ColumnArithmeticMean(array2D); 
PrintArrayDouble(arithmeticMean);