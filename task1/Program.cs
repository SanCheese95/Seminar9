// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NaturalNumber(int n, int m)
{
    if (n == m) return n;
    else return NaturalNumber(n, m + 1);
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int n = GetInfo("Введите число N: ");
Console.WriteLine($"N = {n} -> {NaturalNumber(n, 1)}");