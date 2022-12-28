// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int SummOfDiapasone(int m, int n)
{
    if (n == m) return n;
    return (n + SummOfDiapasone(m, n - 1));
}

int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");
Console.WriteLine(SummOfDiapasone(m, n));