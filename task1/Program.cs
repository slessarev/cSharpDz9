// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int DiapasoneNumbers(int n)
{
    if (n == 0) return n;
    else
    {
        Console.Write(n + ", ");
        return DiapasoneNumbers(n - 1);
    }
}

DiapasoneNumbers(EnterData("Введите число N: "));