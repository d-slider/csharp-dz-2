﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1
// y = k2 * x + b2
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// double b1 = 2; // 2 // 2 // 3
// double k1 = 5; // 2 // 1 // 1
// double b2 = 4; // 3 // 3 // 3
// double k2 = 9; // 1 // 1 // 1

Console.Clear();

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void CalculateCrossPoint(double b1, double k1, double b2, double k2)
{
    double crossPointX = (b2 - b1) / (k1 - k2);
    double crossPointY = (k2 * b1 - b2 * k1) / (k2 - k1);
    
    Console.WriteLine($"Координата точки пересечения двух прямых равна ({Math.Round(crossPointX, 1)}; {Math.Round(crossPointY, 1)})");
}
CalculateCrossPoint(b1, k1, b2, k2);