/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintNums(int num)
{
    if (num < 1)
        return;
    Console.Write(num + ", ");
    PrintNums(num - 1);
}

int n = GetNumber("Введите число:");
PrintNums(n);