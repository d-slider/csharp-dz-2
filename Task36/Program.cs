﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

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

int ОddElementSum(int[] array)
{
    int oddSum = default;
        
    for (int i = 0; i < array.Length; i++) 
    {
        if(i % 2 != 0) oddSum += array[i];
    }
    return oddSum;
}

int[] array = CreateArrayRndInt(4, -9, 9);
PrintArray(array);
int oddSum = ОddElementSum(array);

Console.Write($" -> {oddSum}");