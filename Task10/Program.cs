// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit;

if (number > 99 && number < 1000)
{
    digit = number % 100;  //  456 -> 56
    digit = digit / 10;    //  56  -> 5

    Console.Write($"Вторая цифра числа: {number} = {digit}");
}
else
    Console.Write("Вы ввели не трёхзначное число!");