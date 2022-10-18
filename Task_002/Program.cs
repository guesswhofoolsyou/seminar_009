/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int GetSum(int m, int n)
{
    if (m >= n)
    {
        return m;
    }
    return (m + GetSum(m + 1, n));
}

int m = GetNumber("Введите число:");
int n = GetNumber("Введите число:");
Console.WriteLine();
Console.WriteLine("Сумма элементов от "+ m+" до "+n+" : " +GetSum(m, n));