// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int PowerXY(int x1, int y1)
{
    int pow = 1;
    
    for (int i = 0; i < y1; i++)
    {
        pow *= x1; 
    }
    return pow;
}

Console.Write("Введите число Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int pow = PowerXY(x,y);
Console.Write($"Число {x} в степени {y} = {pow}");