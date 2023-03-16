// * Задача 2:*Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Write("Введите число M: ");
int m = int.Parse(ReadLine());

Write("Введите число N: ");
int n = int.Parse(ReadLine());

GetSum(m, n);

void GetSum(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}