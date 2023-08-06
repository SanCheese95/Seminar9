// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    {
        if (num1 > 0 && num2 == 0) return Akkerman(num1 - 1, 1);
        else return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    }
}

int GetInfo(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int num1 = GetInfo("Введите число m: ");
int num2 = GetInfo("Введите число n: ");
Console.WriteLine($"m = {num1}; n = {num2} -> {Akkerman(num1, num2)}");