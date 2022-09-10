// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Revers(int number) // Описываем метод реверса числа
{
    int result = 0;

    while (number > 0)
    {
        result *= 10;
        result += number % 10;
        number /= 10;
    }
    return result;
}

if (num >= 10000 && num <= 99999)
{
    int reversNum = Revers(num); // Метод возвращает реверс введённого числа

    if (num == reversNum) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
else Console.WriteLine("Введено некоректное число");