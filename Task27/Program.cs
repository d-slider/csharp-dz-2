// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int CountDigits(int num)
{
    if (num != 0)
    {
        if (num < 0) num = -num;
        int sum = default;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
    return 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(number);
Console.WriteLine(result);