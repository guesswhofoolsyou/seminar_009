/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int AkkerFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return AkkerFunc(m - 1, 1);
    }
    else
    {
        return AkkerFunc(m - 1, AkkerFunc(m, n - 1));
    }
}

int m = GetNumber("Введите число:");
int n = GetNumber("Введите число:");
Console.WriteLine();
Console.WriteLine($"A({m},{n})" + AkkerFunc(m, n));