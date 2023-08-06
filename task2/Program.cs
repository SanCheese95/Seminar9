// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfElements(int num1, int num2)
{
    if (num1 == num2) return num1;
    else return SumOfElements(num1 + 1, num2) + num1;
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int num1 = GetInfo("Введите число M: ");
int num2 = GetInfo("Введите число N: ");
Console.WriteLine($"M = {num1}; N = {num2} -> {SumOfElements(num1, num2)}");