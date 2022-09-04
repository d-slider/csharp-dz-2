// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int digit;

if (num < 0) num = num * (-1); // Если число отрицательное, преобразуем его в такое же положительное

if (num < 100)
{
    Console.Write($"Третьей цифры нет числа {number} нет");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    digit = num % 10;  //  326 -> 6
    Console.Write($"Третья цифра числа: {number} = {digit}");
}