// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void ReverseArrayFor(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }
}

void ReverseArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;

    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}


Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int Convert_number(int number)
{
    int result = 0;
    int count = 1;
    while (number != 0)
    {
        result = (number % 2) * count + result;
        number /= 2;
        count *= 10;
    }
    return result;
}


Console.WriteLine($"{Convert_number(num1)}");

Console.Write("Введите целое число для поиска в скрытом массиве: ");
while (!int.TryParse(Console.ReadLine(), out value))
{
    Console.Write("Ошибка ввода. Введите целое число: ");
}


bool restart = true;
while (restart)
{
    Console.WriteLine("Повторить?");
    Console.Write("'Enter' - Да. Что-то другое - Выход.");
    restart = Console.ReadKey().Key == ConsoleKey.Enter;
}


// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
int num = default;
Console.Write("Введите целое число: ");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.Write("Ошибка ввода. \nВведите целое число: ");
}

int ConvertNumber(int number)
{
    int result = 0;
    int count = 1;
    while (number != 0)
    {
        result += (number % 2) * count;
        number /= 2;
        count *= 10;
    }
    return result;
}

Console.Write(ConvertNumber(num));



// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] CoppyArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
    }
    return arr2;
}

int[] arr = CreateArrayRndInt(9, 1, 10);
PrintArray(arr);
Console.WriteLine();
int[] arrcoppy = CoppyArray(arr);
PrintArray(arrcoppy);
// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] Febonachi(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] arr = Febonachi(num);
PrintArray(arr);

/ Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[] CopyArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
    }
    return arr2;
}

int[] arr = CreateArrayRndInt(9, 1, 10);
PrintArray(arr);
Console.WriteLine();
int[] arrCopy = CopyArray(arr);
arrCopy[0] = 100;
PrintArray(arrCopy);