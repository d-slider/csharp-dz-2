// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumMN(int m, int n)
{
    int result = m;
    
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumMN(m, n);
        return result;
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(SumMN(m - 1, n));