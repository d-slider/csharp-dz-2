// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeTable(int digit)
{
    int count = 1;

    while (count <= digit)
    {
        Console.WriteLine($"|{count} - {count * count * count, 3}|");
        count++;
    }
}
CubeTable(number);