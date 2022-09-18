// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа СТРОГО через запятую: ");

string txt = Console.ReadLine();

int NumbersCount(string text)
{
    char delimiterChar = ',';
    string[] numbers = text.Split(delimiterChar);

    int count = default;
    int num;

    foreach (var number in numbers)
    {
        num = Convert.ToInt32(number);
        if (num > 0) count++;
    }
    return count;
}

int count = NumbersCount(txt);
Console.WriteLine($"Количество чисел больше 0 -> {count}");