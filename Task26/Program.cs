// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


int CountDigits(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int count = default;
        while (num > 0)
        {
            num = num / 10;
            count++;
        }
        return count;
    }
    return 1;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);
Console.WriteLine(result);